Imports System

Module Program
    Sub Main(args As String())
        Dim hora, dia As UShort
        Dim minuto, seg As ULong
        Console.WriteLine("Ingrese cantidad de horas")
        hora = Convert.ToUInt16(Console.ReadLine())
        dia = Convert.ToUInt16(hora / 24)
        minuto = Convert.ToUInt32(hora * 60)
        seg = Convert.ToUInt32(hora * 3600)
        Console.WriteLine("La Cantidad de horas ingresadas, equivale a ")
        Console.WriteLine("-> " & dia, " dia(s)")
        Console.WriteLine("-> " & minuto, " minutos")
        Console.WriteLine("-> " & seg, " segundos")
    End Sub
End Module
