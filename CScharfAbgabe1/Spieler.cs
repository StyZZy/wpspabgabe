using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CScharfAbgabe1
{   [Serializable()]
    public class Spieler
    {   [System.Xml.Serialization.XmlElement("Name")]
        public string name { get; set; }
        [System.Xml.Serialization.XmlElement("Vorname")]
        public string vorname { get; set;}
        [System.Xml.Serialization.XmlElement("Position")]
        public string position { get; set;}
        [System.Xml.Serialization.XmlElement("Rueckennummer")]
        public string nummer { get; set;}
        [System.Xml.Serialization.XmlElement("Seit")]
        public string seit { get; set; }
        [System.Xml.Serialization.XmlElement("GeburtsDatum")]
        public string bDay { get; set; }
        [System.Xml.Serialization.XmlElement("GroesseInCm")]
        public string height { get; set; }
        [System.Xml.Serialization.XmlElement("GewichtInKg")]
        public string weight { get; set; }
        [System.Xml.Serialization.XmlElement("SpieleInBundesliga")]
        public string gamesPlayed { get; set; }
        [System.Xml.Serialization.XmlElement("ToreInBundesliga")]
        public string goalsShot { get; set; }
        [System.Xml.Serialization.XmlElement("Nation")]
        public string nation { get; set; }
        [System.Xml.Serialization.XmlElement("Laenderspiele")]
        public string landGames { get; set; }
    }
}
