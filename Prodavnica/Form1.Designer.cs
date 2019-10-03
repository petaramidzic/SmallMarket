namespace Prodavnica
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelRacun = new System.Windows.Forms.Panel();
            this.lblUkupno = new System.Windows.Forms.Label();
            this.lblRacunUkupno = new System.Windows.Forms.Label();
            this.btnPregledRacuna = new System.Windows.Forms.Button();
            this.btnObrisiStavku = new System.Windows.Forms.Button();
            this.btnSnimiRacun = new System.Windows.Forms.Button();
            this.dgvRacun = new System.Windows.Forms.DataGridView();
            this.lblRacun = new System.Windows.Forms.Label();
            this.cbKategorija = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvArtikli = new System.Windows.Forms.DataGridView();
            this.btnDodajNaRacun = new System.Windows.Forms.Button();
            this.nudKolicina = new System.Windows.Forms.NumericUpDown();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.btnNoviArtikal = new System.Windows.Forms.Button();
            this.panelRacun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKolicina)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRacun
            // 
            this.panelRacun.Controls.Add(this.lblUkupno);
            this.panelRacun.Controls.Add(this.lblRacunUkupno);
            this.panelRacun.Controls.Add(this.btnPregledRacuna);
            this.panelRacun.Controls.Add(this.btnObrisiStavku);
            this.panelRacun.Controls.Add(this.btnSnimiRacun);
            this.panelRacun.Controls.Add(this.dgvRacun);
            this.panelRacun.Controls.Add(this.lblRacun);
            this.panelRacun.Location = new System.Drawing.Point(446, 12);
            this.panelRacun.Name = "panelRacun";
            this.panelRacun.Size = new System.Drawing.Size(464, 336);
            this.panelRacun.TabIndex = 0;
            // 
            // lblUkupno
            // 
            this.lblUkupno.AutoSize = true;
            this.lblUkupno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUkupno.Location = new System.Drawing.Point(241, 306);
            this.lblUkupno.Name = "lblUkupno";
            this.lblUkupno.Size = new System.Drawing.Size(36, 18);
            this.lblUkupno.TabIndex = 6;
            this.lblUkupno.Text = "0.00";
            // 
            // lblRacunUkupno
            // 
            this.lblRacunUkupno.AutoSize = true;
            this.lblRacunUkupno.Location = new System.Drawing.Point(155, 312);
            this.lblRacunUkupno.Name = "lblRacunUkupno";
            this.lblRacunUkupno.Size = new System.Drawing.Size(81, 13);
            this.lblRacunUkupno.TabIndex = 5;
            this.lblRacunUkupno.Text = "Racun ukupno:";
            // 
            // btnPregledRacuna
            // 
            this.btnPregledRacuna.Location = new System.Drawing.Point(4, 271);
            this.btnPregledRacuna.Name = "btnPregledRacuna";
            this.btnPregledRacuna.Size = new System.Drawing.Size(75, 62);
            this.btnPregledRacuna.TabIndex = 4;
            this.btnPregledRacuna.Text = "Pregled svih racuna";
            this.btnPregledRacuna.UseVisualStyleBackColor = true;
            this.btnPregledRacuna.Click += new System.EventHandler(this.btnPregledRacuna_Click);
            // 
            // btnObrisiStavku
            // 
            this.btnObrisiStavku.Location = new System.Drawing.Point(158, 271);
            this.btnObrisiStavku.Name = "btnObrisiStavku";
            this.btnObrisiStavku.Size = new System.Drawing.Size(76, 23);
            this.btnObrisiStavku.TabIndex = 3;
            this.btnObrisiStavku.Text = "Obrisi stavku";
            this.btnObrisiStavku.UseVisualStyleBackColor = true;
            this.btnObrisiStavku.Click += new System.EventHandler(this.btnObrisiStavku_Click);
            // 
            // btnSnimiRacun
            // 
            this.btnSnimiRacun.Location = new System.Drawing.Point(386, 271);
            this.btnSnimiRacun.Name = "btnSnimiRacun";
            this.btnSnimiRacun.Size = new System.Drawing.Size(75, 62);
            this.btnSnimiRacun.TabIndex = 2;
            this.btnSnimiRacun.Text = "Snimi racun";
            this.btnSnimiRacun.UseVisualStyleBackColor = true;
            this.btnSnimiRacun.Click += new System.EventHandler(this.btnSnimiRacun_Click);
            // 
            // dgvRacun
            // 
            this.dgvRacun.AllowUserToAddRows = false;
            this.dgvRacun.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRacun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacun.Location = new System.Drawing.Point(3, 33);
            this.dgvRacun.Name = "dgvRacun";
            this.dgvRacun.Size = new System.Drawing.Size(458, 232);
            this.dgvRacun.TabIndex = 1;
            this.dgvRacun.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRacun_CellContentClick);
            // 
            // lblRacun
            // 
            this.lblRacun.AutoSize = true;
            this.lblRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRacun.Location = new System.Drawing.Point(206, 10);
            this.lblRacun.Name = "lblRacun";
            this.lblRacun.Size = new System.Drawing.Size(71, 20);
            this.lblRacun.TabIndex = 0;
            this.lblRacun.Text = "RACUN";
            // 
            // cbKategorija
            // 
            this.cbKategorija.FormattingEnabled = true;
            this.cbKategorija.Location = new System.Drawing.Point(30, 93);
            this.cbKategorija.Name = "cbKategorija";
            this.cbKategorija.Size = new System.Drawing.Size(121, 21);
            this.cbKategorija.TabIndex = 1;
            this.cbKategorija.SelectedValueChanged += new System.EventHandler(this.cbKategorija_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Izaberite kategoriju:";
            // 
            // dgvArtikli
            // 
            this.dgvArtikli.AllowUserToAddRows = false;
            this.dgvArtikli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtikli.Location = new System.Drawing.Point(30, 144);
            this.dgvArtikli.Name = "dgvArtikli";
            this.dgvArtikli.Size = new System.Drawing.Size(388, 150);
            this.dgvArtikli.TabIndex = 3;
            // 
            // btnDodajNaRacun
            // 
            this.btnDodajNaRacun.Location = new System.Drawing.Point(30, 309);
            this.btnDodajNaRacun.Name = "btnDodajNaRacun";
            this.btnDodajNaRacun.Size = new System.Drawing.Size(121, 42);
            this.btnDodajNaRacun.TabIndex = 4;
            this.btnDodajNaRacun.Text = "Dodaj artikal na racun";
            this.btnDodajNaRacun.UseVisualStyleBackColor = true;
            this.btnDodajNaRacun.Click += new System.EventHandler(this.btnDodajNaRacun_Click);
            // 
            // nudKolicina
            // 
            this.nudKolicina.Location = new System.Drawing.Point(298, 331);
            this.nudKolicina.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKolicina.Name = "nudKolicina";
            this.nudKolicina.Size = new System.Drawing.Size(120, 20);
            this.nudKolicina.TabIndex = 5;
            this.nudKolicina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Location = new System.Drawing.Point(295, 309);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(47, 13);
            this.lblKolicina.TabIndex = 6;
            this.lblKolicina.Text = "Kolicina:";
            // 
            // btnNoviArtikal
            // 
            this.btnNoviArtikal.Location = new System.Drawing.Point(343, 91);
            this.btnNoviArtikal.Name = "btnNoviArtikal";
            this.btnNoviArtikal.Size = new System.Drawing.Size(75, 23);
            this.btnNoviArtikal.TabIndex = 7;
            this.btnNoviArtikal.Text = "Novi artikal";
            this.btnNoviArtikal.UseVisualStyleBackColor = true;
            this.btnNoviArtikal.Click += new System.EventHandler(this.btnNoviArtikal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 600);
            this.Controls.Add(this.btnNoviArtikal);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.nudKolicina);
            this.Controls.Add(this.btnDodajNaRacun);
            this.Controls.Add(this.dgvArtikli);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbKategorija);
            this.Controls.Add(this.panelRacun);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelRacun.ResumeLayout(false);
            this.panelRacun.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKolicina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelRacun;
        private System.Windows.Forms.Button btnPregledRacuna;
        private System.Windows.Forms.Button btnObrisiStavku;
        private System.Windows.Forms.Button btnSnimiRacun;
        private System.Windows.Forms.DataGridView dgvRacun;
        private System.Windows.Forms.Label lblRacun;
        private System.Windows.Forms.ComboBox cbKategorija;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvArtikli;
        private System.Windows.Forms.Button btnDodajNaRacun;
        private System.Windows.Forms.NumericUpDown nudKolicina;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.Button btnNoviArtikal;
        private System.Windows.Forms.Label lblUkupno;
        private System.Windows.Forms.Label lblRacunUkupno;
    }
}

