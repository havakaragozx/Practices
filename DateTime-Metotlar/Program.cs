using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);
            Console.WriteLine(DateTime.Now.ToLongDateString()); //tarih uzun format
            Console.WriteLine(DateTime.Now.ToShortDateString()); //tarih kısa format

            //Format - DateTime

            Console.WriteLine(DateTime.Now.ToString("dd")); //24 
            Console.WriteLine(DateTime.Now.ToString("ddd"));  //Sat
            Console.WriteLine(DateTime.Now.ToString("dddd"));  //Saturday

            //Math kütüphanesi
            Console.WriteLine(Math.Abs(-25)); //25
            Console.WriteLine(Math.Sin(10)); //Sinüs verir. Cos ve Tan da mevcut.
            Console.WriteLine(Math.Ceiling(22.3)); //küsüratı  en kucuk tam sayıyı getirir 23

            Console.WriteLine(Math.Max(2, 5));
            Console.WriteLine(Math.Pow(3, 4));
            Console.WriteLine(Math.Sqrt(9));
            Console.WriteLine(Math.Log(9));
            Console.WriteLine(Math.Exp(3)); //e üzeri 3 verir.


        }
    }
}