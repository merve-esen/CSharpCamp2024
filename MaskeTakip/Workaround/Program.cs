using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();

            //Vatandas vatandas = new Vatandas();

            //SelamVer("Engin");
            //SelamVer("Deniz");
            //SelamVer("Merve");
            //SelamVer();

            //int sonuc = Topla(3, 5);

            // Diziler / Arrays
            //string ogrenci1 = "Engin";
            //string ogrenci2 = "Kerem";
            //string ogrenci3 = "Berkay";

            //Console.WriteLine(ogrenci1);
            //Console.WriteLine(ogrenci2);
            //Console.WriteLine(ogrenci3);

            //string[] ogrenciler = new string[3];
            //ogrenciler[0] = "Engin";
            //ogrenciler[1] = "Kerem";
            //ogrenciler[2] = "Berkay";

            //for (int i = 0; i < ogrenciler.Length; i++)
            //{
            //    Console.WriteLine(ogrenciler[i]);
            //}

            //string[] sehirler1 = new[] { "İstanbul", "Ankara", "İzmir" };
            //string[] sehirler2 = new[] { "Edirne", "Bursa", "Adana" };

            //sehirler2 = sehirler1;
            //sehirler1[0] = "Denizli";
            //Console.WriteLine(sehirler2[0]);

            //int sayi1 = 10;
            //int sayi2 = 20;
            //sayi2 = sayi1;
            //sayi1 = 30;
            //Console.WriteLine(sayi2);

            Person person1 = new Person();
            person1.FirstName = "Engin";
            person1.LastName = "Demiroğ";
            person1.DateOfBirthYear = 1985;
            person1.NationalIdentity = 12345678910;

            //Person person2 = new Person();
            //person2.FirstName = "Murat";

            //foreach (string sehir in sehirler1)
            //{
            //    Console.WriteLine(sehir);
            //}

            //List<string> yeniSehirler = new List<string> { "Bilecik", "Zonguldak", "Konya" };
            //yeniSehirler.Add("Gaziantep");
            //foreach (var sehir in yeniSehirler)
            //{
            //    Console.WriteLine(sehir);
            //}

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }

        static void SelamVer(string isim = "isimsiz")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1 = 5, int sayi2 = 10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam: " + sonuc);
            return sonuc;
        }

        private static void Degiskenler()
        {
            string mesaj = "Merhaba";
            double tutar = 100000;
            int sayi = 100;
            bool girisYapmisMi = false;

            string ad = "Engin";
            string soyad = "Demirog";
            int dogumYili = 1985;
            long tcNo = 12345678910;

            Console.WriteLine(tutar * 1.18);
        }
    }

    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }
}