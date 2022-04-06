using System;
using System.Collections;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı
             listeye atın. (ArrayList sınıfını kullanara yazınız.)
             Negatif ve numeric olmayan girişleri engelleyin.
             Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
             Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
            */
            ArrayList list = new ArrayList();
            ArrayList prime = new ArrayList();
            ArrayList notprime = new ArrayList();
            Manager manager = new Manager();

            Console.WriteLine("20 adet pozitif sayı giriniz: ");
            try
            {
                for (int i = 1; i < 21; i++)
                {
                    Console.Write("{0}.pozitif sayı :" , i);
                    int number = int.Parse(Console.ReadLine());
                    if (number < 0)
                    {
                        Console.WriteLine("Lütfen pozitif bir sayı giriniz.");
                        break;
                    }
                    list.Add(number);

                }
            }
            catch
            {
                Console.WriteLine("Lütfen pozitif bir sayı giriniz.");
            }
            Console.WriteLine("-------------------");
            foreach (int item in list)
            {
                if (item == 1)
                {
                    notprime.Add(item);
                }
                else if (item == 2)
                {
                    prime.Add(item);
                }
                else
                {
                    int primenumber = 0;
                    for (int i = 2; i < item; i++)
                    {
                        if (item % i == 0)
                        {
                            primenumber++;
                        }
                    }
                    if (primenumber == 0)
                    {
                        prime.Add(item);
                    }
                    else
                    {
                        notprime.Add(item);
                    }
                }
            }
            Console.WriteLine("Asal olan sayıların büyükten küçüğe sırılansı: ");
            manager.PrimeProperties(prime);
            Console.WriteLine("Asal olanların eleman sayısı: " + prime.Count);
            manager.Average(prime);
            Console.WriteLine("Asal olmayanların büyükten küçüğe sıralanışı :");
            manager.PrimeProperties(notprime);
            Console.WriteLine("Asal olmayanların eleman  sayısı : " + notprime.Count);
            manager.Average(notprime);
        }
    }

    public class Manager
    {
        public ArrayList PrimeProperties(ArrayList arr)
        {
            arr.Sort();
            arr.Reverse();
            foreach (var item in arr)
            {
                Console.WriteLine(item + " ");
            }
            return arr;
        }
        public ArrayList Average(ArrayList arr)
        {
            int total = 0;
            foreach (int item in arr)
            {
                total += item;
            }
            decimal avg = Convert.ToDecimal(total / arr.Count);
            Console.WriteLine("Average: " + avg);
            return arr;
        }
    }
}