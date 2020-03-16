Imports System.IO
Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Fichier.Click

    End Sub

    Private Sub AllerSurLeSiteDeAdaubeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllerSurLeSiteDeAdaubeToolStripMenuItem.Click
        Process.Start("http://51.38.187.135/dev/ADAUBE/")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If My.Computer.FileSystem.FileExists(Application.StartupPath & "\productkey.txt") Then
        'Dim objStreamReader As StreamReader
        'Dim strLine As String

        'Pass the file path and the file name to the StreamReader constructor.

        'objStreamReader = New StreamReader(Application.StartupPath & "\productkey.txt")
        'strLine = objStreamReader.ReadLine

        'If strLine = "" Then
        'MsgBox("Votre clé est n'importe quoi")
        'Me.Close()
        'End If

        'Close the file.
        'objStreamReader.Close()

        EnregistrerToolStripMenuItem.Enabled = False
        EnregistrerSousToolStripMenuItem.Enabled = False
        If My.Computer.FileSystem.DirectoryExists("C:\Users\" & Environment.UserName & "\Adaube\AACB\Projects\") Then
        Else
            MsgBox("Vous utilisez une version non-officielle de ADP !")
            'Me.Close()
        End If
        'Else
        MsgBox("Vous n'avez pas la clé de production !")
        'Me.Close()
        'End If
    End Sub

    Private Sub EnregistrerToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub EnregistrerSousToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnregistrerSousToolStripMenuItem.Click

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Audio.Play(My.Resources.Rasputin, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub MenuStrip2_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip2.ItemClicked

    End Sub

    Private Sub CreativeCloudToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreativeCloudToolStripMenuItem.Click

    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click

    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click

    End Sub

    Private Sub VotreComtpeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VotreComtpeToolStripMenuItem.Click

    End Sub
End Class
