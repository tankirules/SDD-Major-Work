Public Class ValidateUPDForm
    Public Closedproperlyvalidate As Boolean
    Private Sub ValidateUPDForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Closedproperlyvalidate = False

    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        Closedproperlyvalidate = True
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class