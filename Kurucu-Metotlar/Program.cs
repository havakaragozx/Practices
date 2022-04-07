using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan("Hava", "Karagöz", 107, "Yazılım");
            calisan1.CalisanBilgileri();
            Console.WriteLine("*************");
            Calisan calisan2 = new Calisan("Elif", "Karagöz", 8531, "Eğitim");
            calisan2.CalisanBilgileri();
            Console.WriteLine("*************");
            Calisan calisan3 = new Calisan("Barış", "Karagöz");
            calisan3.CalisanBilgileri();


        }
        class Calisan
        {
            //Property : Özellikler
            public string Ad;
            public string Soyad;
            public int No;
            public string Departman;

            public Calisan()
            {

            }
            public Calisan(string ad, string soyad, int no, string departman)
            {
                this.Ad = ad;
                this.Soyad = soyad;
                this.No = no;
                this.Departman = departman;
            }
            public Calisan(string ad, string soyad)
            {
                this.Ad = ad;
                this.Soyad = soyad;

            }

            public void CalisanBilgileri()
            {
                Console.WriteLine("Çalışan Adı : {0}", Ad);
                Console.WriteLine("Çalışan Soyad : {0}", Soyad);
                Console.WriteLine("Çalışan No : {0}", No);
                Console.WriteLine("Çalışan Departman : {0}", Departman);
            }

        }
    }
}

