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
        Me.components = New System.ComponentModel.Container()
        Me.lblBaseItem = New System.Windows.Forms.Label()
        Me.lblCustomisation = New System.Windows.Forms.Label()
        Me.cmbaseitem = New System.Windows.Forms.ComboBox()
        Me.cmbcustoms = New System.Windows.Forms.ComboBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.lblCharacters = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerdtbDataSet = New ProjectIS1111.customerdtbDataSet()
        Me.TblBaseItemTableAdapter = New ProjectIS1111.customerdtbDataSetTableAdapters.tblBaseItemTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerdtbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblBaseItem
        '
        Me.lblBaseItem.AutoSize = True
        Me.lblBaseItem.Location = New System.Drawing.Point(40, 35)
        Me.lblBaseItem.Name = "lblBaseItem"
        Me.lblBaseItem.Size = New System.Drawing.Size(57, 13)
        Me.lblBaseItem.TabIndex = 0
        Me.lblBaseItem.Text = "Base Item:"
        '
        'lblCustomisation
        '
        Me.lblCustomisation.AutoSize = True
        Me.lblCustomisation.Location = New System.Drawing.Point(40, 104)
        Me.lblCustomisation.Name = "lblCustomisation"
        Me.lblCustomisation.Size = New System.Drawing.Size(75, 13)
        Me.lblCustomisation.TabIndex = 1
        Me.lblCustomisation.Text = "Customisation:"
        '
        'cmbaseitem
        '
        Me.cmbaseitem.FormattingEnabled = True
        Me.cmbaseitem.Location = New System.Drawing.Point(43, 53)
        Me.cmbaseitem.Name = "cmbaseitem"
        Me.cmbaseitem.Size = New System.Drawing.Size(121, 21)
        Me.cmbaseitem.TabIndex = 3
        '
        'cmbcustoms
        '
        Me.cmbcustoms.FormattingEnabled = True
        Me.cmbcustoms.Location = New System.Drawing.Point(43, 120)
        Me.cmbcustoms.Name = "cmbcustoms"
        Me.cmbcustoms.Size = New System.Drawing.Size(121, 21)
        Me.cmbcustoms.TabIndex = 4
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(687, 394)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 5
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'lblCharacters
        '
        Me.lblCharacters.AutoSize = True
        Me.lblCharacters.Location = New System.Drawing.Point(43, 171)
        Me.lblCharacters.Name = "lblCharacters"
        Me.lblCharacters.Size = New System.Drawing.Size(85, 13)
        Me.lblCharacters.TabIndex = 6
        Me.lblCharacters.Text = "Extra Characters"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(22, 190)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(43, 187)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(121, 20)
        Me.TextBox1.TabIndex = 8
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "tblBaseItem"
        Me.BindingSource1.DataSource = Me.CustomerdtbDataSet
        '
        'CustomerdtbDataSet
        '
        Me.CustomerdtbDataSet.DataSetName = "customerdtbDataSet"
        Me.CustomerdtbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblBaseItemTableAdapter
        '
        Me.TblBaseItemTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbcustoms)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.lblBaseItem)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.lblCustomisation)
        Me.GroupBox1.Controls.Add(Me.lblCharacters)
        Me.GroupBox1.Controls.Add(Me.cmbaseitem)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(195, 244)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'frmCustomisationPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnNext)
        Me.Name = "frmCustomisationPage"
        Me.Text = "Customisation"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerdtbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblBaseItem As Label
    Friend WithEvents lblCustomisation As Label
    Friend WithEvents cmbaseitem As ComboBox
    Friend WithEvents cmbcustoms As ComboBox
    Friend WithEvents btnNext As Button
    Friend WithEvents lblCharacters As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents CustomerdtbDataSet As customerdtbDataSet
    Friend WithEvents TblBaseItemTableAdapter As customerdtbDataSetTableAdapters.tblBaseItemTableAdapter
    Friend WithEvents GroupBox1 As GroupBox
End Class
