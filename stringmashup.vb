Imports System

Module Program
    Sub Main(args As String())
        Dim str1, str2, chr1, chr2, newstr1, newstr2 As String

        Console.Write("Enter your first string: ")
        str1 = Console.ReadLine
        Console.Write("Enter your second string: ")
        str2 = Console.ReadLine

        chr1 = Left(str1, 2)
        chr2 = Left(str2, 2)

        For i = 3 To Len(str1)
            newstr1 = newstr1 & Mid(str1, i, 1)
        Next
        For i = 3 To Len(str2)
            newstr2 = newstr2 & Mid(str2, i, 1)
        Next

        Console.Write((chr2 & newstr1) & " " & (chr1 & newstr2))
        Console.ReadKey()
    End Sub
End Module
