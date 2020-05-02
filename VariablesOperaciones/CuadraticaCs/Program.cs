using System;

namespace CuadraticaCs
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double d;
            Single res;
            a = 1;
            b = 5;
            c = 2;
            d = Math.Pow(b, 2);
            Console.WriteLine("La b es igual a " + d);

            res = Convert.ToSingle(Math.Pow(b, 2) - (4 * a * c)) / (2 * a);
            Console.WriteLine("La Cuadratica es igual a " + res);
        }
    }
}
