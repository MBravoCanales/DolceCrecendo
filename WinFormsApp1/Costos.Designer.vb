<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Costos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        txtIngrediente1 = New TextBox()
        txtCantidad1 = New TextBox()
        txtCoste1 = New TextBox()
        txtValor1 = New TextBox()
        Button1 = New Button()
        Button5 = New Button()
        Button2 = New Button()
        Button4 = New Button()
        Label5 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(638, 102)
        Label4.Name = "Label4"
        Label4.Size = New Size(116, 15)
        Label4.TabIndex = 3
        Label4.Text = "Valor (unidad/gr/ml)"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(515, 102)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 15)
        Label3.TabIndex = 2
        Label3.Text = "Coste de compra"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(310, 102)
        Label2.Name = "Label2"
        Label2.Size = New Size(183, 15)
        Label2.TabIndex = 1
        Label2.Text = "Cantidad (unidad/gramo/militro)"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(105, 102)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 15)
        Label1.TabIndex = 0
        Label1.Text = "Ingrediente"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtIngrediente1)
        GroupBox1.Controls.Add(txtCantidad1)
        GroupBox1.Controls.Add(txtCoste1)
        GroupBox1.Controls.Add(txtValor1)
        GroupBox1.Location = New Point(105, 120)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(661, 45)
        GroupBox1.TabIndex = 9
        GroupBox1.TabStop = False
        ' 
        ' txtIngrediente1
        ' 
        txtIngrediente1.Location = New Point(6, 15)
        txtIngrediente1.Name = "txtIngrediente1"
        txtIngrediente1.Size = New Size(186, 23)
        txtIngrediente1.TabIndex = 4
        ' 
        ' txtCantidad1
        ' 
        txtCantidad1.Location = New Point(209, 15)
        txtCantidad1.Name = "txtCantidad1"
        txtCantidad1.Size = New Size(183, 23)
        txtCantidad1.TabIndex = 5
        ' 
        ' txtCoste1
        ' 
        txtCoste1.Location = New Point(410, 15)
        txtCoste1.Name = "txtCoste1"
        txtCoste1.Size = New Size(100, 23)
        txtCoste1.TabIndex = 6
        ' 
        ' txtValor1
        ' 
        txtValor1.Enabled = False
        txtValor1.Location = New Point(539, 15)
        txtValor1.Name = "txtValor1"
        txtValor1.Size = New Size(116, 23)
        txtValor1.TabIndex = 7
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(76, 135)
        Button1.Name = "Button1"
        Button1.Size = New Size(23, 23)
        Button1.TabIndex = 8
        Button1.Text = "-"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(772, 135)
        Button5.Name = "Button5"
        Button5.Size = New Size(23, 23)
        Button5.TabIndex = 6
        Button5.Text = "+"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(314, 622)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 2
        Button2.Text = "Guardar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(424, 622)
        Button4.Name = "Button4"
        Button4.Size = New Size(75, 23)
        Button4.TabIndex = 4
        Button4.Text = "Cerrar"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Pristina", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(347, 43)
        Label5.Name = "Label5"
        Label5.Size = New Size(89, 46)
        Label5.TabIndex = 5
        Label5.Text = "Costos"
        ' 
        ' Costos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(880, 689)
        Controls.Add(GroupBox1)
        Controls.Add(Button1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Button4)
        Controls.Add(Label3)
        Controls.Add(Button2)
        Controls.Add(Button5)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Costos"
        Text = "Inredientes"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtValor1 As TextBox
    Friend WithEvents txtCoste1 As TextBox
    Friend WithEvents txtCantidad1 As TextBox
    Friend WithEvents txtIngrediente1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
