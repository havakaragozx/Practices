using System;

namespace MyApp
{
    public class NewBaseType
    {
        public static void Main(string[] args)
        {
            string ifade = "Hava Karagöz";
            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine(sonuc);
            if (sonuc)
            Console.WriteLine(ifade.RemoveWhiteSpaces());
          
            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());

            int[] dizi = {4, 7, 2, 9, 3};
            dizi.SortArray();
            dizi.EkranaYazdir();

            int sayi=5;
            Console.WriteLine(sayi.IsEvenNumber());
           
           Console.WriteLine(ifade.GetFirstCharacter());
                   } 
        
    }

        public static class Extension{
          public static bool CheckSpaces(this string param){
             return  param.Contains(" ");      
                 }
        
        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi=param.Split(" ");
            return string.Join("",dizi);
        }
        
        
          public static string MakeUpperCase(this string param)
          {
             return  param.ToUpper();     
          }
          public static string MakeLowerCase(this string param)
          {
             return  param.ToLower();     
          }
          public static int[] SortArray(this int[] param)
          {
            Array.Sort(param);
            return param;
          }
          
          public static void EkranaYazdir(this int[] param){
             foreach(var item in param){
                Console.WriteLine(item);
             }
          }

          public static bool IsEvenNumber(this int param){
             return param%2 == 0;
          }

           public static string GetFirstCharacter(this string param){
             return param.Substring(0,1);
          }
    }

}