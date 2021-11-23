using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelectionSort
{
    public partial class Form1 : Form
    {

        int randNum;
        int[] randArray = new int[] { };
        int n = 0;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int Min = 0;
            int Max = 20;
            Random randNum = new Random();
            int[] randArray = Enumerable
                .Repeat(0, 10)
                .Select(i => randNum.Next(Min, Max))
                .ToArray();

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(randArray[i]);
            }

            SelectionSort(randArray);

        }

        private void SelectionSort(int[] array)
        {
            int temp, smallest;
            for (int i = 0; i < n - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[smallest])
                    {
                        smallest = j;
                    }
                }
                temp = array[smallest];
                array[smallest] = array[i];
                array[i] = temp;
            }
            Console.WriteLine();
            Console.Write("Array =  ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
        }


    }
}
