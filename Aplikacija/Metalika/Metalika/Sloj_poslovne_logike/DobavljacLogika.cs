using Metalika.Podatkovni_sloj;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metalika
{
    class DobavljacLogika
    {
        public BindingList<poslovni_partner> PrikaziDobavljace()
        {
            BindingList<poslovni_partner> listaDobavljaca = null;
            using (var db = new Entities())
            {
                listaDobavljaca = new BindingList<poslovni_partner>(db.poslovni_partner.ToList());
            }
            return listaDobavljaca;
        }
    }
}
