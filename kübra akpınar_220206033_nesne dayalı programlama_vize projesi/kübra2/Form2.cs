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
    public partial class Form2 : Form
    {

        public string TextBox1Value { get; private set; }
        public string ComboBox1Value { get; private set; }
        public string TextBox3Value { get; private set; }
        public string TextBox4Value { get; private set; }
        public Form2()
        {
            InitializeComponent();

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.Add("KADIN");
            comboBox1.Items.Add("ERKEK");
        }
        public Form2(string gelenMetin) : this()
        {
            // Form2'deki Label'a metni yerleştir
            label1.Text = "MERHABA " + gelenMetin;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TextBox'ları kontrol et
            if (numericUpDown1.Value == 0  ||
                comboBox1.SelectedItem == null ||
                numericUpDown2.Value == 0 ||
                numericUpDown3.Value == 0)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int yas = (int)numericUpDown1.Value;
            int boy = (int)numericUpDown2.Value;
            int kilo = (int)numericUpDown3.Value;



            // Form3'e geçiş yap
            Form3 form3 = new Form3(yas, boy, kilo);
            form3.Show();

            // Form2'yi gizle veya kapat
            this.Hide();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}