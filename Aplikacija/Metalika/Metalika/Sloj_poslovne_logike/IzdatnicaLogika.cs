using Metalika.Podatkovni_sloj;
using System.ComponentModel;
using System.Linq;

namespace Metalika
{
    class IzdatnicaLogika
    {
        public BindingList<izdatnica> PrikaziIzdatnice()
        {
            BindingList<izdatnica> listaIzdatnica = null;
            using (var db = new Entities(Konstante.GetConnectionString()))
            {
                listaIzdatnica = new BindingList<izdatnica>(db.izdatnica.ToList());
            }
            return listaIzdatnica;
        }

        public BindingList<stavke_izdatnice> PrikaziStavkeIzdatnice(izdatnica izdatnica)
        {
            BindingList<stavke_izdatnice> stavkeIzdatnice = null;
            using (var db = new Entities(Konstante.GetConnectionString()))
            {
                db.izdatnica.Attach(izdatnica);
                stavkeIzdatnice = new BindingList<stavke_izdatnice>(izdatnica.stavke_izdatnice.ToList());
            }
            return stavkeIzdatnice;
        }
    }
}
