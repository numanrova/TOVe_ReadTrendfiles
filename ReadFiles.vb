Sub ReadFiles()
        'Outputfile
        Dim outputfile As String = "C:\Visual Studio\Projects\TOVE_LesTrendFiles\TOVE_LesTrendFiles\output2017.txt"

        'Write header line
        ' One column per year
        My.Computer.FileSystem.WriteAllText(outputfile, "Species;1996;1997;1998;1999;2000;2001;2002;2003;2004;2005;2006;2007;2008;2009;2010;2011;2012;2013;2014;2015;2016;C;B;A;" & vbCrLf, False)

        'Where are the files stored?
        'Dim di As New DirectoryInfo("C:\Visual Studio\Projects\TOVE_LesTrendFiles\TOVE_LesTrendFiles\Export")
        Dim di As New DirectoryInfo("R:\ninadata\databaser\TOV-Taksering\TOV-E_ResTrimMaster\DataCombined_TOV_HFT_1996-2016")

        ' Get a reference to each file in that directory.
        Dim fiArr As FileInfo() = di.GetFiles()

        Dim fri As FileInfo
        'For each file in folder
        For Each fri In fiArr
            Dim stdErr As String = ""
            My.Computer.FileSystem.WriteAllText(outputfile, fri.Name.Replace("_2_1.out", "") & ";1;", True)
            stdErr &= fri.Name.Replace("_2_1.out", "") & "; ;"

            Dim fileReader As System.IO.StreamReader
            fileReader =
            My.Computer.FileSystem.OpenTextFileReader(fri.FullName)
            Dim stringReader As String
            'Loop fram til verdier
            While Not fileReader.EndOfStream
                stringReader = fileReader.ReadLine()
                If stringReader.Contains("Time INDICES") Then
                    fileReader.ReadLine()
                    Exit While
                End If
            End While
            stringReader = fileReader.ReadLine
            'Må legge til en linje for hvert år
            For t As Integer = 0 To 19
                stringReader = fileReader.ReadLine
                While stringReader.Contains("  ")
                    stringReader = stringReader.Replace("  ", " ")
                End While
                Dim values() As String = stringReader.Trim.Split(" ")
                My.Computer.FileSystem.WriteAllText(outputfile, values(3) & ";", True)
                stdErr &= values(2) & ";"
            Next

            While Not fileReader.EndOfStream
                stringReader = fileReader.ReadLine
                'Finn verdi for C
                If stringReader.Contains("OVERALL SLOPE IMPUTED (recommended):") Then
                    My.Computer.FileSystem.WriteAllText(outputfile, stringReader.Replace("OVERALL SLOPE IMPUTED (recommended):", "").Trim & ";", True)
                    Exit While
                End If
            End While
            While Not fileReader.EndOfStream
                stringReader = fileReader.ReadLine
                'Finn verdi for C
                If stringReader.Contains("Additive") Then
                    stringReader = fileReader.ReadLine
                    While stringReader.Contains("  ")
                        stringReader = stringReader.Replace("  ", " ")
                    End While
                    Dim values() As String = stringReader.Trim.Split(" ")

                    My.Computer.FileSystem.WriteAllText(outputfile, values(0) & ";" & values(1) & ";", True)
                End If
            End While

            'Skriv linjeskift
            My.Computer.FileSystem.WriteAllText(outputfile, vbCrLf, True)

            'Skriv ei linje til med stdErr
            My.Computer.FileSystem.WriteAllText(outputfile, stdErr & vbCrLf, True)

        Next fri

        Console.ReadKey()
    End Sub
