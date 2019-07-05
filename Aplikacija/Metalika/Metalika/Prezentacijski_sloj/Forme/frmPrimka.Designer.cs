namespace Metalika
{
    partial class FrmPrimka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrimka));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvPrimke = new System.Windows.Forms.DataGridView();
            this.iDprimkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumprimkeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.napomenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDdobavljacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDzaposlenikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poslovnipartnerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stanjeskladistaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkeprimkeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnObrišiStavku = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUrediStavku = new System.Windows.Forms.Button();
            this.btnDodajStavku = new System.Windows.Forms.Button();
            this.dgvStavkePrimke = new System.Windows.Forms.DataGridView();
            this.iDprimkaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDmaterijalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materijalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkeprimkeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.primkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkePrimke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeprimkeBindingSource)).BeginInit();
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
            // dgvPrimke
            // 
            this.dgvPrimke.AllowUserToAddRows = false;
            this.dgvPrimke.AllowUserToDeleteRows = false;
            this.dgvPrimke.AllowUserToResizeColumns = false;
            this.dgvPrimke.AllowUserToResizeRows = false;
            this.dgvPrimke.AutoGenerateColumns = false;
            this.dgvPrimke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrimke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrimke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDprimkaDataGridViewTextBoxColumn,
            this.datumprimkeDataGridViewTextBoxColumn,
            this.napomenaDataGridViewTextBoxColumn,
            this.iDdobavljacDataGridViewTextBoxColumn,
            this.iDzaposlenikDataGridViewTextBoxColumn,
            this.korisnikDataGridViewTextBoxColumn,
            this.poslovnipartnerDataGridViewTextBoxColumn,
            this.stanjeskladistaDataGridViewTextBoxColumn,
            this.stavkeprimkeDataGridViewTextBoxColumn});
            this.dgvPrimke.DataSource = this.primkaBindingSource;
            this.dgvPrimke.Location = new System.Drawing.Point(245, 50);
            this.dgvPrimke.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPrimke.Name = "dgvPrimke";
            this.dgvPrimke.ReadOnly = true;
            this.dgvPrimke.RowTemplate.Height = 24;
            this.dgvPrimke.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrimke.Size = new System.Drawing.Size(680, 235);
            this.dgvPrimke.TabIndex = 9;
            this.dgvPrimke.SelectionChanged += new System.EventHandler(this.DgvPrimke_SelectionChanged);
            // 
            // iDprimkaDataGridViewTextBoxColumn
            // 
            this.iDprimkaDataGridViewTextBoxColumn.DataPropertyName = "ID_primka";
            this.iDprimkaDataGridViewTextBoxColumn.HeaderText = "ID primka";
            this.iDprimkaDataGridViewTextBoxColumn.Name = "iDprimkaDataGridViewTextBoxColumn";
            this.iDprimkaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumprimkeDataGridViewTextBoxColumn
            // 
            this.datumprimkeDataGridViewTextBoxColumn.DataPropertyName = "datum_primke";
            this.datumprimkeDataGridViewTextBoxColumn.HeaderText = "Datum primke";
            this.datumprimkeDataGridViewTextBoxColumn.Name = "datumprimkeDataGridViewTextBoxColumn";
            this.datumprimkeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // napomenaDataGridViewTextBoxColumn
            // 
            this.napomenaDataGridViewTextBoxColumn.DataPropertyName = "napomena";
            this.napomenaDataGridViewTextBoxColumn.HeaderText = "Napomena";
            this.napomenaDataGridViewTextBoxColumn.Name = "napomenaDataGridViewTextBoxColumn";
            this.napomenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDdobavljacDataGridViewTextBoxColumn
            // 
            this.iDdobavljacDataGridViewTextBoxColumn.DataPropertyName = "ID_dobavljac";
            this.iDdobavljacDataGridViewTextBoxColumn.HeaderText = "Dobavljač";
            this.iDdobavljacDataGridViewTextBoxColumn.Name = "iDdobavljacDataGridViewTextBoxColumn";
            this.iDdobavljacDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDzaposlenikDataGridViewTextBoxColumn
            // 
            this.iDzaposlenikDataGridViewTextBoxColumn.DataPropertyName = "ID_zaposlenik";
            this.iDzaposlenikDataGridViewTextBoxColumn.HeaderText = "Zaposlenik";
            this.iDzaposlenikDataGridViewTextBoxColumn.Name = "iDzaposlenikDataGridViewTextBoxColumn";
            this.iDzaposlenikDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // korisnikDataGridViewTextBoxColumn
            // 
            this.korisnikDataGridViewTextBoxColumn.DataPropertyName = "korisnik";
            this.korisnikDataGridViewTextBoxColumn.HeaderText = "korisnik";
            this.korisnikDataGridViewTextBoxColumn.Name = "korisnikDataGridViewTextBoxColumn";
            this.korisnikDataGridViewTextBoxColumn.ReadOnly = true;
            this.korisnikDataGridViewTextBoxColumn.Visible = false;
            // 
            // poslovnipartnerDataGridViewTextBoxColumn
            // 
            this.poslovnipartnerDataGridViewTextBoxColumn.DataPropertyName = "poslovni_partner";
            this.poslovnipartnerDataGridViewTextBoxColumn.HeaderText = "poslovni_partner";
            this.poslovnipartnerDataGridViewTextBoxColumn.Name = "poslovnipartnerDataGridViewTextBoxColumn";
            this.poslovnipartnerDataGridViewTextBoxColumn.ReadOnly = true;
            this.poslovnipartnerDataGridViewTextBoxColumn.Visible = false;
            // 
            // stanjeskladistaDataGridViewTextBoxColumn
            // 
            this.stanjeskladistaDataGridViewTextBoxColumn.DataPropertyName = "stanje_skladista";
            this.stanjeskladistaDataGridViewTextBoxColumn.HeaderText = "stanje_skladista";
            this.stanjeskladistaDataGridViewTextBoxColumn.Name = "stanjeskladistaDataGridViewTextBoxColumn";
            this.stanjeskladistaDataGridViewTextBoxColumn.ReadOnly = true;
            this.stanjeskladistaDataGridViewTextBoxColumn.Visible = false;
            // 
            // stavkeprimkeDataGridViewTextBoxColumn
            // 
            this.stavkeprimkeDataGridViewTextBoxColumn.DataPropertyName = "stavke_primke";
            this.stavkeprimkeDataGridViewTextBoxColumn.HeaderText = "stavke_primke";
            this.stavkeprimkeDataGridViewTextBoxColumn.Name = "stavkeprimkeDataGridViewTextBoxColumn";
            this.stavkeprimkeDataGridViewTextBoxColumn.ReadOnly = true;
            this.stavkeprimkeDataGridViewTextBoxColumn.Visible = false;
            // 
            // primkaBindingSource
            // 
            this.primkaBindingSource.DataSource = typeof(Metalika.Podatkovni_sloj.primka);
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
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Popis primki:";
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
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Primke";
            // 
            // btnObrišiStavku
            // 
            this.btnObrišiStavku.Location = new System.Drawing.Point(443, 644);
            this.btnObrišiStavku.Margin = new System.Windows.Forms.Padding(2);
            this.btnObrišiStavku.Name = "btnObrišiStavku";
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
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Stavke primke:";
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
            // dgvStavkePrimke
            // 
            this.dgvStavkePrimke.AllowUserToAddRows = false;
            this.dgvStavkePrimke.AllowUserToDeleteRows = false;
            this.dgvStavkePrimke.AllowUserToResizeColumns = false;
            this.dgvStavkePrimke.AllowUserToResizeRows = false;
            this.dgvStavkePrimke.AutoGenerateColumns = false;
            this.dgvStavkePrimke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStavkePrimke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkePrimke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDprimkaDataGridViewTextBoxColumn1,
            this.iDmaterijalDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn,
            this.materijalDataGridViewTextBoxColumn,
            this.primkaDataGridViewTextBoxColumn});
            this.dgvStavkePrimke.DataSource = this.stavkeprimkeBindingSource;
            this.dgvStavkePrimke.Location = new System.Drawing.Point(245, 405);
            this.dgvStavkePrimke.Margin = new System.Windows.Forms.Padding(2);
            this.dgvStavkePrimke.Name = "dgvStavkePrimke";
            this.dgvStavkePrimke.ReadOnly = true;
            this.dgvStavkePrimke.RowTemplate.Height = 24;
            this.dgvStavkePrimke.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStavkePrimke.Size = new System.Drawing.Size(500, 235);
            this.dgvStavkePrimke.TabIndex = 20;
            // 
            // iDprimkaDataGridViewTextBoxColumn1
            // 
            this.iDprimkaDataGridViewTextBoxColumn1.DataPropertyName = "ID_primka";
            this.iDprimkaDataGridViewTextBoxColumn1.HeaderText = "ID_primka";
            this.iDprimkaDataGridViewTextBoxColumn1.Name = "iDprimkaDataGridViewTextBoxColumn1";
            this.iDprimkaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDprimkaDataGridViewTextBoxColumn1.Visible = false;
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
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            this.cijenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materijalDataGridViewTextBoxColumn
            // 
            this.materijalDataGridViewTextBoxColumn.DataPropertyName = "materijal";
            this.materijalDataGridViewTextBoxColumn.HeaderText = "materijal";
            this.materijalDataGridViewTextBoxColumn.Name = "materijalDataGridViewTextBoxColumn";
            this.materijalDataGridViewTextBoxColumn.ReadOnly = true;
            this.materijalDataGridViewTextBoxColumn.Visible = false;
            // 
            // primkaDataGridViewTextBoxColumn
            // 
            this.primkaDataGridViewTextBoxColumn.DataPropertyName = "primka";
            this.primkaDataGridViewTextBoxColumn.HeaderText = "primka";
            this.primkaDataGridViewTextBoxColumn.Name = "primkaDataGridViewTextBoxColumn";
            this.primkaDataGridViewTextBoxColumn.ReadOnly = true;
            this.primkaDataGridViewTextBoxColumn.Visible = false;
            // 
            // stavkeprimkeBindingSource
            // 
            this.stavkeprimkeBindingSource.DataSource = typeof(Metalika.Podatkovni_sloj.stavke_primke);
            // 
            // FrmPrimka
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
            this.Controls.Add(this.dgvStavkePrimke);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvPrimke);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmPrimka";
            this.Load += new System.EventHandler(this.FrmPrimka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.primkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkePrimke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeprimkeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvPrimke;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnObrišiStavku;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUrediStavku;
        private System.Windows.Forms.Button btnDodajStavku;
        private System.Windows.Forms.DataGridView dgvStavkePrimke;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDprimkaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDmaterijalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materijalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn primkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource stavkeprimkeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDprimkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumprimkeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn napomenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDdobavljacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDzaposlenikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poslovnipartnerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stanjeskladistaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkeprimkeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource primkaBindingSource;
    }
}