<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCustomisation
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
        Me.cmbQuarter = New System.Windows.Forms.ComboBox()
        Me.lblQuarter = New System.Windows.Forms.Label()
        Me.lblVamp = New System.Windows.Forms.Label()
        Me.cmbVamp = New System.Windows.Forms.ComboBox()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.lblEyestay = New System.Windows.Forms.Label()
        Me.cmbEyestay = New System.Windows.Forms.ComboBox()
        Me.lblHeel = New System.Windows.Forms.Label()
        Me.cmbHeel = New System.Windows.Forms.ComboBox()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbQuarter
        '
        Me.cmbQuarter.FormattingEnabled = True
        Me.cmbQuarter.Items.AddRange(New Object() {"White ", "Red", "Blue", "Green", "Yellow", "Dark Grey", "Light Grey", "Black"})
        Me.cmbQuarter.Location = New System.Drawing.Point(178, 99)
        Me.cmbQuarter.Name = "cmbQuarter"
        Me.cmbQuarter.Size = New System.Drawing.Size(121, 21)
        Me.cmbQuarter.TabIndex = 0
        Me.cmbQuarter.Text = "White"
        '
        'lblQuarter
        '
        Me.lblQuarter.AutoSize = True
        Me.lblQuarter.Location = New System.Drawing.Point(47, 106)
        Me.lblQuarter.Name = "lblQuarter"
        Me.lblQuarter.Size = New System.Drawing.Size(45, 13)
        Me.lblQuarter.TabIndex = 1
        Me.lblQuarter.Text = "Quarter:"
        '
        'lblVamp
        '
        Me.lblVamp.AutoSize = True
        Me.lblVamp.Location = New System.Drawing.Point(47, 530)
        Me.lblVamp.Name = "lblVamp"
        Me.lblVamp.Size = New System.Drawing.Size(37, 13)
        Me.lblVamp.TabIndex = 2
        Me.lblVamp.Text = "Vamp:"
        '
        'cmbVamp
        '
        Me.cmbVamp.FormattingEnabled = True
        Me.cmbVamp.Items.AddRange(New Object() {"White", "Red ", "Blue", "Green", "Yellow", "Dark Grey", "Light Grey", "Black"})
        Me.cmbVamp.Location = New System.Drawing.Point(178, 522)
        Me.cmbVamp.Name = "cmbVamp"
        Me.cmbVamp.Size = New System.Drawing.Size(121, 21)
        Me.cmbVamp.TabIndex = 3
        Me.cmbVamp.Text = "White"
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(1014, 589)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 23)
        Me.btnPrevious.TabIndex = 6
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'lblEyestay
        '
        Me.lblEyestay.AutoSize = True
        Me.lblEyestay.Location = New System.Drawing.Point(910, 99)
        Me.lblEyestay.Name = "lblEyestay"
        Me.lblEyestay.Size = New System.Drawing.Size(47, 13)
        Me.lblEyestay.TabIndex = 7
        Me.lblEyestay.Text = "Eyestay:"
        '
        'cmbEyestay
        '
        Me.cmbEyestay.FormattingEnabled = True
        Me.cmbEyestay.Items.AddRange(New Object() {"White", "Red", "Blue", "Green", "Yellow", "Dark Grey", "Light Grey", "Black"})
        Me.cmbEyestay.Location = New System.Drawing.Point(1034, 90)
        Me.cmbEyestay.Name = "cmbEyestay"
        Me.cmbEyestay.Size = New System.Drawing.Size(121, 21)
        Me.cmbEyestay.TabIndex = 8
        Me.cmbEyestay.Text = "White"
        '
        'lblHeel
        '
        Me.lblHeel.AutoSize = True
        Me.lblHeel.Location = New System.Drawing.Point(913, 529)
        Me.lblHeel.Name = "lblHeel"
        Me.lblHeel.Size = New System.Drawing.Size(32, 13)
        Me.lblHeel.TabIndex = 9
        Me.lblHeel.Text = "Heel:"
        '
        'cmbHeel
        '
        Me.cmbHeel.FormattingEnabled = True
        Me.cmbHeel.Items.AddRange(New Object() {"White", "Red", "Blue", "Green", "Yellow", "Dark Grey", "Light Grey", "Black"})
        Me.cmbHeel.Location = New System.Drawing.Point(1034, 522)
        Me.cmbHeel.Name = "cmbHeel"
        Me.cmbHeel.Size = New System.Drawing.Size(121, 21)
        Me.cmbHeel.TabIndex = 10
        Me.cmbHeel.Text = "White"
        '
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(1130, 589)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(75, 23)
        Me.btnContinue.TabIndex = 11
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'FrmCustomisation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1249, 809)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.cmbHeel)
        Me.Controls.Add(Me.lblHeel)
        Me.Controls.Add(Me.cmbEyestay)
        Me.Controls.Add(Me.lblEyestay)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.cmbVamp)
        Me.Controls.Add(Me.lblVamp)
        Me.Controls.Add(Me.lblQuarter)
        Me.Controls.Add(Me.cmbQuarter)
        Me.Name = "FrmCustomisation"
        Me.Text = "Customisation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbQuarter As ComboBox
    Friend WithEvents lblQuarter As Label
    Friend WithEvents lblVamp As Label
    Friend WithEvents cmbVamp As ComboBox
    Friend WithEvents btnPrevious As Button
    Friend WithEvents lblEyestay As Label
    Friend WithEvents cmbEyestay As ComboBox
    Friend WithEvents lblHeel As Label
    Friend WithEvents cmbHeel As ComboBox
    Friend WithEvents btnContinue As Button
End Class
