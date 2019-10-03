using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Prodavnica
{
    public partial class Form1 : Form
    {
        OleDbDataAdapter adapter_artikal;
        OleDbDataAdapter adapter_grupa;
        OleDbDataAdapter adapter_racun;
        DataTable racun;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();

            adapter_grupa = new OleDbDataAdapter("select * from Grupa", @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\Users\petar\Documents\SKOLA\Treca godina\TVP\Projekat_septembar\Prodavnica\Prodavnica.mdb");
            adapter_artikal = new OleDbDataAdapter("select * from Artikal", @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\Users\petar\Documents\SKOLA\Treca godina\TVP\Projekat_septembar\Prodavnica\Prodavnica.mdb");
            adapter_racun = new OleDbDataAdapter("select * from Racun", @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\Users\petar\Documents\SKOLA\Treca godina\TVP\Projekat_septembar\Prodavnica\Prodavnica.mdb");

            OleDbCommandBuilder cmdBuild = new OleDbCommandBuilder(adapter_artikal);
            adapter_artikal.InsertCommand = cmdBuild.GetInsertCommand();
            adapter_artikal.UpdateCommand = cmdBuild.GetUpdateCommand();
            adapter_artikal.DeleteCommand = cmdBuild.GetDeleteCommand();

            cmdBuild = new OleDbCommandBuilder(adapter_racun);
            adapter_racun.InsertCommand = cmdBuild.GetInsertCommand();
            adapter_racun.UpdateCommand = cmdBuild.GetUpdateCommand();
            adapter_racun.DeleteCommand = cmdBuild.GetDeleteCommand();

            OleDbDataAdapter da = new OleDbDataAdapter("select * from Grupa ;select * from Artikal; select * from Racun", @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\Users\petar\Documents\SKOLA\Treca godina\TVP\Projekat_septembar\Prodavnica\Prodavnica.mdb");

            ds = new DataSet();

            adapter_grupa.Fill(ds, "Grupa");
            adapter_artikal.Fill(ds, "Artikal");
            adapter_racun.Fill(ds, "Racun");

            cbKategorija.DataSource = ds.Tables["Grupa"];
            cbKategorija.DisplayMember = "Naziv";
            cbKategorija.ValueMember = "id_grupa";
            PopuniRacun();            
        }
        private void PopuniRacun()
        {
            racun = new DataTable();

            racun.Columns.Add("id_artikla");
            racun.Columns.Add("Naziv");
            racun.Columns.Add("Poj. Cena", typeof(decimal));
            racun.Columns.Add("Kolicina", typeof(Int32));
            racun.Columns.Add("Popust", typeof(bool));
            racun.Columns.Add("%Popust", typeof(int));
            racun.Columns.Add("Uk. Cena", typeof(decimal));

            dgvRacun.DataSource = racun;            
        }

        private void cbKategorija_SelectedValueChanged(object sender, EventArgs e)
        {
            IEnumerable<DataRow> rows = ds.Tables["Artikal"].Rows.Cast<DataRow>();
            IEnumerable<DataRow> rez = rows.Where(x => (x["id_grupa"]).Equals(cbKategorija.SelectedValue));

            DataTable dtrez = new DataTable();
            if (rez.Count() > 0)
            {
                dtrez = rez.CopyToDataTable();
            }
            dgvArtikli.DataSource = dtrez;
        }

        private void btnNoviArtikal_Click(object sender, EventArgs e)
        {
            FrmNoviArtikal n = new FrmNoviArtikal(ds, adapter_artikal);
            n.Show();
        }

        private void btnDodajNaRacun_Click(object sender, EventArgs e)
        {
            int index = dgvArtikli.CurrentCell.RowIndex;

            DataGridViewRow selectedRow = dgvArtikli.Rows[index];
            DataRow dr = racun.NewRow();

            dr["id_artikla"] = selectedRow.Cells[0].Value.ToString();
            dr["naziv"] = selectedRow.Cells[1].Value.ToString();
            dr["poj. cena"] = selectedRow.Cells[2].Value;
            dr["%Popust"] = selectedRow.Cells[3].Value;
            dr["kolicina"] = nudKolicina.Value;
            dr["Popust"] = false;
            double cena = Convert.ToDouble(selectedRow.Cells[2].Value);
            int kolicina = (int)nudKolicina.Value;
            double ukupna_cena = cena * kolicina;

            dr["Uk. Cena"] = ukupna_cena;

            double ukupna_cena_racuna = Double.Parse(lblUkupno.Text) + ukupna_cena;
            lblUkupno.Text = ukupna_cena_racuna.ToString();

            racun.Rows.Add(dr);
            dgvRacun.DataSource = racun;
            nudKolicina.Value = 1;
        }

        private void dgvRacun_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRacun.CurrentCell.ValueType == typeof(bool))
            {
                DataGridViewRow row = dgvRacun.Rows[dgvRacun.CurrentCell.RowIndex];
                row.Cells["Popust"].Value = !((bool)row.Cells["Popust"].Value);

                double cenaPoKomadu = Double.Parse(row.Cells["poj. cena"].Value.ToString());
                double popust = Double.Parse(row.Cells["%Popust"].Value.ToString());
                double kolicina = Double.Parse(row.Cells["kolicina"].Value.ToString());
                double ukupna_cena = Double.Parse(row.Cells["Uk. Cena"].Value.ToString());
                lblUkupno.Text = (Double.Parse(lblUkupno.Text) - ukupna_cena).ToString();

                if ((bool)row.Cells["Popust"].Value)
                {
                    row.Cells["Uk. Cena"].Value = (cenaPoKomadu - cenaPoKomadu * popust / 100) * kolicina;
                    lblUkupno.Text = (Double.Parse(lblUkupno.Text) + Double.Parse(row.Cells["Uk. Cena"].Value.ToString())).ToString();
                }
                else
                {
                    row.Cells["Uk. Cena"].Value = cenaPoKomadu * kolicina;
                    lblUkupno.Text = (Double.Parse(lblUkupno.Text) + Double.Parse(row.Cells["Uk. Cena"].Value.ToString())).ToString();
                }
            }
        }

        private void btnObrisiStavku_Click(object sender, EventArgs e)
        {
            int index = dgvRacun.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dgvRacun.Rows[index];

            double cena = Convert.ToDouble(selectedRow.Cells[2].Value);
            int kolicina = Convert.ToInt32(selectedRow.Cells[3].Value);
            double ukupna_cena = cena * kolicina;
            double ukupna_cena_racuna = Double.Parse(lblUkupno.Text) - ukupna_cena;
            lblUkupno.Text = ukupna_cena_racuna.ToString();

            dgvRacun.Rows.Remove(selectedRow);            
        }

        private void btnSnimiRacun_Click(object sender, EventArgs e)
        {
            DataRow row;
            double cena = 0;            

            for (int i = 0; i < dgvRacun.Rows.Count; i++)
            {
                cena+= Double.Parse(dgvRacun.Rows[i].Cells["Uk. Cena"].Value.ToString());
            }
            row = ds.Tables["Racun"].NewRow();
            row["cena"] = cena;
            row["datum"] = DateTime.Now.ToString("dd/MM/yyyy");
            row["vreme"] = DateTime.Now.ToString("HH:mm");
            ds.Tables["racun"].Rows.Add(row);

            try
            {
                adapter_racun.Update(ds.Tables["racun"]);
                dgvRacun.DataSource = null;
                PopuniRacun();
                lblUkupno.Text = "0.00";
                MessageBox.Show("Vas racun je uspesno snimljen!");
            }
            catch (Exception)
            {

                MessageBox.Show("Podaci o racunu nisu snimljeni u bazu!");
            }
        }

        private void btnPregledRacuna_Click(object sender, EventArgs e)
        {
            PregledRacuna p = new PregledRacuna(ds, adapter_racun);
            p.Show();            
        }
    }
}
