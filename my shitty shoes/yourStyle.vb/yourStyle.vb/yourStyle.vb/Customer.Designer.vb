<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCustomer
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCustomer))
        Me.YourStyleDataSet = New yourStyle.vb.YourStyleDataSet()
        Me.Customer_InformationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Customer_InformationTableAdapter = New yourStyle.vb.YourStyleDataSetTableAdapters.Customer_InformationTableAdapter()
        Me.TableAdapterManager = New yourStyle.vb.YourStyleDataSetTableAdapters.TableAdapterManager()
        Me.CustomisationTableAdapter = New yourStyle.vb.YourStyleDataSetTableAdapters.CustomisationTableAdapter()
        Me.Order_SummaryTableAdapter = New yourStyle.vb.YourStyleDataSetTableAdapters.Order_SummaryTableAdapter()
        Me.Customer_InformationBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Customer_InformationBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CustomisationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Order_SummaryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CustomerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.OrderIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuarterColourDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VampColourDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EyestayColourDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HeelTabColourDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HeelBackCounterColourDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LacesColourDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LogoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Field1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddedTextDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.EditedTextDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.OrderIDDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShoeModelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LogoDataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DateOrderedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvidedByCustomerDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SizeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnPrint = New System.Windows.Forms.Button()
        CType(Me.YourStyleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Customer_InformationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Customer_InformationBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Customer_InformationBindingNavigator.SuspendLayout()
        CType(Me.CustomisationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Order_SummaryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.TableAdapterManager.CustomisationTableAdapter = Me.CustomisationTableAdapter
        Me.TableAdapterManager.Order_SummaryTableAdapter = Me.Order_SummaryTableAdapter
        Me.TableAdapterManager.UpdateOrder = yourStyle.vb.YourStyleDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CustomisationTableAdapter
        '
        Me.CustomisationTableAdapter.ClearBeforeFill = True
        '
        'Order_SummaryTableAdapter
        '
        Me.Order_SummaryTableAdapter.ClearBeforeFill = True
        '
        'Customer_InformationBindingNavigator
        '
        Me.Customer_InformationBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Customer_InformationBindingNavigator.BindingSource = Me.Customer_InformationBindingSource
        Me.Customer_InformationBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Customer_InformationBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Customer_InformationBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.Customer_InformationBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Customer_InformationBindingNavigatorSaveItem})
        Me.Customer_InformationBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Customer_InformationBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Customer_InformationBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Customer_InformationBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Customer_InformationBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Customer_InformationBindingNavigator.Name = "Customer_InformationBindingNavigator"
        Me.Customer_InformationBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Customer_InformationBindingNavigator.Size = New System.Drawing.Size(1296, 31)
        Me.Customer_InformationBindingNavigator.TabIndex = 0
        Me.Customer_InformationBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(54, 28)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 31)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'Customer_InformationBindingNavigatorSaveItem
        '
        Me.Customer_InformationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Customer_InformationBindingNavigatorSaveItem.Image = CType(resources.GetObject("Customer_InformationBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Customer_InformationBindingNavigatorSaveItem.Name = "Customer_InformationBindingNavigatorSaveItem"
        Me.Customer_InformationBindingNavigatorSaveItem.Size = New System.Drawing.Size(28, 28)
        Me.Customer_InformationBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CustomisationBindingSource
        '
        Me.CustomisationBindingSource.DataMember = "Customisation"
        Me.CustomisationBindingSource.DataSource = Me.YourStyleDataSet
        '
        'Order_SummaryBindingSource
        '
        Me.Order_SummaryBindingSource.DataMember = "Order Summary"
        Me.Order_SummaryBindingSource.DataSource = Me.YourStyleDataSet
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerIDDataGridViewTextBoxColumn, Me.CustomerNameDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.ContactNumberDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.OrderIDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Customer_InformationBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(42, 57)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(684, 150)
        Me.DataGridView1.TabIndex = 4
        '
        'CustomerIDDataGridViewTextBoxColumn
        '
        Me.CustomerIDDataGridViewTextBoxColumn.DataPropertyName = "Customer ID"
        Me.CustomerIDDataGridViewTextBoxColumn.HeaderText = "Customer ID"
        Me.CustomerIDDataGridViewTextBoxColumn.Name = "CustomerIDDataGridViewTextBoxColumn"
        '
        'CustomerNameDataGridViewTextBoxColumn
        '
        Me.CustomerNameDataGridViewTextBoxColumn.DataPropertyName = "Customer Name"
        Me.CustomerNameDataGridViewTextBoxColumn.HeaderText = "Customer Name"
        Me.CustomerNameDataGridViewTextBoxColumn.Name = "CustomerNameDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'ContactNumberDataGridViewTextBoxColumn
        '
        Me.ContactNumberDataGridViewTextBoxColumn.DataPropertyName = "Contact Number"
        Me.ContactNumberDataGridViewTextBoxColumn.HeaderText = "Contact Number"
        Me.ContactNumberDataGridViewTextBoxColumn.Name = "ContactNumberDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'OrderIDDataGridViewTextBoxColumn
        '
        Me.OrderIDDataGridViewTextBoxColumn.DataPropertyName = "Order ID"
        Me.OrderIDDataGridViewTextBoxColumn.HeaderText = "Order ID"
        Me.OrderIDDataGridViewTextBoxColumn.Name = "OrderIDDataGridViewTextBoxColumn"
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrderIDDataGridViewTextBoxColumn1, Me.ModelDataGridViewTextBoxColumn, Me.QuarterColourDataGridViewTextBoxColumn, Me.VampColourDataGridViewTextBoxColumn, Me.EyestayColourDataGridViewTextBoxColumn, Me.HeelTabColourDataGridViewTextBoxColumn, Me.HeelBackCounterColourDataGridViewTextBoxColumn, Me.LacesColourDataGridViewTextBoxColumn, Me.LogoDataGridViewCheckBoxColumn, Me.Field1DataGridViewTextBoxColumn, Me.AddedTextDataGridViewCheckBoxColumn, Me.EditedTextDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.CustomisationBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(42, 213)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 28
        Me.DataGridView2.Size = New System.Drawing.Size(1242, 150)
        Me.DataGridView2.TabIndex = 5
        '
        'OrderIDDataGridViewTextBoxColumn1
        '
        Me.OrderIDDataGridViewTextBoxColumn1.DataPropertyName = "Order ID"
        Me.OrderIDDataGridViewTextBoxColumn1.HeaderText = "Order ID"
        Me.OrderIDDataGridViewTextBoxColumn1.Name = "OrderIDDataGridViewTextBoxColumn1"
        '
        'ModelDataGridViewTextBoxColumn
        '
        Me.ModelDataGridViewTextBoxColumn.DataPropertyName = "Model"
        Me.ModelDataGridViewTextBoxColumn.HeaderText = "Model"
        Me.ModelDataGridViewTextBoxColumn.Name = "ModelDataGridViewTextBoxColumn"
        '
        'QuarterColourDataGridViewTextBoxColumn
        '
        Me.QuarterColourDataGridViewTextBoxColumn.DataPropertyName = "Quarter Colour"
        Me.QuarterColourDataGridViewTextBoxColumn.HeaderText = "Quarter Colour"
        Me.QuarterColourDataGridViewTextBoxColumn.Name = "QuarterColourDataGridViewTextBoxColumn"
        '
        'VampColourDataGridViewTextBoxColumn
        '
        Me.VampColourDataGridViewTextBoxColumn.DataPropertyName = "Vamp Colour"
        Me.VampColourDataGridViewTextBoxColumn.HeaderText = "Vamp Colour"
        Me.VampColourDataGridViewTextBoxColumn.Name = "VampColourDataGridViewTextBoxColumn"
        '
        'EyestayColourDataGridViewTextBoxColumn
        '
        Me.EyestayColourDataGridViewTextBoxColumn.DataPropertyName = "Eyestay Colour"
        Me.EyestayColourDataGridViewTextBoxColumn.HeaderText = "Eyestay Colour"
        Me.EyestayColourDataGridViewTextBoxColumn.Name = "EyestayColourDataGridViewTextBoxColumn"
        '
        'HeelTabColourDataGridViewTextBoxColumn
        '
        Me.HeelTabColourDataGridViewTextBoxColumn.DataPropertyName = "Heel Tab Colour"
        Me.HeelTabColourDataGridViewTextBoxColumn.HeaderText = "Heel Tab Colour"
        Me.HeelTabColourDataGridViewTextBoxColumn.Name = "HeelTabColourDataGridViewTextBoxColumn"
        '
        'HeelBackCounterColourDataGridViewTextBoxColumn
        '
        Me.HeelBackCounterColourDataGridViewTextBoxColumn.DataPropertyName = "Heel/Back Counter Colour"
        Me.HeelBackCounterColourDataGridViewTextBoxColumn.HeaderText = "Heel/Back Counter Colour"
        Me.HeelBackCounterColourDataGridViewTextBoxColumn.Name = "HeelBackCounterColourDataGridViewTextBoxColumn"
        '
        'LacesColourDataGridViewTextBoxColumn
        '
        Me.LacesColourDataGridViewTextBoxColumn.DataPropertyName = "Laces Colour"
        Me.LacesColourDataGridViewTextBoxColumn.HeaderText = "Laces Colour"
        Me.LacesColourDataGridViewTextBoxColumn.Name = "LacesColourDataGridViewTextBoxColumn"
        '
        'LogoDataGridViewCheckBoxColumn
        '
        Me.LogoDataGridViewCheckBoxColumn.DataPropertyName = "Logo"
        Me.LogoDataGridViewCheckBoxColumn.HeaderText = "Logo"
        Me.LogoDataGridViewCheckBoxColumn.Name = "LogoDataGridViewCheckBoxColumn"
        '
        'Field1DataGridViewTextBoxColumn
        '
        Me.Field1DataGridViewTextBoxColumn.DataPropertyName = "Field1"
        Me.Field1DataGridViewTextBoxColumn.HeaderText = "Field1"
        Me.Field1DataGridViewTextBoxColumn.Name = "Field1DataGridViewTextBoxColumn"
        '
        'AddedTextDataGridViewCheckBoxColumn
        '
        Me.AddedTextDataGridViewCheckBoxColumn.DataPropertyName = "Added Text"
        Me.AddedTextDataGridViewCheckBoxColumn.HeaderText = "Added Text"
        Me.AddedTextDataGridViewCheckBoxColumn.Name = "AddedTextDataGridViewCheckBoxColumn"
        '
        'EditedTextDataGridViewTextBoxColumn
        '
        Me.EditedTextDataGridViewTextBoxColumn.DataPropertyName = "Edited Text"
        Me.EditedTextDataGridViewTextBoxColumn.HeaderText = "Edited Text"
        Me.EditedTextDataGridViewTextBoxColumn.Name = "EditedTextDataGridViewTextBoxColumn"
        '
        'DataGridView3
        '
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrderIDDataGridViewTextBoxColumn2, Me.ShoeModelDataGridViewTextBoxColumn, Me.LogoDataGridViewCheckBoxColumn1, Me.DateOrderedDataGridViewTextBoxColumn, Me.ProvidedByCustomerDataGridViewCheckBoxColumn, Me.SizeDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn})
        Me.DataGridView3.DataSource = Me.Order_SummaryBindingSource
        Me.DataGridView3.Location = New System.Drawing.Point(42, 369)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowTemplate.Height = 28
        Me.DataGridView3.Size = New System.Drawing.Size(758, 150)
        Me.DataGridView3.TabIndex = 6
        '
        'OrderIDDataGridViewTextBoxColumn2
        '
        Me.OrderIDDataGridViewTextBoxColumn2.DataPropertyName = "Order ID"
        Me.OrderIDDataGridViewTextBoxColumn2.HeaderText = "Order ID"
        Me.OrderIDDataGridViewTextBoxColumn2.Name = "OrderIDDataGridViewTextBoxColumn2"
        '
        'ShoeModelDataGridViewTextBoxColumn
        '
        Me.ShoeModelDataGridViewTextBoxColumn.DataPropertyName = "Shoe Model"
        Me.ShoeModelDataGridViewTextBoxColumn.HeaderText = "Shoe Model"
        Me.ShoeModelDataGridViewTextBoxColumn.Name = "ShoeModelDataGridViewTextBoxColumn"
        '
        'LogoDataGridViewCheckBoxColumn1
        '
        Me.LogoDataGridViewCheckBoxColumn1.DataPropertyName = "Logo"
        Me.LogoDataGridViewCheckBoxColumn1.HeaderText = "Logo"
        Me.LogoDataGridViewCheckBoxColumn1.Name = "LogoDataGridViewCheckBoxColumn1"
        '
        'DateOrderedDataGridViewTextBoxColumn
        '
        Me.DateOrderedDataGridViewTextBoxColumn.DataPropertyName = "Date Ordered"
        Me.DateOrderedDataGridViewTextBoxColumn.HeaderText = "Date Ordered"
        Me.DateOrderedDataGridViewTextBoxColumn.Name = "DateOrderedDataGridViewTextBoxColumn"
        '
        'ProvidedByCustomerDataGridViewCheckBoxColumn
        '
        Me.ProvidedByCustomerDataGridViewCheckBoxColumn.DataPropertyName = "Provided by Customer"
        Me.ProvidedByCustomerDataGridViewCheckBoxColumn.HeaderText = "Provided by Customer"
        Me.ProvidedByCustomerDataGridViewCheckBoxColumn.Name = "ProvidedByCustomerDataGridViewCheckBoxColumn"
        '
        'SizeDataGridViewTextBoxColumn
        '
        Me.SizeDataGridViewTextBoxColumn.DataPropertyName = "Size"
        Me.SizeDataGridViewTextBoxColumn.HeaderText = "Size"
        Me.SizeDataGridViewTextBoxColumn.Name = "SizeDataGridViewTextBoxColumn"
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(896, 419)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(117, 64)
        Me.btnPrint.TabIndex = 7
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'FrmCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1296, 624)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Customer_InformationBindingNavigator)
        Me.Name = "FrmCustomer"
        Me.Text = "Customer"
        CType(Me.YourStyleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Customer_InformationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Customer_InformationBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Customer_InformationBindingNavigator.ResumeLayout(False)
        Me.Customer_InformationBindingNavigator.PerformLayout()
        CType(Me.CustomisationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Order_SummaryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents YourStyleDataSet As YourStyleDataSet
    Friend WithEvents Customer_InformationBindingSource As BindingSource
    Friend WithEvents Customer_InformationTableAdapter As YourStyleDataSetTableAdapters.Customer_InformationTableAdapter
    Friend WithEvents TableAdapterManager As YourStyleDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Customer_InformationBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Customer_InformationBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CustomisationTableAdapter As YourStyleDataSetTableAdapters.CustomisationTableAdapter
    Friend WithEvents CustomisationBindingSource As BindingSource
    Friend WithEvents Order_SummaryTableAdapter As YourStyleDataSetTableAdapters.Order_SummaryTableAdapter
    Friend WithEvents Order_SummaryBindingSource As BindingSource
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrderIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents OrderIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ModelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuarterColourDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VampColourDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EyestayColourDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HeelTabColourDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HeelBackCounterColourDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LacesColourDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LogoDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents Field1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddedTextDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents EditedTextDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents OrderIDDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents ShoeModelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LogoDataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DateOrderedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProvidedByCustomerDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents SizeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnPrint As Button
End Class
