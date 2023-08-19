Imports System

Module Program
    Sub Main(args As String())
        Dim num, newnum, thous, thisnum As String
        Console.Write("Enter your number: ")
        num = Console.ReadLine

        While num < 0 And num > 999999
            Console.Write("Out of range, enter another number: ")
            num = Console.ReadLine
        End While

        thous = Right(num, 3)
            For i = 1 To (Len(num) - Len(thous))
                thisnum = Mid(num, i, 1)
                newnum = newnum & thisnum
            Next


            newnum = newnum & "," & thous
        Console.Write(newnum)
    End Sub
End Module
