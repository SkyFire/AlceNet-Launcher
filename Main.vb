Public Class Main

    '
    '   Cargamos la funcion Load, para comprobar la conexion
    '

    '   Declaramos los Objetos
    Dim obj_Connection As New alc_Connection
    Dim obj_INI As New alc_INI

    '   Declaramos las variables
    Dim tst_Internet As Boolean
    Dim tst_WowDir As Boolean

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '   Comprobamos la conexion a internet
        If obj_Connection.ConexionInternet = False Then
            '   En caso de no tener conexion cerramos el launcher.
            MsgBox("ERROR: No dispones de conexion a internet.")
            tst_Internet = False
            Me.Close()
        End If

        '   Comprobamos que tenga ruta del juego ya añadida.
        obj_INI.Parametro = "wowdir"
        If obj_INI.Get_Opciones = False Then
            '   En caso de no tener la carpeta del juego seleccionada desabilitamos el boton de jugar.
            img_jugar_on.Enabled = False
            img_jugar_off.Enabled = False
            tst_WowDir = False
        End If

    End Sub




    '
    '   Boton de Cerrar
    '

    ' Mouse HOVER

    Private Sub img_cerrar_off_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles img_cerrar_off.MouseEnter
        ' ocultamos el boton off y mostramos el ON
        img_cerrar_off.Visible = False
        img_cerrar_on.Visible = True
    End Sub
    Private Sub img_cerrar_on_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles img_cerrar_on.MouseLeave
        ' ocultamos el boton ON y mostramos el OFF
        img_cerrar_off.Visible = True
        img_cerrar_on.Visible = False
    End Sub


    ' Mouse CLICK

    Private Sub img_cerrar_on_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles img_cerrar_on.Click
        Application.Exit()
    End Sub


    '
    '   Boton de Minimizar
    '

    ' Mouse HOVER

    Private Sub img_minimizar_off_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles img_minimizar_off.MouseEnter
        ' ocultamos el boton off y mostramos el ON
        img_minimizar_off.Visible = False
        img_minimizar_on.Visible = True
    End Sub
    Private Sub img_minimizar_on_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles img_minimizar_on.MouseLeave
        ' ocultamos el boton ON y mostramos el OFF
        img_minimizar_off.Visible = True
        img_minimizar_on.Visible = False
    End Sub



    ' Mouse CLICK    

    Private Sub img_minimizar_on_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles img_minimizar_on.Click
        Me.WindowState = FormWindowState.Minimized

        Me.Visible = False

        nfi.Visible = True

        'MsgBox("FTProgram has been minimized to the task bar.")

        nfi.Icon = SystemIcons.Exclamation
        nfi.BalloonTipTitle = "Balloon Tip Title"
        nfi.BalloonTipText = "Balloon Tip Text."
        nfi.BalloonTipIcon = ToolTipIcon.Error
        nfi.ShowBalloonTip(1)

        ' timer

        Timer1.Start()
        Timer1.Interval = 3000

    End Sub


    '
    '   Boton de Jugar
    '

    ' Mouse HOVER

    Private Sub img_jugar_on_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles img_jugar_on.MouseLeave
        ' ocultamos el boton off y mostramos el ON
        img_jugar_off.Visible = True
        img_jugar_on.Visible = False
    End Sub
    Private Sub img_jugar_off_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles img_jugar_off.MouseEnter
        ' ocultamos el boton ON y mostramos el OFF
        img_jugar_off.Visible = False
        img_jugar_on.Visible = True
    End Sub


    ' Mouse CLICK     

    Private Sub img_jugar_on_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles img_jugar_on.Click
        MsgBox("Pulsado boton de jugar")
    End Sub


    '
    '   ICONO area notificaciones
    '

    ' Eventos 

    Private Sub nfi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nfi.Click
        ' comprobamos si esta minizmiado o maximizada el form al dar click
        If Me.WindowState = FormWindowState.Minimized Then
            'en caso de estar minimizado lo abrimos
            Me.Visible = True
            Me.WindowState = FormWindowState.Normal
            nfi.Visible = False
        End If

    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        nfi.Icon = My.Resources.view_right
        nfi.BalloonTipTitle = ""
        nfi.BalloonTipText = ""
        Timer1.Stop()
    End Sub

    
End Class
