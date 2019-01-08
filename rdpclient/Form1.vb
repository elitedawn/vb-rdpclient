Imports MSTSCLib

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Application.CommandLineArgs.Count >= 3 Then
            rdpclient.Server = My.Application.CommandLineArgs.Item(0)
            rdpclient.UserName = My.Application.CommandLineArgs.Item(1)
            Dim secured As IMsTscNonScriptable = DirectCast(rdpclient.GetOcx(), IMsTscNonScriptable)
            secured.ClearTextPassword = My.Application.CommandLineArgs.Item(2)
            ipadd.Text = "IP Address: " + My.Application.CommandLineArgs.Item(0)
            uname.Text = "User Name: " + My.Application.CommandLineArgs.Item(1)
            rdpclient.Connect()
        Else
            Application.Exit()
        End If
    End Sub

    Private Sub rdpclient_OnConnecting(sender As Object, e As EventArgs) Handles rdpclient.OnConnecting
        constat.Text = "Status: Connecting"
    End Sub

    Private Sub onconnected() Handles rdpclient.OnConnected
        constat.Text = "Status: Connected"
    End Sub

    Private Sub ondisconnect() Handles rdpclient.OnDisconnected
        constat.Text = "Status: Disconnected"
        Application.Exit()
    End Sub

    Private Sub onerror() Handles rdpclient.OnFatalError
        MessageBox.Show("Error Connecting to: " + My.Application.CommandLineArgs.Item(0), "Fatal Error!")
    End Sub

    Private Sub on_exit(sender As Object, e As EventArgs) Handles MyBase.Closing
        rdpclient.Disconnect()
    End Sub
End Class
