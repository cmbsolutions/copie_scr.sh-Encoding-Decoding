Imports System
Imports System.Text

Module Program
    Sub Main(args As String())
        Try
            If args.Count < 2 Then
                Console.WriteLine("Missing input and/or output file")
                ShowHelp()
                Exit Sub
            End If

            Dim command As String = ""
            Dim inputfile As String = ""
            Dim outputfile As String = ""
            Dim custom_seed As UInteger = 0
            Dim auto As Boolean = True
            Dim forceEncode As Boolean = False
            Dim forceDecode As Boolean = False
            Dim overwrite As Boolean = False

            Dim c As New crypto

            For Each arg In args
                Select Case arg.Substring(0, 2)
                    Case "-a"
                        auto = True
                    Case "-s"
                        Try
                            custom_seed = Convert.ToUInt32(arg.Substring(2), 16)
                        Catch ex As Exception
                            Console.WriteLine($"Invalid seed {arg.Substring(2)}, a seed must be in HEX format. (eg. EBAEBA)")
                            Exit Sub
                        End Try
                    Case "-e"
                    Case "-d"
                        If arg.StartsWith("-e") Then forceEncode = True
                        If arg.StartsWith("-d") Then forceDecode = True
                        Select Case arg.Substring(2)
                            Case "0"
                                custom_seed = c.start_seeds(0)
                            Case "1"
                                custom_seed = c.start_seeds(1)
                            Case "2"
                                If custom_seed = 0 And args.Count(Function(x) x.StartsWith("-s")) = 0 Then
                                    Console.WriteLine($"Missing -s option, -s option is required when using {arg} option. {If(arg.StartsWith("-e"), "En", "De")}coding will be done with default seed.")
                                    custom_seed = c.start_seeds(0)
                                End If
                            Case Else
                                Console.WriteLine($"Unknown {arg} option. {If(arg.StartsWith("-e"), "En", "De")}coding will be done with default seed.")
                                custom_seed = c.start_seeds(0)
                        End Select
                    Case "-o"
                        overwrite = True
                    Case "-h"
                        ShowHelp()
                        Exit Sub
                    Case Else
                        If Not arg.StartsWith("-") Then
                            If inputfile = "" Then
                                inputfile = arg
                            Else
                                outputfile = arg
                            End If
                        Else
                            Console.WriteLine($"Unknown option {arg}")
                            ShowHelp()
                            Exit Sub
                        End If
                End Select
            Next

            If Not IO.File.Exists(inputfile) Then
                Console.WriteLine($"Inputfile not found.")
                Exit Sub
            End If

            If IO.File.Exists(outputfile) And Not overwrite Then
                Console.WriteLine($"Outputfile already exists, use -o option to overwrite.")
                Exit Sub
            End If

            Dim outData As Byte() = Nothing


            If forceEncode Then
                outData = c.EncodeFile(inputfile, custom_seed)
            End If
            If forceDecode Then
                outData = c.DecodeFile(inputfile, custom_seed)
            End If
            If auto Then
                outData = c.AutoDecodeFile(inputfile, custom_seed)
            End If

            If outData IsNot Nothing AndAlso outData.Length > 0 Then
                If IO.File.Exists(outputfile) And overwrite Then IO.File.Delete(outputfile)

                IO.File.WriteAllBytes(outputfile, outData)
            End If

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub ShowHelp()
        Dim sb As New StringBuilder

        sb.AppendLine("CopieScr.Decoder v1.0")
        sb.AppendLine("VW RNS850 & Audi MMI Copie_scr.sh (en/de)coder")
        sb.AppendLine("Command: copiescr.decoder -[OPTIONS] ""<inputfile>"" ""<outputfile>""")
        sb.AppendLine("All options must start with a `-` minus sign")
        sb.AppendLine($"Option{vbTab}{vbTab}Description")
        sb.AppendLine($"a{vbTab}{vbTab}Try to guess the seed for decoding, this is the default behaviour.")
        sb.AppendLine($"s<seed>{vbTab}{vbTab}Encode or decode with the supplied <seed>. The <seed> has to be in HEX format. (eg. EBAEBA)")
        sb.AppendLine($"e<id>{vbTab}{vbTab}Encode with specific seed. id 0 = 1BE3AC, id 1 = EBAEBA, id 2 = seed from -s option")
        sb.AppendLine($"d<id>{vbTab}{vbTab}Decode with specific seed. id 0 = 1BE3AC, id 1 = EBAEBA, id 2 = seed from -s option")
        sb.AppendLine($"o{vbTab}{vbTab}Overwrite outputfile if it already exists.")
        sb.AppendLine($"h{vbTab}{vbTab}This help text")

        Console.WriteLine(sb.ToString)
    End Sub
End Module
