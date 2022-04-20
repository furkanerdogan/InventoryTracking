
namespace StokTakip
{
    partial class ProductsForm
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
            System.Windows.Forms.Label urun_FiyatLabel;
            System.Windows.Forms.Label urun_AdiLabel;
            System.Windows.Forms.Label urun_ModelLabel;
            System.Windows.Forms.Label aciklamaLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.UrunaciklamaTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.UrunlerForm_UpdateBtn = new System.Windows.Forms.Button();
            this.UrunlerForm_AddBtn = new System.Windows.Forms.Button();
            this.urun_FiyatTextBox = new System.Windows.Forms.TextBox();
            this.urun_ModelTextBox = new System.Windows.Forms.TextBox();
            this.urunAdiTxt = new System.Windows.Forms.TextBox();
            urun_FiyatLabel = new System.Windows.Forms.Label();
            urun_AdiLabel = new System.Windows.Forms.Label();
            urun_ModelLabel = new System.Windows.Forms.Label();
            aciklamaLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // urun_FiyatLabel
            // 
            urun_FiyatLabel.AutoSize = true;
            urun_FiyatLabel.Location = new System.Drawing.Point(26, 151);
            urun_FiyatLabel.Name = "urun_FiyatLabel";
            urun_FiyatLabel.Size = new System.Drawing.Size(77, 17);
            urun_FiyatLabel.TabIndex = 15;
            urun_FiyatLabel.Text = "Urun Fiyat:";
            // 
            // urun_AdiLabel
            // 
            urun_AdiLabel.AutoSize = true;
            urun_AdiLabel.Location = new System.Drawing.Point(26, 41);
            urun_AdiLabel.Name = "urun_AdiLabel";
            urun_AdiLabel.Size = new System.Drawing.Size(67, 17);
            urun_AdiLabel.TabIndex = 13;
            urun_AdiLabel.Text = "Urun Adi:";
            // 
            // urun_ModelLabel
            // 
            urun_ModelLabel.AutoSize = true;
            urun_ModelLabel.Location = new System.Drawing.Point(23, 95);
            urun_ModelLabel.Name = "urun_ModelLabel";
            urun_ModelLabel.Size = new System.Drawing.Size(90, 17);
            urun_ModelLabel.TabIndex = 14;
            urun_ModelLabel.Text = "Urun Marka :";
            // 
            // aciklamaLabel
            // 
            aciklamaLabel.AutoSize = true;
            aciklamaLabel.Location = new System.Drawing.Point(27, 205);
            aciklamaLabel.Name = "aciklamaLabel";
            aciklamaLabel.Size = new System.Drawing.Size(68, 17);
            aciklamaLabel.TabIndex = 40;
            aciklamaLabel.Text = "Aciklama:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Controls.Add(this.UrunaciklamaTextBox);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.UrunlerForm_UpdateBtn);
            this.groupBox1.Controls.Add(aciklamaLabel);
            this.groupBox1.Controls.Add(this.UrunlerForm_AddBtn);
            this.groupBox1.Controls.Add(this.urun_FiyatTextBox);
            this.groupBox1.Controls.Add(this.urun_ModelTextBox);
            this.groupBox1.Controls.Add(this.urunAdiTxt);
            this.groupBox1.Controls.Add(urun_FiyatLabel);
            this.groupBox1.Controls.Add(urun_AdiLabel);
            this.groupBox1.Controls.Add(urun_ModelLabel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 497);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürünler Formu";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(53)))), ((int)(((byte)(136)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 461);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(567, 33);
            this.flowLayoutPanel1.TabIndex = 42;
            // 
            // UrunaciklamaTextBox
            // 
            this.UrunaciklamaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UrunaciklamaTextBox.Location = new System.Drawing.Point(108, 205);
            this.UrunaciklamaTextBox.Multiline = true;
            this.UrunaciklamaTextBox.Name = "UrunaciklamaTextBox";
            this.UrunaciklamaTextBox.Size = new System.Drawing.Size(430, 163);
            this.UrunaciklamaTextBox.TabIndex = 41;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button3.Location = new System.Drawing.Point(481, 390);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 50);
            this.button3.TabIndex = 38;
            this.button3.Text = "Temizle";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // UrunlerForm_UpdateBtn
            // 
            this.UrunlerForm_UpdateBtn.Location = new System.Drawing.Point(316, 390);
            this.UrunlerForm_UpdateBtn.Name = "UrunlerForm_UpdateBtn";
            this.UrunlerForm_UpdateBtn.Size = new System.Drawing.Size(80, 50);
            this.UrunlerForm_UpdateBtn.TabIndex = 37;
            this.UrunlerForm_UpdateBtn.Text = "Güncelle";
            this.UrunlerForm_UpdateBtn.UseVisualStyleBackColor = true;
            this.UrunlerForm_UpdateBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // UrunlerForm_AddBtn
            // 
            this.UrunlerForm_AddBtn.Location = new System.Drawing.Point(230, 390);
            this.UrunlerForm_AddBtn.Name = "UrunlerForm_AddBtn";
            this.UrunlerForm_AddBtn.Size = new System.Drawing.Size(80, 50);
            this.UrunlerForm_AddBtn.TabIndex = 36;
            this.UrunlerForm_AddBtn.Text = "Ekle";
            this.UrunlerForm_AddBtn.UseVisualStyleBackColor = true;
            this.UrunlerForm_AddBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // urun_FiyatTextBox
            // 
            this.urun_FiyatTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urun_FiyatTextBox.Location = new System.Drawing.Point(117, 151);
            this.urun_FiyatTextBox.Name = "urun_FiyatTextBox";
            this.urun_FiyatTextBox.Size = new System.Drawing.Size(409, 22);
            this.urun_FiyatTextBox.TabIndex = 18;
            // 
            // urun_ModelTextBox
            // 
            this.urun_ModelTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urun_ModelTextBox.Location = new System.Drawing.Point(117, 90);
            this.urun_ModelTextBox.Name = "urun_ModelTextBox";
            this.urun_ModelTextBox.Size = new System.Drawing.Size(409, 22);
            this.urun_ModelTextBox.TabIndex = 18;
            // 
            // urunAdiTxt
            // 
            this.urunAdiTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urunAdiTxt.Location = new System.Drawing.Point(117, 36);
            this.urunAdiTxt.Name = "urunAdiTxt";
            this.urunAdiTxt.Size = new System.Drawing.Size(409, 22);
            this.urunAdiTxt.TabIndex = 18;
            // 
            // UrunlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 497);
            this.Controls.Add(this.groupBox1);
            this.Name = "UrunlerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.UrunlerForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button UrunlerForm_UpdateBtn;
        public System.Windows.Forms.Button UrunlerForm_AddBtn;
        public System.Windows.Forms.TextBox urun_FiyatTextBox;
        public System.Windows.Forms.TextBox urun_ModelTextBox;
        public System.Windows.Forms.TextBox urunAdiTxt;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.TextBox UrunaciklamaTextBox;
    }
}