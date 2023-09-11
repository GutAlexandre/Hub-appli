Imports System.IO

Public Class Form3
    Dim strFileName As String

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim Path1 As String
        Path1 = Environ$("USERPROFILE") & "\Desktop"

        fd.Title = "Choix de l'application"
        fd.InitialDirectory = Path1
        fd.Filter = "Exe Files (.exe)|*.exe"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            TextBox2.Text = fd.FileName

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim Path1 As String
        Path1 = Environ$("USERPROFILE") & "\Pictures"

        fd.Title = "Image d'application"
        fd.InitialDirectory = Path1
        fd.Filter = "All Images|*.BMP;*.DIB;*.RLE;*.JPG;*.JPEG;*.JPE;*.JFIF;*.GIF;*.TIF;*.TIFF;*.PNG|BMP Files: (*.BMP;*.DIB;*.RLE)|*.BMP;*.DIB;*.RLE|JPEG Files: (*.JPG;*.JPEG;*.JPE;*.JFIF)|*.JPG;*.JPEG;*.JPE;*.JFIF|GIF Files: (*.GIF)|*.GIF|TIFF Files: (*.TIF;*.TIFF)|*.TIF;*.TIFF|PNG Files: (*.PNG)|*.PNG"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            TextBox3.Text = fd.FileName
            strFileName = fd.FileName
            PictureBox1.Image = Image.FromFile(strFileName)

        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim name As String
        name = TextBox1.Text
        If name.Contains(" ") Then
            MsgBox("Choississez un nom ans espaces !! ", MsgBoxStyle.Critical, "Erreur lors du choix du nom")
            Exit Sub
        End If
        Dim maad As String = Path.Combine(IO.Directory.GetParent(Application.ExecutablePath).FullName)
        ' Création d'un fichier png 

        If TextBox3.Text <> "" Then
            My.Computer.FileSystem.CopyFile(strFileName, maad + "\Images\" + name + ".png", True)
        End If

        'écriture dans ce fichier
        File.AppendAllText(maad + "\Config New app", name + " : " + TextBox2.Text + vbNewLine) ' Name : path
        IO.File.SetAttributes("Config New app", IO.FileAttributes.Hidden)

        MsgBox("Application Ajoutée Redemmarez l'application pour voir l'ajout")
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        PictureBox1.Image = My.Resources.Console
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Me.Hide()
        Form1.Show()

    End Sub


End Class

