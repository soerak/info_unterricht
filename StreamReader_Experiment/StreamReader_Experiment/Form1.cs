using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StreamReader_Experiment
{
    public partial class Form1 : Form
    {
        // SR

        //StreamReader sr = new StreamReader("I:/data.csv");

        // SR
        // VARS

        string publicFileDir = string.Empty;

        // VARS


        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if (publicFileDir != string.Empty)
            {
                StreamReader getLastSaveDir = new StreamReader("I:/lastsavedir.txt");
                string tempDir = getLastSaveDir.ReadToEnd();
                getLastSaveDir.Close();

                StreamWriter saveFileSW = new StreamWriter(publicFileDir);
                saveFileSW.Write(richTextBox1.Text);

                saveFileSW.Close();
            }
            else { richTextBox1.Text = "Save Direcory Empty!"; }
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            /*
            string openFileDir = richTextBox1.Text;
            publicFileDir = openFileDir;

            StreamWriter saveLastDir = new StreamWriter("I:/lastsavedir.txt");
            saveLastDir.Write(publicFileDir);
            saveLastDir.Close();

            StreamReader openFileSR = new StreamReader(openFileDir);
            richTextBox1.Text = openFileSR.ReadToEnd();

            openFileSR.Close();
            */

            openFileDialog1.ShowDialog();
            string openFileDir = openFileDialog1.FileName;
            publicFileDir = openFileDir;

            StreamWriter saveLastDir = new StreamWriter("I:/lastsavedir.txt");
            saveLastDir.Write(publicFileDir);
            saveLastDir.Close();

            StreamReader openFileSR = new StreamReader(openFileDir);
            richTextBox1.Text = openFileSR.ReadToEnd();

            //StreamReader loadFont = new StreamReader("I:/lastFont");
            //richTextBox1.Font = loadFont.ReadToEnd();

            openFileSR.Close();



        }

        private void Button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.Font = fontDialog1.Font;

            string saveFontDir = "I:/lastFont.txt";
            StreamWriter saveFont = new StreamWriter(saveFontDir);
            saveFont.Write(fontDialog1.Font);
            saveFont.Close();

        }





        /*
        private int linesInFile(StreamReader sr)
        {
            int j = 0;
            while (sr.ReadLine() != null) { j++; }
            return j;
        }
        */


    }
}
