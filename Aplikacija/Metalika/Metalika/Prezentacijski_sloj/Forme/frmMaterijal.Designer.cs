namespace Metalika
{
    partial class FrmMaterijal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMaterijal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvMaterijali = new System.Windows.Forms.DataGridView();
            this.iDmaterijalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivmaterijalaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dimenzijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sastavDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dodatneinformacijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDjedmjereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jedinicamjereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stanjeskladistaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkeizdatniceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkeprimkeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkenalogaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materijalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterijali)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalBindingSource)).BeginInit();
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
            // dgvMaterijali
            // 
            this.dgvMaterijali.AllowUserToAddRows = false;
            this.dgvMaterijali.AllowUserToDeleteRows = false;
            this.dgvMaterijali.AllowUserToResizeColumns = false;
            this.dgvMaterijali.AllowUserToResizeRows = false;
            this.dgvMaterijali.AutoGenerateColumns = false;
            this.dgvMaterijali.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaterijali.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterijali.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDmaterijalDataGridViewTextBoxColumn,
            this.nazivmaterijalaDataGridViewTextBoxColumn,
            this.dimenzijeDataGridViewTextBoxColumn,
            this.sastavDataGridViewTextBoxColumn,
            this.dodatneinformacijeDataGridViewTextBoxColumn,
            this.iDjedmjereDataGridViewTextBoxColumn,
            this.jedinicamjereDataGridViewTextBoxColumn,
            this.stanjeskladistaDataGridViewTextBoxColumn,
            this.stavkeizdatniceDataGridViewTextBoxColumn,
            this.stavkeprimkeDataGridViewTextBoxColumn,
            this.stavkenalogaDataGridViewTextBoxColumn});
            this.dgvMaterijali.DataSource = this.materijalBindingSource;
            this.dgvMaterijali.Location = new System.Drawing.Point(245, 50);
            this.dgvMaterijali.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMaterijali.Name = "dgvMaterijali";
            this.dgvMaterijali.ReadOnly = true;
            this.dgvMaterijali.RowTemplate.Height = 24;
            this.dgvMaterijali.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterijali.Size = new System.Drawing.Size(594, 324);
            this.dgvMaterijali.TabIndex = 9;
            // 
            // iDmaterijalDataGridViewTextBoxColumn
            // 
            this.iDmaterijalDataGridViewTextBoxColumn.DataPropertyName = "ID_materijal";
            this.iDmaterijalDataGridViewTextBoxColumn.HeaderText = "ID materijal";
            this.iDmaterijalDataGridViewTextBoxColumn.Name = "iDmaterijalDataGridViewTextBoxColumn";
            this.iDmaterijalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivmaterijalaDataGridViewTextBoxColumn
            // 
            this.nazivmaterijalaDataGridViewTextBoxColumn.DataPropertyName = "naziv_materijala";
            this.nazivmaterijalaDataGridViewTextBoxColumn.HeaderText = "Naziv materijala";
            this.nazivmaterijalaDataGridViewTextBoxColumn.Name = "nazivmaterijalaDataGridViewTextBoxColumn";
            this.nazivmaterijalaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dimenzijeDataGridViewTextBoxColumn
            // 
            this.dimenzijeDataGridViewTextBoxColumn.DataPropertyName = "dimenzije";
            this.dimenzijeDataGridViewTextBoxColumn.HeaderText = "Dimenzije";
            this.dimenzijeDataGridViewTextBoxColumn.Name = "dimenzijeDataGridViewTextBoxColumn";
            this.dimenzijeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sastavDataGridViewTextBoxColumn
            // 
            this.sastavDataGridViewTextBoxColumn.DataPropertyName = "sastav";
            this.sastavDataGridViewTextBoxColumn.HeaderText = "Sastav";
            this.sastavDataGridViewTextBoxColumn.Name = "sastavDataGridViewTextBoxColumn";
            this.sastavDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dodatneinformacijeDataGridViewTextBoxColumn
            // 
            this.dodatneinformacijeDataGridViewTextBoxColumn.DataPropertyName = "dodatne_informacije";
            this.dodatneinformacijeDataGridViewTextBoxColumn.HeaderText = "Dodatne informacije";
            this.dodatneinformacijeDataGridViewTextBoxColumn.Name = "dodatneinformacijeDataGridViewTextBoxColumn";
            this.dodatneinformacijeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDjedmjereDataGridViewTextBoxColumn
            // 
            this.iDjedmjereDataGridViewTextBoxColumn.DataPropertyName = "ID_jed_mjere";
            this.iDjedmjereDataGridViewTextBoxColumn.HeaderText = "Jedinica mjere";
            this.iDjedmjereDataGridViewTextBoxColumn.Name = "iDjedmjereDataGridViewTextBoxColumn";
            this.iDjedmjereDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jedinicamjereDataGridViewTextBoxColumn
            // 
            this.jedinicamjereDataGridViewTextBoxColumn.DataPropertyName = "jedinica_mjere";
            this.jedinicamjereDataGridViewTextBoxColumn.HeaderText = "jedinica_mjere";
            this.jedinicamjereDataGridViewTextBoxColumn.Name = "jedinicamjereDataGridViewTextBoxColumn";
            this.jedinicamjereDataGridViewTextBoxColumn.ReadOnly = true;
            this.jedinicamjereDataGridViewTextBoxColumn.Visible = false;
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
            // stavkeprimkeDataGridViewTextBoxColumn
            // 
            this.stavkeprimkeDataGridViewTextBoxColumn.DataPropertyName = "stavke_primke";
            this.stavkeprimkeDataGridViewTextBoxColumn.HeaderText = "stavke_primke";
            this.stavkeprimkeDataGridViewTextBoxColumn.Name = "stavkeprimkeDataGridViewTextBoxColumn";
            this.stavkeprimkeDataGridViewTextBoxColumn.ReadOnly = true;
            this.stavkeprimkeDataGridViewTextBoxColumn.Visible = false;
            // 
            // stavkenalogaDataGridViewTextBoxColumn
            // 
            this.stavkenalogaDataGridViewTextBoxColumn.DataPropertyName = "stavke_naloga";
            this.stavkenalogaDataGridViewTextBoxColumn.HeaderText = "stavke_naloga";
            this.stavkenalogaDataGridViewTextBoxColumn.Name = "stavkenalogaDataGridViewTextBoxColumn";
            this.stavkenalogaDataGridViewTextBoxColumn.ReadOnly = true;
            this.stavkenalogaDataGridViewTextBoxColumn.Visible = false;
            // 
            // materijalBindingSource
            // 
            this.materijalBindingSource.DataSource = typeof(Metalika.Podatkovni_sloj.materijal);
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
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Popis materijala";
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
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Materijali";
            // 
            // FrmMaterijal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(849, 473);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvMaterijali);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMaterijal";
            this.Load += new System.EventHandler(this.FrmMaterijal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterijali)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvMaterijali;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDmaterijalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivmaterijalaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dimenzijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sastavDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dodatneinformacijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDjedmjereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jedinicamjereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stanjeskladistaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkeizdatniceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkeprimkeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkenalogaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource materijalBindingSource;
    }
}