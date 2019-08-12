Imports System.IO

Public Class frmSearchTitle

    Private Sub btnSearchTitle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchTitle.Click
        Dim boolfound As Boolean = False
        Dim AllBooks() As String = File.ReadAllLines(Dir$("Library.txt"))
        Dim I As Integer = 0
        Dim count As Integer = 0 ' counts how many books have been found with the same title
        Do
            Dim temp As String = Trim(Mid(AllBooks(I), 10, 29)) ' between 10 and 30, the title is stored 
            If txttitle.Text = temp Then
                boolfound = True
                '### increment count
                count = count + 1
                ListBox1.Items.Add(temp) 'adds a results as an item in frmPriceRange's listbox

                '### add the array element to the listbox:


            End If

            I += 1
        Loop While I <= UBound(AllBooks)

        If boolfound = False Then
            '### display using a message box an appropriate message:
            MsgBox("No results found for your query.", 0 + 64, "No results")

        Else
            '### display in a message box how many records are found:
            MsgBox(count & " result(s) found for your query", MsgBoxStyle.Information, "Results")
        End If

    End Sub

End Class