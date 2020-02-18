Public Class InputUPDForm
    Public ClosedproperlyInput As Boolean
    Private Sub UPD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClosedproperlyInput = False
    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        ClosedproperlyInput = True
        Me.DialogResult = Windows.Forms.DialogResult.OK

    End Sub

End Class