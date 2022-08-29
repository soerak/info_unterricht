using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sort_that_Bih
{
    public partial class Form1 : Form
    {

        int[] rawArray = new int[1000];
        float bogoLength = 0;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rng = new Random();
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                rawArray[i] = rng.Next(0, 100);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void showUnsorted_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            for (int i = 0; i < rawArray.Length; i++)
            {
                if(rawArray[i] != 0) textBox1.Text += rawArray[i].ToString() + " ";
            }
        }

        private void flushArray_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < rawArray.Length; i++)
            {
                rawArray[i] = 0;
            }
        }

        private void selectionSort_Click(object sender, EventArgs e)
        {
            int temp, smallest;
            int n = 10;
            for (int i = 0; i < n - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (rawArray[j] < rawArray[smallest])
                    {
                        smallest = j;
                    }
                }
                temp = rawArray[smallest];
                rawArray[smallest] = rawArray[i];
                rawArray[i] = temp;
            }
            textBox2.Text = "Sorted Array: ";
            foreach (var item in rawArray)
            {
                if (item != 0)
                {
                    textBox2.Text += item + " ";
                }
            }
        }

        private void insertionSort_Click(object sender, EventArgs e)
        {
            int n = 1000, i, j, val, flag;
            for (i = 1; i < n; i++)
            {
                val = rawArray[i];
                flag = 0;
                for (j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val < rawArray[j])
                    {
                        rawArray[j + 1] = rawArray[j];
                        j--;
                        rawArray[j + 1] = val;
                    }
                    else flag = 1;
                }
            }
            textBox2.Text = "Sorted Array: ";
            foreach (var item in rawArray)
            {
                if (item != 0)
                {
                    textBox2.Text += item + " ";
                }
            }

        }

        private void bubbleSort_Click(object sender, EventArgs e)
        {
            int temp;
            for (int j = 0; j <= rawArray.Length - 2; j++)
            {
                for (int i = 0; i <= rawArray.Length - 2; i++)
                {
                    if (rawArray[i] > rawArray[i + 1])
                    {
                        temp = rawArray[i + 1];
                        rawArray[i + 1] = rawArray[i];
                        rawArray[i] = temp;
                    }
                }
            }
            textBox2.Text = "Sorted Array: ";
            foreach (var item in rawArray)
            {
                if (item != 0)
                {
                    textBox2.Text += item + " ";
                }
            }
        }

        private void mergeSort_Click(object sender, EventArgs e)
        {
            rawArray = MergeSort(rawArray);
            textBox2.Text = "Sorted Array: ";
            foreach (var item in rawArray)
            {
                if (item != 0)
                {
                    textBox2.Text += item + " ";
                }
            }

        }

        public static int[] MergeSort(int[] array)
        {
            int[] left;
            int[] right;
            int[] result = new int[array.Length];
            //As this is a recursive algorithm, we need to have a base case to 
            //avoid an infinite recursion and therfore a stackoverflow
            if (array.Length <= 1)
                return array;
            // The exact midpoint of our array  
            int midPoint = array.Length / 2;
            //Will represent our 'left' array
            left = new int[midPoint];

            //if array has an even number of elements, the left and right array will have the same number of 
            //elements
            if (array.Length % 2 == 0)
                right = new int[midPoint];
            //if array has an odd number of elements, the right array will have one more element than left
            else
                right = new int[midPoint + 1];
            //populate left array
            for (int i = 0; i < midPoint; i++)
                left[i] = array[i];
            //populate right array   
            int x = 0;
            //We start our index from the midpoint, as we have already populated the left array from 0 to 
            for (int i = midPoint; i < array.Length; i++)
            {
                right[x] = array[i];
                x++;
            }
            //Recursively sort the left array
            left = MergeSort(left);
            //Recursively sort the right array
            right = MergeSort(right);
            //Merge our two sorted arrays
            result = merge(left, right);
            return result;
        }

        //This method will be responsible for combining our two sorted arrays into one giant array
        public static int[] merge(int[] left, int[] right)
        {
            int resultLength = right.Length + left.Length;
            int[] result = new int[resultLength];
            //
            int indexLeft = 0, indexRight = 0, indexResult = 0;
            //while either array still has an element
            while (indexLeft < left.Length || indexRight < right.Length)
            {
                //if both arrays have elements  
                if (indexLeft < left.Length && indexRight < right.Length)
                {
                    //If item on left array is less than item on right array, add that item to the result array 
                    if (left[indexLeft] <= right[indexRight])
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }
                    // else the item in the right array wll be added to the results array
                    else
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }
                //if only the left array still has elements, add all its items to the results array
                else if (indexLeft < left.Length)
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }
                //if only the right array still has elements, add all its items to the results array
                else if (indexRight < right.Length)
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }
            }
            return result;
        }

        private void quickSort_Click(object sender, EventArgs e)
        {
            QuickSort(0, rawArray.Length - 1);
            textBox2.Text = "Sorted Array: ";
            foreach (var item in rawArray)
            {
                if (item != 0)
                {
                    textBox2.Text += item + " ";
                }
            }
        }

        private void QuickSort(int start, int end)
        {
            int i;
            if (start < end)
            {
                i = Partition(rawArray, start, end);

                QuickSort(start, i - 1);
                QuickSort(i + 1, end);
            }
        }

        private int Partition(int[] arr, int start, int end)
        {
            int temp;
            int p = arr[end];
            int i = start - 1;

            for (int j = start; j <= end - 1; j++)
            {
                if (arr[j] <= p)
                {
                    i++;
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            temp = arr[i + 1];
            arr[i + 1] = arr[end];
            arr[end] = temp;
            return i + 1;
        }

        private void bogoSort_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            BogoSort(ref rawArray);
            timer1.Stop();
            timer1.Enabled = false;
            textBox2.Text = "Sorted Array: ";
            foreach (var item in rawArray)
            {
                if (item != 0)
                {
                    textBox2.Text += item + " ";
                }
            }
            textBox2.Text += "\r\nElapsed Time: " + (bogoLength / 1000) + "s";
        }

        private static bool IsSorted(ref int[] data)
        {
            int count = data.Length;

            while (--count >= 1)
                if (data[count] < data[count - 1]) return false;

            return true;
        }

        private static void Shuffle(ref int[] data)
        {
            int temp, rnd;
            Random rand = new Random();

            for (int i = 0; i < data.Length; ++i)
            {
                rnd = rand.Next(data.Length);
                temp = data[i];
                data[i] = data[rnd];
                data[rnd] = temp;
            }
        }

        public static void BogoSort(ref int[] data)
        {
            while (!IsSorted(ref data))
                Shuffle(ref data);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bogoLength++;
        }
    }
}
