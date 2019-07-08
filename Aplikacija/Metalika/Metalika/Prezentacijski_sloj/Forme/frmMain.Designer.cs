namespace Metalika
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.msGlavniMeni = new System.Windows.Forms.MenuStrip();
            this.miNaslovnica = new System.Windows.Forms.ToolStripMenuItem();
            this.miKorisnici = new System.Windows.Forms.ToolStripMenuItem();
            this.miTipoviKorisnika = new System.Windows.Forms.ToolStripMenuItem();
            this.miProjekti = new System.Windows.Forms.ToolStripMenuItem();
            this.miDokumenti = new System.Windows.Forms.ToolStripMenuItem();
            this.miPrimke = new System.Windows.Forms.ToolStripMenuItem();
            this.miIzdatnice = new System.Windows.Forms.ToolStripMenuItem();
            this.miRadniNalozi = new System.Windows.Forms.ToolStripMenuItem();
            this.miMaterijal = new System.Windows.Forms.ToolStripMenuItem();
            this.miJediniceMjere = new System.Windows.Forms.ToolStripMenuItem();
            this.miKatalog = new System.Windows.Forms.ToolStripMenuItem();
            this.miSkladiste = new System.Windows.Forms.ToolStripMenuItem();
            this.hpPomoc = new System.Windows.Forms.HelpProvider();
            this.miPomoc = new System.Windows.Forms.ToolStripMenuItem();
            this.msGlavniMeni.SuspendLayout();
            this.SuspendLayout();
            // 
            // msGlavniMeni
            // 
            this.msGlavniMeni.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msGlavniMeni.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNaslovnica,
            this.miKorisnici,
            this.miTipoviKorisnika,
            this.miProjekti,
            this.miDokumenti,
            this.miMaterijal,
            this.miJediniceMjere,
            this.miKatalog,
            this.miSkladiste,
            this.miPomoc});
            this.msGlavniMeni.Location = new System.Drawing.Point(0, 0);
            this.msGlavniMeni.Name = "msGlavniMeni";
            this.msGlavniMeni.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.msGlavniMeni.Size = new System.Drawing.Size(797, 24);
            this.msGlavniMeni.TabIndex = 1;
            this.msGlavniMeni.Text = "Glavni meni";
            // 
            // miNaslovnica
            // 
            this.miNaslovnica.Name = "miNaslovnica";
            this.miNaslovnica.Size = new System.Drawing.Size(81, 20);
            this.miNaslovnica.Text = "Home page";
            this.miNaslovnica.Visible = false;
            this.miNaslovnica.Click += new System.EventHandler(this.MiNaslovnica_Click);
            // 
            // miKorisnici
            // 
            this.miKorisnici.Name = "miKorisnici";
            this.miKorisnici.Size = new System.Drawing.Size(47, 20);
            this.miKorisnici.Text = "Users";
            this.miKorisnici.Visible = false;
            this.miKorisnici.Click += new System.EventHandler(this.MiKorisnici_Click);
            // 
            // miTipoviKorisnika
            // 
            this.miTipoviKorisnika.Name = "miTipoviKorisnika";
            this.miTipoviKorisnika.Size = new System.Drawing.Size(73, 20);
            this.miTipoviKorisnika.Text = "User types";
            this.miTipoviKorisnika.Visible = false;
            this.miTipoviKorisnika.Click += new System.EventHandler(this.MiTipoviKorisnika_Click);
            // 
            // miProjekti
            // 
            this.miProjekti.Name = "miProjekti";
            this.miProjekti.Size = new System.Drawing.Size(61, 20);
            this.miProjekti.Text = "Projects";
            this.miProjekti.Visible = false;
            // 
            // miDokumenti
            // 
            this.miDokumenti.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miPrimke,
            this.miIzdatnice,
            this.miRadniNalozi});
            this.miDokumenti.Name = "miDokumenti";
            this.miDokumenti.Size = new System.Drawing.Size(80, 20);
            this.miDokumenti.Text = "Documents";
            this.miDokumenti.Visible = false;
            // 
            // miPrimke
            // 
            this.miPrimke.Name = "miPrimke";
            this.miPrimke.Size = new System.Drawing.Size(180, 22);
            this.miPrimke.Text = "Delivery notes";
            this.miPrimke.Visible = false;
            this.miPrimke.Click += new System.EventHandler(this.MiPrimke_Click);
            // 
            // miIzdatnice
            // 
            this.miIzdatnice.Name = "miIzdatnice";
            this.miIzdatnice.Size = new System.Drawing.Size(180, 22);
            this.miIzdatnice.Text = "Issue notes";
            this.miIzdatnice.Visible = false;
            this.miIzdatnice.Click += new System.EventHandler(this.MiIzdatnice_Click);
            // 
            // miRadniNalozi
            // 
            this.miRadniNalozi.Name = "miRadniNalozi";
            this.miRadniNalozi.Size = new System.Drawing.Size(180, 22);
            this.miRadniNalozi.Text = "Work orders";
            this.miRadniNalozi.Visible = false;
            this.miRadniNalozi.Click += new System.EventHandler(this.MiRadniNalozi_Click);
            // 
            // miMaterijal
            // 
            this.miMaterijal.Name = "miMaterijal";
            this.miMaterijal.Size = new System.Drawing.Size(62, 20);
            this.miMaterijal.Text = "Material";
            this.miMaterijal.Visible = false;
            this.miMaterijal.Click += new System.EventHandler(this.MiMaterijal_Click);
            // 
            // miJediniceMjere
            // 
            this.miJediniceMjere.Name = "miJediniceMjere";
            this.miJediniceMjere.Size = new System.Drawing.Size(108, 20);
            this.miJediniceMjere.Text = "Units of measure";
            this.miJediniceMjere.Visible = false;
            this.miJediniceMjere.Click += new System.EventHandler(this.MiJediniceMjere_Click);
            // 
            // miKatalog
            // 
            this.miKatalog.Name = "miKatalog";
            this.miKatalog.Size = new System.Drawing.Size(103, 20);
            this.miKatalog.Text = "Product catalog";
            this.miKatalog.Visible = false;
            this.miKatalog.Click += new System.EventHandler(this.MiKatalog_Click);
            // 
            // miSkladiste
            // 
            this.miSkladiste.Name = "miSkladiste";
            this.miSkladiste.Size = new System.Drawing.Size(78, 20);
            this.miSkladiste.Text = "Warehouse";
            this.miSkladiste.Visible = false;
            this.miSkladiste.Click += new System.EventHandler(this.MiSkladiste_Click);
            // 
            // hpPomoc
            // 
            this.hpPomoc.HelpNamespace = "";
            // 
            // miPomoc
            // 
            this.miPomoc.Name = "miPomoc";
            this.miPomoc.Size = new System.Drawing.Size(44, 20);
            this.miPomoc.Text = "Help";
            this.miPomoc.Click += new System.EventHandler(this.MiPomoc_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(797, 449);
            this.Controls.Add(this.msGlavniMeni);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.msGlavniMeni;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(378, 248);
            this.Name = "FrmMain";
            this.Text = "Metalika d.o.o";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyDown);
            this.msGlavniMeni.ResumeLayout(false);
            this.msGlavniMeni.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msGlavniMeni;
        private System.Windows.Forms.ToolStripMenuItem miKorisnici;
        private System.Windows.Forms.ToolStripMenuItem miProjekti;
        private System.Windows.Forms.ToolStripMenuItem miDokumenti;
        private System.Windows.Forms.ToolStripMenuItem miPrimke;
        private System.Windows.Forms.ToolStripMenuItem miIzdatnice;
        private System.Windows.Forms.ToolStripMenuItem miRadniNalozi;
        private System.Windows.Forms.ToolStripMenuItem miMaterijal;
        private System.Windows.Forms.ToolStripMenuItem miKatalog;
        private System.Windows.Forms.ToolStripMenuItem miTipoviKorisnika;
        private System.Windows.Forms.ToolStripMenuItem miNaslovnica;
        private System.Windows.Forms.ToolStripMenuItem miSkladiste;
        private System.Windows.Forms.ToolStripMenuItem miJediniceMjere;
        private System.Windows.Forms.HelpProvider hpPomoc;
        private System.Windows.Forms.ToolStripMenuItem miPomoc;
    }
}

