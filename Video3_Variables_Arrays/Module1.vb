Module Module1

    Sub Main()


        'Declaración de variables
        'Dim miVariable As String = "Hola mundo"

        'Mostramos el mensaje
        'Console.WriteLine(miVariable)
        'Console.ReadKey()

        'Declaración de Array con valores
        'Dim miArray() As String = {"Antonio", "Francisco", "Juan"}

        'Mostramos el valor de la consola
        'Console.WriteLine(miArray(1))
        'Console.Read()

        'Declaración de Array
        Dim miArray(2) As String
        miArray(0) = "Antonio"
        miArray(1) = "Francisco"
        miArray(2) = "Juan"

        'Con Dim podemos dimensionar, pero con ReDim podemos redimensionar
        'con el Preserve conservara los elementos y desechara los que hemos acortado
        ReDim Preserve miArray(1)

        'Mostramos el valor de la consola
        Console.WriteLine(miArray(0))
        Console.Read()

    End Sub

End Module
