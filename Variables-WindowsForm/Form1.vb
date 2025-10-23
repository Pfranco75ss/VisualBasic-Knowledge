Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Esto es un comentario

        'Declaracion de variables y constantes
        Dim edad As Integer = 25
        Dim edad2 As Integer = 25
        Dim sumaEdades As Integer = edad + edad2
        Dim nombre As String = "Antonio"
        Dim fecha As Date = "31/01/1980"
        Dim adulto As Boolean = True

        'MsgBox("Este es el mensaje")
        MsgBox(sumaEdades)

    End Sub
End Class
