Public Class alc_Connection


    '
    '   Funcion Publica: Comprobar conexion a internet.
    '
    Public Function ConexionInternet() As Boolean
        ' Debolbemos un Boolean al comprobar la conexion.
        ' Se comprueba el sitio de la web, de google como garantia de que este online.

        Dim objUrl As New System.Uri("http://www.google.es/")
        ' Setup WebRequest
        Dim objWebReq As System.Net.WebRequest
        objWebReq = System.Net.WebRequest.Create(objUrl)
        Dim objResp As System.Net.WebResponse
        Try
            ' Intento de obtener respuesta y devolver TRUE
            objResp = objWebReq.GetResponse
            objResp.Close()
            objWebReq = Nothing
            Return True
        Catch ex As Exception
            objResp = objWebReq.GetResponse
            ' Error, salir y devolver FALSE
            objResp.Close()
            objWebReq = Nothing
            Return False
        End Try
    End Function

End Class
