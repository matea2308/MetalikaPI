using Metalika.Podatkovni_sloj;
using System;
using System.Windows.Forms;

namespace Metalika
{
    public partial class FrmJedMjere : Form
    {
        private JedinicaMjereLogika jedinicaMjereLogika;

        #region Konstruktor klase i osvježavanje podataka
        public FrmJedMjere()
        {
            InitializeComponent();
            jedinicaMjereLogika = new JedinicaMjereLogika();
        }

        /// <summary>
        /// Metoda koja se poziva pri učitavanju forme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmJedMjere_Load(object sender, EventArgs e)
        {
            OsvjeziJedMjere();
        }

        /// <summary>
        /// Metoda koja postavlja listu jedinica mjere 
        /// (koja se dohvaća preko metode klase JedinicaMjeraLogika)
        /// za izvor podataka datagridview-a forme
        /// </summary>
        private void OsvjeziJedMjere()
        {
            try
            {
                jedinicamjereBindingSource.DataSource = jedinicaMjereLogika.PrikaziJediniceMjere();
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
        /// formu za dodavanje/uređivanje jedinice mjere
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            FrmUrediDodajJedinicu forma = new FrmUrediDodajJedinicu(null);
            forma.ShowDialog();
            OsvjeziJedMjere();
        }

        /// <summary>
        /// Metoda koja se poziva pritiskom na gumb Uredi te otvara
        /// formu za dodavanje/uređivanje jedinice mjere (sa popunjenim poljima)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUredi_Click(object sender, EventArgs e)
        {
            if (jedinicamjereBindingSource.Current is jedinica_mjere oznaceni)
            {
                FrmUrediDodajJedinicu forma = new FrmUrediDodajJedinicu(oznaceni);
                forma.ShowDialog();
                OsvjeziJedMjere();
            }
        }

        /// <summary>
        /// Metoda koja se poziva pritiskom na gumb Obriši te služi
        /// za brisanje pojedine jedinice mjere
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnObrisi_Click(object sender, EventArgs e)
        {
            if (jedinicamjereBindingSource.Current is jedinica_mjere oznaceni)
            {
                if (MessageBox.Show("Are you sure you want to delete the selected unit of measure? ", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (var db = new Entities(Konstante.GetConnectionString()))
                    {
                        db.jedinica_mjere.Attach(oznaceni);
                        db.jedinica_mjere.Remove(oznaceni);
                        db.SaveChanges();
                    }
                }
                OsvjeziJedMjere();
            }
        }
        #endregion

    }
}
