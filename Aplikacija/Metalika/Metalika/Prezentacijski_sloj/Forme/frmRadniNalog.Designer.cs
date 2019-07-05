namespace Metalika
{
    partial class FrmRadniNalog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRadniNalog));
            this.btnDodajNalog = new System.Windows.Forms.Button();
            this.btnUrediNalog = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnObrisiNalog = new System.Windows.Forms.Button();
            this.btnObrišiStavku = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUrediStavku = new System.Windows.Forms.Button();
            this.btnDodajStavku = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvStavkeNaloga = new System.Windows.Forms.DataGridView();
            this.dgvRadniNalozi = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.iDnalogDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDmaterijalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materijalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radninalogDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkenalogaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDnalogDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opispostupkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumpocetkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumzavrsetkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcZaposlenik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDprojektDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projektDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkenalogaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radninalogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeNaloga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRadniNalozi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkenalogaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radninalogBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajNalog
            // 
            this.btnDodajNalog.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDodajNalog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnDodajNalog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnDodajNalog.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDodajNalog.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajNalog.Location = new System.Drawing.Point(327, 356);
            this.btnDodajNalog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodajNalog.Name = "btnDodajNalog";
            this.btnDodajNalog.Size = new System.Drawing.Size(125, 78);
            this.btnDodajNalog.TabIndex = 10;
            this.btnDodajNalog.Text = "Dodaj";
            this.btnDodajNalog.UseVisualStyleBackColor = false;
            this.btnDodajNalog.Click += new System.EventHandler(this.BtnDodajNalog_Click);
            // 
            // btnUrediNalog
            // 
            this.btnUrediNalog.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUrediNalog.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUrediNalog.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrediNalog.Location = new System.Drawing.Point(460, 356);
            this.btnUrediNalog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUrediNalog.Name = "btnUrediNalog";
            this.btnUrediNalog.Size = new System.Drawing.Size(125, 78);
            this.btnUrediNalog.TabIndex = 11;
            this.btnUrediNalog.Text = "Uredi";
            this.btnUrediNalog.UseVisualStyleBackColor = false;
            this.btnUrediNalog.Click += new System.EventHandler(this.BtnUrediNalog_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Radni nalozi:";
            // 
            // btnObrisiNalog
            // 
            this.btnObrisiNalog.Location = new System.Drawing.Point(591, 356);
            this.btnObrisiNalog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnObrisiNalog.Name = "btnObrisiNalog";
            this.btnObrisiNalog.Size = new System.Drawing.Size(124, 78);
            this.btnObrisiNalog.TabIndex = 14;
            this.btnObrisiNalog.Text = "Obriši";
            this.btnObrisiNalog.UseVisualStyleBackColor = true;
            this.btnObrisiNalog.Click += new System.EventHandler(this.BtnObrisiNalog_Click);
            // 
            // btnObrišiStavku
            // 
            this.btnObrišiStavku.Location = new System.Drawing.Point(591, 793);
            this.btnObrišiStavku.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnObrišiStavku.Name = "btnObrišiStavku";
            this.btnObrišiStavku.Size = new System.Drawing.Size(124, 78);
            this.btnObrišiStavku.TabIndex = 19;
            this.btnObrišiStavku.Text = "Obriši";
            this.btnObrišiStavku.UseVisualStyleBackColor = true;
            this.btnObrišiStavku.Click += new System.EventHandler(this.BtnObrišiStavku_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 471);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Stavke naloga:";
            // 
            // btnUrediStavku
            // 
            this.btnUrediStavku.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUrediStavku.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUrediStavku.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrediStavku.Location = new System.Drawing.Point(459, 793);
            this.btnUrediStavku.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUrediStavku.Name = "btnUrediStavku";
            this.btnUrediStavku.Size = new System.Drawing.Size(125, 78);
            this.btnUrediStavku.TabIndex = 17;
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
            this.btnDodajStavku.Location = new System.Drawing.Point(327, 793);
            this.btnDodajStavku.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodajStavku.Name = "btnDodajStavku";
            this.btnDodajStavku.Size = new System.Drawing.Size(125, 78);
            this.btnDodajStavku.TabIndex = 16;
            this.btnDodajStavku.Text = "Dodaj";
            this.btnDodajStavku.UseVisualStyleBackColor = false;
            this.btnDodajStavku.Click += new System.EventHandler(this.BtnDodajStavku_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Metalika.Properties.Resources.m_logo;
            this.pictureBox1.Location = new System.Drawing.Point(35, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dgvStavkeNaloga
            // 
            this.dgvStavkeNaloga.AllowUserToAddRows = false;
            this.dgvStavkeNaloga.AllowUserToDeleteRows = false;
            this.dgvStavkeNaloga.AllowUserToResizeColumns = false;
            this.dgvStavkeNaloga.AllowUserToResizeRows = false;
            this.dgvStavkeNaloga.AutoGenerateColumns = false;
            this.dgvStavkeNaloga.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStavkeNaloga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeNaloga.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDnalogDataGridViewTextBoxColumn1,
            this.iDmaterijalDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.materijalDataGridViewTextBoxColumn,
            this.radninalogDataGridViewTextBoxColumn});
            this.dgvStavkeNaloga.DataSource = this.stavkenalogaBindingSource;
            this.dgvStavkeNaloga.Location = new System.Drawing.Point(327, 498);
            this.dgvStavkeNaloga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvStavkeNaloga.Name = "dgvStavkeNaloga";
            this.dgvStavkeNaloga.ReadOnly = true;
            this.dgvStavkeNaloga.RowTemplate.Height = 24;
            this.dgvStavkeNaloga.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStavkeNaloga.Size = new System.Drawing.Size(667, 289);
            this.dgvStavkeNaloga.TabIndex = 15;
            // 
            // dgvRadniNalozi
            // 
            this.dgvRadniNalozi.AllowUserToAddRows = false;
            this.dgvRadniNalozi.AllowUserToDeleteRows = false;
            this.dgvRadniNalozi.AllowUserToResizeColumns = false;
            this.dgvRadniNalozi.AllowUserToResizeRows = false;
            this.dgvRadniNalozi.AutoGenerateColumns = false;
            this.dgvRadniNalozi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRadniNalozi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRadniNalozi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDnalogDataGridViewTextBoxColumn,
            this.opispostupkaDataGridViewTextBoxColumn,
            this.datumpocetkaDataGridViewTextBoxColumn,
            this.datumzavrsetkaDataGridViewTextBoxColumn,
            this.dgvcZaposlenik,
            this.iDprojektDataGridViewTextBoxColumn,
            this.korisnikDataGridViewTextBoxColumn,
            this.projektDataGridViewTextBoxColumn,
            this.stavkenalogaDataGridViewTextBoxColumn});
            this.dgvRadniNalozi.DataSource = this.radninalogBindingSource;
            this.dgvRadniNalozi.Location = new System.Drawing.Point(327, 62);
            this.dgvRadniNalozi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRadniNalozi.Name = "dgvRadniNalozi";
            this.dgvRadniNalozi.ReadOnly = true;
            this.dgvRadniNalozi.RowTemplate.Height = 24;
            this.dgvRadniNalozi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRadniNalozi.Size = new System.Drawing.Size(907, 289);
            this.dgvRadniNalozi.TabIndex = 9;
            this.dgvRadniNalozi.SelectionChanged += new System.EventHandler(this.DgvRadniNalozi_SelectionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 222);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "Radni nalog";
            // 
            // iDnalogDataGridViewTextBoxColumn1
            // 
            this.iDnalogDataGridViewTextBoxColumn1.DataPropertyName = "ID_nalog";
            this.iDnalogDataGridViewTextBoxColumn1.HeaderText = "ID_nalog";
            this.iDnalogDataGridViewTextBoxColumn1.Name = "iDnalogDataGridViewTextBoxColumn1";
            this.iDnalogDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDnalogDataGridViewTextBoxColumn1.Visible = false;
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
            // materijalDataGridViewTextBoxColumn
            // 
            this.materijalDataGridViewTextBoxColumn.DataPropertyName = "materijal";
            this.materijalDataGridViewTextBoxColumn.HeaderText = "materijal";
            this.materijalDataGridViewTextBoxColumn.Name = "materijalDataGridViewTextBoxColumn";
            this.materijalDataGridViewTextBoxColumn.ReadOnly = true;
            this.materijalDataGridViewTextBoxColumn.Visible = false;
            // 
            // radninalogDataGridViewTextBoxColumn
            // 
            this.radninalogDataGridViewTextBoxColumn.DataPropertyName = "radni_nalog";
            this.radninalogDataGridViewTextBoxColumn.HeaderText = "radni_nalog";
            this.radninalogDataGridViewTextBoxColumn.Name = "radninalogDataGridViewTextBoxColumn";
            this.radninalogDataGridViewTextBoxColumn.ReadOnly = true;
            this.radninalogDataGridViewTextBoxColumn.Visible = false;
            // 
            // stavkenalogaBindingSource
            // 
            this.stavkenalogaBindingSource.DataSource = typeof(Metalika.Podatkovni_sloj.stavke_naloga);
            // 
            // iDnalogDataGridViewTextBoxColumn
            // 
            this.iDnalogDataGridViewTextBoxColumn.DataPropertyName = "ID_nalog";
            this.iDnalogDataGridViewTextBoxColumn.HeaderText = "ID_nalog";
            this.iDnalogDataGridViewTextBoxColumn.Name = "iDnalogDataGridViewTextBoxColumn";
            this.iDnalogDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDnalogDataGridViewTextBoxColumn.Visible = false;
            // 
            // opispostupkaDataGridViewTextBoxColumn
            // 
            this.opispostupkaDataGridViewTextBoxColumn.DataPropertyName = "opis_postupka";
            this.opispostupkaDataGridViewTextBoxColumn.HeaderText = "Opis postupka";
            this.opispostupkaDataGridViewTextBoxColumn.Name = "opispostupkaDataGridViewTextBoxColumn";
            this.opispostupkaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumpocetkaDataGridViewTextBoxColumn
            // 
            this.datumpocetkaDataGridViewTextBoxColumn.DataPropertyName = "datum_pocetka";
            this.datumpocetkaDataGridViewTextBoxColumn.HeaderText = "Datum početka";
            this.datumpocetkaDataGridViewTextBoxColumn.Name = "datumpocetkaDataGridViewTextBoxColumn";
            this.datumpocetkaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumzavrsetkaDataGridViewTextBoxColumn
            // 
            this.datumzavrsetkaDataGridViewTextBoxColumn.DataPropertyName = "datum_zavrsetka";
            this.datumzavrsetkaDataGridViewTextBoxColumn.HeaderText = "Datum završetka";
            this.datumzavrsetkaDataGridViewTextBoxColumn.Name = "datumzavrsetkaDataGridViewTextBoxColumn";
            this.datumzavrsetkaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dgvcZaposlenik
            // 
            this.dgvcZaposlenik.DataPropertyName = "ID_zaposlenik";
            this.dgvcZaposlenik.HeaderText = "Zaposlenik";
            this.dgvcZaposlenik.Name = "dgvcZaposlenik";
            this.dgvcZaposlenik.ReadOnly = true;
            this.dgvcZaposlenik.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // iDprojektDataGridViewTextBoxColumn
            // 
            this.iDprojektDataGridViewTextBoxColumn.DataPropertyName = "ID_projekt";
            this.iDprojektDataGridViewTextBoxColumn.HeaderText = "Projekt";
            this.iDprojektDataGridViewTextBoxColumn.Name = "iDprojektDataGridViewTextBoxColumn";
            this.iDprojektDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // korisnikDataGridViewTextBoxColumn
            // 
            this.korisnikDataGridViewTextBoxColumn.DataPropertyName = "korisnik";
            this.korisnikDataGridViewTextBoxColumn.HeaderText = "korisnik";
            this.korisnikDataGridViewTextBoxColumn.Name = "korisnikDataGridViewTextBoxColumn";
            this.korisnikDataGridViewTextBoxColumn.ReadOnly = true;
            this.korisnikDataGridViewTextBoxColumn.Visible = false;
            // 
            // projektDataGridViewTextBoxColumn
            // 
            this.projektDataGridViewTextBoxColumn.DataPropertyName = "projekt";
            this.projektDataGridViewTextBoxColumn.HeaderText = "projekt";
            this.projektDataGridViewTextBoxColumn.Name = "projektDataGridViewTextBoxColumn";
            this.projektDataGridViewTextBoxColumn.ReadOnly = true;
            this.projektDataGridViewTextBoxColumn.Visible = false;
            // 
            // stavkenalogaDataGridViewTextBoxColumn
            // 
            this.stavkenalogaDataGridViewTextBoxColumn.DataPropertyName = "stavke_naloga";
            this.stavkenalogaDataGridViewTextBoxColumn.HeaderText = "stavke_naloga";
            this.stavkenalogaDataGridViewTextBoxColumn.Name = "stavkenalogaDataGridViewTextBoxColumn";
            this.stavkenalogaDataGridViewTextBoxColumn.ReadOnly = true;
            this.stavkenalogaDataGridViewTextBoxColumn.Visible = false;
            // 
            // radninalogBindingSource
            // 
            this.radninalogBindingSource.DataSource = typeof(Metalika.Podatkovni_sloj.radni_nalog);
            // 
            // FrmRadniNalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1365, 919);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnObrišiStavku);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUrediStavku);
            this.Controls.Add(this.btnDodajStavku);
            this.Controls.Add(this.dgvStavkeNaloga);
            this.Controls.Add(this.btnObrisiNalog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUrediNalog);
            this.Controls.Add(this.btnDodajNalog);
            this.Controls.Add(this.dgvRadniNalozi);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmRadniNalog";
            this.Load += new System.EventHandler(this.FrmRadniNalog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeNaloga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRadniNalozi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkenalogaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radninalogBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDodajNalog;
        private System.Windows.Forms.Button btnUrediNalog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnObrisiNalog;
        private System.Windows.Forms.Button btnObrišiStavku;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUrediStavku;
        private System.Windows.Forms.Button btnDodajStavku;
        private System.Windows.Forms.DataGridView dgvStavkeNaloga;
        private System.Windows.Forms.BindingSource radninalogBindingSource;
        private System.Windows.Forms.DataGridView dgvRadniNalozi;
        private System.Windows.Forms.BindingSource stavkenalogaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDnalogDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDmaterijalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materijalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn radninalogDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDnalogDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opispostupkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumpocetkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumzavrsetkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcZaposlenik;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDprojektDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projektDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkenalogaDataGridViewTextBoxColumn;
    }
}