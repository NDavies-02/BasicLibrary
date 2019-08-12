Imports System.IO
Public Class frmISBNSearch

    Private Sub btnSearchTitle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchTitle.Click
        Dim boolfound As Boolean = False
        Dim AllBooks() As String = File.ReadAllLines(Dir$("Library.txt"))
        Dim I As Integer = 0
        Dim count As Integer = 0 ' counts how many books have been found with the same title
        Do
            Dim temp As String = Trim(Mid(AllBooks(I), 1, 9))
            Dim temp2 As String = Trim(Mid(AllBooks(I), 10, 29))
            Dim temp3 As String = Trim(Mid(AllBooks(I), 40, 4))
            If txtISBN.Text = temp Then
                boolfound = True
                '### increment count
                lblISBN.Text = temp 'in textboxes - NOTE: textbox is set to read only to prevent editing by user at runtime
                lblTitle.Text = temp2
                lblPrice.Text = temp3
                count = count + 1



            End If

            I += 1
        Loop While I <= UBound(AllBooks)

        If boolfound = False Then
            '### display using a message box an appropriate message:
            MsgBox("No results found for your query.", 0 + 64, "No results")

        Else
            '### display in a message box how many records are found:
            MsgBox("Result found for your query", MsgBoxStyle.Exclamation, "Result!")
        End If
    End Sub





End Class