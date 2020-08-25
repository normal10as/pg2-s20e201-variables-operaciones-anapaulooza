using System;

namespace CuadraticaCs
{
    class Program
    {
        static void Main(string[] args)
        {
            const int a=1;
            const int b = 5;
            const int c = 2;
            double d;
            Single res;
            
            d = Math.Pow(b, 2);
            Console.WriteLine("La b es igual a " + d);

            res = Convert.ToSingle(Math.Pow(b, 2) - (4 * a * c)) / (2 * a);
            Console.WriteLine("La Cuadratica es igual a " + res);
        }
    }
}
