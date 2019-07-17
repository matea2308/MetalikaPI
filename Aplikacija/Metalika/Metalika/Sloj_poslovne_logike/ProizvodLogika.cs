using Metalika.Podatkovni_sloj;
using System.ComponentModel;
using System.Linq;

namespace Metalika
{
    class ProizvodLogika
    {
        /// <summary>
        /// Metoda koja služi za dohvaćanje liste proizvoda
        /// iz baze podataka
        /// </summary>
        /// <returns>lista proizvoda</returns>
        public BindingList<proizvod> PrikaziProizvode()
        {
            BindingList<proizvod> listaProizvoda = null;
            using (var db = new Entities(Konstante.GetConnectionString()))
            {
                listaProizvoda = new BindingList<proizvod>(db.proizvod.ToList());
            }
            return listaProizvoda;
        }
    }
}
