Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ofd.ShowDialog = DialogResult.OK Then
            decodeFile(ofd.FileName)
        End If
    End Sub

    Private Sub pFile_DragDrop(sender As Object, e As DragEventArgs) Handles pFile.DragDrop
        Dim files() As String = CType(e.Data.GetData("FileDrop"), String())
        decodeFile(files.First)
    End Sub

    Private Sub pFile_DragEnter(sender As Object, e As DragEventArgs) Handles pFile.DragEnter
        If e.Data.GetDataPresent("FileDrop") Then e.Effect = DragDropEffects.Copy
    End Sub

    Private Sub decodeFile(sFile As String)
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
        rtb.Text = dec.DecodeFile(sFile, cs)
    End Sub

    Private Sub bEnc_Click(sender As Object, e As EventArgs) Handles bEnc.Click
        If rtb.TextLength = 0 Then
            MessageBox.Show("Nothing to encode")
            Exit Sub
        End If

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

        If sfd.ShowDialog = DialogResult.OK Then
            IO.File.WriteAllBytes(sfd.FileName, dec.EncodeString(rtb.Text, cs))
        End If

        MessageBox.Show("File written")
    End Sub

    Private Sub ImportReadableFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportReadableFileToolStripMenuItem.Click
        If ofd.ShowDialog = DialogResult.OK Then
            rtb.Text = IO.File.ReadAllText(ofd.FileName)
        End If
    End Sub
End Class
