Public Class Form1
    Dim tablero(2, 2) As Char ' Matriz de 3x3 para representar el tablero.
    Dim jugadorActivo As Char = "X" ' Variable para llevar la cuenta del jugador activo.
    Dim turnoJugador1 As Boolean = True ' Variable para mantener un registro del turno 

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If tablero(0, 0) = Nothing AndAlso Not turnoJugador1 Then ' Verifica que la celda esté vacía y es el turno del segundo jugador.
            tablero(0, 0) = jugadorActivo ' Coloca la ficha en el tablero.
            btn1.Text = jugadorActivo ' Actualiza la apariencia del botón.
            VerificarGanador() ' Verifica si alguien ha ganado.
            CambiarJugador() ' Cambia al siguiente jugador.
            ActualizarEstado() ' Actualiza el Label con el estado actual del juego.
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If tablero(0, 1) = Nothing AndAlso Not turnoJugador1 Then ' Verifica que la celda esté vacía y es el turno del segundo jugador.
            tablero(0, 1) = jugadorActivo ' Coloca la ficha en el tablero.
            btn2.Text = jugadorActivo ' Actualiza la apariencia del botón.
            VerificarGanador() ' Verifica si alguien ha ganado.
            CambiarJugador() ' Cambia al siguiente jugador.
            ActualizarEstado() ' Actualiza el Label con el estado actual del juego.
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If tablero(0, 2) = Nothing AndAlso Not turnoJugador1 Then ' Verifica que la celda esté vacía y es el turno del segundo jugador.
            tablero(0, 2) = jugadorActivo ' Coloca la ficha en el tablero.
            btn3.Text = jugadorActivo ' Actualiza la apariencia del botón.
            VerificarGanador() ' Verifica si alguien ha ganado.
            CambiarJugador() ' Cambia al siguiente jugador.
            ActualizarEstado() ' Actualiza el Label con el estado actual del juego.
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If tablero(1, 0) = Nothing AndAlso Not turnoJugador1 Then ' Verifica que la celda esté vacía y es el turno del segundo jugador.
            tablero(1, 0) = jugadorActivo ' Coloca la ficha en el tablero.
            btn4.Text = jugadorActivo ' Actualiza la apariencia del botón.
            VerificarGanador() ' Verifica si alguien ha ganado.
            CambiarJugador() ' Cambia al siguiente jugador.
            ActualizarEstado() ' Actualiza el Label con el estado actual del juego.
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If tablero(1, 1) = Nothing AndAlso turnoJugador1 Then ' Verifica que la celda esté vacía y es el turno del primer jugador.
            tablero(1, 1) = jugadorActivo ' Coloca la ficha en el tablero.
            btn5.Text = jugadorActivo ' Actualiza la apariencia del botón.
            VerificarGanador() ' Verifica si alguien ha ganado.
            CambiarJugador() ' Cambia al siguiente jugador.
            turnoJugador1 = False ' El primer jugador ya jugó, cambia el turno.
            ActualizarEstado() ' Actualiza el Label con el estado actual del juego.
        End If
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If tablero(1, 2) = Nothing AndAlso Not turnoJugador1 Then ' Verifica que la celda esté vacía y es el turno del segundo jugador.
            tablero(1, 2) = jugadorActivo ' Coloca la ficha en el tablero.
            btn6.Text = jugadorActivo ' Actualiza la apariencia del botón.
            VerificarGanador() ' Verifica si alguien ha ganado.
            CambiarJugador() ' Cambia al siguiente jugador.
            ActualizarEstado() ' Actualiza el Label con el estado actual del juego.
        End If
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If tablero(2, 0) = Nothing AndAlso Not turnoJugador1 Then ' Verifica que la celda esté vacía y es el turno del segundo jugador.
            tablero(2, 0) = jugadorActivo ' Coloca la ficha en el tablero.
            btn7.Text = jugadorActivo ' Actualiza la apariencia del botón.
            VerificarGanador() ' Verifica si alguien ha ganado.
            CambiarJugador() ' Cambia al siguiente jugador.
            ActualizarEstado() ' Actualiza el Label con el estado actual del juego.
        End If
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If tablero(2, 1) = Nothing AndAlso Not turnoJugador1 Then ' Verifica que la celda esté vacía y es el turno del segundo jugador.
            tablero(2, 1) = jugadorActivo ' Coloca la ficha en el tablero.
            btn8.Text = jugadorActivo ' Actualiza la apariencia del botón.
            VerificarGanador() ' Verifica si alguien ha ganado.
            CambiarJugador() ' Cambia al siguiente jugador.
            ActualizarEstado() ' Actualiza el Label con el estado actual del juego.
        End If
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If tablero(2, 2) = Nothing AndAlso Not turnoJugador1 Then ' Verifica que la celda esté vacía y es el turno del segundo jugador.
            tablero(2, 2) = jugadorActivo ' Coloca la ficha en el tablero.
            btn9.Text = jugadorActivo ' Actualiza la apariencia del botón.
            VerificarGanador() ' Verifica si alguien ha ganado.
            CambiarJugador() ' Cambia al siguiente jugador.
            ActualizarEstado() ' Actualiza el Label con el estado actual del juego.
        End If
    End Sub

    Private Sub CambiarJugador()
        If jugadorActivo = "X" Then
            jugadorActivo = "O"
        Else
            jugadorActivo = "X"
        End If
    End Sub

    Private Sub VerificarGanador()
        ' Verifica todas las combinaciones posibles de tres fichas en línea.
        If tablero(0, 0) = jugadorActivo And tablero(0, 1) = jugadorActivo And tablero(0, 2) = jugadorActivo Then
            MostrarMensaje("¡" & jugadorActivo & " ha ganado!")
            DeshabilitarBotones()
        ElseIf tablero(1, 0) = jugadorActivo And tablero(1, 1) = jugadorActivo And tablero(1, 2) = jugadorActivo Then
            MostrarMensaje("¡" & jugadorActivo & " ha ganado!")
            DeshabilitarBotones()
        ElseIf tablero(2, 0) = jugadorActivo And tablero(2, 1) = jugadorActivo And tablero(2, 2) = jugadorActivo Then
            MostrarMensaje("¡" & jugadorActivo & " ha ganado!")
            DeshabilitarBotones()
        ElseIf tablero(0, 0) = jugadorActivo And tablero(1, 0) = jugadorActivo And tablero(2, 0) = jugadorActivo Then
            MostrarMensaje("¡" & jugadorActivo & " ha ganado!")
            DeshabilitarBotones()
        ElseIf tablero(0, 1) = jugadorActivo And tablero(1, 1) = jugadorActivo And tablero(2, 1) = jugadorActivo Then
            MostrarMensaje("¡" & jugadorActivo & " ha ganado!")
            DeshabilitarBotones()
        ElseIf tablero(0, 2) = jugadorActivo And tablero(1, 2) = jugadorActivo And tablero(2, 2) = jugadorActivo Then
            MostrarMensaje("¡" & jugadorActivo & " ha ganado!")
            DeshabilitarBotones()
        ElseIf tablero(0, 0) = jugadorActivo And tablero(1, 1) = jugadorActivo And tablero(2, 2) = jugadorActivo Then
            MostrarMensaje("¡" & jugadorActivo & " ha ganado!")
            DeshabilitarBotones()
        ElseIf tablero(0, 2) = jugadorActivo And tablero(1, 1) = jugadorActivo And tablero(2, 0) = jugadorActivo Then
            MostrarMensaje("¡" & jugadorActivo & " ha ganado!")
            DeshabilitarBotones()
        End If
    End Sub

    Private Sub MostrarMensaje(mensaje As String)
        MessageBox.Show(mensaje)
    End Sub

    Private Sub DeshabilitarBotones()
        ' Recorre todos los botones en el formulario y los deshabilita.
        For Each boton As Button In Me.Controls.OfType(Of Button)()
            boton.Enabled = False
        Next
    End Sub

    Private Sub ActualizarEstado()
        lblEstado.Text = "Es el turno del jugador " & jugadorActivo
    End Sub

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
