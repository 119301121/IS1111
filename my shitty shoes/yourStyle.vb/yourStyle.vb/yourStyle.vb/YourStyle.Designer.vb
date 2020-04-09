<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmYourStyle
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
        Me.rdoClassic = New System.Windows.Forms.RadioButton()
        Me.rdoRetro = New System.Windows.Forms.RadioButton()
        Me.rdoVintage = New System.Windows.Forms.RadioButton()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rdoClassic
        '
        Me.rdoClassic.AutoSize = True
        Me.rdoClassic.Location = New System.Drawing.Point(128, 86)
        Me.rdoClassic.Name = "rdoClassic"
        Me.rdoClassic.Size = New System.Drawing.Size(100, 17)
        Me.rdoClassic.TabIndex = 0
        Me.rdoClassic.TabStop = True
        Me.rdoClassic.Text = "Classic (€54.99)"
        Me.rdoClassic.UseVisualStyleBackColor = True
        '
        'rdoRetro
        '
        Me.rdoRetro.AutoSize = True
        Me.rdoRetro.Location = New System.Drawing.Point(128, 177)
        Me.rdoRetro.Name = "rdoRetro"
        Me.rdoRetro.Size = New System.Drawing.Size(93, 17)
        Me.rdoRetro.TabIndex = 1
        Me.rdoRetro.TabStop = True
        Me.rdoRetro.Text = "Retro (€49.50)"
        Me.rdoRetro.UseVisualStyleBackColor = True
        '
        'rdoVintage
        '
        Me.rdoVintage.AutoSize = True
        Me.rdoVintage.Location = New System.Drawing.Point(128, 272)
        Me.rdoVintage.Name = "rdoVintage"
        Me.rdoVintage.Size = New System.Drawing.Size(103, 17)
        Me.rdoVintage.TabIndex = 2
        Me.rdoVintage.TabStop = True
        Me.rdoVintage.Text = "Vintage (€44.99)"
        Me.rdoVintage.UseVisualStyleBackColor = True
        '
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(128, 364)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(75, 23)
        Me.btnContinue.TabIndex = 3
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'FrmYourStyle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.rdoVintage)
        Me.Controls.Add(Me.rdoRetro)
        Me.Controls.Add(Me.rdoClassic)
        Me.Name = "FrmYourStyle"
        Me.Text = "Your Style"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rdoClassic As RadioButton
    Friend WithEvents rdoRetro As RadioButton
    Friend WithEvents rdoVintage As RadioButton
    Friend WithEvents btnContinue As Button
End Class
