using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CScharfAbgabe1
{   [Serializable()]
    public class Spieler
    {   [System.Xml.Serialization.XmlElement("Name")]
        public String name { get; set; }
        [System.Xml.Serialization.XmlElement("Vorname")]
        public String vorname { get; set;}
        [System.Xml.Serialization.XmlElement("Position")]
        public String position { get; set;}
        [System.Xml.Serialization.XmlElement("Rueckennummer")]
        public int nummer { get; set;}
        [System.Xml.Serialization.XmlElement("Seit")]
        public int seit { get; set; }
        [System.Xml.Serialization.XmlElement("GeburtsDatum")]
        public String bDay { get; set; }
        [System.Xml.Serialization.XmlElement("GroesseInCm")]
        public int height { get; set; }
        [System.Xml.Serialization.XmlElement("GewichtInKg")]
        public int weight { get; set; }
        [System.Xml.Serialization.XmlElement("SpieleInBundesliga")]
        public int gamesPlayed { get; set; }
        [System.Xml.Serialization.XmlElement("ToreInBundesliga")]
        public int goalsShot { get; set; }
        [System.Xml.Serialization.XmlElement("Nation")]
        public String nation { get; set; }
        [System.Xml.Serialization.XmlElement("Laenderspiele")]
        public int landGames { get; set; }
    }
}
