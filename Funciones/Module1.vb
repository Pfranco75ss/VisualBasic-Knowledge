
Module Module1

    Sub Main()

        'Pedimos el alto del triangulo
        Console.WriteLine("Introduzca el alto del triangulo...")
        Dim alto As Integer = CInt(Console.ReadLine)

        'Pedimos el alto del triangulo.
        Console.WriteLine("Introduzca el ancho del triangulo...")
        Dim ancho As Integer = CInt(Console.ReadLine)

        'area(alto, ancho)    'Asi llamamos un procedimiento
        Dim miArea As Double = areaTriangulo(alto, ancho)    'Asi llamamos una funcion

        'Dos formas de imprimir el resultado
        Console.WriteLine("El area de un triangulo es : " & miArea)
        Console.WriteLine("El area de un triangulo es {0} porque su alto es {1} y su ancho es {2} ", miArea, alto, ancho)

        Console.ReadKey()

    End Sub

    'Esto es un procedimiento
    Sub area(al As Integer, an As Integer)

        Dim area As Double = (al * an) / 2
        Console.WriteLine("El area de un triangulo es : " & area)

    End Sub

    'Esto es una funcion
    Function areaTriangulo(al As Integer, an As Integer) As Double

        Dim area As Double = (al * an) / 2
        Return area

    End Function


End Module
