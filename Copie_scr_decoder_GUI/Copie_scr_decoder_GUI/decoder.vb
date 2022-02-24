Imports System.Text.RegularExpressions

Public Class decoder
    Private ReadOnly start_seeds As New List(Of UInteger)({&H1BE3AC, &HEBAEBA})
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

    Public Function AutoDecodeFile(file As String) As String
        Dim data() As Byte = IO.File.ReadAllBytes(file)
        Dim cs As UInteger = 0

        If data(0) = 241 Then cs = start_seeds(1)
        If data(0) = 192 Then cs = start_seeds(0)

        Dim outData() As Byte = Decode(data, cs)

        Return Text.Encoding.ASCII.GetString(outData)
    End Function

    Public Function DecodeFile(file As String, custom_seed As UInteger) As String
        Dim data() As Byte = IO.File.ReadAllBytes(file)
        Dim outData() As Byte = Decode(data, custom_seed)

        Return Text.Encoding.ASCII.GetString(outData)
    End Function

    Public Function EncodeString(input As String, custom_seed As UInteger) As Byte()
        ' Convert to unix format (only linefeeds)
        input = Regex.Replace(input, "\r\n", vbLf, RegexOptions.IgnoreCase)
        Dim data() As Byte = Text.Encoding.ASCII.GetBytes(input)

        Return Decode(data, custom_seed)
    End Function

    Private Function Decode(data() As Byte, custom_seed As UInteger) As Byte()
        Try
            If custom_seed = 0 Then
                seed = start_seeds.First
            Else
                seed = custom_seed
            End If

            prng_rand()

            Dim outData As New List(Of Byte)

            For Each c In data
                c = CByte(c Xor (prng_rand() And 255))
                outData.Add(c)
            Next

            Return outData.ToArray

        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Return Nothing
        End Try
    End Function
End Class
