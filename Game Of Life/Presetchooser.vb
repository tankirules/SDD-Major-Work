Imports System.IO
Imports System.Text
Public Class Presetchooser
    Dim Grid(50, 50) As Panel
    Dim SideLength As Integer
    Dim presetchecked(50, 50) As Integer
    Dim preset6(50, 50) As Integer
    Dim preset1(50, 50) As Integer
    Dim preset2(50, 50) As Integer
    Dim preset3(50, 50) As Integer
    Dim preset4(50, 50) As Integer
    Dim preset5(50, 50) As Integer

    Dim temp As Boolean

    Dim cpreset1, cpreset2, cpreset3, cpreset4, cpreset5, cpreset6 As RefBool
    Dim centerbeingset As Boolean
    Dim radiobuttonlist As New List(Of RadioButton)
    Dim presetlist As New List(Of Array)
    Dim loadederror As String
    Dim bigbrain As Boolean
    Dim ptemplist As New List(Of Array)
    Dim temppresetname As String
    Dim listofcenterpreset As New List(Of RefBool)
    Dim presetlinelist As New List(Of Integer)
    Dim templist As New List(Of String)
    Dim ptemp1 As Object
    Dim ptemp2 As Object
    Dim ptemp3 As Object
    Dim ptemp4 As Object
    Dim ptemp5 As Object
    Dim ptemp6 As Object
    Dim arrayofpresests(6) As Integer
    Dim presetcountload As Integer
    Public Path As String = "c:\Gameoflife\presets.txt"
    Dim loadedfile() As String = IO.File.ReadAllLines(Path)
    Dim center As coords
    Public presetcoordslist As New List(Of coords)
    Public Structure coords
        Public xcoord As Integer
        Public ycoord As Integer
    End Structure
    Public Class RefBool
        Public val As Boolean
    End Class
    Private Sub Initializevaluesandlists()
        SideLength = Me.Bounds.Height / 60
        templist.Clear()
        bigbrain = False
        loadederror = ""
        temppresetname = ""
        Form1.closedproperlyinput = False
        presetcountload = 0
        centerbeingset = False
        cpreset1 = New RefBool()
        cpreset2 = New RefBool()
        cpreset3 = New RefBool()
        cpreset4 = New RefBool()
        cpreset5 = New RefBool()
        cpreset6 = New RefBool()
        cpreset1.val = False
        cpreset2.val = False
        cpreset3.val = False
        cpreset4.val = False
        cpreset5.val = False
        cpreset6.val = False
        radiobuttonlist.Add(rbtnpreset1)
        radiobuttonlist.Add(rbtnpreset2)
        radiobuttonlist.Add(rbtnpreset3)
        radiobuttonlist.Add(rbtnpreset4)
        radiobuttonlist.Add(rbtnpreset5)
        radiobuttonlist.Add(rbtnpreset6)

        presetlist.Add(preset1)
        presetlist.Add(preset2)
        presetlist.Add(preset3)
        presetlist.Add(preset4)
        presetlist.Add(preset5)
        presetlist.Add(preset6)

        listofcenterpreset.Clear()
        listofcenterpreset.Add(cpreset1)
        listofcenterpreset.Add(cpreset2)
        listofcenterpreset.Add(cpreset3)
        listofcenterpreset.Add(cpreset4)
        listofcenterpreset.Add(cpreset5)
        listofcenterpreset.Add(cpreset6)
    End Sub
    Private Sub Presetchooser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Initializevaluesandlists()
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

        If File.Exists(Path) And loadedfile.Length >= 6 Then
            If loadedfile(0).Contains("P1") Then
                presetlinelist.Add(0)
                presetcountload += 1
                Console.WriteLine("P1 exists!")
                temppresetname = loadedfile(0)
                rbtnpreset1.Text = temppresetname.Remove(0, 2)
                For i = 1 To (loadedfile.Length() - 1)

                    Console.WriteLine(loadedfile.Length())
                    If loadedfile(i).Contains("P2") Then
                        If presetcountload = 1 Then
                            presetlinelist.Add(i)
                            presetcountload += 1
                            Console.WriteLine("P2 exists!")
                            temppresetname = loadedfile(i)
                            rbtnpreset2.Text = temppresetname.Remove(0, 2)
                        Else
                            MsgBox("Preset lines in file corrupt! Recommend deleting C:\Gameoflife\presets.txt and restarting program!")
                            Console.WriteLine("Corrupt 2")
                            loadederror = "Error when testing for preset line prefix"
                            lstbox.Items.Add(loadederror)
                            Exit For
                        End If
                    End If
                    If loadedfile(i).Contains("P3") Then
                        If presetcountload = 2 Then
                            presetlinelist.Add(i)
                            presetcountload += 1
                            Console.WriteLine("P3 exists!")
                            temppresetname = loadedfile(i)
                            rbtnpreset3.Text = temppresetname.Remove(0, 2)
                        Else
                            MsgBox("Preset lines in file corrupt! Recommend deleting C:\Gameoflife\presets.txt and restarting program!")
                            loadederror = "Error when testing for preset line prefix"
                            lstbox.Items.Add(loadederror)
                            Console.WriteLine("Corrupt 3")
                            Exit For
                        End If
                    End If
                    If loadedfile(i).Contains("P4") Then
                        If presetcountload = 3 Then
                            presetlinelist.Add(i)
                            presetcountload += 1
                            Console.WriteLine("P4 exists!")
                            temppresetname = loadedfile(i)
                            rbtnpreset4.Text = temppresetname.Remove(0, 2)
                        Else
                            MsgBox("Preset lines in file corrupt! Recommend deleting C:\Gameoflife\presets.txt and restarting program!")
                            loadederror = "Error when testing for preset line prefix"
                            lstbox.Items.Add(loadederror)
                            Console.WriteLine("Corrupt 4")
                            Exit For
                        End If
                    End If
                    If loadedfile(i).Contains("P5") Then
                        If presetcountload = 4 Then
                            presetlinelist.Add(i)
                            presetcountload += 1
                            Console.WriteLine("P5 exists!")
                            temppresetname = loadedfile(i)
                            rbtnpreset5.Text = temppresetname.Remove(0, 2)
                        Else
                            MsgBox("Preset lines in file corrupt! Recommend deleting C:\Gameoflife\presets.txt and restarting program!")
                            loadederror = "Error when testing for preset line prefix"
                            lstbox.Items.Add(loadederror)
                            Console.WriteLine("Corrupt 5")
                            Exit For
                        End If
                    End If
                    If loadedfile(i).Contains("P6") Then
                        If presetcountload = 5 Then
                            presetlinelist.Add(i)
                            presetcountload += 1
                            Console.WriteLine("P6 exists!")
                            temppresetname = loadedfile(i)
                            rbtnpreset6.Text = temppresetname.Remove(0, 2)
                        Else
                            MsgBox("Preset lines in file corrupt! Recommend deleting C:\Gameoflife\presets.txt and restarting program!")
                            loadederror = "Error when testing for preset line prefix"
                            lstbox.Items.Add(loadederror)
                            Console.WriteLine("Corrupt 6")
                            Exit For
                        End If
                    End If
                Next
                If presetcountload = 6 Then
                    Console.WriteLine("Loading successful! Loaded 6 presets")
                Else
                    MsgBox("Preset lines in file corrupt! Recommend deleting C:\Gameoflife\presets.txt and restarting program!")
                    loadederror = "Error when testing for preset line prefix"
                    lstbox.Items.Add(loadederror)
                    Console.WriteLine(CStr(presetcountload))
                    Console.WriteLine("at the end presetcountload wasnt 6")
                End If
            Else
                MsgBox("Preset lines in file corrupt! Recommend deleting C:\Gameoflife\presets.txt and restarting program!")
                loadederror = "Error when testing for preset line prefix"
                lstbox.Items.Add(loadederror)
                Console.WriteLine("Corrupt because first line isn't P1")
                'if first line isn't P1
            End If

            If loadederror = "" Then
                For i = 0 To presetlinelist(1) - 1
                    templist.Add(loadedfile(i))

                Next
                ptemp1 = templist.ToArray
                For i = 0 To ptemp1.length - 1
                    ptemp1(i) = CStr(ptemp1(i))
                Next
                'put everything related to preset1 into array
                templist.Clear()

                For i = presetlinelist(1) To presetlinelist(2) - 1
                    templist.Add(loadedfile(i))
                Next
                ptemp2 = templist.ToArray
                For i = 0 To ptemp2.length - 1
                    ptemp2(i) = CStr(ptemp2(i))
                Next
                'put everything related to preset2 into array
                templist.Clear()

                For i = presetlinelist(2) To presetlinelist(3) - 1
                    templist.Add(loadedfile(i))
                Next
                ptemp3 = templist.ToArray
                For i = 0 To ptemp3.length - 1
                    ptemp3(i) = CStr(ptemp3(i))
                Next
                'put everything related to preset3 into array
                templist.Clear()

                For i = presetlinelist(3) To presetlinelist(4) - 1
                    templist.Add(loadedfile(i))
                Next
                ptemp4 = templist.ToArray
                For i = 0 To ptemp4.length - 1
                    ptemp4(i) = CStr(ptemp4(i))
                Next
                'put everything related topreset 4 into array
                templist.Clear()
                For i = presetlinelist(4) To presetlinelist(5) - 1
                    templist.Add(loadedfile(i))
                Next
                ptemp5 = templist.ToArray
                For i = 0 To ptemp5.length - 1
                    ptemp5(i) = CStr(ptemp5(i))
                Next
                templist.Clear()
                'put everything related to preset 5 into array
                For i = presetlinelist(5) To loadedfile.Length() - 1
                    templist.Add(loadedfile(i))
                Next
                ptemp6 = templist.ToArray
                For i = 0 To ptemp6.length - 1
                    ptemp6(i) = CStr(ptemp6(i))
                Next
                templist.Clear()


                ptemplist.Add(ptemp1)
                ptemplist.Add(ptemp2)
                ptemplist.Add(ptemp3)
                ptemplist.Add(ptemp4)
                ptemplist.Add(ptemp5)
                ptemplist.Add(ptemp6)
            Else

            End If




            Dim centercheck As String
            For Each ptemparray As Array In ptemplist
                centercheck = ""
                If ptemparray.Length > 1 Then
                    centercheck = ptemparray(1)
                    If centercheck.Length = 6 Then
                        If centercheck(0) <> "c" Then
                            MsgBox("center coordinates corrupt/do not exist! recommend deleting c:\gameoflife\presets.txt and restarting program!")
                            loadederror = "first letter of center string wasn't c"
                            lstbox.Items.Add(loadederror)
                        End If
                    Else
                        MsgBox("center coordinates length is corrupt! recommend deleting c:\gameoflife\presets.txt and restarting program!")
                        loadederror = "line containing center coordinate is not at the required length"
                        lstbox.Items.Add(loadederror)
                    End If

                End If
            Next
            For Each ptemparray As Array In ptemplist

                If ptemparray.Length > 1 Then
                    Dim tempstring As String
                    tempstring = ptemparray(1)
                    If tempstring.Length = 6 Then
                        If tempstring(3) <> "," Or IsNumeric(tempstring(1) + tempstring(2)) = False Or IsNumeric(tempstring(4) + tempstring(5)) = False Then
                            MsgBox("center coordinates corrupt/do not exist! recommend deleting c:\gameoflife\presets.txt and restarting program!")
                            loadederror = "center coordinates aren't numbers or the comma is missing"
                            lstbox.Items.Add(loadederror)
                        ElseIf (CStr(tempstring(1) + tempstring(2)) > 50) Or (CStr(tempstring(1) + tempstring(2)) < 0) Or CStr(tempstring(4) + tempstring(5)) > 50 Or (CStr(tempstring(4) + tempstring(5)) < 0) Then
                            MsgBox("center coordinates out of range! recommend deleting c:\gameoflife\presets.txt and restarting program!")
                            loadederror = "center coordinates are out of range"
                            lstbox.Items.Add(loadederror)
                        End If
                    Else
                        MsgBox("center coordinates format corrupt! recommend deleting c:\gameoflife\presets.txt and restarting program!")
                        loadederror = "Line with center coordinates is not at the required length"
                        lstbox.Items.Add(loadederror)
                    End If

                End If
                If ptemparray.Length > 2 Then
                    For i = 2 To ptemparray.Length - 1
                        Dim tempstring As String
                        tempstring = ptemparray(i)
                        If tempstring.Length = 5 Then
                            If tempstring(2) <> "," Or IsNumeric(tempstring(0) + tempstring(1)) = False Or IsNumeric(tempstring(3) + tempstring(4)) = False Then
                                MsgBox("coordinates format corrupt! recommend deleting c:\gameoflife\presets.txt and restarting program!")
                                loadederror = "grid coords aren't numbers or the comma is missing"
                                lstbox.Items.Add(loadederror)
                            ElseIf (CStr(tempstring(0) + tempstring(1)) > 50) Or (CStr(tempstring(0) + tempstring(1)) < 0) Or (CStr(tempstring(3) + tempstring(4)) > 50) Or (CStr(tempstring(3) + tempstring(4)) < 0) Then
                                MsgBox("coordinates out of range! recommend deleting c:\gameoflife\presets.txt and restarting program!")
                                loadederror = "grid coords are out of range"
                                lstbox.Items.Add(loadederror)
                            End If
                        Else
                            MsgBox("Grid ooordinates format corrupt! recommend deleting c:\gameoflife\presets.txt and restarting program!")
                            loadederror = "Line with grid coordinates is not at the required length"
                            lstbox.Items.Add(loadederror)
                        End If

                    Next
                End If
            Next


            Dim tempgrid As String
            If loadederror = "" Then

                MsgBox("preset file successfully loaded!")
                For i = 1 To ptemp1.length - 1
                    tempgrid = ptemp1(i)
                    If tempgrid.Contains("c") Then
                        preset1(CInt(tempgrid(1) + tempgrid(2)), CInt(tempgrid(4) + tempgrid(5))) = 2
                        Grid(CInt(tempgrid(1) + tempgrid(2)), CInt(tempgrid(4) + tempgrid(5))).BackColor = Color.Yellow
                        presetchecked(CInt(tempgrid(1) + tempgrid(2)), CInt(tempgrid(4) + tempgrid(5))) = 2
                        cpreset1.val = True

                    Else
                        preset1(CInt(tempgrid(0) + tempgrid(1)), CInt(tempgrid(3) + tempgrid(4))) = 1
                        Grid(CInt(tempgrid(0) + tempgrid(1)), CInt(tempgrid(3) + tempgrid(4))).BackColor = Color.Black
                        presetchecked(CInt(tempgrid(0) + tempgrid(1)), CInt(tempgrid(3) + tempgrid(4))) = 1
                    End If
                Next
                For i = 1 To ptemp2.length - 1
                    tempgrid = ptemp2(i)
                    If tempgrid.Contains("c") Then
                        preset2(CInt(tempgrid(1) + tempgrid(2)), CInt(tempgrid(4) + tempgrid(5))) = 2
                        cpreset2.val = True
                    Else
                        preset2(CInt(tempgrid(0) + tempgrid(1)), CInt(tempgrid(3) + tempgrid(4))) = 1
                    End If
                Next
                For i = 1 To ptemp3.length - 1
                    tempgrid = ptemp3(i)
                    If tempgrid.Contains("c") Then
                        preset3(CInt(tempgrid(1) + tempgrid(2)), CInt(tempgrid(4) + tempgrid(5))) = 2
                        cpreset3.val = True
                    Else
                        preset3(CInt(tempgrid(0) + tempgrid(1)), CInt(tempgrid(3) + tempgrid(4))) = 1
                    End If
                Next
                For i = 1 To ptemp4.length - 1
                    tempgrid = ptemp4(i)
                    If tempgrid.Contains("c") Then
                        preset4(CInt(tempgrid(1) + tempgrid(2)), CInt(tempgrid(4) + tempgrid(5))) = 2
                        cpreset4.val = True
                    Else
                        preset4(CInt(tempgrid(0) + tempgrid(1)), CInt(tempgrid(3) + tempgrid(4))) = 1
                    End If
                Next
                For i = 1 To ptemp5.length - 1
                    tempgrid = ptemp5(i)
                    If tempgrid.Contains("c") Then
                        preset5(CInt(tempgrid(1) + tempgrid(2)), CInt(tempgrid(4) + tempgrid(5))) = 2
                        cpreset5.val = True
                    Else
                        preset5(CInt(tempgrid(0) + tempgrid(1)), CInt(tempgrid(3) + tempgrid(4))) = 1
                    End If
                Next
                For i = 1 To ptemp6.length - 1
                    tempgrid = ptemp6(i)
                    If tempgrid.Contains("c") Then
                        preset6(CInt(tempgrid(1) + tempgrid(2)), CInt(tempgrid(4) + tempgrid(5))) = 2
                        cpreset6.val = True
                    Else
                        preset6(CInt(tempgrid(0) + tempgrid(1)), CInt(tempgrid(3) + tempgrid(4))) = 1
                    End If
                Next


            Else
                MsgBox("Are you big brain enough to fix the error yourself? If not, delete c:\gameoflife\presets.txt and restart the program ")
            End If



        ElseIf File.Exists(Path) And loadedfile.Length < 6 Then
            loadederror = "File is not at the required length - please ignore if this is your first time starting the application or if you have not saved the presets yet"
            lstbox.Items.Add(loadederror)

        End If










    End Sub
    Private Sub Grid_Select(sender As Object, e As EventArgs)
        Dim xpos, ypos As Integer
        xpos = CInt(sender.location.x) / SideLength
        ypos = CInt(sender.location.y) / SideLength
        If centerbeingset = True Then
            If rbtnpreset1.Checked And cpreset1.val = True Then
                centeralreadyset()
            ElseIf rbtnpreset2.Checked And cpreset2.val = True Then
                centeralreadyset()
            ElseIf rbtnpreset3.Checked And cpreset3.val = True Then
                centeralreadyset()
            ElseIf rbtnpreset4.Checked And cpreset4.val = True Then
                centeralreadyset()
            ElseIf rbtnpreset5.Checked And cpreset5.val = True Then
                centeralreadyset()
            ElseIf rbtnpreset6.Checked And cpreset6.val = True Then
                centeralreadyset()

            Else
                Grid(xpos, ypos).BackColor = Color.Yellow
                presetchecked(xpos, ypos) = 2
                centerbeingset = False
                MsgBox("Center set!")
                btncenter.Text = "Set Center"
                If rbtnpreset1.Checked = True Then
                    cpreset1.val = True
                ElseIf rbtnpreset2.Checked = True Then
                    cpreset2.val = True
                ElseIf rbtnpreset3.Checked = True Then
                    cpreset3.val = True
                ElseIf rbtnpreset4.Checked = True Then
                    cpreset4.val = True
                ElseIf rbtnpreset5.Checked = True Then
                    cpreset5.val = True
                ElseIf rbtnpreset6.Checked = True Then
                    cpreset6.val = True



                End If


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
        For Each button In radiobuttonlist
            If button.Checked = True Then
                button.Text = InputBox("Enter name to change to ")
            End If
        Next

    End Sub
    Private Sub btnresetgrid_Click(sender As Object, e As EventArgs) Handles btnresetgrid.Click
        cleargrid()

    End Sub

    Private Sub btnsavepreset_Click(sender As Object, e As EventArgs) Handles btnsavepreset.Click
        If rbtnpreset1.Checked = True And cpreset1.val = True Then
            savepresettopreset()
        ElseIf rbtnpreset2.Checked = True And cpreset2.val = True Then
            savepresettopreset()
        ElseIf rbtnpreset3.Checked = True And cpreset3.val = True Then
            savepresettopreset()
        ElseIf rbtnpreset4.Checked = True And cpreset4.val = True Then
            savepresettopreset()
        ElseIf rbtnpreset5.Checked = True And cpreset5.val = True Then
            savepresettopreset()
        ElseIf rbtnpreset6.Checked = True And cpreset6.val = True Then
            savepresettopreset()
        Else
            MsgBox("You have not set a center!")

        End If

    End Sub

    Private Sub rbtnpreset1_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnpreset1.CheckedChanged
        If Grid(50, 50) Is Nothing Then

        Else
            cleargrid()
        End If
        Console.WriteLine("Center being sets: " + CStr(centerbeingset))
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
        If Grid(50, 50) Is Nothing Then

        Else
            cleargrid()
        End If
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
        If Grid(50, 50) Is Nothing Then

        Else
            cleargrid()
        End If
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
        If Grid(50, 50) Is Nothing Then

        Else
            cleargrid()
        End If
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
        If Grid(50, 50) Is Nothing Then

        Else
            cleargrid()
        End If
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
        If Grid(50, 50) Is Nothing Then

        Else
            cleargrid()
        End If
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

    Private Sub btnshowerrors_Click(sender As Object, e As EventArgs) Handles btnshowerrors.Click
        If bigbrain = False Then
            bigbrain = True
            lstbox.Show()
            btnshowerrors.Text = "I have a smol brein :("
        ElseIf bigbrain = True Then
            bigbrain = False
            lstbox.Hide()
            btnshowerrors.Text = "Acktually I hev a very beeg brian"
        End If
    End Sub

    Private Sub btnclosepresetchooser_Click(sender As Object, e As EventArgs) Handles btnclosepresetchooser.Click
        Form1.checkedgridbeforesettingpreset.Clear()
        Dim tempalreadychecked As coords
        'add to a list all the coordinates already checked in the form1 grid
        For x = 1 To 50
            For y = 1 To 50
                If Form1.Checked(x, y) = 1 Then
                    tempalreadychecked.xcoord = x
                    tempalreadychecked.ycoord = y
                    Form1.checkedgridbeforesettingpreset.Add(tempalreadychecked)
                End If
            Next
        Next


        Form1.presetcoordslist.Clear()
        Dim tempcoords As coords
        Form1.closedproperlyinput = True
        For Each button In radiobuttonlist
            If button.Checked = True Then
                If listofcenterpreset(radiobuttonlist.IndexOf(button)).val = True Then
                    For Each array In presetlist
                        If presetlist.IndexOf(array) = radiobuttonlist.IndexOf(button) Then
                            For x = 1 To 50
                                For y = 1 To 50
                                    If array(x, y) = 2 Then
                                        center.xcoord = x
                                        center.ycoord = y
                                    End If
                                Next
                            Next
                            For x = 1 To 50
                                For y = 1 To 50
                                    If array(x, y) = 1 Then
                                        tempcoords.xcoord = x - center.xcoord
                                        tempcoords.ycoord = y - center.ycoord
                                        presetcoordslist.Add(tempcoords)

                                    End If
                                Next
                            Next
                            For Each coord As coords In presetcoordslist
                                Form1.presetcoordslist.Add(coord)
                            Next
                        End If
                    Next
                    Form1.puttinginpreset = True
                Else
                    MsgBox("Preset invalid! Please select or create a valid preset! at " + button.Text)
                    Console.WriteLine("Preset invalid! Please select or create a valid preset! at " + button.Text)

                End If

            End If
        Next
        Me.Close()

    End Sub

    Private Sub btnresetcenter_Click(sender As Object, e As EventArgs) Handles btnresetcenter.Click
        Dim tempcheckedarray(50, 50) As Integer
        For Each button In radiobuttonlist
            If button.Checked = True Then
                listofcenterpreset(radiobuttonlist.IndexOf(button)).val = False
                tempcheckedarray = presetlist(radiobuttonlist.IndexOf(button))
                For x = 1 To 50
                    For y = 1 To 50
                        If presetchecked(x, y) = 2 Or tempcheckedarray(x, y) = 2 Then
                            presetchecked(x, y) = 0
                            Grid(x, y).BackColor = Color.White
                            tempcheckedarray(x, y) = 0
                        End If
                    Next
                Next
                presetlist(radiobuttonlist.IndexOf(button)) = tempcheckedarray
            End If

        Next


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
        Dim temppreset(50, 50) As Integer
        Dim buttonindex As Integer
        buttonindex = 0
        Array.Clear(temppreset, 0, temppreset.Length)
        For x = 1 To 50
            For y = 1 To 50
                If presetchecked(x, y) = 1 Then
                    For Each button In radiobuttonlist
                        If button.Checked = True Then
                            buttonindex = radiobuttonlist.IndexOf(button)
                            temppreset(x, y) = 1
                        End If
                    Next
                End If
                If presetchecked(x, y) = 2 Then
                    For Each button In radiobuttonlist
                        If button.Checked = True Then
                            buttonindex = radiobuttonlist.IndexOf(button)
                            temppreset(x, y) = 2
                        End If
                    Next
                End If
            Next
        Next
        For Each array In presetlist
            If presetlist.IndexOf(array) = buttonindex Then
                Array.Copy(temppreset, array, array.Length)
            End If
        Next

    End Sub
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim tempx, tempy As String
        Using FS As New IO.StreamWriter("C:\Gameoflife\presets.txt")
            'save preset1
            FS.WriteLine("P1" + rbtnpreset1.Text)
            For x = 1 To 50
                For y = 1 To 50
                    If preset1(x, y) = 2 Then
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
                        FS.WriteLine("c" + tempx + "," + tempy)
                        Exit For
                    End If
                Next
            Next
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
            'save preset 2
            FS.WriteLine("P2" + rbtnpreset2.Text)
            For x = 1 To 50
                For y = 1 To 50
                    If preset2(x, y) = 2 Then
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
                        FS.WriteLine("c" + tempx + "," + tempy)
                        Exit For
                    End If
                Next
            Next
            For x = 1 To 50
                For y = 1 To 50
                    If preset2(x, y) = 1 Then
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
            'save preset3
            FS.WriteLine("P3" + rbtnpreset3.Text)
            For x = 1 To 50
                For y = 1 To 50
                    If preset3(x, y) = 2 Then
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
                        FS.WriteLine("c" + tempx + "," + tempy)
                        Exit For
                    End If
                Next
            Next
            For x = 1 To 50
                For y = 1 To 50
                    If preset3(x, y) = 1 Then
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
            'save preset 4
            FS.WriteLine("P4" + rbtnpreset4.Text)
            For x = 1 To 50
                For y = 1 To 50
                    If preset4(x, y) = 2 Then
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
                        FS.WriteLine("c" + tempx + "," + tempy)
                        Exit For
                    End If
                Next
            Next
            For x = 1 To 50
                For y = 1 To 50
                    If preset4(x, y) = 1 Then
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
            'save preset 5
            FS.WriteLine("P5" + rbtnpreset5.Text)
            For x = 1 To 50
                For y = 1 To 50
                    If preset5(x, y) = 2 Then
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
                        FS.WriteLine("c" + tempx + "," + tempy)
                        Exit For
                    End If
                Next
            Next
            For x = 1 To 50
                For y = 1 To 50
                    If preset5(x, y) = 1 Then
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
            'save preset 6
            FS.WriteLine("P6" + rbtnpreset6.Text)
            For x = 1 To 50
                For y = 1 To 50
                    If preset6(x, y) = 2 Then
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
                        FS.WriteLine("c" + tempx + "," + tempy)
                        Exit For
                    End If
                Next
            Next
            For x = 1 To 50
                For y = 1 To 50
                    If preset6(x, y) = 1 Then
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
    Private Sub centeralreadyset()
        btncenter.Text = "Set Center"
        centerbeingset = False
        MsgBox("You have already set a center for this preset!")
    End Sub
End Class