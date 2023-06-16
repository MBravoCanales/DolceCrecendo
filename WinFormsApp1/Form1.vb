Public Class Form1
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureReceta.Click
        Me.Hide()
        Recetario.Show()



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub PictureIngredientes_Click(sender As Object, e As EventArgs) Handles PictureIngredientes.Click
        Me.Hide()
        Ingredientes.Show()


    End Sub

    Private Sub PictureCostos_Click(sender As Object, e As EventArgs) Handles PictureCostos.Click
        Me.Hide()
        Costos.Show()

    End Sub
End Class
