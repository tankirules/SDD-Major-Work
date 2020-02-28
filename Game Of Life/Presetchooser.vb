Public Class Presetchooser
    Dim Grid(50, 50) As Panel
    Dim SideLength As Integer
    Dim presetchecked(50, 50) As Integer
    Dim closedproperlyinput As Boolean
    Dim preset6(50, 50) As Integer
    Dim preset1(50, 50) As Integer
    Dim preset2(50, 50) As Integer
    Dim preset3(50, 50) As Integer
    Dim preset4(50, 50) As Integer
    Dim preset5(50, 50) As Integer
    Dim cpreset1, cpreset2, cpreset3, cpreset4, cpreset5, cpreset6 As Boolean
    Dim centerbeingset As Boolean

    Private Sub Presetchooser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        centerbeingset = False
        cpreset1 = False
        cpreset2 = False
        cpreset3 = False
        cpreset4 = False
        cpreset5 = False
        cpreset6 = False
        Dim loadedfile() As String = IO.File.ReadAllLines("C:\Gameoflife\presets.txt")


        closedproperlyinput = False
        SideLength = Me.Bounds.Height / 60
        For x = 1 To 50
            For y = 1 To 50
                Grid(x, y) = New Panel
                Grid(x, y).Location = New Point(x * SideLength, y * SideLength)
                Grid(x, y).Size = New Size(SideLength, SideLength)
                Grid(x, y).BackgroundImageLayout = ImageLayout.Zoom
                Grid(x, y).BackColor = Color.White
                Grid(x, y).BorderStyle = BorderStyle.FixedSingle
                Controls.Add(Grid(x, y))
                presetchecked(x, y) = 0
                AddHandler Grid(x, y).Click, AddressOf Grid_Select
            Next
        Next





    End Sub
    Private Sub Grid_Select(sender As Object, e As EventArgs)
        Dim xpos, ypos As Integer
        xpos = CInt(sender.location.x) / SideLength
        ypos = CInt(sender.location.y) / SideLength
        If centerbeingset = True Then
            Grid(xpos, ypos).BackColor = Color.Yellow
            presetchecked(xpos, ypos) = 2
            centerbeingset = False
            MsgBox("Center set!")
            If rbtnpreset1.Checked = True Then
                cpreset1 = True
            ElseIf rbtnpreset2.Checked = True Then
                cpreset2 = True
            ElseIf rbtnpreset3.Checked = True Then
                cpreset3 = True
            ElseIf rbtnpreset4.Checked = True Then
                cpreset4 = True
            ElseIf rbtnpreset5.Checked = True Then
                cpreset5 = True
            ElseIf rbtnpreset6.Checked = True Then
                cpreset6 = True

            End If

        Else
            If presetchecked(xpos, ypos) = 0 Then
                Grid(xpos, ypos).BackColor = Color.Black
                presetchecked(xpos, ypos) = 1
            ElseIf presetchecked(xpos, ypos) = 1 Then
                Grid(xpos, ypos).BackColor = Color.White
                presetchecked(xpos, ypos) = 0
            End If
        End If



    End Sub

    Private Sub btneditname_Click(sender As Object, e As EventArgs) Handles btneditname.Click
        If rbtnpreset1.Checked = True Then
            rbtnpreset1.Text = InputBox("Enter name to change to ")

        ElseIf rbtnpreset2.Checked = True Then
            rbtnpreset2.Text = InputBox("Enter name to change to ")
        ElseIf rbtnpreset3.Checked = True Then
            rbtnpreset3.Text = InputBox("Enter name to change to ")
        ElseIf rbtnpreset4.Checked = True Then
            rbtnpreset4.Text = InputBox("Enter name to change to ")
        ElseIf rbtnpreset5.Checked = True Then
            rbtnpreset5.Text = InputBox("Enter name to change to ")
        ElseIf rbtnpreset6.Checked = True Then
            rbtnpreset6.Text = InputBox("Enter name to change to ")

        End If
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim tempx, tempy As String
        Using FS As New IO.StreamWriter("C:\Gameoflife\presets.txt")
            FS.WriteLine("P1" + rbtnpreset1.Text)
            For x = 1 To 50
                For y = 1 To 50
                    If preset1(x, y) = 1 Then
                        If CStr(x).Length = 1 Then
                            tempx = "0" + CStr(x)
                        Else
                            tempx = x
                        End If
                        If CStr(y).Length = 1 Then
                            tempy = "0" + CStr(y)
                        Else
                            tempy = y
                        End If
                        FS.WriteLine(tempx + "," + tempy)
                    End If
                Next
            Next


        End Using
    End Sub

    Private Sub btnresetgrid_Click(sender As Object, e As EventArgs) Handles btnresetgrid.Click
        cleargrid()
        For x = 1 To 50
            For y = 1 To 50
                presetchecked(x, y) = 0
            Next
        Next



    End Sub

    Private Sub btnsavepreset_Click(sender As Object, e As EventArgs) Handles btnsavepreset.Click
        If rbtnpreset1.Checked = True And cpreset1 = True Then
            savepresettopreset()
        ElseIf rbtnpreset2.Checked = True And cpreset2 = True Then
            savepresettopreset()
        ElseIf rbtnpreset3.Checked = True And cpreset3 = True Then
            savepresettopreset()
        ElseIf rbtnpreset4.Checked = True And cpreset4 = True Then
            savepresettopreset()
        ElseIf rbtnpreset5.Checked = True And cpreset5 = True Then
            savepresettopreset()
        ElseIf rbtnpreset6.Checked = True And cpreset6 = True Then
            savepresettopreset()
        Else
            MsgBox("You have not set a center!")

        End If

    End Sub

    Private Sub rbtnpreset1_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnpreset1.CheckedChanged
        cleargrid()
        If rbtnpreset1.Checked Then
            For x = 1 To 50
                For y = 1 To 50
                    If preset1(x, y) = 1 Then
                        Grid(x, y).BackColor = Color.Black
                        presetchecked(x, y) = 1
                    ElseIf preset1(x, y) = 2 Then

                        Grid(x, y).BackColor = Color.Yellow
                        presetchecked(x, y) = 2
                    End If
                Next
            Next
        End If
    End Sub

    Private Sub rbtnpreset2_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnpreset2.CheckedChanged
        cleargrid()
        If rbtnpreset2.Checked Then
            For x = 1 To 50
                For y = 1 To 50
                    If preset2(x, y) = 1 Then
                        Grid(x, y).BackColor = Color.Black
                        presetchecked(x, y) = 1
                    ElseIf preset2(x, y) = 2 Then

                        Grid(x, y).BackColor = Color.Yellow
                        presetchecked(x, y) = 2
                    End If
                Next
            Next
        End If
    End Sub



    Private Sub rbtnpreset3_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnpreset3.CheckedChanged
        cleargrid()
        If rbtnpreset3.Checked Then
            For x = 1 To 50
                For y = 1 To 50
                    If preset3(x, y) = 1 Then
                        Grid(x, y).BackColor = Color.Black
                        presetchecked(x, y) = 1
                    ElseIf preset3(x, y) = 2 Then

                        Grid(x, y).BackColor = Color.Yellow
                        presetchecked(x, y) = 2
                    End If
                Next
            Next
        End If
    End Sub

    Private Sub rbtnpreset4_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnpreset4.CheckedChanged
        cleargrid()
        If rbtnpreset4.Checked Then
            For x = 1 To 50
                For y = 1 To 50
                    If preset4(x, y) = 1 Then
                        Grid(x, y).BackColor = Color.Black
                        presetchecked(x, y) = 1
                    ElseIf preset4(x, y) = 2 Then

                        Grid(x, y).BackColor = Color.Yellow
                        presetchecked(x, y) = 2
                    End If
                Next
            Next
        End If
    End Sub

    Private Sub rbtnpreset5_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnpreset5.CheckedChanged
        cleargrid()
        If rbtnpreset5.Checked Then
            For x = 1 To 50
                For y = 1 To 50
                    If preset5(x, y) = 1 Then
                        Grid(x, y).BackColor = Color.Black
                        presetchecked(x, y) = 1
                    ElseIf preset5(x, y) = 2 Then

                        Grid(x, y).BackColor = Color.Yellow
                        presetchecked(x, y) = 2
                    End If
                Next
            Next
        End If
    End Sub

    Private Sub rbtnpreset6_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnpreset6.CheckedChanged
        cleargrid()
        If rbtnpreset6.Checked Then
            For x = 1 To 50
                For y = 1 To 50
                    If preset6(x, y) = 1 Then
                        Grid(x, y).BackColor = Color.Black
                        presetchecked(x, y) = 1
                    ElseIf preset6(x, y) = 2 Then

                        Grid(x, y).BackColor = Color.Yellow
                        presetchecked(x, y) = 2
                    End If
                Next
            Next
        End If
    End Sub
    Private Sub cleargrid()
        For x = 1 To 50
            For y = 1 To 50
                Grid(x, y).BackColor = Color.White
                presetchecked(x, y) = 0
            Next
        Next
    End Sub
    Private Sub btncenter_Click(sender As Object, e As EventArgs) Handles btncenter.Click
        If centerbeingset = False Then
            btncenter.Text = "Cancel"
            centerbeingset = True
        ElseIf centerbeingset = True Then
            centerbeingset = False
            btncenter.Text = "Set Center"
        End If

    End Sub
    Private Sub savepresettopreset()
        For x = 1 To 50
            For y = 1 To 50
                If presetchecked(x, y) = 1 Then
                    If rbtnpreset1.Checked = True Then
                        preset1(x, y) = 1
                    ElseIf rbtnpreset2.Checked = True Then
                        preset2(x, y) = 1
                    ElseIf rbtnpreset3.Checked = True Then
                        preset3(x, y) = 1
                    ElseIf rbtnpreset4.Checked = True Then
                        preset4(x, y) = 1
                    ElseIf rbtnpreset5.Checked = True Then
                        preset5(x, y) = 1
                    ElseIf rbtnpreset6.Checked = True Then
                        preset6(x, y) = 1

                    End If
                End If
                If presetchecked(x, y) = 2 Then
                    If rbtnpreset1.Checked = True Then
                        preset1(x, y) = 2
                    ElseIf rbtnpreset2.Checked = True Then
                        preset2(x, y) = 2
                    ElseIf rbtnpreset3.Checked = True Then
                        preset3(x, y) = 2
                    ElseIf rbtnpreset4.Checked = True Then
                        preset4(x, y) = 2
                    ElseIf rbtnpreset5.Checked = True Then
                        preset5(x, y) = 2
                    ElseIf rbtnpreset6.Checked = True Then
                        preset6(x, y) = 2

                    End If
                End If

            Next
        Next
    End Sub
End Class