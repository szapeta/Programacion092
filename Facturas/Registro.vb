Public Class Registro
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txbUsuario.TextChanged

    End Sub

    Private Sub botRegistrar_Click(sender As Object, e As EventArgs) Handles botRegistrar.Click
        labError.Text = ""

        If txbPass.Text <> txbPass2.Text Then
            labError.Text = "Las contraseñas deben de coincidir"
        End If
    End Sub
End Class