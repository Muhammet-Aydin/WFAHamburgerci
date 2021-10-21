using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAHamburgerci
{
    public partial class MYMDIForm : Form
    {
        public MYMDIForm()
        {
            InitializeComponent();
        }

        void ChildForm(Form _childform)
        {
            this.Width = _childform.Width + 100;
            this.Height = _childform.Height + 100;

            bool durum = false;

            foreach (Form item in this.MdiChildren)
            {
                if (item.Text==_childform.Text)
                {
                    durum = true;
                    item.Activate();
                }
                else
                {
                    item.Close();
                   
                }
            }
            if (durum==false)
            {
                _childform.MdiParent = this;
                _childform.Show();
            }
     
        }

        private void siparişBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Form1());
        }

        private void siparişBİlgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Form4());
        }

        private void hamburgerEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Form2());
        }

        private void ekstraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Form3());
        }

      

        private void MYMDIForm_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }
    }
}
