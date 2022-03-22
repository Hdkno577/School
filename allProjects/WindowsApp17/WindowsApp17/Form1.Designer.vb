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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim IDLabel As System.Windows.Forms.Label
        Dim WeoponLabel As System.Windows.Forms.Label
        Dim DamageLabel As System.Windows.Forms.Label
        Dim SpeedLabel As System.Windows.Forms.Label
        Dim AccuracyLabel As System.Windows.Forms.Label
        Dim Emotional_DamageLabel As System.Windows.Forms.Label
        Dim ClassLabel As System.Windows.Forms.Label
        Dim PictureLabel As System.Windows.Forms.Label
        Me.Database1DataSet = New WindowsApp17.Database1DataSet()
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table1TableAdapter = New WindowsApp17.Database1DataSetTableAdapters.Table1TableAdapter()
        Me.TableAdapterManager = New WindowsApp17.Database1DataSetTableAdapters.TableAdapterManager()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Table1BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Table1BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.WeoponTextBox = New System.Windows.Forms.TextBox()
        Me.DamageTextBox = New System.Windows.Forms.TextBox()
        Me.SpeedTextBox = New System.Windows.Forms.TextBox()
        Me.AccuracyTextBox = New System.Windows.Forms.TextBox()
        Me.Emotional_DamageTextBox = New System.Windows.Forms.TextBox()
        Me.ClassTextBox = New System.Windows.Forms.TextBox()
        Me.PictureTextBox = New System.Windows.Forms.TextBox()
        IDLabel = New System.Windows.Forms.Label()
        WeoponLabel = New System.Windows.Forms.Label()
        DamageLabel = New System.Windows.Forms.Label()
        SpeedLabel = New System.Windows.Forms.Label()
        AccuracyLabel = New System.Windows.Forms.Label()
        Emotional_DamageLabel = New System.Windows.Forms.Label()
        ClassLabel = New System.Windows.Forms.Label()
        PictureLabel = New System.Windows.Forms.Label()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Table1BindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Table1BindingSource
        '
        Me.Table1BindingSource.DataMember = "Table1"
        Me.Table1BindingSource.DataSource = Me.Database1DataSet
        '
        'Table1TableAdapter
        '
        Me.Table1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Table1TableAdapter = Me.Table1TableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApp17.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
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
        'Table1BindingNavigatorSaveItem
        '
        Me.Table1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Table1BindingNavigatorSaveItem.Image = CType(resources.GetObject("Table1BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Table1BindingNavigatorSaveItem.Name = "Table1BindingNavigatorSaveItem"
        Me.Table1BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Table1BindingNavigatorSaveItem.Text = "Save Data"
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
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(154, 163)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(259, 160)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 2
        '
        'WeoponLabel
        '
        WeoponLabel.AutoSize = True
        WeoponLabel.Location = New System.Drawing.Point(154, 189)
        WeoponLabel.Name = "WeoponLabel"
        WeoponLabel.Size = New System.Drawing.Size(51, 13)
        WeoponLabel.TabIndex = 3
        WeoponLabel.Text = "Weopon:"
        '
        'WeoponTextBox
        '
        Me.WeoponTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Weopon", True))
        Me.WeoponTextBox.Location = New System.Drawing.Point(259, 186)
        Me.WeoponTextBox.Name = "WeoponTextBox"
        Me.WeoponTextBox.Size = New System.Drawing.Size(100, 20)
        Me.WeoponTextBox.TabIndex = 4
        '
        'DamageLabel
        '
        DamageLabel.AutoSize = True
        DamageLabel.Location = New System.Drawing.Point(154, 215)
        DamageLabel.Name = "DamageLabel"
        DamageLabel.Size = New System.Drawing.Size(50, 13)
        DamageLabel.TabIndex = 5
        DamageLabel.Text = "Damage:"
        '
        'DamageTextBox
        '
        Me.DamageTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Damage", True))
        Me.DamageTextBox.Location = New System.Drawing.Point(259, 212)
        Me.DamageTextBox.Name = "DamageTextBox"
        Me.DamageTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DamageTextBox.TabIndex = 6
        '
        'SpeedLabel
        '
        SpeedLabel.AutoSize = True
        SpeedLabel.Location = New System.Drawing.Point(154, 241)
        SpeedLabel.Name = "SpeedLabel"
        SpeedLabel.Size = New System.Drawing.Size(41, 13)
        SpeedLabel.TabIndex = 7
        SpeedLabel.Text = "Speed:"
        '
        'SpeedTextBox
        '
        Me.SpeedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Speed", True))
        Me.SpeedTextBox.Location = New System.Drawing.Point(259, 238)
        Me.SpeedTextBox.Name = "SpeedTextBox"
        Me.SpeedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SpeedTextBox.TabIndex = 8
        '
        'AccuracyLabel
        '
        AccuracyLabel.AutoSize = True
        AccuracyLabel.Location = New System.Drawing.Point(154, 267)
        AccuracyLabel.Name = "AccuracyLabel"
        AccuracyLabel.Size = New System.Drawing.Size(55, 13)
        AccuracyLabel.TabIndex = 9
        AccuracyLabel.Text = "Accuracy:"
        '
        'AccuracyTextBox
        '
        Me.AccuracyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Accuracy", True))
        Me.AccuracyTextBox.Location = New System.Drawing.Point(259, 264)
        Me.AccuracyTextBox.Name = "AccuracyTextBox"
        Me.AccuracyTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AccuracyTextBox.TabIndex = 10
        '
        'Emotional_DamageLabel
        '
        Emotional_DamageLabel.AutoSize = True
        Emotional_DamageLabel.Location = New System.Drawing.Point(154, 293)
        Emotional_DamageLabel.Name = "Emotional_DamageLabel"
        Emotional_DamageLabel.Size = New System.Drawing.Size(99, 13)
        Emotional_DamageLabel.TabIndex = 11
        Emotional_DamageLabel.Text = "Emotional Damage:"
        '
        'Emotional_DamageTextBox
        '
        Me.Emotional_DamageTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Emotional Damage", True))
        Me.Emotional_DamageTextBox.Location = New System.Drawing.Point(259, 290)
        Me.Emotional_DamageTextBox.Name = "Emotional_DamageTextBox"
        Me.Emotional_DamageTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Emotional_DamageTextBox.TabIndex = 12
        '
        'ClassLabel
        '
        ClassLabel.AutoSize = True
        ClassLabel.Location = New System.Drawing.Point(154, 319)
        ClassLabel.Name = "ClassLabel"
        ClassLabel.Size = New System.Drawing.Size(35, 13)
        ClassLabel.TabIndex = 13
        ClassLabel.Text = "Class:"
        '
        'ClassTextBox
        '
        Me.ClassTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Class", True))
        Me.ClassTextBox.Location = New System.Drawing.Point(259, 316)
        Me.ClassTextBox.Name = "ClassTextBox"
        Me.ClassTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ClassTextBox.TabIndex = 14
        '
        'PictureLabel
        '
        PictureLabel.AutoSize = True
        PictureLabel.Location = New System.Drawing.Point(154, 345)
        PictureLabel.Name = "PictureLabel"
        PictureLabel.Size = New System.Drawing.Size(43, 13)
        PictureLabel.TabIndex = 15
        PictureLabel.Text = "Picture:"
        '
        'PictureTextBox
        '
        Me.PictureTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Picture", True))
        Me.PictureTextBox.Location = New System.Drawing.Point(259, 342)
        Me.PictureTextBox.Name = "PictureTextBox"
        Me.PictureTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PictureTextBox.TabIndex = 16
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 468)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(WeoponLabel)
        Me.Controls.Add(Me.WeoponTextBox)
        Me.Controls.Add(DamageLabel)
        Me.Controls.Add(Me.DamageTextBox)
        Me.Controls.Add(SpeedLabel)
        Me.Controls.Add(Me.SpeedTextBox)
        Me.Controls.Add(AccuracyLabel)
        Me.Controls.Add(Me.AccuracyTextBox)
        Me.Controls.Add(Emotional_DamageLabel)
        Me.Controls.Add(Me.Emotional_DamageTextBox)
        Me.Controls.Add(ClassLabel)
        Me.Controls.Add(Me.ClassTextBox)
        Me.Controls.Add(PictureLabel)
        Me.Controls.Add(Me.PictureTextBox)
        Me.Controls.Add(Me.Table1BindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Table1BindingNavigator.ResumeLayout(False)
        Me.Table1BindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Database1DataSet As Database1DataSet
    Friend WithEvents Table1BindingSource As BindingSource
    Friend WithEvents Table1TableAdapter As Database1DataSetTableAdapters.Table1TableAdapter
    Friend WithEvents TableAdapterManager As Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents Table1BindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Table1BindingNavigator As BindingNavigator
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents WeoponTextBox As TextBox
    Friend WithEvents DamageTextBox As TextBox
    Friend WithEvents SpeedTextBox As TextBox
    Friend WithEvents AccuracyTextBox As TextBox
    Friend WithEvents Emotional_DamageTextBox As TextBox
    Friend WithEvents ClassTextBox As TextBox
    Friend WithEvents PictureTextBox As TextBox
End Class
