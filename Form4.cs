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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            decimal ciro = 0;
            decimal exMalzemeGeliri = 0;
            decimal satişAdeti = 0;
            foreach (var item in Form1.Siparişler)
            {
                ciro += item.ToplamTutar;
                foreach (var ex in item.EkstraMalzemesi)//siparişlerin içinde olduug çin siparişler itema atıldıgı için  o item uzerındenn ulasılabilir.
                {
                    exMalzemeGeliri += ex.EkstraFiyat;
                }
                satişAdeti += item.Adet;
                lstsiparisler.Items.Add(item);
            }
            lblSiparisSayısı.Text = lstsiparisler.Items.Count.ToString();
            lblCiro.Text = ciro.ToString("C2");
            lblEkstraMalzemeGeliri.Text = exMalzemeGeliri.ToString();
            lblSatılanUrunAdeti.Text = satişAdeti.ToString();
        }
    }
}
