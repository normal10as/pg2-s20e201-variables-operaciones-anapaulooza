Imports System

Module Program
    Sub Main(args As String())
        Dim sg As Single
        Dim dis As ULong
        Console.WriteLine("Ingrese, si es tan amable, un tiempo en segundos. Y que tenga usted muy buen dia")
        sg = Convert.ToSingle(Console.ReadLine())
        dis = Convert.ToUInt64(sg * 300000)
        Console.WriteLine("La distancia recorrida en " & sg & " es de " & dis & " Km")
    End Sub
End Module
