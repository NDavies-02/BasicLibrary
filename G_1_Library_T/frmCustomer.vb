Imports System.IO
Public Class frmCustomer

    Private Sub frmCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Dir$("Customers.txt") = "" Then
            Dim sw As New StreamWriter(Application.StartupPath & "\Customers.txt", True)    'This makes sure there is actually a database to enter/read data. If not, it creates a new blank one.
            sw.WriteLine(" Line1                                                                                                                                                                                                                                                                                                                                   ")
            sw.Close()
            MsgBox("A new Customer file has been created", vbExclamation, "Warning!")
            lblID.Text = 1 ' initialise the ID to 1 when new file is created
        Else
            lblID.Text = generateID() 'go through file and find next available number
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim CustomerData As New custInfo ' record to store data from text boxes and label into
        Dim sw As New System.IO.StreamWriter(Dir$("Customers.txt"), True)
        CustomerData.ID = LSet(lblID.Text, 10)
        CustomerData.Name = LSet(txtName.Text, 25)
        CustomerData.Telephone = LSet(txttel.Text, 11)     'Filling the structure with data.
        sw.WriteLine(CustomerData.ID & CustomerData.Name & CustomerData.Telephone)
        sw.Close()

        MsgBox("Saved")

        lblID.Text = generateID()
        txtName.Text = ""
        txttel.Text = ""
        txtName.Focus()
    End Sub

  
End Class