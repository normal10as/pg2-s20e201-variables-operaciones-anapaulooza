using System;

namespace EquivalenciasHorasCs
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort hora, dia;
            ulong minuto, seg;
            Console.WriteLine("Ingrese cantidad de horas");
            hora = Convert.ToUInt16(Console.ReadLine());
            dia = Convert.ToUInt16( hora/24 );
            minuto = Convert.ToUInt32(hora*60);
            seg = Convert.ToUInt32(hora*3600);
            Console.WriteLine("La Cantidad de horas ingresadas, equivale a ");
            Console.WriteLine("► "+ dia + " dia(s)");
            Console.WriteLine("► " + minuto + " minutos");
            Console.WriteLine("► " + seg + " segundos");
          
        }
    }
}
//Crea un proyecto llamado “EquivalenciasHoras”
//que lea una cantidad de horas e imprima su equivalente en minutos, segundos y días. 