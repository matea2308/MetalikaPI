using Metalika.Podatkovni_sloj;
using System;
using System.Windows.Forms;

namespace Metalika
{
    public partial class FrmUrediDodajStavkuPrimke : Form
    {
        private stavke_primke stavkePrimke;
        private MaterijalLogika materijalLogika;
        private int idPrimka;

        #region Konstruktor i dohvaćanje vrijednosti
        public FrmUrediDodajStavkuPrimke(object _stavkePrimke, int _idPrimka)
        {
            InitializeComponent();
            stavkePrimke = (stavke_primke)_stavkePrimke;
            if (stavkePrimke == null) idPrimka = _idPrimka;
            materijalLogika = new MaterijalLogika();
        }

        /// <summary>
        /// Metoda koja se poziva prilikom učitavanja forme
        /// (postavlja izvor podataka za combobox materijala i popunjava polja)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmUrediDodajStavkuPrimke_Load(object sender, EventArgs e)
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
            if (stavkePrimke != null)
            {
                tbKolicina.Text = stavkePrimke.kolicina.ToString();
                cbMaterijal.SelectedValue = int.Parse(stavkePrimke.ID_materijal.ToString());
                tbCijena.Text = stavkePrimke.cijena.ToString();
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
        /// (dodaje novu stavku/ažurira vrijednosti postojeće stavke primke)
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
                    if (stavkePrimke == null)
                    {
                        stavke_primke novaStavka = new stavke_primke()
                        {
                            ID_materijal = int.Parse(cbMaterijal.SelectedValue.ToString()),
                            ID_primka = idPrimka,
                            kolicina = int.Parse(tbKolicina.Text),
                            cijena = int.Parse(tbCijena.Text)
                        };
                        if (!string.IsNullOrWhiteSpace(tbKolicina.Text) && int.Parse(tbKolicina.Text) > 0 && !string.IsNullOrWhiteSpace(tbCijena.Text) && int.Parse(tbCijena.Text) > 0)
                        {
                            db.stavke_primke.Add(novaStavka);
                            db.SaveChanges();
                        }
                        else poruka = "Quantity and price are mandatory fields and must be greater than 1!";
                    }
                    else
                    {
                        db.stavke_primke.Attach(stavkePrimke);
                        stavkePrimke.ID_materijal = int.Parse(cbMaterijal.SelectedValue.ToString());
                        stavkePrimke.ID_primka = int.Parse(stavkePrimke.ID_primka.ToString());
                        stavkePrimke.kolicina = int.Parse(tbKolicina.Text);
                        stavkePrimke.cijena = int.Parse(tbCijena.Text);

                        if (!string.IsNullOrWhiteSpace(tbKolicina.Text) && int.Parse(tbKolicina.Text) > 0 && !string.IsNullOrWhiteSpace(tbCijena.Text) && int.Parse(tbCijena.Text) > 0)
                        {
                            db.SaveChanges();
                        }
                        else poruka = "Quantity and price are mandatory fields and must be greater than 1!";
                    }
                }
            }
            catch (Exception)
            {
                poruka = "Error occurred while saving delivery line(does this user already exist?)";
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
