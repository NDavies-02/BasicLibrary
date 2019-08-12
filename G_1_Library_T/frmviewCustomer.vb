Public Class frmviewCustomer
    Private Sub LoadCust_Click(sender As Object, e As EventArgs) Handles LoadCust.Click
        viewCust(CSListBox1)
    End Sub

    Private Sub frmviewCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustsFromFile("Customers.txt")
    End Sub
End Class