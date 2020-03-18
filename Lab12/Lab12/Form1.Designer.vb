<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInputOutput
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblOpening = New System.Windows.Forms.Label()
        Me.lblCurrent = New System.Windows.Forms.Label()
        Me.lblSpent = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtOpening = New System.Windows.Forms.TextBox()
        Me.txtCurrent = New System.Windows.Forms.TextBox()
        Me.txtSpent = New System.Windows.Forms.TextBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(46, 53)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(49, 17)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name:"
        '
        'lblOpening
        '
        Me.lblOpening.AutoSize = True
        Me.lblOpening.Location = New System.Drawing.Point(46, 111)
        Me.lblOpening.Name = "lblOpening"
        Me.lblOpening.Size = New System.Drawing.Size(121, 17)
        Me.lblOpening.TabIndex = 1
        Me.lblOpening.Text = "Opening Balance:"
        '
        'lblCurrent
        '
        Me.lblCurrent.AutoSize = True
        Me.lblCurrent.Location = New System.Drawing.Point(46, 166)
        Me.lblCurrent.Name = "lblCurrent"
        Me.lblCurrent.Size = New System.Drawing.Size(114, 17)
        Me.lblCurrent.TabIndex = 2
        Me.lblCurrent.Text = "Current Balance:"
        '
        'lblSpent
        '
        Me.lblSpent.AutoSize = True
        Me.lblSpent.Location = New System.Drawing.Point(46, 224)
        Me.lblSpent.Name = "lblSpent"
        Me.lblSpent.Size = New System.Drawing.Size(75, 17)
        Me.lblSpent.TabIndex = 3
        Me.lblSpent.Text = "Spent (%):"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(169, 48)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 22)
        Me.txtName.TabIndex = 4
        '
        'txtOpening
        '
        Me.txtOpening.Location = New System.Drawing.Point(169, 106)
        Me.txtOpening.Name = "txtOpening"
        Me.txtOpening.Size = New System.Drawing.Size(100, 22)
        Me.txtOpening.TabIndex = 5
        '
        'txtCurrent
        '
        Me.txtCurrent.Location = New System.Drawing.Point(169, 161)
        Me.txtCurrent.Name = "txtCurrent"
        Me.txtCurrent.Size = New System.Drawing.Size(100, 22)
        Me.txtCurrent.TabIndex = 6
        '
        'txtSpent
        '
        Me.txtSpent.Location = New System.Drawing.Point(169, 219)
        Me.txtSpent.Name = "txtSpent"
        Me.txtSpent.ReadOnly = True
        Me.txtSpent.Size = New System.Drawing.Size(100, 22)
        Me.txtSpent.TabIndex = 7
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(140, 313)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(129, 31)
        Me.btnDisplay.TabIndex = 8
        Me.btnDisplay.Text = "Display Details"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'frmInputOutput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 506)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.txtSpent)
        Me.Controls.Add(Me.txtCurrent)
        Me.Controls.Add(Me.txtOpening)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblSpent)
        Me.Controls.Add(Me.lblCurrent)
        Me.Controls.Add(Me.lblOpening)
        Me.Controls.Add(Me.lblName)
        Me.Name = "frmInputOutput"
        Me.Text = "Input Output"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblOpening As Label
    Friend WithEvents lblCurrent As Label
    Friend WithEvents lblSpent As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtOpening As TextBox
    Friend WithEvents txtCurrent As TextBox
    Friend WithEvents txtSpent As TextBox
    Friend WithEvents btnDisplay As Button
End Class
