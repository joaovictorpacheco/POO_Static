using System;
using POOStatic.classes;

namespace POOStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( Conversor.EuroParaReais(62) );
            Console.WriteLine( Conversor.RealParaEuro(62) );
        }
    }
}
