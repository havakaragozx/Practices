using System;
/*Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
 Cümledeki toplam kelime ve harf sayısını console'a yazdırın..*/
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir cümle yazınız : ");
            string cumle = Console.ReadLine();
            string liste = "ABCÇDEFGĞHİIJKLMNOÖPRSŞTUÜVYZ"
                      + "abcçdefgğhiıjklmnoöprsştuüvyz";

            string[] kelimeler = cumle.Split(' ');
            Console.WriteLine("Kelime sayısı : " + kelimeler.Length);

            int sayac = 0;
            for (int i = 0; i < cumle.Length; i++)
            {
                if (liste.Contains(cumle[i]))
                {
                    sayac++;
                }
            }
            Console.WriteLine("toplam {0} tane  harf vardır.", sayac);
            Console.ReadLine();


        }
    }
}