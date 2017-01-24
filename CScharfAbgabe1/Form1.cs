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
        public Kader spielerListe = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            string path = "SpielerData.xml";

            XmlSerializer serializer = new XmlSerializer(typeof(Kader));

            StreamReader reader = new StreamReader(path);
            spielerListe = (Kader)serializer.Deserialize(reader);
            reader.Close();

            foreach (Spieler spieler in spielerListe.Spieler)
            {
                playerNameCB.Items.Add(spieler.vorname + " " + spieler.name);
            }
            playerNameCB.SelectedIndex = 0;

        }

        private void prevCLCK(object sender, EventArgs e)
        {   if(playerNameCB.SelectedIndex>0)playerNameCB.SelectedIndex -= 1;
            
        }

        private void firstCLCK(object sender, EventArgs e)
        {
            playerNameCB.SelectedIndex = 0;
        }

        private void nextCLCK(object sender, EventArgs e)
        {
            if(playerNameCB.SelectedIndex< playerNameCB.Items.Count-1) playerNameCB.SelectedIndex += 1;
           
        }

        private void lastCLCK(object sender, EventArgs e)
        {
            playerNameCB.SelectedIndex = playerNameCB.Items.Count - 1;
        }

        private void playerNameCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combobox = (ComboBox)sender;


            Spieler spieler = spielerListe.Spieler[combobox.SelectedIndex];

            string path = spieler.name +" "+spieler.vorname +".jpg";

            playerPicPB.ImageLocation = path;

            nameTB.Text = spieler.name;
            surNameTB.Text = spieler.vorname;
            posTB.Text = spieler.position;
            numbTB.Text = spieler.nummer;
            sinceTB.Text = spieler.seit;
            bDayTB.Text = spieler.bDay;
            heightTB.Text = spieler.height;
            weightTB.Text = spieler.weight;
            ggTB.Text = spieler.gamesPlayed + "/" + spieler.goalsShot;
            nationTB.Text = spieler.nation;
            landGTB.Text = spieler.landGames;

        }
    }
}
