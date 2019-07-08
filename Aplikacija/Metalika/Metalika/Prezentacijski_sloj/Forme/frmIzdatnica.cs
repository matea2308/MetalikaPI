using System;
using System.Windows.Forms;
using Metalika.Podatkovni_sloj;

namespace Metalika
{
    public partial class FrmIzdatnica : Form
    {
        private korisnik korisnik;
        private IzdatnicaLogika izdatnicaLogika;

        #region Konstruktor klase i osvježavanje podataka
        public FrmIzdatnica(object _korisnik)
        {
            InitializeComponent();
            korisnik = (korisnik)_korisnik;
            izdatnicaLogika = new IzdatnicaLogika();
        }

        /// <summary>
        /// Metoda koja se poziva prilikom učitavanja forme.
        /// Učitava retke u tablice (datagridview-ove)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmIzdatnica_Load(object sender, EventArgs e)
        {
            OsvjeziIzdatnice();
            OsvjeziStavke();
        }

        /// <summary>
        /// Metoda koja služi za dohvaćanje izdatnica iz baze
        /// </summary>
        private void OsvjeziIzdatnice()
        {
            try
            {
                izdatnicaBindingSource.DataSource = izdatnicaLogika.PrikaziIzdatnice();
            }
            catch (Exception)
            {
                return;
            }
        }

        /// <summary>
        /// Metoda koja služi za dohvaćanje stavki izdatnica
        /// iz baze za selektiranu izdatnicu
        /// </summary>
        private void OsvjeziStavke()
        {
            try
            {
                if (izdatnicaBindingSource.Current is izdatnica oznaceni)
                {
                    stavkeizdatniceBindingSource.DataSource = izdatnicaLogika.PrikaziStavkeIzdatnice(oznaceni);
                }
            }
            catch (Exception)
            {
                return;
            }
        }
        #endregion

        #region Eventi
        /// <summary>
        /// Metoda koja se poziva pri promjeni selektirane izdatnice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvIzdatnice_SelectionChanged(object sender, EventArgs e)
        {
            OsvjeziStavke();
        }

        /// <summary>
        /// Metoda koja se poziva prilikom klika na gumb Dodaj (ispod tablica sa izdatnicama).
        /// Otvara formu za dodavanje/uređivanje izdatnice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            FrmUrediDodajIzdatnicu forma = new FrmUrediDodajIzdatnicu(null, korisnik.ID_korisnik);
            forma.ShowDialog();
            OsvjeziIzdatnice();
            OsvjeziStavke();
        }

        /// <summary>
        /// Metoda koja se poziva prilikom klika na gumb Uredi (ispod tablice sa izdatnicama).
        /// Otvara formu za dodavanje/uređivanje izdatnice (sa popunjenim poljima)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUredi_Click(object sender, EventArgs e)
        {
            if (izdatnicaBindingSource.Current is izdatnica oznaceni)
            {
                FrmUrediDodajIzdatnicu forma = new FrmUrediDodajIzdatnicu(oznaceni, korisnik.ID_korisnik);
                forma.ShowDialog();
                OsvjeziIzdatnice();
                OsvjeziStavke();
            }
        }

        /// <summary>
        /// Metoda koja se poziva prilikom klika na gumb Obriši (ispod tablice sa izdatnicama).
        /// Briše selektiranu izdatnicu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnObrisi_Click(object sender, EventArgs e)
        {
            string poruka = "";
            try
            {
                if (izdatnicaBindingSource.Current is izdatnica oznaceni)
                {
                    if (MessageBox.Show("Are you sure you want to delete the selected delivery note? ", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        using (var db = new Entities())
                        {
                            db.izdatnica.Attach(oznaceni);
                            db.izdatnica.Remove(oznaceni);
                            db.SaveChanges();
                        }
                    }
                    OsvjeziIzdatnice();
                    OsvjeziStavke();
                }
            }
            catch (Exception)
            { 
                poruka = "Deletion of issue note was not successful! Please check if all issue lines are deleted";
            }
            finally
            {
                if (!string.IsNullOrWhiteSpace(poruka)) MessageBox.Show(poruka);
            }
        }

        /// <summary>
        /// Metoda koja se poziva prilikom klika na gumb Dodaj (ispod tablice sa stavkama).
        /// Otvara formu za dodavanje/uređivanje stavke izdatnice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDodajStavku_Click(object sender, EventArgs e)
        {
            if (izdatnicaBindingSource.Current is izdatnica selektiranaIzdatnica)
            {
                FrmUrediDodajStavkuIzdatnice forma = new FrmUrediDodajStavkuIzdatnice(null, selektiranaIzdatnica.ID_izdatnica);
                forma.ShowDialog();
                OsvjeziIzdatnice();
                OsvjeziStavke();
            }
        }

        /// <summary>
        /// Metoda koja se poziva prilikom klika na gumb Uredi (ispod tablice sa stavkama).
        /// Otvara formu za dodavanje/uređivanje stavke izdatnice (sa popunjenim poljima)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUrediStavku_Click(object sender, EventArgs e)
        {
            if (stavkeizdatniceBindingSource.Current is stavke_izdatnice selektiranaStavka)
            {
                FrmUrediDodajStavkuIzdatnice forma = new FrmUrediDodajStavkuIzdatnice(selektiranaStavka, -1);
                forma.ShowDialog();
                OsvjeziIzdatnice();
                OsvjeziStavke();
            }
        }

        /// <summary>
        /// Metoda koja se poziva prilikom klika na gumb Obriši (ispod tablice sa stavkama).
        /// Briše selektiranu stavku izdatnice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnObrisiStavku_Click(object sender, EventArgs e)
        {
            if (stavkeizdatniceBindingSource.Current is stavke_izdatnice selektiranaStavka)
            {
                if (MessageBox.Show("Are you sure you want to delete selected issue line ?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new Entities())
                    {
                        db.stavke_izdatnice.Attach(selektiranaStavka);
                        db.stavke_izdatnice.Remove(selektiranaStavka);
                        db.SaveChanges();
                    }
                }
                OsvjeziIzdatnice();
                OsvjeziStavke();
            }
        }
        #endregion
    }
}