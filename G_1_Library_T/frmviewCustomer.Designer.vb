<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmviewCustomer
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
        Me.CSListBox1 = New System.Windows.Forms.ListBox()
        Me.LoadCust = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CSListBox1
        '
        Me.CSListBox1.FormattingEnabled = True
        Me.CSListBox1.Location = New System.Drawing.Point(41, 32)
        Me.CSListBox1.Name = "CSListBox1"
        Me.CSListBox1.Size = New System.Drawing.Size(206, 173)
        Me.CSListBox1.TabIndex = 0
        '
        'LoadCust
        '
        Me.LoadCust.Location = New System.Drawing.Point(77, 221)
        Me.LoadCust.Name = "LoadCust"
        Me.LoadCust.Size = New System.Drawing.Size(142, 23)
        Me.LoadCust.TabIndex = 1
        Me.LoadCust.Text = "Load"
        Me.LoadCust.UseVisualStyleBackColor = True
        '
        'frmviewCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.LoadCust)
        Me.Controls.Add(Me.CSListBox1)
        Me.Name = "frmviewCustomer"
        Me.Text = "ViewCustomer"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CSListBox1 As ListBox
    Friend WithEvents LoadCust As Button
End Class
