Public Class Form1
    'el boton de enviar se debe cambiar por el tres en raya, matriz (3,3)
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AxWinsock1.Listen()
        estado()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'CheckForIllegalCrossThreadCalls = False
        Label1.Text = Label1.Text & "   " & AxWinsock1.LocalIP
        estado()
    End Sub

    Private Sub AxWinsock1_ConnectionRequest(ByVal sender As Object, ByVal e As AxMSWinsockLib.DMSWinsockControlEvents_ConnectionRequestEvent) Handles AxWinsock1.ConnectionRequest
        If AxWinsock1.CtlState <> MSWinsockLib.StateConstants.sckConnected Then   ' Si no està connectat
            AxWinsock1.Close() 'cierra la escucha
            AxWinsock1.Accept(e.requestID) 'acepta petición 
        End If
    End Sub

    Private Sub AxWinsock1_DataArrival(ByVal sender As Object, ByVal e As AxMSWinsockLib.DMSWinsockControlEvents_DataArrivalEvent) Handles AxWinsock1.DataArrival
        Dim datos As String = ""
        AxWinsock1.GetData(datos, vbString, 1000)
        TextBox1.Text = TextBox1.Text + datos

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim enviar As String
        enviar = TextBox2.Text
        AxWinsock1.SendData(enviar)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        If AxWinsock2.CtlState = MSWinsockLib.StateConstants.sckClosed Then
            AxWinsock2.RemoteHost = AxWinsock1.LocalIP 'aqui recoge la ip. Se puede cambiar por un textbox
            AxWinsock2.Connect() 'se conecta 
        End If


    End Sub

    Private Sub AxWinsock2_DataArrival(ByVal sender As Object, ByVal e As AxMSWinsockLib.DMSWinsockControlEvents_DataArrivalEvent) Handles AxWinsock2.DataArrival 'recibir datos
        Dim datos As String = ""
        AxWinsock2.GetData(datos, vbString, 1000)
        TextBox4.Text = TextBox4.Text + datos

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim enviar As String
        enviar = TextBox3.Text
        AxWinsock2.SendData(enviar)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        AxWinsock1.Close()
        End
    End Sub
    Sub estado()
        Select Case AxWinsock1.CtlState ' estados 
            Case MSWinsockLib.StateConstants.sckClosed
                Label4.Text = "Cerrado"
            Case MSWinsockLib.StateConstants.sckOpen
                Label4.Text = "Open"
            Case MSWinsockLib.StateConstants.sckListening
                Label4.Text = "Listening"
            Case MSWinsockLib.StateConstants.sckConnectionPending
                Label4.Text = "Connection pending"
            Case MSWinsockLib.StateConstants.sckResolvingHost
                Label4.Text = "Resolving host"
            Case MSWinsockLib.StateConstants.sckHostResolved
                Label4.Text = "Host resolved"
            Case MSWinsockLib.StateConstants.sckConnecting
                Label4.Text = "Connecting"
            Case MSWinsockLib.StateConstants.sckConnected
                Label4.Text = "Connected"
            Case MSWinsockLib.StateConstants.sckClosing
                Label4.Text = "Peer has closed the connection!"
            Case MSWinsockLib.StateConstants.sckError
                Label4.Text = "Error"
                AxWinsock1.Close()
        End Select
    End Sub
End Class
