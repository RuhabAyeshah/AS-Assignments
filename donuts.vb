Imports System

Module Program
    Sub Main(args As String())
        Dim numofdo As Integer = 0


        Console.Write("Enter the number of donuts: ")
        numofdo = Console.ReadLine

        If numofdo >= 10 Then
            Console.Write("Number of donuts: MANY ")
        Else
            Console.Write("Number of donuts: " & numofdo)
        End If
        Console.ReadKey()
    End Sub
End Module
