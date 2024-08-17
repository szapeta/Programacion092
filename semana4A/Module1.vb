Module Module1

    Sub Main()
        NombreMetodo()
        NombreMetodo2("Oscar")
        NombreMetodo2("Juan")
        NombreMetodo2("Marcelo")
        Console.WriteLine(getPar())

        getParesList()

        Console.ReadLine()
    End Sub

    Sub NombreMetodo()
        Console.WriteLine("Metodo: NombreMetodo")
    End Sub

    Sub NombreMetodo2(nombreAlumno As String)
        Console.WriteLine("Metodo: NombreMetodo2 hecho por " + nombreAlumno)
    End Sub

    Function getPar() As Integer
        Dim objRandom As Random = New Random()

        Dim numero As Integer

        numero = objRandom.Next(1, 10)

        While True

            If numero Mod 2 = 0 Then
                Return numero
            Else
                numero = objRandom.Next(1, 10)

            End If

        End While

    End Function

    Sub getParesList()
        Dim numeroInicial As Integer
        Dim total As Integer

        Console.WriteLine("Ingrese un valor:")
        numeroInicial = CInt(Console.ReadLine())

        Console.WriteLine("Cuantos numeros pares quiere imprimir?")
        total = CInt(Console.ReadLine())

        If numeroInicial Mod 2 <> 0 Then
            numeroInicial += 1
        End If

        For indice As Integer = 1 To total
            Console.WriteLine(numeroInicial)
            numeroInicial = numeroInicial + 2
        Next

    End Sub

End Module
