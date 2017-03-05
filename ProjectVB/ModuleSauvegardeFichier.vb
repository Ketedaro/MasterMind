Module ModuleSauvegardeFichier
    Public Structure Joueur
        <VBFixedString(20)> Dim nom As String
        Dim score, PartiesJoueur1, PartiesJoueur2 As Integer
        Dim cumulTemps As Long
        Public Sub New(ByVal name As String, score As Boolean, temps As Integer, j As Integer)
            Me.nom = name
            Me.cumulTemps = temps
            If score Then
                Me.score = 1
            Else
                Me.score = 0
            End If

            If j = 1 Then
                Me.PartiesJoueur1 = 1
                Me.PartiesJoueur2 = 0
            Else
                Me.PartiesJoueur1 = 0
                Me.PartiesJoueur2 = 1
            End If
        End Sub

        Public Overrides Function ToString() As String
            Return "Le joueur " & Trim(nom) & " à un score de : " & score & Chr(13) _
                & "Il a joué " & PartiesJoueur1 & " parties en tant que joueur 1 et " & PartiesJoueur2 &
                " parties en joueur 2." & Chr(13) & "Il a gagné " & score & " fois et a joué " & cumulTemps & "secondes en tout."

        End Function
    End Structure

    Private joueurs(5) As Joueur

    Public Sub EnregistrerJoueur1(ByVal nom As String, ByVal resultat As Boolean, ByVal temps As Long)
        For i As Integer = 0 To joueurs.Length - 1
            If Not IsNothing(joueurs(i).nom) AndAlso Trim(joueurs(i).nom) = nom Then
                joueurs(i).PartiesJoueur1 += 1
                joueurs(i).cumulTemps += temps
                If resultat Then
                    joueurs(i).score += 1
                End If
                Exit Sub
            ElseIf IsNothing(joueurs(i).nom)
                joueurs(i) = New Joueur(nom, resultat, temps, 1)
                Exit Sub
            End If
        Next
        ajouterJoueur(nom, resultat, temps, 1)
    End Sub

    Private Sub ajouterJoueur(nom As String, resultat As Boolean, temps As Long, num As Integer)
        Dim place As Integer = joueurs.Length
        ReDim Preserve joueurs(place * 2 - 1)
        joueurs(place) = New Joueur(nom, resultat, temps, num)
    End Sub

    Public Sub EnregistrerJoueur2(ByVal nom As String, ByVal resultat As Boolean)
        For i As Integer = 0 To joueurs.Length - 1
            If Not IsNothing(joueurs(i).nom) AndAlso joueurs(i).nom = nom Then
                joueurs(i).PartiesJoueur2 += 1
                If resultat Then
                    joueurs(i).score += 1
                End If
                Exit Sub
            ElseIf IsNothing(joueurs(i).nom)
                joueurs(i) = New Joueur(nom, resultat, 0, 2)
                Exit Sub
            End If
        Next
        ajouterJoueur(nom, resultat, 0, 2)
    End Sub

    Public Sub ChargerJoueurs()
        Dim numFichier As Integer = FreeFile()
        FileOpen(numFichier, "Joueurs", OpenMode.Random)
        Dim i As Integer = 0
        While not EOF(numFichier)
            If i = joueurs.Length Then
                ReDim Preserve joueurs(joueurs.Length * 2 - 1)
            End If
            FileGet(numFichier, joueurs(i))
            i += 1
        End While
        FileClose(numFichier)
    End Sub

    Public Sub EnregistrerJoueurs()
        Dim numFichier As Integer = FreeFile()
        FileOpen(numFichier, "Joueurs", OpenMode.Random)

        For i As Integer = 0 To joueurs.Length() - 1
            If Not IsNothing(joueurs(i).nom) Then
                FilePut(numFichier, joueurs(i))
            End If
        Next
        FileClose(numFichier)
    End Sub

    Public Function getJoueurs() As Joueur()
        'Return joueurs
        'joueurs(0) = New Joueur()
        'joueurs(1) = New Joueur("Patrice", False, 2, 1)
        Return joueurs
    End Function
End Module
