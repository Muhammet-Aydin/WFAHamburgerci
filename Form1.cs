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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public static List<Sipariş> Siparişler = new List<Sipariş>();//heapte statıc alan actık istedigimizde siparişleri tutacak sıipariş listesi olusturduk.
        public static List<Sipariş> MevcutSiparişler = new List<Sipariş>();//anlık sıparıslerı tutacak liste

        public static List<Menü> Menüler = new List<Menü>//menu bilgiler her menu ıcın hepte ayrı alan acıp koyduk
        {
            new Menü {MenüAdi="SteakHouse",Fiyat=40m},
            new Menü {MenüAdi="McFish",Fiyat=25m},
            new Menü {MenüAdi="BigChicken",Fiyat=45m},
            new Menü{MenüAdi="Whooper",Fiyat=50m},
            new Menü{MenüAdi="Chicken Royal",Fiyat=30m},
            new Menü{MenüAdi="King Chicken",Fiyat=50m }
        };

        public static List<Ekstra> ekstralar = new List<Ekstra>()//ekstraları tanımladıgımız listeye ekstra ekledık her ekstra yenı alan actık.
        {
        new Ekstra {EkstraAdi="Hardal",EkstraFiyat=1},
        new Ekstra {EkstraAdi="Mayonez",EkstraFiyat=1.5m},
        new Ekstra{EkstraAdi="Ketcap",EkstraFiyat=2},
        new Ekstra{EkstraAdi="Ranch",EkstraFiyat=2},
        new Ekstra{EkstraAdi="BBQ",EkstraFiyat=1.3m},
        new Ekstra{EkstraAdi="Sogan Halkasi",EkstraFiyat=5},
        new Ekstra{EkstraAdi="Buffalo",EkstraFiyat=1.4m},
        new Ekstra{EkstraAdi="Sarımsaklı Mayonez",EkstraFiyat=1.4m},
       };

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in Menüler)//menulerı cmbboxa  doldurduk.
            {
                cmbmenüler.Items.Add(item);
            }
            foreach (var item in ekstralar)//ekstraları llp yukledık. flp ıcıne checkbox olusturarak ekledık.
            {
                flpEkstraMalzemeler.Controls.Add(new CheckBox { Text = item.EkstraAdi, Tag = item });
            }
            foreach (var item in MevcutSiparişler)//mwvcut sipariş listesinden verileri alarak list boxa doldurduk.
            {
                lstsiparişler.Items.Add(item);
            }
        }

        private void btnSiparişEkle_Click(object sender, EventArgs e)
        {
            Sipariş yeniSipariş = new Sipariş();

            yeniSipariş.SecilenMenü = (Menü)cmbmenüler.SelectedItem;

            if (rbküçük.Checked)
            {
                yeniSipariş.Boyut = Boyut.Kucuk;
            }
            else if (rborta.Checked)
            {
                yeniSipariş.Boyut = Boyut.Orta;
            }
            else
            {
                yeniSipariş.Boyut = Boyut.Büyük;
            }

            yeniSipariş.EkstraMalzemesi = new List<Ekstra>();

            foreach (CheckBox item in flpEkstraMalzemeler.Controls )
            {
                if (item.Checked)
                {
                    yeniSipariş.EkstraMalzemesi.Add((Ekstra)item.Tag);
                }
            }
            yeniSipariş.Adet = Convert.ToInt32(nmrupdown.Value);
            yeniSipariş.Hesapla();
            MevcutSiparişler.Add(yeniSipariş);

            Siparişler.Add(yeniSipariş);
            lstsiparişler.Items.Add(yeniSipariş);
            TutarHesapla();
            Fonksıyon.Temizle(this.Controls);

        }

        private decimal TutarHesapla()
        {
            decimal ToplamTutar = 0;

            for (int i = 0; i < lstsiparişler.Items.Count; i++)
            {
                Sipariş gelenTutar = (Sipariş)lstsiparişler.Items[i];
                ToplamTutar += gelenTutar.ToplamTutar;
            }
            lbltoplamtutar.Text = ToplamTutar.ToString("C2");
            return ToplamTutar;
        }

        private void btnsipariştamamla_Click(object sender, EventArgs e)
        {
          DialogResult dr= MessageBox.Show("Toplam Sipariş Ücreti:"+lbltoplamtutar.Text+"Satın Almayı Onaylamak Yada TamamLamak İstermisiniz?","Sipariş bilgisi",MessageBoxButtons.YesNo,MessageBoxIcon.Information);

            if (dr==DialogResult.Yes)
            {
                lstsiparişler.Items.Clear();
                MevcutSiparişler.Clear();
                TutarHesapla();
                MessageBox.Show("Sipariş Tamamlandı.");
            }
            else
            {
                MessageBox.Show("Sipariş İptal Edildi.");
            }
            
        }

  
    }




}

