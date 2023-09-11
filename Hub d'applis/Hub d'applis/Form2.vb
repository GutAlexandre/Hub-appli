Imports System.IO

Public Class Form2
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Label5.Text = ListBox1.SelectedItem
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim num As Integer = 0
        Dim maad As String = Path.Combine(IO.Directory.GetParent(Application.ExecutablePath).FullName)

        '    Try
        '        Dim monStreamReader As New StreamReader(maad + "\Config New app")
        '        Dim ligne, ligne2 As String
        '        Dim taille, taillel As Integer
        '        ligne2 = "empty"
        '        Do
        '            ligne = monStreamReader.ReadLine
        '            Dim subs As String() = ligne.Split(" "c, "."c)
        '            Dim apps As String
        '            Dim Name As String
        '            For Each substring As String In subs
        '                apps = $"{substring}"
        '                taille = Len(apps)
        '                taillel = Len(ligne) + 4

        '                If ligne.Length <> ligne2.Length Then

        '                    Name = Mid(ligne, 1, taille)
        '                    ListBox1.Items.Add(Name)
        '                    ligne2 = ligne

        '                End If



        '            Next

        '            ' TRAITEMENT A EFFECTUER SUR LA LIGNE ICI


        '        Loop Until monStreamReader.EndOfStream()
        '        monStreamReader.Close()

        '    Catch ex As Exception
        '        MsgBox("Erreur normal au premier lancement, sinon problème de dossier." & vbCrLf & vbCrLf & "Veuillez vérifier l'emplacement : " & maad + "\Config New app", MsgBoxStyle.Critical, "Erreur lors de l'ouverture du fichier conf...")
        '    End Try
    End Sub

End Class