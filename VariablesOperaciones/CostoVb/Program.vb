Imports System

Module Program
    Sub Main(args As String())
        Dim desc As String
        Dim unid, cf As UShort
        Dim costo As Decimal
        Dim factor As Double
        Console.WriteLine("Ingrese Descripcion ")
        desc = Console.ReadLine()
        Console.WriteLine("Ingrese Numero de Unidades Producidas ")
        unid = Convert.ToInt32(Console.ReadLine())
        const cf = 10700
        const factor = 3.5
        costo = Convert.ToDecimal((unid * factor) + cf)
        Console.WriteLine("El articulo " & desc & ", cuyas unidades producidas son " & unid & ", tiene: ")
        Console.WriteLine("-> Costo Fijo de " & cf)
        Console.WriteLine("-> Factor de Costo de " & factor)
        Console.WriteLine("-> Un Costo Total de " & costo)
    End Sub
End Module
