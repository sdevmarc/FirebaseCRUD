Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Public Class AddRes
    Private con As New FirebaseConfig() With
        {
        .AuthSecret = "cIEaCOCD9F2ia3yBULNIBG56x3q09MpCc7ybEw3G",
        .BasePath = "https://hotel-reservation-da681-default-rtdb.asia-southeast1.firebasedatabase.app/"
        }
    Private client As IFirebaseClient

    Sub Connect()
        client = New FireSharp.FirebaseClient(con)
    End Sub
    Private Sub AddRes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Arr(cmbRT)
        Connect()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Main.Show()
        Me.Close()
    End Sub

    Private Sub btnAddBook_Click(sender As Object, e As EventArgs) Handles btnAddBook.Click
        Dim std As New Base() With
            {
            .cust_no = txtCust.Text,
            .lastname = txtLN.Text,
            .firstname = txtFN.Text,
            .contact_no = txtCN.Text,
            .email = txtEmail.Text,
            .room_no = OBJModule.value(cmbRT),
            .roomtype = cmbRT.SelectedItem,
            .check_in = dtpCI.Text,
            .check_out = dtpCO.Text
            }
        Dim setter = client.Set("Reservations/" + txtCust.Text, std)
        MessageBox.Show("The customer has been reserved!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Main.Show()
        Me.Close()
    End Sub


End Class