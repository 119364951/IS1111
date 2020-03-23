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
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.lblCharacters = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerdtbDataSet = New ProjectIS1111.customerdtbDataSet()
        Me.TblBaseItemTableAdapter = New ProjectIS1111.customerdtbDataSetTableAdapters.tblBaseItemTableAdapter()
        Me.grpSelection = New System.Windows.Forms.GroupBox()
        Me.grpPayment = New System.Windows.Forms.GroupBox()
        Me.lblExpDate = New System.Windows.Forms.Label()
        Me.lblSecNum = New System.Windows.Forms.Label()
        Me.rdoDebit = New System.Windows.Forms.RadioButton()
        Me.rdoCredit = New System.Windows.Forms.RadioButton()
        Me.mtbExDate = New System.Windows.Forms.MaskedTextBox()
        Me.mtbNumber = New System.Windows.Forms.MaskedTextBox()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerdtbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSelection.SuspendLayout()
        Me.grpPayment.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblBaseItem
        '
        Me.lblBaseItem.AutoSize = True
        Me.lblBaseItem.Location = New System.Drawing.Point(45, 33)
        Me.lblBaseItem.Name = "lblBaseItem"
        Me.lblBaseItem.Size = New System.Drawing.Size(57, 13)
        Me.lblBaseItem.TabIndex = 0
        Me.lblBaseItem.Text = "Base Item:"
        '
        'lblCustomisation
        '
        Me.lblCustomisation.AutoSize = True
        Me.lblCustomisation.Location = New System.Drawing.Point(45, 102)
        Me.lblCustomisation.Name = "lblCustomisation"
        Me.lblCustomisation.Size = New System.Drawing.Size(75, 13)
        Me.lblCustomisation.TabIndex = 1
        Me.lblCustomisation.Text = "Customisation:"
        '
        'cmbaseitem
        '
        Me.cmbaseitem.FormattingEnabled = True
        Me.cmbaseitem.Location = New System.Drawing.Point(48, 51)
        Me.cmbaseitem.Name = "cmbaseitem"
        Me.cmbaseitem.Size = New System.Drawing.Size(121, 21)
        Me.cmbaseitem.TabIndex = 3
        '
        'cmbcustoms
        '
        Me.cmbcustoms.FormattingEnabled = True
        Me.cmbcustoms.Location = New System.Drawing.Point(48, 118)
        Me.cmbcustoms.Name = "cmbcustoms"
        Me.cmbcustoms.Size = New System.Drawing.Size(121, 21)
        Me.cmbcustoms.TabIndex = 4
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(451, 352)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 5
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'lblCharacters
        '
        Me.lblCharacters.AutoSize = True
        Me.lblCharacters.Location = New System.Drawing.Point(48, 169)
        Me.lblCharacters.Name = "lblCharacters"
        Me.lblCharacters.Size = New System.Drawing.Size(85, 13)
        Me.lblCharacters.TabIndex = 6
        Me.lblCharacters.Text = "Extra Characters"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(27, 188)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(48, 185)
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
        'grpSelection
        '
        Me.grpSelection.Controls.Add(Me.cmbcustoms)
        Me.grpSelection.Controls.Add(Me.TextBox1)
        Me.grpSelection.Controls.Add(Me.lblBaseItem)
        Me.grpSelection.Controls.Add(Me.CheckBox1)
        Me.grpSelection.Controls.Add(Me.lblCustomisation)
        Me.grpSelection.Controls.Add(Me.lblCharacters)
        Me.grpSelection.Controls.Add(Me.cmbaseitem)
        Me.grpSelection.Location = New System.Drawing.Point(28, 22)
        Me.grpSelection.Name = "grpSelection"
        Me.grpSelection.Size = New System.Drawing.Size(206, 244)
        Me.grpSelection.TabIndex = 9
        Me.grpSelection.TabStop = False
        Me.grpSelection.Text = "Selection"
        '
        'grpPayment
        '
        Me.grpPayment.Controls.Add(Me.mtbNumber)
        Me.grpPayment.Controls.Add(Me.mtbExDate)
        Me.grpPayment.Controls.Add(Me.lblExpDate)
        Me.grpPayment.Controls.Add(Me.lblSecNum)
        Me.grpPayment.Controls.Add(Me.rdoDebit)
        Me.grpPayment.Controls.Add(Me.rdoCredit)
        Me.grpPayment.Location = New System.Drawing.Point(28, 275)
        Me.grpPayment.Name = "grpPayment"
        Me.grpPayment.Size = New System.Drawing.Size(394, 100)
        Me.grpPayment.TabIndex = 10
        Me.grpPayment.TabStop = False
        Me.grpPayment.Text = "Payment Option:"
        '
        'lblExpDate
        '
        Me.lblExpDate.AutoSize = True
        Me.lblExpDate.Location = New System.Drawing.Point(194, 60)
        Me.lblExpDate.Name = "lblExpDate"
        Me.lblExpDate.Size = New System.Drawing.Size(64, 13)
        Me.lblExpDate.TabIndex = 4
        Me.lblExpDate.Text = "Expiry Date:"
        '
        'lblSecNum
        '
        Me.lblSecNum.AutoSize = True
        Me.lblSecNum.Location = New System.Drawing.Point(63, 60)
        Me.lblSecNum.Name = "lblSecNum"
        Me.lblSecNum.Size = New System.Drawing.Size(88, 13)
        Me.lblSecNum.TabIndex = 2
        Me.lblSecNum.Text = "Security Number:"
        '
        'rdoDebit
        '
        Me.rdoDebit.AutoSize = True
        Me.rdoDebit.Location = New System.Drawing.Point(197, 31)
        Me.rdoDebit.Name = "rdoDebit"
        Me.rdoDebit.Size = New System.Drawing.Size(75, 17)
        Me.rdoDebit.TabIndex = 1
        Me.rdoDebit.TabStop = True
        Me.rdoDebit.Text = "Debit Card"
        Me.rdoDebit.UseVisualStyleBackColor = True
        '
        'rdoCredit
        '
        Me.rdoCredit.AutoSize = True
        Me.rdoCredit.Location = New System.Drawing.Point(66, 31)
        Me.rdoCredit.Name = "rdoCredit"
        Me.rdoCredit.Size = New System.Drawing.Size(77, 17)
        Me.rdoCredit.TabIndex = 0
        Me.rdoCredit.TabStop = True
        Me.rdoCredit.Text = "Credit Card"
        Me.rdoCredit.UseVisualStyleBackColor = True
        '
        'mtbExDate
        '
        Me.mtbExDate.Location = New System.Drawing.Point(264, 57)
        Me.mtbExDate.Mask = "00/00/0000"
        Me.mtbExDate.Name = "mtbExDate"
        Me.mtbExDate.Size = New System.Drawing.Size(68, 20)
        Me.mtbExDate.TabIndex = 5
        Me.mtbExDate.ValidatingType = GetType(Date)
        '
        'mtbNumber
        '
        Me.mtbNumber.Location = New System.Drawing.Point(157, 57)
        Me.mtbNumber.Mask = "000"
        Me.mtbNumber.Name = "mtbNumber"
        Me.mtbNumber.Size = New System.Drawing.Size(25, 20)
        Me.mtbNumber.TabIndex = 6
        Me.mtbNumber.ValidatingType = GetType(Integer)
        '
        'frmCustomisationPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 395)
        Me.Controls.Add(Me.grpPayment)
        Me.Controls.Add(Me.grpSelection)
        Me.Controls.Add(Me.btnPrint)
        Me.Name = "frmCustomisationPage"
        Me.Text = "Customisation"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerdtbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSelection.ResumeLayout(False)
        Me.grpSelection.PerformLayout()
        Me.grpPayment.ResumeLayout(False)
        Me.grpPayment.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblBaseItem As Label
    Friend WithEvents lblCustomisation As Label
    Friend WithEvents cmbaseitem As ComboBox
    Friend WithEvents cmbcustoms As ComboBox
    Friend WithEvents btnPrint As Button
    Friend WithEvents lblCharacters As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents CustomerdtbDataSet As customerdtbDataSet
    Friend WithEvents TblBaseItemTableAdapter As customerdtbDataSetTableAdapters.tblBaseItemTableAdapter
    Friend WithEvents grpSelection As GroupBox
    Friend WithEvents grpPayment As GroupBox
    Friend WithEvents rdoDebit As RadioButton
    Friend WithEvents rdoCredit As RadioButton
    Friend WithEvents lblExpDate As Label
    Friend WithEvents lblSecNum As Label
    Friend WithEvents mtbNumber As MaskedTextBox
    Friend WithEvents mtbExDate As MaskedTextBox
End Class
