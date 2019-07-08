using System;
using System.Windows.Forms;
using Metalika.Podatkovni_sloj;

namespace Metalika
{
    public partial class FrmMaterijal : Form
    {
        private MaterijalLogika materijalLogika;

        #region Konstruktor klase i osvježavanje podataka
        public FrmMaterijal()
        {
            InitializeComponent();
            materijalLogika = new MaterijalLogika();
        }

        /// <summary>
        /// Metoda koja se poziva pri učitavanju forme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMaterijal_Load(object sender, EventArgs e)
        {
            OsvjeziMaterijale();
        }

        /// <summary>
        /// Metoda koja postavlja listu materijala 
        /// (koja se dohvaća preko metode klase MaterijalLogika)
        /// za izvor podataka datagridview-a forme
        /// </summary>
        private void OsvjeziMaterijale()
        {
            try
            {
                materijalBindingSource.DataSource = materijalLogika.DohvatiListuMaterijala();
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
        /// formu za dodavanje/uređivanje materijala
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            FrmUrediDodajMaterijal forma = new FrmUrediDodajMaterijal(null);
            forma.ShowDialog();
            OsvjeziMaterijale();
        }

        /// <summary>
        /// Metoda koja se poziva pritiskom na gumb Uredi te otvara
        /// formu za dodavanje/uređivanje materijala (sa popunjenim poljima)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUredi_Click(object sender, EventArgs e)
        {
            if (materijalBindingSource.Current is materijal oznaceni)
            {
                FrmUrediDodajMaterijal forma = new FrmUrediDodajMaterijal(oznaceni);
                forma.ShowDialog();
                OsvjeziMaterijale();
            }
        }

        /// <summary>
        /// Metoda koja se poziva pritiskom na gumb Obriši te služi
        /// za brisanje pojedinog materijala
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnObrisi_Click(object sender, EventArgs e)
        {
            if (materijalBindingSource.Current is materijal oznaceni)
            {
                if (MessageBox.Show("Are you sure you want to delete the selected material? ", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (var db = new Entities())
                    {
                        db.materijal.Attach(oznaceni);
                        db.materijal.Remove(oznaceni);
                        db.SaveChanges();
                    }
                }
                OsvjeziMaterijale();
            }
        }
        #endregion
    }
}
