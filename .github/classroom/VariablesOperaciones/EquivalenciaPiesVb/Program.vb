Imports System

Module Program
    Sub Main(args As String())
        Dim dedos, pulgas, yerba, ciempies, mangos As Single

        Console.WriteLine("Ingrese una Distancia en pies. Para decimales, utilice punto")
        dedos = Convert.ToSingle(Console.ReadLine())
        pulgas = dedos * 12
        yerba = dedos / 3
        ciempies = Convert.ToSingle(dedos * 30.48)
        mangos = Convert.ToSingle(dedos / 3.281)
        Console.WriteLine("Las equivalencias de " & dedos & " pies son")
        Console.WriteLine("-> " & pulgas & " pulgadas")
        Console.WriteLine("-> " & yerba & " yardas")
        Console.WriteLine("-> " & ciempies & " centimetros")
        Console.WriteLine("-> " & mangos & " metros")
    End Sub
End Module
