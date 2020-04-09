<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmManagerLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmManagerLogin))
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.pctJack = New System.Windows.Forms.PictureBox()
        CType(Me.pctJack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLogIn
        '
        Me.btnLogIn.Location = New System.Drawing.Point(123, 224)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(82, 29)
        Me.btnLogIn.TabIndex = 0
        Me.btnLogIn.Text = "Log In"
        Me.btnLogIn.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(72, 94)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(87, 20)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Username:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(76, 162)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(82, 20)
        Me.lblPassword.TabIndex = 2
        Me.lblPassword.Text = "Password:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(193, 94)
        Me.txtName.MaxLength = 15
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 26)
        Me.txtName.TabIndex = 3
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(193, 155)
        Me.txtPassword.MaxLength = 15
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(100, 26)
        Me.txtPassword.TabIndex = 4
        '
        'pctJack
        '
        Me.pctJack.Image = CType(resources.GetObject("pctJack.Image"), System.Drawing.Image)
        Me.pctJack.Location = New System.Drawing.Point(340, 94)
        Me.pctJack.Name = "pctJack"
        Me.pctJack.Size = New System.Drawing.Size(400, 284)
        Me.pctJack.TabIndex = 5
        Me.pctJack.TabStop = False
        Me.pctJack.Visible = False
        '
        'FrmManagerLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pctJack)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnLogIn)
        Me.Name = "FrmManagerLogin"
        Me.Text = "ManagerLogin"
        CType(Me.pctJack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLogIn As Button
    Friend WithEvents lblName As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents pctJack As PictureBox
End Class
