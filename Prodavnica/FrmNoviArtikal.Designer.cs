namespace Prodavnica
{
    partial class FrmNoviArtikal
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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtPopust = new System.Windows.Forms.TextBox();
            this.lblPopust = new System.Windows.Forms.Label();
            this.lblCenaArtikla = new System.Windows.Forms.Label();
            this.txtCenaArtikla = new System.Windows.Forms.TextBox();
            this.lblNazivArtikla = new System.Windows.Forms.Label();
            this.txtNazivArtikla = new System.Windows.Forms.TextBox();
            this.lblKategorija = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbKategorija = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(415, 320);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(100, 36);
            this.btnDodaj.TabIndex = 19;
            this.btnDodaj.Text = "Dodaj novi artikal";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtPopust
            // 
            this.txtPopust.Location = new System.Drawing.Point(394, 275);
            this.txtPopust.Name = "txtPopust";
            this.txtPopust.Size = new System.Drawing.Size(121, 20);
            this.txtPopust.TabIndex = 18;
            // 
            // lblPopust
            // 
            this.lblPopust.AutoSize = true;
            this.lblPopust.Location = new System.Drawing.Point(350, 282);
            this.lblPopust.Name = "lblPopust";
            this.lblPopust.Size = new System.Drawing.Size(40, 13);
            this.lblPopust.TabIndex = 17;
            this.lblPopust.Text = "Popust";
            // 
            // lblCenaArtikla
            // 
            this.lblCenaArtikla.AutoSize = true;
            this.lblCenaArtikla.Location = new System.Drawing.Point(289, 244);
            this.lblCenaArtikla.Name = "lblCenaArtikla";
            this.lblCenaArtikla.Size = new System.Drawing.Size(101, 13);
            this.lblCenaArtikla.TabIndex = 16;
            this.lblCenaArtikla.Text = "Unesite cenu artikla";
            // 
            // txtCenaArtikla
            // 
            this.txtCenaArtikla.Location = new System.Drawing.Point(394, 238);
            this.txtCenaArtikla.Name = "txtCenaArtikla";
            this.txtCenaArtikla.Size = new System.Drawing.Size(121, 20);
            this.txtCenaArtikla.TabIndex = 15;
            // 
            // lblNazivArtikla
            // 
            this.lblNazivArtikla.AutoSize = true;
            this.lblNazivArtikla.Location = new System.Drawing.Point(286, 199);
            this.lblNazivArtikla.Name = "lblNazivArtikla";
            this.lblNazivArtikla.Size = new System.Drawing.Size(102, 13);
            this.lblNazivArtikla.TabIndex = 14;
            this.lblNazivArtikla.Text = "Unesite naziv artikla";
            // 
            // txtNazivArtikla
            // 
            this.txtNazivArtikla.Location = new System.Drawing.Point(394, 196);
            this.txtNazivArtikla.Name = "txtNazivArtikla";
            this.txtNazivArtikla.Size = new System.Drawing.Size(121, 20);
            this.txtNazivArtikla.TabIndex = 13;
            // 
            // lblKategorija
            // 
            this.lblKategorija.AutoSize = true;
            this.lblKategorija.Location = new System.Drawing.Point(291, 157);
            this.lblKategorija.Name = "lblKategorija";
            this.lblKategorija.Size = new System.Drawing.Size(99, 13);
            this.lblKategorija.TabIndex = 12;
            this.lblKategorija.Text = "Izaberite kategoriju:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Dodavanje novog artikla";
            // 
            // cbKategorija
            // 
            this.cbKategorija.FormattingEnabled = true;
            this.cbKategorija.Location = new System.Drawing.Point(394, 154);
            this.cbKategorija.Name = "cbKategorija";
            this.cbKategorija.Size = new System.Drawing.Size(121, 21);
            this.cbKategorija.TabIndex = 10;
            // 
            // FrmNoviArtikal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtPopust);
            this.Controls.Add(this.lblPopust);
            this.Controls.Add(this.lblCenaArtikla);
            this.Controls.Add(this.txtCenaArtikla);
            this.Controls.Add(this.lblNazivArtikla);
            this.Controls.Add(this.txtNazivArtikla);
            this.Controls.Add(this.lblKategorija);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbKategorija);
            this.Name = "FrmNoviArtikal";
            this.Text = "FrmNoviArtikal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtPopust;
        private System.Windows.Forms.Label lblPopust;
        private System.Windows.Forms.Label lblCenaArtikla;
        private System.Windows.Forms.TextBox txtCenaArtikla;
        private System.Windows.Forms.Label lblNazivArtikla;
        private System.Windows.Forms.TextBox txtNazivArtikla;
        private System.Windows.Forms.Label lblKategorija;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKategorija;
    }
}