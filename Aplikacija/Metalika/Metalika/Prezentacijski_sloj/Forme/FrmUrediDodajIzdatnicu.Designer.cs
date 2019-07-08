namespace Metalika
{
    partial class FrmUrediDodajIzdatnicu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrediDodajIzdatnicu));
            this.btnSpremiPromjene = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDatumIzdatnice = new System.Windows.Forms.DateTimePicker();
            this.cbZaposlenik = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbNalog = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lIdIzdatnica = new System.Windows.Forms.Label();
            this.tbIdIzdatnica = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNapomena = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSpremiPromjene
            // 
            this.btnSpremiPromjene.Location = new System.Drawing.Point(9, 416);
            this.btnSpremiPromjene.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpremiPromjene.Name = "btnSpremiPromjene";
            this.btnSpremiPromjene.Size = new System.Drawing.Size(98, 32);
            this.btnSpremiPromjene.TabIndex = 13;
            this.btnSpremiPromjene.Text = "Save changes";
            this.btnSpremiPromjene.UseVisualStyleBackColor = true;
            this.btnSpremiPromjene.Click += new System.EventHandler(this.BtnSpremiPromjene_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(111, 416);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(2);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(73, 32);
            this.btnOdustani.TabIndex = 14;
            this.btnOdustani.Text = "Cancel";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.BtnOdustani_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Metalika.Properties.Resources.m_logo;
            this.pictureBox1.Location = new System.Drawing.Point(9, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 162);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Update/Add issue note";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpDatumIzdatnice);
            this.groupBox1.Controls.Add(this.cbZaposlenik);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbNalog);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lIdIzdatnica);
            this.groupBox1.Controls.Add(this.tbIdIzdatnica);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbNapomena);
            this.groupBox1.Location = new System.Drawing.Point(223, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(245, 289);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter details:";
            // 
            // dtpDatumIzdatnice
            // 
            this.dtpDatumIzdatnice.Location = new System.Drawing.Point(5, 141);
            this.dtpDatumIzdatnice.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDatumIzdatnice.Name = "dtpDatumIzdatnice";
            this.dtpDatumIzdatnice.Size = new System.Drawing.Size(162, 20);
            this.dtpDatumIzdatnice.TabIndex = 4;
            // 
            // cbZaposlenik
            // 
            this.cbZaposlenik.Enabled = false;
            this.cbZaposlenik.FormattingEnabled = true;
            this.cbZaposlenik.Location = new System.Drawing.Point(4, 180);
            this.cbZaposlenik.Margin = new System.Windows.Forms.Padding(2);
            this.cbZaposlenik.Name = "cbZaposlenik";
            this.cbZaposlenik.Size = new System.Drawing.Size(162, 21);
            this.cbZaposlenik.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Employee";
            // 
            // cbNalog
            // 
            this.cbNalog.FormattingEnabled = true;
            this.cbNalog.Location = new System.Drawing.Point(4, 219);
            this.cbNalog.Margin = new System.Windows.Forms.Padding(2);
            this.cbNalog.Name = "cbNalog";
            this.cbNalog.Size = new System.Drawing.Size(162, 21);
            this.cbNalog.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Work order";
            // 
            // lIdIzdatnica
            // 
            this.lIdIzdatnica.AutoSize = true;
            this.lIdIzdatnica.Location = new System.Drawing.Point(4, 241);
            this.lIdIzdatnica.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lIdIzdatnica.Name = "lIdIzdatnica";
            this.lIdIzdatnica.Size = new System.Drawing.Size(18, 13);
            this.lIdIzdatnica.TabIndex = 11;
            this.lIdIzdatnica.Text = "ID";
            // 
            // tbIdIzdatnica
            // 
            this.tbIdIzdatnica.Location = new System.Drawing.Point(4, 257);
            this.tbIdIzdatnica.Margin = new System.Windows.Forms.Padding(2);
            this.tbIdIzdatnica.Name = "tbIdIzdatnica";
            this.tbIdIzdatnica.ReadOnly = true;
            this.tbIdIzdatnica.Size = new System.Drawing.Size(87, 20);
            this.tbIdIzdatnica.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Remark";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Issue note date";
            // 
            // tbNapomena
            // 
            this.tbNapomena.Location = new System.Drawing.Point(4, 44);
            this.tbNapomena.Margin = new System.Windows.Forms.Padding(2);
            this.tbNapomena.Multiline = true;
            this.tbNapomena.Name = "tbNapomena";
            this.tbNapomena.Size = new System.Drawing.Size(237, 78);
            this.tbNapomena.TabIndex = 2;
            // 
            // FrmUrediDodajIzdatnicu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(477, 457);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremiPromjene);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmUrediDodajIzdatnicu";
            this.Text = "Update/Add issue note";
            this.Load += new System.EventHandler(this.FrmUrediDodajIzdatnicu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSpremiPromjene;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbNalog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lIdIzdatnica;
        private System.Windows.Forms.TextBox tbIdIzdatnica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNapomena;
        private System.Windows.Forms.ComboBox cbZaposlenik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDatumIzdatnice;
    }
}