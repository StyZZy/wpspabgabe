using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CScharfAbgabe1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Kader spielerListe = null;
            string path = "SpielerData.xml";

            XmlSerializer serializer = new XmlSerializer(typeof(Kader));

            StreamReader reader = new StreamReader(path);
            spielerListe = (Kader)serializer.Deserialize(reader);
            reader.Close();
            foreach (Spieler spieler in spielerListe.Spieler)
            {
                playerNameCB.Items.Add(spieler.name + " " + spieler.vorname);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
