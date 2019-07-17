using System;
using System.Windows.Forms;
using Metalika.Podatkovni_sloj;

namespace Metalika
{
    public partial class FrmPrimka : Form
    {
        private korisnik korisnik;
        private PrimkaLogika primkaLogika;

        #region Konstruktor klase i osvježavanje podataka
        public FrmPrimka(object _korisnik)
        {
            InitializeComponent();
            korisnik = (korisnik)_korisnik;
            primkaLogika = new PrimkaLogika();
        }

        /// <summary>
        /// Metoda koja se poziva prilikom učitavanja forme.
        /// Učitava retke u tablice (datagridview-ove)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPrimka_Load(object sender, EventArgs e)
        {
            OsvjeziPrimke();
            OsvjeziStavke();
        }

        /// <summary>
        /// Metoda koja služi za dohvaćanje primki iz baze
        /// </summary>
        private void OsvjeziPrimke()
        {
            try
            {
                primkaBindingSource.DataSource = primkaLogika.PrikaziPrimke();
            }
            catch (Exception)
            {
                return;
            }
        }

        /// <summary>
        /// Metoda koja služi za dohvaćanje stavki primke
        /// iz baze za selektiranu primku
        /// </summary>
        private void OsvjeziStavke()
        {
            try
            {
                if (primkaBindingSource.Current is primka oznaceni)
                {
                    stavkeprimkeBindingSource.DataSource = primkaLogika.PrikaziStavkePrimke(oznaceni);
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
        /// Metoda koja se poziva pri promjeni selektirane primke
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvPrimke_SelectionChanged(object sender, EventArgs e)
        {
            OsvjeziStavke();
        }

        /// <summary>
        /// Metoda koja se poziva prilikom klika na gumb Dodaj (ispod tablica sa primkama).
        /// Otvara formu za dodavanje/uređivanje primke
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            FrmUrediDodajPrimku forma = new FrmUrediDodajPrimku(null, korisnik.ID_korisnik);
            forma.ShowDialog();
            OsvjeziPrimke();
            OsvjeziStavke();
        }

        /// <summary>
        /// Metoda koja se poziva prilikom klika na gumb Uredi (ispod tablice sa primkama).
        /// Otvara formu za dodavanje/uređivanje primke (sa popunjenim poljima)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUredi_Click(object sender, EventArgs e)
        {
            if (primkaBindingSource.Current is primka oznaceni)
            {
                FrmUrediDodajPrimku forma = new FrmUrediDodajPrimku(oznaceni, korisnik.ID_korisnik);
                forma.ShowDialog();
                OsvjeziPrimke();
                OsvjeziStavke();
            }
        }

        /// <summary>
        /// Metoda koja se poziva prilikom klika na gumb Obriši (ispod tablice sa primkama).
        /// Briše selektiranu primku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnObrisi_Click(object sender, EventArgs e)
        {
            string poruka = "";
            try
            {
                if (primkaBindingSource.Current is primka oznaceni)
                {
                    if (MessageBox.Show("Are you sure you want to delete the selected delivery note? ", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        using (var db = new Entities(Konstante.GetConnectionString()))
                        {
                            db.primka.Attach(oznaceni);
                            db.primka.Remove(oznaceni);
                            db.SaveChanges();
                        }
                    }
                    OsvjeziPrimke();
                    OsvjeziStavke();
                }
            }

            catch (Exception)
            {
                poruka = "Deletion of delivery note was not successful! Please check if all delivery lines are deleted";
            }

            finally
            {
                if (!string.IsNullOrWhiteSpace(poruka)) MessageBox.Show(poruka);
            }
        }

        /// <summary>
        /// Metoda koja se poziva prilikom klika na gumb Dodaj (ispod tablice sa stavkama).
        /// Otvara formu za dodavanje/uređivanje stavke primke
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDodajStavku_Click(object sender, EventArgs e)
        {
            if (primkaBindingSource.Current is primka selektiranaPrimka)
            {
                FrmUrediDodajStavkuPrimke forma = new FrmUrediDodajStavkuPrimke(null, selektiranaPrimka.ID_primka);
                forma.ShowDialog();
                OsvjeziPrimke();
                OsvjeziStavke();
            }
        }

        /// <summary>
        /// Metoda koja se poziva prilikom klika na gumb Uredi (ispod tablice sa stavkama).
        /// Otvara formu za dodavanje/uređivanje stavke primke (sa popunjenim poljima)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUrediStavku_Click(object sender, EventArgs e)
        {
            if (stavkeprimkeBindingSource.Current is stavke_primke selektiranaStavka)
            {
                FrmUrediDodajStavkuPrimke forma = new FrmUrediDodajStavkuPrimke(selektiranaStavka, -1);
                forma.ShowDialog();
                OsvjeziPrimke();
                OsvjeziStavke();
            }
        }

        /// <summary>
        /// Metoda koja se poziva prilikom klika na gumb Obriši (ispod tablice sa stavkama).
        /// Briše selektiranu stavku primke
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnObrisiStavku_Click(object sender, EventArgs e)
        {
            if (stavkeprimkeBindingSource.Current is stavke_primke selektiranaStavka)
            {
                if (MessageBox.Show("Are you sure you want to delete selected delivery line ?", "Warning!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new Entities(Konstante.GetConnectionString()))
                    {
                        db.stavke_primke.Attach(selektiranaStavka);
                        db.stavke_primke.Remove(selektiranaStavka);
                        db.SaveChanges();
                    }
                }
                OsvjeziPrimke();
                OsvjeziStavke();
            }
        }
        #endregion
    }
}