using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            TohumluBitkiler tohumlubitki = new TohumluBitkiler();        
            tohumlubitki.TohumlaCogalma();

            Console.WriteLine("**************");

            Kuslar marti = new Kuslar();           
            marti.Ucmak();
        }
    }


}