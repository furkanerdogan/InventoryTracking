
namespace StokTakip
{
    partial class ProductsSent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsSent));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.depoCikisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet = new StokTakip.masterDataSet();
            this.depoCikisBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.depoCikisTableAdapter = new StokTakip.masterDataSetTableAdapters.DepoCikisTableAdapter();
            this.tableAdapterManager = new StokTakip.masterDataSetTableAdapters.TableAdapterManager();
            this.depoCikisDataGridView = new System.Windows.Forms.DataGridView();
            this.Istasyon_Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Urun_Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seri_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Istasyon_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Depo_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepoCikis_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Düzenle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.depoCikisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoCikisBindingNavigator)).BeginInit();
            this.depoCikisBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depoCikisDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // depoCikisBindingSource
            // 
            this.depoCikisBindingSource.DataMember = "DepoCikis";
            this.depoCikisBindingSource.DataSource = this.masterDataSet;
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // depoCikisBindingNavigator
            // 
            this.depoCikisBindingNavigator.AddNewItem = null;
            this.depoCikisBindingNavigator.BackColor = System.Drawing.Color.LightGray;
            this.depoCikisBindingNavigator.BindingSource = this.depoCikisBindingSource;
            this.depoCikisBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.depoCikisBindingNavigator.DeleteItem = null;
            this.depoCikisBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.depoCikisBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.toolStripTextBox1,
            this.toolStripSeparator3,
            this.toolStripLabel2,
            this.toolStripComboBox1,
            this.toolStripButton5,
            this.toolStripButton6});
            this.depoCikisBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.depoCikisBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.depoCikisBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.depoCikisBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.depoCikisBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.depoCikisBindingNavigator.Name = "depoCikisBindingNavigator";
            this.depoCikisBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 5, 0, 10);
            this.depoCikisBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.depoCikisBindingNavigator.Size = new System.Drawing.Size(1241, 43);
            this.depoCikisBindingNavigator.TabIndex = 24;
            this.depoCikisBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 25);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Toplam öğe sayısı";
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 25);
            this.bindingNavigatorMoveFirstItem.Text = "Başa taşı";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 25);
            this.bindingNavigatorMovePreviousItem.Text = "Öne taşı";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 28);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Konum";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Geçerli konum";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 25);
            this.bindingNavigatorMoveNextItem.Text = "Arkaya taşı";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 25);
            this.bindingNavigatorMoveLastItem.Text = "Sona taşı";
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
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
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
            this.toolStripTextBox1.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
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
            this.toolStripComboBox1.TextChanged += new System.EventHandler(this.toolStripComboBox1_TextChanged);
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
            // depoCikisTableAdapter
            // 
            this.depoCikisTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.IstasyonlarTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = StokTakip.masterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UrunlerTableAdapter = null;
            // 
            // depoCikisDataGridView
            // 
            this.depoCikisDataGridView.AllowUserToAddRows = false;
            this.depoCikisDataGridView.AllowUserToDeleteRows = false;
            this.depoCikisDataGridView.AutoGenerateColumns = false;
            this.depoCikisDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.depoCikisDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.depoCikisDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.depoCikisDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Istasyon_Adi,
            this.Urun_Adi,
            this.Seri_No,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.Istasyon_Id,
            this.Depo_Id,
            this.DepoCikis_Id,
            this.Düzenle,
            this.Sil});
            this.depoCikisDataGridView.DataSource = this.depoCikisBindingSource;
            this.depoCikisDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.depoCikisDataGridView.Location = new System.Drawing.Point(0, 43);
            this.depoCikisDataGridView.Name = "depoCikisDataGridView";
            this.depoCikisDataGridView.ReadOnly = true;
            this.depoCikisDataGridView.RowHeadersWidth = 51;
            this.depoCikisDataGridView.RowTemplate.Height = 24;
            this.depoCikisDataGridView.Size = new System.Drawing.Size(1241, 494);
            this.depoCikisDataGridView.TabIndex = 24;
            this.depoCikisDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.depoCikisDataGridView_CellClick);
            this.depoCikisDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.depoCikisDataGridView_CellContentClick_1);
            // 
            // Istasyon_Adi
            // 
            this.Istasyon_Adi.DataPropertyName = "Istasyon_Adi";
            this.Istasyon_Adi.HeaderText = "Istasyon Adı";
            this.Istasyon_Adi.MinimumWidth = 6;
            this.Istasyon_Adi.Name = "Istasyon_Adi";
            this.Istasyon_Adi.ReadOnly = true;
            // 
            // Urun_Adi
            // 
            this.Urun_Adi.DataPropertyName = "Urun_Adi";
            this.Urun_Adi.HeaderText = "Urun Adı";
            this.Urun_Adi.MinimumWidth = 6;
            this.Urun_Adi.Name = "Urun_Adi";
            this.Urun_Adi.ReadOnly = true;
            // 
            // Seri_No
            // 
            this.Seri_No.DataPropertyName = "Seri_No";
            this.Seri_No.HeaderText = "Seri_No";
            this.Seri_No.MinimumWidth = 6;
            this.Seri_No.Name = "Seri_No";
            this.Seri_No.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Adet";
            this.dataGridViewTextBoxColumn11.HeaderText = "Adet";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Tarih";
            this.dataGridViewTextBoxColumn9.HeaderText = "Gönderiliş Tarihi";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Aciklama";
            this.dataGridViewTextBoxColumn10.HeaderText = "Aciklama";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // Istasyon_Id
            // 
            this.Istasyon_Id.DataPropertyName = "Istasyon_Id";
            this.Istasyon_Id.HeaderText = "Istasyon_Id";
            this.Istasyon_Id.MinimumWidth = 6;
            this.Istasyon_Id.Name = "Istasyon_Id";
            this.Istasyon_Id.ReadOnly = true;
            this.Istasyon_Id.Visible = false;
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
            // DepoCikis_Id
            // 
            this.DepoCikis_Id.DataPropertyName = "DepoCikis_Id";
            this.DepoCikis_Id.HeaderText = "DepoCikis_Id";
            this.DepoCikis_Id.MinimumWidth = 6;
            this.DepoCikis_Id.Name = "DepoCikis_Id";
            this.DepoCikis_Id.ReadOnly = true;
            this.DepoCikis_Id.Visible = false;
            // 
            // Düzenle
            // 
            this.Düzenle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.NullValue = "Düzenle";
            this.Düzenle.DefaultCellStyle = dataGridViewCellStyle5;
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
            dataGridViewCellStyle6.NullValue = "Sil";
            this.Sil.DefaultCellStyle = dataGridViewCellStyle6;
            this.Sil.HeaderText = "";
            this.Sil.MinimumWidth = 6;
            this.Sil.Name = "Sil";
            this.Sil.ReadOnly = true;
            this.Sil.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Sil.Width = 6;
            // 
            // DepoCikis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 537);
            this.Controls.Add(this.depoCikisDataGridView);
            this.Controls.Add(this.depoCikisBindingNavigator);
            this.Name = "DepoCikis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DEPO ÜRÜN ÇIKIŞ";
            this.Load += new System.EventHandler(this.DepoCikis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.depoCikisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoCikisBindingNavigator)).EndInit();
            this.depoCikisBindingNavigator.ResumeLayout(false);
            this.depoCikisBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depoCikisDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource depoCikisBindingSource;
        private masterDataSetTableAdapters.DepoCikisTableAdapter depoCikisTableAdapter;
        private masterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator depoCikisBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridView depoCikisDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Istasyon_Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Urun_Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seri_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Düzenle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Istasyon_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Depo_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepoCikis_Id;
    }
}