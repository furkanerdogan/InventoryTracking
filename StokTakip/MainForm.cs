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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private Form activeForm = null;
     
        private void openChildgrom(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();

            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Paneltemp.Controls.Add(childForm);
            Paneltemp.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label8.Text = "Depo";
            openChildgrom(new Stock());
           

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label8.Text = "Ürünler";

            openChildgrom(new Products());

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label8.Text = "Gönderilen Ürünler";

            openChildgrom(new ProductsSent());

        }

     
        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            label8.Text = "Istasyonlar";

            openChildgrom(new Istasyon());

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            YesRNo yesRNo = new YesRNo();
            yesRNo.ShowDialog();
            yesRNo.ActionString = "Çıkmak istediğinize emin misiniz?";
            if (yesRNo.TrueFalse == true)
            {
                Application.Exit();

            }
        }

       
    }
}
