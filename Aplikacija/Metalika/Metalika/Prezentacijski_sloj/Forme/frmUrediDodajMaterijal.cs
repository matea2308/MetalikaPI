using Metalika.Podatkovni_sloj;
using System;
using System.Windows.Forms;

namespace Metalika
{
    public partial class FrmUrediDodajMaterijal : Form
    {
        private materijal materijal;
        private JedinicaMjereLogika jedinicaMjereLogika;

        #region Konstruktor i početno postavljanje vrijednosti
        public FrmUrediDodajMaterijal(object _materijal)
        {
            InitializeComponent();
            materijal = (materijal) _materijal;
            jedinicaMjereLogika = new JedinicaMjereLogika();
        }

        /// <summary>
        /// Metoda koja se poziva prilikom učitavanja forme
        /// (poziva metodu PrikaziVrijednosti)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmUrediDodajMaterijal_Load(object sender, EventArgs e)
        {
            PrikaziVrijednosti();
        }

        /// <summary>
        /// Metoda koja služi za prikazivanje podataka dohvaćenih iz baze
        /// u datagridview-u
        /// </summary>
        private void PrikaziVrijednosti()
        {
            cbJedMjere.DataSource = jedinicaMjereLogika.PrikaziJediniceMjere();
            cbJedMjere.DisplayMember = "znacenje";
            cbJedMjere.ValueMember = "ID_jed_mjere";

            if (materijal != null)
            {
                tbIdMaterijal.Text = materijal.ID_materijal.ToString();
                tbNazivMaterijala.Text = materijal.naziv_materijala;
                tbDimenzije.Text = materijal.dimenzije;
                tbSastav.Text = materijal.sastav;
                tbDodatneInfo.Text = materijal.dodatne_informacije;
                cbJedMjere.SelectedValue = materijal.ID_jed_mjere;
            }
            else
            {
                tbIdMaterijal.Visible = false;
                lIdMaterijal.Visible = false;
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
        /// (materijal se ažurira/dodaje se novi materijal u bazu)
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
                    if (materijal == null)
                    {
                        materijal noviMaterijal = new materijal()
                        {
                            naziv_materijala = tbNazivMaterijala.Text,
                            dimenzije = tbDimenzije.Text,
                            sastav = tbSastav.Text,
                            dodatne_informacije = tbDodatneInfo.Text,
                            ID_jed_mjere = cbJedMjere.SelectedValue.ToString()
                        };
                        
                        if (!string.IsNullOrWhiteSpace(tbNazivMaterijala.Text) && !string.IsNullOrWhiteSpace(tbDimenzije.Text) && !string.IsNullOrWhiteSpace(tbSastav.Text))
                        {
                            db.materijal.Add(noviMaterijal);
                            db.SaveChanges();
                        }
                        else poruka = "Material name, dimensions and composition are mandatory fields!";
                    }
                    else
                    {
                        db.materijal.Attach(materijal);
                        materijal.naziv_materijala = tbNazivMaterijala.Text;
                        materijal.dimenzije = tbDimenzije.Text;
                        materijal.sastav = tbSastav.Text;
                        materijal.dodatne_informacije = tbDodatneInfo.Text;
                        materijal.ID_jed_mjere = cbJedMjere.SelectedValue.ToString();
                        materijal.ID_materijal = int.Parse(tbIdMaterijal.Text);

                        if (!string.IsNullOrWhiteSpace(tbNazivMaterijala.Text) && !string.IsNullOrWhiteSpace(tbDimenzije.Text) && !string.IsNullOrWhiteSpace(tbSastav.Text))
                        {
                            db.SaveChanges();
                        }
                        else poruka = "Material name, dimensions and composition are mandatory fields!";

                    }
                }
            }
            catch (Exception)
            {
                poruka = "Error occurred while saving material (does this user already exist?)"; ;
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
