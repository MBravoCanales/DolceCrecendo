<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inicio
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Inicio))
        PictureReceta = New PictureBox()
        BtnSalirInicio = New Button()
        LabelTituloInicio = New Label()
        PictureProduccion = New PictureBox()
        PictureCostos = New PictureBox()
        CType(PictureReceta, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureProduccion, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureCostos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureReceta
        ' 
        PictureReceta.Anchor = AnchorStyles.None
        PictureReceta.Image = CType(resources.GetObject("PictureReceta.Image"), Image)
        PictureReceta.Location = New Point(32, 198)
        PictureReceta.Name = "PictureReceta"
        PictureReceta.Size = New Size(184, 128)
        PictureReceta.SizeMode = PictureBoxSizeMode.StretchImage
        PictureReceta.TabIndex = 0
        PictureReceta.TabStop = False
        ' 
        ' BtnSalirInicio
        ' 
        BtnSalirInicio.Location = New Point(358, 385)
        BtnSalirInicio.Name = "BtnSalirInicio"
        BtnSalirInicio.Size = New Size(75, 23)
        BtnSalirInicio.TabIndex = 1
        BtnSalirInicio.Text = "Salir"
        BtnSalirInicio.UseVisualStyleBackColor = True
        ' 
        ' LabelTituloInicio
        ' 
        LabelTituloInicio.AutoSize = True
        LabelTituloInicio.Font = New Font("Poor Richard", 27.75F, FontStyle.Bold, GraphicsUnit.Point)
        LabelTituloInicio.Location = New Point(272, 73)
        LabelTituloInicio.Name = "LabelTituloInicio"
        LabelTituloInicio.Size = New Size(261, 44)
        LabelTituloInicio.TabIndex = 2
        LabelTituloInicio.Text = "DolceCrescendo"
        ' 
        ' PictureProduccion
        ' 
        PictureProduccion.Anchor = AnchorStyles.None
        PictureProduccion.Image = CType(resources.GetObject("PictureProduccion.Image"), Image)
        PictureProduccion.Location = New Point(309, 198)
        PictureProduccion.Name = "PictureProduccion"
        PictureProduccion.Size = New Size(184, 128)
        PictureProduccion.SizeMode = PictureBoxSizeMode.StretchImage
        PictureProduccion.TabIndex = 3
        PictureProduccion.TabStop = False
        ' 
        ' PictureCostos
        ' 
        PictureCostos.Anchor = AnchorStyles.None
        PictureCostos.Image = CType(resources.GetObject("PictureCostos.Image"), Image)
        PictureCostos.Location = New Point(583, 198)
        PictureCostos.Name = "PictureCostos"
        PictureCostos.Size = New Size(184, 128)
        PictureCostos.SizeMode = PictureBoxSizeMode.StretchImage
        PictureCostos.TabIndex = 4
        PictureCostos.TabStop = False
        PictureCostos.Tag = ""
        ' 
        ' Inicio
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(PictureCostos)
        Controls.Add(PictureProduccion)
        Controls.Add(LabelTituloInicio)
        Controls.Add(BtnSalirInicio)
        Controls.Add(PictureReceta)
        Name = "Inicio"
        Text = "Form1"
        CType(PictureReceta, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureProduccion, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureCostos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureReceta As PictureBox
    Friend WithEvents BtnSalirInicio As Button
    Friend WithEvents LabelTituloInicio As Label
    Friend WithEvents PictureProduccion As PictureBox
    Friend WithEvents PictureCostos As PictureBox
End Class
