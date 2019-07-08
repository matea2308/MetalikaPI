using Metalika.Podatkovni_sloj;
using System;
using System.Windows.Forms;

namespace Metalika
{
    public partial class FrmUrediDodajRadniNalog : Form
    {
        private radni_nalog radniNalog;
        private int idZaposlenik;
        private KorisnikLogika korisnikLogika;
        private RadniNalogLogika radniNalogLogika;
        private ProjektLogika projektLogika;

        #region Konstruktor i početno postavljanje vrijednosti
        public FrmUrediDodajRadniNalog(object _radniNalog, int _idZaposlenik)
        {
            InitializeComponent();
            idZaposlenik = _idZaposlenik;
            radniNalog = (radni_nalog)_radniNalog;
            korisnikLogika = new KorisnikLogika();
            radniNalogLogika = new RadniNalogLogika();
            projektLogika = new ProjektLogika();
        }

        /// <summary>
        /// Metoda koja se poziva pri učitavanju forme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmUrediDodajRadniNalog_Load(object sender, EventArgs e)
        {
            cbZaposlenik.DataSource = korisnikLogika.DohvatiListuKorisnika();
            cbZaposlenik.DisplayMember = "ime";
            cbZaposlenik.ValueMember = "ID_korisnik";
            cbZaposlenik.SelectedValue = idZaposlenik;

            cbProjekt.DataSource = projektLogika.DohvatiListuProjekata();
            cbProjekt.DisplayMember = "naziv";
            cbProjekt.ValueMember = "ID_projekt";

            PrikaziVrijednosti();
        }

        /// <summary>
        /// Metoda koja služi za popunjavanje polja u slučaju
        /// uređivanja postojećeg radnog naloga
        /// </summary>
        private void PrikaziVrijednosti()
        {
            if (radniNalog != null)
            {
                tbIdNalog.Text = radniNalog.ID_nalog.ToString();
                tbOpisPostupka.Text = radniNalog.opis_postupka;
                dtpDatumPocetka.Value = radniNalog.datum_pocetka;
                dtpDatumZavrsetka.Value = radniNalog.datum_zavrsetka;
                cbZaposlenik.SelectedValue = int.Parse(radniNalog.ID_zaposlenik.ToString());
                cbProjekt.SelectedValue = int.Parse(radniNalog.ID_projekt.ToString());
            }
            else
            {
                tbIdNalog.Visible = false;
                lIdNalog.Visible = false;
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
        /// (pohranjuju se promjene/kreira novi radni nalog)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSpremiPromjene_Click(object sender, EventArgs e)
        {
            using (var db = new Entities())
            {
                if (radniNalog == null)
                {
                    radni_nalog noviNalog = new radni_nalog()
                    {
                        opis_postupka = tbOpisPostupka.Text,
                        datum_pocetka = dtpDatumPocetka.Value,
                        datum_zavrsetka = dtpDatumZavrsetka.Value,
                        ID_zaposlenik = idZaposlenik,
                        ID_projekt = int.Parse(cbProjekt.SelectedValue.ToString()),
                    };
                    if (dtpDatumZavrsetka.Value.Date >= dtpDatumPocetka.Value.Date)
                    {
                        db.radni_nalog.Add(noviNalog);
                        db.SaveChanges();
                    }
                    else MessageBox.Show("End date can't be before start date!", "Warning", MessageBoxButtons.OK);
                    
                }
                else
                {
                    db.radni_nalog.Attach(radniNalog);
                    radniNalog.opis_postupka = tbOpisPostupka.Text;
                    radniNalog.datum_pocetka = dtpDatumPocetka.Value;
                    radniNalog.datum_zavrsetka = dtpDatumZavrsetka.Value;
                    radniNalog.ID_zaposlenik = idZaposlenik;
                    radniNalog.ID_projekt = int.Parse(cbProjekt.SelectedValue.ToString());
                    radniNalog.ID_nalog = int.Parse(tbIdNalog.Text);

                    if (dtpDatumZavrsetka.Value.Date >= dtpDatumPocetka.Value.Date)
                    {
                        db.SaveChanges();
                    }
                    else MessageBox.Show("End date can't be before start date!", "Warning", MessageBoxButtons.OK);

                }
            }
            if (dtpDatumZavrsetka.Value.Date >= dtpDatumPocetka.Value.Date) this.Close();
        }

        /// <summary>
        /// Metoda koja se poziva prilikom promjene vrijednosti datuma početka
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DtpDatumPocetka_ValueChanged(object sender, EventArgs e)
        {
            if(dtpDatumPocetka.Value > dtpDatumZavrsetka.Value) dtpDatumZavrsetka.Value = dtpDatumPocetka.Value;
        }
        #endregion
    }
}
