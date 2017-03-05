<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDeMenu
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
        Me.ComboBoxNom1 = New System.Windows.Forms.ComboBox()
        Me.BoutonJouer = New System.Windows.Forms.Button()
        Me.BoutonScores = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxNom2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BoutonQuitter = New System.Windows.Forms.Button()
        Me.ButtonRejouer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComboBoxNom1
        '
        Me.ComboBoxNom1.FormattingEnabled = True
        Me.ComboBoxNom1.Location = New System.Drawing.Point(68, 42)
        Me.ComboBoxNom1.Name = "ComboBoxNom1"
        Me.ComboBoxNom1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxNom1.TabIndex = 13
        '
        'BoutonJouer
        '
        Me.BoutonJouer.Location = New System.Drawing.Point(266, 276)
        Me.BoutonJouer.Name = "BoutonJouer"
        Me.BoutonJouer.Size = New System.Drawing.Size(94, 33)
        Me.BoutonJouer.TabIndex = 12
        Me.BoutonJouer.Text = "Jouer"
        Me.BoutonJouer.UseVisualStyleBackColor = True
        '
        'BoutonScores
        '
        Me.BoutonScores.Location = New System.Drawing.Point(147, 276)
        Me.BoutonScores.Name = "BoutonScores"
        Me.BoutonScores.Size = New System.Drawing.Size(96, 33)
        Me.BoutonScores.TabIndex = 15
        Me.BoutonScores.Text = "Scores"
        Me.BoutonScores.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Joueur 1"
        '
        'ComboBoxNom2
        '
        Me.ComboBoxNom2.FormattingEnabled = True
        Me.ComboBoxNom2.Location = New System.Drawing.Point(249, 42)
        Me.ComboBoxNom2.Name = "ComboBoxNom2"
        Me.ComboBoxNom2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxNom2.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(195, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Joueur 2"
        '
        'BoutonQuitter
        '
        Me.BoutonQuitter.Location = New System.Drawing.Point(29, 276)
        Me.BoutonQuitter.Name = "BoutonQuitter"
        Me.BoutonQuitter.Size = New System.Drawing.Size(96, 33)
        Me.BoutonQuitter.TabIndex = 11
        Me.BoutonQuitter.Text = "Quitter"
        Me.BoutonQuitter.UseVisualStyleBackColor = True
        '
        'ButtonRejouer
        '
        Me.ButtonRejouer.Location = New System.Drawing.Point(159, 181)
        Me.ButtonRejouer.Name = "ButtonRejouer"
        Me.ButtonRejouer.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRejouer.TabIndex = 16
        Me.ButtonRejouer.Text = "Rejouer"
        Me.ButtonRejouer.UseVisualStyleBackColor = True
        Me.ButtonRejouer.Visible = False
        '
        'FormDeMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 338)
        Me.Controls.Add(Me.ButtonRejouer)
        Me.Controls.Add(Me.ComboBoxNom1)
        Me.Controls.Add(Me.BoutonJouer)
        Me.Controls.Add(Me.BoutonScores)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxNom2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BoutonQuitter)
        Me.Name = "FormDeMenu"
        Me.Text = "MasterMind"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBoxNom1 As System.Windows.Forms.ComboBox
    Friend WithEvents BoutonJouer As System.Windows.Forms.Button
    Friend WithEvents BoutonScores As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxNom2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BoutonQuitter As System.Windows.Forms.Button
    Friend WithEvents ButtonRejouer As Button
End Class
