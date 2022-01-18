using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // VARS
        Random random = new Random();
        BOI[] User = new BOI[1];
        string[] listOfNames = new string[] { "Jeremy", "Oleksandr", "Jacob", "Barak", "Lisa", "Marcel" };
        string[] listOfLastNames = new string[] { "Roth", "Seeliger", "Lamar", "Benrivh", "Kostyliev", "Karlsruhe" };



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*   GENERATE VALUES   */
            string a = listOfNames[random.Next(0, 5)];
            string b = listOfLastNames[random.Next(0, 5)];
            int randKN = random.Next(11111111, 99999999);
            int randPin = random.Next(1111, 9999);
            float randGH = random.Next(-1000, 10000);
            int randSteal = random.Next(0, 2);
            Console.WriteLine(randSteal);
            bool stealed = false;
            if (randSteal == 0) { stealed = true; } else if (randSteal == 1) { stealed = false; }
            
            /*   GENERATE USER USING VALUES   */
            User[0] = new BOI(a + " " + b, randKN, randPin, randGH, stealed);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User[0].printUser(textBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // einzahlen

            float templast = User[0].Guthaben;
            float tmpbetrag = float.Parse(textBox2.Text);
            User[0].Guthaben = User[0].Guthaben + tmpbetrag;
            textBox1.Text +=
                "\r\n" + "------- KONTOÄNDERUNG --------" + "\r\n";
            User[0].printUser(textBox1);

            // logs
            textBox3.Text +=
                /* GUTHABEN */ 
                "GUTHABEN:  \r\n"       + 
                "    "                  + 
                templast                + 
                " --> "                 + 
                User[0].Guthaben        + 
                "\r\n \r\n"             ;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // auszahlen
            float templast = User[0].Guthaben;
            float tmpbetrag = float.Parse(textBox2.Text);
            User[0].Guthaben = User[0].Guthaben - tmpbetrag;
            textBox1.Text +=
                "\r\n" + "------- KONTOÄNDERUNG --------" + "\r\n";
            User[0].printUser(textBox1);

            // logs
            textBox3.Text +=
                /* GUTHABEN */
                "GUTHABEN:  \r\n" +
                "    " +
                templast +
                " --> " +
                User[0].Guthaben +
                "\r\n \r\n";
        }
    }

    public class BOI
    {

        public string Kunde;
        public int Kundennummer;
        public int Kundenpin;
        public float Guthaben;
        public bool KarteGeklaut;

        public BOI(string kunde, int kundennummer, int kundenpin, float guthaben, bool kartegeklaut)
        {

            Kunde = kunde;
            Kundennummer = kundennummer;
            Kundenpin = kundenpin;
            Guthaben = guthaben;
            KarteGeklaut = kartegeklaut;

        }

        public void einzahlen(float betrag)
        {
            this.Guthaben += betrag;
        }
        public void auszahlen(float betrag)
        {
            this.Guthaben -= betrag;
        }

        public void printUser(TextBox txt)
        {
            txt.Text =
                //"\r\n" + "\r\n" +
                "Name >> " + this.Kunde + 
                "\r\n" + 
                "KundenNr >> " + this.Kundennummer.ToString() +
                "\r\n" + 
                "PIN >> " + this.Kundenpin.ToString() +
                "\r\n" + 
                "Guthaben >> " + this.Guthaben.ToString() +
                "\r\n" +
                "Karte Geklaut? >> " + this.KarteGeklaut.ToString();
        }

    }


}
