namespace Metalika
{
    partial class FrmUrediDodajMaterijal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrediDodajMaterijal));
            this.label1 = new System.Windows.Forms.Label();
            this.tbDimenzije = new System.Windows.Forms.TextBox();
            this.btnSpremiPromjene = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNazivMaterijala = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbJedMjere = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDodatneInfo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSastav = new System.Windows.Forms.TextBox();
            this.lIdMaterijal = new System.Windows.Forms.Label();
            this.tbIdMaterijal = new System.Windows.Forms.TextBox();
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
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dimensions";
            // 
            // tbDimenzije
            // 
            this.tbDimenzije.Location = new System.Drawing.Point(4, 80);
            this.tbDimenzije.Margin = new System.Windows.Forms.Padding(2);
            this.tbDimenzije.Name = "tbDimenzije";
            this.tbDimenzije.Size = new System.Drawing.Size(162, 20);
            this.tbDimenzije.TabIndex = 4;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Material name";
            // 
            // tbNazivMaterijala
            // 
            this.tbNazivMaterijala.Location = new System.Drawing.Point(4, 44);
            this.tbNazivMaterijala.Margin = new System.Windows.Forms.Padding(2);
            this.tbNazivMaterijala.Name = "tbNazivMaterijala";
            this.tbNazivMaterijala.Size = new System.Drawing.Size(162, 20);
            this.tbNazivMaterijala.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbJedMjere);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbDodatneInfo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbSastav);
            this.groupBox1.Controls.Add(this.lIdMaterijal);
            this.groupBox1.Controls.Add(this.tbIdMaterijal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbDimenzije);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbNazivMaterijala);
            this.groupBox1.Location = new System.Drawing.Point(223, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(245, 319);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter details:";
            // 
            // cbJedMjere
            // 
            this.cbJedMjere.FormattingEnabled = true;
            this.cbJedMjere.Location = new System.Drawing.Point(5, 235);
            this.cbJedMjere.Margin = new System.Windows.Forms.Padding(2);
            this.cbJedMjere.Name = "cbJedMjere";
            this.cbJedMjere.Size = new System.Drawing.Size(162, 21);
            this.cbJedMjere.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 218);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Unit of measure";
            // 
            // tbDodatneInfo
            // 
            this.tbDodatneInfo.Location = new System.Drawing.Point(5, 158);
            this.tbDodatneInfo.Margin = new System.Windows.Forms.Padding(2);
            this.tbDodatneInfo.Multiline = true;
            this.tbDodatneInfo.Name = "tbDodatneInfo";
            this.tbDodatneInfo.Size = new System.Drawing.Size(236, 58);
            this.tbDodatneInfo.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Additional information";
            // 
            // tbSastav
            // 
            this.tbSastav.Location = new System.Drawing.Point(5, 118);
            this.tbSastav.Margin = new System.Windows.Forms.Padding(2);
            this.tbSastav.Name = "tbSastav";
            this.tbSastav.Size = new System.Drawing.Size(162, 20);
            this.tbSastav.TabIndex = 6;
            // 
            // lIdMaterijal
            // 
            this.lIdMaterijal.AutoSize = true;
            this.lIdMaterijal.Location = new System.Drawing.Point(5, 257);
            this.lIdMaterijal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lIdMaterijal.Name = "lIdMaterijal";
            this.lIdMaterijal.Size = new System.Drawing.Size(18, 13);
            this.lIdMaterijal.TabIndex = 11;
            this.lIdMaterijal.Text = "ID";
            // 
            // tbIdMaterijal
            // 
            this.tbIdMaterijal.Location = new System.Drawing.Point(5, 273);
            this.tbIdMaterijal.Margin = new System.Windows.Forms.Padding(2);
            this.tbIdMaterijal.Name = "tbIdMaterijal";
            this.tbIdMaterijal.ReadOnly = true;
            this.tbIdMaterijal.Size = new System.Drawing.Size(87, 20);
            this.tbIdMaterijal.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 101);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Composition";
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
            this.label6.Size = new System.Drawing.Size(199, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Update/Add material";
            // 
            // FrmUrediDodajMaterijal
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
            this.Name = "FrmUrediDodajMaterijal";
            this.Text = "Update/Add material";
            this.Load += new System.EventHandler(this.FrmUrediDodajMaterijal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDimenzije;
        private System.Windows.Forms.Button btnSpremiPromjene;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNazivMaterijala;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lIdMaterijal;
        private System.Windows.Forms.TextBox tbIdMaterijal;
        private System.Windows.Forms.TextBox tbDodatneInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSastav;
        private System.Windows.Forms.ComboBox cbJedMjere;
        private System.Windows.Forms.Label label4;
    }
}