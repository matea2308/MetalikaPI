using Metalika.Podatkovni_sloj;
using System;
using System.Windows.Forms;

namespace Metalika
{
    public partial class FrmPocetna : Form
    {
        private korisnik korisnik;
        #region Konstruktor klase
        public FrmPocetna(object _korisnik)
        {
            InitializeComponent();
            korisnik = (korisnik)_korisnik;
        }

        /// <summary>
        /// Metoda koja se poziva pri učitavanju forme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPocetna_Load(object sender, EventArgs e)
        {
            lPrezimeIme.Text = korisnik.ime + " " + korisnik.prezime;
        }
        #endregion
    }
}
