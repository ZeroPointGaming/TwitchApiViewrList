Imports System.ComponentModel

Public Class SettingForms
    Private Sub Settings_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SaveSettingsBtn.Click
        My.Settings.username = TextBox1.Text.ToString()
        My.Settings.Save()
    End Sub
End Class