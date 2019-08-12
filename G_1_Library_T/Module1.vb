Imports System.IO
Module Module1

    Public Structure custInfo 'for customer form
        Public ID As String '10
        Public Name As String '25
        Public Telephone As String '11
    End Structure


    Public Structure Book
        Public ISBN As String '10
        Public title As String '30
        Public price As String '5
    End Structure
    Public BookArray(100) As Book
    Public CustArray(100) As custInfo
    Const Max = 10
    Public count As Integer

    Sub LoadBooksFromFile(ByVal filename As String)
        'read from file "Library.txt" in the same sequence and the writing
        ' and store each record in the array BookArray()
        Dim AllBooks() As String = File.ReadAllLines(Dir$(filename))
        count = 0 'keeps track of how many records are read from file
        For I = 1 To UBound(AllBooks)
            BookArray(I).ISBN = Trim(Mid(AllBooks(I), 1, 9))
            '### read the other parts of the string into the structure:
            BookArray(I).title = Trim(Mid(AllBooks(I), 10, 29))
            BookArray(I).price = Trim(Mid(AllBooks(I), 30, 4))
            '### increment count by 1 to keep track of number of lines in file:
            count = count + 1

        Next I


    End Sub
    Sub createNewFile()
        If Dir$("Library.txt") = "" Then
            Dim sw As New StreamWriter(Application.StartupPath & "\Library.txt", True)    'This makes sure there is actually a database to enter/read data. If not, it creates a new blank one.
            sw.WriteLine("  Cheese                        and pickle pie                                                                                                       ")
            sw.Close()
            MsgBox("A new database has been created", vbExclamation, "Warning!")
        End If
    End Sub
    Sub viewAllBooks(ByVal myListbox As ListBox)
        myListbox.Items.Clear()
        For x = 1 To count - 1 ' count represents how many records were read from file
            myListbox.Items.Add(BookArray(x).title)
        Next
    End Sub

    Sub writeToLibraryFile(ByVal isbn As String, ByVal title As String, ByVal price As String)
        Dim BookData As New Book
        Dim sw As New System.IO.StreamWriter(Dir$("Library.txt"), True)
        BookData.ISBN = LSet(isbn, 10)
        '### Filling the other fields of the 'structure with data.
        BookData.title = LSet(title, 30)
        BookData.price = LSet(price, 5)


        sw.WriteLine(BookData.ISBN & BookData.title & BookData.price)
        sw.Close()
        '###display using a message box that the record has been saved successfully
        MsgBox("Record saved successfully")


    End Sub

    Function generateID() As Integer
        '**********************************************************************************
        'Load the customer file and loop through the array of records to 
        'find the highest customer ID so
        'we can generate the new unique customer ID.
        'At this point the assumption is that the array is not sorted.

        Dim CustomerData() As String = File.ReadAllLines(Dir$("Customers.txt"))

        Dim highestValue As Integer = (Trim(Mid(CustomerData(1), 1, 9)))
        For I = 1 To UBound(CustomerData)

            If highestValue < (Trim(Mid(CustomerData(I), 1, 9))) Then
                highestValue = (Trim(Mid(CustomerData(I), 1, 9)))
            End If

        Next I

        Return Convert.ToInt16(highestValue) + 1
    End Function

    Sub LoadCustsFromFile(ByVal filename As String)
        'read from file "Customers.txt" in the same sequence and the writing
        ' and store each record in the array CustArray()
        Dim AllCusts() As String = File.ReadAllLines(Dir$(filename))
        count = 0 'keeps track of how many records are read from file
        For I = 1 To UBound(AllCusts)
            CustArray(I).ID = Trim(Mid(AllCusts(I), 1, 9))
            '### read the other parts of the string into the structure:
            CustArray(I).Name = Trim(Mid(AllCusts(I), 10, 21))
            CustArray(I).Telephone = Trim(Mid(AllCusts(I), 22, 40))
            '### increment count by 1 to keep track of number of lines in file:
            count = count + 1

        Next I

    End Sub
    Sub viewCust(ByVal myListbox As ListBox)
        myListbox.Items.Clear()
        For x = 1 To count ' count represents how many records were read from file
            myListbox.Items.Add(CustArray(x).Name)
        Next
    End Sub
End Module
