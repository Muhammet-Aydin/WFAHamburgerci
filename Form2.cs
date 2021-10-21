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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
                Form1.Menüler.Add(new Menü {MenüAdi=txtmenuadi.Text, Fiyat=nmrMenufiyat.Value });
            Fonksıyon.Temizle(this.Controls);
            MessageBox.Show("ekleme işlemi basarıyla tamamlandı.");
        }

       
    }
}
