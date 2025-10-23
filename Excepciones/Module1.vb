Module Module1

    Sub Main()

        Dim dividendo As Integer
        Dim divisor As Integer
        Dim repite As Boolean = True

        Do While repite
            Try
                Console.Clear()
                Console.WriteLine("Introduzca el dividendo...")
                dividendo = Console.ReadLine

                Console.WriteLine("Introduzca el divisor...")
                dividendo = CInt(Console.ReadLine)
                repite = False

                'Obteniendo la excepcion que nos indica el Visual
                'Catch ex As Exception
                'Console.WriteLine(ex.GetBaseException)
                'Console.WriteLine()
                'Console.WriteLine("Ha ocurrido un error : " & ex.Message)
                'Console.WriteLine("Vuelva a introducir los datos ")
                'Console.ReadKey()

                'Se indica los errores o excepciones especificas
            Catch ex As System.OverflowException
                Console.WriteLine("Ha ocurrido un error, se introdujo un valor desiado grande")
                Console.ReadKey()
            Catch ex As System.InvalidCastException
                Console.WriteLine("Ha ocurrido un error, imposible convertir letras en numeros")
                Console.ReadKey()

            Finally
                Console.WriteLine("Estas lineas se ejecutan siempre")
                Console.ReadKey()
            End Try

            'System.FormatException
            'System.OverflowException


        Loop

        Console.WriteLine("El cociente de la división es : {0}", dividir(dividendo, divisor))
        Console.ReadKey()

    End Sub

    Function dividir(ByVal num1 As Integer, ByVal num2 As Integer) As Double

        Dim resultado As Double
        resultado = num1 / num2
        Return resultado


    End Function

End Module
