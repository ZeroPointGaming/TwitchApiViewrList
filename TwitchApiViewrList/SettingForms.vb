Imports System.ComponentModel

Public Class SettingForms
    Private Sub Settings_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SaveSettingsBtn.Click
        My.Settings.username = TextBox1.Text.ToString()
        My.Settings.Save()
    End Sub

    Private Sub SettingForms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            TextBox1.Text = My.Settings.username.ToString()
        Catch ex As Exception
            MessageBox.Show("You have not saved a username, please enter a username and click save. You can find this by going to your twitch channel and looking at the internet address http://twitch.tv/YOURUSERNAME")
        End Try
    End Sub
End Class