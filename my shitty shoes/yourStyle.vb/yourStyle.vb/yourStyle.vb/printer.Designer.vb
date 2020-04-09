<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmprinter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmprinter))
        Me.pctPrinting = New System.Windows.Forms.PictureBox()
        CType(Me.pctPrinting, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pctPrinting
        '
        Me.pctPrinting.Image = CType(resources.GetObject("pctPrinting.Image"), System.Drawing.Image)
        Me.pctPrinting.Location = New System.Drawing.Point(106, 12)
        Me.pctPrinting.Name = "pctPrinting"
        Me.pctPrinting.Size = New System.Drawing.Size(680, 524)
        Me.pctPrinting.TabIndex = 0
        Me.pctPrinting.TabStop = False
        '
        'Frmprinter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 556)
        Me.Controls.Add(Me.pctPrinting)
        Me.Name = "Frmprinter"
        Me.Text = "Print Preview"
        CType(Me.pctPrinting, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pctPrinting As PictureBox
End Class
