Imports System.Windows.Forms

Public Class dlgTemperatureCalendar

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub rbDayAll_CheckedChanged(sender As Object, e As EventArgs) Handles chkDayAll.CheckedChanged
        If chkDayAll.Checked = True Then
            For i = 1 To 7
                DirectCast(Me.Controls.Find("rbDay" & i, True)(0), RadioButton).Enabled = False
            Next
            rbDay1_5.Enabled = False
            rbDay6_7.Enabled = False
        Else
            For i = 1 To 7
                DirectCast(Me.Controls.Find("rbDay" & i, True)(0), RadioButton).Enabled = True
            Next
            rbDay1_5.Enabled = True
            rbDay6_7.Enabled = True
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

        For i = 1 To 23
            Dim lbl As New Label
            With lbl
                .Text = i.ToString.PadLeft(2, "0")
                .Location = New Point(30 + 30 * i, 215)
                .Name = "lblTime" & i.ToString
                .Visible = True
                .ForeColor = Color.Black
                .Width = 16
                .Height = 16
            End With
            Me.Controls.Add(lbl)
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
        DirectCast(Me.Controls.Find("rbDay" & DateTime.Now.DayOfWeek, True)(0), RadioButton).Select()

        For j = 0 To 47
            Dim level As Integer = MultiGenPoint3TemperatureWeeklyStrip.myWeeklySchedule.activeTemp(DateTime.Now.DayOfWeek - 1, j)
            If level = 1 Then
                DirectCast(Me.Controls.Find("chkTime" & j.ToString.PadLeft(2, "0") & "00", True)(0), PictureBox).BackColor = Color.Black
            ElseIf level = 2 Then
                DirectCast(Me.Controls.Find("chkTime" & j.ToString.PadLeft(2, "0") & "00", True)(0), PictureBox).BackColor = Color.Black
                DirectCast(Me.Controls.Find("chkTime" & j.ToString.PadLeft(2, "0") & "01", True)(0), PictureBox).BackColor = Color.Black
            ElseIf level = 3 Then
                DirectCast(Me.Controls.Find("chkTime" & j.ToString.PadLeft(2, "0") & "00", True)(0), PictureBox).BackColor = Color.Black
                DirectCast(Me.Controls.Find("chkTime" & j.ToString.PadLeft(2, "0") & "01", True)(0), PictureBox).BackColor = Color.Black
                DirectCast(Me.Controls.Find("chkTime" & j.ToString.PadLeft(2, "0") & "02", True)(0), PictureBox).BackColor = Color.Black
            End If
        Next

    End Sub
    Private Sub chkTime_Touched(sender As Object, e As EventArgs)
        If sender.backcolor = Color.LightGray Then
            sender.backcolor = Color.Black
            If Strings.Right(sender.name, 2) = "02" Then
                DirectCast(Me.Controls.Find(Strings.Left(sender.name, sender.name.length - 2) & "01", True)(0), PictureBox).BackColor = Color.Black
                DirectCast(Me.Controls.Find(Strings.Left(sender.name, sender.name.length - 2) & "00", True)(0), PictureBox).BackColor = Color.Black
            ElseIf Strings.Right(sender.name, 2) = "01" Then
                DirectCast(Me.Controls.Find(Strings.Left(sender.name, sender.name.length - 2) & "00", True)(0), PictureBox).BackColor = Color.Black
            End If
        Else
            sender.backcolor = Color.LightGray
        End If
    End Sub

    Private Sub rbDay_CheckedChanged(sender As Object, e As EventArgs) Handles rbDay1.CheckedChanged,
        rbDay2.CheckedChanged, rbDay3.CheckedChanged, rbDay4.CheckedChanged, rbDay5.CheckedChanged,
        rbDay6.CheckedChanged, rbDay7.CheckedChanged

        Dim day As Integer = Integer.Parse(Strings.Right(sender.name, 1))
        For j = 0 To 47
            Dim level As Integer = MultiGenPoint3TemperatureWeeklyStrip.myWeeklySchedule.activeTemp(day - 1, j)
            If level = 0 Then
                DirectCast(Me.Controls.Find("chkTime" & j.ToString.PadLeft(2, "0") & "00", True)(0), PictureBox).BackColor = Color.LightGray
                DirectCast(Me.Controls.Find("chkTime" & j.ToString.PadLeft(2, "0") & "01", True)(0), PictureBox).BackColor = Color.LightGray
                DirectCast(Me.Controls.Find("chkTime" & j.ToString.PadLeft(2, "0") & "02", True)(0), PictureBox).BackColor = Color.LightGray
            ElseIf level = 1 Then
                DirectCast(Me.Controls.Find("chkTime" & j.ToString.PadLeft(2, "0") & "00", True)(0), PictureBox).BackColor = Color.Black
                DirectCast(Me.Controls.Find("chkTime" & j.ToString.PadLeft(2, "0") & "01", True)(0), PictureBox).BackColor = Color.LightGray
                DirectCast(Me.Controls.Find("chkTime" & j.ToString.PadLeft(2, "0") & "02", True)(0), PictureBox).BackColor = Color.LightGray
            ElseIf level = 2 Then
                DirectCast(Me.Controls.Find("chkTime" & j.ToString.PadLeft(2, "0") & "00", True)(0), PictureBox).BackColor = Color.Black
                DirectCast(Me.Controls.Find("chkTime" & j.ToString.PadLeft(2, "0") & "01", True)(0), PictureBox).BackColor = Color.Black
                DirectCast(Me.Controls.Find("chkTime" & j.ToString.PadLeft(2, "0") & "02", True)(0), PictureBox).BackColor = Color.LightGray
            ElseIf level = 3 Then
                DirectCast(Me.Controls.Find("chkTime" & j.ToString.PadLeft(2, "0") & "00", True)(0), PictureBox).BackColor = Color.Black
                DirectCast(Me.Controls.Find("chkTime" & j.ToString.PadLeft(2, "0") & "01", True)(0), PictureBox).BackColor = Color.Black
                DirectCast(Me.Controls.Find("chkTime" & j.ToString.PadLeft(2, "0") & "02", True)(0), PictureBox).BackColor = Color.Black
            End If
        Next

    End Sub


End Class
