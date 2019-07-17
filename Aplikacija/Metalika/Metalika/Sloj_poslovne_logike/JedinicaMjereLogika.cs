using Metalika.Podatkovni_sloj;
using System.ComponentModel;
using System.Linq;

namespace Metalika
{
    class JedinicaMjereLogika
    {
        /// <summary>
        /// Metoda koja služi za dohvaćanje liste jedinica mjere
        /// iz baze podataka
        /// </summary>
        /// <returns>lista jedinica mjere</returns>
        public BindingList<jedinica_mjere> PrikaziJediniceMjere()
        {
            BindingList<jedinica_mjere> listaNaloga = null;
            using (var db = new Entities(Konstante.GetConnectionString()))
            {
                listaNaloga = new BindingList<jedinica_mjere>(db.jedinica_mjere.ToList());
            }
            return listaNaloga;
        }
    }
}
