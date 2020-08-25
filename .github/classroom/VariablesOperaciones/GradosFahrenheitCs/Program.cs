using System;

namespace GradosFahrenheitCs
{
    class Program
    {
        static void Main(string[] args)
        {
            double c, f;
            Console.WriteLine("Ingrese temperatura en Grados Celsius. Para decimales utilice punto. ");
            c = Convert.ToDouble(Console.ReadLine());
            f = ((c * 9 / 5) + 32);
            Console.WriteLine("El equivalente es de "+f ,"Grados Fahrenheit");
        }
    }
}
//Crea un proyecto llamado “GradosFahrenheit” donde se ingresa la temperatura en Celsius y
//se muestra su equivalente en fahrenheit. Investigar la fórmula necesaria para realizar el cálculo.  