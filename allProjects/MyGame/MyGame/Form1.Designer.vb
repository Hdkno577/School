<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.P2 = New System.Windows.Forms.PictureBox()
        Me.P1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.P2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'P2
        '
        Me.P2.Image = Global.MyGame.My.Resources.Resources.Enemy__1_
        Me.P2.Location = New System.Drawing.Point(500, 190)
        Me.P2.Name = "P2"
        Me.P2.Size = New System.Drawing.Size(56, 61)
        Me.P2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.P2.TabIndex = 1
        Me.P2.TabStop = False
        '
        'P1
        '
        Me.P1.Image = Global.MyGame.My.Resources.Resources.Character
        Me.P1.Location = New System.Drawing.Point(273, 190)
        Me.P1.Name = "P1"
        Me.P1.Size = New System.Drawing.Size(46, 61)
        Me.P1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.P1.TabIndex = 0
        Me.P1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.P2)
        Me.Controls.Add(Me.P1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.P2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents P1 As PictureBox
    Friend WithEvents P2 As PictureBox
    Friend WithEvents Timer1 As Timer
End Class
