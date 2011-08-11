Public Class alc_INI

    Public Parametro As String

    Private Function comprobar_parametro(ByVal valor As String) As Boolean

        If valor = "null" Then
            Return False
        Else
            Return True
        End If

    End Function

    Public Function Get_Opciones() As Boolean

        If Parametro = "wowdir" Then
            'Return My.Settings.set_wowdir
            Return comprobar_parametro(My.Settings.set_wowdir)
        ElseIf Parametro = "caca" Then
            Return comprobar_parametro(My.Settings.set_wowdir)
        Else
            Return False
        End If

    End Function

End Class
