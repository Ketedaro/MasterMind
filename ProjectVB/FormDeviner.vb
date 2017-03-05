Public Class FormDeviner


    Const listeSymbolesAutorisées As String = "# $ £ % @"

    Private Sub LabelCaracteresJouables_Click(sender As Object, e As EventArgs) Handles LabelCaracteresJouables.Click

    End Sub

    Private Sub ButtonCacher_Click(sender As Object, e As EventArgs) Handles ButtonCacher.Click
        For Each textBox As Control In PanelHiddenSymboles.Controls
            If textBox.Text = "" Then
                MsgBox("Tous les symboles n'ont pas été entrées.")
                Exit Sub
            End If
        Next
        Me.Hide()
        FormGame.Show()
    End Sub

    Private Sub TextBox1_keypress(sender As Object, e As KeyPressEventArgs) Handles TBhiddenSymbole1.KeyPress, TBhiddenSymbole2.KeyPress,
        TBhiddenSymbole3.KeyPress, TBhiddenSymbole4.KeyPress, TBhiddenSymbole5.KeyPress

        If Not listeSymbolesAutorisées.Contains(e.KeyChar) AndAlso e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Public Function EstUnSymboleAutorisé(ByRef e As Char) As Boolean
        If listeSymbolesAutorisées.Contains(e) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub FormDeviner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelCaracteresJouables.Text = "Caractères jouables : " & listeSymbolesAutorisées
    End Sub

    Public Function contientSymbole(ByVal str As String) As Boolean
        For Each c As Control In PanelHiddenSymboles.Controls
            If c.Text = str Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Function contientSymbole(ByVal str As String, ByVal noSymbole As Integer) As Boolean
        For Each c As Control In PanelHiddenSymboles.Controls
            If c.Text = str AndAlso Strings.Right(c.Name, 1) = noSymbole Then
                Return True
            End If
        Next
        Return False
    End Function
End Class