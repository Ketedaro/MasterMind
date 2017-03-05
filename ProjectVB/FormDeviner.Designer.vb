<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDeviner
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
        Me.LabelCaracteresJouables = New System.Windows.Forms.Label()
        Me.ButtonCacher = New System.Windows.Forms.Button()
        Me.TBhiddenSymbole5 = New System.Windows.Forms.TextBox()
        Me.TBhiddenSymbole4 = New System.Windows.Forms.TextBox()
        Me.TBhiddenSymbole2 = New System.Windows.Forms.TextBox()
        Me.TBhiddenSymbole3 = New System.Windows.Forms.TextBox()
        Me.TBhiddenSymbole1 = New System.Windows.Forms.TextBox()
        Me.PanelHiddenSymboles = New System.Windows.Forms.Panel()
        Me.PanelHiddenSymboles.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelCaracteresJouables
        '
        Me.LabelCaracteresJouables.AutoSize = True
        Me.LabelCaracteresJouables.Location = New System.Drawing.Point(27, 55)
        Me.LabelCaracteresJouables.Name = "LabelCaracteresJouables"
        Me.LabelCaracteresJouables.Size = New System.Drawing.Size(109, 13)
        Me.LabelCaracteresJouables.TabIndex = 14
        Me.LabelCaracteresJouables.Text = "Caractères Jouables :"
        '
        'ButtonCacher
        '
        Me.ButtonCacher.Location = New System.Drawing.Point(243, 140)
        Me.ButtonCacher.Name = "ButtonCacher"
        Me.ButtonCacher.Size = New System.Drawing.Size(100, 39)
        Me.ButtonCacher.TabIndex = 6
        Me.ButtonCacher.Text = "Cacher"
        Me.ButtonCacher.UseVisualStyleBackColor = True
        '
        'TBhiddenSymbole5
        '
        Me.TBhiddenSymbole5.Location = New System.Drawing.Point(436, 15)
        Me.TBhiddenSymbole5.MaxLength = 1
        Me.TBhiddenSymbole5.Name = "TBhiddenSymbole5"
        Me.TBhiddenSymbole5.Size = New System.Drawing.Size(100, 20)
        Me.TBhiddenSymbole5.TabIndex = 5
        Me.TBhiddenSymbole5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TBhiddenSymbole4
        '
        Me.TBhiddenSymbole4.Location = New System.Drawing.Point(330, 15)
        Me.TBhiddenSymbole4.MaxLength = 1
        Me.TBhiddenSymbole4.Name = "TBhiddenSymbole4"
        Me.TBhiddenSymbole4.Size = New System.Drawing.Size(100, 20)
        Me.TBhiddenSymbole4.TabIndex = 4
        Me.TBhiddenSymbole4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TBhiddenSymbole2
        '
        Me.TBhiddenSymbole2.Location = New System.Drawing.Point(118, 15)
        Me.TBhiddenSymbole2.MaxLength = 1
        Me.TBhiddenSymbole2.Name = "TBhiddenSymbole2"
        Me.TBhiddenSymbole2.Size = New System.Drawing.Size(100, 20)
        Me.TBhiddenSymbole2.TabIndex = 2
        Me.TBhiddenSymbole2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TBhiddenSymbole3
        '
        Me.TBhiddenSymbole3.Location = New System.Drawing.Point(224, 15)
        Me.TBhiddenSymbole3.MaxLength = 1
        Me.TBhiddenSymbole3.Name = "TBhiddenSymbole3"
        Me.TBhiddenSymbole3.Size = New System.Drawing.Size(100, 20)
        Me.TBhiddenSymbole3.TabIndex = 3
        Me.TBhiddenSymbole3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TBhiddenSymbole1
        '
        Me.TBhiddenSymbole1.Location = New System.Drawing.Point(11, 15)
        Me.TBhiddenSymbole1.MaxLength = 1
        Me.TBhiddenSymbole1.Name = "TBhiddenSymbole1"
        Me.TBhiddenSymbole1.Size = New System.Drawing.Size(100, 20)
        Me.TBhiddenSymbole1.TabIndex = 1
        Me.TBhiddenSymbole1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PanelHiddenSymboles
        '
        Me.PanelHiddenSymboles.Controls.Add(Me.TBhiddenSymbole5)
        Me.PanelHiddenSymboles.Controls.Add(Me.TBhiddenSymbole4)
        Me.PanelHiddenSymboles.Controls.Add(Me.TBhiddenSymbole2)
        Me.PanelHiddenSymboles.Controls.Add(Me.TBhiddenSymbole3)
        Me.PanelHiddenSymboles.Controls.Add(Me.TBhiddenSymbole1)
        Me.PanelHiddenSymboles.Location = New System.Drawing.Point(19, 74)
        Me.PanelHiddenSymboles.Name = "PanelHiddenSymboles"
        Me.PanelHiddenSymboles.Size = New System.Drawing.Size(544, 54)
        Me.PanelHiddenSymboles.TabIndex = 15
        '
        'FormDeviner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 205)
        Me.Controls.Add(Me.PanelHiddenSymboles)
        Me.Controls.Add(Me.LabelCaracteresJouables)
        Me.Controls.Add(Me.ButtonCacher)
        Me.Name = "FormDeviner"
        Me.Text = "MasterMind"
        Me.PanelHiddenSymboles.ResumeLayout(False)
        Me.PanelHiddenSymboles.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelCaracteresJouables As System.Windows.Forms.Label
    Friend WithEvents ButtonCacher As System.Windows.Forms.Button
    Friend WithEvents TBhiddenSymbole5 As System.Windows.Forms.TextBox
    Friend WithEvents TBhiddenSymbole4 As System.Windows.Forms.TextBox
    Friend WithEvents TBhiddenSymbole2 As System.Windows.Forms.TextBox
    Friend WithEvents TBhiddenSymbole3 As System.Windows.Forms.TextBox
    Friend WithEvents TBhiddenSymbole1 As System.Windows.Forms.TextBox
    Friend WithEvents PanelHiddenSymboles As Panel
End Class
