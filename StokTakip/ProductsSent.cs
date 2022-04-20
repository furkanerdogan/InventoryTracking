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
using ClosedXML.Excel;

namespace StokTakip
{
    public partial class ProductsSent : Form
    {
        public ProductsSent()
        {
            InitializeComponent();
        }
        public string Gelen_Depo_Id;
        Boolean Isfiltered = true;

        public Boolean Tasi = false;
        SqlConnection sqlconnect = new SqlConnection(@"Data Source=FURKANERDOĞAN\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
        DataTable table = new DataTable();
        private void DepoCikis_Load(object sender, EventArgs e)
        {
            this.table = masterDataSet.DepoCikis;
            sqlconnect.Open();

            SqlCommand comand2 = new SqlCommand("Select Urunler.Urun_Adi from Urunler,Depo,DepoCikis where Urunler.Urun_Id=Depo.Urun_Id and Depo.Depo_Id=DepoCikis.Depo_Id GROUP BY  Urunler.Urun_Adi ", sqlconnect);
            using (SqlDataReader reader = comand2.ExecuteReader())
            {
                while (reader.Read())
                {
                    toolStripComboBox1.Items.Add(String.Format("{0}", reader["Urun_Adi"]));
                }
            }
            comand2.ExecuteNonQuery();
            sqlconnect.Close();
            

            // TODO: Bu kod satırı 'masterDataSet.DepoCikis' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.depoCikisTableAdapter.Fill(this.masterDataSet.DepoCikis);
            
            

            //Depocikis_Urun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            //Depocikis_Urun.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //Depocikis_Urun.AutoCompleteSource = AutoCompleteSource.ListItems;        
        }


        private void toolStripButton2_Click(object sender, EventArgs e)
        {
           
            ProductsSentForm depoCikisForm = new ProductsSentForm();
            depoCikisForm.DepoCikisFormAdd.Enabled = true;
            depoCikisForm.DepoCikisFormUpdate.Enabled = false;
            depoCikisForm.DepoCikisIstasyonAdiTxt.Enabled = false;
            depoCikisForm.DepoCikisIstasyonNoTextBox.Enabled = false;
            depoCikisForm.DepoCikisIstasyonbayiNoTextBox.Enabled = false;
            depoCikisForm.DepoCikisComboBox.Enabled = false;
            depoCikisForm.CikisseriNoTextBox.Enabled = false;
            depoCikisForm.DepoCikistarihDateTimePicker.Enabled = false;
            depoCikisForm.DepoCikisaciklamaTextBox.Enabled = false;


            depoCikisForm.ShowDialog();
            try
            {
                this.depoCikisTableAdapter.Fill(this.masterDataSet.DepoCikis);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }



        }

    

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try {
                this.depoCikisTableAdapter.Fill(this.masterDataSet.DepoCikis);
                sqlconnect.Open();
            toolStripComboBox1.Items.Clear();
            SqlCommand comand2 = new SqlCommand("Select Urunler.Urun_Adi from Urunler,Depo,DepoCikis where Urunler.Urun_Id=Depo.Urun_Id and Depo.Depo_Id=DepoCikis.Depo_Id GROUP BY  Urunler.Urun_Adi ", sqlconnect);
            using (SqlDataReader reader = comand2.ExecuteReader())
            {
                while (reader.Read())
                {
                    toolStripComboBox1.Items.Add(String.Format("{0}", reader["Urun_Adi"]));
                }
            }
            comand2.ExecuteNonQuery();
            sqlconnect.Close();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
          
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {

            Isfiltered = true;
            DataTable table1 = new DataTable();
            sqlconnect.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT Istasyonlar.Istasyon_Id,Istasyonlar.Istasyon_Adi,Urunler.Urun_Adi,Depo.Depo_Id, Depo.Urun_Id, Depo.Seri_No, DepoCikis.Adet, DepoCikis.Tarih, DepoCikis.Aciklama FROM Depo,Urunler,DepoCikis,Istasyonlar where Urunler.Urun_Id=Depo.Urun_Id and Depo.Depo_Id=DepoCikis.Depo_Id and Istasyonlar.Istasyon_Id=DepoCikis.Istasyon_Id and Depo.Seri_No like'%" + toolStripTextBox1.Text +  "%' ", sqlconnect);
            //SqlDataAdapter adtr = new SqlDataAdapter("SELECT Urunler.Urun_Adi, Urunler.Urun_Marka,Urunler.Urun_Fiyat,Urunler.Aciklama FROM dbo.Urunler where  Urun_Adi like'%" + toolStripTextBox1.Text + "%'OR Aciklama like '%" + toolStripTextBox1.Text + "%' ", sqlconnect);

            adtr.Fill(table1);
            table = table1;
            depoCikisDataGridView.DataSource = table;
            sqlconnect.Close();

            //DataTable table1 = new DataTable();
            //sqlconnect.Open();

            //SqlDataAdapter adtr = new SqlDataAdapter("SELECT Istasyonlar.Istasyon_Adi,Urunler.Urun_Adi, Depo.Seri_No, DepoCikis.Adet, DepoCikis.Tarih, DepoCikis.Aciklama FROM Depo,Urunler,DepoCikis,Istasyonlar where Urunler.Urun_Id = Depo.Urun_Id and Depo.Depo_Id = DepoCikis.Depo_Id and Istasyonlar.Istasyon_Id = DepoCikis.Istasyon_Id and Istasyonlar.Istasyon_Adi like'%" + toolStripTextBox1.Text + "%' OR Urunler.Urun_Adi like '%" + toolStripTextBox1.Text + "%' OR Depo.Seri_No like '%" + toolStripTextBox1.Text + "%'", sqlconnect);
            //adtr.Fill(table1);
            //table = table1;
            //depoCikisDataGridView.DataSource = table1;
            //sqlconnect.Close();
        


        }


        private void depoCikisDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.depoCikisTableAdapter.FillBy(this.masterDataSet.DepoCikis);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void depoCikisDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int DepoAdet = 0;
            int DepoCikis_Adet = 0;

            string colName = depoCikisDataGridView.Columns[e.ColumnIndex].Name;

            if (colName == "Düzenle")
            {
                sqlconnect.Close();
                sqlconnect.Open();
                ProductsSentForm depoCikisForm = new ProductsSentForm();
                depoCikisForm.willUpdateIstasyon_Id = depoCikisDataGridView.CurrentRow.Cells["Istasyon_Id"].Value.ToString();
                depoCikisForm.willUpdategetDepo_Id = depoCikisDataGridView.CurrentRow.Cells["Depo_Id"].Value.ToString();

                SqlCommand comand = new SqlCommand("Select Istasyonlar.Istasyon_No,Istasyonlar.Istasyon_Bayi_No,Istasyonlar.Istasyon_Adi,Urunler.Urun_Adi,Depo.Seri_No from Urunler,Depo,Istasyonlar,DepoCikis where DepoCikis.Istasyon_Id=Istasyonlar.Istasyon_Id and DepoCikis.Istasyon_Id=@Istasyon_Id and Depo.Urun_Id=Urunler.Urun_Id and Depo.Depo_Id=@Depo_Id", sqlconnect);
                comand.Parameters.AddWithValue("@Depo_Id", depoCikisDataGridView.CurrentRow.Cells["Depo_Id"].Value.ToString());
                comand.Parameters.AddWithValue("@Istasyon_Id", depoCikisDataGridView.CurrentRow.Cells["Istasyon_Id"].Value.ToString());

                using (SqlDataReader reader = comand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        depoCikisForm.DepoCikisComboBox.Text = reader["Urun_Adi"].ToString();
                        depoCikisForm.CikisseriNoTextBox.Text = reader["Seri_No"].ToString();
                        depoCikisForm.DepoCikisIstasyonAdiTxt.Text = reader["Istasyon_Adi"].ToString();
                        depoCikisForm.DepoCikisIstasyonNoTextBox.Text = reader["Istasyon_No"].ToString();
                        depoCikisForm.DepoCikisIstasyonbayiNoTextBox.Text = reader["Istasyon_Bayi_No"].ToString();
                    }
                }
                comand.ExecuteNonQuery();
                sqlconnect.Close();

                depoCikisForm.DepoCikisFormAdd.Enabled = false;
                depoCikisForm.DepoCikisFormUpdate.Enabled = true;
                depoCikisForm.DepoCikisIstasyonAdiTxt.Enabled = false;
                depoCikisForm.DepoCikisIstasyonNoTextBox.Enabled = false;
                depoCikisForm.DepoCikisIstasyonbayiNoTextBox.Enabled = false;
                depoCikisForm.DepoCikisComboBox.Enabled = false;
                depoCikisForm.CikisseriNoTextBox.Enabled = false;
                depoCikisForm.DepoCikistarihDateTimePicker.Enabled = false;
                depoCikisForm.DepoCikisaciklamaTextBox.Enabled = false;

                depoCikisForm.DepoCikisnumericUpDown1.Value = Convert.ToInt32(depoCikisDataGridView.Rows[e.RowIndex].Cells[3].Value);
                depoCikisForm.DepoCikistarihDateTimePicker.Value = Convert.ToDateTime(depoCikisDataGridView.Rows[e.RowIndex].Cells[4].Value);
                depoCikisForm.DepoCikisaciklamaTextBox.Text = depoCikisDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                depoCikisForm.ShowDialog();
                try
                {
                    this.depoCikisTableAdapter.Fill(this.masterDataSet.DepoCikis);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }

            else if (colName == "Sil")
            {
                YesRNo formyesorno = new YesRNo();
                formyesorno.ActionString = "Silmek istediğinize emin misiniz?";
                formyesorno.ShowDialog();

                sqlconnect.Close();
                sqlconnect.Open();

                DepoCikis_Adet = Convert.ToInt32(depoCikisDataGridView.Rows[e.RowIndex].Cells[3].Value);

                string DepoCikis_Depo_Id = depoCikisDataGridView.CurrentRow.Cells["Depo_Id"].Value.ToString();
                string DepoCikis_Istasyon_Id = depoCikisDataGridView.CurrentRow.Cells["Depo_Id"].Value.ToString();


                SqlCommand depoadetcommand = new SqlCommand("select Adet from Depo where Depo_Id=@Depo_Id", sqlconnect);
                depoadetcommand.Parameters.AddWithValue("@Depo_Id", DepoCikis_Depo_Id);
                using (SqlDataReader reader = depoadetcommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DepoAdet = Convert.ToInt32(reader["Adet"]);
                    }
                }
                sqlconnect.Close();
                MessageBox.Show("formyesorno.TrueFalse" + formyesorno.TrueFalse);
                if (formyesorno.TrueFalse == true)
                {
                    sqlconnect.Open();

                    //depo çıkış id ye göre silme olması lazım normalde
                    SqlCommand command = new SqlCommand(" DELETE FROM DepoCikis WHERE DepoCikis_Id = @DepoCikis_Id;", sqlconnect);
                    command.Parameters.AddWithValue("@DepoCikis_Id", depoCikisDataGridView.CurrentRow.Cells["DepoCikis_Id"].Value.ToString());

                    int isok = command.ExecuteNonQuery();

                    if (isok == 1)
                    {

                        SqlCommand comand = new SqlCommand("Update Depo Set  Adet=@Adet where Depo_Id=@DepoCikis_Depo_Id ", sqlconnect);
                        comand.Parameters.AddWithValue("@Adet", DepoAdet + DepoCikis_Adet);
                        comand.Parameters.AddWithValue("@DepoCikis_Depo_Id", DepoCikis_Depo_Id);
                        comand.ExecuteNonQuery();




                        MessageBox.Show("Silme işlemi Gerçekleşti...");
                        try
                        {
                            this.depoCikisTableAdapter.Fill(this.masterDataSet.DepoCikis);
                        }
                        catch (System.Exception ex)
                        {
                            System.Windows.Forms.MessageBox.Show(ex.Message);
                        }
                        toolStripComboBox1.Items.Clear();
                        sqlconnect.Close();

                        sqlconnect.Open();
                        SqlCommand comand2 = new SqlCommand("Select Urunler.Urun_Adi from Urunler,Depo where Urunler.Urun_Id=Depo.Urun_Id", sqlconnect);
                        using (SqlDataReader reader = comand2.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                toolStripComboBox1.Items.Add(String.Format("{0}", reader["Urun_Adi"]));
                            }
                        }
                        comand2.ExecuteNonQuery();
                        sqlconnect.Close();
                    }
                    else
                    {
                        MessageBox.Show("Silme işlemi başarısız...");
                    }
                }
                else
                {
                    MessageBox.Show("iptaledildi");
                }
                sqlconnect.Close();
            }
        }

