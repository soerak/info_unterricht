using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace asdfghjklöä
{
    public partial class Form1 : Form
    {

        Random rng = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadDummyXMLFile();
        }

        private void loadDummyXMLFile()
        {
            // DUMMY FILE LOAD

            textBox2.Text = "";

            XmlDocument Personenverwaltung = new XmlDocument();

            Personenverwaltung.Load("personenverwaltung.xml");
            XmlNodeList nodelist = Personenverwaltung.GetElementsByTagName("user");
            foreach (XmlNode node in nodelist)
            {
                textBox2.Text += "ID:\t\t\t" + node["id"].InnerText + "\r\n";
                textBox2.Text += "NAME:\t\t\t" + node["name"].InnerText + "\r\n";
                textBox2.Text += "OCCUPATION:\t\t" + node["occupation"].InnerText + "\r\n\r\n";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // DANK MODE

            if (checkBox1.Checked)
            {
                int a = rng.Next(-10, 10);
                int b = rng.Next(-10, 10);
                this.Location = new Point(this.Location.X + a, this.Location.Y + b);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // LOAD FROM FILE

            textBox2.Text = "";

            string tb3 = textBox3.Text;
            string[] tagArray = tb3.Split('\u002C');
            int tagArrayLen = tagArray.Length;

            string filePath = null;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog1.FileName;
            }


            XmlDocument Personenverwaltung = new XmlDocument();

            Personenverwaltung.Load(filePath);
            XmlNodeList nodelist = Personenverwaltung.GetElementsByTagName(tagArray[0]);
            
            foreach (XmlNode node in nodelist)
            {
                
                for (int i = 1; i < tagArrayLen; i++)
                {
                    textBox2.Text += tagArray[i] + ":\t" + node[tagArray[i]].InnerText + "\r\n";
                    
                }
                textBox2.Text += "\r\n\r\n";
            }

            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string url = textBox1.Text;

            string[] tagArray = url.Split('<CHAR_LIT>');

        }
    }
}
