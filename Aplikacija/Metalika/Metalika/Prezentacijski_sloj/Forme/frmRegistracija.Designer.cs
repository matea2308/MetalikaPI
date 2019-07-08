namespace Metalika
{
    partial class FrmRegistracija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistracija));
            this.label1 = new System.Windows.Forms.Label();
            this.tbNovaZaporka = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPotvrdiZaporku = new System.Windows.Forms.TextBox();
            this.btnSpremiPromjene = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbKorisnickoIme = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTipKorisnika = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pZaporke = new System.Windows.Forms.Panel();
            this.lIdKorisnik = new System.Windows.Forms.Label();
            this.tbIdKorisnik = new System.Windows.Forms.TextBox();
            this.cbOmogucen = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password";
            // 
            // tbNovaZaporka
            // 
            this.tbNovaZaporka.Location = new System.Drawing.Point(4, 75);
            this.tbNovaZaporka.Margin = new System.Windows.Forms.Padding(2);
            this.tbNovaZaporka.Name = "tbNovaZaporka";
            this.tbNovaZaporka.PasswordChar = '*';
            this.tbNovaZaporka.Size = new System.Drawing.Size(162, 20);
            this.tbNovaZaporka.TabIndex = 4;
            this.tbNovaZaporka.TextChanged += new System.EventHandler(this.TbNovaZaporka_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirm the password";
            // 
            // tbPotvrdiZaporku
            // 
            this.tbPotvrdiZaporku.Location = new System.Drawing.Point(4, 111);
            this.tbPotvrdiZaporku.Margin = new System.Windows.Forms.Padding(2);
            this.tbPotvrdiZaporku.Name = "tbPotvrdiZaporku";
            this.tbPotvrdiZaporku.PasswordChar = '*';
            this.tbPotvrdiZaporku.Size = new System.Drawing.Size(162, 20);
            this.tbPotvrdiZaporku.TabIndex = 6;
            this.tbPotvrdiZaporku.TextChanged += new System.EventHandler(this.TbNovaZaporka_TextChanged);
            // 
            // btnSpremiPromjene
            // 
            this.btnSpremiPromjene.Location = new System.Drawing.Point(9, 416);
            this.btnSpremiPromjene.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpremiPromjene.Name = "btnSpremiPromjene";
            this.btnSpremiPromjene.Size = new System.Drawing.Size(98, 32);
            this.btnSpremiPromjene.TabIndex = 21;
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
            this.btnOdustani.TabIndex = 22;
            this.btnOdustani.Text = "Cancel";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.BtnOdustani_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // tbKorisnickoIme
            // 
            this.tbKorisnickoIme.Location = new System.Drawing.Point(4, 38);
            this.tbKorisnickoIme.Margin = new System.Windows.Forms.Padding(2);
            this.tbKorisnickoIme.Name = "tbKorisnickoIme";
            this.tbKorisnickoIme.Size = new System.Drawing.Size(162, 20);
            this.tbKorisnickoIme.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "User type";
            // 
            // cbTipKorisnika
            // 
            this.cbTipKorisnika.FormattingEnabled = true;
            this.cbTipKorisnika.Location = new System.Drawing.Point(4, 152);
            this.cbTipKorisnika.Margin = new System.Windows.Forms.Padding(2);
            this.cbTipKorisnika.Name = "cbTipKorisnika";
            this.cbTipKorisnika.Size = new System.Drawing.Size(162, 21);
            this.cbTipKorisnika.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pZaporke);
            this.groupBox1.Controls.Add(this.lIdKorisnik);
            this.groupBox1.Controls.Add(this.tbIdKorisnik);
            this.groupBox1.Controls.Add(this.cbOmogucen);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbTipKorisnika);
            this.groupBox1.Controls.Add(this.tbNovaZaporka);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbKorisnickoIme);
            this.groupBox1.Controls.Add(this.tbPotvrdiZaporku);
            this.groupBox1.Location = new System.Drawing.Point(223, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(245, 222);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter user data:";
            // 
            // pZaporke
            // 
            this.pZaporke.Location = new System.Drawing.Point(183, 85);
            this.pZaporke.Margin = new System.Windows.Forms.Padding(2);
            this.pZaporke.Name = "pZaporke";
            this.pZaporke.Size = new System.Drawing.Size(26, 24);
            this.pZaporke.TabIndex = 13;
            // 
            // lIdKorisnik
            // 
            this.lIdKorisnik.AutoSize = true;
            this.lIdKorisnik.Location = new System.Drawing.Point(193, 20);
            this.lIdKorisnik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lIdKorisnik.Name = "lIdKorisnik";
            this.lIdKorisnik.Size = new System.Drawing.Size(18, 13);
            this.lIdKorisnik.TabIndex = 12;
            this.lIdKorisnik.Text = "ID";
            // 
            // tbIdKorisnik
            // 
            this.tbIdKorisnik.Location = new System.Drawing.Point(193, 38);
            this.tbIdKorisnik.Margin = new System.Windows.Forms.Padding(2);
            this.tbIdKorisnik.Name = "tbIdKorisnik";
            this.tbIdKorisnik.ReadOnly = true;
            this.tbIdKorisnik.Size = new System.Drawing.Size(49, 20);
            this.tbIdKorisnik.TabIndex = 11;
            // 
            // cbOmogucen
            // 
            this.cbOmogucen.FormattingEnabled = true;
            this.cbOmogucen.Items.AddRange(new object[] {
            "D",
            "N"});
            this.cbOmogucen.Location = new System.Drawing.Point(4, 194);
            this.cbOmogucen.Margin = new System.Windows.Forms.Padding(2);
            this.cbOmogucen.Name = "cbOmogucen";
            this.cbOmogucen.Size = new System.Drawing.Size(162, 21);
            this.cbOmogucen.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 177);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Enabled (D - yes, N - no)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbTelefon);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tbAdresa);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dtpDatumRodjenja);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbPrezime);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbIme);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(223, 236);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(245, 210);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Employee information:";
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(4, 181);
            this.tbTelefon.Margin = new System.Windows.Forms.Padding(2);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(162, 20);
            this.tbTelefon.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 165);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Phone";
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(4, 145);
            this.tbAdresa.Margin = new System.Windows.Forms.Padding(2);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(162, 20);
            this.tbAdresa.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 128);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Address";
            // 
            // dtpDatumRodjenja
            // 
            this.dtpDatumRodjenja.Location = new System.Drawing.Point(4, 108);
            this.dtpDatumRodjenja.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            this.dtpDatumRodjenja.Size = new System.Drawing.Size(162, 20);
            this.dtpDatumRodjenja.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 92);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Date of birth";
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(4, 72);
            this.tbPrezime.Margin = new System.Windows.Forms.Padding(2);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(162, 20);
            this.tbPrezime.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 55);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Surname";
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(4, 35);
            this.tbIme.Margin = new System.Windows.Forms.Padding(2);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(162, 20);
            this.tbIme.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Name";
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
            this.label6.Size = new System.Drawing.Size(162, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "User registration";
            // 
            // FrmRegistracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(477, 457);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremiPromjene);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmRegistracija";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.FrmRegistracija_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNovaZaporka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPotvrdiZaporku;
        private System.Windows.Forms.Button btnSpremiPromjene;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbKorisnickoIme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTipKorisnika;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDatumRodjenja;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbOmogucen;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lIdKorisnik;
        private System.Windows.Forms.TextBox tbIdKorisnik;
        private System.Windows.Forms.Panel pZaporke;
    }
}