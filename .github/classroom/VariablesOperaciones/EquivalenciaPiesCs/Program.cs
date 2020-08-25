using System;

namespace EquivalenciaPiesCs
{
    class Program
    {
        static void Main(string[] args)
        {
            Single dedos, pulgas, yerba, ciempies, mangos;
          
            Console.WriteLine("Ingrese una Distancia en pies. Para decimales, utilice punto");
            dedos = Convert.ToSingle(Console.ReadLine());
            pulgas = dedos * 12;
            yerba = dedos / 3;
            ciempies = Convert.ToSingle(dedos * 30.48);
            mangos = Convert.ToSingle(dedos / 3.281);
            Console.WriteLine("Las equivalencias de "+dedos, " pies son");
            Console.WriteLine("► " + pulgas + " pulgadas");
            Console.WriteLine("► " + yerba + " yardas");
            Console.WriteLine("► " + ciempies +  " centimetros");
            Console.WriteLine("► " + mangos + " metros");
        }
    }
}
//Crear un proyecto llamado “EquivalenciasPies”. Se debe ingresar una distancia
//medidas en pies y calcular su equivalente en pulgadas, yarda, cms y metros. 
//Utilizar únicamente las equivalencias conocidas: 1 pie = 12 pulgadas, 1 yarda = 3 pies,
//1 pulgada = 2.54 cm, 1 metro = 100 cm.