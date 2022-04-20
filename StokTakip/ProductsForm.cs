using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StokTakip
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
        }
        SqlConnection sqlconnect = new SqlConnection(@"Data Source=FURKANERDOĞAN\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
        public string getUrun_Id;
        private void button1_Click(object sender, EventArgs e)
        {
            var isNumeric = int.TryParse(urun_FiyatTextBox.Text, out int n);
            sqlconnect.Open();

            if (urunAdiTxt.Text != null && urun_ModelTextBox.Text != "" && urun_FiyatTextBox.Text != null)
            {
                if (isNumeric == true)
                {

                    SqlCommand depoadetcommandx = new SqlCommand("select COUNT(*)  from Urunler where Urun_Adi=@Urun_Adi", sqlconnect);
                    depoadetcommandx.Parameters.AddWithValue("@Urun_Adi", urunAdiTxt.Text);

                    string UserExist = depoadetcommandx.ExecuteScalar().ToString();
                    if (UserExist == "1")
                    {
                        string message = "Ekleme başarısız!";
                        string title = "Bu ürün daha önce eklendi ";
                        MessageBox.Show(title, message);

                    }
                    else { 
                    SqlCommand command = new SqlCommand("Insert into Urunler(Urun_Adi, Urun_Marka, Urun_Fiyat,Aciklama) values(@Urun_Adi,@Urun_Marka,@Urun_Fiyat,@Aciklama)", sqlconnect);

                    command.Parameters.AddWithValue("@Urun_Adi", urunAdiTxt.Text);
                    command.Parameters.AddWithValue("@Urun_Marka", urun_ModelTextBox.Text);
                    command.Parameters.AddWithValue("@Urun_Fiyat", urun_FiyatTextBox.Text);
                    command.Parameters.AddWithValue("@Aciklama", UrunaciklamaTextBox.Text);

                    int ok = command.ExecuteNonQuery();
                        if (ok == 1)
                        {
                            string message = "Eklendi";
                            string title = "Bilgilendirme Ekranı";
                            MessageBox.Show(message, title);
                            Close();
                     

                        }
                        else
                        {
                            MessageBox.Show("Başarısız");

                        }
                    }

                }
                else
                {
                    MessageBox.Show("fiyat sayı içermelidir!!");
                }

            }
            else
            {
                MessageBox.Show("Boş Alanları Doldurunuz...");

            }
            sqlconnect.Close();
        }

        private void UrunlerForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (urunAdiTxt.Text != null && urun_ModelTextBox.Text != "" && urun_FiyatTextBox.Text != null)
            {

                sqlconnect.Open();

                SqlCommand command = new SqlCommand("Update Urunler Set Urun_Adi= @Urun_Adi, Urun_Marka=@Urun_Marka, Urun_Fiyat=@Urun_Fiyat, Aciklama=@Aciklama where Urun_Id=@Urun_Id ", sqlconnect);
                command.Parameters.AddWithValue("@Urun_Adi", urunAdiTxt.Text);
                command.Parameters.AddWithValue("@Urun_Marka", urun_ModelTextBox.Text);
                command.Parameters.AddWithValue("@Urun_Fiyat", urun_FiyatTextBox.Text);
                command.Parameters.AddWithValue("@Urun_Id", Convert.ToInt32(getUrun_Id));
                command.Parameters.AddWithValue("@Aciklama", UrunaciklamaTextBox.Text);


                command.ExecuteNonQuery();
                int ok = command.ExecuteNonQuery();
                if (ok == 1)
                {
                    string message = "Güncelleme işlemi gerçekleşti...";
                    string title = "Bilgilendirme Ekranı";
                    MessageBox.Show(message, title);               

                }
                sqlconnect.Close();      
                            
            }

            else
            {
                MessageBox.Show("Güncellemek için boş Alanları Doldurunuz...");

            }
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            urunAdiTxt.Text = "";
            urun_ModelTextBox.Text = "";
            urun_FiyatTextBox.Text = "";
            UrunaciklamaTextBox.Text = "";
        }

        
    }
}
