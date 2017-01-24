using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CScharfAbgabe1
{
    class Kader
    {
        private List<Spieler> spielerListe;
        public List<Spieler> Liste
        {
            get
            {
                return spielerListe;
            }
            set
            {
                spielerListe = value;
            }

        }
    }
}
