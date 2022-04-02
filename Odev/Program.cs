using System;
 /*Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
 Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
 Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın..*/
namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pozitif bir sayi giriniz :");
            int n=Convert.ToInt32(Console.ReadLine());
            List<string> kelimeler=new List<string>();
            
            Console.WriteLine("{0} adet kelime giriniz :",n);
            for(int i=0;i<n;i++){
                Console.Write("{0} .Kelimeyi giriniz : ",i+1);              
                string kelime=Console.ReadLine();
                kelimeler.Add(kelime);
                
            }
          int son=kelimeler.Count-1;
          for(int i=son;i>=0;i--){
              Console.WriteLine(kelimeler[i]);
          }
        
        }
    }
}