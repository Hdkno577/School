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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.clear = New System.Windows.Forms.Button()
        Me.PeriBox = New System.Windows.Forms.TextBox()
        Me.AreaBox = New System.Windows.Forms.TextBox()
        Me.SideBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.sclear = New System.Windows.Forms.Button()
        Me.rPeriBox = New System.Windows.Forms.TextBox()
        Me.rAreaBox = New System.Windows.Forms.TextBox()
        Me.WidthBox = New System.Windows.Forms.TextBox()
        Me.lengthBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tPeri = New System.Windows.Forms.TextBox()
        Me.tArea = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TriC = New System.Windows.Forms.TextBox()
        Me.TriB = New System.Windows.Forms.TextBox()
        Me.TriA = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.clear)
        Me.GroupBox1.Controls.Add(Me.PeriBox)
        Me.GroupBox1.Controls.Add(Me.AreaBox)
        Me.GroupBox1.Controls.Add(Me.SideBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(112, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(217, 172)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Square"
        '
        'clear
        '
        Me.clear.Location = New System.Drawing.Point(6, 143)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(75, 23)
        Me.clear.TabIndex = 7
        Me.clear.Text = "Clear"
        Me.clear.UseVisualStyleBackColor = True
        '
        'PeriBox
        '
        Me.PeriBox.Location = New System.Drawing.Point(73, 103)
        Me.PeriBox.Name = "PeriBox"
        Me.PeriBox.ReadOnly = True
        Me.PeriBox.Size = New System.Drawing.Size(100, 20)
        Me.PeriBox.TabIndex = 6
        '
        'AreaBox
        '
        Me.AreaBox.Location = New System.Drawing.Point(73, 68)
        Me.AreaBox.Name = "AreaBox"
        Me.AreaBox.ReadOnly = True
        Me.AreaBox.Size = New System.Drawing.Size(100, 20)
        Me.AreaBox.TabIndex = 5
        '
        'SideBox
        '
        Me.SideBox.Location = New System.Drawing.Point(73, 35)
        Me.SideBox.Name = "SideBox"
        Me.SideBox.Size = New System.Drawing.Size(100, 20)
        Me.SideBox.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Perimeter"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Area"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Side"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.sclear)
        Me.GroupBox2.Controls.Add(Me.rPeriBox)
        Me.GroupBox2.Controls.Add(Me.rAreaBox)
        Me.GroupBox2.Controls.Add(Me.WidthBox)
        Me.GroupBox2.Controls.Add(Me.lengthBox)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(335, 62)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(376, 172)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rectangle"
        '
        'sclear
        '
        Me.sclear.Location = New System.Drawing.Point(7, 143)
        Me.sclear.Name = "sclear"
        Me.sclear.Size = New System.Drawing.Size(75, 23)
        Me.sclear.TabIndex = 8
        Me.sclear.Text = "Clear"
        Me.sclear.UseVisualStyleBackColor = True
        '
        'rPeriBox
        '
        Me.rPeriBox.Location = New System.Drawing.Point(75, 98)
        Me.rPeriBox.Name = "rPeriBox"
        Me.rPeriBox.ReadOnly = True
        Me.rPeriBox.Size = New System.Drawing.Size(100, 20)
        Me.rPeriBox.TabIndex = 7
        '
        'rAreaBox
        '
        Me.rAreaBox.Location = New System.Drawing.Point(75, 75)
        Me.rAreaBox.Name = "rAreaBox"
        Me.rAreaBox.ReadOnly = True
        Me.rAreaBox.Size = New System.Drawing.Size(100, 20)
        Me.rAreaBox.TabIndex = 6
        '
        'WidthBox
        '
        Me.WidthBox.Location = New System.Drawing.Point(75, 51)
        Me.WidthBox.Name = "WidthBox"
        Me.WidthBox.Size = New System.Drawing.Size(100, 20)
        Me.WidthBox.TabIndex = 5
        '
        'lengthBox
        '
        Me.lengthBox.Location = New System.Drawing.Point(75, 25)
        Me.lengthBox.Name = "lengthBox"
        Me.lengthBox.Size = New System.Drawing.Size(100, 20)
        Me.lengthBox.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Perimeter"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Area"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Width"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Length"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.tPeri)
        Me.GroupBox3.Controls.Add(Me.tArea)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.TriC)
        Me.GroupBox3.Controls.Add(Me.TriB)
        Me.GroupBox3.Controls.Add(Me.TriA)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(112, 235)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(217, 203)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Triangle"
        '
        'tPeri
        '
        Me.tPeri.Location = New System.Drawing.Point(63, 151)
        Me.tPeri.Name = "tPeri"
        Me.tPeri.ReadOnly = True
        Me.tPeri.Size = New System.Drawing.Size(100, 20)
        Me.tPeri.TabIndex = 9
        '
        'tArea
        '
        Me.tArea.Location = New System.Drawing.Point(63, 121)
        Me.tArea.Name = "tArea"
        Me.tArea.ReadOnly = True
        Me.tArea.Size = New System.Drawing.Size(100, 20)
        Me.tArea.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 154)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 13)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Perimeter"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 124)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Area"
        '
        'TriC
        '
        Me.TriC.Location = New System.Drawing.Point(63, 88)
        Me.TriC.Name = "TriC"
        Me.TriC.Size = New System.Drawing.Size(100, 20)
        Me.TriC.TabIndex = 5
        '
        'TriB
        '
        Me.TriB.Location = New System.Drawing.Point(63, 56)
        Me.TriB.Name = "TriB"
        Me.TriB.Size = New System.Drawing.Size(100, 20)
        Me.TriB.TabIndex = 4
        '
        'TriA
        '
        Me.TriA.Location = New System.Drawing.Point(63, 20)
        Me.TriA.Name = "TriA"
        Me.TriA.Size = New System.Drawing.Size(100, 20)
        Me.TriA.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Side C"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Side B"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Side A"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Area"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PeriBox As TextBox
    Friend WithEvents AreaBox As TextBox
    Friend WithEvents SideBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents clear As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rPeriBox As TextBox
    Friend WithEvents rAreaBox As TextBox
    Friend WithEvents WidthBox As TextBox
    Friend WithEvents lengthBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents sclear As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents tPeri As TextBox
    Friend WithEvents tArea As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TriC As TextBox
    Friend WithEvents TriB As TextBox
    Friend WithEvents TriA As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
End Class
