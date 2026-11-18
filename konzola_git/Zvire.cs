using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konzola_git
{
    internal class Zvire
    {
        public int ID { get; set; }
        public string Jmeno { get; set; }
        public string Druh { get; set; }
        public int Vek { get; set; }
        public string Pohlavi { get; set; }
        public bool Adoptovano { get; set; }

        private static int nextID = 1;
        
        public Zvire (string jmeno, string druh, int vek, string pohlavi, bool adoptovano)
        {
            ID = (nextID++);
            Jmeno = jmeno;
            Druh = druh;
            Vek = vek;
            Pohlavi = pohlavi;
            Adoptovano = adoptovano;
        }
    }
}
