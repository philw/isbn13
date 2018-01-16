Module Module1

    Sub Main()

        Dim ISBN As String
        Dim Digit As Integer
        Dim Total As Integer

        Console.Write("Enter isbn: ")
        ISBN = Console.ReadLine

        Total = 0
        For i = 0 To ISBN.Length - 1
            Digit = Asc(ISBN(i)) - Asc("0")
            If i Mod 2 = 0 Then
                Total += Digit
            Else
                Total += Digit * 3
            End If
        Next

        Console.WriteLine(Total Mod 10)

        Console.ReadLine()

    End Sub

End Module
