using System;

namespace FacturacionCs
{
    class Program
    {
        static void Main(string[] args)
        {
            string art;
            double costo, util,imp,pre;
            Console.WriteLine("Ingrese Nombre del Articulo");
            art = Console.ReadLine();
            Console.WriteLine("Ingrese Costo del Articulo");
            costo =Convert.ToDouble( Console.ReadLine());
            util = (costo * 150) / 100;
            imp = (costo * 21) / 100;
            pre = util + costo + imp;
            Console.WriteLine("El articulo " + art);
            Console.WriteLine("Tiene: ");
            Console.WriteLine("►Utilidad= " + util);
            Console.WriteLine("►Impuesto= " + imp);
            Console.WriteLine("►Precio de venta= " + pre);
            

        }
    }
}


//Crea un proyecto llamado “Facturación” en el cual se ingresa
//el nombre de un artículo y su costo. La utilidad es del 150 por ciento y 
//el impuesto es el 21 por ciento. Calcular e imprimir artículo, utilidad, impuesto y precio de venta. 