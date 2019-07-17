using EncryptString;
using Metalika.Podatkovni_sloj;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Metalika
{
    public partial class FrmPromjenaZaporke : Form
    {
        private string korisnickoIme;

        #region Konstruktor
        public FrmPromjenaZaporke(string _korIme)
        {
            InitializeComponent();
            korisnickoIme = _korIme;
        }
        #endregion

        #region Eventi
        /// <summary>
        /// Metoda koja se poziva prilikom klika na gumb "Odustani"
        /// (zatvara se forma za promjenu zaporke)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Metoda koja se poziva prilikom promjene u polju nove zaporke
        /// ili polju potvrde nove zaporke. Ako se zaporke podudaraju,
        /// pravokutnik je zelene boje. Inače je crvene boje.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbNovaZaporka_TextChanged(object sender, EventArgs e)
        {
            if (tbNovaZaporka.Text.Equals(tbPotvrdiZaporku.Text)) pZaporke.BackColor = Color.Green;
            else pZaporke.BackColor = Color.Red;
        }

        /// <summary>
        /// Metoda koja se poziva prilikom klika na gumb "Spremi promjene".
        /// Ako se zaporke podudaraju i ako polja nisu prazna, zaporka se ažurira
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSpremiPromjene_Click(object sender, EventArgs e)
        {
            string poruka = "";
            try
            {
                if (pZaporke.BackColor == Color.Green && !string.IsNullOrWhiteSpace(tbNovaZaporka.Text))
                {
                    using (var db = new Entities(Konstante.GetConnectionString()))
                    {
                        var trenutniKorisnik = db.korisnik.Where(x => x.korisnicko_ime.Equals(korisnickoIme)).Single();
                        db.korisnik.Attach(trenutniKorisnik);

                        // ako polje za unos zaporke nije prazno, prije pohrane korisnika, enkriptiraj zaporku
                        if (!string.IsNullOrWhiteSpace(tbNovaZaporka.Text))
                        {
                            trenutniKorisnik.zaporka = Enkripcija.Enkriptiranje(tbNovaZaporka.Text, Konstante.EnkripcijskiKljuc);
                        }
                        else trenutniKorisnik.zaporka = tbNovaZaporka.Text;

                        db.SaveChanges();
                    }
                }
                else poruka = "passwords don't match!";
            }
            catch (Exception)
            {
                poruka = "Error occurred during password update. Please check your internet connection!";
            }
            finally
            {
                if (!string.IsNullOrWhiteSpace(poruka)) MessageBox.Show(poruka);
                else
                {
                    MessageBox.Show("Password updated!", "Notification", MessageBoxButtons.OK);
                    Close();
                }
            }
        }
        #endregion
    }
}
