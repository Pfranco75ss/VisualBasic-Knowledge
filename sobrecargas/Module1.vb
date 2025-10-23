Module Module1

    Sub Main()

        Dim resultado As Double = promedio(8, 4.5, 5)
        Console.WriteLine(resultado)
        Console.ReadKey()

    End Sub

    Function promedio(ByVal num1 As Integer, ByVal num2 As Integer) As Double

        Return (num1 + num2) / 2

    End Function

    Function promedio(ByVal num1 As Integer, ByVal num2 As Integer, ByVal num3 As Integer) As Double

        Return (num1 + num2 + num3) / 3

    End Function

    Function promedio(ByVal num1 As Double, ByVal num2 As Integer, ByVal num3 As Integer) As Double

        Return (num1 + num2 + num3) / 3

    End Function

    Function promedio(ByVal num1 As Integer, ByVal num2 As Double, ByVal num3 As Integer) As Double

        Return (num1 + num2 + num3) / 3

    End Function

End Module
