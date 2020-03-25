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
        'TODO: This line of code loads data into the 'CustomerdtbDataSet.tblBaseItem' table. You can move, or remove it, as needed.
        Me.TblBaseItemTableAdapter.Fill(Me.CustomerdtbDataSet.tblBaseItem)

        'Order Number Maker
        Randomize()
        GetNumber()

        txtOrderID.Text = num

        'Ceratin parts of the from will be disabled in order for the customer to fully fill out the from
        grpSelection.Enabled = False
        grpPayment.Enabled = False

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        frmReceiptTime.Show()
    End Sub

    Private Sub btnCustomise_Click(sender As Object, e As EventArgs) Handles btnCustomise.Click
        'Make sure important details are put in before continuing
        If txtForeName.Text = "" Or txtSurname.Text = "" Or txtStreetAdd.Text = "" Or mtbPhoneNo.Text = "" Then
            MessageBox.Show("You have not input necessary data!")
        Else
            grpSelection.Enabled = True
            grpCustomCom.Enabled = False
        End If
    End Sub

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
            MessageBox.Show("You have not input necessary data!")
        Else
            grpPayment.Enabled = True
        End If
    End Sub
End Class