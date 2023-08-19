Imports System

Module Program
    Sub Main(args As String())

        Dim sent, thischr As String
        Dim i, numofv, numofcons, v, c As Integer
        Const vowel As String = "aeiou"
        Const cons As String = "bcdfghjklmnpqrstvwxyz"

        Console.Write("Enter your sentence: ")
        sent = Console.ReadLine

        sent = LCase(sent)
        For i = 1 To Len(sent)
            thischr = Mid(sent, i, 1)
            v = InStr(vowel, thischr)
            c = InStr(cons, thischr)

            If v > 0 Then
                numofv = numofv + 1
            ElseIf c > 0 Then
                numofcons = numofcons + 1
            End If

        Next

        Console.WriteLine("The number of vowels is: " & numofv)
        Console.Write("The number of consonants is: " & numofcons)

        Console.ReadKey()
    End Sub
End Module
