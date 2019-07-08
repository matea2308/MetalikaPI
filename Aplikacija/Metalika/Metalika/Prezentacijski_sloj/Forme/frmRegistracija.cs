using EncryptString;
using Metalika.Podatkovni_sloj;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Metalika
{
    public partial class FrmRegistracija : Form
    {
        private korisnik korisnik;
        private TipKorisnikaLogika tipKorisnikaLogika;

        #region Konstruktor i početno postavljanje vrijednosti
        public FrmRegistracija(object _korisnik)
        {
            InitializeComponent();
            korisnik = (korisnik) _korisnik;
            tipKorisnikaLogika = new TipKorisnikaLogika();
        }

        /// <summary>
        /// Metoda koja se poziva prilikom učitavanja forme
        /// (poziva metodu PrikaziVrijednosti)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmRegistracija_Load(object sender, EventArgs e)
        {
            cbTipKorisnika.DataSource = tipKorisnikaLogika.DohvatiListuTipovaKorisnika();
            cbTipKorisnika.DisplayMember = "naziv";
            cbTipKorisnika.ValueMember = "ID_tip_korisnika";

            PrikaziVrijednosti();
        }

        /// <summary>
        /// Metoda koja služi popunjavanju polja u slučaju uređivanja tipa korisnika
        /// </summary>
        private void PrikaziVrijednosti()
        {
            if (korisnik != null)
            {
                tbIdKorisnik.Text = korisnik.ID_korisnik.ToString();
                tbKorisnickoIme.Text = korisnik.korisnicko_ime;
                tbNovaZaporka.Text = Enkripcija.Dekriptiranje(korisnik.zaporka, Konstante.EnkripcijskiKljuc);
                tbPotvrdiZaporku.Text = Enkripcija.Dekriptiranje(korisnik.zaporka, Konstante.EnkripcijskiKljuc);
                cbOmogucen.SelectedItem = korisnik.omogucen.ToString();
                cbTipKorisnika.SelectedItem = korisnik.ID_tip_korisnika.ToString();
                tbIme.Text = korisnik.ime;
                tbPrezime.Text = korisnik.prezime;
                dtpDatumRodjenja.Value = korisnik.datum_rodjenja;
                tbAdresa.Text = korisnik.adresa;
                tbTelefon.Text = korisnik.telefon;
            }
            else
            {
                tbIdKorisnik.Visible = false;
                lIdKorisnik.Visible = false;
            }

            // limitiramo date time picker kako ne bi mogli postaviti da je korisnik maloljetan npr. ima 2 godine
            dtpDatumRodjenja.MaxDate = DateTime.Now.AddYears(-18);
        }

        #endregion

        #region Eventi
        /// <summary>
        /// Metoda koja provjerava da li su sva obavezna polja popunjena
        /// </summary>
        /// <param name="korisnik"></param>
        /// <returns>Vraća false ako jesu, ili true ako postoji greška</returns>
        private bool ProvjeriVrijednosti(korisnik korisnik)
        {

            if (string.IsNullOrWhiteSpace(korisnik.korisnicko_ime)) return true;
            else if (string.IsNullOrWhiteSpace(korisnik.ime)) return true;
            else if (string.IsNullOrWhiteSpace(korisnik.prezime)) return true;
            else if (string.IsNullOrWhiteSpace(korisnik.omogucen)) return true;
            else if (string.IsNullOrWhiteSpace(korisnik.datum_rodjenja.ToString())) return true;
            else if (string.IsNullOrWhiteSpace(korisnik.adresa)) return true;
            else if (string.IsNullOrWhiteSpace(korisnik.telefon)) return true;
            else if (string.IsNullOrWhiteSpace(korisnik.ID_tip_korisnika.ToString())) return true;
            else return false;
        }

        /// <summary>
        /// Metoda koja se poziva kada se promjeni sadržaj tbNovaZaporka
        /// ili tbPotvrdiZaporku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbNovaZaporka_TextChanged(object sender, EventArgs e)
        {
            if (tbNovaZaporka.Text.Equals(tbPotvrdiZaporku.Text)) pZaporke.BackColor = Color.Green;
            else pZaporke.BackColor = Color.Red;
        }

        /// <summary>
        /// Metoda koja se poziva prilikom klika na gumb "Odustani"
        /// (zatvara se forma)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Metoda koja se poziva prilikom klika na gumb "Spremi promjene"
        /// korisnik se ažurira/novi korisnik se pohranjuje u bazu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSpremiPromjene_Click(object sender, EventArgs e)
        {
            // varijabla koja se koristi u slučaju greške (sadržava poruku koja će se prikazati)
            string poruka = "";

            // kod se nalazi unutar try-catch-finally bloka kako bi uspješno detektirali greške kao što su CONSTRAINT Violation
            try
            {
                using (var db = new Entities())
                {
                    if (korisnik == null)
                    {
                        korisnik noviKorisnik = new korisnik()
                        {
                            korisnicko_ime = tbKorisnickoIme.Text,
                            ime = tbIme.Text,
                            prezime = tbPrezime.Text,
                            datum_rodjenja = dtpDatumRodjenja.Value,
                            datum_registracije = DateTime.Now,
                            adresa = tbAdresa.Text,
                            telefon = tbTelefon.Text,
                            ID_tip_korisnika = int.Parse(cbTipKorisnika.SelectedValue.ToString()),
                            omogucen = cbOmogucen.SelectedItem.ToString()
                        };

                        // ako polje za unos zaporke nije prazno, prije pohrane korisnika, enkriptiraj zaporku
                        if (!string.IsNullOrWhiteSpace(tbNovaZaporka.Text))
                        {
                            noviKorisnik.zaporka = Enkripcija.Enkriptiranje(tbNovaZaporka.Text, Konstante.EnkripcijskiKljuc);
                        }
                        else noviKorisnik.zaporka = tbNovaZaporka.Text;

                        if (!ProvjeriVrijednosti(noviKorisnik) && pZaporke.BackColor == Color.Green)
                        {
                            db.korisnik.Add(noviKorisnik);
                            db.SaveChanges();
                        }
                        else poruka = "Make sure all required fields are populated and passwords match!";
                    }
                    else
                    {
                        db.korisnik.Attach(korisnik);
                        korisnik.korisnicko_ime = tbKorisnickoIme.Text;
                        korisnik.ime = tbIme.Text;
                        korisnik.prezime = tbPrezime.Text;
                        korisnik.datum_rodjenja = dtpDatumRodjenja.Value;
                        korisnik.adresa = tbAdresa.Text;
                        korisnik.telefon = tbTelefon.Text;
                        korisnik.ID_tip_korisnika = int.Parse(cbTipKorisnika.SelectedValue.ToString());
                        korisnik.omogucen = cbOmogucen.SelectedItem.ToString();

                        // ako polje za unos zaporke nije prazno, prije pohrane korisnika, enkriptiraj zaporku
                        if (!string.IsNullOrWhiteSpace(tbNovaZaporka.Text))
                        {
                            korisnik.zaporka = Enkripcija.Enkriptiranje(tbNovaZaporka.Text, Konstante.EnkripcijskiKljuc);
                        }
                        else korisnik.zaporka = tbNovaZaporka.Text;

                        if (!ProvjeriVrijednosti(korisnik) && pZaporke.BackColor == Color.Green)
                        {
                            db.SaveChanges();
                        }
                        else poruka = "Make sure all required fields are populated and passwords match!";

                    }
                }
            }
            catch (Exception)
            {
                poruka = "Error occurred while saving user (does this user already exist?)";
            }
            finally
            {
                if (!string.IsNullOrWhiteSpace(poruka)) MessageBox.Show(poruka);
                else Close();
            }
        }
        #endregion
    }
}
