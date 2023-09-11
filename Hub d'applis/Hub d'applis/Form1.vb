Imports System.IO

Public Class Form1
    Dim strFileName As String
    Dim maad As String = Path.Combine(IO.Directory.GetParent(Application.ExecutablePath).FullName)
    Private folderBrowserDialog1 As Object
    Public Property MyString As Object

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ComboBox1.Items.Clear() ' clear combobox
        Dim num As Integer = 0


        Try
            Dim monStreamReader As New StreamReader(maad + "\Config New app")
            Dim ligne, ligne2 As String
            Dim taille, taillel As Integer
            ligne2 = "empty"
            Do
                ligne = monStreamReader.ReadLine
                Dim subs As String() = ligne.Split(" "c, "."c)
                Dim apps As String
                Dim Name As String
                For Each substring As String In subs
                    apps = $"{substring}"
                    taille = Len(apps)
                    taillel = Len(ligne) + 4

                    If ligne.Length <> ligne2.Length Then

                        Name = Mid(ligne, 1, taille)
                        ComboBox1.Items.Add(Name)
                        ligne2 = ligne

                    End If



                Next

                ' TRAITEMENT A EFFECTUER SUR LA LIGNE ICI


            Loop Until monStreamReader.EndOfStream()
            monStreamReader.Close()

        Catch ex As Exception
            MsgBox("Erreur normal au premier lancement, sinon problème de dossier." & vbCrLf & vbCrLf & "Veuillez vérifier l'emplacement : " & maad + "\Config New app", MsgBoxStyle.Critical, "Erreur lors de l'ouverture du fichier conf...")
        End Try

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim maad As String = Path.Combine(IO.Directory.GetParent(Application.ExecutablePath).FullName)
        Try

            PictureBox1.Image = Image.FromFile(maad + "\Images\" + ComboBox1.Text + ".png")

        Catch ex As Exception

            PictureBox1.Image = My.Resources.ConsoleNotFound

        End Try




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim proc As New System.Diagnostics.Process
        Dim maad As String = Path.Combine(IO.Directory.GetParent(Application.ExecutablePath).FullName)

        If ComboBox1.Text.Contains("Choisir") = False Then
            Dim num As Integer = 0
            Try
                Dim monStreamReader As New StreamReader(maad + "\Config New app")
                Dim ligne As String
                Dim taille As Integer

                Do
                    ligne = monStreamReader.ReadLine
                    Dim subs As String() = ligne.Split(" "c, "."c)
                    Dim apps As String
                    For Each substring As String In subs
                        num = num + 1
                        apps = $"{substring}"

                        If ComboBox1.Text = apps Then
                            'ligne est le nom : chemin d'acces
                            taille = Len(apps) + 4
                            Dim path As String = Mid(ligne, taille)
                            proc.Start(path)



                        End If


                    Next

                    ' TRAITEMENT A EFFECTUER SUR LA LIGNE ICI


                Loop Until monStreamReader.EndOfStream()
                monStreamReader.Close()

            Catch ex As Exception
                MsgBox("Le chemin d'acces spécifié n'existe pas", MsgBoxStyle.Critical, "Erreur lors de l'ouverture du fichier ")
            End Try


        ElseIf ComboBox1.Text.Contains("Choisir") = True Then
            MsgBox("Tu dois choisir une application !")


        End If


    End Sub


    Private Sub ContactezNousToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactezNousToolStripMenuItem.Click
        MsgBox("Discord : Unknow#3137 ")
    End Sub



    Private Sub SuppriméToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuppriméToolStripMenuItem.Click

        'Me.Hide()
        'Form2.Show()

    End Sub

    Private Sub AjouterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjouterToolStripMenuItem.Click
        Me.Hide()
        Form3.Show()

    End Sub


    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub


    Private Sub ModifierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifierToolStripMenuItem.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class


