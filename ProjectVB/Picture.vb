Public Class ImageIntro
    Private Sub PictureIntro_Click(sender As Object, e As EventArgs) Handles PictureIntro.Click
        Me.Hide()
        FormDeMenu.Show()
    End Sub

    Private Sub ImageIntro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModuleSauvegardeFichier.ChargerJoueurs()
    End Sub
End Class
