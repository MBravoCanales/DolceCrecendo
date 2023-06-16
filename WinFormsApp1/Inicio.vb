Public Class Inicio
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureReceta.Click
        Me.Hide()
        Recetario.Show()



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnSalirInicio.Click
        Me.Close()

    End Sub

    Private Sub PictureIngredientes_Click(sender As Object, e As EventArgs) Handles PictureProduccion.Click
        Me.Hide()
        Produccion.Show()


    End Sub

    Private Sub PictureCostos_Click(sender As Object, e As EventArgs) Handles PictureCostos.Click
        Me.Hide()
        Costos.Show()

    End Sub
End Class
