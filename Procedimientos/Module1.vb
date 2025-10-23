Module Module1

    Sub Main()

        encabezado("Bienvenidos .... ")

        'Pedimos el primer factor
        Console.Write("Introduzca el primer factor : ")
        Dim factor1 As Integer = CInt(Console.ReadLine)

        'Pedimos el segundo factor
        Console.Write("Introduzca el segundo factor : ")
        Dim factor2 As Integer = CInt(Console.ReadLine)

        'Console.Clear()
        encabezado("Resultado de la multiplicación...")
        multiplica(factor1, factor2)


    End Sub

    Private Sub multiplica(f1 As Integer, f2 As Integer)

        Dim producto As Integer = f1 * f2
        Console.WriteLine(producto)
        Console.ReadKey()

    End Sub


    Private Sub encabezado(texto As String)

        Console.WriteLine()
        Console.WriteLine("---------------------------------------------")
        Console.WriteLine(texto)
        Console.WriteLine("---------------------------------------------")
        Console.WriteLine()

    End Sub



End Module
