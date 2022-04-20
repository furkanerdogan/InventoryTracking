
namespace StokTakip
{
    partial class StockForm
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
            System.Windows.Forms.Label aciklamaLabel;
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.DepoComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DepoaciklamaTextBox = new System.Windows.Forms.TextBox();
            this.Deposeri_NoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DepotarihDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.DepoFormUpdate = new System.Windows.Forms.Button();
            this.DepoFormAdd = new System.Windows.Forms.Button();
            aciklamaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // aciklamaLabel
            // 
            aciklamaLabel.AutoSize = true;
            aciklamaLabel.Location = new System.Drawing.Point(19, 191);
            aciklamaLabel.Name = "aciklamaLabel";
            aciklamaLabel.Size = new System.Drawing.Size(68, 17);
            aciklamaLabel.TabIndex = 18;
            aciklamaLabel.Text = "Aciklama:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(100, 119);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(63, 22);
            this.numericUpDown1.TabIndex = 31;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Adet :";
            // 
            // DepoComboBox
            // 
            this.DepoComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DepoComboBox.FormattingEnabled = true;
            this.DepoComboBox.Location = new System.Drawing.Point(100, 41);
            this.DepoComboBox.Name = "DepoComboBox";
            this.DepoComboBox.Size = new System.Drawing.Size(405, 24);
            this.DepoComboBox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün";
            // 
            // DepoaciklamaTextBox
            // 
            this.DepoaciklamaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DepoaciklamaTextBox.Location = new System.Drawing.Point(100, 191);
            this.DepoaciklamaTextBox.Multiline = true;
            this.DepoaciklamaTextBox.Name = "DepoaciklamaTextBox";
            this.DepoaciklamaTextBox.Size = new System.Drawing.Size(405, 204);
            this.DepoaciklamaTextBox.TabIndex = 19;
            // 
            // Deposeri_NoTextBox
            // 
            this.Deposeri_NoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Deposeri_NoTextBox.Location = new System.Drawing.Point(100, 77);
            this.Deposeri_NoTextBox.Name = "Deposeri_NoTextBox";
            this.Deposeri_NoTextBox.Size = new System.Drawing.Size(405, 22);
            this.Deposeri_NoTextBox.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seri No";
            // 
            // DepotarihDateTimePicker
            // 
            this.DepotarihDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DepotarihDateTimePicker.Location = new System.Drawing.Point(100, 151);
            this.DepotarihDateTimePicker.Name = "DepotarihDateTimePicker";
            this.DepotarihDateTimePicker.Size = new System.Drawing.Size(405, 22);
            this.DepotarihDateTimePicker.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tarih :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.DepoFormUpdate);
            this.groupBox1.Controls.Add(this.DepoFormAdd);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.DepoComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DepoaciklamaTextBox);
            this.groupBox1.Controls.Add(this.Deposeri_NoTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DepotarihDateTimePicker);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(aciklamaLabel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 515);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Depo Formu";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(53)))), ((int)(((byte)(136)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 479);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(574, 33);
            this.flowLayoutPanel1.TabIndex = 47;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button3.Location = new System.Drawing.Point(479, 414);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 50);
            this.button3.TabIndex = 34;
            this.button3.Text = "Temizle";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DepoFormUpdate
            // 
            this.DepoFormUpdate.Location = new System.Drawing.Point(314, 414);
            this.DepoFormUpdate.Name = "DepoFormUpdate";
            this.DepoFormUpdate.Size = new System.Drawing.Size(80, 50);
            this.DepoFormUpdate.TabIndex = 33;
            this.DepoFormUpdate.Text = "Güncelle";
            this.DepoFormUpdate.UseVisualStyleBackColor = true;
            this.DepoFormUpdate.Click += new System.EventHandler(this.button2_Click);
            // 
            // DepoFormAdd
            // 
            this.DepoFormAdd.Location = new System.Drawing.Point(228, 414);
            this.DepoFormAdd.Name = "DepoFormAdd";
            this.DepoFormAdd.Size = new System.Drawing.Size(80, 50);
            this.DepoFormAdd.TabIndex = 32;
            this.DepoFormAdd.Text = "Ekle";
            this.DepoFormAdd.UseVisualStyleBackColor = true;
            this.DepoFormAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // DepoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 515);
            this.Controls.Add(this.groupBox1);
            this.Name = "DepoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.DepoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.Button DepoFormUpdate;
        public System.Windows.Forms.Button DepoFormAdd;
        public System.Windows.Forms.NumericUpDown numericUpDown1;
        public System.Windows.Forms.ComboBox DepoComboBox;
        public System.Windows.Forms.TextBox DepoaciklamaTextBox;
        public System.Windows.Forms.TextBox Deposeri_NoTextBox;
        public System.Windows.Forms.DateTimePicker DepotarihDateTimePicker;
    }
}