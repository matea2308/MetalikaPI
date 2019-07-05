using System;
using System.Windows.Forms;

namespace Metalika
{
    public partial class FrmStanjeSkladista : Form
    {
        private StanjeSkladistaLogika stanjeSkladistaLogika;

        #region Konstruktor klase i osvježavanje podataka
        public FrmStanjeSkladista()
        {
            InitializeComponent();
            stanjeSkladistaLogika = new StanjeSkladistaLogika();
        }

        /// <summary>
        /// Metoda koja se poziva prilikom učitavanja forme.
        /// Učitava retke u tablice (datagridview-ove)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmStanjeSkladista_Load(object sender, EventArgs e)
        {
            OsvjeziStanje();
        }

        /// <summary>
        /// Metoda koja služi za dohvaćanje stanja skladišta iz baze
        /// </summary>
        private void OsvjeziStanje()
        {
            stanjeskladistapogledBindingSource.DataSource = stanjeSkladistaLogika.PrikaziStanje();
            lOsvjezeno.Text = DateTime.Now.ToString();
        }
        #endregion

        #region Eventi
        /// <summary>
        /// Metoda koja se poziva prilikom klika na gumb "Osvježi"
        /// (osvježava prikaz u tablici)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOsvjezi_Click(object sender, EventArgs e)
        {
            OsvjeziStanje();
        }
        #endregion
    }
}