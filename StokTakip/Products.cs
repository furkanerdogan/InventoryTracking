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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }
        SqlConnection sqlconnect = new SqlConnection(@"Data Source=FURKANERDOĞAN\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
        DataTable table = new DataTable();
     

        private void Urun_Load(object sender, EventArgs e)
        {
            
            // TODO: Bu kod satırı 'masterDataSet1.Urunler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.urunlerTableAdapter.Fill(this.masterDataSet.Urunler);

            this.table = masterDataSet.Urunler;   

        }
 
     
       
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            ProductsForm urunlerForm = new ProductsForm();      
            urunlerForm.UrunlerForm_AddBtn.Enabled = true;
            urunlerForm.UrunlerForm_UpdateBtn.Enabled = false;

            urunlerForm.ShowDialog();
            try
            {
                this.urunlerTableAdapter.Fill(this.masterDataSet.Urunler);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

     private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable table1 = new DataTable();
            sqlconnect.Open();

            SqlDataAdapter adtr = new SqlDataAdapter("SELECT Urunler.Urun_Adi, Urunler.Urun_Marka,Urunler.Urun_Fiyat,Urunler.Aciklama FROM dbo.Urunler where  Urun_Adi like'%" + toolStripTextBox1.Text + "%'OR Aciklama like '%" + toolStripTextBox1.Text + "%' ", sqlconnect);
            adtr.Fill(table1);
            table = table1;
            urunlerDataGridView.DataSource = table1;
            sqlconnect.Close();

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
                            xlworkbook.Worksheets.Add(this.table, "Urun");
                            xlworkbook.SaveAs(sfd.FileName);

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

      

        private void urunlerDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = urunlerDataGridView.Columns[e.ColumnIndex].Name;

            if (colName == "Düzenle")
            {
                ProductsForm urunlerForm = new ProductsForm();
                urunlerForm.UrunlerForm_AddBtn.Enabled = false;
                urunlerForm.UrunlerForm_UpdateBtn.Enabled = true;

                urunlerForm.urunAdiTxt.Text = urunlerDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                urunlerForm.urun_ModelTextBox.Text = urunlerDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                urunlerForm.urun_FiyatTextBox.Text = urunlerDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                urunlerForm.UrunaciklamaTextBox.Text = urunlerDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();

                urunlerForm.getUrun_Id = urunlerDataGridView.CurrentRow.Cells["Urun_Id"].Value.ToString();
                urunlerForm.ShowDialog();
                try
                {
                    this.urunlerTableAdapter.Fill(this.masterDataSet.Urunler);
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
                    sqlconnect.Open();
                    SqlCommand command = new SqlCommand(" DELETE FROM Urunler WHERE Urun_Adi = @Urun_Adi", sqlconnect);
                    command.Parameters.AddWithValue("@Urun_Adi", urunlerDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
                    int isok = command.ExecuteNonQuery();
                    if (isok == 1)
                    {
                        MessageBox.Show("Silme işlemi Gerçekleşti...");
                        try
                        {
                            this.urunlerTableAdapter.Fill(this.masterDataSet.Urunler);
                        }
                        catch (System.Exception ex)
                        {
                            System.Windows.Forms.MessageBox.Show(ex.Message);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Silme işlemi başarısız...");
                    }
                    sqlconnect.Close();
                }
                else
                {
                    MessageBox.Show("iptaledildi");
                }
            }

            else
            {
            }
        }
    }

}
