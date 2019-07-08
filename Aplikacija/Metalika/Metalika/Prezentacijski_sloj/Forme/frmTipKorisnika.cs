using Metalika.Podatkovni_sloj;
using System;
using System.Windows.Forms;

namespace Metalika
{
    public partial class FrmTipKorisnika : Form
    {
        private TipKorisnikaLogika tipKorisnikaLogika;

        #region Konstruktor klase i osvježavanje podataka
        public FrmTipKorisnika()
        {
            InitializeComponent();
            tipKorisnikaLogika = new TipKorisnikaLogika();
        }

        /// <summary>
        /// Metoda koja se poziva pri učitavanju forme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmTipKorisnika_Load(object sender, EventArgs e)
        {
            OsvjeziTipove();
        }

        /// <summary>
        /// Metoda koja postavlja listu tipova korisnika 
        /// (koja se dohvaća preko metode klase TipKorisnikaLogika)
        /// za izvor podataka datagridview-a forme
        /// </summary>
        private void OsvjeziTipove()
        {
            try
            {
                tipkorisnikaBindingSource.DataSource = tipKorisnikaLogika.DohvatiListuTipovaKorisnika();
            }
            catch (Exception)
            {
                return;
            }
            
        }
        #endregion

        #region Eventi
        /// <summary>
        /// Metoda koja se poziva pritiskom na gumb Dodaj te otvara
        /// formu za dodavanje/uređivanje tipa korisnika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            FrmUrediDodajTip forma = new FrmUrediDodajTip(null);
            forma.ShowDialog();
            OsvjeziTipove();
        }

        /// <summary>
        /// Metoda koja se poziva pritiskom na gumb Uredi te otvara
        /// formu za dodavanje/uređivanje tipa korisnika (sa popunjenim poljima)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUredi_Click(object sender, EventArgs e)
        {
            if (tipkorisnikaBindingSource.Current is tip_korisnika oznaceni)
            {
                FrmUrediDodajTip forma = new FrmUrediDodajTip(oznaceni);
                forma.ShowDialog();
                OsvjeziTipove();
            }
        }

        /// <summary>
        /// Metoda koja se poziva pritiskom na gumb Obriši te služi
        /// za brisanje pojedinog tipa korisnika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnObrisi_Click(object sender, EventArgs e)
        {           
            if (tipkorisnikaBindingSource.Current is tip_korisnika oznaceni)
            {
                if (MessageBox.Show("Are you sure you want to delete the selected user type? ", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (var db = new Entities())
                    {
                        db.tip_korisnika.Attach(oznaceni);
                        db.tip_korisnika.Remove(oznaceni);
                        db.SaveChanges();
                    }
                }
                OsvjeziTipove();
            }
        }
        #endregion
    }
}
