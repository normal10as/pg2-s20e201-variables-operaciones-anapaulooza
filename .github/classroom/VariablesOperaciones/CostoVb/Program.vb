Imports System

Module Program
    Sub Main(args As String())
        Dim desc As String
        Dim unid As UShort
        Dim costo As Decimal
        Const cf = 10700
        Const factor = 3.5
        Console.WriteLine("Ingrese Descripcion ")
        desc = Console.ReadLine()
        Console.WriteLine("Ingrese Numero de Unidades Producidas ")
        unid = Convert.ToInt32(Console.ReadLine())


        costo = Convert.ToDecimal((unid * factor) + cf)
        Console.WriteLine("El articulo " & desc & ", cuyas unidades producidas son " & unid & ", tiene: ")
        Console.WriteLine("-> Costo Fijo de " & cf)
        Console.WriteLine("-> Factor de Costo de " & factor)
        Console.WriteLine("-> Un Costo Total de " & costo)
    End Sub
End Module
