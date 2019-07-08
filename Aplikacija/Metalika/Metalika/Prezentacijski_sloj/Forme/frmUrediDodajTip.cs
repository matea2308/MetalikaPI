using System;
using System.Windows.Forms;
using Metalika.Podatkovni_sloj;

namespace Metalika
{
    public partial class FrmUrediDodajTip : Form
    {
        private tip_korisnika tipKorisnika;

        #region Konstruktor i početno postavljanje vrijednosti
        public FrmUrediDodajTip(object _tipKorisnika)
        {
            InitializeComponent();
            tipKorisnika = (tip_korisnika)_tipKorisnika;
        }

        /// <summary>
        /// Metoda koja se poziva prilikom učitavanja forme
        /// (poziva metodu PrikaziVrijednosti)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmUrediDodajTip_Load(object sender, EventArgs e)
        {
            PrikaziVrijednosti();
        }

        /// <summary>
        /// Metoda koja služi popunjavanju polja u slučaju uređivanja tipa korisnika
        /// </summary>
        private void PrikaziVrijednosti()
        {
            if (tipKorisnika != null)
            {
                tbIdTipKorisnika.Text = tipKorisnika.ID_tip_korisnika.ToString();
                tbNazivTipa.Text = tipKorisnika.naziv;
                tbOpis.Text = tipKorisnika.opis;
                cbOmogucen.SelectedItem = tipKorisnika.omogucen.ToString();
            }
            else
            {
                tbIdTipKorisnika.Visible = false;
                lIdTipKorisnika.Visible = false;
            }
        }
        #endregion

        #region Eventi
        /// <summary>
        /// Metoda koja se poziva prilikom klika na gumb "Odustani"
        /// (zatvara formu)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Metoda koja se poziva prilikom klika na gumb "Spremi promjene"
        /// (dodaje novi tip/sprema promjene na postojećem tipu korisnika)
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
                    if (tipKorisnika == null)
                    {
                        tip_korisnika noviTip = new tip_korisnika()
                        {
                            naziv = tbNazivTipa.Text,
                            opis = tbOpis.Text,
                            omogucen = cbOmogucen.SelectedItem.ToString()
                        };

                        if (!string.IsNullOrWhiteSpace(tbNazivTipa.Text))
                        {
                            db.tip_korisnika.Add(noviTip);
                            db.SaveChanges();
                        }
                        else poruka = "Type name is mandatory field!";
                    }
                    else
                    {
                        db.tip_korisnika.Attach(tipKorisnika);
                        tipKorisnika.naziv = tbNazivTipa.Text;
                        tipKorisnika.opis = tbOpis.Text;
                        tipKorisnika.omogucen = cbOmogucen.SelectedItem.ToString();

                        if (!string.IsNullOrWhiteSpace(tbNazivTipa.Text))
                        {
                            db.SaveChanges();
                        }
                        else poruka = "Type name is mandatory field!";

                    }
                }
            }
            catch (Exception)
            {
                poruka = "Error occurred while saving user type (does this user already exist?)";
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
