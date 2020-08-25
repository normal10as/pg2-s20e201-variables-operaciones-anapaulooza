using System;
using System.Dynamic;

namespace VelocidadDeLaLuzCs
{
    class Program
    {
        static void Main(string[] args)
        {

            Single sg;
            ulong dis;
            Console.WriteLine("Ingrese, si es tan amable, un tiempo en segundos. Y que tenga usted muy buen dia");
            sg = Convert.ToSingle(Console.ReadLine());
            dis = Convert.ToUInt64 (sg * 300000);
            Console.WriteLine("La distancia recorrida en "+ sg +" es de "+dis+" Km");
        }
    }
}
//Crear un proyecto llamado “VelocidadDeLaLuz”. Teniendo en cuenta que la velocidad de
//la luz 300.000 kilómetros por segundo, elaborar un algoritmo que lea un tiempo en segundos
//imprima la distancia que recorre la luz en dicho tiempo. 