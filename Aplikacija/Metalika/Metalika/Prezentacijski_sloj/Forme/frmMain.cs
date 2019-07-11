using Metalika.Podatkovni_sloj;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Metalika
{
    public partial class FrmMain : Form
    {
        private FrmLogin loginForma;
        private korisnik korisnik;
        private string korIme;

        #region Konstruktor i osvježavanje prikaza
        public FrmMain(FrmLogin _forma, string _korIme)
        {
            InitializeComponent();
            loginForma = _forma;
            korIme = _korIme;

            //postavljanje lokacije helpa
            hpPomoc.HelpNamespace = @"Prezentacijski_sloj\Help\Metalika Help.chm";
        }

        /// <summary>
        /// Metoda koja definira koje opcije će biti dostupne pojedinom tipu korisnika
        /// </summary>
        /// <param name="idTipKorisnika">tip korisnika</param>
        private void PrikaziIzbornik(int idTipKorisnika)
        {
            string tipKorisnika;
            using(var db = new Entities())
            {
                var tip = db.tip_korisnika.Where(x => x.ID_tip_korisnika == idTipKorisnika).Single();
                tipKorisnika = tip.naziv;
            }

            switch (tipKorisnika)
            {
                case "Admin":
                    miNaslovnica.Visible = true;
                    miKorisnici.Visible = true;
                    miTipoviKorisnika.Visible = true;
                    miKatalog.Visible = true;
                    miJediniceMjere.Visible = true;
                    break;
                case "Warehouse worker":
                    miNaslovnica.Visible = true;
                    miSkladiste.Visible = true;
                    miDokumenti.Visible = true;
                    miPrimke.Visible = true;
                    miIzdatnice.Visible = true;
                    miMaterijal.Visible = true;
                    miKatalog.Visible = true;
                    break;
                case "Planner":
                    miNaslovnica.Visible = true;
                    miProjekti.Visible = true;
                    miKatalog.Visible = true;
                    break;
                case "Production management":
                    miNaslovnica.Visible = true;
                    miProjekti.Visible = true;
                    miSkladiste.Visible = true;
                    miKatalog.Visible = true;
                    miDokumenti.Visible = true;
                    miRadniNalozi.Visible = true;
                    break;
            }
        }

        /// <summary>
        /// Metoda koja se koristi za promjenu sadržaja/djeteta MDI kontejnera,
        /// a MDI kontejner je FrmMain
        /// </summary>
        /// <param name="forma">forma s kojom zamjenjujemo trenutni sadržaj</param>
        private void PrikaziFormu(Form forma)
        {
            /*
             * ako postoji trenutno/aktivno dijete MDI kontejnera i ako tip forme (koju prosljeđujemo metodi)
             * nije jednak tipu trenutnog/aktivnog djeteta kontejnera, zatvori aktivno dijete, postavi
             * FrmMain (forma dohvaćena uz pomoću "this") kao roditelja forme koju prosljeđujemo te prikaži tu
             * formu maksimizirano. Ako pak nema aktivnog djeteta kontejnera, postavi FrmMain kao roditelja
             * forme koju prosljeđujemo te prikaži tu formu maksimizirano
             */

            if (ActiveMdiChild != null && forma.GetType() != ActiveMdiChild.GetType())
            {
                ActiveMdiChild.Close();
                forma.MdiParent = this;
                forma.WindowState = FormWindowState.Maximized;

                forma.Show();
            }
            else if (ActiveMdiChild == null)
            {
                forma.MdiParent = this;
                forma.WindowState = FormWindowState.Maximized;
                forma.Show();
            }
        }
        #endregion

        #region Eventi
        /// <summary>
        /// Metoda koja se poziva prilikom učitavanja forme. Otvara formu
        /// u maksimiziranom načinu rada, prikazuje izbornik/meni s obzirom
        /// na tip korisnika, te prikazuje FrmPocetna formu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            using(var db = new Entities())
            {
                korisnik = db.korisnik.Where(x => x.korisnicko_ime.Equals(korIme)).Single();
            }
            PrikaziIzbornik(korisnik.ID_tip_korisnika);
            PrikaziFormu(new FrmPocetna(korisnik));
        }

        /// <summary>
        /// Metoda koja se poziva prilikom zatvaranja forme
        /// (pokazuje FrmLogin koju smo prethodno sakrili)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginForma.Show();
        }

        /// <summary>
        /// Metoda koja se poziva kada se klikne na element izbornika "Korisnici"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MiKorisnici_Click(object sender, EventArgs e)
        {
            PrikaziFormu(new FrmKorisnik());
        }

        /// <summary>
        /// Metoda koja se poziva kada se klikne na element izbornika "Katalog"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MiKatalog_Click(object sender, EventArgs e)
        {
            PrikaziFormu(new FrmKatalog());
        }

        /// <summary>
        /// Metoda koja se poziva kada se klikne na element izbornika "Tipovi korisnika"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MiTipoviKorisnika_Click(object sender, EventArgs e)
        {
            PrikaziFormu(new FrmTipKorisnika());
        }

        /// <summary>
        /// Metoda koja se poziva kada se klikne na element izbornika "Naslovnica"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MiNaslovnica_Click(object sender, EventArgs e)
        {
            PrikaziFormu(new FrmPocetna(korisnik));
        }

        /// <summary>
        /// Metoda koja se poziva kada se klikne na element izbornika "Materijal"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MiMaterijal_Click(object sender, EventArgs e)
        {
            PrikaziFormu(new FrmMaterijal());
        }

        /// <summary>
        /// Metoda koja se poziva kada se klikne na element izbornika "Jedinice mjere"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MiJediniceMjere_Click(object sender, EventArgs e)
        {
            PrikaziFormu(new FrmJedMjere());
        }

        /// <summary>
        /// Metoda koja se poziva kada se klikne na element izbornika "Radni nalozi"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MiRadniNalozi_Click(object sender, EventArgs e)
        {
            PrikaziFormu(new FrmRadniNalog(korisnik));
        }

        /// <summary>
        /// Metoda koja se poziva kada se klikne na element izbornika "Izdatnice"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MiIzdatnice_Click(object sender, EventArgs e)
        {
            PrikaziFormu(new FrmIzdatnica(korisnik));
        }

        /// <summary>
        /// Metoda koja se poziva kada se klikne na element izbornika "Primke"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MiPrimke_Click(object sender, EventArgs e)
        {
            PrikaziFormu(new FrmPrimka(korisnik));
        }

        /// <summary>
        /// Metoda koja se poziva kada se klikne na element izbornika "Pomoć"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MiPomoc_Click(object sender, EventArgs e)
        {
            try
            {
                Help.ShowHelp(this, hpPomoc.HelpNamespace);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Metoda koja se poziva kada se klikne na element izbornika "Skladište"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MiSkladiste_Click(object sender, EventArgs e)
        {
            PrikaziFormu(new FrmStanjeSkladista());
        }

        /// <summary>
        /// Metoda koja se poziva kada se pritisne "F1"
        /// (otvara pomoć)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                try
                {
                    Help.ShowHelp(this, hpPomoc.HelpNamespace);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion
    }
}
