using System;

namespace CotizacionDolarCs
{
    class Program
    {
        static void Main(string[] args)
        {
            Single dolarios, pesolines, tipirijillo;
            Console.WriteLine("Ingrese Cantidad de Dolares a comprar. Para decimales utilice punto");
            dolarios = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Ingrese Tipo de Cambio en pesos (costo de dolar en pesos). Para decimales utilice punto");
            tipirijillo = Convert.ToSingle(Console.ReadLine());
            pesolines = dolarios * tipirijillo;
            Console.WriteLine("la cantidad de Pesos que necesita es "+pesolines);

        }
    }
}
//Crea un proyecto llamado “CotizaciónDólar” el cual se ingresa la cantidad de dólares
//que se va a comprar y el tipo de cambio en pesos (costó de un dólar en pesos)
//Calcular e imprimir la cantidad que se debe pagar en pesos por la cantidad de dólares indicada