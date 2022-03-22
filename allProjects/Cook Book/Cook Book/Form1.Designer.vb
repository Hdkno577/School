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
        Dim IDLabel As System.Windows.Forms.Label
        Dim DishLabel As System.Windows.Forms.Label
        Dim InstructionsLabel As System.Windows.Forms.Label
        Dim PictureLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Database4DataSet = New Cook_Book.Database4DataSet()
        Me.RecipiesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecipiesTableAdapter = New Cook_Book.Database4DataSetTableAdapters.RecipiesTableAdapter()
        Me.TableAdapterManager = New Cook_Book.Database4DataSetTableAdapters.TableAdapterManager()
        Me.RecipiesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.RecipiesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.DishTextBox = New System.Windows.Forms.TextBox()
        Me.InstructionsTextBox = New System.Windows.Forms.TextBox()
        Me.VegatarianCheckBox = New System.Windows.Forms.CheckBox()
        Me.SpicyCheckBox = New System.Windows.Forms.CheckBox()
        Me.SoupCheckBox = New System.Windows.Forms.CheckBox()
        Me.PictureTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        IDLabel = New System.Windows.Forms.Label()
        DishLabel = New System.Windows.Forms.Label()
        InstructionsLabel = New System.Windows.Forms.Label()
        PictureLabel = New System.Windows.Forms.Label()
        CType(Me.Database4DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecipiesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecipiesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RecipiesBindingNavigator.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(13, 45)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'DishLabel
        '
        DishLabel.AutoSize = True
        DishLabel.Location = New System.Drawing.Point(13, 71)
        DishLabel.Name = "DishLabel"
        DishLabel.Size = New System.Drawing.Size(31, 13)
        DishLabel.TabIndex = 3
        DishLabel.Text = "Dish:"
        '
        'InstructionsLabel
        '
        InstructionsLabel.AutoSize = True
        InstructionsLabel.Location = New System.Drawing.Point(13, 159)
        InstructionsLabel.Name = "InstructionsLabel"
        InstructionsLabel.Size = New System.Drawing.Size(64, 13)
        InstructionsLabel.TabIndex = 5
        InstructionsLabel.Text = "Instructions:"
        '
        'PictureLabel
        '
        PictureLabel.AutoSize = True
        PictureLabel.Location = New System.Drawing.Point(402, 25)
        PictureLabel.Name = "PictureLabel"
        PictureLabel.Size = New System.Drawing.Size(43, 13)
        PictureLabel.TabIndex = 13
        PictureLabel.Text = "Picture:"
        '
        'Database4DataSet
        '
        Me.Database4DataSet.DataSetName = "Database4DataSet"
        Me.Database4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RecipiesBindingSource
        '
        Me.RecipiesBindingSource.DataMember = "Recipies"
        Me.RecipiesBindingSource.DataSource = Me.Database4DataSet
        '
        'RecipiesTableAdapter
        '
        Me.RecipiesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.RecipiesTableAdapter = Me.RecipiesTableAdapter
        Me.TableAdapterManager.UpdateOrder = Cook_Book.Database4DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RecipiesBindingNavigator
        '
        Me.RecipiesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.RecipiesBindingNavigator.BindingSource = Me.RecipiesBindingSource
        Me.RecipiesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.RecipiesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.RecipiesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.RecipiesBindingNavigatorSaveItem})
        Me.RecipiesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.RecipiesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.RecipiesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.RecipiesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.RecipiesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.RecipiesBindingNavigator.Name = "RecipiesBindingNavigator"
        Me.RecipiesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.RecipiesBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.RecipiesBindingNavigator.TabIndex = 0
        Me.RecipiesBindingNavigator.Text = "BindingNavigator1"
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
        'RecipiesBindingNavigatorSaveItem
        '
        Me.RecipiesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RecipiesBindingNavigatorSaveItem.Image = CType(resources.GetObject("RecipiesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.RecipiesBindingNavigatorSaveItem.Name = "RecipiesBindingNavigatorSaveItem"
        Me.RecipiesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.RecipiesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecipiesBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(83, 42)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(104, 20)
        Me.IDTextBox.TabIndex = 2
        '
        'DishTextBox
        '
        Me.DishTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecipiesBindingSource, "Dish", True))
        Me.DishTextBox.Location = New System.Drawing.Point(83, 68)
        Me.DishTextBox.Name = "DishTextBox"
        Me.DishTextBox.Size = New System.Drawing.Size(104, 20)
        Me.DishTextBox.TabIndex = 4
        '
        'InstructionsTextBox
        '
        Me.InstructionsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecipiesBindingSource, "Instructions", True))
        Me.InstructionsTextBox.Location = New System.Drawing.Point(83, 156)
        Me.InstructionsTextBox.Multiline = True
        Me.InstructionsTextBox.Name = "InstructionsTextBox"
        Me.InstructionsTextBox.Size = New System.Drawing.Size(104, 31)
        Me.InstructionsTextBox.TabIndex = 6
        '
        'VegatarianCheckBox
        '
        Me.VegatarianCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.RecipiesBindingSource, "Vegatarian", True))
        Me.VegatarianCheckBox.Location = New System.Drawing.Point(256, 34)
        Me.VegatarianCheckBox.Name = "VegatarianCheckBox"
        Me.VegatarianCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.VegatarianCheckBox.TabIndex = 8
        Me.VegatarianCheckBox.Text = "Vegatarian"
        Me.VegatarianCheckBox.UseVisualStyleBackColor = True
        '
        'SpicyCheckBox
        '
        Me.SpicyCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.RecipiesBindingSource, "Spicy", True))
        Me.SpicyCheckBox.Location = New System.Drawing.Point(256, 64)
        Me.SpicyCheckBox.Name = "SpicyCheckBox"
        Me.SpicyCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.SpicyCheckBox.TabIndex = 10
        Me.SpicyCheckBox.Text = "Spicy"
        Me.SpicyCheckBox.UseVisualStyleBackColor = True
        '
        'SoupCheckBox
        '
        Me.SoupCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.RecipiesBindingSource, "Soup", True))
        Me.SoupCheckBox.Location = New System.Drawing.Point(256, 94)
        Me.SoupCheckBox.Name = "SoupCheckBox"
        Me.SoupCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.SoupCheckBox.TabIndex = 12
        Me.SoupCheckBox.Text = "Soup"
        Me.SoupCheckBox.UseVisualStyleBackColor = True
        '
        'PictureTextBox
        '
        Me.PictureTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecipiesBindingSource, "Picture", True))
        Me.PictureTextBox.Location = New System.Drawing.Point(405, 42)
        Me.PictureTextBox.Name = "PictureTextBox"
        Me.PictureTextBox.Size = New System.Drawing.Size(104, 20)
        Me.PictureTextBox.TabIndex = 14
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(515, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(250, 121)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 211)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(DishLabel)
        Me.Controls.Add(Me.DishTextBox)
        Me.Controls.Add(InstructionsLabel)
        Me.Controls.Add(Me.InstructionsTextBox)
        Me.Controls.Add(Me.VegatarianCheckBox)
        Me.Controls.Add(Me.SpicyCheckBox)
        Me.Controls.Add(Me.SoupCheckBox)
        Me.Controls.Add(PictureLabel)
        Me.Controls.Add(Me.PictureTextBox)
        Me.Controls.Add(Me.RecipiesBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Cook Book"
        CType(Me.Database4DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecipiesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecipiesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RecipiesBindingNavigator.ResumeLayout(False)
        Me.RecipiesBindingNavigator.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Database4DataSet As Database4DataSet
    Friend WithEvents RecipiesBindingSource As BindingSource
    Friend WithEvents RecipiesTableAdapter As Database4DataSetTableAdapters.RecipiesTableAdapter
    Friend WithEvents TableAdapterManager As Database4DataSetTableAdapters.TableAdapterManager
    Friend WithEvents RecipiesBindingNavigator As BindingNavigator
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
    Friend WithEvents RecipiesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents DishTextBox As TextBox
    Friend WithEvents InstructionsTextBox As TextBox
    Friend WithEvents VegatarianCheckBox As CheckBox
    Friend WithEvents SpicyCheckBox As CheckBox
    Friend WithEvents SoupCheckBox As CheckBox
    Friend WithEvents PictureTextBox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
