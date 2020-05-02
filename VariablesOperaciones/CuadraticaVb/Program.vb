Imports System

Module Program
    Sub Main(args As String())
        Dim a, b, c As UInt16
        Dim d As Double
        Dim res As Single
        a = 1
        b = 5
        c = 2
        d = b ^ 2
        Console.WriteLine("La b es igual a " & d)

        res = Convert.ToSingle((b ^ 2) - (4 * a * c)) / (2 * a)
        Console.WriteLine("La Cuadratica es igual a " & res)

    End Sub
End Module
