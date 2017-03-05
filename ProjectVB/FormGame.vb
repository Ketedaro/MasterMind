Public Class FormGame
    Private nbrEssaies As Integer = 0
    Private tempsEcoulé As Long = 0

    Private Sub BoutonSuggerer_Click(sender As Object, e As EventArgs) Handles BoutonSuggerer.Click
        For Each c As Control In PanelSuggestions.Controls
            If c.Text = "" Then
                MsgBox("Vous n'avez pas renseigné tous les champs.")
                Exit Sub
            End If
        Next
        Dim nombreSymbolesCorrectes As Integer = 0
        For Each c As Control In PanelSuggestions.Controls
            Dim noSymbole As Integer = Strings.Right(c.Name, 1)
            If FormDeviner.contientSymbole(c.Text, noSymbole) Then
                c.BackColor = Color.Green
                nombreSymbolesCorrectes += 1
                AjouterLabel(Color.Green, noSymbole + nbrEssaies * 5, c.Text)
            ElseIf FormDeviner.contientSymbole(c.Text) Then
                c.BackColor = Color.Blue
                AjouterLabel(Color.Blue, noSymbole + nbrEssaies * 5, c.Text)
            Else
                AjouterLabel(Color.Black, noSymbole + nbrEssaies * 5, c.Text)
            End If
        Next
        nbrEssaies += 1
        Me.Text = "Il vous reste " & 15 - nbrEssaies & " coups..."
        If nombreSymbolesCorrectes = 5 Then
            LabelTrouvé.Visible = True
            FinDePartie()
            ModuleSauvegardeFichier.EnregistrerJoueur1(Trim(FormDeMenu.ComboBoxNom1.Text), True, tempsEcoulé)
            ModuleSauvegardeFichier.EnregistrerJoueur2(Trim(FormDeMenu.ComboBoxNom2.Text), False)
        ElseIf nbrEssaies = 15 Then
            LabelPerdu.Visible = True
            FinDePartie()
            ModuleSauvegardeFichier.EnregistrerJoueur1(Trim(FormDeMenu.ComboBoxNom1.Text), False, tempsEcoulé)
            ModuleSauvegardeFichier.EnregistrerJoueur2(Trim(FormDeMenu.ComboBoxNom2.Text), True)
        End If
    End Sub

    Private Sub AjouterLabel(couleur As Color, numero As Integer, s As String)
        For Each c As Control In PanelAnciennesPropositions.Controls
            If c.Name = "Label" & numero Then
                c.Text = s
                c.ForeColor = couleur
            End If
        Next
    End Sub

    Private Sub TextBox_keypress(sender As Object, e As KeyPressEventArgs) Handles TBSuggestion1.KeyPress, TBSuggestion2.KeyPress,
        TBSuggestion3.KeyPress, TBSuggestion4.KeyPress, TBSuggestion5.KeyPress

        If Not FormDeviner.EstUnSymboleAutorisé(e.KeyChar) AndAlso e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub FinDePartie()
        BoutonSuggerer.Enabled = False
        ButtonBye.Visible = True
        ButtonBye.Enabled = True
        monTimer.Enabled = False
    End Sub

    Private Sub ButtonBye_Click(sender As Object, e As EventArgs) Handles ButtonBye.Click
        monTimer.Enabled = False
        For Each c As Control In PanelAnciennesPropositions.Controls
            c.Text = ""
        Next
        nbrEssaies = 0
        For Each c As Control In PanelSuggestions.Controls
            c.Text = ""
            c.BackColor = Color.White
        Next
        BoutonSuggerer.Enabled = True
        ButtonBye.Visible = False
        LabelTrouvé.Visible = False
        LabelPerdu.Visible = False
        Me.Hide()
        FormDeMenu.ButtonRejouer.Show()
        FormDeMenu.Show()
    End Sub

    Private Sub TBSuggestion_GetFocus(sender As Object, e As EventArgs) Handles TBSuggestion1.GotFocus, TBSuggestion2.GotFocus,
        TBSuggestion3.GotFocus, TBSuggestion4.GotFocus, TBSuggestion5.GotFocus
        sender.backcolor = Color.White
    End Sub

    Private Sub FormGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Il vous reste " & 15 - nbrEssaies & " coups..."
        monTimer.Enabled = True
        monTimer.Start()
        ButtonBye.Visible = False
        BoutonSuggerer.Enabled = True
        LabelPerdu.Visible = False
        LabelTrouvé.Visible = False
    End Sub

    Private Sub incCompteur(sender As Object, e As EventArgs) Handles monTimer.Tick
        tempsEcoulé += 1
    End Sub

End Class