namespace Metalika
{
    partial class FrmPromjenaZaporke
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPromjenaZaporke));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNovaZaporka = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPotvrdiZaporku = new System.Windows.Forms.TextBox();
            this.btnSpremiPromjene = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.pZaporke = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 166);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "New password";
            // 
            // tbNovaZaporka
            // 
            this.tbNovaZaporka.Location = new System.Drawing.Point(9, 182);
            this.tbNovaZaporka.Margin = new System.Windows.Forms.Padding(2);
            this.tbNovaZaporka.Name = "tbNovaZaporka";
            this.tbNovaZaporka.PasswordChar = '*';
            this.tbNovaZaporka.Size = new System.Drawing.Size(162, 20);
            this.tbNovaZaporka.TabIndex = 3;
            this.tbNovaZaporka.TextChanged += new System.EventHandler(this.TbNovaZaporka_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Confirm the password";
            // 
            // tbPotvrdiZaporku
            // 
            this.tbPotvrdiZaporku.Location = new System.Drawing.Point(9, 219);
            this.tbPotvrdiZaporku.Margin = new System.Windows.Forms.Padding(2);
            this.tbPotvrdiZaporku.Name = "tbPotvrdiZaporku";
            this.tbPotvrdiZaporku.PasswordChar = '*';
            this.tbPotvrdiZaporku.Size = new System.Drawing.Size(162, 20);
            this.tbPotvrdiZaporku.TabIndex = 6;
            this.tbPotvrdiZaporku.TextChanged += new System.EventHandler(this.TbNovaZaporka_TextChanged);
            // 
            // btnSpremiPromjene
            // 
            this.btnSpremiPromjene.Location = new System.Drawing.Point(11, 268);
            this.btnSpremiPromjene.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpremiPromjene.Name = "btnSpremiPromjene";
            this.btnSpremiPromjene.Size = new System.Drawing.Size(76, 32);
            this.btnSpremiPromjene.TabIndex = 7;
            this.btnSpremiPromjene.Text = "Save";
            this.btnSpremiPromjene.UseVisualStyleBackColor = true;
            this.btnSpremiPromjene.Click += new System.EventHandler(this.BtnSpremiPromjene_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(98, 268);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(2);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(73, 32);
            this.btnOdustani.TabIndex = 8;
            this.btnOdustani.Text = "Cancel";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.BtnOdustani_Click);
            // 
            // pZaporke
            // 
            this.pZaporke.Location = new System.Drawing.Point(186, 202);
            this.pZaporke.Margin = new System.Windows.Forms.Padding(2);
            this.pZaporke.Name = "pZaporke";
            this.pZaporke.Size = new System.Drawing.Size(26, 24);
            this.pZaporke.TabIndex = 14;
            // 
            // FrmPromjenaZaporke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(428, 381);
            this.Controls.Add(this.pZaporke);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremiPromjene);
            this.Controls.Add(this.tbPotvrdiZaporku);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNovaZaporka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmPromjenaZaporke";
            this.Text = "Change password";
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
        private System.Windows.Forms.Panel pZaporke;
    }
}