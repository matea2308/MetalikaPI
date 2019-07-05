

using Metalika.Podatkovni_sloj;
using System.ComponentModel;
using System.Linq;

namespace Metalika
{
    class TipKorisnikaLogika
    {
        /// <summary>
        /// Metoda koja služi za dohvaćanje liste tipova 
        /// korisnika iz baze podataka
        /// </summary>
        /// <returns>lista tipova korisnika</returns>
        public BindingList<tip_korisnika> DohvatiListuTipovaKorisnika()
        {
            BindingList<tip_korisnika> listaTipova = null;
            using (var db = new Entities())
            {
                listaTipova = new BindingList<tip_korisnika>(db.tip_korisnika.ToList());
            }
            return listaTipova;
        }
    }
}
