Imports System

Module Program
    Sub Main(args As String())
        Dim str, newstr, first, thischr, a As String
        Dim i As Integer

        Console.Write("Enter your string: ")
        str = Console.ReadLine

        first = Left(str, 1)

        For i = 2 To Len(str)
            thischr = Mid(str, i, 1)

            If thischr <> first Then
                newstr = newstr & thischr
            Else
                newstr = newstr & "*"
            End If
        Next
        Console.Write(first & newstr)
        Console.ReadKey()
    End Sub
End Module
