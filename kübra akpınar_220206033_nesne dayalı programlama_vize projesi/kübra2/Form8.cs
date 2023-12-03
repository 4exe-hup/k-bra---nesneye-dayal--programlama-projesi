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


    public partial class Form8 : Form
    {

        private int _yas;
        public Form8(int yas) : this()
        {

            if (yas >= 1 && yas <= 17)
            {
                label7.Text = "3 - 4";

            }
            else if (yas >= 18 && yas <= 30)
            {
                label7.Text = "3 - 5";

            }
            else if (yas >= 31 && yas <= 50)
            {
                label7.Text = "3 - 4";

            }
            else
            {
                label7.Text = "3 - 4";

            }


        }

        public Form8()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
