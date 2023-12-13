using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._6
{
    internal class Lezione
    {
        public string Descrizione { get; set; }
        public DateTime Data { get; set; }
        public DateTime OraInizio { get; set; }
        public TimeSpan Durata { get; set; }
        public Docente Docente { get; set; }
        public Aula Aula { get; set; }
        public List<Studente> Presenti { get; set; }

        public void Assente (Studente studente)
        {
            Presenti.Remove(studente);
        }
    }
}
