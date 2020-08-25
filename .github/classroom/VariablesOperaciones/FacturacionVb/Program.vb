Imports System

Module Program
    Sub Main(args As String())
        Dim art As String
        Dim costo, util, imp, pre As Double
        Console.WriteLine("Ingrese Nombre del Articulo")
        art = Console.ReadLine()
        Console.WriteLine("Ingrese Costo del Articulo")
        costo = Convert.ToDouble(Console.ReadLine())
        util = (costo * 150) / 100
        imp = (costo * 21) / 100
        pre = util + costo + imp
        Console.WriteLine("El articulo " & art)
        Console.WriteLine("Tiene: ")
        Console.WriteLine("->Utilidad= " & util)
        Console.WriteLine("->Impuesto= " & imp)
        Console.WriteLine("->Precio de venta= " & pre)
    End Sub
End Module
