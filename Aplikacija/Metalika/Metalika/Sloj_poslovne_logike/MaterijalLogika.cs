using Metalika.Podatkovni_sloj;
using System.ComponentModel;
using System.Linq;

namespace Metalika
{
    class MaterijalLogika
    {
        /// <summary>
        /// Metoda koja služi za dohvaćanje liste materijala
        /// iz baze podataka
        /// </summary>
        /// <returns>lista materijala</returns>
        public BindingList<materijal> DohvatiListuMaterijala()
        {
            BindingList<materijal> listaMaterijala = null;
            using (var db = new Entities(Konstante.GetConnectionString()))
            {
                listaMaterijala = new BindingList<materijal>(db.materijal.ToList());
            }
            return listaMaterijala;
        }
    }
}
