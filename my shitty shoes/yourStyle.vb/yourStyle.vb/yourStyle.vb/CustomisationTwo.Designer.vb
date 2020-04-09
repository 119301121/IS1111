<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCustomisationTwo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.lblHeelback = New System.Windows.Forms.Label()
        Me.cmbHeelback = New System.Windows.Forms.ComboBox()
        Me.lblLaces = New System.Windows.Forms.Label()
        Me.cmbLaces = New System.Windows.Forms.ComboBox()
        Me.lblLogo = New System.Windows.Forms.Label()
        Me.btnLogo = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lblFileSelected = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(1086, 554)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(75, 23)
        Me.btnContinue.TabIndex = 1
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'lblHeelback
        '
        Me.lblHeelback.AutoSize = True
        Me.lblHeelback.Location = New System.Drawing.Point(92, 77)
        Me.lblHeelback.Name = "lblHeelback"
        Me.lblHeelback.Size = New System.Drawing.Size(56, 13)
        Me.lblHeelback.TabIndex = 2
        Me.lblHeelback.Text = "Heelback:"
        '
        'cmbHeelback
        '
        Me.cmbHeelback.FormattingEnabled = True
        Me.cmbHeelback.Items.AddRange(New Object() {"White", "Red", "Blue", "Yellow", "Dark Grey", "Light Grey", "Black"})
        Me.cmbHeelback.Location = New System.Drawing.Point(206, 68)
        Me.cmbHeelback.Name = "cmbHeelback"
        Me.cmbHeelback.Size = New System.Drawing.Size(121, 21)
        Me.cmbHeelback.TabIndex = 3
        Me.cmbHeelback.Text = "White"
        '
        'lblLaces
        '
        Me.lblLaces.AutoSize = True
        Me.lblLaces.Location = New System.Drawing.Point(92, 509)
        Me.lblLaces.Name = "lblLaces"
        Me.lblLaces.Size = New System.Drawing.Size(39, 13)
        Me.lblLaces.TabIndex = 4
        Me.lblLaces.Text = "Laces:"
        '
        'cmbLaces
        '
        Me.cmbLaces.FormattingEnabled = True
        Me.cmbLaces.Items.AddRange(New Object() {"White", "Red", "Blue", "Green", "Yellow", "Dark Grey", "Light Grey", "Black"})
        Me.cmbLaces.Location = New System.Drawing.Point(206, 501)
        Me.cmbLaces.Name = "cmbLaces"
        Me.cmbLaces.Size = New System.Drawing.Size(121, 21)
        Me.cmbLaces.TabIndex = 5
        Me.cmbLaces.Text = "White"
        '
        'lblLogo
        '
        Me.lblLogo.AutoSize = True
        Me.lblLogo.Location = New System.Drawing.Point(931, 97)
        Me.lblLogo.Name = "lblLogo"
        Me.lblLogo.Size = New System.Drawing.Size(106, 13)
        Me.lblLogo.TabIndex = 6
        Me.lblLogo.Text = "Add Your Own Logo:"
        '
        'btnLogo
        '
        Me.btnLogo.Location = New System.Drawing.Point(1086, 92)
        Me.btnLogo.Name = "btnLogo"
        Me.btnLogo.Size = New System.Drawing.Size(75, 23)
        Me.btnLogo.TabIndex = 8
        Me.btnLogo.Text = "Browse Files"
        Me.btnLogo.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lblFileSelected
        '
        Me.lblFileSelected.AutoSize = True
        Me.lblFileSelected.Location = New System.Drawing.Point(934, 154)
        Me.lblFileSelected.Name = "lblFileSelected"
        Me.lblFileSelected.Size = New System.Drawing.Size(80, 13)
        Me.lblFileSelected.TabIndex = 9
        Me.lblFileSelected.Text = "No file selected"
        '
        'FrmCustomisationTwo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1904, 1042)
        Me.Controls.Add(Me.lblFileSelected)
        Me.Controls.Add(Me.btnLogo)
        Me.Controls.Add(Me.lblLogo)
        Me.Controls.Add(Me.cmbLaces)
        Me.Controls.Add(Me.lblLaces)
        Me.Controls.Add(Me.cmbHeelback)
        Me.Controls.Add(Me.lblHeelback)
        Me.Controls.Add(Me.btnContinue)
        Me.Name = "FrmCustomisationTwo"
        Me.Text = "CustomisationTwo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnContinue As Button
    Friend WithEvents lblHeelback As Label
    Friend WithEvents cmbHeelback As ComboBox
    Friend WithEvents lblLaces As Label
    Friend WithEvents cmbLaces As ComboBox
    Friend WithEvents lblLogo As Label
    Friend WithEvents btnLogo As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents lblFileSelected As Label
End Class
