Public Class ValidateUPDForm
    Public Closedproperlyvalidate As Boolean
    Private Sub ValidateUPDForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Closedproperlyvalidate = False

    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        Closedproperlyvalidate = True
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub txtpassword_TextChanged(sender As Object, e As EventArgs) Handles txtpassword.TextChanged

    End Sub

    Private Sub txtusername_TextChanged(sender As Object, e As EventArgs) Handles txtusername.TextChanged

    End Sub
End Class