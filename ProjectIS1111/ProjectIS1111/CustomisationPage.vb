Public Class frmCustomisationPage
    Private Sub frmCustomisationPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CustomerdtbDataSet.tblBaseItem' table. You can move, or remove it, as needed.
        Me.TblBaseItemTableAdapter.Fill(Me.CustomerdtbDataSet.tblBaseItem)

    End Sub
End Class