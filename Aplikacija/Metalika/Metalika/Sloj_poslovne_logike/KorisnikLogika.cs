using Metalika.Podatkovni_sloj;
using System.ComponentModel;
using System.Linq;

namespace Metalika
{
    class KorisnikLogika
    {
        /// <summary>
        /// Metoda koja služi za dohvaćanje liste korisnika 
        /// iz baze podataka
        /// </summary>
        /// <returns>lista korisnika</returns>
        public BindingList<korisnik> DohvatiListuKorisnika()
        {
            BindingList<korisnik> listaKorisnika = null;
            using (var db = new Entities())
            {
                listaKorisnika = new BindingList<korisnik>(db.korisnik.ToList());
            }
            return listaKorisnika;
        }
    }
}
