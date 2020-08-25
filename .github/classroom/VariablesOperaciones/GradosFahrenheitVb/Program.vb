Imports System

Module Program
    Sub Main(args As String())
        Dim c, f As Single
        Console.WriteLine("Ingrese temperatura en Grados Celsius. Para decimales utilice punto. ")
        c = Convert.ToDouble(Console.ReadLine())
        f = ((c * 9 / 5) + 32)
        Console.WriteLine("El equivalente es de " & f, "Grados Fahrenheit")
    End Sub
End Module
