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
    public partial class Form9 : Form
    {

        private int _yas;

        public Form9(int yas) : this()
        {

            if (yas >= 1 && yas <= 17)
            {
                label7.Text = "DİYET YAPMAMALISINIZ !";

            }
            else if (yas >= 18 && yas <= 30)
            {
                label7.Text = "BAZI GÜNLERDE SADECE 2 ÖĞÜN YETERLİDİR .";

            }
            else if (yas >= 31 && yas <= 50)
            {
                label7.Text = "ARA SIRA DİYET YAPMALISINIZ , SAĞLIĞINIZA DİKKAT EDİNİZ !";

            }
            else
            {
                label7.Text = "HAFTADA SADECE BİR GÜN %50 DAHA AZ YEMEK TÜKETİN!";

            }

        }

        public Form9()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }
    }
}
