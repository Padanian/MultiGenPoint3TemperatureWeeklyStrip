
Public Class Form1
    Dim MultiGenPointDailyStrip1 As New MultiGenPointDailyStrip.MultiGenPointDailyStrip

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        With MultiGenPointDailyStrip1
            .Location = New Point(50, 50)
        End With
        MultiGenPointDailyStrip1.Settings(#01:30#.AddMinutes(120 * Rnd()),
                                          #06:00#.AddMinutes(120 * Rnd()),
                                          #07:30#.AddMinutes(120 * Rnd()),
                                          #12:30#.AddMinutes(120 * Rnd()),
                                          #15:30#.AddMinutes(120 * Rnd()),
                                          #20:30#.AddMinutes(120 * Rnd()))
        Me.Controls.Add(MultiGenPointDailyStrip1)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
