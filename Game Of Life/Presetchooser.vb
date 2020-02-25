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

    Private Sub Presetchooser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        If presetChecked(xpos, ypos) = 0 Then
            Grid(xpos, ypos).BackColor = Color.Black
            presetchecked(xpos, ypos) = 1
        ElseIf presetChecked(xpos, ypos) = 1 Then
            Grid(xpos, ypos).BackColor = Color.White
            presetchecked(xpos, ypos) = 0
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
        For x = 1 To 50
            For y = 1 To 50
                Grid(x, y).BackColor = Color.White
                presetchecked(x, y) = 0
            Next
        Next
    End Sub

    Private Sub btnsavepreset_Click(sender As Object, e As EventArgs) Handles btnsavepreset.Click
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

            Next
        Next
        For x = 1 To 50
            For y = 1 To 50
                Grid(x, y).BackColor = Color.White
                presetchecked(x, y) = 0
            Next
        Next
    End Sub

End Class