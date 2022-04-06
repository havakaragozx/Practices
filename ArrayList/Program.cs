using System;
using System.Collections;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Collections namespace

            ArrayList liste = new ArrayList();
            /*   liste.Add("Ayse");
               liste.Add(2);
               liste.Add('A');
   */
            //içerisindeki verilere erişim
            /*   Console.WriteLine(liste[1]);
               foreach (var item in liste)
               {
                   Console.WriteLine(item);
               }
               */

            //AddRange 
            Console.WriteLine("**Add Range");
            //  string[] renkler = { "kırmızı", "sarı", "yeşil" };
            List<int> sayilar = new List<int>() { 1, 2, 3, 4, 5 };
            //  liste.AddRange(renkler);
            liste.AddRange(sayilar);
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
            //Sort : sıralama
            Console.WriteLine("**** Sort ****");
            liste.Sort();

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //Binary Search : kacıncı indexte oldugunu getirir.
            Console.WriteLine("**** Binary Search ****");
            Console.WriteLine(liste.BinarySearch(3));
            //Reverse :ortadan aynalıyor.en bastakı en sona , en sondakı en basa
            Console.WriteLine("**** Reverse ****");
            liste.Reverse();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //clear : listeyi temizler.
            liste.Clear();
            

        }
    }
}
