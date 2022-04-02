using System;
 
 /*Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
 Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
 Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.*/
namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi;
           
            Console.Write("Lütfen Pozitif bir sayı giriniz : ");
            sayi=Convert.ToInt32(Console.ReadLine());
            int[] sayilar=new int[sayi];
            
            for(int i=0;i<sayi;i++){
             Console.Write((i+1)+ ".sayiyi giriniz: ");
             sayilar[i]=Convert.ToInt32(Console.ReadLine());
            }

            for(int i=0;i<sayilar.Length;i++){
                int cift=sayilar[i]%2;
                if(cift==0){
                    Console.WriteLine("Girilen Çift Sayılar :"+sayilar[i]);
                }
                else {

                }
            }

            

        }
    }
}