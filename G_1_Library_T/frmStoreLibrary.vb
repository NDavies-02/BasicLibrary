Public Class frmStoreLibrary

    
    Private Sub frmStoreLibrary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnStore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStore.Click
        '### call the procedure writeToLibraryFile and pass into the procedure the values of textboxes
        writeToLibraryFile(txtISBN.Text, txtTitle.Text, txtPrice.Text)


    End Sub
End Class