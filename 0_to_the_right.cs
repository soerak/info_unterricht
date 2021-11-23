using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DerZugMussSortiertWerden
{
    public partial class Form1 : Form
    {

        int[] zug = new int[] { 1, 1, 1, 1, 0, 0, 0, 1, 1, 0, 0, 1 };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OToTheRight(zug);
        }

        private void OToTheRight(int[] array)
        {
            int[] sortedArray = new int[array.Length];
            int lastDigit = 0;
            int a = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                {
                    sortedArray[i - a] = array[i];
                }
                else
                {
                    sortedArray[i - lastDigit] = array[i];
                    a++;
                    lastDigit++;
                }

            }

            for (int j = 0; j < sortedArray.Length; j++)
            {
                textBox1.Text += sortedArray[j] + "  ";
            }

        }
    }
}
