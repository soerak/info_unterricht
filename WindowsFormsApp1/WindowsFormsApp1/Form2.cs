using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {

        Konto myKonto = new Konto(6487, 6942, 764372);
        User myUser = new User("Jacob", "Seeliger", 69429);

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt64(textBox1.Text) == myKonto.kontonummer && Convert.ToInt16(textBox2.Text) == myKonto.pin)
            {
                loadLogin();
            }
        }

        void loadLogin()
        {
            Form1 form = new Form1();
            form.Show();
            this.Visible = false;
        }
    }

    public class Konto
    {
        public float guthaben;
        public int pin;
        public int kontonummer;

        public Konto(float _guthaben, int _pin, int _kontonummer)
        {
            guthaben = _guthaben;
            pin = _pin;
            kontonummer = _kontonummer;
        }

    }

    public class User
    {
        public string vorname;
        public string nachname;
        public int kundennummer;

        public User(string _vorname, string _nachname, int _kundennummer)
        {
            vorname     = _vorname;
            nachname    = _nachname;
            kundennummer = _kundennummer;
        }
    }
}
