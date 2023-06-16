<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        PictureReceta = New PictureBox()
        Button1 = New Button()
        Label1 = New Label()
        PictureIngredientes = New PictureBox()
        PictureCostos = New PictureBox()
        CType(PictureReceta, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureIngredientes, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureCostos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureReceta
        ' 
        PictureReceta.Image = CType(resources.GetObject("PictureReceta.Image"), Image)
        PictureReceta.Location = New Point(32, 198)
        PictureReceta.Name = "PictureReceta"
        PictureReceta.Size = New Size(184, 128)
        PictureReceta.SizeMode = PictureBoxSizeMode.StretchImage
        PictureReceta.TabIndex = 0
        PictureReceta.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(358, 385)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 1
        Button1.Text = "Salir"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Poor Richard", 27.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(272, 73)
        Label1.Name = "Label1"
        Label1.Size = New Size(261, 44)
        Label1.TabIndex = 2
        Label1.Text = "DolceCrescendo"
        ' 
        ' PictureIngredientes
        ' 
        PictureIngredientes.Image = CType(resources.GetObject("PictureIngredientes.Image"), Image)
        PictureIngredientes.Location = New Point(309, 198)
        PictureIngredientes.Name = "PictureIngredientes"
        PictureIngredientes.Size = New Size(184, 128)
        PictureIngredientes.SizeMode = PictureBoxSizeMode.StretchImage
        PictureIngredientes.TabIndex = 3
        PictureIngredientes.TabStop = False
        ' 
        ' PictureCostos
        ' 
        PictureCostos.Image = CType(resources.GetObject("PictureCostos.Image"), Image)
        PictureCostos.Location = New Point(583, 198)
        PictureCostos.Name = "PictureCostos"
        PictureCostos.Size = New Size(184, 128)
        PictureCostos.SizeMode = PictureBoxSizeMode.StretchImage
        PictureCostos.TabIndex = 4
        PictureCostos.TabStop = False
        PictureCostos.Tag = ""
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(PictureCostos)
        Controls.Add(PictureIngredientes)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(PictureReceta)
        Name = "Form1"
        Text = "Form1"
        CType(PictureReceta, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureIngredientes, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureCostos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureReceta As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureIngredientes As PictureBox
    Friend WithEvents PictureCostos As PictureBox
End Class
