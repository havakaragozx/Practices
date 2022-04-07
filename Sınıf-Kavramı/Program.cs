using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Erişim Belirleyiciler
               Public : heryerden erişilebilir
               Private : sadece tanımlandıgı sınıf ıcerısınde erişilebilir
               Internal : kendı bulundugu proje ıcınde erişilebilir 
               Protected : sadece tanımlandıgı sınıfta veya o sınıftan miras alan sınıflardan erişilebilir. */
            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Hava";
            calisan1.Soyad = "Karagöz";
            calisan1.No = 107;
            calisan1.Departman = "Yazılım";

            calisan1.CalisanBilgileri();
            Console.WriteLine("*************");
            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Elif";
            calisan2.Soyad = "Karagöz";
            calisan2.No = 8531;
            calisan2.Departman = "Eğitim";

            calisan2.CalisanBilgileri();




        }
        class Calisan
        {
            //Property : Özellikler
            public string Ad;
            public string Soyad;
            public int No;
            public string Departman;
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