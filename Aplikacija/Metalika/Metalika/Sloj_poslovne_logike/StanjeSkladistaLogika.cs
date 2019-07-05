using Metalika.Podatkovni_sloj;
using System.ComponentModel;
using System.Linq;

namespace Metalika
{
    class StanjeSkladistaLogika
    {
        public BindingList<stanje_skladista_pogled> PrikaziStanje()
        {
            BindingList<stanje_skladista_pogled> listaMaterijala = null;
            using (var db = new Entities())
            {
                listaMaterijala = new BindingList<stanje_skladista_pogled>(db.stanje_skladista_pogled.ToList());
            }
            return listaMaterijala;
        }
    }
}
