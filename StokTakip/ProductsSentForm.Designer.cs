
namespace StokTakip
{
    partial class ProductsSentForm
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
            System.Windows.Forms.Label aciklamaLabel;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label urun_AdiLabel;
            System.Windows.Forms.Label Istasyon_No;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DepoCikisIstasyonbayiNoTextBox = new System.Windows.Forms.TextBox();
            this.DepoCikisIstasyonNoTextBox = new System.Windows.Forms.TextBox();
            this.DepoCikisIstasyonAdiTxt = new System.Windows.Forms.TextBox();
            this.Cikisbutton3 = new System.Windows.Forms.Button();
            this.DepoCikisFormUpdate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DepoCikisFormAdd = new System.Windows.Forms.Button();
            this.depocikisistasyonara = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gidistarih = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.DepoCikisnumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.DepoCikisComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DepoCikisaciklamaTextBox = new System.Windows.Forms.TextBox();
            this.CikisseriNoTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DepoCikistarihDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Depocikisdepoara = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ıstasyonAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıstasyonNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıstasyonBayiNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Istasyon_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıstasyonlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet = new StokTakip.masterDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Urun_Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seriNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Depo_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.depoTableAdapter = new StokTakip.masterDataSetTableAdapters.DepoTableAdapter();
            this.istasyonlarTableAdapter = new StokTakip.masterDataSetTableAdapters.IstasyonlarTableAdapter();
            aciklamaLabel = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            urun_AdiLabel = new System.Windows.Forms.Label();
            Istasyon_No = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DepoCikisnumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıstasyonlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // aciklamaLabel
            // 
            aciklamaLabel.AutoSize = true;
            aciklamaLabel.Location = new System.Drawing.Point(138, 221);
            aciklamaLabel.Name = "aciklamaLabel";
            aciklamaLabel.Size = new System.Drawing.Size(68, 17);
            aciklamaLabel.TabIndex = 35;
            aciklamaLabel.Text = "Aciklama:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(79, 174);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(121, 17);
            label9.TabIndex = 49;
            label9.Text = "İstasyon Bayi No :";
            // 
            // urun_AdiLabel
            // 
            urun_AdiLabel.AutoSize = true;
            urun_AdiLabel.Location = new System.Drawing.Point(79, 92);
            urun_AdiLabel.Name = "urun_AdiLabel";
            urun_AdiLabel.Size = new System.Drawing.Size(92, 17);
            urun_AdiLabel.TabIndex = 45;
            urun_AdiLabel.Text = "İstasyon Adı :";
            // 
            // Istasyon_No
            // 
            Istasyon_No.AutoSize = true;
            Istasyon_No.Location = new System.Drawing.Point(79, 128);
            Istasyon_No.Name = "Istasyon_No";
            Istasyon_No.Size = new System.Drawing.Size(90, 17);
            Istasyon_No.TabIndex = 46;
            Istasyon_No.Text = "İstasyon No :";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1382, 659);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DepoCikisIstasyonbayiNoTextBox);
            this.groupBox2.Controls.Add(label9);
            this.groupBox2.Controls.Add(this.DepoCikisIstasyonNoTextBox);
            this.groupBox2.Controls.Add(this.DepoCikisIstasyonAdiTxt);
            this.groupBox2.Controls.Add(urun_AdiLabel);
            this.groupBox2.Controls.Add(Istasyon_No);
            this.groupBox2.Controls.Add(this.Cikisbutton3);
            this.groupBox2.Controls.Add(this.DepoCikisFormUpdate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.DepoCikisFormAdd);
            this.groupBox2.Controls.Add(this.depocikisistasyonara);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(832, 332);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(547, 324);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // DepoCikisIstasyonbayiNoTextBox
            // 
            this.DepoCikisIstasyonbayiNoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DepoCikisIstasyonbayiNoTextBox.Location = new System.Drawing.Point(215, 169);
            this.DepoCikisIstasyonbayiNoTextBox.Name = "DepoCikisIstasyonbayiNoTextBox";
            this.DepoCikisIstasyonbayiNoTextBox.Size = new System.Drawing.Size(105, 22);
            this.DepoCikisIstasyonbayiNoTextBox.TabIndex = 50;
            // 
            // DepoCikisIstasyonNoTextBox
            // 
            this.DepoCikisIstasyonNoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DepoCikisIstasyonNoTextBox.Location = new System.Drawing.Point(215, 125);
            this.DepoCikisIstasyonNoTextBox.Name = "DepoCikisIstasyonNoTextBox";
            this.DepoCikisIstasyonNoTextBox.Size = new System.Drawing.Size(105, 22);
            this.DepoCikisIstasyonNoTextBox.TabIndex = 47;
            // 
            // DepoCikisIstasyonAdiTxt
            // 
            this.DepoCikisIstasyonAdiTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DepoCikisIstasyonAdiTxt.Location = new System.Drawing.Point(215, 87);
            this.DepoCikisIstasyonAdiTxt.Name = "DepoCikisIstasyonAdiTxt";
            this.DepoCikisIstasyonAdiTxt.Size = new System.Drawing.Size(105, 22);
            this.DepoCikisIstasyonAdiTxt.TabIndex = 48;
            // 
            // Cikisbutton3
            // 
            this.Cikisbutton3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Cikisbutton3.Location = new System.Drawing.Point(445, 252);
            this.Cikisbutton3.Name = "Cikisbutton3";
            this.Cikisbutton3.Size = new System.Drawing.Size(80, 50);
            this.Cikisbutton3.TabIndex = 44;
            this.Cikisbutton3.Text = "Temizle";
            this.Cikisbutton3.UseVisualStyleBackColor = false;
            // 
            // DepoCikisFormUpdate
            // 
            this.DepoCikisFormUpdate.Location = new System.Drawing.Point(280, 252);
            this.DepoCikisFormUpdate.Name = "DepoCikisFormUpdate";
            this.DepoCikisFormUpdate.Size = new System.Drawing.Size(80, 50);
            this.DepoCikisFormUpdate.TabIndex = 43;
            this.DepoCikisFormUpdate.Text = "Güncelle";
            this.DepoCikisFormUpdate.UseVisualStyleBackColor = true;
            this.DepoCikisFormUpdate.Click += new System.EventHandler(this.DepoCikisFormUpdate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "ISTASYON";
            // 
            // DepoCikisFormAdd
            // 
            this.DepoCikisFormAdd.Location = new System.Drawing.Point(194, 252);
            this.DepoCikisFormAdd.Name = "DepoCikisFormAdd";
            this.DepoCikisFormAdd.Size = new System.Drawing.Size(80, 50);
            this.DepoCikisFormAdd.TabIndex = 42;
            this.DepoCikisFormAdd.Text = "Ekle";
            this.DepoCikisFormAdd.UseVisualStyleBackColor = true;
            this.DepoCikisFormAdd.Click += new System.EventHandler(this.DepoCikisFormAdd_Click);
            // 
            // depocikisistasyonara
            // 
            this.depocikisistasyonara.Location = new System.Drawing.Point(356, 21);
            this.depocikisistasyonara.Name = "depocikisistasyonara";
            this.depocikisistasyonara.Size = new System.Drawing.Size(166, 22);
            this.depocikisistasyonara.TabIndex = 7;
            this.depocikisistasyonara.TextChanged += new System.EventHandler(this.depocikisistasyonara_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ara :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gidistarih);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.DepoCikisnumericUpDown1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.DepoCikisComboBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.DepoCikisaciklamaTextBox);
            this.groupBox1.Controls.Add(this.CikisseriNoTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.DepoCikistarihDateTimePicker);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(aciklamaLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Depocikisdepoara);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 332);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(823, 324);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // gidistarih
            // 
            this.gidistarih.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gidistarih.Location = new System.Drawing.Point(229, 180);
            this.gidistarih.Name = "gidistarih";
            this.gidistarih.Size = new System.Drawing.Size(217, 22);
            this.gidistarih.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(136, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 17);
            this.label10.TabIndex = 42;
            this.label10.Text = "Gidiş Tarihi :";
            // 
            // DepoCikisnumericUpDown1
            // 
            this.DepoCikisnumericUpDown1.Location = new System.Drawing.Point(229, 113);
            this.DepoCikisnumericUpDown1.Name = "DepoCikisnumericUpDown1";
            this.DepoCikisnumericUpDown1.Size = new System.Drawing.Size(52, 22);
            this.DepoCikisnumericUpDown1.TabIndex = 41;
            this.DepoCikisnumericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "Adet :";
            // 
            // DepoCikisComboBox
            // 
            this.DepoCikisComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DepoCikisComboBox.FormattingEnabled = true;
            this.DepoCikisComboBox.Location = new System.Drawing.Point(229, 35);
            this.DepoCikisComboBox.Name = "DepoCikisComboBox";
            this.DepoCikisComboBox.Size = new System.Drawing.Size(217, 24);
            this.DepoCikisComboBox.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "Ürün";
            // 
            // DepoCikisaciklamaTextBox
            // 
            this.DepoCikisaciklamaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DepoCikisaciklamaTextBox.Location = new System.Drawing.Point(229, 221);
            this.DepoCikisaciklamaTextBox.Multiline = true;
            this.DepoCikisaciklamaTextBox.Name = "DepoCikisaciklamaTextBox";
            this.DepoCikisaciklamaTextBox.Size = new System.Drawing.Size(217, 94);
            this.DepoCikisaciklamaTextBox.TabIndex = 37;
            // 
            // CikisseriNoTextBox
            // 
            this.CikisseriNoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CikisseriNoTextBox.Location = new System.Drawing.Point(229, 71);
            this.CikisseriNoTextBox.Name = "CikisseriNoTextBox";
            this.CikisseriNoTextBox.Size = new System.Drawing.Size(217, 22);
            this.CikisseriNoTextBox.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(136, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "Seri No";
            // 
            // DepoCikistarihDateTimePicker
            // 
            this.DepoCikistarihDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DepoCikistarihDateTimePicker.Location = new System.Drawing.Point(229, 144);
            this.DepoCikistarihDateTimePicker.Name = "DepoCikistarihDateTimePicker";
            this.DepoCikistarihDateTimePicker.Size = new System.Drawing.Size(217, 22);
            this.DepoCikistarihDateTimePicker.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(136, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 17);
            this.label8.TabIndex = 34;
            this.label8.Text = "Geliş Tarihi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "DEPO";
            // 
            // Depocikisdepoara
            // 
            this.Depocikisdepoara.Location = new System.Drawing.Point(610, 19);
            this.Depocikisdepoara.Name = "Depocikisdepoara";
            this.Depocikisdepoara.Size = new System.Drawing.Size(166, 22);
            this.Depocikisdepoara.TabIndex = 5;
            this.Depocikisdepoara.TextChanged += new System.EventHandler(this.Depocikisdepoara_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(543, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ara :";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıstasyonAdiDataGridViewTextBoxColumn,
            this.ıstasyonNoDataGridViewTextBoxColumn,
            this.ıstasyonBayiNoDataGridViewTextBoxColumn,
            this.Istasyon_Id});
            this.dataGridView2.DataSource = this.ıstasyonlarBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(832, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(547, 323);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // ıstasyonAdiDataGridViewTextBoxColumn
            // 
            this.ıstasyonAdiDataGridViewTextBoxColumn.DataPropertyName = "Istasyon_Adi";
            this.ıstasyonAdiDataGridViewTextBoxColumn.HeaderText = "Istasyon_Adi";
            this.ıstasyonAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıstasyonAdiDataGridViewTextBoxColumn.Name = "ıstasyonAdiDataGridViewTextBoxColumn";
            this.ıstasyonAdiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ıstasyonNoDataGridViewTextBoxColumn
            // 
            this.ıstasyonNoDataGridViewTextBoxColumn.DataPropertyName = "Istasyon_No";
            this.ıstasyonNoDataGridViewTextBoxColumn.HeaderText = "Istasyon_No";
            this.ıstasyonNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıstasyonNoDataGridViewTextBoxColumn.Name = "ıstasyonNoDataGridViewTextBoxColumn";
            this.ıstasyonNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ıstasyonBayiNoDataGridViewTextBoxColumn
            // 
            this.ıstasyonBayiNoDataGridViewTextBoxColumn.DataPropertyName = "Istasyon_Bayi_No";
            this.ıstasyonBayiNoDataGridViewTextBoxColumn.HeaderText = "Istasyon_Bayi_No";
            this.ıstasyonBayiNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıstasyonBayiNoDataGridViewTextBoxColumn.Name = "ıstasyonBayiNoDataGridViewTextBoxColumn";
            this.ıstasyonBayiNoDataGridViewTextBoxColumn.ReadOnly = true;
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
            // ıstasyonlarBindingSource
            // 
            this.ıstasyonlarBindingSource.DataMember = "Istasyonlar";
            this.ıstasyonlarBindingSource.DataSource = this.masterDataSet;
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Urun_Adi,
            this.seriNoDataGridViewTextBoxColumn,
            this.adetDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn,
            this.aciklamaDataGridViewTextBoxColumn,
            this.urunIdDataGridViewTextBoxColumn,
            this.Depo_Id});
            this.dataGridView1.DataSource = this.depoBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(823, 323);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Urun_Adi
            // 
            this.Urun_Adi.DataPropertyName = "Urun_Adi";
            this.Urun_Adi.HeaderText = "Urun_Adi";
            this.Urun_Adi.MinimumWidth = 6;
            this.Urun_Adi.Name = "Urun_Adi";
            this.Urun_Adi.ReadOnly = true;
            // 
            // seriNoDataGridViewTextBoxColumn
            // 
            this.seriNoDataGridViewTextBoxColumn.DataPropertyName = "Seri_No";
            this.seriNoDataGridViewTextBoxColumn.HeaderText = "Seri_No";
            this.seriNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.seriNoDataGridViewTextBoxColumn.Name = "seriNoDataGridViewTextBoxColumn";
            this.seriNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adetDataGridViewTextBoxColumn
            // 
            this.adetDataGridViewTextBoxColumn.DataPropertyName = "Adet";
            this.adetDataGridViewTextBoxColumn.HeaderText = "Adet";
            this.adetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adetDataGridViewTextBoxColumn.Name = "adetDataGridViewTextBoxColumn";
            this.adetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "Tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            this.tarihDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aciklamaDataGridViewTextBoxColumn
            // 
            this.aciklamaDataGridViewTextBoxColumn.DataPropertyName = "Aciklama";
            this.aciklamaDataGridViewTextBoxColumn.HeaderText = "Aciklama";
            this.aciklamaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aciklamaDataGridViewTextBoxColumn.Name = "aciklamaDataGridViewTextBoxColumn";
            this.aciklamaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urunIdDataGridViewTextBoxColumn
            // 
            this.urunIdDataGridViewTextBoxColumn.DataPropertyName = "Urun_Id";
            this.urunIdDataGridViewTextBoxColumn.HeaderText = "Urun_Id";
            this.urunIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunIdDataGridViewTextBoxColumn.Name = "urunIdDataGridViewTextBoxColumn";
            this.urunIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.urunIdDataGridViewTextBoxColumn.Visible = false;
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
            // depoBindingSource
            // 
            this.depoBindingSource.DataMember = "Depo";
            this.depoBindingSource.DataSource = this.masterDataSet;
            // 
            // depoTableAdapter
            // 
            this.depoTableAdapter.ClearBeforeFill = true;
            // 
            // istasyonlarTableAdapter
            // 
            this.istasyonlarTableAdapter.ClearBeforeFill = true;
            // 
            // DepoCikisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 659);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1397, 697);
            this.Name = "DepoCikisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepoCikisForm";
            this.Load += new System.EventHandler(this.DepoCikisForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DepoCikisnumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıstasyonlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource depoBindingSource;
        private masterDataSetTableAdapters.DepoTableAdapter depoTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource ıstasyonlarBindingSource;
        private masterDataSetTableAdapters.IstasyonlarTableAdapter istasyonlarTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox depocikisistasyonara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Depocikisdepoara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.NumericUpDown DepoCikisnumericUpDown1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox DepoCikisComboBox;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox DepoCikisaciklamaTextBox;
        public System.Windows.Forms.TextBox CikisseriNoTextBox;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.DateTimePicker DepoCikistarihDateTimePicker;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Button DepoCikisFormUpdate;
        public System.Windows.Forms.Button DepoCikisFormAdd;
        public System.Windows.Forms.TextBox DepoCikisIstasyonbayiNoTextBox;
        public System.Windows.Forms.TextBox DepoCikisIstasyonNoTextBox;
        public System.Windows.Forms.TextBox DepoCikisIstasyonAdiTxt;
        public System.Windows.Forms.Button Cikisbutton3;
        public System.Windows.Forms.DateTimePicker gidistarih;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıstasyonAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıstasyonNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıstasyonBayiNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Istasyon_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Urun_Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn seriNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gonderildiDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Depo_Id;
    }
}