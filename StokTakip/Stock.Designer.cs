
namespace StokTakip
{
    partial class Stock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.depoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.depoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet1 = new StokTakip.masterDataSet();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.depoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Depo_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Düzenle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depoTableAdapter = new StokTakip.masterDataSetTableAdapters.DepoTableAdapter();
            this.tableAdapterManager1 = new StokTakip.masterDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.depoBindingNavigator)).BeginInit();
            this.depoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::StokTakip.Properties.Resources.rotate_left;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(72, 25);
            this.toolStripButton1.Text = "Yenile";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 28);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::StokTakip.Properties.Resources.add;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(60, 25);
            this.toolStripButton2.Text = "Ekle";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(32, 25);
            this.toolStripLabel1.Text = "Ara";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 28);
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripButton6_Click);
            this.toolStripTextBox1.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton5.BackColor = System.Drawing.Color.ForestGreen;
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(95, 25);
            this.toolStripButton5.Text = "Excel\'e aktar";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(54, 25);
            this.toolStripLabel2.Text = "Filtrele";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 28);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(112, 25);
            this.toolStripButton6.Text = "Filtreyi Temizle";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // depoBindingNavigator
            // 
            this.depoBindingNavigator.AddNewItem = null;
            this.depoBindingNavigator.BackColor = System.Drawing.Color.LightGray;
            this.depoBindingNavigator.BindingSource = this.depoBindingSource;
            this.depoBindingNavigator.CountItem = this.toolStripLabel3;
            this.depoBindingNavigator.DeleteItem = null;
            this.depoBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.depoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator4,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator5,
            this.toolStripTextBox2,
            this.toolStripLabel3,
            this.toolStripSeparator6,
            this.toolStripButton7,
            this.toolStripButton8,
            this.bindingNavigatorSeparator2,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.toolStripTextBox1,
            this.toolStripSeparator1,
            this.toolStripButton5,
            this.toolStripLabel2,
            this.toolStripComboBox1,
            this.toolStripSeparator3,
            this.toolStripButton6});
            this.depoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.depoBindingNavigator.MoveFirstItem = this.toolStripButton3;
            this.depoBindingNavigator.MoveLastItem = this.toolStripButton8;
            this.depoBindingNavigator.MoveNextItem = this.toolStripButton7;
            this.depoBindingNavigator.MovePreviousItem = this.toolStripButton4;
            this.depoBindingNavigator.Name = "depoBindingNavigator";
            this.depoBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 5, 0, 10);
            this.depoBindingNavigator.PositionItem = this.toolStripTextBox2;
            this.depoBindingNavigator.Size = new System.Drawing.Size(1033, 43);
            this.depoBindingNavigator.TabIndex = 5;
            this.depoBindingNavigator.Text = "bindingNavigator1";
            // 
            // depoBindingSource
            // 
            this.depoBindingSource.DataMember = "Depo";
            this.depoBindingSource.DataSource = this.masterDataSet1;
            // 
            // masterDataSet1
            // 
            this.masterDataSet1.DataSetName = "masterDataSet";
            this.masterDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(37, 25);
            this.toolStripLabel3.Text = "/ {0}";
            this.toolStripLabel3.ToolTipText = "Toplam öğe sayısı";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(29, 25);
            this.toolStripButton3.Text = "Başa taşı";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(29, 25);
            this.toolStripButton4.Text = "Öne taşı";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.AccessibleName = "Konum";
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(50, 27);
            this.toolStripTextBox2.Text = "0";
            this.toolStripTextBox2.ToolTipText = "Geçerli konum";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.RightToLeftAutoMirrorImage = true;
            this.toolStripButton7.Size = new System.Drawing.Size(29, 25);
            this.toolStripButton7.Text = "Arkaya taşı";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.RightToLeftAutoMirrorImage = true;
            this.toolStripButton8.Size = new System.Drawing.Size(29, 25);
            this.toolStripButton8.Text = "Sona taşı";
            // 
            // depoDataGridView
            // 
            this.depoDataGridView.AllowUserToAddRows = false;
            this.depoDataGridView.AllowUserToDeleteRows = false;
            this.depoDataGridView.AutoGenerateColumns = false;
            this.depoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.depoDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.depoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.depoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.Depo_Id,
            this.dataGridViewTextBoxColumn10,
            this.Düzenle,
            this.Sil});
            this.depoDataGridView.DataSource = this.depoBindingSource;
            this.depoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.depoDataGridView.Location = new System.Drawing.Point(0, 43);
            this.depoDataGridView.Name = "depoDataGridView";
            this.depoDataGridView.ReadOnly = true;
            this.depoDataGridView.RowHeadersWidth = 51;
            this.depoDataGridView.RowTemplate.Height = 24;
            this.depoDataGridView.Size = new System.Drawing.Size(1033, 478);
            this.depoDataGridView.TabIndex = 5;
            this.depoDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.depoDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Urun_Adi";
            this.dataGridViewTextBoxColumn15.HeaderText = "Urun_Adi";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Seri_No";
            this.dataGridViewTextBoxColumn11.HeaderText = "Seri_No";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Adet";
            this.dataGridViewTextBoxColumn12.HeaderText = "Adet";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Tarih";
            this.dataGridViewTextBoxColumn13.HeaderText = "Tarih";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Aciklama";
            this.dataGridViewTextBoxColumn14.HeaderText = "Aciklama";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // Depo_Id
            // 
            this.Depo_Id.DataPropertyName = "Depo_Id";
            this.Depo_Id.HeaderText = "Depo_Id";
            this.Depo_Id.MinimumWidth = 6;
            this.Depo_Id.Name = "Depo_Id";
            this.Depo_Id.ReadOnly = true;
            this.Depo_Id.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Urun_Id";
            this.dataGridViewTextBoxColumn10.HeaderText = "Urun_Id";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // Düzenle
            // 
            this.Düzenle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.NullValue = "Düzenle";
            this.Düzenle.DefaultCellStyle = dataGridViewCellStyle1;
            this.Düzenle.HeaderText = "";
            this.Düzenle.MinimumWidth = 6;
            this.Düzenle.Name = "Düzenle";
            this.Düzenle.ReadOnly = true;
            this.Düzenle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Düzenle.Width = 6;
            // 
            // Sil
            // 
            this.Sil.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.NullValue = "Sil";
            this.Sil.DefaultCellStyle = dataGridViewCellStyle2;
            this.Sil.HeaderText = "";
            this.Sil.MinimumWidth = 6;
            this.Sil.Name = "Sil";
            this.Sil.ReadOnly = true;
            this.Sil.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Sil.Width = 6;
            // 
            // depoTableAdapter
            // 
            this.depoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.IstasyonlarTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = StokTakip.masterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.UrunlerTableAdapter = null;
            // 
            // Depo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 521);
            this.Controls.Add(this.depoDataGridView);
            this.Controls.Add(this.depoBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Depo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DEPO ÜRÜN GİRİŞ";
            this.Load += new System.EventHandler(this.Depo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.depoBindingNavigator)).EndInit();
            this.depoBindingNavigator.ResumeLayout(false);
            this.depoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private masterDataSet masterDataSet;
        private masterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn Urun_Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeriNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn depoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seriNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gonderildiDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.BindingNavigator depoBindingNavigator;
        private masterDataSet masterDataSet1;
        private System.Windows.Forms.BindingSource depoBindingSource;
        private masterDataSetTableAdapters.DepoTableAdapter depoTableAdapter;
        private masterDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView depoDataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        public System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Düzenle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Depo_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
    }
}