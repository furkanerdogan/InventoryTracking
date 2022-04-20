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
    public partial class StockForm : Form
    {
        public StockForm()
        {
            InitializeComponent();
        }
        public string getDepo_Id;
        SqlConnection connectsql = new SqlConnection(@"Data Source=FURKANERDOĞAN\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {

            connectsql.Open();
            if (DepoComboBox.SelectedItem != "" && DepoComboBox.SelectedItem != null)
            {
                SqlCommand depoadetcommandx = new SqlCommand("select COUNT(*)  from Depo where Seri_No=@Seri_No", connectsql);
                depoadetcommandx.Parameters.AddWithValue("@Seri_No", Deposeri_NoTextBox.Text);

                string UserExist = depoadetcommandx.ExecuteScalar().ToString();
                if (UserExist == "1" && Deposeri_NoTextBox.Text!="")
                {
                        string message = "Ekleme başarısız!";
                        string title = "Bu ürün daha önce eklendi ";
                         MessageBox.Show(title, message);

                }
                else { 
                        SqlCommand command = new SqlCommand("Insert into dbo.Depo(Urun_Id, Seri_No, Adet, Tarih, Aciklama) values(@Urun_Id,@Seri_No,@Adet,@Tarih,@Aciklama)", connectsql);
                        SqlCommand findUrunId = new SqlCommand("Select Urun_Id from Urunler where Urun_Adi=@Urun_Adi", connectsql);
                        findUrunId.Parameters.AddWithValue("@Urun_Adi", DepoComboBox.SelectedItem.ToString());
                        using (SqlDataReader reader = findUrunId.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                command.Parameters.AddWithValue("@Urun_Id", reader["Urun_Id"].ToString());
                            }
                        }
                        command.Parameters.AddWithValue("@Seri_No", Deposeri_NoTextBox.Text);
                        command.Parameters.AddWithValue("@Adet", numericUpDown1.Value);
                        command.Parameters.AddWithValue("@Tarih", DepotarihDateTimePicker.Value);
                        command.Parameters.AddWithValue("@Aciklama", DepoaciklamaTextBox.Text);
                        int ok = command.ExecuteNonQuery();
                        if (ok == 1)
                        {
                            string message = "Eklendi";
                            string title = "Bilgilendirme Ekranı";
                            MessageBox.Show(message, title);
                            Close();



                        }
                }
            }
            else
            {
                MessageBox.Show("Boş Alanları Doldurunuz...");

            }
            connectsql.Close();


        }


        private void DepoForm_Load(object sender, EventArgs e)
        {

            connectsql.Open();
            SqlCommand comand = new SqlCommand("Select Urun_Adi from Urunler", connectsql);
            using (SqlDataReader reader = comand.ExecuteReader())
            {
                while (reader.Read())
                {
                    DepoComboBox.Items.Add(String.Format("{0}", reader["Urun_Adi"]));

                }
            }

            comand.ExecuteNonQuery();
            connectsql.Close();

            DepoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            DepoComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            DepoComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if (DepoaciklamaTextBox.Text != null && DepoaciklamaTextBox.Text != "" && Deposeri_NoTextBox.Text != null && Deposeri_NoTextBox.Text != "" && DepoComboBox.SelectedItem != null && DepoComboBox.SelectedItem != "")

            

                connectsql.Open();

                SqlCommand command = new SqlCommand("Update Depo Set  Urun_Id=@Urun_Id,Seri_No= @Seri_No,Adet=@Adet,Tarih=@Tarih, Aciklama=@Aciklama where Depo_Id=@Depo_Id", connectsql);
                
                SqlCommand findUrunId = new SqlCommand("Select Urun_Id from Urunler where Urun_Adi=@Urun_Adi", connectsql);
                findUrunId.Parameters.AddWithValue("@Urun_Adi", DepoComboBox.SelectedItem.ToString());
                using (SqlDataReader reader = findUrunId.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        command.Parameters.AddWithValue("@Urun_Id", reader["Urun_Id"].ToString());
                    }
                }

                command.Parameters.AddWithValue("@Seri_No", Deposeri_NoTextBox.Text);
                command.Parameters.AddWithValue("@Adet", numericUpDown1.Value);
                command.Parameters.AddWithValue("@Tarih", DepotarihDateTimePicker.Value);
                command.Parameters.AddWithValue("@Aciklama", DepoaciklamaTextBox.Text);
                command.Parameters.AddWithValue("@Depo_Id", getDepo_Id.ToString()) ;

                int ok = command.ExecuteNonQuery();
                if (ok == 1)
                {
                    string message = "Güncelleme işlemi gerçekleşti...";
                    string title = "Bilgilendirme Ekranı";
                    MessageBox.Show(message, title);
                }
                connectsql.Close();
           
            

         
            Close();
        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            DepoComboBox.Text = "";
            DepoaciklamaTextBox.Text = "";
            Deposeri_NoTextBox.Text = "";
            numericUpDown1.Value = 1;
            
        }

    }
}
