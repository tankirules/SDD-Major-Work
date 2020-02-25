Public Class InputUPDForm
    Public ClosedproperlyInput As Boolean
    Private Sub UPD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClosedproperlyInput = False
    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        ClosedproperlyInput = True
        Me.DialogResult = Windows.Forms.DialogResult.OK

    End Sub


    Private Sub btnshowhide_Click(sender As Object, e As EventArgs) Handles btnshowhide.Click
        If txtpassword.UseSystemPasswordChar = False Then
            txtpassword.UseSystemPasswordChar = True
        Else
            txtpassword.UseSystemPasswordChar = False
        End If
    End Sub
End Class