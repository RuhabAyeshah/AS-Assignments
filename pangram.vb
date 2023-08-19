Imports System

Module Program
    Sub Main(args As String())
        Dim sent As String
        Dim a, i As Integer
        Dim pangram As Boolean
        Dim thischr As Char
        Const alph As String = "abcdefghijklmnopqrstuvwxyz"
        pangram = True
        sent = ""
        a = 0
        i = 0

        Console.Write("enter your sentence: ")
        sent = Console.ReadLine
        LCase(sent)

        For i = 1 To Len(alph)
            thischr = Mid(alph, i, 1)
            a = InStr(sent, alph)
            If a = 0 And thischr <> " " Then
                pangram = False
            End If
        Next

        If pangram = False Then
            Console.WriteLine("this does not contain all the letters of the alphabet")
        Else
            Console.WriteLine("this contains all the letters of the alphabet")
        End If

        Console.ReadKey()
    End Sub
End Module
