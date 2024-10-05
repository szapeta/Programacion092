Public Class Registro
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txbUsuario.TextChanged

    End Sub

    Private Sub botRegistrar_Click(sender As Object, e As EventArgs) Handles botRegistrar.Click
        labError.Text = ""

        If txbPass.Text = txbPass2.Text And txbNombre.Text.Trim <> "" Then
            labError.Text = ""

            Dim objBdd As New ConexionBD()
            objBdd.InsertarDatos("insert into Usuario (Nombre, Apellido, Usuario, Pass, Telefono, FechaNac, NumeroErrores, Activo, UltimoLogin) 
        values(" & txbNombre.Text & ", 'Felipe', 'pruebasfelipe', '123', '+(502) 32323232', '2000-09-13', 0, 'A', GETDATE());")

        Else
            labError.Text = "Las contraseñas deben ser iguales y el campo nombre debe tener un valor"
        End If

    End Sub
End Class