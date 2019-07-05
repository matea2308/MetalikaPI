using Metalika.Podatkovni_sloj;
using System;
using System.Windows.Forms;

namespace Metalika
{
    public partial class FrmUrediDodajStavkuNaloga : Form
    {
        private stavke_naloga stavkeNaloga;
        private MaterijalLogika materijalLogika;
        private int idNalog;

        #region Konstruktor i dohvaćanje vrijednosti
        public FrmUrediDodajStavkuNaloga(object _stavkeNaloga, int _idNalog)
        {
            InitializeComponent();
            stavkeNaloga = (stavke_naloga) _stavkeNaloga;
            if (stavkeNaloga == null) idNalog = _idNalog;
            materijalLogika = new MaterijalLogika();
        }

        /// <summary>
        /// Metoda koja se poziva prilikom učitavanja forme
        /// (postavlja izvor podataka za combobox materijala i popunjava polja)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmUrediDodajStavkuNaloga_Load(object sender, EventArgs e)
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
            if (stavkeNaloga != null)
            {
                tbKolicina.Text = stavkeNaloga.kolicina.ToString();
                cbMaterijal.SelectedValue = int.Parse(stavkeNaloga.ID_materijal.ToString());
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
        /// (dodaje novu stavku/ažurira vrijednosti postojeće stavke radnog naloga)
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
                    if (stavkeNaloga == null)
                    {
                        stavke_naloga novaStavka = new stavke_naloga()
                        {
                            ID_materijal = int.Parse(cbMaterijal.SelectedValue.ToString()),
                            ID_nalog = idNalog,
                            kolicina = int.Parse(tbKolicina.Text)
                        };
                        if (!string.IsNullOrWhiteSpace(tbKolicina.Text) && int.Parse(tbKolicina.Text) > 0)
                        {
                            db.stavke_naloga.Add(novaStavka);
                            db.SaveChanges();
                        }
                        else poruka = "Količina mora biti unešena!";
                    }
                    else
                    {
                        db.stavke_naloga.Attach(stavkeNaloga);
                        stavkeNaloga.ID_materijal = int.Parse(cbMaterijal.SelectedValue.ToString());
                        stavkeNaloga.ID_nalog = int.Parse(stavkeNaloga.ID_nalog.ToString());
                        stavkeNaloga.kolicina = int.Parse(tbKolicina.Text);

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
                poruka = "Greška prilikom spremanja stavke radnog naloga u bazu (da li ovi podaci već postoje u bazi?)";
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
