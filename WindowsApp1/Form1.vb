Imports System.IO
Imports MultiGenPoint3TemperatureWeeklyStrip.MultiGenPoint3TemperatureWeeklyStrip

Public Class Form1
    Dim MultiGen1 As New MultiGenPoint3TemperatureWeeklyStrip.MultiGenPoint3TemperatureWeeklyStrip
    Dim MultiGen2 As New MultiGenPoint3TemperatureWeeklyStrip.MultiGenPoint3TemperatureWeeklyStrip
    Dim MultiGen3 As New MultiGenPoint3TemperatureWeeklyStrip.MultiGenPoint3TemperatureWeeklyStrip



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        With MultiGen1
            .Location = New Point(50, 50)
        End With

        With MultiGen2
            .Location = New Point(50, 200)
        End With

        With MultiGen3
            .Location = New Point(50, 350)
        End With

        Me.Controls.Add(MultiGen1)
        Me.Controls.Add(MultiGen2)
        Me.Controls.Add(MultiGen3)

    End Sub
End Class
