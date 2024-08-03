Module Module1

    Sub Main()

        Dim year As Integer
        Dim resultado As Integer
        year = 2026

        resultado = year Mod 2

        If year Mod 2 = 0 And year = 2024 Then
            Console.WriteLine("El año es par y es 2024")
        ElseIf year Mod 2 = 0 Then
            Console.WriteLine("El año es par")
        Else
            Console.WriteLine("El año es impar")
        End If

        Dim contador As Integer = 0

        While contador < 5
            Console.WriteLine("El contador es: " + CStr(contador))
            contador = contador + 1
            'contador += 1
        End While

        Console.ReadLine()

    End Sub

End Module
