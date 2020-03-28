Public Class frmCustomisationPage
    Dim num As Integer

    Private Sub GetNumber()
        num = Math.Ceiling(Rnd() * 10000)
    End Sub

    'Setting up global variables
    Public Class GlobalVariables
        Public Shared dblTotal As Double
    End Class

    Private Sub frmCustomisationPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Order Number Maker
        Randomize()
        GetNumber()

        txtOrderID.Text = num

        'Ceratin parts of the from will be disabled in order for the customer to fully fill out the from
        grpCost.Enabled = False
        grpSelection.Enabled = False
        grpPayment.Enabled = False

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If mtbNumber.Text = "" Or mtbExDate.Text = "" Or mtbDate.Text = "" Then
            MessageBox.Show("You have not input necessary data!", "Error")
        Else
            frmReceiptTime.Show()
        End If
    End Sub

    Private Sub btnCustomise_Click(sender As Object, e As EventArgs) Handles btnCustomise.Click
        'Make sure important details are put in before continuing
        If txtForeName.Text = "" Or txtSurname.Text = "" Or txtStreetAdd.Text = "" Or mtbPhoneNo.Text = "" Then
            MessageBox.Show("You have not input necessary data!", "Error")
        Else
            grpSelection.Enabled = True
            grpCustomCom.Enabled = False
        End If
    End Sub

    '
    Private Sub rdoClassic_CheckedChanged(sender As Object, e As EventArgs) Handles rdoClassic.CheckedChanged
        If rdoClassic.Checked = True Then
            grpCustomCom.Enabled = True
        End If
    End Sub

    Private Sub rdoRetro_CheckedChanged(sender As Object, e As EventArgs) Handles rdoRetro.CheckedChanged
        If rdoRetro.Checked = True Then
            grpCustomCom.Enabled = True
        End If
    End Sub

    Private Sub rdoVintage_CheckedChanged(sender As Object, e As EventArgs) Handles rdoVintage.CheckedChanged
        If rdoVintage.Checked = True Then
            grpCustomCom.Enabled = True
        End If
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        If txtSize.Text = "" Or mtbQuantity.Text = "" Then
            MessageBox.Show("You have not input necessary data!", "Error")
        Else
            grpPayment.Enabled = True
        End If
    End Sub

    'When radio button is checked grpCost is unlocked
    'For radio button rdoCredit
    Private Sub rdoCredit_CheckedChanged(sender As Object, e As EventArgs) Handles rdoCredit.CheckedChanged
        If rdoCredit.Checked = True Then
            grpCost.Enabled = True
        End If
    End Sub

    'For radio button rdoDebit
    Private Sub rdoDebit_CheckedChanged(sender As Object, e As EventArgs) Handles rdoDebit.CheckedChanged
        If rdoDebit.Checked = True Then
            grpCost.Enabled = True
        End If
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

    End Sub
End Class