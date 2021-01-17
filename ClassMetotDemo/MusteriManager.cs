using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        Musteri[] Musteri_List = new Musteri[] { };

        public void Register_New_Musteri(Musteri kullaniciid,string MusteriAdi,string MusteriSoyadi, int Id,int Telefon_No,double Bakiye,string Banka_il )
        {
            kullaniciid.MusteriAdi = MusteriAdi;
            kullaniciid.MusteriSoyadi = MusteriSoyadi;
            kullaniciid.Id = Id;
            kullaniciid.Telefon_No = Telefon_No;
            kullaniciid.Bakiye = Bakiye;
            kullaniciid.Banka_il = Banka_il;

        }

        public void Delete_user()
        {

        }


    }
}
