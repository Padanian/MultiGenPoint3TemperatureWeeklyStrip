Imports System.Windows.Forms

Public Class dlgTemperatureCalendar
    Dim activeHeatTempLocal As Integer(,)
    Dim activeCoolTempLocal As Integer(,)
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Array.Copy(activeHeatTempLocal, MultiGenPoint3TemperatureWeeklyStrip.myWeeklySchedule.activeHeatTemp, activeHeatTempLocal.Length)
        Array.Copy(activeCoolTempLocal, MultiGenPoint3TemperatureWeeklyStrip.myWeeklySchedule.activeCoolTemp, activeCoolTempLocal.Length)

        MultiGenPoint3TemperatureWeeklyStrip.myWeeklySchedule.coolPB = nupCoolBP.Value
        MultiGenPoint3TemperatureWeeklyStrip.myWeeklySchedule.heatPB = nupHeatBP.Value
        MultiGenPoint3TemperatureWeeklyStrip.myWeeklySchedule.setpointCoolT1 = nupCoolT1.Value
        MultiGenPoint3TemperatureWeeklyStrip.myWeeklySchedule.setpointCoolT2 = nupCoolT2.Value
        MultiGenPoint3TemperatureWeeklyStrip.myWeeklySchedule.setpointCoolT3 = nupCoolT3.Value
        MultiGenPoint3TemperatureWeeklyStrip.myWeeklySchedule.setpointHeatT1 = nupHeatT1.Value
        MultiGenPoint3TemperatureWeeklyStrip.myWeeklySchedule.setpointHeatT2 = nupHeatT2.Value
        MultiGenPoint3TemperatureWeeklyStrip.myWeeklySchedule.setpointHeatT3 = nupHeatT3.Value
        MultiGenPoint3TemperatureWeeklyStrip.myWeeklySchedule.freezeProtSetpoint = nupFrostProt.Value
        MultiGenPoint3TemperatureWeeklyStrip.myWeeklySchedule.ecoCoolIncrease = nupCoolEco.Value
        MultiGenPoint3TemperatureWeeklyStrip.myWeeklySchedule.ecoHeatReduction = nupHeatEco.Value

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub rbDayAll_CheckedChanged(sender As Object, e As EventArgs) Handles chkDayAll.CheckedChanged
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
        ReDim activeCoolTempLocal(6, 47)

        Array.Copy(MultiGenPoint3TemperatureWeeklyStrip.myWeeklySchedule.activeHeatTemp, activeHeatTempLocal, activeHeatTempLocal.Length)
        Array.Copy(MultiGenPoint3TemperatureWeeklyStrip.myWeeklySchedule.activeCoolTemp, activeCoolTempLocal, activeCoolTempLocal.Length)

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

        nupCoolBP.Value = MultiGenPoint3TemperatureWeeklyStrip.myWeeklySchedule.coolPB
        nupHeatBP.Value = MultiGenPoint3TemperatureWeeklyStrip.myWeeklySchedule.heatPB
        nupCoolT1.Value = MultiGenPoint3TemperatureWeeklyStrip.myWeeklySchedule.setpointCoolT1
        nupCoolT2.Value = MultiGenPoint3TemperatureWeeklyStrip.myWeeklySchedule.setpointCoolT2
        nupCoolT3.Value = MultiGenPoint3TemperatureWeeklyStrip.myWeeklySchedule.setpointCoolT3
        nupHeatT1.Value = MultiGenPoint3TemperatureWeeklyStrip.myWeeklySchedule.setpointHeatT1
        nupHeatT2.Value = MultiGenPoint3TemperatureWeeklyStrip.myWeeklySchedule.setpointHeatT2
        nupHeatT3.Value = MultiGenPoint3TemperatureWeeklyStrip.myWeeklySchedule.setpointHeatT3
        nupFrostProt.Value = MultiGenPoint3TemperatureWeeklyStrip.myWeeklySchedule.freezeProtSetpoint
        nupCoolEco.Value = MultiGenPoint3TemperatureWeeklyStrip.myWeeklySchedule.ecoCoolIncrease
        nupHeatEco.Value = MultiGenPoint3TemperatureWeeklyStrip.myWeeklySchedule.ecoHeatReduction

    End Sub
    Private Sub chkTime_Touched(sender As Object, e As EventArgs)
        Dim day As Integer
        For Each rb In gbDays.Controls
            If TypeOf (rb) Is RadioButton AndAlso rb.checked = True Then
                day = Integer.Parse(Strings.Right(rb.name, 1))
            End If
        Next

        If sender.backcolor = Color.LightGray Then
            sender.backcolor = Color.Black
            If Strings.Right(sender.name, 2) = "02" Then
                DirectCast(Me.Controls.Find(Strings.Left(sender.name, sender.name.length - 2) & "01", True)(0), PictureBox).BackColor = Color.Black
                DirectCast(Me.Controls.Find(Strings.Left(sender.name, sender.name.length - 2) & "00", True)(0), PictureBox).BackColor = Color.Black
                activeHeatTempLocal(day, CInt(Strings.Mid(sender.name, 8, 2))) = 3
            ElseIf Strings.Right(sender.name, 2) = "01" Then
                DirectCast(Me.Controls.Find(Strings.Left(sender.name, sender.name.length - 2) & "00", True)(0), PictureBox).BackColor = Color.Black
                activeHeatTempLocal(day, CInt(Strings.Mid(sender.name, 8, 2))) = 2
            ElseIf Strings.Right(sender.name, 2) = "00" Then
                activeHeatTempLocal(day, CInt(Strings.Mid(sender.name, 8, 2))) = 1

            End If
        Else
            sender.backcolor = Color.LightGray
            If Strings.Right(sender.name, 2) = "01" Then
                DirectCast(Me.Controls.Find(Strings.Left(sender.name, sender.name.length - 2) & "02", True)(0), PictureBox).BackColor = Color.LightGray
                activeHeatTempLocal(day, CInt(Strings.Mid(sender.name, 8, 2))) = 1
            ElseIf Strings.Right(sender.name, 2) = "00" Then
                DirectCast(Me.Controls.Find(Strings.Left(sender.name, sender.name.length - 2) & "02", True)(0), PictureBox).BackColor = Color.LightGray
                DirectCast(Me.Controls.Find(Strings.Left(sender.name, sender.name.length - 2) & "01", True)(0), PictureBox).BackColor = Color.LightGray
                activeHeatTempLocal(day, CInt(Strings.Mid(sender.name, 8, 2))) = 0
            ElseIf Strings.Right(sender.name, 2) = "02" Then
                activeHeatTempLocal(day, CInt(Strings.Mid(sender.name, 8, 2))) = 2
            End If
        End If
    End Sub
    Private Sub cckTime_Touched(sender As Object, e As EventArgs)
        Dim day As Integer
        For Each rb In gbDays.Controls
            If TypeOf (rb) Is RadioButton AndAlso rb.checked = True Then
                day = Integer.Parse(Strings.Right(rb.name, 1))
            End If
        Next


        If sender.backcolor = Color.LightGray Then
            sender.backcolor = Color.Black
            If Strings.Right(sender.name, 2) = "02" Then
                DirectCast(Me.Controls.Find(Strings.Left(sender.name, sender.name.length - 2) & "01", True)(0), PictureBox).BackColor = Color.Black
                DirectCast(Me.Controls.Find(Strings.Left(sender.name, sender.name.length - 2) & "00", True)(0), PictureBox).BackColor = Color.Black
                activeCoolTempLocal(day, CInt(Strings.Mid(sender.name, 8, 2))) = 3
            ElseIf Strings.Right(sender.name, 2) = "01" Then
                DirectCast(Me.Controls.Find(Strings.Left(sender.name, sender.name.length - 2) & "00", True)(0), PictureBox).BackColor = Color.Black
                activeCoolTempLocal(day, CInt(Strings.Mid(sender.name, 8, 2))) = 2
            ElseIf Strings.Right(sender.name, 2) = "00" Then
                activeCoolTempLocal(day, CInt(Strings.Mid(sender.name, 8, 2))) = 1

            End If
        Else
            sender.backcolor = Color.LightGray
            If Strings.Right(sender.name, 2) = "01" Then
                DirectCast(Me.Controls.Find(Strings.Left(sender.name, sender.name.length - 2) & "02", True)(0), PictureBox).BackColor = Color.LightGray
                activeCoolTempLocal(day, CInt(Strings.Mid(sender.name, 8, 2))) = 1
            ElseIf Strings.Right(sender.name, 2) = "00" Then
                DirectCast(Me.Controls.Find(Strings.Left(sender.name, sender.name.length - 2) & "02", True)(0), PictureBox).BackColor = Color.LightGray
                DirectCast(Me.Controls.Find(Strings.Left(sender.name, sender.name.length - 2) & "01", True)(0), PictureBox).BackColor = Color.LightGray
                activeCoolTempLocal(day, CInt(Strings.Mid(sender.name, 8, 2))) = 0
            ElseIf Strings.Right(sender.name, 2) = "02" Then
                activeCoolTempLocal(day, CInt(Strings.Mid(sender.name, 8, 2))) = 2
            End If
        End If

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

End Class
