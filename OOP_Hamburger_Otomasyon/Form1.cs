using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP_Hamburger_Otomasyon.Models;

namespace OOP_Hamburger_Otomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<HamburgerMenusu> menuler = new List<HamburgerMenusu>
            {
                new HamburgerMenusu
                    {Ad = "Texas SmokeHouse", Fiyat = 15, Description = "Gurme Menünüsünden enfes bir lezzet"},
                new HamburgerMenusu
                    {Ad = "Barbekü Brioche", Fiyat = 18, Description = "Barbekülü bir Meksika ateşinde hazır mısınız"},
                new HamburgerMenusu
                    {Ad = "Crispy Chicken", Fiyat = 20, Description = "Tavuklar hiç bu kadar çıtır olmamıştı"},
                new HamburgerMenusu
                {
                    Ad = "SteakHouse", Fiyat = 25, Description = "Öyle bir tat alacaksınız ki bu para az diyeceksiniz"
                },
                new HamburgerMenusu
                    {Ad = "TenderCrisp", Fiyat = 23, Description = "Hem acıyı aldık hem de çıtırı bir araya getirdik"}
            };

            foreach (HamburgerMenusu item in menuler)
            {
                cmbMenuler.Items.Add(item);

            }

        }

        private void cmbMenuler_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblAcıklama.Text = (cmbMenuler.SelectedItem as HamburgerMenusu).Description;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Siparis s = new Siparis();
            s.SecilenMenu=cmbMenuler.SelectedItem as HamburgerMenusu;
            s.Adet = Convert.ToInt16(nmrAdet.Value);
            if (rdbBuyuk.Checked) s.Buyukluk = Enums.Boyut.Buyuk;
            else if (rdbKucuk.Checked) s.Buyukluk = Enums.Boyut.Orta;
            else s.Buyukluk = Enums.Boyut.Kucuk;


            foreach (CheckBox item in grbMalzeme.Controls)
            {
                if (item.Checked)
                {
                    EkstraMalzeme eks=new EkstraMalzeme();
                    eks.Ad = item.Text;
                    eks.Fiyat = Convert.ToDecimal(item.Tag);
                    s.Malzemeleri.Add(eks);
                }
            }
            s.TutarHesapla();
            lstSiparisler.Items.Add(s);

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            decimal toplam = 0;
            foreach (Siparis item in lstSiparisler.Items)
            {
                toplam += item.ToplamTutar;
                

            }
            MessageBox.Show($"Toplam Tutarınız :{toplam.ToString()}");

        }
    }
}
