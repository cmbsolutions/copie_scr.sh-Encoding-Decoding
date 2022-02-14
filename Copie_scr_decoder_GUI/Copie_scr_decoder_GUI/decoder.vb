Public Class decoder
    Private Const start_seed As UInteger = &H1BE3AC
    Private seed As UInteger

    Private Function prng_rand() As UInteger
        Dim r0, r1, r3 As UInteger

        r0 = seed
        r1 = (seed >> 1) Or (seed << 31)
        r3 = CUInt(((r1 >> 16) And 255) + r1)
        r1 = CUInt(((r3 >> 8) And 255) << 16)
        r3 -= r1
        seed = r3

        Return r0
    End Function

    Public Function Decode(file As String, custom_seed As UInteger) As String
        Try
            If custom_seed = 0 Then
                seed = start_seed
            Else
                seed = custom_seed
            End If

            prng_rand()

            Dim inData() As Byte = IO.File.ReadAllBytes(file)
            Dim outData As New List(Of Byte)

            For Each c In inData
                c = CByte(c Xor (prng_rand() And 255))
                outData.Add(c)
            Next

            Return Text.Encoding.ASCII.GetString(outData.ToArray)

        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Return ""
        End Try
    End Function
End Class
