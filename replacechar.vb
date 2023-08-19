Imports System

Module Program
    Sub Main(args As String())

        Dim sent, sent2 As String
        Dim chr, chr2, thischr As Char
        Dim i As Integer
        sent = ""
        sent2 = ""
        chr = ""
        chr2 = ""
        thischr = ""
        i = 0
        'sent is the user's string, sent2 is the modified string
        'chr is the character to be replaced, chr2 is the character it will be replaced with

        Console.Write("Enter your sentence: ")
        sent = Console.ReadLine
        Console.Write("Enter the character you wish to replace: ")
        chr = Console.ReadLine
        Console.Write("Enter the character you wish to replace the previous character with: ")
        chr2 = Console.ReadLine

        For i = 1 To Len(sent)
            thischr = Mid(sent, i, 1)
            If thischr = chr Then
                sent2 = sent2 & chr2
            Else
                sent2 = sent2 & thischr
            End If
        Next

        Console.WriteLine(sent2)

        Console.ReadKey()

    End Sub
End Module
