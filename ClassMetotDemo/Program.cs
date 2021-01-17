using System;

namespace ClassMetotDemo
{
    class Program
    {
        public void ekle(Musteri kullaniciid, string MusteriAdi,string MusteriSoyadi, int Id,int Telefon_No,double Bakiye, string Banka_il)
        {
            MusteriManager MusteriTakip = new MusteriManager();
            var userid = new Musteri();
            MusteriTakip.Register_New_Musteri(kullaniciid, MusteriAdi, MusteriSoyadi, Id, Telefon_No, Bakiye, Banka_il);

        }
        static void Main(string[] args)
        {
            Musteri user1 = new Musteri();
            user1.MusteriAdi = "Mehmet Emre";
            user1.MusteriSoyadi = "ATA";
            user1.Id = 1234343234;
            user1.Telefon_No = 555111233;
            user1.Bakiye = 45500;
            user1.Banka_il = "Gaziantep";
            Musteri user2 = new Musteri();
            user2.MusteriAdi = "Abdullah";
            user2.MusteriSoyadi = "ATA";
            user2.Id = 431212524;
            user2.Telefon_No = 222111453;
            user2.Bakiye = 150000;
            user2.Banka_il = "İstanbul";

            Musteri user3 = new Musteri();
            user3.MusteriAdi = "Emir Fatih";
            user3.MusteriSoyadi = "ATA";
            user3.Id = 254246845;
            user3.Telefon_No = 444557654;
            user3.Bakiye = 12500;
            user2.Banka_il = "Ankara";


            MusteriManager MusteriTakip = new MusteriManager();
            Musteri[] Musteri_List = new Musteri[] { user1, user2, user3 };


            foreach (var item in Musteri_List)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine(item.MusteriAdi);
                Console.WriteLine(item.MusteriSoyadi);
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Telefon_No);
                Console.WriteLine(item.Bakiye);
                Console.WriteLine(item.Banka_il);
                Console.WriteLine("------------------------------");
            }
        }
    }
}
