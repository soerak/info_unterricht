using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace LoginSupergeil
{
    public partial class Form1 : Form
    {

        //login vars
        string[] usernames = new String[] { "Jacob", "Marie", "Leander" };
        string[] passwords = new String[] { "communism", "1234", "Java7" };

        //collatz vars
        int u;
        int z = 0;

        //bubble vars
        int[] myArray = Enumerable.Range(0, 100).ToArray();
        int lao = 0;




        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            /*
             * Collatzfunktion
             * 
             * textBox3.Text = Convert.ToString(Collatz(Convert.ToInt32(textBox1.Text)));
             */
            

            binarySort(myArray, int.Parse(textBox1.Text));
        }

        private int Collatz(int x) {

            //u = x % 2;
            z = 0;
            while(x != 1)
            {
                if(x % 2 == 0)
                {
                    x = x / 2;
                } else {
                    x = (x * 3) + 1;
                }
                z++;
            }

            return z;

        }

        private void binarySort(int[] array, int gesucht)
        {
            int low = 0;
            int high = array.Length - 1;
            int mid = 0;
            bool gefunden = false;

            while(low <= high)
            {
                mid = (low + high) / 2;
                                                                                                                                                                                                                                        //Thread.Sleep(5000);
                if (gesucht == array[mid])
                {
                    low = high + 1;
                    gefunden = true;
                    lao++;
                } else if (gesucht > array[mid])
                {
                    low = mid + 1;
                    lao++;
                } else
                {
                    high = mid - 1;
                    lao++;
                }
            }

            if(gefunden)
            {
                textBox3.Text = "gefunden: " + mid+ "\nOperationen = " + lao;
            }

        }

    }
}
