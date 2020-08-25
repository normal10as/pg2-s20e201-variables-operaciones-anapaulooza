Imports System

Module Program
    Sub Main(args As String())
        Dim ancho, larg, area, costo, costo2 As Decimal

        Console.WriteLine("Ingrese ancho de terreno, para decimales utilice punto ")
        ancho = Convert.ToDecimal(Console.ReadLine())
        Console.WriteLine("Ingrese largo de terreno, para decimales utilice punto ")
        larg = Convert.ToDecimal(Console.ReadLine())
        area = ancho * larg
        Console.WriteLine("Ingrese Costo del M2, para decimales utilice punto ")
        costo2 = Convert.ToDecimal(Console.ReadLine())
        costo = costo2 * area
        Console.WriteLine("El costo del terreno es de  " + (costo))
    End Sub
End Module
