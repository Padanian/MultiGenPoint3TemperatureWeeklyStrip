Public Class MultiGenPointCalendarStrip
    Dim pbBoxes As PictureBox() = New PictureBox(287) {}
    Public Sub New()
        InitializeComponent()
        For i = 0 To 287
            If i = 0 Or i = 287 Then
                Dim pbTick As PictureBox = New PictureBox
                With pbTick
                    .Width = 1
                    .Height = 30
                    .Location = New Point(Me.Location.X + i, Me.Location.Y)
                    .BackColor = Color.Black
                    .Visible = True
                End With
                Me.Controls.Add(pbTick)
            ElseIf i Mod 12 = 0 Then
                Dim pbTick As PictureBox = New PictureBox
                With pbTick
                    .Width = 1
                    .Height = 8
                    .Location = New Point(Me.Location.X + i, Me.Location.Y + 14)
                    .BackColor = Color.Black
                    .Visible = True
                End With
                Me.Controls.Add(pbTick)
            End If
            pbBoxes(i) = New PictureBox
            If i <> 0 Then
                With pbBoxes(i)
                    .Width = 1
                    .Height = 8
                    .Location = New Point(Me.Location.X + i, Me.Location.Y + 22)
                    .BackColor = Color.Transparent
                    .Visible = True
                End With
                Me.Controls.Add(pbBoxes(i))
            End If
        Next
        Dim lbl04 As New Label
        With lbl04
            .Text = "04"
            .Location = New Point(12 * 3 + 4, 0)
            .Visible = True
            .Width = 16
        End With
        Me.Controls.Add(lbl04)
        Dim lbl08 As New Label
        With lbl08
            .Text = "08"
            .Location = New Point(12 * 7 + 4, 0)
            .Visible = True
            .Width = 16
        End With
        Me.Controls.Add(lbl08)
        Dim lbl12 As New Label
        With lbl12
            .Text = "12"
            .Location = New Point(12 * 11 + 4, 0)
            .Visible = True
            .Width = 16
        End With
        Me.Controls.Add(lbl12)
        Dim lbl16 As New Label
        With lbl16
            .Text = "16"
            .Location = New Point(12 * 15 + 4, 0)
            .Visible = True
            .Width = 16
        End With
        Me.Controls.Add(lbl16)
        Dim lbl20 As New Label
        With lbl20
            .Text = "20"
            .Location = New Point(12 * 19 + 4, 0)
            .Visible = True
            .Width = 20
        End With
        Me.Controls.Add(lbl20)
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
            ElseIf i >= F2On And i <= F2Off Then
                pbBoxes(i).BackColor = Color.Black
            ElseIf i >= F3On And i <= F3Off Then
                pbBoxes(i).BackColor = Color.Black
            Else
                pbBoxes(i).BackColor = Color.Transparent
            End If
        Next
    End Sub


End Class
