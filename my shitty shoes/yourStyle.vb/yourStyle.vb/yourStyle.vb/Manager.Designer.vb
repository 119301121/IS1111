<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmManager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmManager))
        Me.pctPrinter = New System.Windows.Forms.PictureBox()
        Me.pctShoe = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblPrint = New System.Windows.Forms.Label()
        Me.lblCustomer = New System.Windows.Forms.Label()
        Me.lblEmployee = New System.Windows.Forms.Label()
        CType(Me.pctPrinter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctShoe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pctPrinter
        '
        Me.pctPrinter.Image = CType(resources.GetObject("pctPrinter.Image"), System.Drawing.Image)
        Me.pctPrinter.Location = New System.Drawing.Point(12, 129)
        Me.pctPrinter.Name = "pctPrinter"
        Me.pctPrinter.Size = New System.Drawing.Size(226, 161)
        Me.pctPrinter.TabIndex = 0
        Me.pctPrinter.TabStop = False
        '
        'pctShoe
        '
        Me.pctShoe.BackgroundImage = CType(resources.GetObject("pctShoe.BackgroundImage"), System.Drawing.Image)
        Me.pctShoe.Location = New System.Drawing.Point(288, 129)
        Me.pctShoe.Name = "pctShoe"
        Me.pctShoe.Size = New System.Drawing.Size(202, 161)
        Me.pctShoe.TabIndex = 1
        Me.pctShoe.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(534, 118)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(226, 172)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lblPrint
        '
        Me.lblPrint.AutoSize = True
        Me.lblPrint.Location = New System.Drawing.Point(85, 316)
        Me.lblPrint.Name = "lblPrint"
        Me.lblPrint.Size = New System.Drawing.Size(85, 20)
        Me.lblPrint.TabIndex = 3
        Me.lblPrint.Text = "Print forms"
        '
        'lblCustomer
        '
        Me.lblCustomer.AutoSize = True
        Me.lblCustomer.Location = New System.Drawing.Point(311, 316)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(146, 20)
        Me.lblCustomer.TabIndex = 4
        Me.lblCustomer.Text = "Customer Records:"
        '
        'lblEmployee
        '
        Me.lblEmployee.AutoSize = True
        Me.lblEmployee.Location = New System.Drawing.Point(571, 316)
        Me.lblEmployee.Name = "lblEmployee"
        Me.lblEmployee.Size = New System.Drawing.Size(124, 20)
        Me.lblEmployee.TabIndex = 5
        Me.lblEmployee.Text = "Add Employees:"
        '
        'FrmManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblEmployee)
        Me.Controls.Add(Me.lblCustomer)
        Me.Controls.Add(Me.lblPrint)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pctShoe)
        Me.Controls.Add(Me.pctPrinter)
        Me.Name = "FrmManager"
        Me.Text = "Manager"
        CType(Me.pctPrinter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctShoe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pctPrinter As PictureBox
    Friend WithEvents pctShoe As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblPrint As Label
    Friend WithEvents lblCustomer As Label
    Friend WithEvents lblEmployee As Label
End Class
