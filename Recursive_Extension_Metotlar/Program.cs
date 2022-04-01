using System;

namespace MyApp 
{
    internal class Program
    {
      public  static  void Main(string[] args)
        {
            //Rekürsif - Öz yinelemeli fonksiyonlar
            int result=1;
            for(int i=1;i<5;i++){
             result=result*3;
             Console.WriteLine(result);
            }
        }
    }
}