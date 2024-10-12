Public Class Registro
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txbUsuario.TextChanged

    End Sub

    Private Sub botRegistrar_Click(sender As Object, e As EventArgs) Handles botRegistrar.Click
        labError.Text = ""

        'Se ejecuta solo si los campos tienen valores
        If txbNombre.Text <> "" And txbApellido.Text <> "" And txbUsuario.Text <> "" And txbPass.Text <> "" And txbPass2.Text <> "" Then

            If txbPass.Text = txbPass2.Text And txbNombre.Text.Trim <> "" Then
                labError.Text = ""

                'Validar repetidos
                Dim objBdd As New ConexionBD()
                Dim resultado As New DataTable()
                resultado = objBdd.SelectQuery("select count(*) from Usuario where usuario = '" & txbUsuario.Text & "'")

                If resultado.Rows(0)(0).ToString() = "0" Then
                    txbFecha.Format = DateTimePickerFormat.Custom
                    txbFecha.CustomFormat = "yyyy-MM-dd"
                    Dim fecha As String = txbFecha.Value.ToString("yyyy-MM-dd")

                    objBdd.InsertarDatos("insert into Usuario (Nombre, Apellido, Usuario, Pass, Telefono, FechaNac, NumeroErrores, Activo, UltimoLogin) values('" & txbNombre.Text & "', '" & txbApellido.Text & "', '" & txbUsuario.Text & "', '" & txbPass.Text & "', '" & txbTelefono.Text & "', '" & fecha & "', 0, 'A', GETDATE());")

                    Dim PFacturas As PantallaFacturas = New PantallaFacturas()
                    PFacturas.Show()
                    Me.Close()

                Else
                    labError.Text = "El usuario ya existe"
                End If

            Else
                    labError.Text = "Las contraseñas deben ser iguales y el campo nombre debe tener un valor"
            End If
        Else
            labError.Text = "Todos los campos con (*) son obligatorios"
        End If



    End Sub
End Class