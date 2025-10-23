Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Declaraciones de variables
        Dim valor1 As Integer = 3
        Dim valor2 As Integer = 10
        Dim resultado As Double

        'Operamos con las variables
        'resultado = valor1 + valor2 'operador suma
        'resultado = valor1 - valor2 'operador resta
        'resultado = valor1 / valor2 'operador division
        'resultado = valor1 * valor2 'operador multiplicacion
        'resultado = valor1 ^ valor2 'operador exponente

        'resultado = valor1 Mod valor2 'Muestra el resto de la division

        'Sin perdida de valor
        resultado = valor1
        resultado = resultado + 1
        resultado += 1

        'mostramos resultados
        MsgBox(resultado)




    End Sub
End Class
