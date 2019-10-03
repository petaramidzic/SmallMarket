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
    public partial class PregledRacuna : Form
    {
        DataSet ds;
        OleDbDataAdapter da;

        public PregledRacuna(DataSet _ds, OleDbDataAdapter _da)
        {
            InitializeComponent();
            ds = _ds;
            da = _da;
            //ucitavam podatke iz baze jer ako sam u medjuvremenu dodao novi racun nemam id u ispisu
            ds.Tables["Racun"].Clear();
            da.Fill(ds, "Racun");
            dgvRacuni.DataSource = ds.Tables["Racun"];
        }

        private void Filter()
        {
            DateTime datum_od = dtpOd.Value;
            DateTime datum_do = dtpDo.Value;

            DataSet filter = new DataSet();

            IEnumerable<DataRow> rows = ds.Tables["Racun"].Rows.Cast<DataRow>();
            IEnumerable<DataRow> rez = rows.Where(x => ((DateTime)x["datum"]) >= datum_od && ((DateTime)x["datum"]) <= datum_do);

            if (datum_do<datum_od)
            {
                MessageBox.Show("Datum \"Do\" ne moze biti veci od datuma \"Od\" ");
            }
            else
            {
                DataTable dtrez = new DataTable();
                if (rez.Count() > 0)
                {
                    dtrez = rez.CopyToDataTable();
                }
                else
                {
                    dtrez.Columns.Add("id_racun");
                    dtrez.Columns.Add("cena");
                    dtrez.Columns.Add("datum");
                    dtrez.Columns.Add("vreme");
                }
                dgvRacuni.DataSource = dtrez;
            }            
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            dgvRacuni.DataSource = ds.Tables["Racun"];
            dtpOd.Value = DateTime.Now;
            dtpDo.Value = DateTime.Now;
            da.Fill(ds, "Racun");
            dgvRacuni.DataSource = null;
            dgvRacuni.DataSource = ds.Tables["Racun"];
        }

        private void dtpOd_ValueChanged(object sender, EventArgs e)
        {
            dtpDo.Value = dtpOd.Value.AddDays(1);
        }        
    }
}
