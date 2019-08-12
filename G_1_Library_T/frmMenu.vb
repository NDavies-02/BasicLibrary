Imports System.IO
Public Class frmMenu

    Private Sub AllBooksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllBooksToolStripMenuItem.Click
        frmViewBooks.Show()
    End Sub

    Private Sub BookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookToolStripMenuItem.Click
        frmStoreLibrary.Show()
    End Sub

    Private Sub frmMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        createNewFile()
    End Sub

    Private Sub TitleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TitleToolStripMenuItem.Click
        frmSearchTitle.Show()
    End Sub

    Private Sub ISBNToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ISBNToolStripMenuItem.Click
        frmISBNSearch.Show()
    End Sub

    Private Sub LibraryMemberToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LibraryMemberToolStripMenuItem.Click
        frmCustomer.Show()
    End Sub

    Private Sub AllCustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllCustomersToolStripMenuItem.Click
        frmviewCustomer.Show()
    End Sub

    Private Sub CustomerByIDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerByIDToolStripMenuItem.Click
        frmCustIDSearch.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

    End Sub
End Class
