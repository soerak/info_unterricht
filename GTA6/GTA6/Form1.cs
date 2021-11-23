using System;
//using System.Timers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTA6
{
    public partial class Form1 : Form
    {

        Point point = new Point();
        Timer timer1 = new Timer();
        int moveVar = 4;
        Random r = new Random();
        Random r2 = new Random();
        int score = 0;
        bool up = false;
        bool down = false;
        bool pUsed = false;
        bool pause = false;

        void coin()
        {
            if(coin1.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                score++;
                coin1.Location = new Point(coin1.Location.X + 600, coin1.Location.Y - coin1.Location.Y);
                coin1.Location = new Point(coin1.Location.Y + r.Next(0, 500));


            }

            if(coin1.Location.X >= -10)
            {
                coin1.Location = new Point(coin1.Location.X + 600, coin1.Location.Y - coin1.Location.Y);
                coin1.Location = new Point(coin1.Location.Y + r.Next(0, 500));
            }
        }




        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X + 20, pictureBox1.Location.Y + 200);
            coin1.Location = new Point(coin1.Location.X + 100, coin1.Location.Y + r.Next(0, 400));
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            //pictureBox1.Location = new Point(pictureBox1.Location.X + 10);
            coin1.Location = new Point(coin1.Location.X - 12, coin1.Location.Y);
            label1.Text = "Score: " + score;

            if (up == true && pictureBox1.Location.Y >= 5)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - moveVar);
            }

            if (down == true && pictureBox1.Location.Y <= 560)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + moveVar);
            }

            



        }

        private void Die()
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
            timer5.Stop();
            label3.Visible = true;
        }

        private void Form1_KeyDown_1(object sender, KeyEventArgs e) //--------
        {


                if (e.KeyCode == Keys.Up)
                {
                    up = true;
                }


                else if (e.KeyCode == Keys.Down)
                {
                    down = true;
                }

            if (e.KeyCode == Keys.Space)
            {
                for (int x = 0; x < 600; x++)
                {
                    if (x >= 500 && pUsed == false) { moveVar = 50; }
                    else { moveVar = 4; }
                }
                pUsed = true;
            }

            

            
        }

        private void Coin1_Click(object sender, EventArgs e)
        {

        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            //coin();
            
        }

        private void Timer4_Tick(object sender, EventArgs e)
        {
            if (coin1.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                score++;
                coin1.Location = new Point(coin1.Location.X + 700, coin1.Location.Y - coin1.Location.Y);
                coin1.Location = new Point(coin1.Location.X, coin1.Location.Y + r.Next(0, 500));


            }

            if (coin1.Location.X <= -10)
            {
                coin1.Location = new Point(coin1.Location.X + 900, coin1.Location.Y - coin1.Location.Y);
                coin1.Location = new Point(coin1.Location.X, coin1.Location.Y + r.Next(0, 500));
                //Application.Exit();
                Die();
            }



        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {



                if (e.KeyCode == Keys.Down)
                {
                    down = false;
                }

                else if (e.KeyCode == Keys.Up)
                {
                    up = false;
                }

            if (e.KeyCode == Keys.Escape && pause)
            {
                pause = false;
            }
            else if (e.KeyCode == Keys.Escape && !pause)
            {
                pause = true;
            }


        }

        private void Timer5_Tick(object sender, EventArgs e)
        {
            if (pause)
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                timer4.Stop();
                label2.Visible = true;
            } else
            {
                timer1.Start();
                timer2.Start();
                timer3.Start();
                timer4.Start();
                label2.Visible = false;
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
