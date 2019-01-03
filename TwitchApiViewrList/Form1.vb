Imports System.Web.Script.Serialization
Imports System.IO
Imports System.Net


Public Class Form1
    Public username As String = "enraged_ares"

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        SettingForms.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub FetchData(username As String)
        Dim url_string = "https://tmi.twitch.tv/group/user/" + username + "/chatters"

        'Request JSON
        Dim Req As HttpWebRequest
        Dim Ret As HttpWebResponse = Nothing
        Dim SR As StreamReader
        Req = DirectCast(WebRequest.Create(url_string), HttpWebRequest)
        Ret = DirectCast(Req.GetResponse(), HttpWebResponse)
        SR = New StreamReader(Ret.GetResponseStream())
        Dim Raw As String = Nothing
        Raw = SR.ReadToEnd()

        'Process the requested JSON into usable dictionaries
        Dim DATA_OBJECT As New Chatters()
        Dim JavaScriptSerialization As New JavaScriptSerializer()
        DATA_OBJECT = JavaScriptSerialization.Deserialize(Raw, DATA_OBJECT.GetType)

        'Viewers
        For Each member In DATA_OBJECT.chatters.viewers
            TextBox1.Text += member.ToString() + Environment.NewLine
        Next
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        FetchData(username)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FetchData(username)
    End Sub
End Class

'Serialization Classes
<Serializable>
Public Class Chatters
    Public _links
    <Runtime.Serialization.DataMember>
    Public chatter_count As Integer
    <Runtime.Serialization.DataMember>
    Public chatters As Groups
End Class

<SerializableAttribute>
Public Class Groups
    <Runtime.Serialization.DataMember>
    Public vips As String()
    <Runtime.Serialization.DataMember>
    Public moderators As String()
    <Runtime.Serialization.DataMember>
    Public staff As String()
    <Runtime.Serialization.DataMember>
    Public admins As String()
    <Runtime.Serialization.DataMember>
    Public global_mods As String()
    <Runtime.Serialization.DataMember>
    Public viewers As String()
End Class
