Imports System

Module Program
    Sub Main(args As String())
        Dim str, first, last As String

        Console.Write("Enter your string: ")
        str = Console.ReadLine

        If Len(str) > 2 Then
            first = Left(str, 2)
            last = Right(str, 2)
            str = first & last
            Console.Write(str)
        Else
            Console.Write(str)
        End If
        Console.ReadKey()
    End Sub
End Module
