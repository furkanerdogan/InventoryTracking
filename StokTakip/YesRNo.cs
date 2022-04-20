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
    public partial class YesRNo : Form
    {
        public Boolean TrueFalse;
        public string ActionString="";

        public YesRNo()
        {
            InitializeComponent();
        }

        private void YesRNo_Load(object sender, EventArgs e)
        {
            label1.Text = ActionString.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TrueFalse = true;
          
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TrueFalse = false;

            Close();

        }

    }
}
