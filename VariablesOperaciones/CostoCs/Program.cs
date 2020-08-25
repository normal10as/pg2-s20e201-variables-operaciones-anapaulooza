using System;
using System.Globalization;

namespace CostoCs
{
    class Program
    {
        static void Main(string[] args)
        {
            String desc;
            int unid, cf;
            decimal costo;
            double factor;
            Console.WriteLine("Ingrese Descripcion ");
            desc = Console.ReadLine();
            Console.WriteLine("Ingrese Numero de Unidades Producidas ");
            unid = Convert.ToInt32( Console.ReadLine());
            const cf = 10700;
            const factor = 3.5;
            costo = Convert.ToDecimal((unid * factor) + cf);
            Console.WriteLine("El articulo "+desc+", cuyas unidades producidas son "+unid+", tiene: ");
            Console.WriteLine("► Costo Fijo de "+cf);
            Console.WriteLine("► Factor de Costo de " + factor);
            Console.WriteLine("► Un Costo Total de " + costo);
        }
    }
}
// Crear un proyecto llamado “Costos” qué calcula imprima el costo de producción 
//de un artículo, teniendo como datos la descripción y el número de unidades producidas.
//El costo se calcula multiplicando el número de unidades producidas por un factor de costo
//de materiales de 3. 5 y sumándole el producto un costo fijo de 10.700. Informar
//todos los datos ingresados junto a los resultados calculados.  
