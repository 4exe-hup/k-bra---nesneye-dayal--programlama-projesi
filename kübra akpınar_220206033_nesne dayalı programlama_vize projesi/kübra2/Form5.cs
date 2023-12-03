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
    public partial class Form5 : Form
    {

        private int _yas;
        public Form5(int yas) : this()
        {

            if (yas >= 1 && yas <= 17)
            {
                label7.Text = "GÜNLÜK 2.5 LİTRE";
                label8.Text = "HAFTALIK 17.5 LİTRE";
                label9.Text = "AYLIK 75 LİTRE";
            }
            else if (yas >= 18 && yas <= 30)
            {
                label7.Text = "GÜNLÜK 2 LİTRE";
                label8.Text = "HAFTALIK 14 LİTRE";
                label9.Text = "AYLIK 60 LİTRE";
            }
            else if (yas >= 31 && yas <= 50)
            {
                label7.Text = "GÜNLÜK 2.5 LİTRE";
                label8.Text = "HAFTALIK 17.5 LİTRE";
                label9.Text = "AYLIK 75 LİTRE";
            }
            else
            {
                label7.Text = "GÜNLÜK 2 LİTRE";
                label8.Text = "HAFTALIK 14 LİTRE";
                label9.Text = "AYLIK 60 LİTRE";
            }
        }

        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
