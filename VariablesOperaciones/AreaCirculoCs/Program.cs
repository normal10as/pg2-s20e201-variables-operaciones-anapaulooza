using System;

namespace AreaCirculoCs
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, area;
            Console.WriteLine("Ingrese el radio del circulo en cm. Para decimales, utilice punto");
            r = Convert.ToDouble(Console.ReadLine());
            area = r * 3.1416;
            Console.WriteLine("El area del Circulo es " + area);
        }
    }
}
//1.9. Crea un proyecto llamado “ÁreaCirculo” donde se ingresa
//el radio del círculo, imprime el área. 𝐴𝑟𝑒𝑎 = 𝜋𝑟  