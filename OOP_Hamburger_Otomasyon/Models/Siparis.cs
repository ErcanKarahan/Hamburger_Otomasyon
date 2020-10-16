using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Hamburger_Otomasyon.Enums;

namespace OOP_Hamburger_Otomasyon.Models
{
    public class Siparis
    {

        public Siparis()
        {

            Malzemeleri = new List<EkstraMalzeme>();
        }
        public HamburgerMenusu SecilenMenu { get; set; }
        public short Adet { get; set; }
        public Boyut Buyukluk { get; set; }
        public List<EkstraMalzeme> Malzemeleri { get; set; }

        public decimal ToplamTutar { get; private set; }
        public void TutarHesapla()
        {
            ToplamTutar = SecilenMenu.Fiyat;
            switch (Buyukluk)
            {
                case Boyut.Orta:
                    ToplamTutar += 1;
                    break;
                case Boyut.Buyuk:
                    ToplamTutar += 2;
                    break;
            }

            foreach (EkstraMalzeme item in Malzemeleri)
            {
                ToplamTutar += item.Fiyat;

            }

            ToplamTutar *= Adet;
        }

        public override string ToString()
        {
            if (Malzemeleri.Count<1)
            {
                return $"{SecilenMenu.Ad}Menüsü,x{Adet},{Buyukluk}Boy,Topla : {ToplamTutar:C2}";
            }
            else
            {
                string malzemesi = null;
                foreach (EkstraMalzeme item  in Malzemeleri)
                {
                    malzemesi += $"{item.Ad},";
                }
                malzemesi = malzemesi.TrimEnd(',');
                return
                    $"{SecilenMenu.Ad}menüsü,{Buyukluk}bay,x{Adet},malzemeleri:({malzemesi}),Toplam Tutar=>{ToplamTutar:C2}";
            }
        }
    }
}

