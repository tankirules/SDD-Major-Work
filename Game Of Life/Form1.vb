Imports System.IO
Imports System.Text
Public Class Form1

    Dim Grid(50, 50) As Panel
    Dim Checked(50, 50) As Integer
    Dim SideLength As Integer
    Dim TempGrid(50, 50) As Integer
    Dim Started As Boolean
    Dim Outofbounds As Boolean
    Dim PresetVisible As Boolean
    Dim Username As String
    Dim password As String
    Dim uncheckedcolor, checkedcolor As Color
    Dim supercancer As Boolean
    Dim Timesupdated As Integer
    Dim isdown As Boolean
    Dim puttinginpreset As Boolean
    Public closedproperlyinput As Boolean
    Public presettoput(50, 50) As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        puttinginpreset = False
        isdown = False
        closedproperlyinput = False



        Timesupdated = 0
        Tickspeedcalculator.Start()
        supercancer = False
        uncheckedcolor = Color.White
        checkedcolor = Color.Black
        Started = False
        SideLength = Me.Bounds.Height / 60
        PresetVisible = False
        For x = 1 To 50
            For y = 1 To 50
                Grid(x, y) = New Panel
                Grid(x, y).Location = New Point(x * SideLength, y * SideLength)
                Grid(x, y).Size = New Size(SideLength, SideLength)

                Grid(x, y).BackgroundImageLayout = ImageLayout.Zoom
                Grid(x, y).BackColor = uncheckedcolor
                Grid(x, y).BorderStyle = BorderStyle.FixedSingle
                Controls.Add(Grid(x, y))
                Checked(x, y) = 0
                TempGrid(x, y) = 0
                '0 Is Not checked, 1 Is checked - Set all squares To Not be checked
                AddHandler Grid(x, y).Click, AddressOf Grid_Select
                AddHandler Grid(x, y).MouseEnter, AddressOf Mouse_Enter
                AddHandler Grid(x, y).MouseDown, AddressOf Mouse_Down
                AddHandler Grid(x, y).MouseHover, AddressOf Mouse_Hover
            Next
        Next

    End Sub
    Private Sub Mouse_Hover(sender As Object, e As EventArgs)

    End Sub
    Private Sub Mouse_Down(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Right Then
            If isdown = False Then
                isdown = True
            ElseIf isdown = True Then
                isdown = False
            End If
        End If
    End Sub
    Private Sub Grid_Select(sender As Object, e As EventArgs)
        Dim xpos, ypos As Integer
        xpos = CInt(sender.location.x) / SideLength
        ypos = CInt(sender.location.y) / SideLength
        lblx.Text = "X Pos: " + CStr(xpos)
        lbly.Text = "Y Pos: " + CStr(ypos)

        If Checked(xpos, ypos) = 0 Then
            Grid(xpos, ypos).BackColor = checkedcolor
            Checked(xpos, ypos) = 1
        ElseIf Checked(xpos, ypos) = 1 Then
            Grid(xpos, ypos).BackColor = uncheckedcolor
            Checked(xpos, ypos) = 0
        End If


    End Sub
    Private Sub Mouse_Enter(sender As Object, e As EventArgs)
        Dim xpos, ypos As Integer
        xpos = CInt(sender.location.x) / SideLength
        ypos = CInt(sender.location.y) / SideLength

        If isdown Then
            Grid(xpos, ypos).BackColor = checkedcolor
            Checked(xpos, ypos) = 1
        End If



    End Sub

    Private Sub btnstartstop_Click(sender As Object, e As EventArgs) Handles btnstartstop.Click
        If Started = False Then
            btnstartstop.Text = "Stop"
            Started = True
            updatetimer.Start()
        ElseIf Started = True Then
            btnstartstop.Text = "Start"
            Started = False
            updatetimer.Stop()
        End If
    End Sub
    Private Sub resetgrid()
        For x = 1 To 50
            For y = 1 To 50
                Grid(x, y).BackColor = uncheckedcolor
                Checked(x, y) = 0
                TempGrid(x, y) = 0
            Next
        Next
    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        resetgrid()
    End Sub

    Private Sub updatetimer_Tick(sender As Object, e As EventArgs) Handles updatetimer.Tick
        Timesupdated = Timesupdated + 1
        Dim neighbours As Integer

        For x = 1 To 50
            For y = 1 To 50
                neighbours = 0
                If Checked(x, y) = 0 Then
                    Checkneighbours(x, y, neighbours)

                    If neighbours = 3 Then
                        TempGrid(x, y) = 1
                        'Console.WriteLine("Dead Cell Regenerated at :" + CStr(x) + " " + CStr(y))
                    End If
                ElseIf Checked(x, y) = 1 Then
                    Checkneighbours(x, y, neighbours)
                    'Console.WriteLine("checking live cell")
                    'Console.WriteLine("neighbours:" + CStr(neighbours))
                    If neighbours < 2 And neighbours >= 0 Then
                        TempGrid(x, y) = 0
                        'Console.WriteLine("Live Cell Killed at :" + CStr(x) + " " + CStr(y))
                    ElseIf neighbours = 2 Or neighbours = 3 Then
                        TempGrid(x, y) = 1
                        'Console.WriteLine("Live Cell living at :" + CStr(x) + " " + CStr(y))
                    ElseIf neighbours > 3 Then
                        TempGrid(x, y) = 0
                        'Console.WriteLine("Live Cell overpopulated at :" + CStr(x) + " " + CStr(y))
                    ElseIf neighbours < 0 Then
                        TempGrid(x, y) = 0
                    End If
                End If
            Next
        Next

        For x = 1 To 50
            For y = 1 To 50
                If TempGrid(x, y) = 0 Then
                    Checked(x, y) = 0
                    Grid(x, y).BackColor = uncheckedcolor
                ElseIf TempGrid(x, y) = 1 Then
                    Checked(x, y) = 1
                    Grid(x, y).BackColor = checkedcolor
                End If
            Next
        Next



    End Sub
    Private Sub Checkneighbours(ByVal x As Integer, y As Integer, ByRef neighbours As Integer)
        'If Checked(x, y, 1) = 1 Then
        '    Console.WriteLine(CStr(x) + " " + CStr(y) + " Is checked!")
        'End If
        Outofbounds = False
        If x - 1 < 1 Or x + 1 > 50 Or y - 1 < 1 Or y + 1 > 50 Then
            Outofbounds = True
            neighbours = -100
        Else
            neighbours = Checked(x - 1, y + 1) + Checked(x, y + 1) + Checked(x + 1, y + 1) + Checked(x - 1, y) + Checked(x + 1, y) + Checked(x - 1, y - 1) + Checked(x, y - 1) + Checked(x + 1, y - 1)

        End If



        If neighbours > 0 Then
            'Console.WriteLine("Total Neighbours for: " + CStr(x) + " " + CStr(y) + " is " + CStr(neighbours))
        End If



    End Sub

    Private Sub Speedcontrol_Scroll(sender As Object, e As EventArgs) Handles Speedcontrol.Scroll
        updatetimer.Interval = Speedcontrol.Value
    End Sub


    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim UPD As New InputUPDForm
        Dim result As DialogResult
        Dim tempx, tempy As String

        If UPD.ShowDialog(Me) <> DialogResult.Cancel And UPD.ClosedproperlyInput = True Then
            Username = UPD.txtusername.Text
            password = UPD.txtpassword.Text

            Dim SaveFile As New SaveFileDialog With {
            .Title = "Save Current board State",
            .Filter = "Grid State File|*.gsf|All files|*.*",
            .FileName = "Board_State"
        }
            If SaveFile.ShowDialog() <> DialogResult.Cancel Then
                Using FS As New IO.StreamWriter(SaveFile.FileName)
                    FS.WriteLine("Username:" + Username)
                    FS.WriteLine("Password:" + password)
                    For x = 1 To 50
                        For y = 1 To 50
                            If Checked(x, y) = 1 Then
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



            End If
        Else
            MsgBox("Exporting Grid State Canceled")
        End If






    End Sub

    Private Sub btnopen_Click(sender As Object, e As EventArgs) Handles btnopen.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String
        Dim valid As Boolean
        Dim tempstring As String
        Dim tempx, tempy As String
        Dim loadedu, loadedp As String
        Dim enteredu, enteredp As String
        Dim UPD As New ValidateUPDForm
        Dim result As DialogResult
        Dim coordsvalid As Boolean
        valid = False
        tempx = ""
        tempy = ""


        fd.Title = "Load Saved Grid State"
        fd.InitialDirectory = "C:\"
        fd.Filter = "Grid State File|*.gsf|All files|*.*"


        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
            Dim loadedfile() As String = IO.File.ReadAllLines(strFileName)
            If loadedfile(0).Contains("Username:") And loadedfile(1).Contains("Password:") Then

                result = UPD.ShowDialog(Me)
                If result = Windows.Forms.DialogResult.OK And UPD.Closedproperlyvalidate = True Then
                    enteredu = UPD.txtusername.Text
                    enteredp = UPD.txtpassword.Text
                    loadedu = loadedfile(0)
                    loadedu = loadedu.Remove(0, 9)
                    loadedp = loadedfile(1)
                    loadedp = loadedp.Remove(0, 9)
                    For x = 1 To 50
                        For y = 1 To 50
                            Checked(x, y) = 0
                            Grid(x, y).BackColor = uncheckedcolor
                        Next
                    Next

                    If enteredu = loadedu And enteredp = loadedp Then
                        valid = True
                        For i = 2 To loadedfile.Length - 1
                            coordsvalid = True
                            tempx = ""
                            tempy = ""
                            tempstring = loadedfile(i)
                            Console.WriteLine("tempstring at loadedfile" + CStr(i) + "is : " + tempstring)
                            If tempstring(2) <> "," Or tempstring.Length <> 5 Then
                                MsgBox("Loaded file has invalid coordinate format!")
                                Console.WriteLine("Loaded file has invalid coordinate format!")
                                valid = False
                                Exit For
                            Else

                                Console.WriteLine("passed comma coordinate test")
                                For h = 0 To 1
                                    If IsNumeric(tempstring(h)) = False Then
                                        coordsvalid = False
                                    End If
                                    tempx = tempx + tempstring(h)
                                Next
                                For g = 3 To 4
                                    If IsNumeric(tempstring(g)) = False Then
                                        coordsvalid = False
                                    End If
                                    tempy = tempy + tempstring(g)
                                Next
                                If coordsvalid = False Then
                                    valid = False
                                    MsgBox("Invalid coordinates! Loading Stopped!")
                                    Exit For
                                End If
                                If CInt(tempx) < 0 Or CInt(tempx) > 50 Or CInt(tempy) < 0 Or CInt(tempy) > 50 Then
                                    valid = False
                                    MsgBox("Coordinates out of range!")
                                    Exit For
                                End If


                                Console.WriteLine("tempx is " + tempx + "and tempy is " + tempy)
                                Checked(CInt(tempx), CInt(tempy)) = 1
                                Grid(CInt(tempx), CInt(tempy)).BackColor = checkedcolor
                                Console.WriteLine("Checked black at :" + tempx + " , " + tempy)

                            End If
                        Next
                    Else
                        MsgBox("Username/Password Incorrect!")
                    End If
                Else
                    MsgBox("Save file not loaded!")

                End If

            Else
                MsgBox("Loaded file has invalid Username/Password format!")

                valid = False
            End If

        End If




    End Sub


    Private Sub Tickspeedcalculator_Tick(sender As Object, e As EventArgs) Handles Tickspeedcalculator.Tick
        lbltickspeed.Text = CStr(Timesupdated)
        Timesupdated = 0
    End Sub

    Private Sub btnpreset_Click(sender As Object, e As EventArgs) Handles btnpreset.Click
        Dim Preset As Presetchooser
        If Presetchooser.ShowDialog() = DialogResult.OK And closedproperlyinput = True Then
            puttinginpreset = True
        End If
    End Sub

End Class
