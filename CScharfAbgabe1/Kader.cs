using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CScharfAbgabe1
{   [Serializable()]
    [System.Xml.Serialization.XmlRoot("Kader")]
    public class Kader
    {
        [XmlArray("SpielerListe")]
        [XmlArrayItem("Spieler",typeof(Spieler))]
        public Spieler[] Spieler { get; set; }
        public List<Spieler> spielerListe;

        
    }
}
