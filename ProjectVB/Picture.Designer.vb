<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImageIntro
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImageIntro))
        Me.PictureIntro = New System.Windows.Forms.PictureBox()
        CType(Me.PictureIntro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureIntro
        '
        Me.PictureIntro.ErrorImage = CType(resources.GetObject("PictureIntro.ErrorImage"), System.Drawing.Image)
        Me.PictureIntro.Image = CType(resources.GetObject("PictureIntro.Image"), System.Drawing.Image)
        Me.PictureIntro.ImageLocation = "Picture.jpg"
        Me.PictureIntro.Location = New System.Drawing.Point(-241, -157)
        Me.PictureIntro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureIntro.Name = "PictureIntro"
        Me.PictureIntro.Size = New System.Drawing.Size(1504, 887)
        Me.PictureIntro.TabIndex = 0
        Me.PictureIntro.TabStop = False
        '
        'ImageIntro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1035, 575)
        Me.Controls.Add(Me.PictureIntro)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ImageIntro"
        Me.Text = "MasterMind"
        CType(Me.PictureIntro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureIntro As System.Windows.Forms.PictureBox
End Class
