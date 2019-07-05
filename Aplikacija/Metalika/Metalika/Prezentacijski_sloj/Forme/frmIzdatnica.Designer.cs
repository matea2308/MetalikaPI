namespace Metalika
{
    partial class FrmIzdatnica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIzdatnica));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvIzdatnice = new System.Windows.Forms.DataGridView();
            this.iDizdatnicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumizdatniceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.napomenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDzaposlenikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDnalogDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radninalogDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stanjeskladistaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkeizdatniceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izdatnicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnObrišiStavku = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUrediStavku = new System.Windows.Forms.Button();
            this.btnDodajStavku = new System.Windows.Forms.Button();
            this.dgvStavkeIzdatnice = new System.Windows.Forms.DataGridView();
            this.iDizdatnicaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDmaterijalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izdatnicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materijalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkeizdatniceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzdatnice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.izdatnicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeIzdatnice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeizdatniceBindingSource)).BeginInit();
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
            // dgvIzdatnice
            // 
            this.dgvIzdatnice.AllowUserToAddRows = false;
            this.dgvIzdatnice.AllowUserToDeleteRows = false;
            this.dgvIzdatnice.AllowUserToResizeColumns = false;
            this.dgvIzdatnice.AllowUserToResizeRows = false;
            this.dgvIzdatnice.AutoGenerateColumns = false;
            this.dgvIzdatnice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIzdatnice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIzdatnice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDizdatnicaDataGridViewTextBoxColumn,
            this.datumizdatniceDataGridViewTextBoxColumn,
            this.napomenaDataGridViewTextBoxColumn,
            this.iDzaposlenikDataGridViewTextBoxColumn,
            this.iDnalogDataGridViewTextBoxColumn,
            this.korisnikDataGridViewTextBoxColumn,
            this.radninalogDataGridViewTextBoxColumn,
            this.stanjeskladistaDataGridViewTextBoxColumn,
            this.stavkeizdatniceDataGridViewTextBoxColumn});
            this.dgvIzdatnice.DataSource = this.izdatnicaBindingSource;
            this.dgvIzdatnice.Location = new System.Drawing.Point(245, 50);
            this.dgvIzdatnice.Margin = new System.Windows.Forms.Padding(2);
            this.dgvIzdatnice.Name = "dgvIzdatnice";
            this.dgvIzdatnice.ReadOnly = true;
            this.dgvIzdatnice.RowTemplate.Height = 24;
            this.dgvIzdatnice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIzdatnice.Size = new System.Drawing.Size(680, 235);
            this.dgvIzdatnice.TabIndex = 9;
            this.dgvIzdatnice.SelectionChanged += new System.EventHandler(this.DgvIzdatnice_SelectionChanged);
            // 
            // iDizdatnicaDataGridViewTextBoxColumn
            // 
            this.iDizdatnicaDataGridViewTextBoxColumn.DataPropertyName = "ID_izdatnica";
            this.iDizdatnicaDataGridViewTextBoxColumn.HeaderText = "ID izdatnica";
            this.iDizdatnicaDataGridViewTextBoxColumn.Name = "iDizdatnicaDataGridViewTextBoxColumn";
            this.iDizdatnicaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumizdatniceDataGridViewTextBoxColumn
            // 
            this.datumizdatniceDataGridViewTextBoxColumn.DataPropertyName = "datum_izdatnice";
            this.datumizdatniceDataGridViewTextBoxColumn.HeaderText = "Datum izdatnice";
            this.datumizdatniceDataGridViewTextBoxColumn.Name = "datumizdatniceDataGridViewTextBoxColumn";
            this.datumizdatniceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // napomenaDataGridViewTextBoxColumn
            // 
            this.napomenaDataGridViewTextBoxColumn.DataPropertyName = "napomena";
            this.napomenaDataGridViewTextBoxColumn.HeaderText = "Napomena";
            this.napomenaDataGridViewTextBoxColumn.Name = "napomenaDataGridViewTextBoxColumn";
            this.napomenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDzaposlenikDataGridViewTextBoxColumn
            // 
            this.iDzaposlenikDataGridViewTextBoxColumn.DataPropertyName = "ID_zaposlenik";
            this.iDzaposlenikDataGridViewTextBoxColumn.HeaderText = "Zaposlenik";
            this.iDzaposlenikDataGridViewTextBoxColumn.Name = "iDzaposlenikDataGridViewTextBoxColumn";
            this.iDzaposlenikDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDnalogDataGridViewTextBoxColumn
            // 
            this.iDnalogDataGridViewTextBoxColumn.DataPropertyName = "ID_nalog";
            this.iDnalogDataGridViewTextBoxColumn.HeaderText = "Radni nalog";
            this.iDnalogDataGridViewTextBoxColumn.Name = "iDnalogDataGridViewTextBoxColumn";
            this.iDnalogDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // korisnikDataGridViewTextBoxColumn
            // 
            this.korisnikDataGridViewTextBoxColumn.DataPropertyName = "korisnik";
            this.korisnikDataGridViewTextBoxColumn.HeaderText = "korisnik";
            this.korisnikDataGridViewTextBoxColumn.Name = "korisnikDataGridViewTextBoxColumn";
            this.korisnikDataGridViewTextBoxColumn.ReadOnly = true;
            this.korisnikDataGridViewTextBoxColumn.Visible = false;
            // 
            // radninalogDataGridViewTextBoxColumn
            // 
            this.radninalogDataGridViewTextBoxColumn.DataPropertyName = "radni_nalog";
            this.radninalogDataGridViewTextBoxColumn.HeaderText = "radni_nalog";
            this.radninalogDataGridViewTextBoxColumn.Name = "radninalogDataGridViewTextBoxColumn";
            this.radninalogDataGridViewTextBoxColumn.ReadOnly = true;
            this.radninalogDataGridViewTextBoxColumn.Visible = false;
            // 
            // stanjeskladistaDataGridViewTextBoxColumn
            // 
            this.stanjeskladistaDataGridViewTextBoxColumn.DataPropertyName = "stanje_skladista";
            this.stanjeskladistaDataGridViewTextBoxColumn.HeaderText = "stanje_skladista";
            this.stanjeskladistaDataGridViewTextBoxColumn.Name = "stanjeskladistaDataGridViewTextBoxColumn";
            this.stanjeskladistaDataGridViewTextBoxColumn.ReadOnly = true;
            this.stanjeskladistaDataGridViewTextBoxColumn.Visible = false;
            // 
            // stavkeizdatniceDataGridViewTextBoxColumn
            // 
            this.stavkeizdatniceDataGridViewTextBoxColumn.DataPropertyName = "stavke_izdatnice";
            this.stavkeizdatniceDataGridViewTextBoxColumn.HeaderText = "stavke_izdatnice";
            this.stavkeizdatniceDataGridViewTextBoxColumn.Name = "stavkeizdatniceDataGridViewTextBoxColumn";
            this.stavkeizdatniceDataGridViewTextBoxColumn.ReadOnly = true;
            this.stavkeizdatniceDataGridViewTextBoxColumn.Visible = false;
            // 
            // izdatnicaBindingSource
            // 
            this.izdatnicaBindingSource.DataSource = typeof(Metalika.Podatkovni_sloj.izdatnica);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDodaj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnDodaj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDodaj.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(245, 289);
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
            this.btnUredi.Location = new System.Drawing.Point(345, 289);
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
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Popis izdatnica:";
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(443, 289);
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
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Izdatnice";
            // 
            // btnObrišiStavku
            // 
            this.btnObrišiStavku.Location = new System.Drawing.Point(443, 644);
            this.btnObrišiStavku.Margin = new System.Windows.Forms.Padding(2);
            this.btnObrišiStavku.Name = "btnObrisiStavku";
            this.btnObrišiStavku.Size = new System.Drawing.Size(93, 63);
            this.btnObrišiStavku.TabIndex = 24;
            this.btnObrišiStavku.Text = "Obriši";
            this.btnObrišiStavku.UseVisualStyleBackColor = true;
            this.btnObrišiStavku.Click += new System.EventHandler(this.BtnObrisiStavku_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 383);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Stavke izdatnice:";
            // 
            // btnUrediStavku
            // 
            this.btnUrediStavku.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUrediStavku.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUrediStavku.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrediStavku.Location = new System.Drawing.Point(344, 644);
            this.btnUrediStavku.Margin = new System.Windows.Forms.Padding(2);
            this.btnUrediStavku.Name = "btnUrediStavku";
            this.btnUrediStavku.Size = new System.Drawing.Size(94, 63);
            this.btnUrediStavku.TabIndex = 22;
            this.btnUrediStavku.Text = "Uredi";
            this.btnUrediStavku.UseVisualStyleBackColor = false;
            this.btnUrediStavku.Click += new System.EventHandler(this.BtnUrediStavku_Click);
            // 
            // btnDodajStavku
            // 
            this.btnDodajStavku.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDodajStavku.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnDodajStavku.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnDodajStavku.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDodajStavku.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajStavku.Location = new System.Drawing.Point(245, 644);
            this.btnDodajStavku.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajStavku.Name = "btnDodajStavku";
            this.btnDodajStavku.Size = new System.Drawing.Size(94, 63);
            this.btnDodajStavku.TabIndex = 21;
            this.btnDodajStavku.Text = "Dodaj";
            this.btnDodajStavku.UseVisualStyleBackColor = false;
            this.btnDodajStavku.Click += new System.EventHandler(this.BtnDodajStavku_Click);
            // 
            // dgvStavkeIzdatnice
            // 
            this.dgvStavkeIzdatnice.AllowUserToAddRows = false;
            this.dgvStavkeIzdatnice.AllowUserToDeleteRows = false;
            this.dgvStavkeIzdatnice.AllowUserToResizeColumns = false;
            this.dgvStavkeIzdatnice.AllowUserToResizeRows = false;
            this.dgvStavkeIzdatnice.AutoGenerateColumns = false;
            this.dgvStavkeIzdatnice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStavkeIzdatnice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeIzdatnice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDizdatnicaDataGridViewTextBoxColumn1,
            this.iDmaterijalDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.izdatnicaDataGridViewTextBoxColumn,
            this.materijalDataGridViewTextBoxColumn});
            this.dgvStavkeIzdatnice.DataSource = this.stavkeizdatniceBindingSource;
            this.dgvStavkeIzdatnice.Location = new System.Drawing.Point(245, 405);
            this.dgvStavkeIzdatnice.Margin = new System.Windows.Forms.Padding(2);
            this.dgvStavkeIzdatnice.Name = "dgvStavkeIzdatnice";
            this.dgvStavkeIzdatnice.ReadOnly = true;
            this.dgvStavkeIzdatnice.RowTemplate.Height = 24;
            this.dgvStavkeIzdatnice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStavkeIzdatnice.Size = new System.Drawing.Size(500, 235);
            this.dgvStavkeIzdatnice.TabIndex = 20;
            // 
            // iDizdatnicaDataGridViewTextBoxColumn1
            // 
            this.iDizdatnicaDataGridViewTextBoxColumn1.DataPropertyName = "ID_izdatnica";
            this.iDizdatnicaDataGridViewTextBoxColumn1.HeaderText = "ID_izdatnica";
            this.iDizdatnicaDataGridViewTextBoxColumn1.Name = "iDizdatnicaDataGridViewTextBoxColumn1";
            this.iDizdatnicaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDizdatnicaDataGridViewTextBoxColumn1.Visible = false;
            // 
            // iDmaterijalDataGridViewTextBoxColumn
            // 
            this.iDmaterijalDataGridViewTextBoxColumn.DataPropertyName = "ID_materijal";
            this.iDmaterijalDataGridViewTextBoxColumn.HeaderText = "Materijal";
            this.iDmaterijalDataGridViewTextBoxColumn.Name = "iDmaterijalDataGridViewTextBoxColumn";
            this.iDmaterijalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Količina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // izdatnicaDataGridViewTextBoxColumn
            // 
            this.izdatnicaDataGridViewTextBoxColumn.DataPropertyName = "izdatnica";
            this.izdatnicaDataGridViewTextBoxColumn.HeaderText = "izdatnica";
            this.izdatnicaDataGridViewTextBoxColumn.Name = "izdatnicaDataGridViewTextBoxColumn";
            this.izdatnicaDataGridViewTextBoxColumn.ReadOnly = true;
            this.izdatnicaDataGridViewTextBoxColumn.Visible = false;
            // 
            // materijalDataGridViewTextBoxColumn
            // 
            this.materijalDataGridViewTextBoxColumn.DataPropertyName = "materijal";
            this.materijalDataGridViewTextBoxColumn.HeaderText = "materijal";
            this.materijalDataGridViewTextBoxColumn.Name = "materijalDataGridViewTextBoxColumn";
            this.materijalDataGridViewTextBoxColumn.ReadOnly = true;
            this.materijalDataGridViewTextBoxColumn.Visible = false;
            // 
            // stavkeizdatniceBindingSource
            // 
            this.stavkeizdatniceBindingSource.DataSource = typeof(Metalika.Podatkovni_sloj.stavke_primke);
            // 
            // FrmIzdatnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(988, 788);
            this.ControlBox = false;
            this.Controls.Add(this.btnObrišiStavku);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUrediStavku);
            this.Controls.Add(this.btnDodajStavku);
            this.Controls.Add(this.dgvStavkeIzdatnice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvIzdatnice);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmIzdatnica";
            this.Load += new System.EventHandler(this.FrmIzdatnica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzdatnice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.izdatnicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeIzdatnice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeizdatniceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvIzdatnice;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDizdatnicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumizdatniceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn napomenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDzaposlenikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDnalogDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn radninalogDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stanjeskladistaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkeizdatniceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource izdatnicaBindingSource;
        private System.Windows.Forms.Button btnObrišiStavku;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUrediStavku;
        private System.Windows.Forms.Button btnDodajStavku;
        private System.Windows.Forms.DataGridView dgvStavkeIzdatnice;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDizdatnicaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDmaterijalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn izdatnicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materijalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource stavkeizdatniceBindingSource;
    }
}