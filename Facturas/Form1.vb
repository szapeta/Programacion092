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


    End Sub

    Private Sub botRegistrar_Click(sender As Object, e As EventArgs) Handles botRegistrar.Click
        Dim pantallaRegistro As Registro
        pantallaRegistro = New Registro


        pantallaRegistro.Show()

    End Sub
End Class
