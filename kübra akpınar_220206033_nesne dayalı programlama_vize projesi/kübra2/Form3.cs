using System;
using System.Threading;
using System.Windows.Forms;

namespace kübra2
{
    public partial class Form3 : Form
    {

        private int _yas;
        private int _boy;
        private int _kilo;

        public Form3(int yas, int boy, int kilo) : this()
        {
            _yas = yas;
            _boy = boy;
            _kilo = kilo;
        }

        public int Gelenyas => _yas;
        public int Gelenboy => _boy;
        public int Gelenkilo => _kilo;

        public Form3()
        {
            InitializeComponent();
        }

        // Form3 yüklenirken çalışacak olay işleyicisi
        private void Form3_Load(object sender, EventArgs e)
        {
            // Arka planda 10 saniye bekleyip sonra Form4'ü açan görevi başlat
            ThreadPool.QueueUserWorkItem(new WaitCallback((state) =>
            {
                Thread.Sleep(10000); // 10 saniye bekleyin

                // Form4'ü açmak için ana thread üzerinden işlem yapın
                this.Invoke(new Action(() =>
                {
                    OpenForm4();
                }));
            }));
        }

        private void OpenForm4()
        {
            // Form4'ü aç
            Form4 form4 = new Form4(_yas,_boy,_kilo);
            form4.Show();

            // Form3'ü kapat
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
