<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustIDSearch
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblISBN = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSearchID = New System.Windows.Forms.Button()
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Enter customer ID"
        '
        'lblPrice
        '
        Me.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPrice.Location = New System.Drawing.Point(121, 173)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(82, 26)
        Me.lblPrice.TabIndex = 25
        '
        'lblTitle
        '
        Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitle.Location = New System.Drawing.Point(121, 147)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(82, 26)
        Me.lblTitle.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(33, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 26)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Phone Number"
        '
        'lblISBN
        '
        Me.lblISBN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblISBN.Location = New System.Drawing.Point(121, 121)
        Me.lblISBN.Name = "lblISBN"
        Me.lblISBN.Size = New System.Drawing.Size(82, 26)
        Me.lblISBN.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(33, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 26)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Name"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(33, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 26)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "ID"
        '
        'btnSearchID
        '
        Me.btnSearchID.Location = New System.Drawing.Point(36, 86)
        Me.btnSearchID.Name = "btnSearchID"
        Me.btnSearchID.Size = New System.Drawing.Size(151, 23)
        Me.btnSearchID.TabIndex = 23
        Me.btnSearchID.Text = "Search for customer"
        Me.btnSearchID.UseVisualStyleBackColor = True
        '
        'txtISBN
        '
        Me.txtISBN.Location = New System.Drawing.Point(30, 53)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.Size = New System.Drawing.Size(157, 20)
        Me.txtISBN.TabIndex = 22
        '
        'frmCustIDSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblISBN)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSearchID)
        Me.Controls.Add(Me.txtISBN)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCustIDSearch"
        Me.Text = "CustIDSearch"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblISBN As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSearchID As Button
    Friend WithEvents txtISBN As TextBox
End Class
