using System;
using System.Windows.Forms;
using Metalika.Podatkovni_sloj;

namespace Metalika
{
    public partial class FrmKorisnik : Form
    {
        private KorisnikLogika korisnikLogika;

        #region Konstruktor klase i osvježavanje podataka
        public FrmKorisnik()
        {
            InitializeComponent();
            korisnikLogika = new KorisnikLogika();
        }

        /// <summary>
        /// Metoda koja se poziva pri učitavanju forme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmKorisnik_Load(object sender, EventArgs e)
        {
            OsvjeziKorisnike();
        }

        /// <summary>
        /// Metoda koja postavlja listu korisnika
        /// (koja se dohvaća preko metode klase JedinicaMjeraLogika)
        /// za izvor podataka datagridview-a forme
        /// </summary>
        private void OsvjeziKorisnike()
        {
            try
            {
                korisnikBindingSource.DataSource = korisnikLogika.DohvatiListuKorisnika();
            }
            catch (Exception)
            {
                return;
            } 
        }
        #endregion

        #region Eventi
        /// <summary>
        /// Metoda koja se poziva prilikom klika na gumb "Dodaj"
        /// (otvara formu za dodavanje/uređivanje korisnika)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            FrmRegistracija forma = new FrmRegistracija(null);
            forma.ShowDialog();
            OsvjeziKorisnike();
        }

        /// <summary>
        /// Metoda koja se poziva prilikom klika na gumb "Uredi"
        /// (otvara formu za dodavanje/uređivanje korisnika sa popunjenim poljima)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUredi_Click(object sender, EventArgs e)
        {
            if (korisnikBindingSource.Current is korisnik oznaceni)
            {
                FrmRegistracija forma = new FrmRegistracija(oznaceni);
                forma.ShowDialog();
                OsvjeziKorisnike();
            }  
        }

        /// <summary>
        /// Metoda koja se poziva prilikom klika na gumb "Obriši"
        /// Briše selektiranog korisnika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnObrisi_Click(object sender, EventArgs e)
        {
            if (korisnikBindingSource.Current is korisnik oznaceni)
            {
                if (MessageBox.Show("Da li ste sigurni da želite izbrisati označenog korisnika ?", "Upozorenje", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (var db = new Entities())
                    {
                        db.korisnik.Attach(oznaceni);
                        db.korisnik.Remove(oznaceni);
                        db.SaveChanges();
                    }
                }
                OsvjeziKorisnike();
            }
        }
        #endregion
    }
}
