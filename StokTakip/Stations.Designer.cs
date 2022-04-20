
namespace StokTakip
{
    partial class Istasyon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Istasyon));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.istasyonlarBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.istasyonlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet = new StokTakip.masterDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.istasyonlarDataGridView = new System.Windows.Forms.DataGridView();
            this.Istasyon_Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Istasyon_NoName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Istasyon_Bayi_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Düzenle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Istasyon_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.istasyonlarTableAdapter = new StokTakip.masterDataSetTableAdapters.IstasyonlarTableAdapter();
            this.tableAdapterManager = new StokTakip.masterDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.istasyonlarBindingNavigator)).BeginInit();
            this.istasyonlarBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.istasyonlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.istasyonlarDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // istasyonlarBindingNavigator
            // 
            this.istasyonlarBindingNavigator.AddNewItem = null;
            this.istasyonlarBindingNavigator.BackColor = System.Drawing.Color.LightGray;
            this.istasyonlarBindingNavigator.BindingSource = this.istasyonlarBindingSource;
            this.istasyonlarBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.istasyonlarBindingNavigator.DeleteItem = null;
            this.istasyonlarBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.istasyonlarBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton4,
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
            this.toolStripButton3,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.toolStripTextBox1,
            this.toolStripButton5});
            this.istasyonlarBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.istasyonlarBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.istasyonlarBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.istasyonlarBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.istasyonlarBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.istasyonlarBindingNavigator.Name = "istasyonlarBindingNavigator";
            this.istasyonlarBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 5, 0, 10);
            this.istasyonlarBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.istasyonlarBindingNavigator.Size = new System.Drawing.Size(888, 42);
            this.istasyonlarBindingNavigator.TabIndex = 1;
            this.istasyonlarBindingNavigator.Text = "bindingNavigator1";
            // 
            // istasyonlarBindingSource
            // 
            this.istasyonlarBindingSource.DataMember = "Istasyonlar";
            this.istasyonlarBindingSource.DataSource = this.masterDataSet;
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 24);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Toplam öğe sayısı";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = global::StokTakip.Properties.Resources.rotate_left;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(64, 24);
            this.toolStripButton4.Text = "Yenil";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Başa taşı";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Öne taşı";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Arkaya taşı";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Sona taşı";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::StokTakip.Properties.Resources.add;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(60, 24);
            this.toolStripButton3.Text = "Ekle";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(32, 24);
            this.toolStripLabel1.Text = "Ara";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBox1.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton5.BackColor = System.Drawing.Color.ForestGreen;
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(95, 24);
            this.toolStripButton5.Text = "Excel\'e aktar";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // istasyonlarDataGridView
            // 
            this.istasyonlarDataGridView.AllowUserToAddRows = false;
            this.istasyonlarDataGridView.AllowUserToDeleteRows = false;
            this.istasyonlarDataGridView.AutoGenerateColumns = false;
            this.istasyonlarDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.istasyonlarDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.istasyonlarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.istasyonlarDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Istasyon_Adi,
            this.Istasyon_NoName,
            this.Istasyon_Bayi_No,
            this.Düzenle,
            this.Sil,
            this.Istasyon_Id});
            this.istasyonlarDataGridView.DataSource = this.istasyonlarBindingSource;
            this.istasyonlarDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.istasyonlarDataGridView.Location = new System.Drawing.Point(0, 42);
            this.istasyonlarDataGridView.Name = "istasyonlarDataGridView";
            this.istasyonlarDataGridView.ReadOnly = true;
            this.istasyonlarDataGridView.RowHeadersWidth = 51;
            this.istasyonlarDataGridView.RowTemplate.Height = 24;
            this.istasyonlarDataGridView.Size = new System.Drawing.Size(888, 464);
            this.istasyonlarDataGridView.TabIndex = 2;
            this.istasyonlarDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.istasyonlarDataGridView_CellClick);
            // 
            // Istasyon_Adi
            // 
            this.Istasyon_Adi.DataPropertyName = "Istasyon_Adi";
            this.Istasyon_Adi.HeaderText = "Istasyon_Adi";
            this.Istasyon_Adi.MinimumWidth = 6;
            this.Istasyon_Adi.Name = "Istasyon_Adi";
            this.Istasyon_Adi.ReadOnly = true;
            // 
            // Istasyon_NoName
            // 
            this.Istasyon_NoName.DataPropertyName = "Istasyon_No";
            this.Istasyon_NoName.HeaderText = "Istasyon_No";
            this.Istasyon_NoName.MinimumWidth = 6;
            this.Istasyon_NoName.Name = "Istasyon_NoName";
            this.Istasyon_NoName.ReadOnly = true;
            // 
            // Istasyon_Bayi_No
            // 
            this.Istasyon_Bayi_No.DataPropertyName = "Istasyon_Bayi_No";
            this.Istasyon_Bayi_No.HeaderText = "Istasyon_Bayi_No";
            this.Istasyon_Bayi_No.MinimumWidth = 6;
            this.Istasyon_Bayi_No.Name = "Istasyon_Bayi_No";
            this.Istasyon_Bayi_No.ReadOnly = true;
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
            // Istasyon_Id
            // 
            this.Istasyon_Id.DataPropertyName = "Istasyon_Id";
            this.Istasyon_Id.HeaderText = "Istasyon_Id";
            this.Istasyon_Id.MinimumWidth = 6;
            this.Istasyon_Id.Name = "Istasyon_Id";
            this.Istasyon_Id.ReadOnly = true;
            this.Istasyon_Id.Visible = false;
            // 
            // istasyonlarTableAdapter
            // 
            this.istasyonlarTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.IstasyonlarTableAdapter = this.istasyonlarTableAdapter;
            this.tableAdapterManager.UpdateOrder = StokTakip.masterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UrunlerTableAdapter = null;
            // 
            // Istasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 506);
            this.Controls.Add(this.istasyonlarDataGridView);
            this.Controls.Add(this.istasyonlarBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Istasyon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İSTASYONLAR";
            this.Load += new System.EventHandler(this.Istasyon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.istasyonlarBindingNavigator)).EndInit();
            this.istasyonlarBindingNavigator.ResumeLayout(false);
            this.istasyonlarBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.istasyonlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.istasyonlarDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource istasyonlarBindingSource;
        private masterDataSetTableAdapters.IstasyonlarTableAdapter istasyonlarTableAdapter;
        private masterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator istasyonlarBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.DataGridView istasyonlarDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Istasyon_Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Istasyon_NoName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Istasyon_Bayi_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Düzenle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Istasyon_Id;
    }
}