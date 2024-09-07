<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.botLogin = New System.Windows.Forms.Button()
        Me.txbUsuario = New System.Windows.Forms.TextBox()
        Me.txbPass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.labError = New System.Windows.Forms.Label()
        Me.botRegistrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(153, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Inicio de Sesión"
        '
        'botLogin
        '
        Me.botLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botLogin.Location = New System.Drawing.Point(248, 377)
        Me.botLogin.Name = "botLogin"
        Me.botLogin.Size = New System.Drawing.Size(121, 42)
        Me.botLogin.TabIndex = 1
        Me.botLogin.Text = "Login"
        Me.botLogin.UseVisualStyleBackColor = True
        '
        'txbUsuario
        '
        Me.txbUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbUsuario.Location = New System.Drawing.Point(120, 141)
        Me.txbUsuario.Name = "txbUsuario"
        Me.txbUsuario.Size = New System.Drawing.Size(249, 31)
        Me.txbUsuario.TabIndex = 2
        '
        'txbPass
        '
        Me.txbPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbPass.Location = New System.Drawing.Point(120, 267)
        Me.txbPass.Name = "txbPass"
        Me.txbPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txbPass.Size = New System.Drawing.Size(249, 31)
        Me.txbPass.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(120, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Ingrese su usuario:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(120, 231)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(201, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Ingrese su contraseña:"
        '
        'labError
        '
        Me.labError.AutoSize = True
        Me.labError.ForeColor = System.Drawing.Color.Red
        Me.labError.Location = New System.Drawing.Point(63, 463)
        Me.labError.Name = "labError"
        Me.labError.Size = New System.Drawing.Size(0, 13)
        Me.labError.TabIndex = 6
        '
        'botRegistrar
        '
        Me.botRegistrar.BackColor = System.Drawing.Color.YellowGreen
        Me.botRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botRegistrar.Location = New System.Drawing.Point(105, 377)
        Me.botRegistrar.Name = "botRegistrar"
        Me.botRegistrar.Size = New System.Drawing.Size(121, 42)
        Me.botRegistrar.TabIndex = 7
        Me.botRegistrar.Text = "Registrarme"
        Me.botRegistrar.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 500)
        Me.Controls.Add(Me.botRegistrar)
        Me.Controls.Add(Me.labError)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txbPass)
        Me.Controls.Add(Me.txbUsuario)
        Me.Controls.Add(Me.botLogin)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents botLogin As Button
    Friend WithEvents txbUsuario As TextBox
    Friend WithEvents txbPass As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents labError As Label
    Friend WithEvents botRegistrar As Button
End Class
