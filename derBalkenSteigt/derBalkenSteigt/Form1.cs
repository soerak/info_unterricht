using System.IO;
using System.Linq;

namespace derBalkenSteigt
{
    public partial class Form1 : Form
    {

        string[] dataCountry = new string[9];
        string[] dataCount = new string[9];
        StreamReader CSVReader = new StreamReader("23211-0001.txt");
        string[] data = new string[1];

        public Form1()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            string dataDump;
            /* DEBUG */
            label1.Text = (string)CSVReader.ReadToEnd();
            for (int i = 0; i < 9; i++)
            {
                dataDump = (string)CSVReader.ReadToEnd();
                /* DEBUG */ //label1.Text = dataDump;
                data = dataDump.Split(";");
                
                //int data1Parsed = int.Parse(data[1]);
                //int data1Floored = Math.Floor(baba);

                /* DEBUG */ for (int j = 0; j < 1; j++) { Console.WriteLine((string)data[j]); }
                /*
                if      (i == 0) { pictureBox1.Size  = new Size(34, data1Parsed);  } 
                else if (i == 1) { pictureBox2.Size  = new Size(34, data1Parsed);  }
                else if (i == 2) { pictureBox3.Size  = new Size(34, data1Parsed);  }
                else if (i == 3) { pictureBox4.Size  = new Size(34, data1Parsed);  }
                else if (i == 4) { pictureBox5.Size  = new Size(34, data1Parsed);  }
                else if (i == 5) { pictureBox6.Size  = new Size(34, data1Parsed);  }
                else if (i == 6) { pictureBox7.Size  = new Size(34, data1Parsed);  }
                else if (i == 7) { pictureBox8.Size  = new Size(34, data1Parsed);  }
                else if (i == 8) { pictureBox9.Size  = new Size(34, data1Parsed);  }
                else if (i == 9) { pictureBox10.Size = new Size(34, data1Parsed);  } */
                

                pictureBox1.Size = new Size(34, 72);
                


            }
            //CSVReader.Close();

        }

        private void drawBalken(int value)
        {
            int length = dataCountry.Length;
            PictureBox[] pbArray = new PictureBox[length];

            for (int i = 0;i < pbArray.Length; i++)
            {
                pbArray[i] = new PictureBox();
                pbArray[i].Location = new Point(20, 500);
                pbArray[i].Size = new Size(19, value);
                pbArray[i].BackColor = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            drawBalken(100);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader myReader = new StreamReader("data.txt");

            label1.Text +=  (char)myReader.Read();
            myReader.Close();
        }
    }
}