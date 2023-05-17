
Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Open("show")
        Catch ex As Exception
            MessageBox.Show("Error Encountered!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub btnAddbook_Click(sender As Object, e As EventArgs) Handles btnAddbook.Click
        txtSearch.Text = ""
        AddRes.Show()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        txtSearch.Text = ""
        AddRes.Show()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim searchValue As Integer
            If Integer.TryParse(txtSearch.Text, searchValue) Then
                MdiCustomers.dgvCustomers.Rows.Clear()
                Open("show")
                btnEdit.Enabled = True
            ElseIf (txtSearch.Text = "") Then
                MessageBox.Show("Please fill the search box!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                MessageBox.Show("Please enter a valid id number!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show("Error Encountered!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtSearch.Text = ""
        btnEdit.Enabled = False
        Open("show")
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            Dim searchValue As Integer
            If Integer.TryParse(txtSearch.Text, searchValue) Then
                MngRes.Show()
            ElseIf (txtSearch.Text = "") Then
                MessageBox.Show("Please fill the search box!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                MessageBox.Show("Please enter a valid id number!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show("Error Encountered!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim searchValue As Integer
            If Integer.TryParse(txtSearch.Text, searchValue) Then
                If (MessageBox.Show("Are you sure you want to permanently delete this data?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes) Then

                End If
            ElseIf (txtSearch.Text = "") Then
                MessageBox.Show("Please fill the search box!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                MessageBox.Show("Please enter a valid id number!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show("Error Encountered!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        If (MessageBox.Show("Are you sure you want to exit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub DEVELOPERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DEVELOPERToolStripMenuItem.Click
        MessageBox.Show("I am Marc Edison D. Suarez", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
