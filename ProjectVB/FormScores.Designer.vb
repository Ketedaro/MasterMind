<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormScores
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
        Me.LabelScores = New System.Windows.Forms.Label()
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.LabelScore = New System.Windows.Forms.Label()
        Me.LabelJ1 = New System.Windows.Forms.Label()
        Me.LabelTemps = New System.Windows.Forms.Label()
        Me.LabelJ2 = New System.Windows.Forms.Label()
        Me.ListBoxJ1 = New System.Windows.Forms.ListBox()
        Me.ListBoxScore = New System.Windows.Forms.ListBox()
        Me.ListBoxNom = New System.Windows.Forms.ListBox()
        Me.ListBoxJ2 = New System.Windows.Forms.ListBox()
        Me.ListBoxTemps = New System.Windows.Forms.ListBox()
        Me.LabelTrié = New System.Windows.Forms.Label()
        Me.ComboBoxSearch = New System.Windows.Forms.ComboBox()
        Me.ComboBoxTri = New System.Windows.Forms.ComboBox()
        Me.LabelSearch = New System.Windows.Forms.Label()
        Me.ButtonSearch = New System.Windows.Forms.Button()
        Me.ButtonRetour = New System.Windows.Forms.Button()
        Me.PanelListBox = New System.Windows.Forms.Panel()
        Me.PanelListBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelScores
        '
        Me.LabelScores.AutoSize = True
        Me.LabelScores.Location = New System.Drawing.Point(445, 43)
        Me.LabelScores.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelScores.Name = "LabelScores"
        Me.LabelScores.Size = New System.Drawing.Size(52, 17)
        Me.LabelScores.TabIndex = 0
        Me.LabelScores.Text = "Scores"
        '
        'LabelNom
        '
        Me.LabelNom.AutoSize = True
        Me.LabelNom.Location = New System.Drawing.Point(68, 108)
        Me.LabelNom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(37, 17)
        Me.LabelNom.TabIndex = 1
        Me.LabelNom.Text = "Nom"
        '
        'LabelScore
        '
        Me.LabelScore.AutoSize = True
        Me.LabelScore.Location = New System.Drawing.Point(269, 108)
        Me.LabelScore.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelScore.Name = "LabelScore"
        Me.LabelScore.Size = New System.Drawing.Size(45, 17)
        Me.LabelScore.TabIndex = 2
        Me.LabelScore.Text = "Score"
        '
        'LabelJ1
        '
        Me.LabelJ1.AutoSize = True
        Me.LabelJ1.Location = New System.Drawing.Point(445, 108)
        Me.LabelJ1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelJ1.Name = "LabelJ1"
        Me.LabelJ1.Size = New System.Drawing.Size(64, 17)
        Me.LabelJ1.TabIndex = 3
        Me.LabelJ1.Text = "Joueur 1"
        '
        'LabelTemps
        '
        Me.LabelTemps.AutoSize = True
        Me.LabelTemps.Location = New System.Drawing.Point(820, 108)
        Me.LabelTemps.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelTemps.Name = "LabelTemps"
        Me.LabelTemps.Size = New System.Drawing.Size(87, 17)
        Me.LabelTemps.TabIndex = 4
        Me.LabelTemps.Text = "Temps Total"
        '
        'LabelJ2
        '
        Me.LabelJ2.AutoSize = True
        Me.LabelJ2.Location = New System.Drawing.Point(645, 108)
        Me.LabelJ2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelJ2.Name = "LabelJ2"
        Me.LabelJ2.Size = New System.Drawing.Size(64, 17)
        Me.LabelJ2.TabIndex = 5
        Me.LabelJ2.Text = "Joueur 2"
        '
        'ListBoxJ1
        '
        Me.ListBoxJ1.FormattingEnabled = True
        Me.ListBoxJ1.ItemHeight = 16
        Me.ListBoxJ1.Location = New System.Drawing.Point(404, 6)
        Me.ListBoxJ1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListBoxJ1.Name = "ListBoxJ1"
        Me.ListBoxJ1.Size = New System.Drawing.Size(127, 196)
        Me.ListBoxJ1.TabIndex = 7
        '
        'ListBoxScore
        '
        Me.ListBoxScore.FormattingEnabled = True
        Me.ListBoxScore.ItemHeight = 16
        Me.ListBoxScore.Location = New System.Drawing.Point(213, 6)
        Me.ListBoxScore.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListBoxScore.Name = "ListBoxScore"
        Me.ListBoxScore.Size = New System.Drawing.Size(127, 196)
        Me.ListBoxScore.TabIndex = 8
        '
        'ListBoxNom
        '
        Me.ListBoxNom.FormattingEnabled = True
        Me.ListBoxNom.ItemHeight = 16
        Me.ListBoxNom.Location = New System.Drawing.Point(23, 6)
        Me.ListBoxNom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListBoxNom.MultiColumn = True
        Me.ListBoxNom.Name = "ListBoxNom"
        Me.ListBoxNom.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.ListBoxNom.Size = New System.Drawing.Size(127, 196)
        Me.ListBoxNom.TabIndex = 9
        '
        'ListBoxJ2
        '
        Me.ListBoxJ2.FormattingEnabled = True
        Me.ListBoxJ2.ItemHeight = 16
        Me.ListBoxJ2.Location = New System.Drawing.Point(595, 6)
        Me.ListBoxJ2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListBoxJ2.Name = "ListBoxJ2"
        Me.ListBoxJ2.Size = New System.Drawing.Size(127, 196)
        Me.ListBoxJ2.TabIndex = 10
        '
        'ListBoxTemps
        '
        Me.ListBoxTemps.FormattingEnabled = True
        Me.ListBoxTemps.ItemHeight = 16
        Me.ListBoxTemps.Location = New System.Drawing.Point(785, 6)
        Me.ListBoxTemps.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListBoxTemps.Name = "ListBoxTemps"
        Me.ListBoxTemps.Size = New System.Drawing.Size(127, 196)
        Me.ListBoxTemps.TabIndex = 11
        '
        'LabelTrié
        '
        Me.LabelTrié.AutoSize = True
        Me.LabelTrié.Location = New System.Drawing.Point(68, 410)
        Me.LabelTrié.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelTrié.Name = "LabelTrié"
        Me.LabelTrié.Size = New System.Drawing.Size(104, 17)
        Me.LabelTrié.TabIndex = 12
        Me.LabelTrié.Text = "Trié par ordre :"
        '
        'ComboBoxSearch
        '
        Me.ComboBoxSearch.FormattingEnabled = True
        Me.ComboBoxSearch.Location = New System.Drawing.Point(727, 400)
        Me.ComboBoxSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBoxSearch.Name = "ComboBoxSearch"
        Me.ComboBoxSearch.Size = New System.Drawing.Size(160, 24)
        Me.ComboBoxSearch.TabIndex = 14
        '
        'ComboBoxTri
        '
        Me.ComboBoxTri.FormattingEnabled = True
        Me.ComboBoxTri.Location = New System.Drawing.Point(197, 406)
        Me.ComboBoxTri.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBoxTri.Name = "ComboBoxTri"
        Me.ComboBoxTri.Size = New System.Drawing.Size(160, 24)
        Me.ComboBoxTri.TabIndex = 15
        '
        'LabelSearch
        '
        Me.LabelSearch.AutoSize = True
        Me.LabelSearch.Location = New System.Drawing.Point(592, 406)
        Me.LabelSearch.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelSearch.Name = "LabelSearch"
        Me.LabelSearch.Size = New System.Drawing.Size(125, 17)
        Me.LabelSearch.TabIndex = 16
        Me.LabelSearch.Text = "Recherche joueur:"
        '
        'ButtonSearch
        '
        Me.ButtonSearch.Location = New System.Drawing.Point(759, 433)
        Me.ButtonSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(100, 28)
        Me.ButtonSearch.TabIndex = 17
        Me.ButtonSearch.Text = "Rechercher"
        Me.ButtonSearch.UseVisualStyleBackColor = True
        '
        'ButtonRetour
        '
        Me.ButtonRetour.Location = New System.Drawing.Point(831, 31)
        Me.ButtonRetour.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonRetour.Name = "ButtonRetour"
        Me.ButtonRetour.Size = New System.Drawing.Size(100, 28)
        Me.ButtonRetour.TabIndex = 18
        Me.ButtonRetour.Text = "Retour"
        Me.ButtonRetour.UseVisualStyleBackColor = True
        '
        'PanelListBox
        '
        Me.PanelListBox.Controls.Add(Me.ListBoxTemps)
        Me.PanelListBox.Controls.Add(Me.ListBoxJ2)
        Me.PanelListBox.Controls.Add(Me.ListBoxNom)
        Me.PanelListBox.Controls.Add(Me.ListBoxScore)
        Me.PanelListBox.Controls.Add(Me.ListBoxJ1)
        Me.PanelListBox.Location = New System.Drawing.Point(17, 138)
        Me.PanelListBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelListBox.Name = "PanelListBox"
        Me.PanelListBox.Size = New System.Drawing.Size(924, 218)
        Me.PanelListBox.TabIndex = 19
        '
        'FormScores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(963, 487)
        Me.Controls.Add(Me.PanelListBox)
        Me.Controls.Add(Me.ButtonRetour)
        Me.Controls.Add(Me.ButtonSearch)
        Me.Controls.Add(Me.LabelSearch)
        Me.Controls.Add(Me.ComboBoxTri)
        Me.Controls.Add(Me.ComboBoxSearch)
        Me.Controls.Add(Me.LabelTrié)
        Me.Controls.Add(Me.LabelJ2)
        Me.Controls.Add(Me.LabelTemps)
        Me.Controls.Add(Me.LabelJ1)
        Me.Controls.Add(Me.LabelScore)
        Me.Controls.Add(Me.LabelNom)
        Me.Controls.Add(Me.LabelScores)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormScores"
        Me.Text = "FormScores"
        Me.PanelListBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Friend WithEvents LabelScores As Label
    Friend WithEvents LabelNom As Label
    Friend WithEvents LabelScore As Label
    Friend WithEvents LabelJ1 As Label
    Friend WithEvents LabelTemps As Label
    Friend WithEvents LabelJ2 As Label
    Friend WithEvents ListBoxJ1 As ListBox
    Friend WithEvents ListBoxScore As ListBox
    Friend WithEvents ListBoxNom As ListBox
    Friend WithEvents ListBoxJ2 As ListBox
    Friend WithEvents ListBoxTemps As ListBox
    Friend WithEvents LabelTrié As Label
    Friend WithEvents ComboBoxSearch As ComboBox
    Friend WithEvents ComboBoxTri As ComboBox
    Friend WithEvents LabelSearch As Label
    Friend WithEvents ButtonSearch As Button
    Friend WithEvents ButtonRetour As Button
    Friend WithEvents PanelListBox As Panel
End Class
