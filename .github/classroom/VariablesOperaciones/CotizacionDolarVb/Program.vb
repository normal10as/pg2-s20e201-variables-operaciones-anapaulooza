Imports System

Module Program
    Sub Main(args As String())
        Dim dolarios, pesolines, tipirijillo As Single
        Console.WriteLine("Ingrese Cantidad de Dolares a comprar. Para decimales utilice punto")
        dolarios = Convert.ToSingle(Console.ReadLine())
        Console.WriteLine("Ingrese Tipo de Cambio en pesos (costo de dolar en pesos). Para decimales utilice punto")
        tipirijillo = Convert.ToSingle(Console.ReadLine())
        pesolines = dolarios * tipirijillo
        Console.WriteLine("la cantidad de Pesos que necesita es " & pesolines)
    End Sub
End Module
