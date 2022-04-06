using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List sınıfı 
            //List<T> class
            //System.Collections.Generic
            //T -> object türündedir.

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(3);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");

            //Count : eleman sayısını getirir.
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            //Foreach ve List.Foreach ile elemanlara erişim
            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }

            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }
            //Listeden eleman cıkarma
            sayiListesi.Remove(10);
            renkListesi.Remove("Turuncu");

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Liste içerisinde arama
            if (sayiListesi.Contains(3))
                Console.WriteLine("liste içerisinde bulundu");

            //Eleman ile indekse erişme
            Console.WriteLine(renkListesi.BinarySearch("Kırmızı"));

            //Diziyi List'e çevirme
            string[] hayvanlar = { "Kedi", "Köpek", "Kuş" };
            List<string> hayvan = new List<string>(hayvanlar);

            //Listeyi temizleme
            hayvan.Clear();

            //List içerisinde nesne tutmak
            List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();
            Kullanicilar kullanici1 = new Kullanicilar();
            kullanici1.Isim = "Ayse";
            kullanici1.Soyisim = "Yilmaz";
            kullanici1.Yas = 26;

            kullaniciListesi.Add(kullanici1);

            List<Kullanicilar> yeniListe = new List<Kullanicilar>();
            yeniListe.Add(new Kullanicilar()
            {
                Isim = "Hava",
                Soyisim = "Karagöz",
                Yas = 27
            });

            foreach (var kullanici in kullaniciListesi)
            {
                Console.WriteLine("Kullanıcı Adı : " + kullanici.Isim);
                Console.WriteLine("Kullanıcı soyAdı : " + kullanici.Soyisim);
                Console.WriteLine("Kullanıcı Yas : " + kullanici.Yas);
            }
            yeniListe.Clear();

        }
    }

    public class Kullanicilar
    {
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}