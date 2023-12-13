using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._6
{
    internal class ElencoCorsi
    {
        public List<Corso> Corsi{ get; set; }

        public void AggCorso(Corso corso)
        {
            Corsi.Add(corso);
        }
    }
}
