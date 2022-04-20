
namespace StokTakip
{
    partial class Products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.urunlerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.urunlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet = new StokTakip.masterDataSet();
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
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.urunlerTableAdapter = new StokTakip.masterDataSetTableAdapters.UrunlerTableAdapter();
            this.tableAdapterManager = new StokTakip.masterDataSetTableAdapters.TableAdapterManager();
            this.Urun_Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Urun_Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunlerDataGridView = new System.Windows.Forms.DataGridView();
            this.Urun_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Düzenle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingNavigator)).BeginInit();
            this.urunlerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // urunlerBindingNavigator
            // 
            this.urunlerBindingNavigator.AddNewItem = null;
            this.urunlerBindingNavigator.BackColor = System.Drawing.Color.Gainsboro;
            this.urunlerBindingNavigator.BindingSource = this.urunlerBindingSource;
            this.urunlerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.urunlerBindingNavigator.DeleteItem = null;
            this.urunlerBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.urunlerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.toolStripButton4,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.toolStripTextBox1,
            this.toolStripButton5});
            this.urunlerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.urunlerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.urunlerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.urunlerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.urunlerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.urunlerBindingNavigator.Name = "urunlerBindingNavigator";
            this.urunlerBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 5, 0, 10);
            this.urunlerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.urunlerBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.urunlerBindingNavigator.Size = new System.Drawing.Size(1211, 42);
            this.urunlerBindingNavigator.TabIndex = 19;
            this.urunlerBindingNavigator.Text = "bindingNavigator1";
            // 
            // urunlerBindingSource
            // 
            this.urunlerBindingSource.DataMember = "Urunler";
            this.urunlerBindingSource.DataSource = this.masterDataSet;
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
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::StokTakip.Properties.Resources.rotate_left;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(72, 24);
            this.toolStripButton1.Text = "Yenile";
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
            this.bindingNavigatorMoveNextItem.Enabled = false;
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
            // toolStripButton4
            // 
            this.toolStripButton4.Image = global::StokTakip.Properties.Resources.add;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(60, 24);
            this.toolStripButton4.Text = "Ekle";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
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
            // urunlerTableAdapter
            // 
            this.urunlerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.IstasyonlarTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = StokTakip.masterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UrunlerTableAdapter = this.urunlerTableAdapter;
            // 
            // Urun_Adi
            // 
            this.Urun_Adi.DataPropertyName = "Urun_Adi";
            this.Urun_Adi.HeaderText = "Urun_Adi";
            this.Urun_Adi.MinimumWidth = 6;
            this.Urun_Adi.Name = "Urun_Adi";
            this.Urun_Adi.Width = 182;
            // 
            // Urun_Model
            // 
            this.Urun_Model.DataPropertyName = "Urun_Model";
            this.Urun_Model.HeaderText = "Urun_Model";
            this.Urun_Model.MinimumWidth = 6;
            this.Urun_Model.Name = "Urun_Model";
            this.Urun_Model.Width = 182;
            // 
            // urunlerDataGridView
            // 
            this.urunlerDataGridView.AllowUserToAddRows = false;
            this.urunlerDataGridView.AllowUserToDeleteRows = false;
            this.urunlerDataGridView.AutoGenerateColumns = false;
            this.urunlerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.urunlerDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.urunlerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.urunlerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Urun_Id,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Düzenle,
            this.Sil});
            this.urunlerDataGridView.DataSource = this.urunlerBindingSource;
            this.urunlerDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.urunlerDataGridView.Location = new System.Drawing.Point(0, 42);
            this.urunlerDataGridView.Name = "urunlerDataGridView";
            this.urunlerDataGridView.ReadOnly = true;
            this.urunlerDataGridView.RowHeadersWidth = 51;
            this.urunlerDataGridView.RowTemplate.Height = 24;
            this.urunlerDataGridView.Size = new System.Drawing.Size(1211, 468);
            this.urunlerDataGridView.TabIndex = 19;
            this.urunlerDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.urunlerDataGridView_CellClick);
            // 
            // Urun_Id
            // 
            this.Urun_Id.DataPropertyName = "Urun_Id";
            this.Urun_Id.HeaderText = "Urun_Id";
            this.Urun_Id.MinimumWidth = 6;
            this.Urun_Id.Name = "Urun_Id";
            this.Urun_Id.ReadOnly = true;
            this.Urun_Id.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Urun_Adi";
            this.dataGridViewTextBoxColumn2.HeaderText = "Urun_Adi";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Urun_Marka";
            this.dataGridViewTextBoxColumn3.HeaderText = "Urun_Marka";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Urun_Fiyat";
            this.dataGridViewTextBoxColumn4.HeaderText = "Urun_Fiyat";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Aciklama";
            this.dataGridViewTextBoxColumn5.HeaderText = "Aciklama";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
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
            // Urun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 510);
            this.Controls.Add(this.urunlerDataGridView);
            this.Controls.Add(this.urunlerBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Urun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÜRÜNLER";
            this.Load += new System.EventHandler(this.Urun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingNavigator)).EndInit();
            this.urunlerBindingNavigator.ResumeLayout(false);
            this.urunlerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private masterDataSetTableAdapters.UrunlerTableAdapter urunlerTableAdapter;
        private masterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator urunlerBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Urun_Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Urun_Model;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource urunlerBindingSource;
        private System.Windows.Forms.DataGridView urunlerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Urun_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Düzenle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sil;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
    }
}