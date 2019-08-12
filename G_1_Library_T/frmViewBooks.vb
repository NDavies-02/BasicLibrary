Imports System.IO
Public Class frmViewBooks
    Private Sub frmViewBooks_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'procedure that reads all data from file into an array of records:
        LoadBooksFromFile("Library.txt")
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        '### call the procedure to view all the books (see Module1)
        '### check what value needs to be passed in
        viewAllBooks(ListBox1)
    End Sub

End Class