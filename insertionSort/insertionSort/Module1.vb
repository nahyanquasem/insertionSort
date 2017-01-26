Module Module1

    Sub Main()

        Dim list() As Integer = {23, 19, 17, 13, 11, 7, 5, 3, 2}

        Dim i, j, key As Integer

        i = 0
        j = 1

        For j = 1 To 8
            key = list(j)

            i = j - 1

            While i >= 0
                If list(i) > key Then
                    list(i + 1) = list(i)
                    i = i - 1
                End If

            End While

            list(i + 1) = key

        Next

        For i = 1 To 8
            Console.Write(list(i) & " ")
        Next



    End Sub

End Module
