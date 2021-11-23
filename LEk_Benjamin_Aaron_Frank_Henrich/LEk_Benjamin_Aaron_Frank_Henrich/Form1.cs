// Benjamin Henrich

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEk_Benjamin_Aaron_Frank_Henrich
{
    public partial class Form1 : Form
    {

        // VARS

        int[] meinArray = new int[] { 4556, 233, 56, 123, 6, 9 };
        int[] gefilterterArray = new int[5];
        List<int> gefArray = new List<int>();
        List<int> gefArrayBad = new List<int>();

        // VARS

        // custom methods

        void arrayAusgeben(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                textBox1.Text += Convert.ToString(input[i]) + "  ";
            }
        }

        void arrayFilter(int grenzwert, int[] input)
        {
            textBox1.Text = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] <= grenzwert)
                {
                    gefArray.Add(input[i]);
                    textBox1.Text += input[i] + "  ";
                } else
                {
                    gefArrayBad.Add(input[i]);
                }
            }

            textBox1.Text += "\r\n" + "RAUSGEFILTERT:   ";

            for (int i = 0; i < gefArrayBad.Count; i++)
            {
                textBox1.Text += gefArrayBad[i] + "  ";
            }


        }

        void arrayFilter2()
        {
            // ich habe keine ahnung wie ich ein array mache was genau 
            // so groß ist wie notwendig ohne listen zu verwenden
        }



        // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            arrayAusgeben(meinArray);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            arrayFilter(Convert.ToInt32(textBox2.Text), meinArray);
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
