Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ofd.ShowDialog = DialogResult.OK Then
            Dim dec As New decoder

            rtb.Text = dec.Decode(ofd.FileName)

        End If
    End Sub

    Private Sub pFile_DragDrop(sender As Object, e As DragEventArgs) Handles pFile.DragDrop
        Dim files() As String = CType(e.Data.GetData("FileDrop"), String())

        For Each f In files
            Dim dec As New decoder

            rtb.Text = dec.Decode(f)
        Next
    End Sub

    Private Sub pFile_DragEnter(sender As Object, e As DragEventArgs) Handles pFile.DragEnter
        If e.Data.GetDataPresent("FileDrop") Then e.Effect = DragDropEffects.Copy
    End Sub
End Class
