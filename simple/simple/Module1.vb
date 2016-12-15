Module Module1
    Dim ar As Collection = New Collection
    Sub Main()
        ar.Add(2)
        For i = 3 To 100000 step 2
            For j = 1 To ar.Count \ 2 + 1
                If i \ ar(j) = i / ar(j) Then
                    GoTo er
                End If
            Next
            Console.Write(i.ToString + ", ")
            ar.Add(i)
er:
        Next
        Console.ReadLine()
    End Sub
End Module
