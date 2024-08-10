Module Module1

    Sub Main()
        'while
        Dim numeroBase As Integer
        Console.WriteLine("Ingrese un valor:")
        'numeroBase = CInt(Console.ReadLine())
        numeroBase = 5

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

        Console.WriteLine("Ejemplo de For")
        For indice As Integer = 0 To 4
            Console.WriteLine("El contador es: " + CStr(indice))
        Next


        'Programa para mostrar los numeros impares contenidos entre 2 y el valor ingresado
        Console.WriteLine("Ingrese un valor para calcular los primos")
        Dim numBase As Integer
        numBase = CInt(Console.ReadLine())

        '7
        For numTemporal As Integer = 2 To numBase - 1

            Dim contadorExatos = 0

            For index As Integer = 1 To numTemporal
                If numTemporal Mod index = 0 Then
                    contadorExatos = contadorExatos + 1
                    'contadorExatos += 1
                End If
            Next

            If contadorExatos = 2 Then
                Console.WriteLine(numTemporal)
            End If

        Next

        Console.ReadLine()
    End Sub

End Module
