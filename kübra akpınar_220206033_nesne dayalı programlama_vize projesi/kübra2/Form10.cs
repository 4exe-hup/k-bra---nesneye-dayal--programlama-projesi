using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kübra2
{
    public partial class Form10 : Form
    {

        private int _yas;

        public Form10(int yas) : this()
        {
            if (yas >= 30 && yas <= 50)
            {
                label7.Text = "YÜRÜYÜŞ : 0.5";
                label8.Text = "YÜZME : 0.5";

            }
            else if (yas >= 51 && yas <= 81)
            {
                label7.Text = "YÜRÜYÜŞ : 1";
                label8.Text = "YÜZME : 0.5";

            }
            else if (yas >= 82 && yas <= 100)
            {
                label7.Text = "YÜRÜYÜŞ : 1.5";
                label8.Text = "YÜZME : 0.8";

            }
            else
            {
                label7.Text = "YÜRÜYÜŞ : 2";
                label8.Text = "YÜZME : 1";

            }

        }

        public Form10()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }
    }
}
