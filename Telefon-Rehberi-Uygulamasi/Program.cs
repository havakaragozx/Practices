using System;

namespace TelefonRehberi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Kisi> kisiler = new List<Kisi>(){
              new Kisi(){ Isim="Hava",Soyisim="Karagöz",TelefonNo="1111111111" },
              new Kisi(){Isim="Elif",Soyisim="Karagöz",TelefonNo="2222222222"},
              new Kisi(){Isim="Barış",Soyisim="Karagöz",TelefonNo="33333333333"}
          };

            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz ");
            Console.WriteLine("**************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek ");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemekk");
            Console.WriteLine("(5) Rehberde Arama Yapmak");

            Console.WriteLine("Yapmak istediğiniz işlem sırasını giriniz : ");
            int deger = Convert.ToInt16(Console.ReadLine());
            switch (deger)
            {

                case 1:
                    Rehber.Kaydet(kisiler);
                    break;

                case 2:
                    Rehber.Sil(kisiler);
                    break;

                case 3:
                    Rehber.Güncelleme(kisiler);
                    break;

                case 4:
                    Rehber.RehberListeleme(kisiler);
                    break;

                case 5:
                    Rehber.RehberdeArama(kisiler);
                    break;


            }
            System.Console.WriteLine("Gerçekleştirdiğiniz işlem başarıyla tamamlanmıştır..");
        }
    }
}