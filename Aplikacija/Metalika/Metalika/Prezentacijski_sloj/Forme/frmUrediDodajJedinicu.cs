using Metalika.Podatkovni_sloj;
using System;
using System.Windows.Forms;

namespace Metalika
{
    public partial class FrmUrediDodajJedinicu : Form
    {
        private jedinica_mjere jedinicaMjere;

        #region Konstruktor i početno postavljanje vrijednosti
        public FrmUrediDodajJedinicu(object _jedMjere)
        {
            InitializeComponent();
            jedinicaMjere = (jedinica_mjere)_jedMjere;
        }
        /// <summary>
        /// Metoda koja se poziva pri učitavanju forme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmUrediDodajJedinicu_Load(object sender, EventArgs e)
        {
            PrikaziVrijednosti();
        }

        /// <summary>
        /// Metoda koja služi za popunjavanje polja u slučaju
        /// uređivanja postojeće jedinice mjere
        /// </summary>
        private void PrikaziVrijednosti()
        {
            if (jedinicaMjere != null)
            {
                tbIdJedMjere.Text = jedinicaMjere.ID_jed_mjere;
                tbZnacenje.Text = jedinicaMjere.znacenje;
            }
        }
        #endregion

        #region Eventi
        /// <summary>
        /// Metoda koja se poziva kada se pritiske gumb Odustani
        /// (zatvara se forma)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Metoda koja se poziva kada se pritisne gumb Spremi
        /// (pohranjuju se promjene/kreira nova jedinica mjere)
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
                    if (jedinicaMjere == null)
                    {
                        jedinica_mjere novaJedinica = new jedinica_mjere()
                        {
                            ID_jed_mjere = tbIdJedMjere.Text,
                            znacenje = tbZnacenje.Text
                        };
                        db.jedinica_mjere.Add(novaJedinica);
                        if (!string.IsNullOrWhiteSpace(tbIdJedMjere.Text) && !string.IsNullOrWhiteSpace(tbZnacenje.Text))
                        {
                            db.SaveChanges();
                        }
                        else poruka = "ID unit of measure and meaning are mandatory fields!";
                    }
                    else
                    {
                        db.jedinica_mjere.Attach(jedinicaMjere);
                        jedinicaMjere.ID_jed_mjere = tbIdJedMjere.Text;
                        jedinicaMjere.znacenje = tbZnacenje.Text;

                        if (!string.IsNullOrWhiteSpace(tbIdJedMjere.Text) && !string.IsNullOrWhiteSpace(tbZnacenje.Text))
                        {
                            db.SaveChanges();
                        }
                        else poruka = "ID unit of measure and meaning are mandatory fields!";

                    }
                }
            }
            catch (Exception)
            {
                poruka = "Error occurred while saving unit of measure (does this user already exist?)";
            }
            finally
            {
                if (!string.IsNullOrWhiteSpace(poruka)) MessageBox.Show(poruka);
                else Close();
            }
            
        }
        #endregion

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
