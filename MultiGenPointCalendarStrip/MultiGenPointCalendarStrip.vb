Public Class MultiGenPointCalendarStrip
    Dim pbBoxes As PictureBox() = New PictureBox(287) {}
    Private Sub New()
        For i = 0 To 287
            pbBoxes(i) = New PictureBox
            With pbBoxes(i)
                .Width = 1
                .Height = 8
                .Location = New Point(Me.Location.X + i, Me.Location.Y)
                .BackColor = Color.Transparent
                .Visible = True
            End With
            Me.Controls.Add(pbBoxes(i))
        Next
    End Sub
    ''' <summary>
    ''' Controllo numerico in combinazione tra trackbar e label
    ''' </summary>
    ''' <param name="F1On">Inizio prima fascia in multipli di 5 minuti (es.: 14 = 1h10')</param>
    ''' <param name="F1Off">Fine prima fascia in multipli di 5 minuti (es.: 14 = 1h10')</param>
    ''' <param name="F2On">Inizio seconda fascia in multipli di 5 minuti (es.: 14 = 1h10')</param>
    ''' <param name="F2Off">Fine seconda fascia in multipli di 5 minuti (es.: 14 = 1h10')</param>
    ''' <param name="F3On">Inizio terza fascia in multipli di 5 minuti (es.: 14 = 1h10')</param>
    ''' <param name="F3Off">Fine quarta fascia in multipli di 5 minuti (es.: 14 = 1h10')</param>
    ''' <remarks></remarks>

    Public Sub Settings(ByVal F1On As Integer,
                         F1Off As Integer,
                         F2On As Integer,
                         F2Off As Integer,
                         F3On As Integer,
                         F3Off As Integer)

        If F1On > F1Off Or (F1On = 0 And F1Off = 0) Then
            MsgBox("Fascia oraria F1 non impostata correttamente")
            Exit Sub
        End If
        If F2On > F2Off Then
            MsgBox("Fascia oraria F2 non impostata correttamente")
            Exit Sub
        End If
        If F3On > F3Off Then
            MsgBox("Fascia oraria F3 non impostata correttamente")
            Exit Sub
        End If

        For i = 0 To 287
            If i >= F1On And i <= F1Off Then
                pbBoxes(i).BackColor = Color.Black
            Else
                pbBoxes(i).BackColor = Color.Transparent
            End If
            If i >= F2On And i <= F2Off Then
                pbBoxes(i).BackColor = Color.Black
            Else
                pbBoxes(i).BackColor = Color.Transparent
            End If
            If i >= F3On And i <= F3Off Then
                pbBoxes(i).BackColor = Color.Black
            Else
                pbBoxes(i).BackColor = Color.Transparent
            End If
        Next

    End Sub

End Class
