Public Class PantallaFacturas
    Private Sub PantallaFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objFacturas As ConexionBD
        objFacturas = New ConexionBD()

        dgvFacturas.DataSource = objFacturas.SelectQuery("select * from Factura")

    End Sub
End Class