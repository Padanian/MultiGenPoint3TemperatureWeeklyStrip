Imports System.IO
Imports System.Windows.Forms

Public Class dlgTemperatureCalendar
    Dim activeHeatTempLocal(,) As Integer
    Dim activeCoolTempLocal(,) As Integer

    Public dlgWeeklyScheduler As New weeklyScheduler
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        dlgWeeklyScheduler.activeHeatTemp = activeHeatTempLocal
        dlgWeeklyScheduler.activeCoolTemp = activeCoolTempLocal

        dlgWeeklyScheduler.coolPB = nupCoolBP.Value
        dlgWeeklyScheduler.heatPB = nupHeatBP.Value
        dlgWeeklyScheduler.setpointCoolT1 = nupCoolT1.Value
        dlgWeeklyScheduler.setpointCoolT2 = nupCoolT2.Value
        dlgWeeklyScheduler.setpointCoolT3 = nupCoolT3.Value
        dlgWeeklyScheduler.setpointHeatT1 = nupHeatT1.Value
        dlgWeeklyScheduler.setpointHeatT2 = nupHeatT2.Value
        dlgWeeklyScheduler.setpointHeatT3 = nupHeatT3.Value
        dlgWeeklyScheduler.freezeProtSetpoint = nupFrostProt.Value
        dlgWeeklyScheduler.ecoCoolIncrease = nupCoolEco.Value
        dlgWeeklyScheduler.ecoHeatReduction = nupHeatEco.Value


        MultiGenPoint3TemperatureWeeklyStrip.UpdateRequest = True
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click

        MultiGenPoint3TemperatureWeeklyStrip.UpdateRequest = True

        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub chkDayAll_CheckedChanged(sender As Object, e As EventArgs) Handles chkDayAll.CheckedChanged
        If chkDayAll.Checked = True Then
            For i = 0 To 6
                DirectCast(Me.Controls.Find("rbDay" & i, True)(0), RadioButton).Enabled = False
            Next
            rbFeriale.Enabled = False
            rbFestivo.Enabled = False
        Else
            For i = 0 To 6
                DirectCast(Me.Controls.Find("rbDay" & i, True)(0), RadioButton).Enabled = True
            Next
            rbFeriale.Enabled = True
            rbFestivo.Enabled = True
        End If
    End Sub
    Private Sub dlgTemperatureCalendar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Cancel_Button.Enabled = False Then
            Cancel_Button.Enabled = True
        End If


#If DEBUG Then
        btnSaveWeekly.Visible = True
