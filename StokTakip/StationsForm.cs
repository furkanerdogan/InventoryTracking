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
    public partial class StationsForm : Form
    {
        public StationsForm()
        {
            InitializeComponent();
        }
        SqlConnection sqlconnect = new SqlConnection(@"Data Source=FURKANERDOĞAN\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
        public string getIStasyon_Id;
        private void UrunlerForm_AddBtn_Click(object sender, EventArgs e)
        {

            var isNumeric1 = int.TryParse(IstasyonNoTextBox.Text, out int n);
            var isNumeric2 = int.TryParse(IstasyonbayiNoTextBox.Text, out int m);


            if (IstasyonAdiTxt.Text != "" && IstasyonNoTextBox.Text != "")
            {
                if (isNumeric1 == true && isNumeric2==true)
                {
                    try
                    {
                            sqlconnect.Open();
                            SqlCommand depoadetcommandx = new SqlCommand("select COUNT(*)  from Istasyonlar where Istasyon_No=@Istasyon_No", sqlconnect);
                            depoadetcommandx.Parameters.AddWithValue("@Istasyon_No", IstasyonNoTextBox.Text);

                            string UserExist = depoadetcommandx.ExecuteScalar().ToString();
                            if (UserExist == "1")
                            {
                                string message = "Ekleme başarısız!";
                                string title = "Bu istasyon daha önce eklendi ";
                                MessageBox.Show(title, message);

                            }
                            else { 
                            SqlCommand command = new SqlCommand("Insert into Istasyonlar(Istasyon_Adi, Istasyon_No,Istasyon_Bayi_No) values(@Istasyon_Adi,@Istasyon_No,@Istasyon_Bayi_No)", sqlconnect);
                            command.Parameters.AddWithValue("@Istasyon_Adi", IstasyonAdiTxt.Text);
                            command.Parameters.AddWithValue("@Istasyon_No", IstasyonNoTextBox.Text);
                            command.Parameters.AddWithValue("@Istasyon_Bayi_No", IstasyonbayiNoTextBox.Text);

                            int a = command.ExecuteNonQuery();
                                    if (a == 1)
                                    {
                                        string message = "Eklendi";
                                        string title = "Bilgilendirme Ekranı";
                                        MessageBox.Show(message, title);
                                        Close();


                                    }
                                    else
                                    {
                                        MessageBox.Show("Ekleme işlemi başarısız...");

                                    }
                            sqlconnect.Close();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata" + ex);
                    }
                }
                else
                {
                    MessageBox.Show("İstasyon numarası ve bayi numarası sayı olmalıdır...");
                }

            }

            else
            {
                MessageBox.Show("Boş Alanları Doldurunuz...");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IstasyonAdiTxt.Text = "";
            IstasyonNoTextBox.Text = "";
            IstasyonbayiNoTextBox.Text = "";
        }

        private void IstasyonFormUpdate_Click(object sender, EventArgs e)
        {
            
            var isNumeric = int.TryParse(IstasyonNoTextBox.Text, out int n);
            var isNumeric2 = int.TryParse(IstasyonbayiNoTextBox.Text, out int mn);

            if (IstasyonAdiTxt.Text != "")
            {
                if (isNumeric == true && isNumeric2==true)
                {
                    try
                    {

                        sqlconnect.Open();
                        SqlCommand command = new SqlCommand("Update Istasyonlar Set Istasyon_Adi=@Istasyon_Adi,Istasyon_No=@Istasyon_No,Istasyon_Bayi_No=@Istasyon_Bayi_No where Istasyon_Id=@Istasyon_Id", sqlconnect);
                        command.Parameters.AddWithValue("@Istasyon_Adi", IstasyonAdiTxt.Text);
                        command.Parameters.AddWithValue("@Istasyon_No", IstasyonNoTextBox.Text);
                        command.Parameters.AddWithValue("@Istasyon_Bayi_No", IstasyonbayiNoTextBox.Text);

                        command.Parameters.AddWithValue("@Istasyon_Id", getIStasyon_Id);
                        int ok = command.ExecuteNonQuery();
                        if (ok == 1)
                        {
                            string message = "Güncelleme işlemi gerçekleşti...";
                            string title = "Bilgilendirme Ekranı";
                            MessageBox.Show(message, title);
                            Close();
                        }

                            sqlconnect.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata" + ex);
                    }
                }
                else
                {
                    MessageBox.Show("Istasyon numarası  ve bayi numarası sayı olmalıdır !");

                }
            }
            else
            {
                MessageBox.Show("İstasyon Adı Boş Bırakılamaz!");

            }
           

        }

      
    }
}
