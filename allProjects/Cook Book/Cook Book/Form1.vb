Public Class Form1
    Private Sub RecipiesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles RecipiesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RecipiesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database4DataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database4DataSet.Recipies' table. You can move, or remove it, as needed.
        Me.RecipiesTableAdapter.Fill(Me.Database4DataSet.Recipies)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        OpenFileDialog1.ShowDialog()
        PictureBox1.Load(OpenFileDialog1.FileName)
    End Sub

    Private Sub PictureTextBox_TextChanged(sender As Object, e As EventArgs) Handles PictureTextBox.TextChanged
        If IO.File.Exists(PictureTextBox.Text) Then
            PictureBox1.Load(PictureTextBox.Text)
        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        PictureTextBox.Text = OpenFileDialog1.FileName
    End Sub
End Class
