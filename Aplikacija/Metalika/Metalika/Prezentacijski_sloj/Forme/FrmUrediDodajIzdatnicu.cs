using Metalika.Podatkovni_sloj;
using System;
using System.Windows.Forms;

namespace Metalika
{
    public partial class FrmUrediDodajIzdatnicu : Form
    {
        private izdatnica izdatnica;
        private int idZaposlenik;
        private KorisnikLogika korisnikLogika;
        private RadniNalogLogika radniNalogLogika;

        #region Konstruktor i početno postavljanje vrijednosti
        public FrmUrediDodajIzdatnicu(object _izdatnica, int _idZaposlenik)
        {
            InitializeComponent();
            idZaposlenik = _idZaposlenik;
            izdatnica = (izdatnica)_izdatnica;
            korisnikLogika = new KorisnikLogika();
            radniNalogLogika = new RadniNalogLogika();
        }

        /// <summary>
        /// Metoda koja se poziva pri učitavanju forme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmUrediDodajIzdatnicu_Load(object sender, EventArgs e)
        {
            cbZaposlenik.DataSource = korisnikLogika.DohvatiListuKorisnika();
            cbZaposlenik.DisplayMember = "ime";
            cbZaposlenik.ValueMember = "ID_korisnik";

            cbZaposlenik.SelectedValue = idZaposlenik;

            cbNalog.DataSource = radniNalogLogika.PrikaziNaloge();
            cbNalog.DisplayMember = "opis_postupka";
            cbNalog.ValueMember = "ID_nalog";

            PrikaziVrijednosti();
        }

        /// <summary>
        /// Metoda koja služi za popunjavanje polja u slučaju
        /// uređivanja postojeće izdatnice
        /// </summary>
        private void PrikaziVrijednosti()
        {
            if (izdatnica != null)
            {
                tbIdIzdatnica.Text = izdatnica.ID_izdatnica.ToString();
                tbNapomena.Text = izdatnica.napomena;
                dtpDatumIzdatnice.Value = izdatnica.datum_izdatnice;
                cbZaposlenik.SelectedValue = int.Parse(izdatnica.ID_zaposlenik.ToString());
                cbNalog.SelectedValue = int.Parse(izdatnica.ID_nalog.ToString());
            }
            else
            {
                tbIdIzdatnica.Visible = false;
                lIdIzdatnica.Visible = false;
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
        /// (pohranjuju se promjene/kreira nova izdatnica)
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
                    if (izdatnica == null)
                    {
                        izdatnica novaIzdatnica = new izdatnica()
                        {
                            napomena = tbNapomena.Text,
                            datum_izdatnice = dtpDatumIzdatnice.Value,
                            ID_zaposlenik = idZaposlenik,
                            ID_nalog = int.Parse(cbNalog.SelectedValue.ToString()),
                        };
                        db.izdatnica.Add(novaIzdatnica);
                        db.SaveChanges();
                    }
                    else
                    {
                        db.izdatnica.Attach(izdatnica);
                        izdatnica.napomena = tbNapomena.Text;
                        izdatnica.datum_izdatnice = dtpDatumIzdatnice.Value;
                        izdatnica.ID_zaposlenik = idZaposlenik;
                        izdatnica.ID_nalog = int.Parse(cbNalog.SelectedValue.ToString());
                        izdatnica.ID_izdatnica = int.Parse(tbIdIzdatnica.Text);

                        db.SaveChanges();
                    }
                }
            }
            catch (Exception)
            {
                poruka = "Error occurred while saving issue note (does this user already exist?)";
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
