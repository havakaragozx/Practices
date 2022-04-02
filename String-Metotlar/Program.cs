using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz C# , Hoşgeldiniz";
            string degisken2 = "C#";
            //Length : Karakter sayısını verir
            //ToUpper :Tüm karakterleri büyük yapar.
            //ToLower :Tüm karakterleri küçük yapar.
            //Concat : 2 parametre alır.Birleştirme yapar.
            //CompareTo : karşılaştırma yapar. İki degişken aynıysa 0 döndürür.0,1,-1 
            //Compare : true : buyuk kucuk harf duyarsız,false : duyarlı
            //Contains : değişken içinde bulursa true doner.
            //EndWith : değişkendekı deger ne ıle bıttıgını sorgulama
            //IndexOf : Indexini dondurur.Bulamazsa -1 dondurur.
            //Insert : Verilen Indexe verilen string degeri ekler.
            //LastIndexOf : karakterın ındexini getirir.
            //PadLeft, PadRight : verılen int e kadar sonuna karakter ekle
            //Remove : verilen karakterden sonrasını siler.
            //Replace : yer degiştirme yapar.
            //Split: bosluklara gore parcala diziye ata
            //Substring  : 4.indexten basla 6 karakter getir.
            Console.WriteLine(degisken.Length);
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());
            Console.WriteLine(string.Concat(degisken, " Hava Karagöz"));
            Console.WriteLine(degisken.CompareTo(degisken2));
            Console.WriteLine(string.Compare(degisken, degisken2, false));
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz"));
            Console.WriteLine(degisken.StartsWith("Merhaba"));
            Console.WriteLine(degisken.IndexOf("C"));
            Console.WriteLine(degisken.IndexOf("Hava"));
            Console.WriteLine(degisken.Insert(0, "Hava ,"));
            Console.WriteLine(degisken.LastIndexOf("i"));
            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken + degisken2.PadLeft(30, '*'));
            Console.WriteLine(degisken.PadRight(50) + degisken2);
            Console.WriteLine(degisken.PadRight(50, '-') + degisken2);
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(0,1));
            Console.WriteLine(degisken.Remove(5,3));
            Console.WriteLine(degisken.Replace("C#","CSharp"));
            Console.WriteLine(degisken.Replace(" ","*"));
             Console.WriteLine(degisken.Split(' ')[1]);
              Console.WriteLine(degisken.Substring(4,6));
        }
    }
}