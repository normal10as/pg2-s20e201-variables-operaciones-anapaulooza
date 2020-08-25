using System;

namespace AreaCirculo.Cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Single r, area;
            Console.WriteLine("Ingrese el radio del circulo en cm. Para decimales, utilice punto");
            r = Convert.ToSingle(Console.ReadLine());
            area = Convert.ToSingle (r * 3.1416);
        Console.WriteLine("El area del Circulo es " + area + " cm");
        }
    }
}
