using Metalika.Podatkovni_sloj;
using System;
using System.Windows.Forms;

namespace Metalika
{
    public partial class FrmUrediDodajPrimku : Form
    {
        private primka primka;
        private int idZaposlenik;
        private KorisnikLogika korisnikLogika;
        private DobavljacLogika dobavljacLogika;

        #region Konstruktor i početno postavljanje vrijednosti
        public FrmUrediDodajPrimku(object _primka, int _idZaposlenik)
        {
            InitializeComponent();
            idZaposlenik = _idZaposlenik;
            primka = (primka)_primka;
            korisnikLogika = new KorisnikLogika();
            dobavljacLogika = new DobavljacLogika();
        }

        /// <summary>
        /// Metoda koja se poziva pri učitavanju forme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmUrediDodajPrimku_Load(object sender, EventArgs e)
        {
            cbZaposlenik.DataSource = korisnikLogika.DohvatiListuKorisnika();
            cbZaposlenik.DisplayMember = "ime";
            cbZaposlenik.ValueMember = "ID_korisnik";

            cbZaposlenik.SelectedValue = idZaposlenik;

            cbDobavljac.DataSource = dobavljacLogika.PrikaziDobavljace();
            cbDobavljac.DisplayMember = "naziv";
            cbDobavljac.ValueMember = "ID_partner";

            PrikaziVrijednosti();
        }

        /// <summary>
        /// Metoda koja služi za popunjavanje polja u slučaju
        /// uređivanja postojeće primke
        /// </summary>
        private void PrikaziVrijednosti()
        {
            if (primka != null)
            {
                tbIdPrimka.Text = primka.ID_primka.ToString();
                tbNapomena.Text = primka.napomena;
                dtpDatumPrimke.Value = primka.datum_primke;
                cbZaposlenik.SelectedValue = int.Parse(primka.ID_zaposlenik.ToString());
                cbDobavljac.SelectedValue = int.Parse(primka.ID_dobavljac.ToString());
            }
            else
            {
                tbIdPrimka.Visible = false;
                lIdPrimka.Visible = false;
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
        /// (pohranjuju se promjene/kreira nova primka)
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
                using (var db = new Entities(Konstante.GetConnectionString()))
                {
                    if (primka == null)
                    {
                        primka novaPrimka = new primka()
                        {
                            napomena = tbNapomena.Text,
                            datum_primke = dtpDatumPrimke.Value,
                            ID_zaposlenik = idZaposlenik,
                            ID_dobavljac = int.Parse(cbDobavljac.SelectedValue.ToString()),
                        };
                        db.primka.Add(novaPrimka);
                        db.SaveChanges();
                    }
                    else
                    {
                        db.primka.Attach(primka);
                        primka.napomena = tbNapomena.Text;
                        primka.datum_primke = dtpDatumPrimke.Value;
                        primka.ID_zaposlenik = idZaposlenik;
                        primka.ID_dobavljac = int.Parse(cbDobavljac.SelectedValue.ToString());
                        primka.ID_primka = int.Parse(tbIdPrimka.Text);

                        db.SaveChanges();
                    }
                }
            }
            catch (Exception)
            {
                poruka = "Error occurred while saving delivery note (does this user already exist?)";
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