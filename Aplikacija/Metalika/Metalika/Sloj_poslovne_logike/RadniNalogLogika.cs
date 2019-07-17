using Metalika.Podatkovni_sloj;
using System.ComponentModel;
using System.Linq;

namespace Metalika
{
    class RadniNalogLogika
    {
        public BindingList<radni_nalog> PrikaziNaloge()
        {
            BindingList<radni_nalog> listaNaloga = null;
            using (var db = new Entities(Konstante.GetConnectionString()))
            {
                listaNaloga = new BindingList<radni_nalog>(db.radni_nalog.ToList());
            }
            return listaNaloga;
        }

        public BindingList<stavke_naloga> PrikaziStavkeNaloga(radni_nalog nalog)
        {
            BindingList<stavke_naloga> stavkeNaloga = null;
            using (var db = new Entities(Konstante.GetConnectionString()))
            {
                db.radni_nalog.Attach(nalog);
                stavkeNaloga = new BindingList<stavke_naloga>(nalog.stavke_naloga.ToList());
            }
            return stavkeNaloga;
        }
    }
}
