Imports System

Module Program
    Sub Main(args As String())

        Dim str, newstr As String
        Dim a, b As Integer
        Console.Write("Enter your string: ")
        str = Console.ReadLine

        a = InStr(str, "not")
        b = InStr(a + 1, str, "bad")
        newstr = Left(str, (a - 1)) & "good" & Right(str, (Len(str) - b - 2))
        Console.Write(newstr)
        Console.ReadKey()


    End Sub
End Module
