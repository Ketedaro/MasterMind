Public Class FormDeMenu
    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxNom1.KeyPress, ComboBoxNom2.KeyPress
        If Not (Char.IsLetter(e.KeyChar) Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BoxNom_LostFocus(sender As Object, e As EventArgs) Handles ComboBoxNom1.LostFocus, ComboBoxNom1.LostFocus
        If ComboBoxNom1.Text <> "" Then
            ComboBoxNom1.Text = ComboBoxNom1.Text.Substring(0, 1).ToUpper() + ComboBoxNom1.Text.Substring(1).ToLower()
        End If
        If ComboBoxNom2.Text <> "" Then
            ComboBoxNom1.Text = ComboBoxNom1.Text.Substring(0, 1).ToUpper() + ComboBoxNom1.Text.Substring(1).ToLower()
        End If
    End Sub





    Private Sub BoutonQuitter_Click(sender As Object, e As EventArgs) Handles BoutonQuitter.Click
        Dim réponse As MsgBoxResult = MsgBox("Etes-vous sûr de vouloir quitter?", MsgBoxStyle.OkCancel, "Quitter le magnifique mastermind")
        If réponse = MsgBoxResult.Ok Then
            ModuleSauvegardeFichier.EnregistrerJoueurs()
            Application.Exit()
        End If
    End Sub


    Private Sub BoutonJouer_Click(sender As Object, e As EventArgs) Handles BoutonJouer.Click
        If ComboBoxNom1.Text = "" OrElse ComboBoxNom2.Text = "" Then
            MsgBox("Vous devez donner un nom aux deux joueurs.")
        ElseIf ComboBoxNom1.Text = ComboBoxNom2.Text
            MsgBox("Les joueurs ne peuvent avoir le même nom.")
        Else
            Me.Hide()
            FormDeviner.Show()
        End If

    End Sub

    Private Sub BoutonScores_Click(sender As Object, e As EventArgs) Handles BoutonScores.Click
        FormScores.charger()
        Me.Hide()
        FormScores.Show()
    End Sub

    Private Sub ComboBoxNom2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxNom1.LostFocus, ComboBoxNom2.LostFocus
        sender.text = StrConv(sender.text, VbStrConv.ProperCase)
    End Sub

    Private Sub ButtonRejouer_Click(sender As Object, e As EventArgs) Handles ButtonRejouer.Click
        Dim s As String = ComboBoxNom1.Text
        ComboBoxNom1.Text = ComboBoxNom2.Text
        ComboBoxNom2.Text = s
        BoutonJouer_Click(sender, e)
    End Sub
End Class