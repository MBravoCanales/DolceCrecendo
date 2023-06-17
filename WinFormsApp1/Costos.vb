Public Class Costos
    Private contador As Integer = 1 ' Variable contador para el número de group boxes generados
    Private Sub Ingredientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Inicio.Show()


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txtValor1.TextChanged


    End Sub

    Private Sub txtCoste1_TextChanged(sender As Object, e As EventArgs) Handles txtCoste1.TextChanged
        Dim cantidad As Double = Double.Parse(txtCantidad1.Text)
        Dim coste As Double = Double.Parse(txtCoste1.Text)

        Dim valor As Double = coste / cantidad

        txtValor1.Text = valor.ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class