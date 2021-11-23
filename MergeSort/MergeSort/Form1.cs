using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MergeSort
{
    public partial class Form1 : Form
    { 
        // vars

        int[] arrayA = new int[] { 1, 3, 4, 7, 9, 10, 11};
        int[] arrayB = new int[] { 4, 5, 6, 6, 7, 8 };
        int[] mergedArrayPublic = new int[13];
        
        // vars




        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void merge()
        {
            
        }


        

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            merge(arrayA, arrayB);
            ms();
        }
    }
}
