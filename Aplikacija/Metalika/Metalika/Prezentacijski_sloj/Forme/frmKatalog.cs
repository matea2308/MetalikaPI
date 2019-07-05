using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using Metalika.Podatkovni_sloj;
using System;

namespace Metalika
{
    public partial class FrmKatalog : Form
    {
        private ProizvodLogika proizvodLogika;

        #region Konstruktor i dohvaćanje podataka
        public FrmKatalog()
        {
            InitializeComponent();
            proizvodLogika = new ProizvodLogika();
        }

        /// <summary>
        /// Metoda koja se poziva pri učitavanju forme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmKatalog_Load(object sender, EventArgs e)
        {
            PopuniKatalog();
        }

        /// <summary>
        /// Metoda koja se poziva kada se učita forma, a služi za
        /// dohvaćanje proizvoda iz baze te raspoređivanje istih
        /// u dva stupca na formi
        /// </summary>
        private void PopuniKatalog()
        {
            //dohvati listu proizvoda i njihovih cijena
            BindingList<proizvod> proizvodi = proizvodLogika.PrikaziProizvode();

            /*
             * početne koordinate, veličina panela je 200x260, slika je 200x200
             * što znači da će se labele Naziv i Cijena morati nalaziti malo ispod
             * slike kako bi bile vidljive (na y = 220 odnosno y = 245)
            */

            int x = 0, y = 0, nazivX = 0, nazivY = 220, cijenaX = 0, cijenaY = 245;

            //koristi se kako bi osigurali da se nalaze 2 proizvoda po retku
            bool paran = false;

            /*
             * za svaki proizvod dohvaćen preko upita, kreiraj panel, te
             * picturebox (za sliku) i dvije labele koji će pripadati
             * tom panelu te napravi pomak u "stupac" ili u redak ispod
             */

            foreach(proizvod pr in proizvodi)
            {
                Panel proizvod = new Panel
                {
                    Height = 260,
                    Width = 200,
                    Location = new Point(x, y)
                };
                PictureBox pictureBox = new PictureBox
                {
                    ImageLocation = @"Prezentacijski_sloj\Slike\steel_icon.png",
                    Width = 200,
                    Height = 200
                };
                proizvod.Controls.Add(pictureBox);
                Label naziv = new Label
                {
                    Font = new Font("Calibri", 12.0f, FontStyle.Bold),
                    Text = pr.naziv_proizvoda,
                    Location = new Point(nazivX, nazivY),
                    AutoSize = true
                };
                proizvod.Controls.Add(naziv);
                Label cijena = new Label
                {
                    Font = new Font("Calibri", 12.0f, FontStyle.Bold),
                    Text = pr.cijena + " HRK",
                    Location = new Point(cijenaX, cijenaY)

                };
                proizvod.Controls.Add(cijena);

                pKatalog.Controls.Add(proizvod);

                /* 
                 * ako je zadnji element koji smo dodali bio "paran" (stavljen na drugo
                 * mjesto u retku) postavljamo X koordinatu na početak, a Y u drugi redak.
                 * Inače, postavljamo X koordinatu na drugo mjesto u retku
                 */

                if (paran)
                {
                    x = 0;
                    y += 270;
                    paran = false;
                }
                else
                {
                    x += 300;
                    paran = true;
                }
            }
        }
        #endregion
    }
}
