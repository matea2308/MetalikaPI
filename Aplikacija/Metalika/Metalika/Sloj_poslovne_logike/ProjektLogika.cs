using Metalika.Podatkovni_sloj;
using System.ComponentModel;
using System.Linq;

namespace Metalika
{
    class ProjektLogika
    {
        /// <summary>
        /// Metoda koja služi za dohvaćanje liste projekata
        /// iz baze podataka
        /// </summary>
        /// <returns>lista projekata</returns>
        public BindingList<projekt> DohvatiListuProjekata()
        {
            BindingList<projekt> listaProjekata = null;
            using (var db = new Entities(Konstante.GetConnectionString()))
            {
                listaProjekata = new BindingList<projekt>(db.projekt.ToList());
            }
            return listaProjekata;
        }
    }
}
