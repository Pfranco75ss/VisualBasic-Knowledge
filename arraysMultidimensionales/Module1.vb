Module Module1

    Sub Main()

        'Declaracion de Array
        Dim miArray(2, 2) As String
        miArray(0, 0) = "Antonio"
        miArray(0, 1) = "35"
        miArray(0, 2) = "12345678"

        miArray(1, 0) = "Francisco"
        miArray(1, 1) = "30"
        miArray(1, 2) = "78451296"

        miArray(2, 0) = "Juan"
        miArray(2, 1) = "20"
        miArray(2, 2) = "00000000"


        'Mostramos el valor en la consola
        'Concatenación con el simbolo &
        Console.WriteLine(miArray(2, 0) & " " & miArray(2, 1) & " " & miArray(2, 2))
        Console.Read()


    End Sub

End Module
