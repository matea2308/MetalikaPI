using Metalika.Podatkovni_sloj;
using System;
using System.Windows.Forms;

namespace Metalika
{
    public partial class FrmUrediDodajStavkuIzdatnice : Form
    {
        private stavke_izdatnice stavkeIzdatnice;
        private MaterijalLogika materijalLogika;
        private int idIzdatnica;

        #region Konstruktor i dohvaćanje vrijednosti
        public FrmUrediDodajStavkuIzdatnice(object _stavkeIzdatnice, int _idIzdatnica)
        {
            InitializeComponent();
            stavkeIzdatnice = (stavke_izdatnice)_stavkeIzdatnice;
            if (stavkeIzdatnice == null) idIzdatnica = _idIzdatnica;
            materijalLogika = new MaterijalLogika();
        }

        /// <summary>
        /// Metoda koja se poziva prilikom učitavanja forme
        /// (postavlja izvor podataka za combobox materijala i popunjava polja)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmUrediDodajStavkuIzdatnice_Load(object sender, EventArgs e)
        {
            cbMaterijal.DataSource = materijalLogika.DohvatiListuMaterijala();
            cbMaterijal.DisplayMember = "naziv_materijala";
            cbMaterijal.ValueMember = "ID_materijal";

            PrikaziVrijednosti();
        }

        /// <summary>
        /// Metoda koja služi za popunjavanje polja forme u slučaju ažuriranja
        /// </summary>
        private void PrikaziVrijednosti()
        {
            if (stavkeIzdatnice != null)
            {
                tbKolicina.Text = stavkeIzdatnice.kolicina.ToString();
                cbMaterijal.SelectedValue = int.Parse(stavkeIzdatnice.ID_materijal.ToString());
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
        /// (dodaje novu stavku/ažurira vrijednosti postojeće stavke izdatnice)
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
                    if (stavkeIzdatnice == null)
                    {
                        stavke_izdatnice novaStavka = new stavke_izdatnice()
                        {
                            ID_materijal = int.Parse(cbMaterijal.SelectedValue.ToString()),
                            ID_izdatnica = idIzdatnica,
                            kolicina = int.Parse(tbKolicina.Text)
                        };
                        if (!string.IsNullOrWhiteSpace(tbKolicina.Text) && int.Parse(tbKolicina.Text) > 0)
                        {
                            db.stavke_izdatnice.Add(novaStavka);
                            db.SaveChanges();
                        }
                        else poruka = "Količina mora biti unešena!";
                    }
                    else
                    {
                        db.stavke_izdatnice.Attach(stavkeIzdatnice);
                        stavkeIzdatnice.ID_materijal = int.Parse(cbMaterijal.SelectedValue.ToString());
                        stavkeIzdatnice.ID_izdatnica = int.Parse(stavkeIzdatnice.ID_izdatnica.ToString());
                        stavkeIzdatnice.kolicina = int.Parse(tbKolicina.Text);

                        if (!string.IsNullOrWhiteSpace(tbKolicina.Text) && int.Parse(tbKolicina.Text) > 0)
                        {
                            db.SaveChanges();
                        }
                        else poruka = "Količina mora biti unešena!";
                    }
                }
            }
            catch (Exception)
            {
                poruka = "Greška prilikom spremanja stavke izdatnice u bazu (da li ovi podaci već postoje u bazi?)";
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
