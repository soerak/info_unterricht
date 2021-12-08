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
using System.Threading;
using System.Diagnostics;
using System.Reflection;

namespace ClickOfDuty
{
    public partial class Form1 : Form
    {

        int gameovertime = 0;
        int points = 0;
        Random randomPosX = new Random();
        Random randomPosY = new Random();
        public bool submitUsername = false;
        string lastLBCache;
        int miss = 0;
        string rank = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader loadLB = new StreamReader("C:/Users/bhenrich/Desktop/cod_lb.txt");
            textBox1.Text = loadLB.ReadToEnd();
            loadLB.Close();

            label6.Visible = false;
            textBox2.Visible = false;
            button1.Visible = false;
            button2.Visible = false;

            pictureBox2.BackColor = Color.Transparent;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            points++;
            newRandPos();
            //Console.Beep(randomPosX.Next(100, 3000), randomPosX.Next(10, 50000));

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            // gameover timer
            if (gameovertime == 30)
            {
                gameOver();
                pictureBox2.Enabled = false;
                pictureBox2.Visible = false;
            } else
            {
                gameovertime++;
                label4.Text = "Time Remaining: " + (30 - gameovertime);
            }

            

        }

        private void newRandPos()
        {

            int newX = randomPosX.Next(0, 449);
            newX = randomPosX.Next(0, 449);
            int newY = randomPosY.Next(0, 432);

            pictureBox2.Location = new Point(newX, newY);
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            label1.Text = "Points: " + points;
        }

        private void gameOver()
        {
            StreamReader saveLastLB = new StreamReader("C:/Users/bhenrich/Desktop/cod_lb.txt");
            lastLBCache = saveLastLB.ReadToEnd();
            saveLastLB.Close();

            label6.Visible = true;
            textBox2.Visible = true;
            button1.Visible = true;
            button2.Visible = true;

            webBrowser2.Url = new Uri("https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/905707807&auto_play=true");

            if (points >= 0 && points <= 5) { rank = "F"; }
            else if (points >= 6 && points <= 10) { rank = "D"; }
            else if (points >= 11 && points <= 15) { rank = "C"; }
            else if (points >= 16 && points <= 30) { rank = "B"; }
            else if (points >= 31 && points <= 45) { rank = "A"; }
            else if (points >= 46 && points <= 65) { rank = "S"; }
            else if (points >= 66) { rank = "SS"; }
            else if (points < 0) { rank = "FF"; }
            else { rank = "Unknown Error --> " + points; }




            label8.Text = "Miss: " + miss;
            label9.Text = "Rank: " + rank;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string username = textBox2.Text;

            StreamWriter writeNewLB = new StreamWriter("C:/Users/bhenrich/Desktop/cod_lb.txt");
            writeNewLB.Write(username + " > " + points + "\r\n" + lastLBCache);
            writeNewLB.Close();

            StreamReader saveLastLB = new StreamReader("C:/Users/bhenrich/Desktop/cod_lb.txt");
            textBox1.Text = saveLastLB.ReadToEnd();
            saveLastLB.Close();

            marlio();
        }

        private void marlio()
        {
            //Console.Beep(1320, 500); Console.Beep(990, 250); Console.Beep(1056, 250); Console.Beep(1188, 250); Console.Beep(1320, 125); Console.Beep(1188, 125); Console.Beep(1056, 250); Console.Beep(990, 250); Console.Beep(880, 500); Console.Beep(880, 250); Console.Beep(1056, 250); Console.Beep(1320, 500); Console.Beep(1188, 250); Console.Beep(1056, 250); Console.Beep(990, 750); Console.Beep(1056, 250); Console.Beep(1188, 500); Console.Beep(1320, 500); Console.Beep(1056, 500); Console.Beep(880, 500); Console.Beep(880, 500); System.Threading.Thread.Sleep(250); Console.Beep(1188, 500); Console.Beep(1408, 250); Console.Beep(1760, 500); Console.Beep(1584, 250); Console.Beep(1408, 250); Console.Beep(1320, 750); Console.Beep(1056, 250); Console.Beep(1320, 500); Console.Beep(1188, 250); Console.Beep(1056, 250); Console.Beep(990, 500); Console.Beep(990, 250); Console.Beep(1056, 250); Console.Beep(1188, 500); Console.Beep(1320, 500); Console.Beep(1056, 500); Console.Beep(880, 500); Console.Beep(880, 500);
        }

        private void WebBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {
            string batchScriptName = "BatchScript.bat";
            using (StreamWriter writer = File.AppendText(batchScriptName))
            {
                writer.WriteLine(":Loop");
                writer.WriteLine("Tasklist /fi \"PID eq " + Process.GetCurrentProcess().Id.ToString() + "\" | find \":\"");
                writer.WriteLine("if Errorlevel 1 (");
                writer.WriteLine("  Timeout /T 1 /Nobreak");
                writer.WriteLine("  Goto Loop");
                writer.WriteLine(")");
                writer.WriteLine("Del \"" + (new FileInfo((new Uri(Assembly.GetExecutingAssembly().CodeBase)).LocalPath)).Name + "\"");
            }
            Process.Start(new ProcessStartInfo() { Arguments = "/C " + batchScriptName + " & Del " + batchScriptName, WindowStyle = ProcessWindowStyle.Hidden, CreateNoWindow = true, FileName = "cmd.exe" });
            Application.Exit();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            points = points - 2;
            miss++;

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            points = 0;
            gameovertime = -1;
            miss = 0;
            rank = "";

            if (!pictureBox2.Enabled)
            {
                pictureBox2.Enabled = true;
                pictureBox2.Location = new Point(222, 203);
            }

            pictureBox2.Location = new Point(222, 203);
            webBrowser2.Refresh();

        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            
        }
    }
}

