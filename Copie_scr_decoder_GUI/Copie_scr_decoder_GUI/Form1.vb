Public Class Form1
    Private lexer As LexerStyles

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
        Dim txt As String = ""

        If cb1.SelectedItem IsNot Nothing Then
            If cb1.SelectedIndex = 0 Then
                txt = dec.AutoDecodeFile(sFile)
            Else
                Try
                    cs = Convert.ToUInt32(cb1.SelectedItem.ToString, 16)
                    txt = dec.DecodeFile(sFile, cs)
                Catch ex As Exception
                    MessageBox.Show("Not a valid seed!")
                    cs = Nothing
                End Try
            End If
        End If

        'rtb.Text = dec.DecodeFile(sFile, cs)
        scEditor.ClearAll()
        scEditor.Text = txt
        scEditor.Colorize(0, scEditor.Text.Length)
    End Sub

    Private Sub bEnc_Click(sender As Object, e As EventArgs) Handles bEnc.Click
        If scEditor.TextLength = 0 Then
            MessageBox.Show("Nothing to encode!")
            Exit Sub
        End If

        Dim data() As Byte = System.Text.Encoding.ASCII.GetBytes(scEditor.Text)

        If data(0) <> 35 Then
            MessageBox.Show("Encoding can only be done on decoded text!")
            Exit Sub
        End If


        If cb1.SelectedIndex = 0 Then cb1.SelectedIndex = 1

        Dim dec As New decoder
        Dim cs As UInteger = Nothing

        If cb1.SelectedItem IsNot Nothing Then
            Try
                cs = Convert.ToUInt32(cb1.SelectedItem.ToString, 16)
            Catch ex As Exception
                MessageBox.Show("Not a valid seed!")
                cs = Nothing
            End Try
        End If

        If sfd.ShowDialog = DialogResult.OK Then
            IO.File.WriteAllBytes(sfd.FileName, dec.EncodeString(scEditor.Text, cs))
            MessageBox.Show("File written!")
        End If
    End Sub

    Private Sub ImportReadableFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportReadableFileToolStripMenuItem.Click
        If ofd.ShowDialog = DialogResult.OK Then
            'rtb.Text = IO.File.ReadAllText(ofd.FileName)
            scEditor.ClearAll()
            scEditor.Text = IO.File.ReadAllText(ofd.FileName)
            scEditor.Colorize(0, scEditor.Text.Length)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        lexer = New LexerStyles
        lexer.setKShStyle(scEditor)
        cb1.SelectedIndex = 0
    End Sub
End Class
