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
    public partial class Form6 : Form
    {

        //private int _yas;

        public Form6(int yas) : this()
        {

            if (yas >= 1 && yas <= 17)
            {
                label7.Text = "GÜNLÜK 2700-3200";
                label8.Text = "HAFTALIK 18,900-22,400";
                label9.Text = "AYLIK 81,000-96,000";
            }
            else if (yas >= 18 && yas <= 30)
            {
                label7.Text = "GÜNLÜK 2500-3000";
                label8.Text = "HAFTALIK 17,500-21,000";
                label9.Text = "AYLIK 75,000-90,000";
            }
            else if (yas >= 31 && yas <= 50)
            {
                label7.Text = "GÜNLÜK 2300-2800";
                label8.Text = "HAFTALIK 16,100-19,600";
                label9.Text = "AYLIK 69,000-84,000";
            }
            else
            {
                label7.Text = "GÜNLÜK 2000-2400";
                label8.Text = "HAFTALIK 14,000-16,800";
                label9.Text = "AYLIK 60,000-72,000";
            }

        }

        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
