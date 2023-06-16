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
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        TextBox1 = New TextBox()
        Label5 = New Label()
        GroupBox1 = New GroupBox()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        Label10 = New Label()
        TextBox7 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        ComboBox1 = New ComboBox()
        GroupBox2 = New GroupBox()
        Button4 = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(499, 382)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 0
        Button1.Text = "Salir"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(460, 79)
        Button2.Name = "Button2"
        Button2.Size = New Size(23, 23)
        Button2.TabIndex = 2
        Button2.Text = "Agregar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(487, 79)
        Button3.Name = "Button3"
        Button3.Size = New Size(23, 23)
        Button3.TabIndex = 3
        Button3.Text = "Eliminar"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Enabled = False
        TextBox1.Location = New Point(239, 51)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(36, 54)
        Label5.Name = "Label5"
        Label5.Size = New Size(32, 15)
        Label5.TabIndex = 9
        Label5.Text = "Total"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TextBox7)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(TextBox6)
        GroupBox1.Controls.Add(TextBox5)
        GroupBox1.Controls.Add(TextBox4)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Location = New Point(534, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(366, 331)
        GroupBox1.TabIndex = 10
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(159, 19)
        Label6.Name = "Label6"
        Label6.Size = New Size(43, 15)
        Label6.TabIndex = 0
        Label6.Text = "Detalle"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(36, 83)
        Label7.Name = "Label7"
        Label7.Size = New Size(179, 15)
        Label7.TabIndex = 10
        Label7.Text = "Cantidad de unidades fabricadas"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(36, 112)
        Label8.Name = "Label8"
        Label8.Size = New Size(98, 15)
        Label8.TabIndex = 11
        Label8.Text = "Coste por unidad"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(36, 141)
        Label9.Name = "Label9"
        Label9.Size = New Size(120, 15)
        Label9.TabIndex = 12
        Label9.Text = "Venta de cada unidad"
        ' 
        ' TextBox4
        ' 
        TextBox4.Enabled = False
        TextBox4.Location = New Point(239, 80)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 23)
        TextBox4.TabIndex = 13
        ' 
        ' TextBox5
        ' 
        TextBox5.Enabled = False
        TextBox5.Location = New Point(239, 109)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(100, 23)
        TextBox5.TabIndex = 14
        ' 
        ' TextBox6
        ' 
        TextBox6.Enabled = False
        TextBox6.Location = New Point(239, 138)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(100, 23)
        TextBox6.TabIndex = 15
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(36, 171)
        Label10.Name = "Label10"
        Label10.Size = New Size(117, 15)
        Label10.TabIndex = 16
        Label10.Text = "Ganancia por unidad"
        ' 
        ' TextBox7
        ' 
        TextBox7.Enabled = False
        TextBox7.Location = New Point(239, 168)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(100, 23)
        TextBox7.TabIndex = 17
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(194, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 15)
        Label1.TabIndex = 0
        Label1.Text = "Produccion"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(20, 54)
        Label2.Name = "Label2"
        Label2.Size = New Size(47, 15)
        Label2.TabIndex = 2
        Label2.Text = "Insumo"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(147, 54)
        Label3.Name = "Label3"
        Label3.Size = New Size(185, 15)
        Label3.TabIndex = 3
        Label3.Text = "Cantidad a utilizar (unidad/gr/ml)"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(354, 54)
        Label4.Name = "Label4"
        Label4.Size = New Size(37, 15)
        Label4.TabIndex = 4
        Label4.Text = "Coste"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(148, 80)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(184, 23)
        TextBox2.TabIndex = 5
        ' 
        ' TextBox3
        ' 
        TextBox3.Enabled = False
        TextBox3.Location = New Point(354, 80)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 6
        ' 
        ' ComboBox1
        ' 
        ComboBox1.AllowDrop = True
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Harina", "Azucar"})
        ComboBox1.Location = New Point(20, 80)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(118, 23)
        ComboBox1.TabIndex = 7
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(TextBox3)
        GroupBox2.Controls.Add(ComboBox1)
        GroupBox2.Controls.Add(Button3)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Button2)
        GroupBox2.Controls.Add(TextBox2)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Location = New Point(12, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(516, 331)
        GroupBox2.TabIndex = 11
        GroupBox2.TabStop = False
        GroupBox2.Text = "GroupBox2"
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(391, 382)
        Button4.Name = "Button4"
        Button4.Size = New Size(75, 23)
        Button4.TabIndex = 12
        Button4.Text = "Limpiar"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Costos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(912, 450)
        Controls.Add(Button4)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Button1)
        Name = "Costos"
        Text = "Produccion"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button4 As Button
End Class
