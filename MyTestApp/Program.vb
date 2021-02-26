Imports System

Module Program
    Public Function Text_handler(ByVal qstateName As String) As String
        Dim fin_res As String
        Try
            fin_res = qstateName.Split(" ")(1).ToString + ", " + qstateName.Split(" ")(2).ToString
        Catch IOORex As IndexOutOfRangeException
            fin_res = qstateName.Split(" ")(1).ToString
        End Try
        Return (fin_res)
    End Function

    Sub Main()
        Dim qstateName As String = "СХБН Тамбов Жердянка"
        Dim Value As String = Text_handler(qstateName)
        Console.WriteLine(Value)
    End Sub
End Module

