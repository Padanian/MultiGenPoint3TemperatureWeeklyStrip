Public Class MultiGenPointDailyStrip
    Public Sub New()
        InitializeComponent()
        For i = 0 To 288 Step 12
            Dim disp As Integer
            If i = 288 Then
                disp = i - 1
            Else
                disp = i
            End If
            If i = 0 Or i = 288 Then
                Dim pbTick As PictureBox = New PictureBox
                With pbTick
                    .Width = 1
                    .Height = 30
                    .Location = New Point(Me.Location.X + disp, Me.Location.Y)
                    .BackColor = Color.Black
                    .Visible = True
                End With
                Me.Controls.Add(pbTick)
            Else
                Dim pbTick As PictureBox = New PictureBox
                With pbTick
                    .Width = 1
                    .Height = 8
                    .Location = New Point(Me.Location.X + disp, Me.Location.Y + 14)
                    .BackColor = Color.Black
                    .Visible = True
                End With
                Me.Controls.Add(pbTick)
            End If
        Next
        Dim lbl04 As New Label
        With lbl04
            .Text = "04"
            .Location = New Point(12 * 3 + 4, 0)
            .Visible = True
            .Width = 20
            .Height = 12
        End With
        Me.Controls.Add(lbl04)
        Dim lbl08 As New Label
        With lbl08
            .Text = "08"
            .Location = New Point(12 * 7 + 4, 0)
            .Visible = True
            .Width = 20
            .Height = 12
        End With
        Me.Controls.Add(lbl08)
        Dim lbl12 As New Label
        With lbl12
            .Text = "12"
            .Location = New Point(12 * 11 + 4, 0)
            .Visible = True
            .Width = 20
            .Height = 12
        End With
        Me.Controls.Add(lbl12)
        Dim lbl16 As New Label
        With lbl16
            .Text = "16"
            .Location = New Point(12 * 15 + 4, 0)
            .Visible = True
            .Width = 20
            .Height = 12
        End With
        Me.Controls.Add(lbl16)
        Dim lbl20 As New Label
        With lbl20
            .Text = "20"
            .Location = New Point(12 * 19 + 4, 0)
            .Visible = True
            .Width = 20
            .Height = 12
        End With
        Me.Controls.Add(lbl20)
    End Sub
    ''' <summary>
    ''' Controllo numerico in combinazione tra trackbar e label
    ''' </summary>
    ''' <param name="dF1On">Inizio prima fascia</param>
    ''' <param name="dF1Off">Fine prima fascia</param>
    ''' <param name="dF2On">Inizio seconda fascia)</param>
    ''' <param name="dF2Off">Fine seconda fascia</param>
    ''' <param name="dF3On">Inizio terza fascia</param>
    ''' <param name="dF3Off">Fine quarta fascia</param>
    ''' <remarks></remarks>

    Public Sub Settings(ByVal dF1On As DateTime,
                         dF1Off As DateTime,
                         dF2On As DateTime,
                         dF2Off As DateTime,
                         dF3On As DateTime,
                         dF3Off As DateTime)

        Dim F1On As Integer = dF1On.Hour * 12 + dF1On.Minute \ 5
        Dim F1Off As Integer = dF1Off.Hour * 12 + dF1Off.Minute \ 5
        Dim F2On As Integer = dF2On.Hour * 12 + dF2On.Minute \ 5
        Dim F2Off As Integer = dF2Off.Hour * 12 + dF2Off.Minute \ 5
        Dim F3On As Integer = dF3On.Hour * 12 + dF3On.Minute \ 5
        Dim F3Off As Integer = dF3Off.Hour * 12 + dF3Off.Minute \ 5

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

        For Each ctr In Me.Controls
            If TypeOf (ctr) Is PictureBox Then
                If ctr.tag?.contains("pbSquares") Then
                    ctr.dispose
                End If
            End If
        Next

        Application.DoEvents()

        Dim pbSquares1 As PictureBox = New PictureBox
        With pbSquares1
            .Width = (F1Off - F1On)
            .Height = 8
            .Location = New Point(.Location.X + F1On, .Location.Y + 22)
            .BackColor = Color.Black
            .Visible = True
            .Tag = "pbSquares1"
        End With
        Me.Controls.Add(pbSquares1)

        Dim pbSquares2 As PictureBox = New PictureBox
        With pbSquares2
            .Width = (F2Off - F2On)
            .Height = 8
            .Location = New Point(.Location.X + F2On, .Location.Y + 22)
            .BackColor = Color.Black
            .Visible = True
            .Tag = "pbSquares2"
        End With
        Me.Controls.Add(pbSquares2)

        Dim pbSquares3 As PictureBox = New PictureBox
        With pbSquares3
            .Width = (F3Off - F3On)
            .Height = 8
            .Location = New Point(.Location.X + F3On, .Location.Y + 22)
            .BackColor = Color.Black
            .Visible = True
            .Tag = "pbSquares3"
        End With
        Me.Controls.Add(pbSquares3)

        Application.DoEvents()


    End Sub


End Class

