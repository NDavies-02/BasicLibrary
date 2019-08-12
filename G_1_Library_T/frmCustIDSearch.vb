Imports System.IO
Public Class frmCustIDSearch
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnSearchID_Click(sender As Object, e As EventArgs) Handles btnSearchID.Click
        Dim boolfound As Boolean = False
        Dim AllCusts() As String = File.ReadAllLines(Dir$("Customers.txt"))
        Dim I As Integer = 0
        Dim count As Integer = 0 ' counts how many books have been found with the same title
        Do
            Dim temp As String = Trim(Mid(AllCusts(I), 1, 9))
            Dim temp2 As String = Trim(Mid(AllCusts(I), 10, 21))
            Dim temp3 As String = Trim(Mid(AllCusts(I), 22, 40))
            If txtISBN.Text = temp Then
                boolfound = True
                '### increment count
                lblISBN.Text = temp 'in textboxes - NOTE: textbox is set to read only to prevent editing by user at runtime
                lblTitle.Text = temp2
                lblPrice.Text = temp3
                count = count + 1



            End If

            I += 1
        Loop While I <= UBound(AllCusts)

        If boolfound = False Then
            '### display using a message box an appropriate message:
            MsgBox("No customer found with that ID.", 0 + 64, "Not found...")

        Else
            '### display in a message box how many records are found:
            MsgBox("A customer was found with ID " & txtISBN.Text, MsgBoxStyle.Information, "Found!")
        End If
    End Sub
End Class