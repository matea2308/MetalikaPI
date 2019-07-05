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
            this.miPomoc = new System.Windows.Forms.ToolStripMenuItem();
            this.hpPomoc = new System.Windows.Forms.HelpProvider();
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
            this.msGlavniMeni.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.msGlavniMeni.Size = new System.Drawing.Size(981, 28);
            this.msGlavniMeni.TabIndex = 1;
            this.msGlavniMeni.Text = "Glavni meni";
            // 
            // miNaslovnica
            // 
            this.miNaslovnica.Name = "miNaslovnica";
            this.miNaslovnica.Size = new System.Drawing.Size(93, 24);
            this.miNaslovnica.Text = "Naslovnica";
            this.miNaslovnica.Visible = false;
            this.miNaslovnica.Click += new System.EventHandler(this.MiNaslovnica_Click);
            // 
            // miKorisnici
            // 
            this.miKorisnici.Name = "miKorisnici";
            this.miKorisnici.Size = new System.Drawing.Size(77, 24);
            this.miKorisnici.Text = "Korisnici";
            this.miKorisnici.Visible = false;
            this.miKorisnici.Click += new System.EventHandler(this.MiKorisnici_Click);
            // 
            // miTipoviKorisnika
            // 
            this.miTipoviKorisnika.Name = "miTipoviKorisnika";
            this.miTipoviKorisnika.Size = new System.Drawing.Size(124, 24);
            this.miTipoviKorisnika.Text = "Tipovi korisnika";
            this.miTipoviKorisnika.Visible = false;
            this.miTipoviKorisnika.Click += new System.EventHandler(this.MiTipoviKorisnika_Click);
            // 
            // miProjekti
            // 
            this.miProjekti.Name = "miProjekti";
            this.miProjekti.Size = new System.Drawing.Size(71, 24);
            this.miProjekti.Text = "Projekti";
            this.miProjekti.Visible = false;
            // 
            // miDokumenti
            // 
            this.miDokumenti.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miPrimke,
            this.miIzdatnice,
            this.miRadniNalozi});
            this.miDokumenti.Name = "miDokumenti";
            this.miDokumenti.Size = new System.Drawing.Size(94, 24);
            this.miDokumenti.Text = "Dokumenti";
            this.miDokumenti.Visible = false;
            // 
            // miPrimke
            // 
            this.miPrimke.Name = "miPrimke";
            this.miPrimke.Size = new System.Drawing.Size(166, 26);
            this.miPrimke.Text = "Primke";
            this.miPrimke.Visible = false;
            this.miPrimke.Click += new System.EventHandler(this.MiPrimke_Click);
            // 
            // miIzdatnice
            // 
            this.miIzdatnice.Name = "miIzdatnice";
            this.miIzdatnice.Size = new System.Drawing.Size(166, 26);
            this.miIzdatnice.Text = "Izdatnice";
            this.miIzdatnice.Visible = false;
            this.miIzdatnice.Click += new System.EventHandler(this.MiIzdatnice_Click);
            // 
            // miRadniNalozi
            // 
            this.miRadniNalozi.Name = "miRadniNalozi";
            this.miRadniNalozi.Size = new System.Drawing.Size(166, 26);
            this.miRadniNalozi.Text = "Radni nalozi";
            this.miRadniNalozi.Visible = false;
            this.miRadniNalozi.Click += new System.EventHandler(this.MiRadniNalozi_Click);
            // 
            // miMaterijal
            // 
            this.miMaterijal.Name = "miMaterijal";
            this.miMaterijal.Size = new System.Drawing.Size(80, 24);
            this.miMaterijal.Text = "Materijal";
            this.miMaterijal.Visible = false;
            this.miMaterijal.Click += new System.EventHandler(this.MiMaterijal_Click);
            // 
            // miJediniceMjere
            // 
            this.miJediniceMjere.Name = "miJediniceMjere";
            this.miJediniceMjere.Size = new System.Drawing.Size(116, 24);
            this.miJediniceMjere.Text = "Jedinice mjere";
            this.miJediniceMjere.Visible = false;
            this.miJediniceMjere.Click += new System.EventHandler(this.MiJediniceMjere_Click);
            // 
            // miKatalog
            // 
            this.miKatalog.Name = "miKatalog";
            this.miKatalog.Size = new System.Drawing.Size(144, 24);
            this.miKatalog.Text = "Katalog proizvoda";
            this.miKatalog.Visible = false;
            this.miKatalog.Click += new System.EventHandler(this.MiKatalog_Click);
            // 
            // miSkladiste
            // 
            this.miSkladiste.Name = "miSkladiste";
            this.miSkladiste.Size = new System.Drawing.Size(80, 24);
            this.miSkladiste.Text = "Skladište";
            this.miSkladiste.Visible = false;
            this.miSkladiste.Click += new System.EventHandler(this.MiSkladiste_Click);
            // 
            // miPomoc
            // 
            this.miPomoc.Name = "miPomoc";
            this.miPomoc.Size = new System.Drawing.Size(66, 24);
            this.miPomoc.Text = "Pomoć";
            this.miPomoc.Click += new System.EventHandler(this.MiPomoc_Click);
            // 
            // hpPomoc
            // 
            this.hpPomoc.HelpNamespace = "";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(981, 553);
            this.Controls.Add(this.msGlavniMeni);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.msGlavniMeni;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(498, 296);
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

