namespace Metalika
{
    partial class FrmUrediDodajTip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrediDodajTip));
            this.label1 = new System.Windows.Forms.Label();
            this.tbOpis = new System.Windows.Forms.TextBox();
            this.btnSpremiPromjene = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNazivTipa = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lIdTipKorisnika = new System.Windows.Forms.Label();
            this.tbIdTipKorisnika = new System.Windows.Forms.TextBox();
            this.cbOmogucen = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Opis";
            // 
            // tbOpis
            // 
            this.tbOpis.Location = new System.Drawing.Point(4, 80);
            this.tbOpis.Margin = new System.Windows.Forms.Padding(2);
            this.tbOpis.Multiline = true;
            this.tbOpis.Name = "tbOpis";
            this.tbOpis.Size = new System.Drawing.Size(237, 97);
            this.tbOpis.TabIndex = 4;
            // 
            // btnSpremiPromjene
            // 
            this.btnSpremiPromjene.Location = new System.Drawing.Point(9, 416);
            this.btnSpremiPromjene.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpremiPromjene.Name = "btnSpremiPromjene";
            this.btnSpremiPromjene.Size = new System.Drawing.Size(98, 32);
            this.btnSpremiPromjene.TabIndex = 9;
            this.btnSpremiPromjene.Text = "Spremi promjene";
            this.btnSpremiPromjene.UseVisualStyleBackColor = true;
            this.btnSpremiPromjene.Click += new System.EventHandler(this.BtnSpremiPromjene_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(111, 416);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(2);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(73, 32);
            this.btnOdustani.TabIndex = 10;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.BtnOdustani_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naziv tipa";
            // 
            // tbNazivTipa
            // 
            this.tbNazivTipa.Location = new System.Drawing.Point(4, 44);
            this.tbNazivTipa.Margin = new System.Windows.Forms.Padding(2);
            this.tbNazivTipa.Name = "tbNazivTipa";
            this.tbNazivTipa.Size = new System.Drawing.Size(162, 20);
            this.tbNazivTipa.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lIdTipKorisnika);
            this.groupBox1.Controls.Add(this.tbIdTipKorisnika);
            this.groupBox1.Controls.Add(this.cbOmogucen);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbOpis);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbNazivTipa);
            this.groupBox1.Location = new System.Drawing.Point(223, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(245, 263);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unesi detalje:";
            // 
            // lIdTipKorisnika
            // 
            this.lIdTipKorisnika.AutoSize = true;
            this.lIdTipKorisnika.Location = new System.Drawing.Point(4, 218);
            this.lIdTipKorisnika.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lIdTipKorisnika.Name = "lIdTipKorisnika";
            this.lIdTipKorisnika.Size = new System.Drawing.Size(18, 13);
            this.lIdTipKorisnika.TabIndex = 7;
            this.lIdTipKorisnika.Text = "ID";
            // 
            // tbIdTipKorisnika
            // 
            this.tbIdTipKorisnika.Location = new System.Drawing.Point(4, 234);
            this.tbIdTipKorisnika.Margin = new System.Windows.Forms.Padding(2);
            this.tbIdTipKorisnika.Name = "tbIdTipKorisnika";
            this.tbIdTipKorisnika.ReadOnly = true;
            this.tbIdTipKorisnika.Size = new System.Drawing.Size(87, 20);
            this.tbIdTipKorisnika.TabIndex = 8;
            // 
            // cbOmogucen
            // 
            this.cbOmogucen.FormattingEnabled = true;
            this.cbOmogucen.Items.AddRange(new object[] {
            "D",
            "N"});
            this.cbOmogucen.Location = new System.Drawing.Point(4, 196);
            this.cbOmogucen.Margin = new System.Windows.Forms.Padding(2);
            this.cbOmogucen.Name = "cbOmogucen";
            this.cbOmogucen.Size = new System.Drawing.Size(162, 21);
            this.cbOmogucen.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 179);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Omogućen (D/N)";
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
            this.label6.Size = new System.Drawing.Size(146, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Uredi/dodaj tip";
            // 
            // FrmUrediDodajTip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(477, 457);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremiPromjene);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmUrediDodajTip";
            this.Text = "Uredi/dodaj tip korisnika";
            this.Load += new System.EventHandler(this.FrmUrediDodajTip_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbOpis;
        private System.Windows.Forms.Button btnSpremiPromjene;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNazivTipa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbOmogucen;
        private System.Windows.Forms.Label lIdTipKorisnika;
        private System.Windows.Forms.TextBox tbIdTipKorisnika;
    }
}