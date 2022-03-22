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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.colorBox = New System.Windows.Forms.TextBox()
        Me.makeBox = New System.Windows.Forms.TextBox()
        Me.yearBox = New System.Windows.Forms.TextBox()
        Me.seatBox = New System.Windows.Forms.TextBox()
        Me.priceBox = New System.Windows.Forms.TextBox()
        Me.modelBox = New System.Windows.Forms.TextBox()
        Me.hpBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(34, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Audi TT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Color"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Make"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Year"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Seats"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 284)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Price"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 334)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Model"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 383)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Horse Power"
        '
        'colorBox
        '
        Me.colorBox.Location = New System.Drawing.Point(68, 69)
        Me.colorBox.Name = "colorBox"
        Me.colorBox.ReadOnly = True
        Me.colorBox.Size = New System.Drawing.Size(100, 20)
        Me.colorBox.TabIndex = 8
        '
        'makeBox
        '
        Me.makeBox.Location = New System.Drawing.Point(71, 122)
        Me.makeBox.Name = "makeBox"
        Me.makeBox.ReadOnly = True
        Me.makeBox.Size = New System.Drawing.Size(100, 20)
        Me.makeBox.TabIndex = 9
        '
        'yearBox
        '
        Me.yearBox.Location = New System.Drawing.Point(66, 178)
        Me.yearBox.Name = "yearBox"
        Me.yearBox.ReadOnly = True
        Me.yearBox.Size = New System.Drawing.Size(100, 20)
        Me.yearBox.TabIndex = 10
        '
        'seatBox
        '
        Me.seatBox.Location = New System.Drawing.Point(71, 230)
        Me.seatBox.Name = "seatBox"
        Me.seatBox.ReadOnly = True
        Me.seatBox.Size = New System.Drawing.Size(100, 20)
        Me.seatBox.TabIndex = 11
        '
        'priceBox
        '
        Me.priceBox.Location = New System.Drawing.Point(68, 284)
        Me.priceBox.Name = "priceBox"
        Me.priceBox.ReadOnly = True
        Me.priceBox.Size = New System.Drawing.Size(100, 20)
        Me.priceBox.TabIndex = 12
        '
        'modelBox
        '
        Me.modelBox.Location = New System.Drawing.Point(73, 334)
        Me.modelBox.Name = "modelBox"
        Me.modelBox.ReadOnly = True
        Me.modelBox.Size = New System.Drawing.Size(100, 20)
        Me.modelBox.TabIndex = 13
        '
        'hpBox
        '
        Me.hpBox.Location = New System.Drawing.Point(105, 383)
        Me.hpBox.Name = "hpBox"
        Me.hpBox.ReadOnly = True
        Me.hpBox.Size = New System.Drawing.Size(100, 20)
        Me.hpBox.TabIndex = 14
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(129, 21)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Toyota Corolla"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(258, 21)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(114, 23)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Porsche Cayman"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.hpBox)
        Me.Controls.Add(Me.modelBox)
        Me.Controls.Add(Me.priceBox)
        Me.Controls.Add(Me.seatBox)
        Me.Controls.Add(Me.yearBox)
        Me.Controls.Add(Me.makeBox)
        Me.Controls.Add(Me.colorBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents colorBox As TextBox
    Friend WithEvents makeBox As TextBox
    Friend WithEvents yearBox As TextBox
    Friend WithEvents seatBox As TextBox
    Friend WithEvents priceBox As TextBox
    Friend WithEvents modelBox As TextBox
    Friend WithEvents hpBox As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
