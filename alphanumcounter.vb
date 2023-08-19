Imports System

Module Program
    Sub Main(args As String())

        Dim sent, chr, thischr, alph, num As String
        Dim i, a, b, chrcount, alphcount, numcount, schrcount As Integer
        'a and b are to check if character is a alphabet or number respectively 
        'schrcount is the number of special characters, including space
        alph = "abcdefghijklmnopqrstuvwxyz"
        num = "1234567890"
        thischr = ""
        chrcount = 0
        numcount = 0
        schrcount = 0

        Console.Write("Enter your word or sentence: ")
        sent = Console.ReadLine
        Console.Write("Enter the character you would like to count: ")
        chr = Console.ReadLine

        sent = LCase(sent)
        For i = 1 To Len(sent)
            thischr = Mid(sent, i, 1)
            a = InStr(alph, thischr)
            b = InStr(num, thischr)


            If thischr = chr Then
                chrcount = chrcount + 1
            ElseIf a > 0 Then
                alphcount = alphcount + 1
            ElseIf b > 0 Then
                numcount = numcount + 1
            Else
                schrcount = schrcount + 1
            End If
        Next

        Console.WriteLine("The number of " & chr & " is: " & chrcount)
        Console.WriteLine("The number of alphabets excluding " & chr & " is: " & alphcount)
        Console.WriteLine("The number of numbers is: " & numcount)
        Console.WriteLine("The number of special characters including space is: " & schrcount)

        console.readkey()



    End Sub
End Module