        private void toolStripComboBox1_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook xlworkbook = new XLWorkbook())
                        {
                            if (Isfiltered)
                            {
                                xlworkbook.Worksheets.Add(this.table, "DepoCikis");
                                xlworkbook.SaveAs(sfd.FileName);
                                Isfiltered = false;

                            }
                            else
                            {
                                xlworkbook.Worksheets.Add(this.masterDataSet.DepoCikis, "DepoCikis");
                                xlworkbook.SaveAs(sfd.FileName);
                            }
                        }
                        MessageBox.Show("Excele aktarma başarılı!!");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("hata" + ex);
                    }
                }
            }
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable table1 = new DataTable();
            sqlconnect.Open();

            SqlDataAdapter adtr = new SqlDataAdapter(" SELECT Istasyon_Adi,Urunler.Urun_Adi, Depo.Seri_No, DepoCikis.Adet, DepoCikis.Tarih, DepoCikis.Aciklama, DepoCikis.DepoCikis_Id FROM Depo,Urunler,DepoCikis,Istasyonlar where Urunler.Urun_Id = Depo.Urun_Id and Depo.Depo_Id = DepoCikis.Depo_Id and Istasyonlar.Istasyon_Id = DepoCikis.Istasyon_Id AND Urun_Adi ='" + toolStripComboBox1.SelectedItem.ToString() + "'", sqlconnect);
            adtr.Fill(table1);
            depoCikisDataGridView.DataSource = table1;
            sqlconnect.Close();
            table = table1;
            Isfiltered = true;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            toolStripTextBox1.Clear();
            Isfiltered = false;
            depoCikisDataGridView.DataSource = this.masterDataSet.DepoCikis;
            toolStripComboBox1.Text = "";
        }
    }
}
