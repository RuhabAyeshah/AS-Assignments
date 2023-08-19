Imports System

Module Program
    Sub Main(args As String())
        Dim str, newstr, last As String

        Console.Write("Enter your string: ")
        str = Console.ReadLine

        If Len(str) >= 3 Then
            last = Right(str, 3)
            If last = "ing" Then
                newstr = str & "ly"
            Else
                newstr = str & "ing"
            End If
        Else
            Console.Write(str)
        End If

        Console.Write(newstr)
        Console.ReadKey()

    End Sub
End Module
