<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmText
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.lblFontSize = New System.Windows.Forms.Label()
        Me.trkSize = New System.Windows.Forms.TrackBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblFont = New System.Windows.Forms.Label()
        Me.cmbFontStyle = New System.Windows.Forms.ComboBox()
        Me.cmbFont = New System.Windows.Forms.ComboBox()
        Me.rchText = New System.Windows.Forms.RichTextBox()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.trkSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnNext)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnPrevious)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblFontSize)
        Me.SplitContainer1.Panel1.Controls.Add(Me.trkSize)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblFont)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbFontStyle)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbFont)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.rchText)
        Me.SplitContainer1.Size = New System.Drawing.Size(1232, 634)
        Me.SplitContainer1.SplitterDistance = 211
        Me.SplitContainer1.TabIndex = 0
        '
        'lblFontSize
        '
        Me.lblFontSize.AutoSize = True
        Me.lblFontSize.Location = New System.Drawing.Point(573, 54)
        Me.lblFontSize.Name = "lblFontSize"
        Me.lblFontSize.Size = New System.Drawing.Size(87, 13)
        Me.lblFontSize.TabIndex = 5
        Me.lblFontSize.Text = "Select Font Size:"
        '
        'trkSize
        '
        Me.trkSize.LargeChange = 2
        Me.trkSize.Location = New System.Drawing.Point(566, 73)
        Me.trkSize.Maximum = 30
        Me.trkSize.Minimum = 8
        Me.trkSize.Name = "trkSize"
        Me.trkSize.Size = New System.Drawing.Size(174, 45)
        Me.trkSize.TabIndex = 4
        Me.trkSize.Value = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(317, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Select Font Style:"
        '
        'lblFont
        '
        Me.lblFont.AutoSize = True
        Me.lblFont.Location = New System.Drawing.Point(13, 54)
        Me.lblFont.Name = "lblFont"
        Me.lblFont.Size = New System.Drawing.Size(64, 13)
        Me.lblFont.TabIndex = 2
        Me.lblFont.Text = "Select Font:"
        '
        'cmbFontStyle
        '
        Me.cmbFontStyle.FormattingEnabled = True
        Me.cmbFontStyle.Items.AddRange(New Object() {"Regular", "Bold", "Italic"})
        Me.cmbFontStyle.Location = New System.Drawing.Point(320, 73)
        Me.cmbFontStyle.Name = "cmbFontStyle"
        Me.cmbFontStyle.Size = New System.Drawing.Size(192, 21)
        Me.cmbFontStyle.TabIndex = 1
        Me.cmbFontStyle.Text = "Regular"
        '
        'cmbFont
        '
        Me.cmbFont.FormattingEnabled = True
        Me.cmbFont.Location = New System.Drawing.Point(12, 73)
        Me.cmbFont.Name = "cmbFont"
        Me.cmbFont.Size = New System.Drawing.Size(227, 21)
        Me.cmbFont.TabIndex = 0
        Me.cmbFont.Text = "Microsoft Sans Serif"
        '
        'rchText
        '
        Me.rchText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rchText.Location = New System.Drawing.Point(0, 0)
        Me.rchText.Name = "rchText"
        Me.rchText.Size = New System.Drawing.Size(1232, 419)
        Me.rchText.TabIndex = 0
        Me.rchText.Text = ""
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(903, 73)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 23)
        Me.btnPrevious.TabIndex = 6
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(1062, 72)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 7
        Me.btnNext.Text = "Continue"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'FrmText
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1232, 634)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FrmText"
        Me.Text = "Text"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.trkSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Label2 As Label
    Friend WithEvents lblFont As Label
    Friend WithEvents cmbFontStyle As ComboBox
    Friend WithEvents cmbFont As ComboBox
    Friend WithEvents rchText As RichTextBox
    Friend WithEvents trkSize As TrackBar
    Friend WithEvents lblFontSize As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
End Class
