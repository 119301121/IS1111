<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrint
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrint))
        Me.pctPrintA4 = New System.Windows.Forms.PictureBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.pct = New System.Windows.Forms.PictureBox()
        Me.YourStyleDataSet = New yourStyle.vb.YourStyleDataSet()
        Me.Customer_InformationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Customer_InformationTableAdapter = New yourStyle.vb.YourStyleDataSetTableAdapters.Customer_InformationTableAdapter()
        Me.TableAdapterManager = New yourStyle.vb.YourStyleDataSetTableAdapters.TableAdapterManager()
        Me.rdoPrint2 = New System.Windows.Forms.RadioButton()
        Me.btnPrint = New System.Windows.Forms.Button()
        CType(Me.pctPrintA4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YourStyleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Customer_InformationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pctPrintA4
        '
        Me.pctPrintA4.Image = CType(resources.GetObject("pctPrintA4.Image"), System.Drawing.Image)
        Me.pctPrintA4.InitialImage = CType(resources.GetObject("pctPrintA4.InitialImage"), System.Drawing.Image)
        Me.pctPrintA4.Location = New System.Drawing.Point(32, 12)
        Me.pctPrintA4.Name = "pctPrintA4"
        Me.pctPrintA4.Size = New System.Drawing.Size(195, 225)
        Me.pctPrintA4.TabIndex = 0
        Me.pctPrintA4.TabStop = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(32, 256)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(213, 24)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "A4 Sheet (21cmx29.7cm)"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'pct
        '
        Me.pct.Image = CType(resources.GetObject("pct.Image"), System.Drawing.Image)
        Me.pct.Location = New System.Drawing.Point(313, 12)
        Me.pct.Name = "pct"
        Me.pct.Size = New System.Drawing.Size(195, 225)
        Me.pct.TabIndex = 2
        Me.pct.TabStop = False
        '
        'YourStyleDataSet
        '
        Me.YourStyleDataSet.DataSetName = "YourStyleDataSet"
        Me.YourStyleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Customer_InformationBindingSource
        '
        Me.Customer_InformationBindingSource.DataMember = "Customer Information"
        Me.Customer_InformationBindingSource.DataSource = Me.YourStyleDataSet
        '
        'Customer_InformationTableAdapter
        '
        Me.Customer_InformationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Customer_InformationTableAdapter = Me.Customer_InformationTableAdapter
        Me.TableAdapterManager.CustomisationTableAdapter = Nothing
        Me.TableAdapterManager.Order_SummaryTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = yourStyle.vb.YourStyleDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'rdoPrint2
        '
        Me.rdoPrint2.AutoSize = True
        Me.rdoPrint2.Location = New System.Drawing.Point(358, 256)
        Me.rdoPrint2.Name = "rdoPrint2"
        Me.rdoPrint2.Size = New System.Drawing.Size(92, 24)
        Me.rdoPrint2.TabIndex = 3
        Me.rdoPrint2.TabStop = True
        Me.rdoPrint2.Text = "Collated"
        Me.rdoPrint2.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(580, 93)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(89, 31)
        Me.btnPrint.TabIndex = 4
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'FrmPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 553)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.rdoPrint2)
        Me.Controls.Add(Me.pct)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.pctPrintA4)
        Me.Name = "FrmPrint"
        Me.Text = "Print"
        CType(Me.pctPrintA4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YourStyleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Customer_InformationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pctPrintA4 As PictureBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents pct As PictureBox
    Friend WithEvents YourStyleDataSet As YourStyleDataSet
    Friend WithEvents Customer_InformationBindingSource As BindingSource
    Friend WithEvents Customer_InformationTableAdapter As YourStyleDataSetTableAdapters.Customer_InformationTableAdapter
    Friend WithEvents TableAdapterManager As YourStyleDataSetTableAdapters.TableAdapterManager
    Friend WithEvents rdoPrint2 As RadioButton
    Friend WithEvents btnPrint As Button
End Class
