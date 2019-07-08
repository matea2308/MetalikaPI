namespace Metalika
{
    partial class FrmJedMjere
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJedMjere));
            this.dgvJediniceMjere = new System.Windows.Forms.DataGridView();
            this.jedinicamjereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iDjedmjereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.znacenjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materijalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJediniceMjere)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jedinicamjereBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvJediniceMjere
            // 
            this.dgvJediniceMjere.AllowUserToAddRows = false;
            this.dgvJediniceMjere.AllowUserToDeleteRows = false;
            this.dgvJediniceMjere.AllowUserToResizeColumns = false;
            this.dgvJediniceMjere.AllowUserToResizeRows = false;
            this.dgvJediniceMjere.AutoGenerateColumns = false;
            this.dgvJediniceMjere.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJediniceMjere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJediniceMjere.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDjedmjereDataGridViewTextBoxColumn,
            this.znacenjeDataGridViewTextBoxColumn,
            this.materijalDataGridViewTextBoxColumn});
            this.dgvJediniceMjere.DataSource = this.jedinicamjereBindingSource;
            this.dgvJediniceMjere.Location = new System.Drawing.Point(245, 50);
            this.dgvJediniceMjere.Margin = new System.Windows.Forms.Padding(2);
            this.dgvJediniceMjere.MultiSelect = false;
            this.dgvJediniceMjere.Name = "dgvJediniceMjere";
            this.dgvJediniceMjere.ReadOnly = true;
            this.dgvJediniceMjere.RowTemplate.Height = 24;
            this.dgvJediniceMjere.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJediniceMjere.Size = new System.Drawing.Size(459, 324);
            this.dgvJediniceMjere.TabIndex = 9;
            // 
            // jedinicamjereBindingSource
            // 
            this.jedinicamjereBindingSource.DataSource = typeof(Metalika.Podatkovni_sloj.jedinica_mjere);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDodaj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnDodaj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDodaj.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(245, 389);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(94, 63);
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "Add";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.BtnDodaj_Click);
            // 
            // btnUredi
            // 
            this.btnUredi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUredi.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUredi.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUredi.Location = new System.Drawing.Point(345, 389);
            this.btnUredi.Margin = new System.Windows.Forms.Padding(2);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(94, 63);
            this.btnUredi.TabIndex = 11;
            this.btnUredi.Text = "Update";
            this.btnUredi.UseVisualStyleBackColor = false;
            this.btnUredi.Click += new System.EventHandler(this.BtnUredi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Units of measure:";
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnObrisi.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnObrisi.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.Location = new System.Drawing.Point(443, 389);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(2);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(94, 63);
            this.btnObrisi.TabIndex = 14;
            this.btnObrisi.Text = "Delete";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.BtnObrisi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Units of measure";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            // iDjedmjereDataGridViewTextBoxColumn
            // 
            this.iDjedmjereDataGridViewTextBoxColumn.DataPropertyName = "ID_jed_mjere";
            this.iDjedmjereDataGridViewTextBoxColumn.HeaderText = "Units of measure ID";
            this.iDjedmjereDataGridViewTextBoxColumn.Name = "iDjedmjereDataGridViewTextBoxColumn";
            this.iDjedmjereDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // znacenjeDataGridViewTextBoxColumn
            // 
            this.znacenjeDataGridViewTextBoxColumn.DataPropertyName = "znacenje";
            this.znacenjeDataGridViewTextBoxColumn.HeaderText = "Meaning";
            this.znacenjeDataGridViewTextBoxColumn.Name = "znacenjeDataGridViewTextBoxColumn";
            this.znacenjeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materijalDataGridViewTextBoxColumn
            // 
            this.materijalDataGridViewTextBoxColumn.DataPropertyName = "materijal";
            this.materijalDataGridViewTextBoxColumn.HeaderText = "materijal";
            this.materijalDataGridViewTextBoxColumn.Name = "materijalDataGridViewTextBoxColumn";
            this.materijalDataGridViewTextBoxColumn.ReadOnly = true;
            this.materijalDataGridViewTextBoxColumn.Visible = false;
            // 
            // FrmJedMjere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(821, 473);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvJediniceMjere);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmJedMjere";
            this.Load += new System.EventHandler(this.FrmJedMjere_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJediniceMjere)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jedinicamjereBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvJediniceMjere;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource jedinicamjereBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDjedmjereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn znacenjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materijalDataGridViewTextBoxColumn;
    }
}