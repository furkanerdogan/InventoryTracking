
namespace StokTakip
{
    partial class StationsForm
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
            System.Windows.Forms.Label urun_AdiLabel;
            System.Windows.Forms.Label Istasyon_No;
            System.Windows.Forms.Label label1;
            this.IstasyonNoTextBox = new System.Windows.Forms.TextBox();
            this.IstasyonAdiTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.IstasyonFormUpdate = new System.Windows.Forms.Button();
            this.IstasyonFormAdd = new System.Windows.Forms.Button();
            this.IstasyonbayiNoTextBox = new System.Windows.Forms.TextBox();
            urun_AdiLabel = new System.Windows.Forms.Label();
            Istasyon_No = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // urun_AdiLabel
            // 
            urun_AdiLabel.AutoSize = true;
            urun_AdiLabel.Location = new System.Drawing.Point(18, 68);
            urun_AdiLabel.Name = "urun_AdiLabel";
            urun_AdiLabel.Size = new System.Drawing.Size(92, 17);
            urun_AdiLabel.TabIndex = 13;
            urun_AdiLabel.Text = "İstasyon Adı :";
            // 
            // Istasyon_No
            // 
            Istasyon_No.AutoSize = true;
            Istasyon_No.Location = new System.Drawing.Point(18, 130);
            Istasyon_No.Name = "Istasyon_No";
            Istasyon_No.Size = new System.Drawing.Size(90, 17);
            Istasyon_No.TabIndex = 14;
            Istasyon_No.Text = "İstasyon No :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(18, 194);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(121, 17);
            label1.TabIndex = 19;
            label1.Text = "İstasyon Bayi No :";
            // 
            // IstasyonNoTextBox
            // 
            this.IstasyonNoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IstasyonNoTextBox.Location = new System.Drawing.Point(154, 127);
            this.IstasyonNoTextBox.Name = "IstasyonNoTextBox";
            this.IstasyonNoTextBox.Size = new System.Drawing.Size(384, 22);
            this.IstasyonNoTextBox.TabIndex = 18;
            // 
            // IstasyonAdiTxt
            // 
            this.IstasyonAdiTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IstasyonAdiTxt.Location = new System.Drawing.Point(154, 63);
            this.IstasyonAdiTxt.Name = "IstasyonAdiTxt";
            this.IstasyonAdiTxt.Size = new System.Drawing.Size(384, 22);
            this.IstasyonAdiTxt.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.IstasyonFormUpdate);
            this.groupBox1.Controls.Add(this.IstasyonFormAdd);
            this.groupBox1.Controls.Add(this.IstasyonbayiNoTextBox);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.IstasyonNoTextBox);
            this.groupBox1.Controls.Add(this.IstasyonAdiTxt);
            this.groupBox1.Controls.Add(urun_AdiLabel);
            this.groupBox1.Controls.Add(Istasyon_No);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 506);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İstasyon Ekle";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(53)))), ((int)(((byte)(136)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 470);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(570, 33);
            this.flowLayoutPanel1.TabIndex = 46;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button3.Location = new System.Drawing.Point(484, 395);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 50);
            this.button3.TabIndex = 45;
            this.button3.Text = "Temizle";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // IstasyonFormUpdate
            // 
            this.IstasyonFormUpdate.Location = new System.Drawing.Point(319, 395);
            this.IstasyonFormUpdate.Name = "IstasyonFormUpdate";
            this.IstasyonFormUpdate.Size = new System.Drawing.Size(80, 50);
            this.IstasyonFormUpdate.TabIndex = 44;
            this.IstasyonFormUpdate.Text = "Güncelle";
            this.IstasyonFormUpdate.UseVisualStyleBackColor = true;
            this.IstasyonFormUpdate.Click += new System.EventHandler(this.IstasyonFormUpdate_Click);
            // 
            // IstasyonFormAdd
            // 
            this.IstasyonFormAdd.Location = new System.Drawing.Point(233, 395);
            this.IstasyonFormAdd.Name = "IstasyonFormAdd";
            this.IstasyonFormAdd.Size = new System.Drawing.Size(80, 50);
            this.IstasyonFormAdd.TabIndex = 43;
            this.IstasyonFormAdd.Text = "Ekle";
            this.IstasyonFormAdd.UseVisualStyleBackColor = true;
            this.IstasyonFormAdd.Click += new System.EventHandler(this.UrunlerForm_AddBtn_Click);
            // 
            // IstasyonbayiNoTextBox
            // 
            this.IstasyonbayiNoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IstasyonbayiNoTextBox.Location = new System.Drawing.Point(154, 189);
            this.IstasyonbayiNoTextBox.Name = "IstasyonbayiNoTextBox";
            this.IstasyonbayiNoTextBox.Size = new System.Drawing.Size(384, 22);
            this.IstasyonbayiNoTextBox.TabIndex = 20;
            // 
            // IstasyonlarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 506);
            this.Controls.Add(this.groupBox1);
            this.Name = "IstasyonlarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button IstasyonFormUpdate;
        public System.Windows.Forms.Button IstasyonFormAdd;
        public System.Windows.Forms.TextBox IstasyonNoTextBox;
        public System.Windows.Forms.TextBox IstasyonAdiTxt;
        public System.Windows.Forms.TextBox IstasyonbayiNoTextBox;
    }
}