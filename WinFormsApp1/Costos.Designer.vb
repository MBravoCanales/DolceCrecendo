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
        Button2 = New Button()
        Button4 = New Button()
        Label5 = New Label()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        TabPage2 = New TabPage()
        GroupBox2 = New GroupBox()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Label6 = New Label()
        Button3 = New Button()
        Label7 = New Label()
        Button6 = New Button()
        Label8 = New Label()
        Label9 = New Label()
        TabPage3 = New TabPage()
        GroupBox3 = New GroupBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        Label10 = New Label()
        Button7 = New Button()
        Label11 = New Label()
        Button8 = New Button()
        Label12 = New Label()
        Label13 = New Label()
        TabControl1.SuspendLayout()
        TabPage2.SuspendLayout()
        GroupBox2.SuspendLayout()
        TabPage3.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
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
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Location = New Point(12, 92)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(826, 324)
        TabControl1.TabIndex = 10
        ' 
        ' TabPage1
        ' 
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(818, 296)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Datos"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(GroupBox2)
        TabPage2.Controls.Add(Label6)
        TabPage2.Controls.Add(Button3)
        TabPage2.Controls.Add(Label7)
        TabPage2.Controls.Add(Button6)
        TabPage2.Controls.Add(Label8)
        TabPage2.Controls.Add(Label9)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(818, 296)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Agregar"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(TextBox1)
        GroupBox2.Controls.Add(TextBox2)
        GroupBox2.Controls.Add(TextBox3)
        GroupBox2.Controls.Add(TextBox4)
        GroupBox2.Location = New Point(54, 42)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(661, 45)
        GroupBox2.TabIndex = 16
        GroupBox2.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(6, 15)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(186, 23)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(209, 15)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(183, 23)
        TextBox2.TabIndex = 5
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(410, 15)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 6
        ' 
        ' TextBox4
        ' 
        TextBox4.Enabled = False
        TextBox4.Location = New Point(539, 15)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(116, 23)
        TextBox4.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(54, 24)
        Label6.Name = "Label6"
        Label6.Size = New Size(67, 15)
        Label6.TabIndex = 10
        Label6.Text = "Ingrediente"
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(25, 57)
        Button3.Name = "Button3"
        Button3.Size = New Size(23, 23)
        Button3.TabIndex = 15
        Button3.Text = "-"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(259, 24)
        Label7.Name = "Label7"
        Label7.Size = New Size(183, 15)
        Label7.TabIndex = 11
        Label7.Text = "Cantidad (unidad/gramo/militro)"
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(721, 57)
        Button6.Name = "Button6"
        Button6.Size = New Size(23, 23)
        Button6.TabIndex = 14
        Button6.Text = "+"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(587, 24)
        Label8.Name = "Label8"
        Label8.Size = New Size(116, 15)
        Label8.TabIndex = 13
        Label8.Text = "Valor (unidad/gr/ml)"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(464, 24)
        Label9.Name = "Label9"
        Label9.Size = New Size(97, 15)
        Label9.TabIndex = 12
        Label9.Text = "Coste de compra"
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(GroupBox3)
        TabPage3.Controls.Add(Label10)
        TabPage3.Controls.Add(Button7)
        TabPage3.Controls.Add(Label11)
        TabPage3.Controls.Add(Button8)
        TabPage3.Controls.Add(Label12)
        TabPage3.Controls.Add(Label13)
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(818, 296)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Modificar"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(TextBox5)
        GroupBox3.Controls.Add(TextBox6)
        GroupBox3.Controls.Add(TextBox7)
        GroupBox3.Controls.Add(TextBox8)
        GroupBox3.Location = New Point(57, 39)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(661, 45)
        GroupBox3.TabIndex = 16
        GroupBox3.TabStop = False
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(6, 15)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(186, 23)
        TextBox5.TabIndex = 4
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(209, 15)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(183, 23)
        TextBox6.TabIndex = 5
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(410, 15)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(100, 23)
        TextBox7.TabIndex = 6
        ' 
        ' TextBox8
        ' 
        TextBox8.Enabled = False
        TextBox8.Location = New Point(539, 15)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(116, 23)
        TextBox8.TabIndex = 7
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(57, 21)
        Label10.Name = "Label10"
        Label10.Size = New Size(67, 15)
        Label10.TabIndex = 10
        Label10.Text = "Ingrediente"
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(28, 54)
        Button7.Name = "Button7"
        Button7.Size = New Size(23, 23)
        Button7.TabIndex = 15
        Button7.Text = "-"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(262, 21)
        Label11.Name = "Label11"
        Label11.Size = New Size(183, 15)
        Label11.TabIndex = 11
        Label11.Text = "Cantidad (unidad/gramo/militro)"
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(724, 54)
        Button8.Name = "Button8"
        Button8.Size = New Size(23, 23)
        Button8.TabIndex = 14
        Button8.Text = "+"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(590, 21)
        Label12.Name = "Label12"
        Label12.Size = New Size(116, 15)
        Label12.TabIndex = 13
        Label12.Text = "Valor (unidad/gr/ml)"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(467, 21)
        Label13.Name = "Label13"
        Label13.Size = New Size(97, 15)
        Label13.TabIndex = 12
        Label13.Text = "Coste de compra"
        ' 
        ' Costos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(880, 689)
        Controls.Add(TabControl1)
        Controls.Add(Label5)
        Controls.Add(Button4)
        Controls.Add(Button2)
        FormBorderStyle = FormBorderStyle.None
        Name = "Costos"
        Text = "Inredientes"
        TabControl1.ResumeLayout(False)
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
End Class
