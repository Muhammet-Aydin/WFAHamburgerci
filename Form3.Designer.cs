
namespace WFAHamburgerci
{
    partial class Form3
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
            this.grbekstramalzeme = new System.Windows.Forms.GroupBox();
            this.nmrekstramalzemeFiyat = new System.Windows.Forms.NumericUpDown();
            this.txtekstramalzemeAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grbekstramalzeme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrekstramalzemeFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // grbekstramalzeme
            // 
            this.grbekstramalzeme.Controls.Add(this.button1);
            this.grbekstramalzeme.Controls.Add(this.nmrekstramalzemeFiyat);
            this.grbekstramalzeme.Controls.Add(this.txtekstramalzemeAdi);
            this.grbekstramalzeme.Controls.Add(this.label2);
            this.grbekstramalzeme.Controls.Add(this.label1);
            this.grbekstramalzeme.Location = new System.Drawing.Point(31, 30);
            this.grbekstramalzeme.Name = "grbekstramalzeme";
            this.grbekstramalzeme.Size = new System.Drawing.Size(590, 374);
            this.grbekstramalzeme.TabIndex = 0;
            this.grbekstramalzeme.TabStop = false;
            this.grbekstramalzeme.Text = "Ekstra Malzeme Bilgisi:";
            // 
            // nmrekstramalzemeFiyat
            // 
            this.nmrekstramalzemeFiyat.Location = new System.Drawing.Point(168, 112);
            this.nmrekstramalzemeFiyat.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrekstramalzemeFiyat.Name = "nmrekstramalzemeFiyat";
            this.nmrekstramalzemeFiyat.Size = new System.Drawing.Size(140, 20);
            this.nmrekstramalzemeFiyat.TabIndex = 3;
            this.nmrekstramalzemeFiyat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtekstramalzemeAdi
            // 
            this.txtekstramalzemeAdi.Location = new System.Drawing.Point(168, 63);
            this.txtekstramalzemeAdi.Name = "txtekstramalzemeAdi";
            this.txtekstramalzemeAdi.Size = new System.Drawing.Size(139, 20);
            this.txtekstramalzemeAdi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "fiyat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "adi";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "ekstra malzeme ekleme";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 456);
            this.Controls.Add(this.grbekstramalzeme);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form3";
            this.grbekstramalzeme.ResumeLayout(false);
            this.grbekstramalzeme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrekstramalzemeFiyat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbekstramalzeme;
        private System.Windows.Forms.NumericUpDown nmrekstramalzemeFiyat;
        private System.Windows.Forms.TextBox txtekstramalzemeAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}