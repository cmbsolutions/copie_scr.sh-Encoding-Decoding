Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ofd.ShowDialog = DialogResult.OK Then
            Dim dec As New decoder
            Dim cs As UInteger = Nothing

            If cb1.SelectedItem IsNot Nothing Then
                Try
                    cs = Convert.ToUInt32(cb1.SelectedItem.ToString, 16)
                Catch ex As Exception
                    MessageBox.Show("Not a valid seed")
                    cs = Nothing
                End Try
            End If
            rtb.Text = dec.Decode(ofd.FileName, cs)

        End If
    End Sub

    Private Sub pFile_DragDrop(sender As Object, e As DragEventArgs) Handles pFile.DragDrop
        Dim files() As String = CType(e.Data.GetData("FileDrop"), String())
        Dim cs As UInteger = Nothing
        If cb1.SelectedItem IsNot Nothing Then
            Try
                cs = Convert.ToUInt32(cb1.SelectedItem.ToString, 16)
            Catch ex As Exception
                MessageBox.Show("Not a valid seed")
                cs = Nothing
            End Try
        End If
        For Each f In files
            Dim dec As New decoder

            rtb.Text = dec.Decode(f, cs)
        Next
    End Sub

    Private Sub pFile_DragEnter(sender As Object, e As DragEventArgs) Handles pFile.DragEnter
        If e.Data.GetDataPresent("FileDrop") Then e.Effect = DragDropEffects.Copy
    End Sub
End Class
