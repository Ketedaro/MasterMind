Public Class FormScores
    Private joueurs() As Joueur

    Private Sub ComboBoxSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxSearch.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        If ComboBoxSearch.Text <> "" Then
            For Each j As Joueur In joueurs
                If Trim(j.nom) = ComboBoxSearch.Text Then
                    MsgBox(j.ToString())
                End If
            Next
        End If
    End Sub

    Private Sub ButtonRetour_Click(sender As Object, e As EventArgs) Handles ButtonRetour.Click
        Me.Hide()
        FormDeMenu.Show()
    End Sub

    Private Sub ComboBoxTri_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxTri.SelectedIndexChanged
        If ComboBoxTri.SelectedIndex = 0 Then
            triAlphabétique()
        Else
            triScores()
        End If
    End Sub

    Private Sub triAlphabétique()
        Dim lbNom, lbScore, lbJ1, lbJ2, lbTemps As New ListBox
        For i As Integer = 0 To ListBoxNom.Items.Count() - 1
            lbNom.Items.Add(ListBoxNom.Items(i))
            lbScore.Items.Add(ListBoxScore.Items(i))
            lbJ1.Items.Add(ListBoxJ1.Items(i))
            lbJ2.Items.Add(ListBoxJ2.Items(i))
            lbTemps.Items.Add(ListBoxTemps.Items(i))
        Next

        ListBoxNom.Sorted = True
        ListBoxScore.Items.Clear()
        ListBoxJ1.Items.Clear()
        ListBoxJ2.Items.Clear()
        ListBoxTemps.Items.Clear()

        For i As Integer = 0 To ListBoxNom.Items.Count() - 1
            For j As Integer = 0 To ListBoxNom.Items.Count() - 1
                If ListBoxNom.Items(i) = lbNom.Items(j) Then
                    ListBoxScore.Items.Add(lbScore.Items(j))
                    ListBoxJ1.Items.Add(lbJ1.Items(j))
                    ListBoxJ2.Items.Add(lbJ2.Items(j))
                    ListBoxTemps.Items.Add(lbTemps.Items(j))
                End If
            Next
        Next
        ListBoxNom.Sorted = False
    End Sub

    Private Sub triScores()
        For Each l As ListBox In PanelListBox.Controls
            l.Items.Clear()
        Next
        Dim joueursCopie(joueurs.Length - 1) As Joueur
        For i As Integer = 0 To joueurs.Length - 1
            joueursCopie(i) = joueurs(i)
        Next
        For i As Integer = 0 To UBound(joueursCopie)
            Dim scoreMax As Integer = 0
            Dim index As Integer = -1
            For j As Integer = 0 To UBound(joueursCopie)
                If joueursCopie(j).score >= scoreMax AndAlso Not IsNothing(joueursCopie(j).nom) Then
                    scoreMax = joueursCopie(j).score
                    index = j
                End If
            Next
            If index = -1 Then
                Exit Sub
            End If
            ListBoxNom.Items.Add(joueursCopie(index).nom)
            ListBoxScore.Items.Add(joueursCopie(index).score)
            ListBoxJ1.Items.Add(joueursCopie(index).PartiesJoueur1)
            ListBoxJ2.Items.Add(joueursCopie(index).PartiesJoueur2)
            ListBoxTemps.Items.Add(joueursCopie(index).cumulTemps)
            joueursCopie(index).score = -1
        Next
    End Sub

    Public Sub Charger()
        joueurs = ModuleSauvegardeFichier.getJoueurs()
        For Each c As ListBox In PanelListBox.Controls
            c.Items.Clear()
        Next
        For Each j As Joueur In joueurs
            If Not IsNothing(j.nom) Then
                ListBoxNom.Items.Add(j.nom)
                ListBoxScore.Items.Add(j.score)
                ListBoxJ1.Items.Add(j.PartiesJoueur1)
                ListBoxJ2.Items.Add(j.PartiesJoueur2)
                ListBoxTemps.Items.Add(j.cumulTemps)
            End If
        Next
    End Sub

    Private Sub FormScores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxTri.Items.Add("Alphabétique")
        ComboBoxTri.Items.Add("Meilleur score")
    End Sub
End Class