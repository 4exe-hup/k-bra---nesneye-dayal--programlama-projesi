using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kübra2
{
    public partial class Form4 : Form
    {

        private int _yas;
        private int _boy;
        private int _kilo;

        public Form4(int yas, int boy, int kilo) : this()
        {
            _yas = yas;
            _boy = boy;
            _kilo = kilo;
        }

        public int Gelenyas => _yas;
        public int Gelenboy => _boy;
        public int Gelenkilo => _kilo;
        public Form4()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            Form5 ac = new Form5(_yas);
            ac.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 ac = new Form6(_yas);
            ac.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 ac = new Form7(_boy,_kilo);
            ac.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form8 ac = new Form8(_yas);
            ac.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form9 ac = new Form9(_yas);
            ac.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form10 ac = new Form10(_yas);
            ac.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
