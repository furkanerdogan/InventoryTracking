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
    public partial class Istasyon : Form
    {
        public Istasyon()
        {
            InitializeComponent();
        }
        SqlConnection sqlconnect = new SqlConnection(@"Data Source=FURKANERDOĞAN\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
        DataTable table = new DataTable();
        private void istasyonlarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.istasyonlarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masterDataSet);

        }
        private void Istasyon_Load(object sender, EventArgs e)
        {
          
            this.table = masterDataSet.Istasyonlar;

            // TODO: Bu kod satırı 'masterDataSet.Istasyonlar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.istasyonlarTableAdapter.Fill(this.masterDataSet.Istasyonlar);

        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {

            StationsForm istasyonlarForm = new StationsForm();
            istasyonlarForm.IstasyonFormAdd.Enabled = true;
            istasyonlarForm.IstasyonFormUpdate.Enabled = false;

            istasyonlarForm.ShowDialog();
            try
            {
                this.istasyonlarTableAdapter.Fill(this.masterDataSet.Istasyonlar);
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
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT Istasyon_Adi,Istasyon_No,Istasyon_Bayi_No FROM Istasyonlar where  Istasyon_Adi like'%" + toolStripTextBox1.Text + "%' OR Istasyon_No like '%"+ toolStripTextBox1.Text+"%' OR Istasyon_Bayi_No like '%" + toolStripTextBox1.Text + "%'", sqlconnect);
            adtr.Fill(table1);
            table = table1;
            istasyonlarDataGridView.DataSource = table1;
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
                                xlworkbook.Worksheets.Add(this.table, "Istasyon");
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

        
        private void istasyonlarDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = istasyonlarDataGridView.Columns[e.ColumnIndex].Name;

            if (colName == "Düzenle")
            {
                StationsForm istasyonlarform = new StationsForm();
                istasyonlarform.IstasyonFormUpdate.Enabled = true;
                istasyonlarform.IstasyonFormAdd.Enabled = false;

                istasyonlarform.IstasyonAdiTxt.Text = istasyonlarDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                istasyonlarform.IstasyonNoTextBox.Text = istasyonlarDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                istasyonlarform.IstasyonbayiNoTextBox.Text = istasyonlarDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();

                istasyonlarform.getIStasyon_Id = istasyonlarDataGridView.CurrentRow.Cells["Istasyon_Id"].Value.ToString();
                istasyonlarform.ShowDialog();
                try
                {
                    this.istasyonlarTableAdapter.Fill(this.masterDataSet.Istasyonlar);
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
                    SqlCommand command = new SqlCommand(" DELETE FROM Istasyonlar WHERE Istasyon_Id = @Istasyon_Id;", sqlconnect);
                    command.Parameters.AddWithValue("@Istasyon_Id", istasyonlarDataGridView.CurrentRow.Cells["Istasyon_Id"].Value.ToString());
                    int isok = command.ExecuteNonQuery();
                    if (isok == 1)
                    {
                        MessageBox.Show("Silme işlemi Gerçekleşti...");
                        try
                        {
                            this.istasyonlarTableAdapter.Fill(this.masterDataSet.Istasyonlar);
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
        }
    }
}
