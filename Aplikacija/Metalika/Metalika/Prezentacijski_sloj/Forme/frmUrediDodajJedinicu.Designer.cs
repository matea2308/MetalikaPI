namespace Metalika
{
    partial class FrmUrediDodajJedinicu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrediDodajJedinicu));
            this.btnSpremiPromjene = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbZnacenje = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lIdJedMjere = new System.Windows.Forms.Label();
            this.tbIdJedMjere = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSpremiPromjene
            // 
            this.btnSpremiPromjene.Location = new System.Drawing.Point(9, 416);
            this.btnSpremiPromjene.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpremiPromjene.Name = "btnSpremiPromjene";
            this.btnSpremiPromjene.Size = new System.Drawing.Size(98, 32);
            this.btnSpremiPromjene.TabIndex = 5;
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
            this.btnOdustani.TabIndex = 6;
            this.btnOdustani.Text = "Cancel";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.BtnOdustani_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Meaning";
            // 
            // tbZnacenje
            // 
            this.tbZnacenje.Location = new System.Drawing.Point(4, 72);
            this.tbZnacenje.Margin = new System.Windows.Forms.Padding(2);
            this.tbZnacenje.Name = "tbZnacenje";
            this.tbZnacenje.Size = new System.Drawing.Size(162, 20);
            this.tbZnacenje.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lIdJedMjere);
            this.groupBox1.Controls.Add(this.tbIdJedMjere);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbZnacenje);
            this.groupBox1.Location = new System.Drawing.Point(286, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(245, 263);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter details";
            // 
            // lIdJedMjere
            // 
            this.lIdJedMjere.AutoSize = true;
            this.lIdJedMjere.Location = new System.Drawing.Point(4, 20);
            this.lIdJedMjere.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lIdJedMjere.Name = "lIdJedMjere";
            this.lIdJedMjere.Size = new System.Drawing.Size(18, 13);
            this.lIdJedMjere.TabIndex = 1;
            this.lIdJedMjere.Text = "ID";
            // 
            // tbIdJedMjere
            // 
            this.tbIdJedMjere.Location = new System.Drawing.Point(4, 36);
            this.tbIdJedMjere.Margin = new System.Windows.Forms.Padding(2);
            this.tbIdJedMjere.Name = "tbIdJedMjere";
            this.tbIdJedMjere.Size = new System.Drawing.Size(87, 20);
            this.tbIdJedMjere.TabIndex = 2;
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
            this.label6.Location = new System.Drawing.Point(5, 160);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(277, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Update/add units of measure";
            // 
            // FrmUrediDodajJedinicu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(536, 457);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremiPromjene);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmUrediDodajJedinicu";
            this.Text = "Update/add units of measure";
            this.Load += new System.EventHandler(this.FrmUrediDodajJedinicu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSpremiPromjene;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbZnacenje;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lIdJedMjere;
        private System.Windows.Forms.TextBox tbIdJedMjere;
    }
}