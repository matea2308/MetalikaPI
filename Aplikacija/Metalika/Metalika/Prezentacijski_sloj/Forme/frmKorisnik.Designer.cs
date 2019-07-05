namespace Metalika
{
    partial class FrmKorisnik
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKorisnik));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvKorisnici = new System.Windows.Forms.DataGridView();
            this.iDkorisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnickoimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaporkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumregistracijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.omogucenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumrodjenjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDtipkorisnikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izdatnicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipkorisnikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radninalogDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projektDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Metalika.Properties.Resources.m_logo;
            this.pictureBox1.Location = new System.Drawing.Point(26, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dgvKorisnici
            // 
            this.dgvKorisnici.AllowUserToAddRows = false;
            this.dgvKorisnici.AllowUserToDeleteRows = false;
            this.dgvKorisnici.AllowUserToResizeColumns = false;
            this.dgvKorisnici.AllowUserToResizeRows = false;
            this.dgvKorisnici.AutoGenerateColumns = false;
            this.dgvKorisnici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDkorisnikDataGridViewTextBoxColumn,
            this.korisnickoimeDataGridViewTextBoxColumn,
            this.zaporkaDataGridViewTextBoxColumn,
            this.datumregistracijeDataGridViewTextBoxColumn,
            this.omogucenDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.datumrodjenjaDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.iDtipkorisnikaDataGridViewTextBoxColumn,
            this.izdatnicaDataGridViewTextBoxColumn,
            this.tipkorisnikaDataGridViewTextBoxColumn,
            this.radninalogDataGridViewTextBoxColumn,
            this.primkaDataGridViewTextBoxColumn,
            this.projektDataGridViewTextBoxColumn});
            this.dgvKorisnici.DataSource = this.korisnikBindingSource;
            this.dgvKorisnici.Location = new System.Drawing.Point(245, 50);
            this.dgvKorisnici.Margin = new System.Windows.Forms.Padding(2);
            this.dgvKorisnici.Name = "dgvKorisnici";
            this.dgvKorisnici.ReadOnly = true;
            this.dgvKorisnici.RowTemplate.Height = 24;
            this.dgvKorisnici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKorisnici.Size = new System.Drawing.Size(760, 324);
            this.dgvKorisnici.TabIndex = 9;
            // 
            // iDkorisnikDataGridViewTextBoxColumn
            // 
            this.iDkorisnikDataGridViewTextBoxColumn.DataPropertyName = "ID_korisnik";
            this.iDkorisnikDataGridViewTextBoxColumn.HeaderText = "ID korisnik";
            this.iDkorisnikDataGridViewTextBoxColumn.Name = "iDkorisnikDataGridViewTextBoxColumn";
            this.iDkorisnikDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDkorisnikDataGridViewTextBoxColumn.Width = 76;
            // 
            // korisnickoimeDataGridViewTextBoxColumn
            // 
            this.korisnickoimeDataGridViewTextBoxColumn.DataPropertyName = "korisnicko_ime";
            this.korisnickoimeDataGridViewTextBoxColumn.HeaderText = "Korisničko ime";
            this.korisnickoimeDataGridViewTextBoxColumn.Name = "korisnickoimeDataGridViewTextBoxColumn";
            this.korisnickoimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.korisnickoimeDataGridViewTextBoxColumn.Width = 92;
            // 
            // zaporkaDataGridViewTextBoxColumn
            // 
            this.zaporkaDataGridViewTextBoxColumn.DataPropertyName = "zaporka";
            this.zaporkaDataGridViewTextBoxColumn.HeaderText = "zaporka";
            this.zaporkaDataGridViewTextBoxColumn.Name = "zaporkaDataGridViewTextBoxColumn";
            this.zaporkaDataGridViewTextBoxColumn.ReadOnly = true;
            this.zaporkaDataGridViewTextBoxColumn.Visible = false;
            this.zaporkaDataGridViewTextBoxColumn.Width = 70;
            // 
            // datumregistracijeDataGridViewTextBoxColumn
            // 
            this.datumregistracijeDataGridViewTextBoxColumn.DataPropertyName = "datum_registracije";
            this.datumregistracijeDataGridViewTextBoxColumn.HeaderText = "Datum registracije";
            this.datumregistracijeDataGridViewTextBoxColumn.Name = "datumregistracijeDataGridViewTextBoxColumn";
            this.datumregistracijeDataGridViewTextBoxColumn.ReadOnly = true;
            this.datumregistracijeDataGridViewTextBoxColumn.Width = 106;
            // 
            // omogucenDataGridViewTextBoxColumn
            // 
            this.omogucenDataGridViewTextBoxColumn.DataPropertyName = "omogucen";
            this.omogucenDataGridViewTextBoxColumn.HeaderText = "Omogućen";
            this.omogucenDataGridViewTextBoxColumn.Name = "omogucenDataGridViewTextBoxColumn";
            this.omogucenDataGridViewTextBoxColumn.ReadOnly = true;
            this.omogucenDataGridViewTextBoxColumn.Width = 84;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            this.imeDataGridViewTextBoxColumn.Width = 49;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.prezimeDataGridViewTextBoxColumn.Width = 69;
            // 
            // datumrodjenjaDataGridViewTextBoxColumn
            // 
            this.datumrodjenjaDataGridViewTextBoxColumn.DataPropertyName = "datum_rodjenja";
            this.datumrodjenjaDataGridViewTextBoxColumn.HeaderText = "Datum rođenja";
            this.datumrodjenjaDataGridViewTextBoxColumn.Name = "datumrodjenjaDataGridViewTextBoxColumn";
            this.datumrodjenjaDataGridViewTextBoxColumn.ReadOnly = true;
            this.datumrodjenjaDataGridViewTextBoxColumn.Width = 94;
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            this.adresaDataGridViewTextBoxColumn.ReadOnly = true;
            this.adresaDataGridViewTextBoxColumn.Width = 65;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefonDataGridViewTextBoxColumn.Width = 68;
            // 
            // iDtipkorisnikaDataGridViewTextBoxColumn
            // 
            this.iDtipkorisnikaDataGridViewTextBoxColumn.DataPropertyName = "ID_tip_korisnika";
            this.iDtipkorisnikaDataGridViewTextBoxColumn.HeaderText = "Tip korisnika";
            this.iDtipkorisnikaDataGridViewTextBoxColumn.Name = "iDtipkorisnikaDataGridViewTextBoxColumn";
            this.iDtipkorisnikaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDtipkorisnikaDataGridViewTextBoxColumn.Width = 85;
            // 
            // izdatnicaDataGridViewTextBoxColumn
            // 
            this.izdatnicaDataGridViewTextBoxColumn.DataPropertyName = "izdatnica";
            this.izdatnicaDataGridViewTextBoxColumn.HeaderText = "izdatnica";
            this.izdatnicaDataGridViewTextBoxColumn.Name = "izdatnicaDataGridViewTextBoxColumn";
            this.izdatnicaDataGridViewTextBoxColumn.ReadOnly = true;
            this.izdatnicaDataGridViewTextBoxColumn.Visible = false;
            this.izdatnicaDataGridViewTextBoxColumn.Width = 74;
            // 
            // tipkorisnikaDataGridViewTextBoxColumn
            // 
            this.tipkorisnikaDataGridViewTextBoxColumn.DataPropertyName = "tip_korisnika";
            this.tipkorisnikaDataGridViewTextBoxColumn.HeaderText = "tip_korisnika";
            this.tipkorisnikaDataGridViewTextBoxColumn.Name = "tipkorisnikaDataGridViewTextBoxColumn";
            this.tipkorisnikaDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipkorisnikaDataGridViewTextBoxColumn.Visible = false;
            this.tipkorisnikaDataGridViewTextBoxColumn.Width = 91;
            // 
            // radninalogDataGridViewTextBoxColumn
            // 
            this.radninalogDataGridViewTextBoxColumn.DataPropertyName = "radni_nalog";
            this.radninalogDataGridViewTextBoxColumn.HeaderText = "radni_nalog";
            this.radninalogDataGridViewTextBoxColumn.Name = "radninalogDataGridViewTextBoxColumn";
            this.radninalogDataGridViewTextBoxColumn.ReadOnly = true;
            this.radninalogDataGridViewTextBoxColumn.Visible = false;
            this.radninalogDataGridViewTextBoxColumn.Width = 87;
            // 
            // primkaDataGridViewTextBoxColumn
            // 
            this.primkaDataGridViewTextBoxColumn.DataPropertyName = "primka";
            this.primkaDataGridViewTextBoxColumn.HeaderText = "primka";
            this.primkaDataGridViewTextBoxColumn.Name = "primkaDataGridViewTextBoxColumn";
            this.primkaDataGridViewTextBoxColumn.ReadOnly = true;
            this.primkaDataGridViewTextBoxColumn.Visible = false;
            this.primkaDataGridViewTextBoxColumn.Width = 63;
            // 
            // projektDataGridViewTextBoxColumn
            // 
            this.projektDataGridViewTextBoxColumn.DataPropertyName = "projekt";
            this.projektDataGridViewTextBoxColumn.HeaderText = "projekt";
            this.projektDataGridViewTextBoxColumn.Name = "projektDataGridViewTextBoxColumn";
            this.projektDataGridViewTextBoxColumn.ReadOnly = true;
            this.projektDataGridViewTextBoxColumn.Visible = false;
            this.projektDataGridViewTextBoxColumn.Width = 64;
            // 
            // korisnikBindingSource
            // 
            this.korisnikBindingSource.DataSource = typeof(Metalika.Podatkovni_sloj.korisnik);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDodaj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnDodaj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDodaj.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(245, 378);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(94, 63);
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.BtnDodaj_Click);
            // 
            // btnUredi
            // 
            this.btnUredi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUredi.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUredi.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUredi.Location = new System.Drawing.Point(345, 378);
            this.btnUredi.Margin = new System.Windows.Forms.Padding(2);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(94, 63);
            this.btnUredi.TabIndex = 11;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = false;
            this.btnUredi.Click += new System.EventHandler(this.BtnUredi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Postojeći korisnici:";
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(443, 378);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(2);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(93, 63);
            this.btnObrisi.TabIndex = 14;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.BtnObrisi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Korisnici";
            // 
            // FrmKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1041, 473);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvKorisnici);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmKorisnik";
            this.Load += new System.EventHandler(this.FrmKorisnik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvKorisnici;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDkorisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnickoimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaporkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumregistracijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn omogucenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumrodjenjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDtipkorisnikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn izdatnicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipkorisnikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn radninalogDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn primkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projektDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
    }
}