#End If
        cbManual.Text = cbManual.Items.Item(3)

        For Each lbl In Me.Controls
            If TypeOf (lbl) Is Label And lbl.name.contains("lblTime") Then
                lbl.dispose
            End If
            If TypeOf (lbl) Is PictureBox And lbl.name.contains("chkTime") Then
                lbl.dispose
            End If
        Next
        Me.Invalidate()
        Me.Refresh()
        Application.DoEvents()

        ReDim activeHeatTempLocal(6, 47)
        activeHeatTempLocal = dlgWeeklyScheduler.activeHeatTemp
        ReDim activeCoolTempLocal(6, 47)
        activeCoolTempLocal = dlgWeeklyScheduler.activeCoolTemp

        nupCoolBP.Value = dlgWeeklyScheduler.coolPB
        nupHeatBP.Value = dlgWeeklyScheduler.heatPB
        nupCoolT1.Value = dlgWeeklyScheduler.setpointCoolT1
        nupCoolT2.Value = dlgWeeklyScheduler.setpointCoolT2
        nupCoolT3.Value = dlgWeeklyScheduler.setpointCoolT3
        nupHeatT1.Value = dlgWeeklyScheduler.setpointHeatT1
        nupHeatT2.Value = dlgWeeklyScheduler.setpointHeatT2
        nupHeatT3.Value = dlgWeeklyScheduler.setpointHeatT3
        nupFrostProt.Value = dlgWeeklyScheduler.freezeProtSetpoint
        nupCoolEco.Value = dlgWeeklyScheduler.ecoCoolIncrease
        nupHeatEco.Value = dlgWeeklyScheduler.ecoHeatReduction

        For i = 1 To 23
            Dim lbl As New Label
            With lbl
                .Text = i.ToString.PadLeft(2, "0")
                .Location = New Point(30 + 30 * i, 215)
                .Name = "lblTime" & i.ToString
                .Visible = True
                .ForeColor = Color.Black
                .Width = 20
                .Height = 16
            End With
            Me.Controls.Add(lbl)
            Dim lcl As New Label
            With lcl
                .Text = i.ToString.PadLeft(2, "0")
                .Location = New Point(30 + 30 * i, 295)
                .Name = "lclTime" & i.ToString
                .Visible = True
                .ForeColor = Color.Black
                .Width = 20
                .Height = 16
            End With
            Me.Controls.Add(lcl)
        Next


        For i = 0 To 2
            For f = 0 To 47
                Dim chk As New PictureBox
                With chk
                    .Text = ""
                    .Location = New Point(36 + 15 * f, 199 - 15 * i)
                    .Name = "chkTime" & f.ToString.PadLeft(2, "0") & i.ToString.PadLeft(2, "0")
                    .Visible = True
                    .BackColor = Color.LightGray
                    .Width = 14
                    .Height = 14
                End With
                Me.Controls.Add(chk)
                AddHandler chk.Click, AddressOf chkTime_Touched
            Next
        Next

        For i = 0 To 2
            For f = 0 To 47
                Dim cck As New PictureBox
                With cck
                    .Text = ""
                    .Location = New Point(36 + 15 * f, 249 + 15 * i)
                    .Name = "cckTime" & f.ToString.PadLeft(2, "0") & i.ToString.PadLeft(2, "0")
                    .Visible = True
                    .BackColor = Color.LightGray
                    .Width = 14
                    .Height = 14
                End With
                Me.Controls.Add(cck)
                AddHandler cck.Click, AddressOf cckTime_Touched
            Next
        Next


        DirectCast(Me.Controls.Find("rbDay" & DateTime.Now.DayOfWeek, True)(0), RadioButton).Select()

        Dim Day = DateTime.Now.DayOfWeek
        For j = 0 To 47
            Dim levelHeat As Integer = activeHeatTempLocal(Day, j)
            Dim levelCool As Integer = activeCoolTempLocal(Day, j)
            If levelHeat = 1 Then
                DirectCast(Me.Controls.Find("chkTime" & j.ToString.PadLeft(2, "0") & "00", True)(0), PictureBox).BackColor = Color.Black
            ElseIf levelHeat = 2 Then
                DirectCast(Me.Controls.Find("chkTime" & j.ToString.PadLeft(2, "0") & "00", True)(0), PictureBox).BackColor = Color.Black
                DirectCast(Me.Controls.Find("chkTime" & j.ToString.PadLeft(2, "0") & "01", True)(0), PictureBox).BackColor = Color.Black
            ElseIf levelHeat = 3 Then
                DirectCast(Me.Controls.Find("chkTime" & j.ToString.PadLeft(2, "0") & "00", True)(0), PictureBox).BackColor = Color.Black
                DirectCast(Me.Controls.Find("chkTime" & j.ToString.PadLeft(2, "0") & "01", True)(0), PictureBox).BackColor = Color.Black
                DirectCast(Me.Controls.Find("chkTime" & j.ToString.PadLeft(2, "0") & "02", True)(0), PictureBox).BackColor = Color.Black
            End If
            If levelCool = 1 Then
                DirectCast(Me.Controls.Find("cckTime" & j.ToString.PadLeft(2, "0") & "00", True)(0), PictureBox).BackColor = Color.Black
            ElseIf levelCool = 2 Then
                DirectCast(Me.Controls.Find("cckTime" & j.ToString.PadLeft(2, "0") & "00", True)(0), PictureBox).BackColor = Color.Black
                DirectCast(Me.Controls.Find("cckTime" & j.ToString.PadLeft(2, "0") & "01", True)(0), PictureBox).BackColor = Color.Black
            ElseIf levelCool = 3 Then
                DirectCast(Me.Controls.Find("cckTime" & j.ToString.PadLeft(2, "0") & "00", True)(0), PictureBox).BackColor = Color.Black
                DirectCast(Me.Controls.Find("cckTime" & j.ToString.PadLeft(2, "0") & "01", True)(0), PictureBox).BackColor = Color.Black
                DirectCast(Me.Controls.Find("cckTime" & j.ToString.PadLeft(2, "0") & "02", True)(0), PictureBox).BackColor = Color.Black
            End If
        Next


    End Sub
    Private Sub chkTime_Touched(sender As Object, e As EventArgs)
        Dim weekCycleEnd As Integer
        Dim weekCycleStart As Integer
        Dim hour As Integer
        Integer.TryParse(Strings.Mid(sender.name, 8, 2), hour)

        Dim day As Integer
        For Each rb In gbDays.Controls
            If TypeOf (rb) Is RadioButton AndAlso rb.checked = True Then
                Integer.TryParse(Strings.Right(rb.name, 1), day)
            End If
        Next

        If chkDayAll.Checked Then
            weekCycleEnd = 6
            weekCycleStart = 0
        ElseIf rbFeriale.Checked Then
            weekCycleEnd = 5
            weekCycleStart = 1
            day = 1
        ElseIf rbFestivo.Checked Then
            day = 6
        End If



        If sender.backcolor = Color.LightGray Then
            sender.backcolor = Color.Black
            If Strings.Right(sender.name, 2) = "02" Then
                DirectCast(Me.Controls.Find(Strings.Left(sender.name, sender.name.length - 2) & "02", True)(0), PictureBox).BackColor = Color.Black
                DirectCast(Me.Controls.Find(Strings.Left(sender.name, sender.name.length - 2) & "01", True)(0), PictureBox).BackColor = Color.Black
                DirectCast(Me.Controls.Find(Strings.Left(sender.name, sender.name.length - 2) & "00", True)(0), PictureBox).BackColor = Color.Black
                activeHeatTempLocal(day, hour) = 3
            ElseIf Strings.Right(sender.name, 2) = "01" Then
                DirectCast(Me.Controls.Find(Strings.Left(sender.name, sender.name.length - 2) & "01", True)(0), PictureBox).BackColor = Color.Black
                DirectCast(Me.Controls.Find(Strings.Left(sender.name, sender.name.length - 2) & "00", True)(0), PictureBox).BackColor = Color.Black
                activeHeatTempLocal(day, hour) = 2
            ElseIf Strings.Right(sender.name, 2) = "00" Then
                DirectCast(Me.Controls.Find(Strings.Left(sender.name, sender.name.length - 2) & "00", True)(0), PictureBox).BackColor = Color.Black
                activeHeatTempLocal(day, hour) = 1

            End If
        Else
            sender.backcolor = Color.LightGray
            If Strings.Right(sender.name, 2) = "01" Then
                DirectCast(Me.Controls.Find(Strings.Left(sender.name, sender.name.length - 2) & "02", True)(0), PictureBox).BackColor = Color.LightGray
                DirectCast(Me.Controls.Find(Strings.Left(sender.name, sender.name.length - 2) & "01", True)(0), PictureBox).BackColor = Color.LightGray
                activeHeatTempLocal(day, hour) = 1
            ElseIf Strings.Right(sender.name, 2) = "00" Then
                DirectCast(Me.Controls.Find(Strings.Left(sender.name, sender.name.length - 2) & "02", True)(0), PictureBox).BackColor = Color.LightGray
                DirectCast(Me.Controls.Find(Strings.Left(sender.name, sender.name.length - 2) & "01", True)(0), PictureBox).BackColor = Color.LightGray
                DirectCast(Me.Controls.Find(Strings.Left(sender.name, sender.name.length - 2) & "00", True)(0), PictureBox).BackColor = Color.LightGray
                activeHeatTempLocal(day, hour) = 0
            ElseIf Strings.Right(sender.name, 2) = "02" Then
                DirectCast(Me.Controls.Find(Strings.Left(sender.name, sender.name.length - 2) & "00", True)(0), PictureBox).BackColor = Color.LightGray
                activeHeatTempLocal(day, hour) = 2
            End If
        End If

        If weekCycleEnd <> weekCycleStart Then
            For weekdays = weekCycleStart To weekCycleEnd
                activeHeatTempLocal(weekdays, hour) = activeHeatTempLocal(day, hour)
            Next
        End If

        If rbFestivo.Checked Then
            activeHeatTempLocal(0, hour) = activeHeatTempLocal(day, hour)
        End If


        MultiGenPoint3TemperatureWeeklyStrip.UpdateRequest = True

    End Sub
    Private Sub cckTime_Touched(sender As Object, e As EventArgs)
        Dim weekCycleEnd As Integer
        Dim weekCycleStart As Integer
        Dim hour As Integer
        Integer.TryParse(Strings.Mid(sender.name, 8, 2), hour)

        Dim day As Integer
        For Each rb In gbDays.Controls
            If TypeOf (rb) Is RadioButton AndAlso rb.checked = True Then
                Integer.TryParse(Strings.Right(rb.name, 1), day)
            End If
        Next

        If chkDayAll.Checked Then
            weekCycleEnd = 6
            weekCycleStart = 0
        ElseIf rbFeriale.Checked Then
            weekCycleEnd = 5
            weekCycleStart = 1
            day = 1
        ElseIf rbFestivo.Checked Then
            day = 6
        End If


        If sender.backcolor = Color.LightGray Then
            sender.backcolor = Color.Black
            If Strings.Right(sender.name, 2) = "02" Then
                DirectCast(Me.Controls.Find(Strings.Left(sender.name, sender.name.length - 2) & "02", True)(0), PictureBox).BackColor = Color.Black
                DirectCast(Me.Controls.Find(Strings.Left(sender.name, sender.name.length - 2) & "01", True)(0), PictureBox).BackColor = Color.Black
                DirectCast(Me.Controls.Find(Strings.Left(sender.name, sender.name.length - 2) & "00", True)(0), PictureBox).BackColor = Color.Black
                activeCoolTempLocal(day, hour) = 3
            ElseIf Strings.Right(sender.name, 2) = "01" Then
                DirectCast(Me.Controls.Find(Strings.Left(sender.name, sender.name.length - 2) & "01", True)(0), PictureBox).BackColor = Color.Black
                DirectCast(Me.Controls.Find(Strings.Left(sender.name, sender.name.length - 2) & "00", True)(0), PictureBox).BackColor = Color.Black
                activeCoolTempLocal(day, hour) = 2
            ElseIf Strings.Right(sender.name, 2) = "00" Then
                DirectCast(Me.Controls.Find(Strings.Left(sender.name, sender.name.length - 2) & "00", True)(0), PictureBox).BackColor = Color.Black
                activeCoolTempLocal(day, hour) = 1

            End If
        Else
            sender.backcolor = Color.LightGray
            If Strings.Right(sender.name, 2) = "01" Then
                DirectCast(Me.Controls.Find(Strings.Left(sender.name, sender.name.length - 2) & "02", True)(0), PictureBox).BackColor = Color.LightGray
                DirectCast(Me.Controls.Find(Strings.Left(sender.name, sender.name.length - 2) & "01", True)(0), PictureBox).BackColor = Color.LightGray
                activeCoolTempLocal(day, hour) = 1
            ElseIf Strings.Right(sender.name, 2) = "00" Then
                DirectCast(Me.Controls.Find(Strings.Left(sender.name, sender.name.length - 2) & "02", True)(0), PictureBox).BackColor = Color.LightGray
                DirectCast(Me.Controls.Find(Strings.Left(sender.name, sender.name.length - 2) & "01", True)(0), PictureBox).BackColor = Color.LightGray
                DirectCast(Me.Controls.Find(Strings.Left(sender.name, sender.name.length - 2) & "00", True)(0), PictureBox).BackColor = Color.LightGray
                activeCoolTempLocal(day, hour) = 0
            ElseIf Strings.Right(sender.name, 2) = "02" Then
                DirectCast(Me.Controls.Find(Strings.Left(sender.name, sender.name.length - 2) & "00", True)(0), PictureBox).BackColor = Color.LightGray
                activeCoolTempLocal(day, hour) = 2
            End If
        End If

        If weekCycleEnd <> weekCycleStart Then
            For weekdays = weekCycleStart To weekCycleEnd
                activeCoolTempLocal(weekdays, hour) = activeCoolTempLocal(day, hour)
            Next
        End If

        If rbFestivo.Checked Then
            activeCoolTempLocal(0, hour) = activeCoolTempLocal(day, hour)
        End If

        MultiGenPoint3TemperatureWeeklyStrip.UpdateRequest = True

    End Sub
    Private Sub rbDay_CheckedChanged(sender As Object, e As EventArgs) Handles rbDay1.CheckedChanged,
        rbDay2.CheckedChanged, rbDay3.CheckedChanged, rbDay4.CheckedChanged, rbDay5.CheckedChanged,
        rbDay6.CheckedChanged, rbDay0.CheckedChanged

        Dim day As Integer = Integer.Parse(Strings.Right(sender.name, 1))
        For j = 0 To 47
            Dim levelHeat As Integer = activeHeatTempLocal(day, j)
            Dim levelCool As Integer = activeCoolTempLocal(day, j)
            If levelHeat = 0 Then
                DirectCast(Me.Controls.Find("chkTime" & j.ToString.PadLeft(2, "0") & "00", True)(0), PictureBox).BackColor = Color.LightGray
                DirectCast(Me.Controls.Find("chkTime" & j.ToString.PadLeft(2, "0") & "01", True)(0), PictureBox).BackColor = Color.LightGray
                DirectCast(Me.Controls.Find("chkTime" & j.ToString.PadLeft(2, "0") & "02", True)(0), PictureBox).BackColor = Color.LightGray
            ElseIf levelHeat = 1 Then
                DirectCast(Me.Controls.Find("chkTime" & j.ToString.PadLeft(2, "0") & "00", True)(0), PictureBox).BackColor = Color.Black
                DirectCast(Me.Controls.Find("chkTime" & j.ToString.PadLeft(2, "0") & "01", True)(0), PictureBox).BackColor = Color.LightGray
                DirectCast(Me.Controls.Find("chkTime" & j.ToString.PadLeft(2, "0") & "02", True)(0), PictureBox).BackColor = Color.LightGray
            ElseIf levelHeat = 2 Then
                DirectCast(Me.Controls.Find("chkTime" & j.ToString.PadLeft(2, "0") & "00", True)(0), PictureBox).BackColor = Color.Black
                DirectCast(Me.Controls.Find("chkTime" & j.ToString.PadLeft(2, "0") & "01", True)(0), PictureBox).BackColor = Color.Black
                DirectCast(Me.Controls.Find("chkTime" & j.ToString.PadLeft(2, "0") & "02", True)(0), PictureBox).BackColor = Color.LightGray
            ElseIf levelHeat = 3 Then
                DirectCast(Me.Controls.Find("chkTime" & j.ToString.PadLeft(2, "0") & "00", True)(0), PictureBox).BackColor = Color.Black
                DirectCast(Me.Controls.Find("chkTime" & j.ToString.PadLeft(2, "0") & "01", True)(0), PictureBox).BackColor = Color.Black
                DirectCast(Me.Controls.Find("chkTime" & j.ToString.PadLeft(2, "0") & "02", True)(0), PictureBox).BackColor = Color.Black
            End If
            If levelCool = 0 Then
                DirectCast(Me.Controls.Find("cckTime" & j.ToString.PadLeft(2, "0") & "00", True)(0), PictureBox).BackColor = Color.LightGray
                DirectCast(Me.Controls.Find("cckTime" & j.ToString.PadLeft(2, "0") & "01", True)(0), PictureBox).BackColor = Color.LightGray
                DirectCast(Me.Controls.Find("cckTime" & j.ToString.PadLeft(2, "0") & "02", True)(0), PictureBox).BackColor = Color.LightGray
            ElseIf levelCool = 1 Then
                DirectCast(Me.Controls.Find("cckTime" & j.ToString.PadLeft(2, "0") & "00", True)(0), PictureBox).BackColor = Color.Black
                DirectCast(Me.Controls.Find("cckTime" & j.ToString.PadLeft(2, "0") & "01", True)(0), PictureBox).BackColor = Color.LightGray
                DirectCast(Me.Controls.Find("cckTime" & j.ToString.PadLeft(2, "0") & "02", True)(0), PictureBox).BackColor = Color.LightGray
            ElseIf levelCool = 2 Then
                DirectCast(Me.Controls.Find("cckTime" & j.ToString.PadLeft(2, "0") & "00", True)(0), PictureBox).BackColor = Color.Black
                DirectCast(Me.Controls.Find("cckTime" & j.ToString.PadLeft(2, "0") & "01", True)(0), PictureBox).BackColor = Color.Black
                DirectCast(Me.Controls.Find("cckTime" & j.ToString.PadLeft(2, "0") & "02", True)(0), PictureBox).BackColor = Color.LightGray
            ElseIf levelCool = 3 Then
                DirectCast(Me.Controls.Find("cckTime" & j.ToString.PadLeft(2, "0") & "00", True)(0), PictureBox).BackColor = Color.Black
                DirectCast(Me.Controls.Find("cckTime" & j.ToString.PadLeft(2, "0") & "01", True)(0), PictureBox).BackColor = Color.Black
                DirectCast(Me.Controls.Find("cckTime" & j.ToString.PadLeft(2, "0") & "02", True)(0), PictureBox).BackColor = Color.Black
            End If
        Next

    End Sub
    Private Sub btnSaveWeekly_Click(sender As Object, e As EventArgs) Handles btnSaveWeekly.Click
        Try
            Dim temp As New weeklyScheduler
            Array.Copy(activeHeatTempLocal, temp.activeHeatTemp, activeHeatTempLocal.Length)
            Array.Copy(activeCoolTempLocal, temp.activeCoolTemp, activeCoolTempLocal.Length)

            temp.coolPB = nupCoolBP.Value
            temp.heatPB = nupHeatBP.Value
            temp.setpointCoolT1 = nupCoolT1.Value
            temp.setpointCoolT2 = nupCoolT2.Value
            temp.setpointCoolT3 = nupCoolT3.Value
            temp.setpointHeatT1 = nupHeatT1.Value
            temp.setpointHeatT2 = nupHeatT2.Value
            temp.setpointHeatT3 = nupHeatT3.Value
            temp.freezeProtSetpoint = nupFrostProt.Value
            temp.ecoCoolIncrease = nupCoolEco.Value
            temp.ecoHeatReduction = nupHeatEco.Value


            Dim bf As New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter

            Dim sfd As New SaveFileDialog
            Dim filename As String
            sfd.Filter = "mgp files (*.mgp)|*.mgp|Tutti i files (*.*)|*.*"
            If sfd.ShowDialog = DialogResult.OK Then
                filename = sfd.FileName
            Else
                Exit Sub
            End If

            Dim fStream As New FileStream(filename, FileMode.Create)

            bf.Serialize(fStream, temp) ' write to file

            fStream.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub
    Private Sub btnLoadWeekly_Click(sender As Object, e As EventArgs) Handles btnLoadWeekly.Click

        Cancel_Button.Enabled = False

        Try
            Dim bf As New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter
            Dim ofd As New OpenFileDialog
            Dim filename As String
            ofd.Filter = "mgp files (*.mgp)|*.mgp|Tutti i files (*.*)|*.*"
            If ofd.ShowDialog = DialogResult.OK Then
                filename = ofd.FileName
            Else
                Exit Sub
            End If
            Dim fStream As New FileStream(filename, FileMode.Open)

            Dim bftemp As weeklyScheduler = bf.Deserialize(fStream) ' read from file
            dlgWeeklyScheduler = bftemp

            ReDim activeHeatTempLocal(6, 47)
            activeHeatTempLocal = dlgWeeklyScheduler.activeHeatTemp
            ReDim activeCoolTempLocal(6, 47)
            activeCoolTempLocal = dlgWeeklyScheduler.activeCoolTemp


            fStream.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        For j = 0 To 47
            DirectCast(Me.Controls.Find("chkTime" & j.ToString.PadLeft(2, "0") & "00", True)(0), PictureBox).BackColor = Color.LightGray
            DirectCast(Me.Controls.Find("cckTime" & j.ToString.PadLeft(2, "0") & "00", True)(0), PictureBox).BackColor = Color.LightGray
            DirectCast(Me.Controls.Find("chkTime" & j.ToString.PadLeft(2, "0") & "01", True)(0), PictureBox).BackColor = Color.LightGray
            DirectCast(Me.Controls.Find("cckTime" & j.ToString.PadLeft(2, "0") & "01", True)(0), PictureBox).BackColor = Color.LightGray
            DirectCast(Me.Controls.Find("chkTime" & j.ToString.PadLeft(2, "0") & "02", True)(0), PictureBox).BackColor = Color.LightGray
            DirectCast(Me.Controls.Find("cckTime" & j.ToString.PadLeft(2, "0") & "02", True)(0), PictureBox).BackColor = Color.LightGray
        Next


        For j = 0 To 47
            Dim levelHeat As Integer = dlgWeeklyScheduler.activeHeatTemp(DateTime.Now.DayOfWeek, j)
            Dim levelCool As Integer = dlgWeeklyScheduler.activeCoolTemp(DateTime.Now.DayOfWeek, j)
            If levelHeat = 1 Then
                DirectCast(Me.Controls.Find("chkTime" & j.ToString.PadLeft(2, "0") & "00", True)(0), PictureBox).BackColor = Color.Black
            ElseIf levelHeat = 2 Then
                DirectCast(Me.Controls.Find("chkTime" & j.ToString.PadLeft(2, "0") & "00", True)(0), PictureBox).BackColor = Color.Black
                DirectCast(Me.Controls.Find("chkTime" & j.ToString.PadLeft(2, "0") & "01", True)(0), PictureBox).BackColor = Color.Black
            ElseIf levelHeat = 3 Then
                DirectCast(Me.Controls.Find("chkTime" & j.ToString.PadLeft(2, "0") & "00", True)(0), PictureBox).BackColor = Color.Black
                DirectCast(Me.Controls.Find("chkTime" & j.ToString.PadLeft(2, "0") & "01", True)(0), PictureBox).BackColor = Color.Black
                DirectCast(Me.Controls.Find("chkTime" & j.ToString.PadLeft(2, "0") & "02", True)(0), PictureBox).BackColor = Color.Black
            End If
            If levelCool = 1 Then
                DirectCast(Me.Controls.Find("cckTime" & j.ToString.PadLeft(2, "0") & "00", True)(0), PictureBox).BackColor = Color.Black
            ElseIf levelCool = 2 Then
                DirectCast(Me.Controls.Find("cckTime" & j.ToString.PadLeft(2, "0") & "00", True)(0), PictureBox).BackColor = Color.Black
                DirectCast(Me.Controls.Find("cckTime" & j.ToString.PadLeft(2, "0") & "01", True)(0), PictureBox).BackColor = Color.Black
            ElseIf levelCool = 3 Then
                DirectCast(Me.Controls.Find("cckTime" & j.ToString.PadLeft(2, "0") & "00", True)(0), PictureBox).BackColor = Color.Black
                DirectCast(Me.Controls.Find("cckTime" & j.ToString.PadLeft(2, "0") & "01", True)(0), PictureBox).BackColor = Color.Black
                DirectCast(Me.Controls.Find("cckTime" & j.ToString.PadLeft(2, "0") & "02", True)(0), PictureBox).BackColor = Color.Black
            End If
        Next

        nupCoolBP.Value = dlgWeeklyScheduler.coolPB
        nupHeatBP.Value = dlgWeeklyScheduler.heatPB
        nupCoolT1.Value = dlgWeeklyScheduler.setpointCoolT1
        nupCoolT2.Value = dlgWeeklyScheduler.setpointCoolT2
        nupCoolT3.Value = dlgWeeklyScheduler.setpointCoolT3
        nupHeatT1.Value = dlgWeeklyScheduler.setpointHeatT1
        nupHeatT2.Value = dlgWeeklyScheduler.setpointHeatT2
        nupHeatT3.Value = dlgWeeklyScheduler.setpointHeatT3
        nupFrostProt.Value = dlgWeeklyScheduler.freezeProtSetpoint
        nupCoolEco.Value = dlgWeeklyScheduler.ecoCoolIncrease
        nupHeatEco.Value = dlgWeeklyScheduler.ecoHeatReduction

        MultiGenPoint3TemperatureWeeklyStrip.UpdateRequest = True

    End Sub
    Private Sub btnCopyForth_Click(sender As Object, e As EventArgs) Handles btnCopyForth.Click

        Dim today As Integer
        Dim tomorrow As Integer
        For Each rb In gbDays.Controls
            If TypeOf (rb) Is RadioButton AndAlso rb.checked = True Then
                today = Integer.Parse(Strings.Right(rb.name, 1))
            End If
        Next
        If today = 6 Then
            tomorrow = 0
        Else
            tomorrow = today + 1
        End If


        For j = 0 To 47
            activeHeatTempLocal(tomorrow, j) = activeHeatTempLocal(today, j)
            activeCoolTempLocal(tomorrow, j) = activeCoolTempLocal(today, j)
        Next

        DirectCast(gbDays.Controls.Find("rbDay" & tomorrow.ToString, True)(0), RadioButton).Select()

    End Sub
    Private Sub btnCopyBack_Click(sender As Object, e As EventArgs) Handles btnCopyBack.Click
        Dim today As Integer
        Dim yesterday As Integer
        For Each rb In gbDays.Controls
            If TypeOf (rb) Is RadioButton AndAlso rb.checked = True Then
                today = Integer.Parse(Strings.Right(rb.name, 1))
            End If
        Next
        If today = 0 Then
            yesterday = 6
        Else
            yesterday = today - 1
        End If


        For j = 0 To 47
            activeHeatTempLocal(yesterday, j) = activeHeatTempLocal(today, j)
            activeCoolTempLocal(yesterday, j) = activeCoolTempLocal(today, j)
        Next

        DirectCast(gbDays.Controls.Find("rbDay" & yesterday.ToString, True)(0), RadioButton).Select()

    End Sub
    Private Sub btnEmptyWeek_Click(sender As Object, e As EventArgs) Handles btnEmptyWeek.Click
        For i = 0 To 6
            For j = 0 To 47
                activeHeatTempLocal(i, j) = 0
                activeCoolTempLocal(i, j) = 0
            Next
        Next
        For Each pb In Me.Controls
            If TypeOf (pb) Is PictureBox And pb.Height = 14 And pb.Width = 14 Then
                pb.backcolor = Color.LightGray
            End If
        Next

    End Sub
End Class
