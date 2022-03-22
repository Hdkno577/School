<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim PictureLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim CostLabel As System.Windows.Forms.Label
        Dim LocationLabel As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Database2DataSet = New TourGuide2.Database2DataSet()
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table1TableAdapter = New TourGuide2.Database2DataSetTableAdapters.Table1TableAdapter()
        Me.TableAdapterManager = New TourGuide2.Database2DataSetTableAdapters.TableAdapterManager()
        Me.Table1BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Table1BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.WinterCheckBox = New System.Windows.Forms.CheckBox()
        Me.SpringCheckBox = New System.Windows.Forms.CheckBox()
        Me.SummerCheckBox = New System.Windows.Forms.CheckBox()
        Me.FallCheckBox = New System.Windows.Forms.CheckBox()
        Me.HotelCheckBox = New System.Windows.Forms.CheckBox()
        Me.ResturauntCheckBox = New System.Windows.Forms.CheckBox()
        Me.ShoppingCheckBox = New System.Windows.Forms.CheckBox()
        Me.OutdorsCheckBox = New System.Windows.Forms.CheckBox()
        Me.LandMarkCheckBox = New System.Windows.Forms.CheckBox()
        Me.Activity_CenterCheckBox = New System.Windows.Forms.CheckBox()
        Me.PictureTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.CostTextBox = New System.Windows.Forms.TextBox()
        Me.LocationTextBox = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        PictureLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        CostLabel = New System.Windows.Forms.Label()
        LocationLabel = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        CType(Me.Database2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Table1BindingNavigator.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureLabel
        '
        PictureLabel.AutoSize = True
        PictureLabel.Location = New System.Drawing.Point(203, 389)
        PictureLabel.Name = "PictureLabel"
        PictureLabel.Size = New System.Drawing.Size(43, 13)
        PictureLabel.TabIndex = 23
        PictureLabel.Text = "Picture:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(202, 318)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(63, 13)
        DescriptionLabel.TabIndex = 25
        DescriptionLabel.Text = "Description:"
        '
        'CostLabel
        '
        CostLabel.AutoSize = True
        CostLabel.Location = New System.Drawing.Point(5, 507)
        CostLabel.Name = "CostLabel"
        CostLabel.Size = New System.Drawing.Size(31, 13)
        CostLabel.TabIndex = 27
        CostLabel.Text = "Cost:"
        '
        'LocationLabel
        '
        LocationLabel.AutoSize = True
        LocationLabel.Location = New System.Drawing.Point(5, 481)
        LocationLabel.Name = "LocationLabel"
        LocationLabel.Size = New System.Drawing.Size(51, 13)
        LocationLabel.TabIndex = 29
        LocationLabel.Text = "Location:"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(25, 184)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 31
        IDLabel.Text = "ID:"
        '
        'Database2DataSet
        '
        Me.Database2DataSet.DataSetName = "Database2DataSet"
        Me.Database2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Table1BindingSource
        '
        Me.Table1BindingSource.DataMember = "Table1"
        Me.Table1BindingSource.DataSource = Me.Database2DataSet
        '
        'Table1TableAdapter
        '
        Me.Table1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Table1TableAdapter = Me.Table1TableAdapter
        Me.TableAdapterManager.UpdateOrder = TourGuide2.Database2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Table1BindingNavigator
        '
        Me.Table1BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Table1BindingNavigator.BindingSource = Me.Table1BindingSource
        Me.Table1BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Table1BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Table1BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Table1BindingNavigatorSaveItem})
        Me.Table1BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Table1BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Table1BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Table1BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Table1BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Table1BindingNavigator.Name = "Table1BindingNavigator"
        Me.Table1BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Table1BindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.Table1BindingNavigator.TabIndex = 0
        Me.Table1BindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Table1BindingNavigatorSaveItem
        '
        Me.Table1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Table1BindingNavigatorSaveItem.Image = CType(resources.GetObject("Table1BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Table1BindingNavigatorSaveItem.Name = "Table1BindingNavigatorSaveItem"
        Me.Table1BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Table1BindingNavigatorSaveItem.Text = "Save Data"
        '
        'WinterCheckBox
        '
        Me.WinterCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Table1BindingSource, "Winter", True))
        Me.WinterCheckBox.Location = New System.Drawing.Point(32, 57)
        Me.WinterCheckBox.Name = "WinterCheckBox"
        Me.WinterCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.WinterCheckBox.TabIndex = 4
        Me.WinterCheckBox.Text = "Winter"
        Me.WinterCheckBox.UseVisualStyleBackColor = True
        '
        'SpringCheckBox
        '
        Me.SpringCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Table1BindingSource, "Spring", True))
        Me.SpringCheckBox.Location = New System.Drawing.Point(142, 57)
        Me.SpringCheckBox.Name = "SpringCheckBox"
        Me.SpringCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.SpringCheckBox.TabIndex = 6
        Me.SpringCheckBox.Text = "Spring"
        Me.SpringCheckBox.UseVisualStyleBackColor = True
        '
        'SummerCheckBox
        '
        Me.SummerCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Table1BindingSource, "Summer", True))
        Me.SummerCheckBox.Location = New System.Drawing.Point(277, 57)
        Me.SummerCheckBox.Name = "SummerCheckBox"
        Me.SummerCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.SummerCheckBox.TabIndex = 8
        Me.SummerCheckBox.Text = "Summer"
        Me.SummerCheckBox.UseVisualStyleBackColor = True
        '
        'FallCheckBox
        '
        Me.FallCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Table1BindingSource, "Fall", True))
        Me.FallCheckBox.Location = New System.Drawing.Point(409, 57)
        Me.FallCheckBox.Name = "FallCheckBox"
        Me.FallCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.FallCheckBox.TabIndex = 10
        Me.FallCheckBox.Text = "Fall"
        Me.FallCheckBox.UseVisualStyleBackColor = True
        '
        'HotelCheckBox
        '
        Me.HotelCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Table1BindingSource, "Hotel", True))
        Me.HotelCheckBox.Location = New System.Drawing.Point(539, 57)
        Me.HotelCheckBox.Name = "HotelCheckBox"
        Me.HotelCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.HotelCheckBox.TabIndex = 12
        Me.HotelCheckBox.Text = "Hotel"
        Me.HotelCheckBox.UseVisualStyleBackColor = True
        '
        'ResturauntCheckBox
        '
        Me.ResturauntCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Table1BindingSource, "Resturaunt", True))
        Me.ResturauntCheckBox.Location = New System.Drawing.Point(32, 124)
        Me.ResturauntCheckBox.Name = "ResturauntCheckBox"
        Me.ResturauntCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.ResturauntCheckBox.TabIndex = 14
        Me.ResturauntCheckBox.Text = "Resturaunt"
        Me.ResturauntCheckBox.UseVisualStyleBackColor = True
        '
        'ShoppingCheckBox
        '
        Me.ShoppingCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Table1BindingSource, "Shopping", True))
        Me.ShoppingCheckBox.Location = New System.Drawing.Point(142, 124)
        Me.ShoppingCheckBox.Name = "ShoppingCheckBox"
        Me.ShoppingCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.ShoppingCheckBox.TabIndex = 16
        Me.ShoppingCheckBox.Text = "Shopping"
        Me.ShoppingCheckBox.UseVisualStyleBackColor = True
        '
        'OutdorsCheckBox
        '
        Me.OutdorsCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Table1BindingSource, "Outdors", True))
        Me.OutdorsCheckBox.Location = New System.Drawing.Point(277, 124)
        Me.OutdorsCheckBox.Name = "OutdorsCheckBox"
        Me.OutdorsCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.OutdorsCheckBox.TabIndex = 18
        Me.OutdorsCheckBox.Text = "Outdoors"
        Me.OutdorsCheckBox.UseVisualStyleBackColor = True
        '
        'LandMarkCheckBox
        '
        Me.LandMarkCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Table1BindingSource, "LandMark", True))
        Me.LandMarkCheckBox.Location = New System.Drawing.Point(409, 124)
        Me.LandMarkCheckBox.Name = "LandMarkCheckBox"
        Me.LandMarkCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.LandMarkCheckBox.TabIndex = 20
        Me.LandMarkCheckBox.Text = "Land Marks"
        Me.LandMarkCheckBox.UseVisualStyleBackColor = True
        '
        'Activity_CenterCheckBox
        '
        Me.Activity_CenterCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Table1BindingSource, "Activity Center", True))
        Me.Activity_CenterCheckBox.Location = New System.Drawing.Point(539, 124)
        Me.Activity_CenterCheckBox.Name = "Activity_CenterCheckBox"
        Me.Activity_CenterCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Activity_CenterCheckBox.TabIndex = 22
        Me.Activity_CenterCheckBox.Text = "Activity Centers"
        Me.Activity_CenterCheckBox.UseVisualStyleBackColor = True
        '
        'PictureTextBox
        '
        Me.PictureTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Picture", True))
        Me.PictureTextBox.Location = New System.Drawing.Point(271, 382)
        Me.PictureTextBox.Name = "PictureTextBox"
        Me.PictureTextBox.Size = New System.Drawing.Size(104, 20)
        Me.PictureTextBox.TabIndex = 24
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Description", True))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(271, 318)
        Me.DescriptionTextBox.Multiline = True
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(488, 58)
        Me.DescriptionTextBox.TabIndex = 26
        '
        'CostTextBox
        '
        Me.CostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Cost", True))
        Me.CostTextBox.Location = New System.Drawing.Point(89, 504)
        Me.CostTextBox.Name = "CostTextBox"
        Me.CostTextBox.Size = New System.Drawing.Size(104, 20)
        Me.CostTextBox.TabIndex = 28
        '
        'LocationTextBox
        '
        Me.LocationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Location", True))
        Me.LocationTextBox.Location = New System.Drawing.Point(89, 478)
        Me.LocationTextBox.Name = "LocationTextBox"
        Me.LocationTextBox.Size = New System.Drawing.Size(217, 20)
        Me.LocationTextBox.TabIndex = 30
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(8, 318)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(185, 154)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(52, 181)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 32
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 596)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.WinterCheckBox)
        Me.Controls.Add(Me.SpringCheckBox)
        Me.Controls.Add(Me.SummerCheckBox)
        Me.Controls.Add(Me.FallCheckBox)
        Me.Controls.Add(Me.HotelCheckBox)
        Me.Controls.Add(Me.ResturauntCheckBox)
        Me.Controls.Add(Me.ShoppingCheckBox)
        Me.Controls.Add(Me.OutdorsCheckBox)
        Me.Controls.Add(Me.LandMarkCheckBox)
        Me.Controls.Add(Me.Activity_CenterCheckBox)
        Me.Controls.Add(PictureLabel)
        Me.Controls.Add(Me.PictureTextBox)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(CostLabel)
        Me.Controls.Add(Me.CostTextBox)
        Me.Controls.Add(LocationLabel)
        Me.Controls.Add(Me.LocationTextBox)
        Me.Controls.Add(Me.Table1BindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Tour Guide"
        CType(Me.Database2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Table1BindingNavigator.ResumeLayout(False)
        Me.Table1BindingNavigator.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Database2DataSet As Database2DataSet
    Friend WithEvents Table1BindingSource As BindingSource
    Friend WithEvents Table1TableAdapter As Database2DataSetTableAdapters.Table1TableAdapter
    Friend WithEvents TableAdapterManager As Database2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Table1BindingNavigator As BindingNavigator
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
    Friend WithEvents Table1BindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents WinterCheckBox As CheckBox
    Friend WithEvents SpringCheckBox As CheckBox
    Friend WithEvents SummerCheckBox As CheckBox
    Friend WithEvents FallCheckBox As CheckBox
    Friend WithEvents HotelCheckBox As CheckBox
    Friend WithEvents ResturauntCheckBox As CheckBox
    Friend WithEvents ShoppingCheckBox As CheckBox
    Friend WithEvents OutdorsCheckBox As CheckBox
    Friend WithEvents LandMarkCheckBox As CheckBox
    Friend WithEvents Activity_CenterCheckBox As CheckBox
    Friend WithEvents PictureTextBox As TextBox
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents CostTextBox As TextBox
    Friend WithEvents LocationTextBox As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents IDTextBox As TextBox
End Class
