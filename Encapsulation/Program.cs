using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kapsülleme : Bir nesnenin bazı ozellıklerını diğer classlardan /nesnelerden korumak anlamına geliyor.
            Ogrenci ogrenci1 = new Ogrenci("Hava", "Karagöz", 293, 4);
            ogrenci1.SinifAtlat();
            ogrenci1.OgrenciBilgileriGetir();

            Ogrenci ogrenci2=new Ogrenci("Deniz","Arda",250,1);
            ogrenci2.SinifDusur();
            ogrenci2.SinifDusur();
            ogrenci2.OgrenciBilgileriGetir();
        }
    }
    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim { get => isim; set => isim = value; } //get ismi return  ediyor , set isme value atıyor.
        /*
           get { return isim; }
           set { isim=value;  }
       */
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif
        {
            get => sinif;
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Sınıf en az 1 olabilir");
                }
                else
                    sinif = value;
            }
        }

        public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = isim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }
        public Ogrenci()
        {

        }
        public void OgrenciBilgileriGetir()
        {
            Console.WriteLine("***Öğrenci Bilgileri***");
            Console.WriteLine("Öğrenci Adı : {0}", this.Isim);
            Console.WriteLine("Öğrenci SoyAdı : {0}", this.Soyisim);
            Console.WriteLine("Öğrenci No : {0}", this.OgrenciNo);
            Console.WriteLine("Öğrenci Sınıf : {0}", this.Sinif);
        }
        public void SinifAtlat()
        {
            this.Sinif = this.Sinif + 1;
        }
        public void SinifDusur()
        {
            this.Sinif = this.Sinif - 1;
        }
    }
}