using System;
using System.Collections.Generic;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> kullanicilar = new Dictionary<int, string>();
            kullanicilar.Add(10, "Hava Karagöz");
            kullanicilar.Add(12, "Elif Karagöz");

            //Dizinin elemanlarına erişim 
            Console.WriteLine("elemanlara erişim");
            Console.WriteLine(kullanicilar[12]);
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item);
            }

            //Count
            Console.WriteLine(kullanicilar.Count);
            //Contains
            Console.WriteLine(kullanicilar.ContainsKey(9));
            Console.WriteLine(kullanicilar.ContainsValue("Hava Karagöz"));
            //Remove 
            Console.WriteLine("Remove");
            kullanicilar.Remove(12);
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item);
            }

            //Keys 
            Console.WriteLine("Keys");
            foreach (var item in kullanicilar.Keys)
            {
                Console.WriteLine(item);
            }
            //Values
            Console.WriteLine("Values");
            foreach (var item in kullanicilar.Values)
            {
                Console.WriteLine(item);
            }

        }
    }
}