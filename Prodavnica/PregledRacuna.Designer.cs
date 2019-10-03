namespace Prodavnica
{
    partial class PregledRacuna
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
            this.dtpOd = new System.Windows.Forms.DateTimePicker();
            this.dtpDo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOd = new System.Windows.Forms.Label();
            this.lblDo = new System.Windows.Forms.Label();
            this.dgvRacuni = new System.Windows.Forms.DataGridView();
            this.gpFilter = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnResetFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).BeginInit();
            this.gpFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpOd
            // 
            this.dtpOd.Location = new System.Drawing.Point(24, 32);
            this.dtpOd.Name = "dtpOd";
            this.dtpOd.Size = new System.Drawing.Size(200, 20);
            this.dtpOd.TabIndex = 0;
            this.dtpOd.ValueChanged += new System.EventHandler(this.dtpOd_ValueChanged);
            // 
            // dtpDo
            // 
            this.dtpDo.Location = new System.Drawing.Point(24, 92);
            this.dtpDo.Name = "dtpDo";
            this.dtpDo.Size = new System.Drawing.Size(200, 20);
            this.dtpDo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pregled Racuna";
            // 
            // lblOd
            // 
            this.lblOd.AutoSize = true;
            this.lblOd.Location = new System.Drawing.Point(21, 16);
            this.lblOd.Name = "lblOd";
            this.lblOd.Size = new System.Drawing.Size(24, 13);
            this.lblOd.TabIndex = 3;
            this.lblOd.Text = "Od:";
            // 
            // lblDo
            // 
            this.lblDo.AutoSize = true;
            this.lblDo.Location = new System.Drawing.Point(21, 76);
            this.lblDo.Name = "lblDo";
            this.lblDo.Size = new System.Drawing.Size(24, 13);
            this.lblDo.TabIndex = 4;
            this.lblDo.Text = "Do:";
            // 
            // dgvRacuni
            // 
            this.dgvRacuni.AllowUserToAddRows = false;
            this.dgvRacuni.AllowUserToDeleteRows = false;
            this.dgvRacuni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRacuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacuni.Location = new System.Drawing.Point(105, 197);
            this.dgvRacuni.Name = "dgvRacuni";
            this.dgvRacuni.Size = new System.Drawing.Size(571, 218);
            this.dgvRacuni.TabIndex = 5;
            // 
            // gpFilter
            // 
            this.gpFilter.Controls.Add(this.btnResetFilter);
            this.gpFilter.Controls.Add(this.btnFilter);
            this.gpFilter.Controls.Add(this.lblOd);
            this.gpFilter.Controls.Add(this.dtpOd);
            this.gpFilter.Controls.Add(this.lblDo);
            this.gpFilter.Controls.Add(this.dtpDo);
            this.gpFilter.Location = new System.Drawing.Point(105, 62);
            this.gpFilter.Name = "gpFilter";
            this.gpFilter.Size = new System.Drawing.Size(336, 129);
            this.gpFilter.TabIndex = 6;
            this.gpFilter.TabStop = false;
            this.gpFilter.Text = "Filter";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(249, 28);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 5;
            this.btnFilter.Text = "Filtriraj";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnResetFilter
            // 
            this.btnResetFilter.Location = new System.Drawing.Point(249, 92);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(75, 23);
            this.btnResetFilter.TabIndex = 6;
            this.btnResetFilter.Text = "Ponisti Filter";
            this.btnResetFilter.UseVisualStyleBackColor = true;
            this.btnResetFilter.Click += new System.EventHandler(this.btnResetFilter_Click);
            // 
            // PregledRacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpFilter);
            this.Controls.Add(this.dgvRacuni);
            this.Controls.Add(this.label1);
            this.Name = "PregledRacuna";
            this.Text = "PregledRacuna";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).EndInit();
            this.gpFilter.ResumeLayout(false);
            this.gpFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpOd;
        private System.Windows.Forms.DateTimePicker dtpDo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOd;
        private System.Windows.Forms.Label lblDo;
        private System.Windows.Forms.DataGridView dgvRacuni;
        private System.Windows.Forms.GroupBox gpFilter;
        private System.Windows.Forms.Button btnResetFilter;
        private System.Windows.Forms.Button btnFilter;
    }
}