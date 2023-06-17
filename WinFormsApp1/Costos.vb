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
        ' Clonar el GroupBox y sus TextBox
        Dim nuevoGroupBox As GroupBox = CloneGroupBox(GroupBox1)

        ' Ajustar la posición del nuevo GroupBox debajo del anterior
        Dim posicionY As Integer = GroupBox1.Location.Y + GroupBox1.Height + 10 ' Ajusta la distancia vertical según tu diseño
        Dim posicionX As Integer = GroupBox1.Location.X
        nuevoGroupBox.Location = New Point(posicionX, posicionY)

        ' Incrementar el contador para el siguiente GroupBox
        contador += 1

        ' Cambiar los nombres de los TextBox dentro del nuevo GroupBox para reflejar el contador
        For Each control As Control In nuevoGroupBox.Controls
            If TypeOf control Is TextBox Then
                Dim textBox As TextBox = CType(control, TextBox)
                textBox.Name = textBox.Name.Substring(0, textBox.Name.Length - 1) & contador.ToString()
            End If
        Next

        ' Asignar los eventos para los TextBox del nuevo GroupBox
        AddHandler nuevoGroupBox.Controls("txtCantidad" & contador.ToString()).TextChanged, AddressOf CalcularValor
        AddHandler nuevoGroupBox.Controls("txtCoste" & contador.ToString()).TextChanged, AddressOf CalcularValor

        ' Agregar el nuevo GroupBox al formulario
        Me.Controls.Add(nuevoGroupBox)
    End Sub

    Private Sub CalcularValor(sender As Object, e As EventArgs)
        Dim textBox As TextBox = CType(sender, TextBox)
        Dim groupName As String = textBox.Name.Substring(0, textBox.Name.Length - 1)

        Dim cantidad As Double = Double.Parse(CType(Me.Controls(groupName & "Cantidad" & contador.ToString()), TextBox).Text)
        Dim coste As Double = Double.Parse(CType(Me.Controls(groupName & "Coste" & contador.ToString()), TextBox).Text)

        Dim valor As Double = coste / cantidad

        CType(Me.Controls(groupName & "Valor" & contador.ToString()), TextBox).Text = valor.ToString()
    End Sub

    Private Function CloneGroupBox(originalGroupBox As GroupBox) As GroupBox
        ' Crear un nuevo GroupBox clonado
        Dim nuevoGroupBox As New GroupBox()
        nuevoGroupBox.Size = originalGroupBox.Size
        nuevoGroupBox.Text = originalGroupBox.Text

        ' Clonar los TextBox del GroupBox original
        For Each control As Control In originalGroupBox.Controls
            If TypeOf control Is TextBox Then
                Dim originalTextBox As TextBox = CType(control, TextBox)

                ' Crear un nuevo TextBox clonado
                Dim nuevoTextBox As New TextBox()
                nuevoTextBox.Name = originalTextBox.Name
                nuevoTextBox.Size = originalTextBox.Size
                nuevoTextBox.Location = originalTextBox.Location
                nuevoTextBox.Text = originalTextBox.Text

                ' Copiar las propiedades de comportamiento del TextBox original al clonado
                nuevoTextBox.Multiline = originalTextBox.Multiline
                nuevoTextBox.ReadOnly = originalTextBox.ReadOnly
                nuevoTextBox.Enabled = originalTextBox.Enabled
                nuevoTextBox.ScrollBars = originalTextBox.ScrollBars

                ' Agregar el nuevo TextBox al GroupBox clonado
                nuevoGroupBox.Controls.Add(nuevoTextBox)
            End If
        Next

        Return nuevoGroupBox
    End Function


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