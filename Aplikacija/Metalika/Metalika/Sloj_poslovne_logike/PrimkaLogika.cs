using Metalika.Podatkovni_sloj;
using System.ComponentModel;
using System.Linq;

namespace Metalika
{
    class PrimkaLogika
    {
        public BindingList<primka> PrikaziPrimke()
        {
            BindingList<primka> listaPrimki = null;
            using (var db = new Entities(Konstante.GetConnectionString()))
            {
                listaPrimki = new BindingList<primka>(db.primka.ToList());
            }
            return listaPrimki;
        }

        public BindingList<stavke_primke> PrikaziStavkePrimke(primka primka)
        {
            BindingList<stavke_primke> stavkePrimke = null;
            using (var db = new Entities(Konstante.GetConnectionString()))
            {
                db.primka.Attach(primka);
                stavkePrimke = new BindingList<stavke_primke>(primka.stavke_primke.ToList());
            }
            return stavkePrimke;
        }
    }
}
