using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(120, 0,0,0);
        }
    
        private void button2_Click(object sender, EventArgs e)
        {
           
            Stock depo = new Stock();
            depo.ShowDialog();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            ProductsSent depoCikis = new ProductsSent();
            depoCikis.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="bakizaman" && textBox2.Text=="Bkzmn.0574")
            {
                string message = "Giriş Başarılı!";
                string title = "Bilgilendirme Ekranı";
                MessageBox.Show(message, title);

                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();
                Close();
            }
            else
            {
                string message = "Şifre Yanlış!";
                string title = "Bilgilendirme Ekranı";
                MessageBox.Show(message, title);
            }
        }
    }
}
