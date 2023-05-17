Module OBJModule
    Private val As Integer
    Sub Open(inp As Object)
        If (inp = "show") Then
            Dim frm As New MdiCustomers
            frm.MdiParent = Main
            frm.Show()
        End If
    End Sub

    Sub Arr(inp As Object)
        Dim arr() As String = {"Presidential Suite", "King Room", "Queen Room", "Murphy Room", "Accessible Room / Disabled Room", "Quad Room", "Triple Room", "Double Room", "Single Room", "Smoking Room"}
        inp.Items.AddRange(arr)
        inp.SelectedIndex = 0
    End Sub

    Function value(inp As Object)
        If (inp.SelectedIndex = 0) Then
            val = 2
        ElseIf (inp.SelectedIndex = 1) Then
            val = 4
        ElseIf (inp.SelectedIndex = 2) Then
            val = 6
        ElseIf (inp.SelectedIndex = 3) Then
            val = 8
        ElseIf (inp.SelectedIndex = 4) Then
            val = 10
        ElseIf (inp.SelectedIndex = 5) Then
            val = 12
        ElseIf (inp.SelectedIndex = 6) Then
            val = 14
        ElseIf (inp.SelectedIndex = 7) Then
            val = 16
        ElseIf (inp.SelectedIndex = 8) Then
            val = 18
        ElseIf (inp.SelectedIndex = 9) Then
            val = 20
        End If
        Return val
    End Function
End Module
