using System;
namespace metotlar_overloading {
    class Program{
        static void Main(string[] args){
//Rekürsif - Öz yinelemeli fonksiyonlar
            int result=1;
            for(int i=1;i<5;i++)
             result=result*3;
             Console.WriteLine(result); 
             Islemler instance=new();
             Console.WriteLine(instance.Expo(3,4));

        }
    }

    public class Islemler{
        public int Expo(int sayi,int üs){
            if(üs<2) 
            return sayi;
            return Expo(sayi,üs-1)*sayi;
            //Expo(3,4)
            //Expo(3,3)*3
            //Expo(3,2)*3*3;
            //Expo(3,1)*3*3*3;
            //3*3*3*3=3^4
        }
    }
}