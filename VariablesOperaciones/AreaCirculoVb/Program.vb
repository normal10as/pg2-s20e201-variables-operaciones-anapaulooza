Imports System

Module Program
    Sub Main(args As String())
        Dim r, area As Single
        Console.WriteLine("Ingrese el radio del circulo en cm. Para decimales, utilice punto")
        r = (Console.ReadLine())
        area = r * 3.1416
        Console.WriteLine("El area del Circulo es " & area)
    End Sub
End Module
