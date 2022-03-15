using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEK_OOP_OOM_BENJAMIN_HENICH_TEST_UEBUNG
{
    public partial class Form1 : Form
    {

        List<SuS> susListB = new List<SuS>();
        List<SuS> susListE = new List<SuS>();
        List<Raum> raumList = new List<Raum>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // CREATE ROOMS
            raumList.Add(new Raum("01a", 30, 15, "Biologie"));
            raumList.Add(new Raum("01e", 21, 50, "English"));

            //CREATE BIO STUDENTS
            susListB.Add(new SuS("Susi Sauer", "123456", "1.0"));
            susListB.Add(new SuS("Kevin Schmidt", "geheim", "4.6"));
            susListB.Add(new SuS("Chantal Müller", "chantal", "2.0"));

            //CREATE ENG STUDENTS
            susListE.Add(new SuS("Jeremy Vogel", "passwort", "4.0"));
            susListE.Add(new SuS("Jennifer Schmidt", "geheim", "3.3"));
            susListE.Add(new SuS("Justin Müller", "justin", "1.0"));

            // APPEND SUS TO ROOMS
            foreach (var sus in susListB) { raumList[0].addSus(sus); }
            foreach (var sus in susListE) { raumList[1].addSus(sus); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // PRINT ALL USERDATA
            textBox1.Text = "";

            foreach (SuS sus in susListB)
            {
                textBox1.Text +=
                    "USRNAME: " +
                    sus.getVar(0) +
                    "\r\nGRADE: " +
                    sus.getVar(2) +
                    "\r\n\r\n";
            }
            foreach (SuS sus in susListE)
            {
                textBox1.Text +=
                    "USRNAME: " +
                    sus.getVar(0) +
                    "\r\nGRADE: " +
                    sus.getVar(2) +
                    "\r\n\r\n";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            // PRINT ALL ROOMDATA
            foreach (var room in raumList)
            {
                room.outputRaumData(textBox1);
                textBox1.Text += "\r\n\r\n";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

            raumList[0].outputRaumData(textBox1);
            textBox1.Text += "AVERAGE GRADE:\t\t" + Convert.ToString(raumList[0].ReturnAverageGrade()) + "\r\n";
            textBox1.Text += "SCHÜLER IN BIO-RAUM:\r\n";
            foreach (var sus in susListB)
            {
                textBox1.Text +=
                    "\tName:\t" + sus.getVar(0) + "\r\n" +
                    "\tPWD:\t" + sus.getVar(1) + "\r\n" +
                    "\tNote:\t" + sus.getVar(2) + "\r\n\r\n";
            }
            

            textBox1.Text += "\r\n\r\n";

            raumList[0].outputRaumData(textBox1);
            textBox1.Text += "AVERAGE GRADE:\t\t" + Convert.ToString(raumList[1].ReturnAverageGrade()) + "\r\n";
            textBox1.Text += "SCHÜLER IN ENG-RAUM:\r\n";
            foreach (var sus in susListB)
            {
                textBox1.Text +=
                    "\tName:\t" + sus.getVar(0) + "\r\n" +
                    "\tPWD:\t" + sus.getVar(1) + "\r\n" +
                    "\tNote:\t" + sus.getVar(2) + "\r\n\r\n";
            }
        }
    }
}
