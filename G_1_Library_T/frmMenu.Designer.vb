<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllCustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibraryMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TitleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ISBNToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerByIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewToolStripMenuItem, Me.StoreToolStripMenuItem, Me.SearchToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(427, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllBooksToolStripMenuItem, Me.AllCustomersToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'AllBooksToolStripMenuItem
        '
        Me.AllBooksToolStripMenuItem.Name = "AllBooksToolStripMenuItem"
        Me.AllBooksToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.AllBooksToolStripMenuItem.Text = "All Books"
        '
        'AllCustomersToolStripMenuItem
        '
        Me.AllCustomersToolStripMenuItem.Name = "AllCustomersToolStripMenuItem"
        Me.AllCustomersToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.AllCustomersToolStripMenuItem.Text = "All Customers"
        '
        'StoreToolStripMenuItem
        '
        Me.StoreToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LibraryMemberToolStripMenuItem, Me.BookToolStripMenuItem, Me.LoanToolStripMenuItem})
        Me.StoreToolStripMenuItem.Name = "StoreToolStripMenuItem"
        Me.StoreToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.StoreToolStripMenuItem.Text = "Store"
        '
        'LibraryMemberToolStripMenuItem
        '
        Me.LibraryMemberToolStripMenuItem.Name = "LibraryMemberToolStripMenuItem"
        Me.LibraryMemberToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.LibraryMemberToolStripMenuItem.Text = "Library Member"
        '
        'BookToolStripMenuItem
        '
        Me.BookToolStripMenuItem.Name = "BookToolStripMenuItem"
        Me.BookToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.BookToolStripMenuItem.Text = "Book"
        '
        'LoanToolStripMenuItem
        '
        Me.LoanToolStripMenuItem.Name = "LoanToolStripMenuItem"
        Me.LoanToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.LoanToolStripMenuItem.Text = "Loan"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TitleToolStripMenuItem, Me.ISBNToolStripMenuItem, Me.CustomerByIDToolStripMenuItem})
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'TitleToolStripMenuItem
        '
        Me.TitleToolStripMenuItem.Name = "TitleToolStripMenuItem"
        Me.TitleToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.TitleToolStripMenuItem.Text = "Title"
        '
        'ISBNToolStripMenuItem
        '
        Me.ISBNToolStripMenuItem.Name = "ISBNToolStripMenuItem"
        Me.ISBNToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.ISBNToolStripMenuItem.Text = "ISBN"
        '
        'CustomerByIDToolStripMenuItem
        '
        Me.CustomerByIDToolStripMenuItem.Name = "CustomerByIDToolStripMenuItem"
        Me.CustomerByIDToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.CustomerByIDToolStripMenuItem.Text = "Customer by ID"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.G_1_Library.My.Resources.Resources.download
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(427, 374)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllBooksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StoreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LibraryMemberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TitleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ISBNToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllCustomersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerByIDToolStripMenuItem As ToolStripMenuItem
End Class
