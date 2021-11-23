using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bubbleSort
{
    public partial class Form1 : Form
    {

        // VAR
        int runtime = 0;
        int[] array = new int[] { 2, 5, 3, 7, 4, 9, 1, 8, 3, 6, 5, 2, 5, 3, 7, 3, 4, 8, 5, 2, 6 };
        bool gebraucht = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            //textBox1.Text += "\n Laufzeit -> " + runtime;
            

        }
        class DeezNuts
        {
            public string name;
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            DeezNuts[] idioten = new DeezNuts[3];

            Random bruh1 = new Random();
            label1.Text = "";

            for (int i = 0; i < 3; i++)
            {
                
                string bruh2 = Convert.ToString((bruh1.NextDouble()));
                idioten[i] = new DeezNuts();
                idioten[i].name = "bruh: " + bruh2;
                label1.Text += idioten[i].name + "\r\n";
            }
        }
    }
}
