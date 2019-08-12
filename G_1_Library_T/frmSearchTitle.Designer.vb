<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchTitle
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
        Me.btnSearchTitle = New System.Windows.Forms.Button()
        Me.txttitle = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnSearchTitle
        '
        Me.btnSearchTitle.Location = New System.Drawing.Point(17, 73)
        Me.btnSearchTitle.Name = "btnSearchTitle"
        Me.btnSearchTitle.Size = New System.Drawing.Size(106, 23)
        Me.btnSearchTitle.TabIndex = 6
        Me.btnSearchTitle.Text = "Search for book title"
        Me.btnSearchTitle.UseVisualStyleBackColor = True
        '
        'txttitle
        '
        Me.txttitle.Location = New System.Drawing.Point(11, 40)
        Me.txttitle.Name = "txttitle"
        Me.txttitle.Size = New System.Drawing.Size(113, 20)
        Me.txttitle.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Enter Book title"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(11, 112)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(401, 69)
        Me.ListBox1.TabIndex = 13
        '
        'frmSearchTitle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 204)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnSearchTitle)
        Me.Controls.Add(Me.txttitle)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "frmSearchTitle"
        Me.Text = "Search title"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSearchTitle As System.Windows.Forms.Button
    Friend WithEvents txttitle As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
End Class
