Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txbUsuario.TextChanged

    End Sub

    Private Sub botLogin_Click(sender As Object, e As EventArgs) Handles botLogin.Click

        labError.Text = ""

        If txbUsuario.Text = "" Then
            labError.Text = "Debe ingresar su usuario"
        End If

        If txbPass.Text = "" Then
            labError.Text = labError.Text + " Debe ingresar su contraseña"
        End If

        If txbUsuario.Text <> "" And txbPass.Text <> "" Then
            Dim objBDD As ConexionBD = New ConexionBD
            Dim resultadoUsurio As DataTable = New DataTable

            resultadoUsurio = objBDD.SelectQuery("Select COUNT(*) from Usuario where Usuario = '" & txbUsuario.Text & "' and Pass = '" & txbPass.Text & "' and Activo = 'A'")


            If resultadoUsurio.Rows(0)(0).ToString() = "1" Then
                Dim PFacturas As PantallaFacturas = New PantallaFacturas()
                PFacturas.Show()
                Me.Hide()
            Else
                labError.Text = "Usuario o contraseña incorrectos"
            End If

        End If
    End Sub

    Private Sub botRegistrar_Click(sender As Object, e As EventArgs) Handles botRegistrar.Click
        Dim pantallaRegistro As Registro
        pantallaRegistro = New Registro


        pantallaRegistro.Show()

    End Sub
End Class
