Module Module1

    Sub Main()

        Dim miPromedio As Integer = promedio(10, 50)

        Dim miPromedio2 As Integer = promedio(60, 452, 41, 58, 20)

        'Ejemplo del array
        Dim miArray() As Integer = {1, 2, 3}
        Dim miSuma As Integer = array(miArray)

        Console.WriteLine("El promedio de promedio1 es {0}", miPromedio)
        Console.WriteLine("El promedio de promedio2 es {0}", miPromedio2)

        Console.ReadKey()

    End Sub

    Function suma(ByVal num1 As Integer, ByVal num2 As Integer, Optional num3 As Integer = 2) As Integer

        Dim miSuma As Integer = num1 + num2 + num3
        Return miSuma

    End Function

    'Ejemplo que se envia un array
    Function array(ByVal num1() As Integer) As Integer

    End Function

    Function promedio(ParamArray ByVal nums() As Integer) As Integer

        Dim resultado As Integer = 0
        For i As Integer = 0 To nums.Count - 1
            resultado += nums(i)
        Next

        Return resultado / nums.Count

    End Function


End Module
