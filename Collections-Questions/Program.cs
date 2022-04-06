using System;
using System.Collections;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi 
            ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan 
            ve bu ortalamaları ve ortalama toplamlarını
             console'a yazdıran programı yazınız. 
             (Array sınıfını kullanarak yazınız.)*/


            int[] sayilar = new int[20];
            int[] minSayilar = new int[3];
            int[] maxSayilar = new int[3];

            Console.WriteLine("20 adet pozitif sayı giriniz: ");

            for (int i = 0; i < 20; i++)
            {
                Console.Write("{0}.pozitif sayı :", i+1);
                sayilar[i] = int.Parse(Console.ReadLine());

            }
            Array.Sort(sayilar);
            double minSayac = 0;

            for (int i = 0; i < 3; i++)
            {
                minSayilar[i] = sayilar[i];
            }
            Console.WriteLine("Dizinin en küçük elemanları: ");
            foreach (var item in minSayilar)
            {
                Console.WriteLine(item);
                minSayac += item;
            }

            Array.Reverse(sayilar);
            double maxSayac = 0;
            for (int i = 0; i < 3; i++)
            {
                maxSayilar[i] = sayilar[i];
            }
            Console.WriteLine("Dizinin en büyük elemanları: ");
            foreach (var item in maxSayilar)
            {
                Console.WriteLine(item);
                maxSayac += item;
            }

            double minAvg = minSayac / 3;
            double maxAvg = maxSayac / 3;

            Console.WriteLine("Küçük dizinin ortalamasi : " + minAvg);
            Console.WriteLine("Büyük dizinin ortalamasi : " + maxAvg);
            Console.WriteLine("Büyük ve Küçük dizinin ortalamaları toplamı: " + (minAvg + maxAvg));



        }
    }

}
