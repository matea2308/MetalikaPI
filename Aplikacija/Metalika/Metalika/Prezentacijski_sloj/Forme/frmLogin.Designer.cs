namespace Metalika
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.lblUnesiKorIme = new System.Windows.Forms.Label();
            this.tbKorIme = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUnesiZaporku = new System.Windows.Forms.Label();
            this.tbZaporka = new System.Windows.Forms.TextBox();
            this.btnUlogirajSe = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRegistracija = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 169);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Korisničko ime";
            // 
            // lblUnesiKorIme
            // 
            this.lblUnesiKorIme.AutoSize = true;
            this.lblUnesiKorIme.ForeColor = System.Drawing.Color.Red;
            this.lblUnesiKorIme.Location = new System.Drawing.Point(134, 183);
            this.lblUnesiKorIme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnesiKorIme.Name = "lblUnesiKorIme";
            this.lblUnesiKorIme.Size = new System.Drawing.Size(154, 13);
            this.lblUnesiKorIme.TabIndex = 2;
            this.lblUnesiKorIme.Text = "* Molimo unesite korisničko ime";
            // 
            // tbKorIme
            // 
            this.tbKorIme.Location = new System.Drawing.Point(134, 199);
            this.tbKorIme.Margin = new System.Windows.Forms.Padding(2);
            this.tbKorIme.Name = "tbKorIme";
            this.tbKorIme.Size = new System.Drawing.Size(162, 20);
            this.tbKorIme.TabIndex = 3;
            this.tbKorIme.TextChanged += new System.EventHandler(this.TbKorIme_TextChanged);
            this.tbKorIme.Enter += new System.EventHandler(this.TbKorIme_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 227);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Zaporka";
            // 
            // lblUnesiZaporku
            // 
            this.lblUnesiZaporku.AutoSize = true;
            this.lblUnesiZaporku.ForeColor = System.Drawing.Color.Red;
            this.lblUnesiZaporku.Location = new System.Drawing.Point(134, 240);
            this.lblUnesiZaporku.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnesiZaporku.Name = "lblUnesiZaporku";
            this.lblUnesiZaporku.Size = new System.Drawing.Size(125, 13);
            this.lblUnesiZaporku.TabIndex = 5;
            this.lblUnesiZaporku.Text = "* Molimo unesite zaporku";
            // 
            // tbZaporka
            // 
            this.tbZaporka.Location = new System.Drawing.Point(134, 257);
            this.tbZaporka.Margin = new System.Windows.Forms.Padding(2);
            this.tbZaporka.Name = "tbZaporka";
            this.tbZaporka.PasswordChar = '*';
            this.tbZaporka.Size = new System.Drawing.Size(162, 20);
            this.tbZaporka.TabIndex = 6;
            this.tbZaporka.TextChanged += new System.EventHandler(this.TbZaporka_TextChanged);
            this.tbZaporka.Enter += new System.EventHandler(this.TbZaporka_Enter);
            // 
            // btnUlogirajSe
            // 
            this.btnUlogirajSe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUlogirajSe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnUlogirajSe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnUlogirajSe.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUlogirajSe.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnUlogirajSe.Location = new System.Drawing.Point(134, 280);
            this.btnUlogirajSe.Margin = new System.Windows.Forms.Padding(2);
            this.btnUlogirajSe.Name = "btnUlogirajSe";
            this.btnUlogirajSe.Size = new System.Drawing.Size(76, 32);
            this.btnUlogirajSe.TabIndex = 7;
            this.btnUlogirajSe.Text = "Ulogiraj se";
            this.btnUlogirajSe.UseVisualStyleBackColor = false;
            this.btnUlogirajSe.Click += new System.EventHandler(this.BtnUlogirajSe_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOdustani.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnOdustani.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnOdustani.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOdustani.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnOdustani.Location = new System.Drawing.Point(222, 280);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(2);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(73, 32);
            this.btnOdustani.TabIndex = 8;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.BtnOdustani_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 336);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nemaš korisnički račun?";
            // 
            // lblRegistracija
            // 
            this.lblRegistracija.AutoSize = true;
            this.lblRegistracija.ForeColor = System.Drawing.Color.Blue;
            this.lblRegistracija.Location = new System.Drawing.Point(242, 336);
            this.lblRegistracija.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegistracija.Name = "lblRegistracija";
            this.lblRegistracija.Size = new System.Drawing.Size(70, 13);
            this.lblRegistracija.TabIndex = 10;
            this.lblRegistracija.Text = "Registriraj se!";
            this.lblRegistracija.Click += new System.EventHandler(this.LblRegistracija_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Metalika.Properties.Resources.m_logo;
            this.pictureBox1.Location = new System.Drawing.Point(136, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(438, 387);
            this.Controls.Add(this.lblRegistracija);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnUlogirajSe);
            this.Controls.Add(this.tbZaporka);
            this.Controls.Add(this.lblUnesiZaporku);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbKorIme);
            this.Controls.Add(this.lblUnesiKorIme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(454, 426);
            this.MinimumSize = new System.Drawing.Size(454, 426);
            this.Name = "FrmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUnesiKorIme;
        private System.Windows.Forms.TextBox tbKorIme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUnesiZaporku;
        private System.Windows.Forms.TextBox tbZaporka;
        private System.Windows.Forms.Button btnUlogirajSe;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRegistracija;
    }
}