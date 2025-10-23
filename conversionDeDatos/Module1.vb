Module Module1

    Sub Main()

        Console.WriteLine("Bienvenidos")
        Console.WriteLine("Introduzca el primer sumando...")

        'Obtenemos el dato introducido por el usuario
        Dim sumando1 As Integer
        'Dim sumando1 As String
        'sumando1 = Console.ReadLine()
        sumando1 = CInt(Console.ReadLine()) 'De esta forma solicitamos que el valor que mande sea numero

        Console.WriteLine("Introduzca el segundo sumando...")
        'Dim sumando2 As Integer = Console.ReadLine()
        Dim sumando2 As Integer = CInt(Console.ReadLine())
        'Dim sumando2 As String = Console.ReadLine()

        'El comando cInt convierte el texto a numero para que sea posible efectuar la operacion numerica
        Console.WriteLine("El resultado es: " & sumando1 + sumando2)
        'Console.WriteLine("El resultado es: " & CInt(sumando1) + CInt(sumando2))
        Console.ReadLine()

    End Sub

End Module
