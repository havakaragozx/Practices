using System;
using System.Collections;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan
             ve dizinin elemanlarını sıralayan programı yazınız.
             */

             Console.WriteLine("Bir Cümle yazınız: ");
             string input=Console.ReadLine();
             char[] sesliHarfler={'a','e','i','o','u'};

             List<char> harfler=new List<char>();
             foreach(var item in input){
                 foreach(var sabit in sesliHarfler){
                     if(item==sabit)
                     harfler.Add(item);
                 }
             }
             Console.WriteLine("Cümle içerisindeki sesli harfler : ");
             foreach(var item in harfler){
                 Console.Write(item+" ");
             }
        }
    }

}
