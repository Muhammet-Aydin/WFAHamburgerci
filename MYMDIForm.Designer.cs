
namespace WFAHamburgerci
{
    partial class MYMDIForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.siparişYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişBİlgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hamburgerEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekstraMalzemeEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişYönetimiToolStripMenuItem,
            this.ürünYönetimiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(748, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
      
            // 
            // siparişYönetimiToolStripMenuItem
            // 
            this.siparişYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişBToolStripMenuItem,
            this.siparişBİlgileriToolStripMenuItem});
            this.siparişYönetimiToolStripMenuItem.Name = "siparişYönetimiToolStripMenuItem";
            this.siparişYönetimiToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.siparişYönetimiToolStripMenuItem.Text = "Sipariş Yönetimi";
            // 
            // siparişBToolStripMenuItem
            // 
            this.siparişBToolStripMenuItem.Name = "siparişBToolStripMenuItem";
            this.siparişBToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.siparişBToolStripMenuItem.Text = "Sipariş Oluştur";
            this.siparişBToolStripMenuItem.Click += new System.EventHandler(this.siparişBToolStripMenuItem_Click);
            // 
            // siparişBİlgileriToolStripMenuItem
            // 
            this.siparişBİlgileriToolStripMenuItem.Name = "siparişBİlgileriToolStripMenuItem";
            this.siparişBİlgileriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.siparişBİlgileriToolStripMenuItem.Text = "Sipariş Bİlgileri";
            this.siparişBİlgileriToolStripMenuItem.Click += new System.EventHandler(this.siparişBİlgileriToolStripMenuItem_Click);
            // 
            // ürünYönetimiToolStripMenuItem
            // 
            this.ürünYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hamburgerEkleToolStripMenuItem,
            this.ekstraMalzemeEkleToolStripMenuItem});
            this.ürünYönetimiToolStripMenuItem.Name = "ürünYönetimiToolStripMenuItem";
            this.ürünYönetimiToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.ürünYönetimiToolStripMenuItem.Text = "Ürün Yönetimi";
            // 
            // hamburgerEkleToolStripMenuItem
            // 
            this.hamburgerEkleToolStripMenuItem.Name = "hamburgerEkleToolStripMenuItem";
            this.hamburgerEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hamburgerEkleToolStripMenuItem.Text = "Hamburger Ekle";
            this.hamburgerEkleToolStripMenuItem.Click += new System.EventHandler(this.hamburgerEkleToolStripMenuItem_Click);
            // 
            // ekstraMalzemeEkleToolStripMenuItem
            // 
            this.ekstraMalzemeEkleToolStripMenuItem.Name = "ekstraMalzemeEkleToolStripMenuItem";
            this.ekstraMalzemeEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ekstraMalzemeEkleToolStripMenuItem.Text = "Ekstra Malzeme Ekle";
            this.ekstraMalzemeEkleToolStripMenuItem.Click += new System.EventHandler(this.ekstraMalzemeEkleToolStripMenuItem_Click);
            // 
            // MYMDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(748, 466);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MYMDIForm";
            this.Text = "MyMDIForm";
            this.Load += new System.EventHandler(this.MYMDIForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem siparişYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişBİlgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hamburgerEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekstraMalzemeEkleToolStripMenuItem;
    }
}