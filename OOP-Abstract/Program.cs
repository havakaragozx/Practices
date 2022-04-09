using System;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********INTERFACE************");
            Focus focus = new Focus();
            Console.WriteLine(focus.HangiMarkaninAraci().ToString());
            Console.WriteLine(focus.KacTekerlektenOlusur().ToString());
            Console.WriteLine(focus.StandartRengiNe().ToString());
            Console.WriteLine("**********INTERFACE************");
            Civic civic = new Civic();
            Console.WriteLine(civic.HangiMarkaninAraci().ToString());
            Console.WriteLine(civic.KacTekerlektenOlusur().ToString());
            Console.WriteLine(civic.StandartRengiNe().ToString());
            Console.WriteLine("***********ABSTRACT***********");
            NewFocus newFocus = new NewFocus();
            Console.WriteLine(newFocus.HangiMarkaninAraci().ToString());
            Console.WriteLine(newFocus.KacTekerlektenOlusur().ToString());
            Console.WriteLine(newFocus.StandartRengiNe().ToString());
            Console.WriteLine("***********ABSTRACT***********");
            Civic Newcivic = new Civic();
            Console.WriteLine(Newcivic.HangiMarkaninAraci().ToString());
            Console.WriteLine(Newcivic.KacTekerlektenOlusur().ToString());
            Console.WriteLine(Newcivic.StandartRengiNe().ToString());
        }
    }
}