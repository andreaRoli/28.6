using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._6
{
    internal class Aula
    {
        public string Nome { get; set; }
        public int Capienza { get; set; }
        public List<string> Risorse { get; set; }

        public void AggRisorse(string risorse)
        {
            Risorse.Add(risorse);
        }
    }
}
