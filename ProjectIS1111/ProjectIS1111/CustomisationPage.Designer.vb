<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCustomisationPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.grpSelection = New System.Windows.Forms.GroupBox()
        Me.grpCustomCom = New System.Windows.Forms.GroupBox()
        Me.grpText = New System.Windows.Forms.GroupBox()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.lblAddChar = New System.Windows.Forms.Label()
        Me.lblBaseChar = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtText = New System.Windows.Forms.TextBox()
        Me.chkLaces = New System.Windows.Forms.CheckBox()
        Me.chkHeelBackCounter = New System.Windows.Forms.CheckBox()
        Me.chkHeelTab = New System.Windows.Forms.CheckBox()
        Me.lblLaces = New System.Windows.Forms.Label()
        Me.lblHeelBackCouter = New System.Windows.Forms.Label()
        Me.chkEyestay = New System.Windows.Forms.CheckBox()
        Me.chkVamp = New System.Windows.Forms.CheckBox()
        Me.chkQuarter = New System.Windows.Forms.CheckBox()
        Me.lblHeelTab = New System.Windows.Forms.Label()
        Me.lblEyestay = New System.Windows.Forms.Label()
        Me.lblVamp = New System.Windows.Forms.Label()
        Me.lblQuarter = New System.Windows.Forms.Label()
        Me.grpBaseItem = New System.Windows.Forms.GroupBox()
        Me.mtbQuantity = New System.Windows.Forms.MaskedTextBox()
        Me.frmQuantity = New System.Windows.Forms.Label()
        Me.txtSize = New System.Windows.Forms.TextBox()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.rdoRetro = New System.Windows.Forms.RadioButton()
        Me.rdoVintage = New System.Windows.Forms.RadioButton()
        Me.rdoClassic = New System.Windows.Forms.RadioButton()
        Me.lblVintage = New System.Windows.Forms.Label()
        Me.lblRetro = New System.Windows.Forms.Label()
        Me.lblClassic = New System.Windows.Forms.Label()
        Me.grpPayment = New System.Windows.Forms.GroupBox()
        Me.mtbNumber = New System.Windows.Forms.MaskedTextBox()
        Me.mtbExDate = New System.Windows.Forms.MaskedTextBox()
        Me.lblExpDate = New System.Windows.Forms.Label()
        Me.lblSecNum = New System.Windows.Forms.Label()
        Me.rdoDebit = New System.Windows.Forms.RadioButton()
        Me.rdoCredit = New System.Windows.Forms.RadioButton()
        Me.grpCost = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnCustomise = New System.Windows.Forms.Button()
        Me.grpCusDetails = New System.Windows.Forms.GroupBox()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.mtbPhoneNo = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtStreetAdd = New System.Windows.Forms.TextBox()
        Me.lblStreetAdd = New System.Windows.Forms.Label()
        Me.txtForeName = New System.Windows.Forms.TextBox()
        Me.lblFName = New System.Windows.Forms.Label()
        Me.txtOrderID = New System.Windows.Forms.TextBox()
        Me.lblOrderID = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mtbDate = New System.Windows.Forms.MaskedTextBox()
        Me.grpSelection.SuspendLayout()
        Me.grpCustomCom.SuspendLayout()
        Me.grpText.SuspendLayout()
        Me.grpBaseItem.SuspendLayout()
        Me.grpPayment.SuspendLayout()
        Me.grpCost.SuspendLayout()
        Me.grpCusDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(102, 77)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 5
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'grpSelection
        '
        Me.grpSelection.Controls.Add(Me.grpCustomCom)
        Me.grpSelection.Controls.Add(Me.grpBaseItem)
        Me.grpSelection.Location = New System.Drawing.Point(229, 25)
        Me.grpSelection.Name = "grpSelection"
        Me.grpSelection.Size = New System.Drawing.Size(626, 244)
        Me.grpSelection.TabIndex = 9
        Me.grpSelection.TabStop = False
        Me.grpSelection.Text = "Selection"
        '
        'grpCustomCom
        '
        Me.grpCustomCom.Controls.Add(Me.grpText)
        Me.grpCustomCom.Controls.Add(Me.chkLaces)
        Me.grpCustomCom.Controls.Add(Me.chkHeelBackCounter)
        Me.grpCustomCom.Controls.Add(Me.chkHeelTab)
        Me.grpCustomCom.Controls.Add(Me.lblLaces)
        Me.grpCustomCom.Controls.Add(Me.lblHeelBackCouter)
        Me.grpCustomCom.Controls.Add(Me.chkEyestay)
        Me.grpCustomCom.Controls.Add(Me.chkVamp)
        Me.grpCustomCom.Controls.Add(Me.chkQuarter)
        Me.grpCustomCom.Controls.Add(Me.lblHeelTab)
        Me.grpCustomCom.Controls.Add(Me.lblEyestay)
        Me.grpCustomCom.Controls.Add(Me.lblVamp)
        Me.grpCustomCom.Controls.Add(Me.lblQuarter)
        Me.grpCustomCom.Location = New System.Drawing.Point(177, 19)
        Me.grpCustomCom.Name = "grpCustomCom"
        Me.grpCustomCom.Size = New System.Drawing.Size(432, 219)
        Me.grpCustomCom.TabIndex = 10
        Me.grpCustomCom.TabStop = False
        Me.grpCustomCom.Text = "Customisation Component:"
        '
        'grpText
        '
        Me.grpText.Controls.Add(Me.btnPay)
        Me.grpText.Controls.Add(Me.lblAddChar)
        Me.grpText.Controls.Add(Me.lblBaseChar)
        Me.grpText.Controls.Add(Me.Label1)
        Me.grpText.Controls.Add(Me.txtText)
        Me.grpText.Location = New System.Drawing.Point(6, 137)
        Me.grpText.Name = "grpText"
        Me.grpText.Size = New System.Drawing.Size(420, 76)
        Me.grpText.TabIndex = 12
        Me.grpText.TabStop = False
        Me.grpText.Text = "Text:"
        '
        'btnPay
        '
        Me.btnPay.Location = New System.Drawing.Point(81, 46)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(75, 23)
        Me.btnPay.TabIndex = 13
        Me.btnPay.Text = "Pay"
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'lblAddChar
        '
        Me.lblAddChar.AutoSize = True
        Me.lblAddChar.Location = New System.Drawing.Point(239, 51)
        Me.lblAddChar.Name = "lblAddChar"
        Me.lblAddChar.Size = New System.Drawing.Size(142, 13)
        Me.lblAddChar.TabIndex = 3
        Me.lblAddChar.Text = "€0.05 per additional charcter"
        '
        'lblBaseChar
        '
        Me.lblBaseChar.AutoSize = True
        Me.lblBaseChar.Location = New System.Drawing.Point(239, 23)
        Me.lblBaseChar.Name = "lblBaseChar"
        Me.lblBaseChar.Size = New System.Drawing.Size(142, 13)
        Me.lblBaseChar.TabIndex = 2
        Me.lblBaseChar.Text = "€0.45 per character up to 10"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(191, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 1
        '
        'txtText
        '
        Me.txtText.Location = New System.Drawing.Point(17, 20)
        Me.txtText.Name = "txtText"
        Me.txtText.Size = New System.Drawing.Size(202, 20)
        Me.txtText.TabIndex = 0
        '
        'chkLaces
        '
        Me.chkLaces.AutoSize = True
        Me.chkLaces.Location = New System.Drawing.Point(281, 108)
        Me.chkLaces.Name = "chkLaces"
        Me.chkLaces.Size = New System.Drawing.Size(53, 17)
        Me.chkLaces.TabIndex = 11
        Me.chkLaces.Text = "€4.00"
        Me.chkLaces.UseVisualStyleBackColor = True
        '
        'chkHeelBackCounter
        '
        Me.chkHeelBackCounter.AutoSize = True
        Me.chkHeelBackCounter.Location = New System.Drawing.Point(281, 73)
        Me.chkHeelBackCounter.Name = "chkHeelBackCounter"
        Me.chkHeelBackCounter.Size = New System.Drawing.Size(53, 17)
        Me.chkHeelBackCounter.TabIndex = 10
        Me.chkHeelBackCounter.Text = "€6.49"
        Me.chkHeelBackCounter.UseVisualStyleBackColor = True
        '
        'chkHeelTab
        '
        Me.chkHeelTab.AutoSize = True
        Me.chkHeelTab.Location = New System.Drawing.Point(281, 38)
        Me.chkHeelTab.Name = "chkHeelTab"
        Me.chkHeelTab.Size = New System.Drawing.Size(53, 17)
        Me.chkHeelTab.TabIndex = 9
        Me.chkHeelTab.Text = "€4.99"
        Me.chkHeelTab.UseVisualStyleBackColor = True
        '
        'lblLaces
        '
        Me.lblLaces.AutoSize = True
        Me.lblLaces.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLaces.Location = New System.Drawing.Point(152, 109)
        Me.lblLaces.Name = "lblLaces"
        Me.lblLaces.Size = New System.Drawing.Size(45, 13)
        Me.lblLaces.TabIndex = 8
        Me.lblLaces.Text = "Laces:"
        '
        'lblHeelBackCouter
        '
        Me.lblHeelBackCouter.AutoSize = True
        Me.lblHeelBackCouter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeelBackCouter.Location = New System.Drawing.Point(152, 73)
        Me.lblHeelBackCouter.Name = "lblHeelBackCouter"
        Me.lblHeelBackCouter.Size = New System.Drawing.Size(120, 13)
        Me.lblHeelBackCouter.TabIndex = 7
        Me.lblHeelBackCouter.Text = "Heel/Back Counter:"
        '
        'chkEyestay
        '
        Me.chkEyestay.AutoSize = True
        Me.chkEyestay.Location = New System.Drawing.Point(73, 108)
        Me.chkEyestay.Name = "chkEyestay"
        Me.chkEyestay.Size = New System.Drawing.Size(53, 17)
        Me.chkEyestay.TabIndex = 6
        Me.chkEyestay.Text = "€5.00"
        Me.chkEyestay.UseVisualStyleBackColor = True
        '
        'chkVamp
        '
        Me.chkVamp.AutoSize = True
        Me.chkVamp.Location = New System.Drawing.Point(73, 73)
        Me.chkVamp.Name = "chkVamp"
        Me.chkVamp.Size = New System.Drawing.Size(59, 17)
        Me.chkVamp.TabIndex = 5
        Me.chkVamp.Text = "€14.99"
        Me.chkVamp.UseVisualStyleBackColor = True
        '
        'chkQuarter
        '
        Me.chkQuarter.AutoSize = True
        Me.chkQuarter.Location = New System.Drawing.Point(73, 38)
        Me.chkQuarter.Name = "chkQuarter"
        Me.chkQuarter.Size = New System.Drawing.Size(53, 17)
        Me.chkQuarter.TabIndex = 4
        Me.chkQuarter.Text = "€8.99"
        Me.chkQuarter.UseVisualStyleBackColor = True
        '
        'lblHeelTab
        '
        Me.lblHeelTab.AutoSize = True
        Me.lblHeelTab.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeelTab.Location = New System.Drawing.Point(152, 39)
        Me.lblHeelTab.Name = "lblHeelTab"
        Me.lblHeelTab.Size = New System.Drawing.Size(65, 13)
        Me.lblHeelTab.TabIndex = 3
        Me.lblHeelTab.Text = "Heel/Tab:"
        '
        'lblEyestay
        '
        Me.lblEyestay.AutoSize = True
        Me.lblEyestay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEyestay.Location = New System.Drawing.Point(17, 108)
        Me.lblEyestay.Name = "lblEyestay"
        Me.lblEyestay.Size = New System.Drawing.Size(55, 13)
        Me.lblEyestay.TabIndex = 2
        Me.lblEyestay.Text = "Eyestay:"
        '
        'lblVamp
        '
        Me.lblVamp.AutoSize = True
        Me.lblVamp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVamp.Location = New System.Drawing.Point(17, 73)
        Me.lblVamp.Name = "lblVamp"
        Me.lblVamp.Size = New System.Drawing.Size(42, 13)
        Me.lblVamp.TabIndex = 1
        Me.lblVamp.Text = "Vamp:"
        '
        'lblQuarter
        '
        Me.lblQuarter.AutoSize = True
        Me.lblQuarter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuarter.Location = New System.Drawing.Point(17, 38)
        Me.lblQuarter.Name = "lblQuarter"
        Me.lblQuarter.Size = New System.Drawing.Size(53, 13)
        Me.lblQuarter.TabIndex = 0
        Me.lblQuarter.Text = "Quarter:"
        '
        'grpBaseItem
        '
        Me.grpBaseItem.Controls.Add(Me.mtbQuantity)
        Me.grpBaseItem.Controls.Add(Me.frmQuantity)
        Me.grpBaseItem.Controls.Add(Me.txtSize)
        Me.grpBaseItem.Controls.Add(Me.lblSize)
        Me.grpBaseItem.Controls.Add(Me.rdoRetro)
        Me.grpBaseItem.Controls.Add(Me.rdoVintage)
        Me.grpBaseItem.Controls.Add(Me.rdoClassic)
        Me.grpBaseItem.Controls.Add(Me.lblVintage)
        Me.grpBaseItem.Controls.Add(Me.lblRetro)
        Me.grpBaseItem.Controls.Add(Me.lblClassic)
        Me.grpBaseItem.Location = New System.Drawing.Point(19, 19)
        Me.grpBaseItem.Name = "grpBaseItem"
        Me.grpBaseItem.Size = New System.Drawing.Size(139, 219)
        Me.grpBaseItem.TabIndex = 9
        Me.grpBaseItem.TabStop = False
        Me.grpBaseItem.Text = "Base Item:"
        '
        'mtbQuantity
        '
        Me.mtbQuantity.Location = New System.Drawing.Point(66, 185)
        Me.mtbQuantity.Mask = "0000"
        Me.mtbQuantity.Name = "mtbQuantity"
        Me.mtbQuantity.Size = New System.Drawing.Size(32, 20)
        Me.mtbQuantity.TabIndex = 13
        Me.mtbQuantity.ValidatingType = GetType(Integer)
        '
        'frmQuantity
        '
        Me.frmQuantity.AutoSize = True
        Me.frmQuantity.Location = New System.Drawing.Point(16, 189)
        Me.frmQuantity.Name = "frmQuantity"
        Me.frmQuantity.Size = New System.Drawing.Size(49, 13)
        Me.frmQuantity.TabIndex = 12
        Me.frmQuantity.Text = "Quantity:"
        '
        'txtSize
        '
        Me.txtSize.Location = New System.Drawing.Point(16, 153)
        Me.txtSize.Name = "txtSize"
        Me.txtSize.Size = New System.Drawing.Size(100, 20)
        Me.txtSize.TabIndex = 10
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.Location = New System.Drawing.Point(13, 137)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(58, 13)
        Me.lblSize.TabIndex = 9
        Me.lblSize.Text = "Shoe Size:"
        '
        'rdoRetro
        '
        Me.rdoRetro.AutoSize = True
        Me.rdoRetro.Location = New System.Drawing.Point(66, 71)
        Me.rdoRetro.Name = "rdoRetro"
        Me.rdoRetro.Size = New System.Drawing.Size(58, 17)
        Me.rdoRetro.TabIndex = 8
        Me.rdoRetro.TabStop = True
        Me.rdoRetro.Text = "€49.50"
        Me.rdoRetro.UseVisualStyleBackColor = True
        '
        'rdoVintage
        '
        Me.rdoVintage.AutoSize = True
        Me.rdoVintage.Location = New System.Drawing.Point(66, 107)
        Me.rdoVintage.Name = "rdoVintage"
        Me.rdoVintage.Size = New System.Drawing.Size(58, 17)
        Me.rdoVintage.TabIndex = 7
        Me.rdoVintage.TabStop = True
        Me.rdoVintage.Text = "€44.99"
        Me.rdoVintage.UseVisualStyleBackColor = True
        '
        'rdoClassic
        '
        Me.rdoClassic.AutoSize = True
        Me.rdoClassic.Location = New System.Drawing.Point(66, 37)
        Me.rdoClassic.Name = "rdoClassic"
        Me.rdoClassic.Size = New System.Drawing.Size(58, 17)
        Me.rdoClassic.TabIndex = 6
        Me.rdoClassic.TabStop = True
        Me.rdoClassic.Text = "€54.49"
        Me.rdoClassic.UseVisualStyleBackColor = True
        '
        'lblVintage
        '
        Me.lblVintage.AutoSize = True
        Me.lblVintage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVintage.Location = New System.Drawing.Point(13, 109)
        Me.lblVintage.Name = "lblVintage"
        Me.lblVintage.Size = New System.Drawing.Size(54, 13)
        Me.lblVintage.TabIndex = 5
        Me.lblVintage.Text = "Vintage:"
        '
        'lblRetro
        '
        Me.lblRetro.AutoSize = True
        Me.lblRetro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRetro.Location = New System.Drawing.Point(13, 74)
        Me.lblRetro.Name = "lblRetro"
        Me.lblRetro.Size = New System.Drawing.Size(42, 13)
        Me.lblRetro.TabIndex = 4
        Me.lblRetro.Text = "Retro:"
        '
        'lblClassic
        '
        Me.lblClassic.AutoSize = True
        Me.lblClassic.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassic.Location = New System.Drawing.Point(13, 39)
        Me.lblClassic.Name = "lblClassic"
        Me.lblClassic.Size = New System.Drawing.Size(51, 13)
        Me.lblClassic.TabIndex = 3
        Me.lblClassic.Text = "Classic:"
        '
        'grpPayment
        '
        Me.grpPayment.Controls.Add(Me.mtbDate)
        Me.grpPayment.Controls.Add(Me.Label4)
        Me.grpPayment.Controls.Add(Me.mtbNumber)
        Me.grpPayment.Controls.Add(Me.mtbExDate)
        Me.grpPayment.Controls.Add(Me.lblExpDate)
        Me.grpPayment.Controls.Add(Me.lblSecNum)
        Me.grpPayment.Controls.Add(Me.rdoDebit)
        Me.grpPayment.Controls.Add(Me.rdoCredit)
        Me.grpPayment.Location = New System.Drawing.Point(28, 275)
        Me.grpPayment.Name = "grpPayment"
        Me.grpPayment.Size = New System.Drawing.Size(463, 108)
        Me.grpPayment.TabIndex = 10
        Me.grpPayment.TabStop = False
        Me.grpPayment.Text = "Payment Option:"
        '
        'mtbNumber
        '
        Me.mtbNumber.Location = New System.Drawing.Point(143, 58)
        Me.mtbNumber.Mask = "000"
        Me.mtbNumber.Name = "mtbNumber"
        Me.mtbNumber.Size = New System.Drawing.Size(25, 20)
        Me.mtbNumber.TabIndex = 6
        Me.mtbNumber.ValidatingType = GetType(Integer)
        '
        'mtbExDate
        '
        Me.mtbExDate.Location = New System.Drawing.Point(250, 58)
        Me.mtbExDate.Mask = "00/00/0000"
        Me.mtbExDate.Name = "mtbExDate"
        Me.mtbExDate.Size = New System.Drawing.Size(68, 20)
        Me.mtbExDate.TabIndex = 5
        Me.mtbExDate.ValidatingType = GetType(Date)
        '
        'lblExpDate
        '
        Me.lblExpDate.AutoSize = True
        Me.lblExpDate.Location = New System.Drawing.Point(180, 61)
        Me.lblExpDate.Name = "lblExpDate"
        Me.lblExpDate.Size = New System.Drawing.Size(64, 13)
        Me.lblExpDate.TabIndex = 4
        Me.lblExpDate.Text = "Expiry Date:"
        '
        'lblSecNum
        '
        Me.lblSecNum.AutoSize = True
        Me.lblSecNum.Location = New System.Drawing.Point(49, 61)
        Me.lblSecNum.Name = "lblSecNum"
        Me.lblSecNum.Size = New System.Drawing.Size(88, 13)
        Me.lblSecNum.TabIndex = 2
        Me.lblSecNum.Text = "Security Number:"
        '
        'rdoDebit
        '
        Me.rdoDebit.AutoSize = True
        Me.rdoDebit.Location = New System.Drawing.Point(183, 32)
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
        Me.rdoCredit.Location = New System.Drawing.Point(52, 32)
        Me.rdoCredit.Name = "rdoCredit"
        Me.rdoCredit.Size = New System.Drawing.Size(77, 17)
        Me.rdoCredit.TabIndex = 0
        Me.rdoCredit.TabStop = True
        Me.rdoCredit.Text = "Credit Card"
        Me.rdoCredit.UseVisualStyleBackColor = True
        '
        'grpCost
        '
        Me.grpCost.Controls.Add(Me.Label2)
        Me.grpCost.Controls.Add(Me.txtCost)
        Me.grpCost.Controls.Add(Me.btnCalculate)
        Me.grpCost.Controls.Add(Me.btnPrint)
        Me.grpCost.Location = New System.Drawing.Point(508, 275)
        Me.grpCost.Name = "grpCost"
        Me.grpCost.Size = New System.Drawing.Size(183, 108)
        Me.grpCost.TabIndex = 11
        Me.grpCost.TabStop = False
        Me.grpCost.Text = "Cost:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(120, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "+23% VAT"
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(10, 31)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(100, 20)
        Me.txtCost.TabIndex = 7
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(10, 77)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnCustomise
        '
        Me.btnCustomise.Location = New System.Drawing.Point(120, 192)
        Me.btnCustomise.Name = "btnCustomise"
        Me.btnCustomise.Size = New System.Drawing.Size(69, 23)
        Me.btnCustomise.TabIndex = 12
        Me.btnCustomise.Text = "Customise"
        Me.btnCustomise.UseVisualStyleBackColor = True
        '
        'grpCusDetails
        '
        Me.grpCusDetails.Controls.Add(Me.lblSurname)
        Me.grpCusDetails.Controls.Add(Me.btnCustomise)
        Me.grpCusDetails.Controls.Add(Me.txtSurname)
        Me.grpCusDetails.Controls.Add(Me.mtbPhoneNo)
        Me.grpCusDetails.Controls.Add(Me.Label3)
        Me.grpCusDetails.Controls.Add(Me.txtStreetAdd)
        Me.grpCusDetails.Controls.Add(Me.lblStreetAdd)
        Me.grpCusDetails.Controls.Add(Me.txtForeName)
        Me.grpCusDetails.Controls.Add(Me.lblFName)
        Me.grpCusDetails.Controls.Add(Me.txtOrderID)
        Me.grpCusDetails.Controls.Add(Me.lblOrderID)
        Me.grpCusDetails.Location = New System.Drawing.Point(28, 25)
        Me.grpCusDetails.Name = "grpCusDetails"
        Me.grpCusDetails.Size = New System.Drawing.Size(195, 244)
        Me.grpCusDetails.TabIndex = 13
        Me.grpCusDetails.TabStop = False
        Me.grpCusDetails.Text = "Customer Details:"
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Location = New System.Drawing.Point(99, 73)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(52, 13)
        Me.lblSurname.TabIndex = 9
        Me.lblSurname.Text = "Surname:"
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(102, 89)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(87, 20)
        Me.txtSurname.TabIndex = 8
        '
        'mtbPhoneNo
        '
        Me.mtbPhoneNo.Location = New System.Drawing.Point(7, 195)
        Me.mtbPhoneNo.Mask = "(999) 000-0000"
        Me.mtbPhoneNo.Name = "mtbPhoneNo"
        Me.mtbPhoneNo.Size = New System.Drawing.Size(100, 20)
        Me.mtbPhoneNo.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Phone Number:"
        '
        'txtStreetAdd
        '
        Me.txtStreetAdd.Location = New System.Drawing.Point(7, 143)
        Me.txtStreetAdd.Name = "txtStreetAdd"
        Me.txtStreetAdd.Size = New System.Drawing.Size(182, 20)
        Me.txtStreetAdd.TabIndex = 5
        '
        'lblStreetAdd
        '
        Me.lblStreetAdd.AutoSize = True
        Me.lblStreetAdd.Location = New System.Drawing.Point(10, 126)
        Me.lblStreetAdd.Name = "lblStreetAdd"
        Me.lblStreetAdd.Size = New System.Drawing.Size(79, 13)
        Me.lblStreetAdd.TabIndex = 4
        Me.lblStreetAdd.Text = "Street Address:"
        '
        'txtForeName
        '
        Me.txtForeName.Location = New System.Drawing.Point(7, 89)
        Me.txtForeName.Name = "txtForeName"
        Me.txtForeName.Size = New System.Drawing.Size(87, 20)
        Me.txtForeName.TabIndex = 3
        '
        'lblFName
        '
        Me.lblFName.AutoSize = True
        Me.lblFName.Location = New System.Drawing.Point(6, 73)
        Me.lblFName.Name = "lblFName"
        Me.lblFName.Size = New System.Drawing.Size(62, 13)
        Me.lblFName.TabIndex = 2
        Me.lblFName.Text = "Fore Name:"
        '
        'txtOrderID
        '
        Me.txtOrderID.Location = New System.Drawing.Point(7, 37)
        Me.txtOrderID.Name = "txtOrderID"
        Me.txtOrderID.ReadOnly = True
        Me.txtOrderID.Size = New System.Drawing.Size(100, 20)
        Me.txtOrderID.TabIndex = 1
        '
        'lblOrderID
        '
        Me.lblOrderID.AutoSize = True
        Me.lblOrderID.Location = New System.Drawing.Point(7, 20)
        Me.lblOrderID.Name = "lblOrderID"
        Me.lblOrderID.Size = New System.Drawing.Size(50, 13)
        Me.lblOrderID.TabIndex = 0
        Me.lblOrderID.Text = "Order ID:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(337, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Date:"
        '
        'mtbDate
        '
        Me.mtbDate.Location = New System.Drawing.Point(369, 58)
        Me.mtbDate.Mask = "00/00/0000"
        Me.mtbDate.Name = "mtbDate"
        Me.mtbDate.Size = New System.Drawing.Size(68, 20)
        Me.mtbDate.TabIndex = 8
        Me.mtbDate.ValidatingType = GetType(Date)
        '
        'frmCustomisationPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 412)
        Me.Controls.Add(Me.grpCusDetails)
        Me.Controls.Add(Me.grpCost)
        Me.Controls.Add(Me.grpPayment)
        Me.Controls.Add(Me.grpSelection)
        Me.Name = "frmCustomisationPage"
        Me.Text = "Customisation"
        Me.grpSelection.ResumeLayout(False)
        Me.grpCustomCom.ResumeLayout(False)
        Me.grpCustomCom.PerformLayout()
        Me.grpText.ResumeLayout(False)
        Me.grpText.PerformLayout()
        Me.grpBaseItem.ResumeLayout(False)
        Me.grpBaseItem.PerformLayout()
        Me.grpPayment.ResumeLayout(False)
        Me.grpPayment.PerformLayout()
        Me.grpCost.ResumeLayout(False)
        Me.grpCost.PerformLayout()
        Me.grpCusDetails.ResumeLayout(False)
        Me.grpCusDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPrint As Button
    Friend WithEvents grpSelection As GroupBox
    Friend WithEvents grpPayment As GroupBox
    Friend WithEvents rdoDebit As RadioButton
    Friend WithEvents rdoCredit As RadioButton
    Friend WithEvents lblExpDate As Label
    Friend WithEvents lblSecNum As Label
    Friend WithEvents mtbNumber As MaskedTextBox
    Friend WithEvents mtbExDate As MaskedTextBox
    Friend WithEvents grpBaseItem As GroupBox
    Friend WithEvents grpCost As GroupBox
    Friend WithEvents txtCost As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnCustomise As Button
    Friend WithEvents lblVintage As Label
    Friend WithEvents lblRetro As Label
    Friend WithEvents lblClassic As Label
    Friend WithEvents grpCustomCom As GroupBox
    Friend WithEvents lblEyestay As Label
    Friend WithEvents lblVamp As Label
    Friend WithEvents lblQuarter As Label
    Friend WithEvents chkHeelTab As CheckBox
    Friend WithEvents lblLaces As Label
    Friend WithEvents lblHeelBackCouter As Label
    Friend WithEvents chkEyestay As CheckBox
    Friend WithEvents chkVamp As CheckBox
    Friend WithEvents chkQuarter As CheckBox
    Friend WithEvents lblHeelTab As Label
    Friend WithEvents chkLaces As CheckBox
    Friend WithEvents chkHeelBackCounter As CheckBox
    Friend WithEvents grpText As GroupBox
    Friend WithEvents txtText As TextBox
    Friend WithEvents rdoRetro As RadioButton
    Friend WithEvents rdoVintage As RadioButton
    Friend WithEvents rdoClassic As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents lblBaseChar As Label
    Friend WithEvents lblAddChar As Label
    Friend WithEvents btnPay As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSize As TextBox
    Friend WithEvents lblSize As Label
    Friend WithEvents grpCusDetails As GroupBox
    Friend WithEvents txtOrderID As TextBox
    Friend WithEvents lblOrderID As Label
    Friend WithEvents txtForeName As TextBox
    Friend WithEvents lblFName As Label
    Friend WithEvents frmQuantity As Label
    Friend WithEvents txtStreetAdd As TextBox
    Friend WithEvents lblStreetAdd As Label
    Friend WithEvents mtbQuantity As MaskedTextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents mtbPhoneNo As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblSurname As Label
    Friend WithEvents mtbDate As MaskedTextBox
    Friend WithEvents Label4 As Label
End Class
