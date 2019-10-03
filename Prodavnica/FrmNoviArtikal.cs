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
    public partial class FrmNoviArtikal : Form
    {
        DataSet ds;
        OleDbDataAdapter da;
        double cena;
        double popust;

        public FrmNoviArtikal(DataSet _ds, OleDbDataAdapter _da)
        {
            InitializeComponent();
            ds = _ds;
            da = _da;
            cbKategorija.DataSource = ds.Tables["Grupa"];
            cbKategorija.DisplayMember = "Naziv";
            cbKategorija.ValueMember = "id_grupa";
        }

        private bool ProveraPoljaUnosa()
        {            
            if (String.IsNullOrEmpty(txtNazivArtikla.Text) && String.IsNullOrWhiteSpace(txtNazivArtikla.Text))
            {
                MessageBox.Show("Morate uneti polje Naziv!");
                return false;
            }  
            if (!Double.TryParse(txtCenaArtikla.Text, out cena))
            {
                MessageBox.Show("Polje \"Cena\" mora biti numericko");
                return false;
            }  
            if (!Double.TryParse(txtPopust.Text, out popust))
            {
                MessageBox.Show("Polje \"Popust\" mora biti numericko");
                return false;
            }
            return true;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DataRow novired = ds.Tables["Artikal"].NewRow();

            if (ProveraPoljaUnosa())
            {
                novired["naziv"] = txtNazivArtikla.Text;
                novired["cena"] = cena.ToString();
                novired["popust"] = popust.ToString();
                novired["id_grupa"] = cbKategorija.SelectedValue;
                ds.Tables["Artikal"].Rows.Add(novired);

                try
                {
                    da.Update(ds.Tables["Artikal"]); //upisuje u bazu
                    ds.Tables["Artikal"].Clear(); //cisti ds
                    da.Fill(ds, "Artikal");  //cita iz baze
                    MessageBox.Show("Uspesno snimljeni podaci!");
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Neuspesan upis u bazu!");
                }                
            }  
        }
    }
}
