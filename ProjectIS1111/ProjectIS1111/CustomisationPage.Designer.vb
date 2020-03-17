<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomisationPage
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbaseitem = New System.Windows.Forms.ComboBox()
        Me.cmbcustoms = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(220, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Base Item:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(387, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Customisation:"
        '
        'cmbaseitem
        '
        Me.cmbaseitem.FormattingEnabled = True
        Me.cmbaseitem.Location = New System.Drawing.Point(223, 127)
        Me.cmbaseitem.Name = "cmbaseitem"
        Me.cmbaseitem.Size = New System.Drawing.Size(121, 21)
        Me.cmbaseitem.TabIndex = 3
        '
        'cmbcustoms
        '
        Me.cmbcustoms.FormattingEnabled = True
        Me.cmbcustoms.Location = New System.Drawing.Point(390, 127)
        Me.cmbcustoms.Name = "cmbcustoms"
        Me.cmbcustoms.Size = New System.Drawing.Size(121, 21)
        Me.cmbcustoms.TabIndex = 4
        '
        'frmCustomisationPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmbcustoms)
        Me.Controls.Add(Me.cmbaseitem)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCustomisationPage"
        Me.Text = "Customise"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbaseitem As ComboBox
    Friend WithEvents cmbcustoms As ComboBox
End Class
