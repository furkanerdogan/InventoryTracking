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
using System.Threading;

namespace StokTakip
{
    public partial class Stock : Form
    {
        

        public Stock()
        {
            InitializeComponent();

        }


        SqlConnection connectsql = new SqlConnection(@"Data Source=FURKANERDOĞAN\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
        DataTable table = new DataTable();
        Boolean Isfiltered = true;
   
        private void Depo_Load(object sender, EventArgs e)
        {
            this.depoTableAdapter.Fill(this.masterDataSet1.Depo);

            // TODO: Bu kod satırı 'masterDataSet.DepoCikis' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.table = masterDataSet1.Depo;
            try
            {

                connectsql.Open();

                SqlCommand comand2 = new SqlCommand("Select Urunler.Urun_Adi from Urunler,Depo where Urunler.Urun_Id=Depo.Urun_Id and Depo.Adet>0  GROUP BY  Urunler.Urun_Adi", connectsql);
                using (SqlDataReader reader = comand2.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        toolStripComboBox1.Items.Add(String.Format("{0}", reader["Urun_Adi"]));
                    }
                }
                comand2.ExecuteNonQuery();


                connectsql.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata" + ex);
            }

           

        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            Isfiltered = true;
            DataTable table1= new DataTable();
            connectsql.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT Urunler.Urun_Adi,Depo.Seri_No, Depo.Adet,Depo.Tarih, Depo.Aciklama FROM dbo.Depo,dbo.Urunler where Depo.Urun_Id=Urunler.Urun_Id AND Depo.Adet>0 AND Seri_No like'%" + toolStripTextBox1.Text + "%'", connectsql);
            adtr.Fill(table1);
            table = table1;
            depoDataGridView.DataSource = table;
            connectsql.Close();
         

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
                            if(Isfiltered)
                            { 
                            xlworkbook.Worksheets.Add(this.table, "Depo");
                            xlworkbook.SaveAs(sfd.FileName);
                            Isfiltered = false;

                            }
                            else
                            {
                                xlworkbook.Worksheets.Add(this.masterDataSet1.Depo, "Depo");
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
 

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            toolStripTextBox1.Clear();
            Isfiltered = false;
            depoDataGridView.DataSource = this.masterDataSet1.Depo;
            toolStripComboBox1.Text = "";
           
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable table1 = new DataTable();
            connectsql.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT Urunler.Urun_Adi,Depo.Seri_No, Depo.Adet,Depo.Tarih, Depo.Aciklama FROM dbo.Depo,dbo.Urunler where  Depo.Adet >0 and Depo.Urun_Id=Urunler.Urun_Id AND Urun_Adi ='" + toolStripComboBox1.SelectedItem.ToString() + "'", connectsql);
            adtr.Fill(table1);
            depoDataGridView.DataSource = table1;
            connectsql.Close();
            table = table1;
            Isfiltered = true;
        }

      

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {

         
            StockForm depoForm = new StockForm();
            depoForm.DepoFormUpdate.Enabled = false;
            depoForm.DepoFormAdd.Enabled = true;

            depoForm.ShowDialog();
            this.depoTableAdapter.Fill(this.masterDataSet1.Depo);
            

          
            toolStripComboBox1.BeginUpdate();
           


           

        }

       
        
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {

                connectsql.Open();
                toolStripComboBox1.Items.Clear();
                SqlCommand comand2 = new SqlCommand("Select Urunler.Urun_Adi from Urunler,Depo where Urunler.Urun_Id=Depo.Urun_Id and Depo.Adet>0  GROUP BY  Urunler.Urun_Adi", connectsql);
                using (SqlDataReader reader = comand2.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        toolStripComboBox1.Items.Add(String.Format("{0}", reader["Urun_Adi"]));
                    }
                }
                comand2.ExecuteNonQuery();


                connectsql.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata" + ex);
            }
            try
            {

                this.depoTableAdapter.Fill(this.masterDataSet1.Depo);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

    

        private void depoDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = depoDataGridView.Columns[e.ColumnIndex].Name;

            if (colName == "Düzenle")
            {
                StockForm depoForm = new StockForm();
                depoForm.DepoFormAdd.Enabled = false;
                depoForm.DepoFormUpdate.Enabled = true;

                depoForm.DepoComboBox.Text = depoDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                depoForm.Deposeri_NoTextBox.Text = depoDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                depoForm.numericUpDown1.Value = Convert.ToInt32(depoDataGridView.Rows[e.RowIndex].Cells[2].Value);
                depoForm.DepotarihDateTimePicker.Value = Convert.ToDateTime(depoDataGridView.Rows[e.RowIndex].Cells[3].Value);
                depoForm.DepoaciklamaTextBox.Text = depoDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();

                depoForm.getDepo_Id = depoDataGridView.CurrentRow.Cells["Depo_Id"].Value.ToString();
                depoForm.ShowDialog();
                try
                {
                    this.depoTableAdapter.Fill(this.masterDataSet1.Depo);
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

                if (formyesorno.TrueFalse == true)
                {
                    connectsql.Open();
                    SqlCommand command = new SqlCommand(" DELETE FROM Depo WHERE Depo_Id = @Depo_Id;", connectsql);
                    command.Parameters.AddWithValue("@Depo_Id", depoDataGridView.CurrentRow.Cells["Depo_Id"].Value.ToString());
                    int isok = command.ExecuteNonQuery();
                    if (isok == 1)
                    {
                        MessageBox.Show("Silme işlemi Gerçekleşti...");
                        try
                        {
                            this.depoTableAdapter.Fill(this.masterDataSet1.Depo);
                        }
                        catch (System.Exception ex)
                        {
                            System.Windows.Forms.MessageBox.Show(ex.Message);
                        }
                        toolStripComboBox1.Items.Clear();

                        SqlCommand comand2 = new SqlCommand("Select Urunler.Urun_Adi from Urunler,Depo where Urunler.Urun_Id=Depo.Urun_Id group by Urunler.Urun_Adi", connectsql);
                        using (SqlDataReader reader = comand2.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                toolStripComboBox1.Items.Add(String.Format("{0}", reader["Urun_Adi"]));
                            }
                        }
                        comand2.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Silme işlemi başarısız...");
                    }
                    connectsql.Close();
                }
                else
                {
                    MessageBox.Show("iptaledildi");
                }
            }
        }

       
    }
}


