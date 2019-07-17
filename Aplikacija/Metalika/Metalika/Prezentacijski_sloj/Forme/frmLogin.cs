using EncryptString;
using Metalika.Podatkovni_sloj;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Metalika
{
    public partial class FrmLogin : Form
    {
        #region Konstruktor
        public FrmLogin()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// Metoda koja se poziva pri učitavanju forme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            lblUnesiKorIme.Visible = false;
            lblUnesiZaporku.Visible = false;
        }
        #endregion

        #region Eventi
        /// <summary>
        /// Metoda koja se poziva prilikom ulaska u textbox
        /// tbKorIme (uz pomoć tipke TAB)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbKorIme_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        /// <summary>
        /// Metoda koja se poziva prilikom ulaska u textbox
        /// tbZaporka (uz pomoć tipke TAB)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbZaporka_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        /// <summary>
        /// Metoda koja se poziva prilikom unosa u textbox
        /// tbKorIme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbKorIme_TextChanged(object sender, EventArgs e)
        {
            lblUnesiKorIme.Visible = false;
        }

        /// <summary>
        /// Metoda koja se poziva prilikom unosa u textbox
        /// tbZaporka
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbZaporka_TextChanged(object sender, EventArgs e)
        {
            lblUnesiZaporku.Visible = false;
        }

        /// <summary>
        /// Metoda koja se poziva prilikom klika na label
        /// "Registriraj se!"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LblRegistracija_Click(object sender, EventArgs e)
        {
            FrmRegistracija forma = new FrmRegistracija(null);
            forma.ShowDialog();
        }

        /// <summary>
        /// Metoda koja se poziva prilikom klika na gumb "Ulogiraj se". Izvode
        /// se provjere korisničkog imena i zaporke te se pokreće glavna forma
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUlogirajSe_Click(object sender, EventArgs e)
        {
            // u slučaju da nije uneseno korisničko ime ili zaporka, 
            // pojavljuje se label koji sugerira da su ta polja obavezna

            if (string.IsNullOrWhiteSpace(tbKorIme.Text)) lblUnesiKorIme.Visible = true;
            if (string.IsNullOrWhiteSpace(tbZaporka.Text)) lblUnesiZaporku.Visible = true;

            if(!string.IsNullOrWhiteSpace(tbKorIme.Text) && !string.IsNullOrWhiteSpace(tbZaporka.Text))
            {
                bool uspjesanLogin = false;
                using (var db = new Entities(Konstante.GetConnectionString()))
                {
                    bool korisnik = db.korisnik.Where(x => x.korisnicko_ime.Equals(tbKorIme.Text)).Any();

                    if (!korisnik) MessageBox.Show("Invalid user name/password!", "Remark", MessageBoxButtons.OK);
                    else
                    {
                        // dohvaćamo lozinku iz baze za korisničko ime koje smo proslijedili te ako je lozinka "blank"
                        // pokrećemo formu za postavljanje lozinke. Inače, provjeravamo da li je unos lozinke dobar i pokrećemo glavnu formu

                        var lozinka = db.korisnik.Where(x => x.korisnicko_ime.Equals(tbKorIme.Text)).Select(x => x.zaporka).FirstOrDefault();
                        var omogucen = db.korisnik.Where(x => x.korisnicko_ime.Equals(tbKorIme.Text)).Select(x => x.omogucen).FirstOrDefault();
                        if (omogucen.Equals("N"))
                        {
                            MessageBox.Show("The user you are trying to log in with is currently disabled. Please contact your administrator", "Warning");
                        }
                        else if (string.IsNullOrWhiteSpace(lozinka))
                        {
                            if (MessageBox.Show("The password of the current user has expired and needs to be changed!", "Remark", MessageBoxButtons.OKCancel) == DialogResult.OK)
                            {
                                FrmPromjenaZaporke forma = new FrmPromjenaZaporke(tbKorIme.Text);
                                forma.ShowDialog();
                            }
                            else return;
                        }
                        else
                        {
                            string enkriptiranaLozinka = Enkripcija.Enkriptiranje(tbZaporka.Text, Konstante.EnkripcijskiKljuc);
                            uspjesanLogin = db.korisnik.Where(x => x.korisnicko_ime.Equals(tbKorIme.Text) && x.zaporka.Equals(enkriptiranaLozinka)).Any();
                            if (!uspjesanLogin) MessageBox.Show("Invalid user name/password!", "Remark", MessageBoxButtons.OK);
                            else
                            {
                                FrmMain glavnaForma = new FrmMain(this, tbKorIme.Text);
                                glavnaForma.Show();
                                Hide();
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Metoda koja se poziva prilikom klika na gumb "Odustani"
        /// (aplikacija prestaje s radom)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOdustani_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
