using System;
using System.Windows.Forms;
using Metalika.Podatkovni_sloj;

namespace Metalika
{
    public partial class FrmRadniNalog : Form
    {
        private korisnik korisnik;
        private RadniNalogLogika radniNalogLogika;

        #region Konstruktor klase i osvježavanje podataka
        public FrmRadniNalog(object _korisnik)
        {
            InitializeComponent();
            korisnik = (korisnik) _korisnik;
            radniNalogLogika = new RadniNalogLogika();
        }

        /// <summary>
        /// Metoda koja se poziva prilikom učitavanja forme.
        /// Učitava retke u tablice (datagridview-ove)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmRadniNalog_Load(object sender, EventArgs e)
        {
            OsvjeziNaloge();
            OsvjeziStavke();
        }

        /// <summary>
        /// Metoda koja služi za dohvaćanje radnih naloga iz baze
        /// </summary>
        private void OsvjeziNaloge()
        {
            try
            {
                radninalogBindingSource.DataSource = radniNalogLogika.PrikaziNaloge();
            }
            catch (Exception)
            {
                return;
            }
            
        }

        /// <summary>
        /// Metoda koja služi za dohvaćanje stavki naloga
        /// iz baze za selektirani radni nalog
        /// </summary>
        private void OsvjeziStavke()
        {
            try
            {
                if (radninalogBindingSource.Current is radni_nalog oznaceni)
                {
                    stavkenalogaBindingSource.DataSource = radniNalogLogika.PrikaziStavkeNaloga(oznaceni);
                }
            }
            catch (Exception)
            {
                return;
            }      
        }
        #endregion

        #region Eventi
        /// <summary>
        /// Metoda koja se poziva pri promjeni selektiranog radnog naloga
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvRadniNalozi_SelectionChanged(object sender, EventArgs e)
        {
            OsvjeziStavke();
        }

        /// <summary>
        /// Metoda koja se poziva prilikom klika na gumb Dodaj (ispod tablica sa radnim nalozima).
        /// Otvara formu za dodavanje/uređivanje naloga
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDodajNalog_Click(object sender, EventArgs e)
        {
            FrmUrediDodajRadniNalog forma = new FrmUrediDodajRadniNalog(null, korisnik.ID_korisnik);
            forma.ShowDialog();
            OsvjeziNaloge();
            OsvjeziStavke();
        }

        /// <summary>
        /// Metoda koja se poziva prilikom klika na gumb Uredi (ispod tablice sa radnim nalozima).
        /// Otvara formu za dodavanje/uređivanje naloga (sa popunjenim poljima)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUrediNalog_Click(object sender, EventArgs e)
        {
            if (radninalogBindingSource.Current is radni_nalog oznaceni)
            {
                FrmUrediDodajRadniNalog forma = new FrmUrediDodajRadniNalog(oznaceni, korisnik.ID_korisnik);
                forma.ShowDialog();
                OsvjeziNaloge();
                OsvjeziStavke();
            }
        }

        /// <summary>
        /// Metoda koja se poziva prilikom klika na gumb Obriši (ispod tablice sa nalozima).
        /// Briše selektirani radni nalog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnObrisiNalog_Click(object sender, EventArgs e)
        {
            string poruka = "";
            try
            {
                if (radninalogBindingSource.Current is radni_nalog oznaceni)
                {
                    if (MessageBox.Show("Are you sure you want to delete the selected work order? ", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        using (var db = new Entities())
                        {
                            db.radni_nalog.Attach(oznaceni);
                            db.radni_nalog.Remove(oznaceni);
                            db.SaveChanges();
                        }
                    }
                    OsvjeziNaloge();
                    OsvjeziStavke();
                }
            }

            catch (Exception ex)
            {
                if (ex.InnerException == null) poruka = "Deletion of work order was not successful! Please check if all work order lines are deleted";
                else poruka = "Deleting work order failed! Make sure the work order is already used to create the issue note";
            }

            finally
            {
                if (!string.IsNullOrWhiteSpace(poruka)) MessageBox.Show(poruka);
            }
        }

        /// <summary>
        /// Metoda koja se poziva prilikom klika na gumb Dodaj (ispod tablice sa stavkama).
        /// Otvara formu za dodavanje/uređivanje stavke naloga
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDodajStavku_Click(object sender, EventArgs e)
        {
            if (radninalogBindingSource.Current is radni_nalog selektiraniNalog)
            {
                FrmUrediDodajStavkuNaloga forma = new FrmUrediDodajStavkuNaloga(null, selektiraniNalog.ID_nalog);
                forma.ShowDialog();
                OsvjeziNaloge();
                OsvjeziStavke();
            }
        }

        /// <summary>
        /// Metoda koja se poziva prilikom klika na gumb Uredi (ispod tablice sa stavkama).
        /// Otvara formu za dodavanje/uređivanje stavke naloga (sa popunjenim poljima)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUrediStavku_Click(object sender, EventArgs e)
        {
            if (stavkenalogaBindingSource.Current is stavke_naloga selektiranaStavka)
            {
                FrmUrediDodajStavkuNaloga forma = new FrmUrediDodajStavkuNaloga(selektiranaStavka, -1);
                forma.ShowDialog();
                OsvjeziNaloge();
                OsvjeziStavke();
            }
        }

        /// <summary>
        /// Metoda koja se poziva prilikom klika na gumb Obriši (ispod tablice sa stavkama).
        /// Briše selektiranu stavku naloga
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnObrišiStavku_Click(object sender, EventArgs e)
        {
            radni_nalog selektiraniNalog = radninalogBindingSource.Current as radni_nalog;
            if (stavkenalogaBindingSource.Current is stavke_naloga selektiranaStavka)
            {
                if (MessageBox.Show("Are you sure you want to delete selected work order line ?", "Warning!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new Entities())
                    {
                        db.stavke_naloga.Attach(selektiranaStavka);
                        db.stavke_naloga.Remove(selektiranaStavka);
                        db.SaveChanges();
                    }
                }
                OsvjeziNaloge();
                OsvjeziStavke();
            }
        }

        #endregion
    }
}
