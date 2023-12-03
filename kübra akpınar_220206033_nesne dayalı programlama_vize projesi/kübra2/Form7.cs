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


    public partial class Form7 : Form
    {

        private int _boy;
        private int _kilo;


        public Form7(int boy, int kilo) : this()
        {
            if (boy >= 181 && boy <= 200 && kilo >= 50 && kilo <= 80)
            {
                // Belirli bir boy ve kilo aralığına göre uyum oranını kontrol et
                if (kilo / (boy / 100.0 * boy / 100.0) < 18.5)
                {
                    label7.Text = "Boy ve kilo uyumu düşük.";
                    label8.Text = "uyum oranı : %50.";
                }
                else if (kilo / (boy / 100.0 * boy / 100.0) >= 18.5 && kilo / (boy / 100.0 * boy / 100.0) < 25)
                {
                    label7.Text = "Boy ve kilo uyumu normal.";
                    label8.Text = "uyum oranı : %85.";
                }
                else if (kilo / (boy / 100.0 * boy / 100.0) >= 25 && kilo / (boy / 100.0 * boy / 100.0) < 30)
                {
                    label7.Text = "Boy ve kilo uyumu yüksek.";
                    label8.Text = "uyum oranı : %95.";
                }
                else
                {
                    label7.Text = "Boy ve kilo uyumu çok yüksek.";
                    label8.Text = "uyum oranı : %100.";
                }
            }
            else
            {

                label7.Text = "Boy ve kilo uyumu çok düşük.";
                label8.Text = "uyum oranı : %20.";
            }

        }

        public Form7()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
