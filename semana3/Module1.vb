Module Module1

    Sub Main()
        'while
        Dim numeroBase As Integer
        Console.WriteLine("Ingrese un valor:")
        numeroBase = CInt(Console.ReadLine())

        Dim limite As Integer
        limite = numeroBase + 5

        While numeroBase < limite
            numeroBase = numeroBase + 1

            If numeroBase Mod 2 = 0 Then
                Console.WriteLine(CStr(numeroBase) + " par")
            Else
                Console.WriteLine(numeroBase & " impar")
            End If

            'numeroBase += 1
        End While

        Console.ReadLine()
    End Sub

End Module
