Imports System

Module Program
    Sub Main(args As String())

        Const a = 1
        Const b = 5
        Const c = 2
        Dim d As Double
        Dim res As Single

        d = b ^ 2
        Console.WriteLine("La b es igual a " & d)

        res = Convert.ToSingle((b ^ 2) - (4 * a * c)) / (2 * a)
        Console.WriteLine("La Cuadratica es igual a " & res)

    End Sub
End Module
