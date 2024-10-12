<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txbNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txbApellido = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txbUsuario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txbPass = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txbPass2 = New System.Windows.Forms.TextBox()
        Me.botRegistrar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txbTelefono = New System.Windows.Forms.TextBox()
        Me.labError = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txbFecha = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(242, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Registro de usuarios"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(59, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Ingrese su nombre:(*)"
        '
        'txbNombre
        '
        Me.txbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbNombre.Location = New System.Drawing.Point(59, 110)
        Me.txbNombre.Name = "txbNombre"
        Me.txbNombre.Size = New System.Drawing.Size(249, 31)
        Me.txbNombre.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(390, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(193, 24)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Ingrese su apellido:(*)"
        '
        'txbApellido
        '
        Me.txbApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbApellido.Location = New System.Drawing.Point(390, 110)
        Me.txbApellido.Name = "txbApellido"
        Me.txbApellido.Size = New System.Drawing.Size(249, 31)
        Me.txbApellido.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(59, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(289, 24)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Ingrese un nombre de usuario:(*)"
        '
        'txbUsuario
        '
        Me.txbUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbUsuario.Location = New System.Drawing.Point(59, 222)
        Me.txbUsuario.Name = "txbUsuario"
        Me.txbUsuario.Size = New System.Drawing.Size(580, 31)
        Me.txbUsuario.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(63, 292)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(220, 24)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Ingrese su contraseña:(*)"
        '
        'txbPass
        '
        Me.txbPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbPass.Location = New System.Drawing.Point(63, 334)
        Me.txbPass.Name = "txbPass"
        Me.txbPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txbPass.Size = New System.Drawing.Size(249, 31)
        Me.txbPass.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(386, 292)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(233, 24)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Confirme su contraseña:(*)"
        '
        'txbPass2
        '
        Me.txbPass2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbPass2.Location = New System.Drawing.Point(386, 334)
        Me.txbPass2.Name = "txbPass2"
        Me.txbPass2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txbPass2.Size = New System.Drawing.Size(249, 31)
        Me.txbPass2.TabIndex = 13
        '
        'botRegistrar
        '
        Me.botRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botRegistrar.Location = New System.Drawing.Point(274, 539)
        Me.botRegistrar.Name = "botRegistrar"
        Me.botRegistrar.Size = New System.Drawing.Size(148, 59)
        Me.botRegistrar.TabIndex = 15
        Me.botRegistrar.Text = "Regristrarme"
        Me.botRegistrar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(67, 405)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(175, 24)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Ingrese su telefono:"
        '
        'txbTelefono
        '
        Me.txbTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbTelefono.Location = New System.Drawing.Point(67, 447)
        Me.txbTelefono.Name = "txbTelefono"
        Me.txbTelefono.Size = New System.Drawing.Size(249, 31)
        Me.txbTelefono.TabIndex = 16
        '
        'labError
        '
        Me.labError.AutoSize = True
        Me.labError.ForeColor = System.Drawing.Color.Red
        Me.labError.Location = New System.Drawing.Point(68, 611)
        Me.labError.Name = "labError"
        Me.labError.Size = New System.Drawing.Size(0, 13)
        Me.labError.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(386, 405)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(278, 24)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Ingrese su fecha de nacimiento:"
        '
        'txbFecha
        '
        Me.txbFecha.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbFecha.Location = New System.Drawing.Point(386, 453)
        Me.txbFecha.Name = "txbFecha"
        Me.txbFecha.Size = New System.Drawing.Size(278, 20)
        Me.txbFecha.TabIndex = 21
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 681)
        Me.Controls.Add(Me.txbFecha)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.labError)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txbTelefono)
        Me.Controls.Add(Me.botRegistrar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txbPass2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txbPass)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txbUsuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txbApellido)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txbNombre)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Registro"
        Me.Text = "Registro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txbNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txbApellido As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txbUsuario As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txbPass As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txbPass2 As TextBox
    Friend WithEvents botRegistrar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txbTelefono As TextBox
    Friend WithEvents labError As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txbFecha As DateTimePicker
End Class
