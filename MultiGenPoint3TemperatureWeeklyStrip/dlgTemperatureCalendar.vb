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
        Else
            For i = 1 To 7
                DirectCast(Me.Controls.Find("rbDay" & i, True)(0), RadioButton).Enabled = True
            Next
        End If
    End Sub

    Private Sub dlgTemperatureCalendar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each lbl In Me.Controls
            If TypeOf (lbl) Is Label And lbl.name.contains("lblTime") Then
                lbl.dispose
            End If
            If TypeOf (lbl) Is CheckBox And lbl.name.contains("chkTime") Then
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
                .Location = New Point(44 + 30 * i, 212)
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
                Dim chk As New CheckBox
                With chk
                    .Text = ""
                    .Location = New Point(52 + 15 * f, 165 + 15 * i)
                    .Name = "chkTime" & f.ToString.PadLeft(2, "0") & i.ToString.PadLeft(2, "0")
                    .Visible = True
                    .ForeColor = Color.Black
                    .Width = 15
                    .Height = 14
                End With
                Me.Controls.Add(chk)
            Next
        Next


    End Sub
End Class
