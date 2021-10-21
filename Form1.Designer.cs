
namespace WFAHamburgerci
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbküçük = new System.Windows.Forms.RadioButton();
            this.rbbüyük = new System.Windows.Forms.RadioButton();
            this.rborta = new System.Windows.Forms.RadioButton();
            this.lstsiparişler = new System.Windows.Forms.ListBox();
            this.cmbmenüler = new System.Windows.Forms.ComboBox();
            this.pcbresim = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flpEkstraMalzemeler = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.nmrupdown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lbltoplamtutar = new System.Windows.Forms.Label();
            this.btnsipariştamamla = new System.Windows.Forms.Button();
            this.btnSiparişEkle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbresim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrupdown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menü Seçiniz:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbküçük);
            this.groupBox1.Controls.Add(this.rbbüyük);
            this.groupBox1.Controls.Add(this.rborta);
            this.groupBox1.Location = new System.Drawing.Point(14, 296);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 55);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Boyut Seciniz:";
            // 
            // rbküçük
            // 
            this.rbküçük.AutoSize = true;
            this.rbküçük.Checked = true;
            this.rbküçük.Location = new System.Drawing.Point(27, 19);
            this.rbküçük.Name = "rbküçük";
            this.rbküçük.Size = new System.Drawing.Size(60, 17);
            this.rbküçük.TabIndex = 6;
            this.rbküçük.TabStop = true;
            this.rbküçük.Text = "küçük";
            this.rbküçük.UseVisualStyleBackColor = true;
            // 
            // rbbüyük
            // 
            this.rbbüyük.AutoSize = true;
            this.rbbüyük.Location = new System.Drawing.Point(267, 19);
            this.rbbüyük.Name = "rbbüyük";
            this.rbbüyük.Size = new System.Drawing.Size(59, 17);
            this.rbbüyük.TabIndex = 5;
            this.rbbüyük.Text = "büyük";
            this.rbbüyük.UseVisualStyleBackColor = true;
            // 
            // rborta
            // 
            this.rborta.AutoSize = true;
            this.rborta.Location = new System.Drawing.Point(147, 19);
            this.rborta.Name = "rborta";
            this.rborta.Size = new System.Drawing.Size(47, 17);
            this.rborta.TabIndex = 4;
            this.rborta.Text = "orta";
            this.rborta.UseVisualStyleBackColor = true;
            // 
            // lstsiparişler
            // 
            this.lstsiparişler.FormattingEnabled = true;
            this.lstsiparişler.Location = new System.Drawing.Point(418, 12);
            this.lstsiparişler.Name = "lstsiparişler";
            this.lstsiparişler.Size = new System.Drawing.Size(513, 472);
            this.lstsiparişler.TabIndex = 2;
            // 
            // cmbmenüler
            // 
            this.cmbmenüler.FormattingEnabled = true;
            this.cmbmenüler.Location = new System.Drawing.Point(14, 257);
            this.cmbmenüler.Name = "cmbmenüler";
            this.cmbmenüler.Size = new System.Drawing.Size(370, 21);
            this.cmbmenüler.TabIndex = 3;
            // 
            // pcbresim
            // 
            this.pcbresim.Image = ((System.Drawing.Image)(resources.GetObject("pcbresim.Image")));
            this.pcbresim.Location = new System.Drawing.Point(17, 26);
            this.pcbresim.Name = "pcbresim";
            this.pcbresim.Size = new System.Drawing.Size(381, 203);
            this.pcbresim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbresim.TabIndex = 4;
            this.pcbresim.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ekstra Malzemeler:";
            // 
            // flpEkstraMalzemeler
            // 
            this.flpEkstraMalzemeler.Location = new System.Drawing.Point(17, 392);
            this.flpEkstraMalzemeler.Name = "flpEkstraMalzemeler";
            this.flpEkstraMalzemeler.Size = new System.Drawing.Size(367, 92);
            this.flpEkstraMalzemeler.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 501);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Adet:";
            // 
            // nmrupdown
            // 
            this.nmrupdown.DecimalPlaces = 2;
            this.nmrupdown.Location = new System.Drawing.Point(82, 494);
            this.nmrupdown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrupdown.Name = "nmrupdown";
            this.nmrupdown.Size = new System.Drawing.Size(140, 20);
            this.nmrupdown.TabIndex = 8;
            this.nmrupdown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 501);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Toplam Tutar:";
            // 
            // lbltoplamtutar
            // 
            this.lbltoplamtutar.AutoSize = true;
            this.lbltoplamtutar.Location = new System.Drawing.Point(521, 500);
            this.lbltoplamtutar.Name = "lbltoplamtutar";
            this.lbltoplamtutar.Size = new System.Drawing.Size(33, 13);
            this.lbltoplamtutar.TabIndex = 10;
            this.lbltoplamtutar.Text = "0 TL";
            // 
            // btnsipariştamamla
            // 
            this.btnsipariştamamla.Location = new System.Drawing.Point(771, 494);
            this.btnsipariştamamla.Name = "btnsipariştamamla";
            this.btnsipariştamamla.Size = new System.Drawing.Size(148, 35);
            this.btnsipariştamamla.TabIndex = 11;
            this.btnsipariştamamla.Text = "Siparişi Tamamla";
            this.btnsipariştamamla.UseVisualStyleBackColor = true;
            this.btnsipariştamamla.Click += new System.EventHandler(this.btnsipariştamamla_Click);
            // 
            // btnSiparişEkle
            // 
            this.btnSiparişEkle.Location = new System.Drawing.Point(74, 525);
            this.btnSiparişEkle.Name = "btnSiparişEkle";
            this.btnSiparişEkle.Size = new System.Drawing.Size(148, 35);
            this.btnSiparişEkle.TabIndex = 12;
            this.btnSiparişEkle.Text = "Sipariş Ekle";
            this.btnSiparişEkle.UseVisualStyleBackColor = true;
            this.btnSiparişEkle.Click += new System.EventHandler(this.btnSiparişEkle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 572);
            this.Controls.Add(this.btnSiparişEkle);
            this.Controls.Add(this.btnsipariştamamla);
            this.Controls.Add(this.lbltoplamtutar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nmrupdown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flpEkstraMalzemeler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pcbresim);
            this.Controls.Add(this.cmbmenüler);
            this.Controls.Add(this.lstsiparişler);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbresim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrupdown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbküçük;
        private System.Windows.Forms.RadioButton rbbüyük;
        private System.Windows.Forms.RadioButton rborta;
        private System.Windows.Forms.ListBox lstsiparişler;
        private System.Windows.Forms.ComboBox cmbmenüler;
        private System.Windows.Forms.PictureBox pcbresim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flpEkstraMalzemeler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmrupdown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbltoplamtutar;
        private System.Windows.Forms.Button btnsipariştamamla;
        private System.Windows.Forms.Button btnSiparişEkle;
    }
}

