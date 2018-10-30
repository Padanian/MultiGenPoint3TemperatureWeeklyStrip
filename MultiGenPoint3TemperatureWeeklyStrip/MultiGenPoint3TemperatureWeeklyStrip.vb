Imports System.Globalization
Public Class MultiGenPoint3TemperatureWeeklyStrip
    Dim WithEvents clock As New Timers.Timer
    Private m_temperature As Double
    Private m_isHeating As Boolean
    Private m_isCooling As Boolean
    Private m_isManual As Boolean
    Private m_isOff As Boolean
    Private m_isEco As Boolean
    Public Shared UpdateRequest As Boolean = True
    Private myWeeklySchedule As New weeklyScheduler
    Public Property isHeating As Boolean
        Get
            isHeating = m_isHeating
        End Get
        Set(isHeating As Boolean)
            pbHeat.Visible = isHeating
            m_isHeating = isHeating
        End Set
    End Property
    Public Property isCooling As Boolean
        Get
            isCooling = m_isCooling
        End Get
        Set(isCooling As Boolean)
            pbCool.Visible = isCooling
            m_isCooling = isCooling
        End Set
    End Property
    Public Property isManual As Boolean
        Get
            isManual = m_isManual
        End Get
        Set(isManual As Boolean)
            pbManual.Visible = isManual
            m_isManual = isManual
        End Set
    End Property
    Public Property isEco As Boolean
        Get
            isEco = m_isEco
        End Get
        Set(isEco As Boolean)
            pbEco.Visible = isEco
            m_isEco = isEco
        End Set
    End Property
    Public Property isOff As Boolean
        Get
            isOff = m_isOff
        End Get
        Set(isOff As Boolean)
            m_isOff = isOff
            If isOff = True Then
                clock.Enabled = False
                For Each ctl In Me.Controls
                    If ctl.name <> "lblClock" Then
                        ctl.visible = False
                    Else
                        lblClock.Text = " OFF"
                    End If
                Next
            Else
                clock.Enabled = True
                For Each ctl In Me.Controls
                    ctl.visible = True
                    If ctl.name = pbCool.Name Then
                        ctl.visible = isCooling
                    ElseIf ctl.name = pbHeat.Name Then
                        ctl.visible = isHeating
                    ElseIf ctl.name = pbManual.Name Then
                        ctl.visible = isManual
                    ElseIf ctl.name = pbEco.Name Then
                        ctl.visible = isEco
                    End If
                    If TypeOf (ctl) Is Label And ctl.name.contains("lblDay") Then
                        If Not ctl.name.contains(DateTime.Now.DayOfWeek) Then
                            ctl.visible = False
                        End If
                    End If
                    clock_tick()
                Next
            End If
        End Set
    End Property
    Public Property temperature As Double
        Get
            temperature = m_temperature
        End Get
        Set(temperature As Double)
            lblTemperature.Text = Format(temperature, "##0.0").ToString & "°c"
            m_temperature = temperature

        End Set
    End Property
    Public Sub New()
        InitializeComponent()
        modificaClockText("")

#Region "Labels"
        Dim lbl04 As New Label
        With lbl04
            .Text = "04"
            .Location = New Point(12 * 3 + 6, 96)
            .Visible = True
            .Width = 20
            .Height = 12
        End With
        Me.Controls.Add(lbl04)
        Dim lbl08 As New Label
        With lbl08
            .Text = "08"
            .Location = New Point(12 * 7 + 6, 96)
            .Visible = True
            .Width = 20
            .Height = 12
        End With
        Me.Controls.Add(lbl08)
        Dim lbl12 As New Label
        With lbl12
            .Text = "12"
            .Location = New Point(12 * 11 + 6, 96)
            .Visible = True
            .Width = 20
            .Height = 12
        End With
        Me.Controls.Add(lbl12)
        Dim lbl16 As New Label
        With lbl16
            .Text = "16"
            .Location = New Point(12 * 15 + 6, 96)
            .Visible = True
            .Width = 20
            .Height = 12
        End With
        Me.Controls.Add(lbl16)
        Dim lbl20 As New Label
        With lbl20
            .Text = "20"
            .Location = New Point(12 * 19 + 6, 96)
            .Visible = True
            .Width = 20
            .Height = 12
        End With
        Me.Controls.Add(lbl20)
#End Region
        With clock
            .Interval = 500
            .Enabled = True
            .AutoReset = True
            .Start()
        End With

        Me.temperature = 100 * Rnd()
        Me.isHeating = True
        Me.isCooling = False
        Me.isManual = False
        Me.isEco = False

        If DateTime.Now.DayOfWeek <> 0 Then
            lblDay.Text = DateTime.Now.DayOfWeek
        Else
            lblDay.Text = "7"
        End If

        AddHandler Me.Click, AddressOf pbSquares_Click

        If System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy" Then
            lblDate.Text = DateTime.Now.Month.ToString.PadLeft(2, "0") & "/" &
            DateTime.Now.Day.ToString.PadLeft(2, "0") & "/" &
            Strings.Right(DateTime.Now.Year.ToString, 2).PadLeft(2, "0")
        ElseIf System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy" Then
            lblDate.Text = DateTime.Now.Day.ToString.PadLeft(2, "0") & "/" &
                DateTime.Now.Month.ToString.PadLeft(2, "0") & "/" &
                Strings.Right(DateTime.Now.Year.ToString, 2).PadLeft(2, "0")
        End If


    End Sub
    Private Sub clock_tick() Handles clock.Elapsed
        If DateTime.Now.Second Mod 2 = 0 Then
            modificaClockText(DateTime.Now.Hour.ToString & ":" & DateTime.Now.Minute.ToString.PadLeft(2, "0"))
        Else
            modificaClockText(DateTime.Now.Hour.ToString & "." & DateTime.Now.Minute.ToString.PadLeft(2, "0"))
        End If

        modificalblDays()

        Dim timingUpdate = 3600
#If DEBUG Then
        timingUpdate = 60
#End If


        If UpdateRequest Or DateTime.Now.Second Mod timingUpdate = 0 Then
            UpdateRequest = False
            For Each pb In Me.Controls
                If TypeOf (pb) Is PictureBox And pb.height = 5 And pb.width = 5 Then
                    pbDispose(pb)
                End If
            Next
            Dim counter As Integer
            For i = 3 To 288 Step 6
                Dim pbTickT1 As PictureBox = New PictureBox
                Dim pbTickT2 As PictureBox = New PictureBox
                Dim pbTickT3 As PictureBox = New PictureBox
                With pbTickT3
                    .Width = 5
                    .Height = 5
                    .Location = New Point(.Location.X + i, .Location.Y + 110)
                    .Visible = True
                End With
                pbAddControl(pbTickT3)
                AddHandler pbTickT1.Click, AddressOf pbSquares_Click
                With pbTickT2
                    .Width = 5
                    .Height = 5
                    .Location = New Point(.Location.X + i, .Location.Y + 116)
                    .Visible = True
                End With
                pbAddControl(pbTickT2)
                AddHandler pbTickT2.Click, AddressOf pbSquares_Click
                With pbTickT1
                    .Width = 5
                    .Height = 5
                    .Location = New Point(.Location.X + i, .Location.Y + 122)
                    .Visible = True
                    .Name = "pbTickT1" & counter.ToString.PadLeft(2, "0")
                End With
                pbAddControl(pbTickT1)
                AddHandler pbTickT3.Click, AddressOf pbSquares_Click

                If myWeeklySchedule.activeHeatTemp(DateTime.Now.DayOfWeek, counter) = 0 Then
                    pbTickT1.BackColor = Color.LightGray
                    pbTickT2.BackColor = Color.LightGray
                    pbTickT3.BackColor = Color.LightGray
                ElseIf myWeeklySchedule.activeHeatTemp(DateTime.Now.DayOfWeek, counter) = 1 Then
                    pbTickT1.BackColor = Color.Black
                    pbTickT2.BackColor = Color.LightGray
                    pbTickT3.BackColor = Color.LightGray
                ElseIf myWeeklySchedule.activeHeatTemp(DateTime.Now.DayOfWeek, counter) = 2 Then
                    pbTickT1.BackColor = Color.Black
                    pbTickT2.BackColor = Color.Black
                    pbTickT3.BackColor = Color.LightGray
                ElseIf myWeeklySchedule.activeHeatTemp(DateTime.Now.DayOfWeek, counter) = 3 Then
                    pbTickT1.BackColor = Color.Black
                    pbTickT2.BackColor = Color.Black
                    pbTickT3.BackColor = Color.Black
                End If
                counter += 1
            Next
        End If

        blinkingDot()

    End Sub
    Private Delegate Sub blinkingDotDelegate()
    Private Sub blinkingDot()



        If Me.InvokeRequired Then
            Dim d As New blinkingDotDelegate(AddressOf Me.blinkingDot)
            Me.BeginInvoke(d)
        Else
            Dim position As Integer
            Dim defaultColor As Color
            position = (DateTime.Now.Hour * 60 + DateTime.Now.Minute) \ 30

            If myWeeklySchedule.activeHeatTemp(DateTime.Now.DayOfWeek, position) <> 0 Then
                defaultColor = Color.Black
            Else
                defaultColor = Color.LightGray
            End If


            If DirectCast(Me.Controls.Find("pbTickT1" & position.ToString.PadLeft(2, "0"), True)(0), PictureBox).BackColor = defaultColor Then
                DirectCast(Me.Controls.Find("pbTickT1" & position.ToString.PadLeft(2, "0"), True)(0), PictureBox).BackColor = Color.DarkGray
            Else
                DirectCast(Me.Controls.Find("pbTickT1" & position.ToString.PadLeft(2, "0"), True)(0), PictureBox).BackColor = defaultColor
            End If
        End If



    End Sub
    Private Delegate Sub modificaClockTextDelegate(ByVal a As String)
    Private Sub modificaClockText(ByVal a As String)

        If Me.InvokeRequired Then
            Dim d As New modificaClockTextDelegate(AddressOf Me.modificaClockText)
            Me.BeginInvoke(d, New Object() {a})
        Else
            lblClock.Text = a
        End If

    End Sub
    Private Delegate Sub modificalblDaysDelegate()
    Private Sub modificalblDays()

        If Me.InvokeRequired Then
            Dim d As New modificalblDaysDelegate(AddressOf Me.modificalblDays)
            Me.BeginInvoke(d)
        Else
            If DateTime.Now.Hour = 0 And DateTime.Now.Minute = 0 And DateTime.Now.Second = 0 Then
                For Each lbl In Me.Controls
                    If TypeOf (lbl) Is Label And lbl.name.contains("lblDay") Then
                        If lbl.name.contains(DateTime.Now.DayOfWeek) Then
                            lbl.visible = True
                        Else
                            lbl.visible = False
                        End If
                    End If
                Next
            End If
        End If

    End Sub
    Private Delegate Sub pbDisposeDelegate(ByRef a As PictureBox)
    Private Sub pbDispose(ByRef a As PictureBox)

        If Me.InvokeRequired Then
            Dim d As New pbDisposeDelegate(AddressOf Me.pbDispose)
            Me.BeginInvoke(d, New Object() {a})
        Else
            a.Dispose()
        End If

    End Sub
    Private Delegate Sub pbAddControlDelegate(ByRef a As PictureBox)

    Private Sub pbAddControl(ByRef a As PictureBox)

        If Me.InvokeRequired Then
            Dim d As New pbDisposeDelegate(AddressOf Me.pbAddControl)
            Me.BeginInvoke(d, New Object() {a})

        Else
            Me.Controls.Add(a)
        End If

    End Sub
    Public Sub pbSquares_Click()
        dlgTemperatureCalendar.dlgWeeklyScheduler = myWeeklySchedule
        dlgTemperatureCalendar.ShowDialog()
        If dlgTemperatureCalendar.DialogResult = DialogResult.OK Then
            myWeeklySchedule = dlgTemperatureCalendar.dlgWeeklyScheduler
        End If
    End Sub
    Public Sub UpdatemyWeeklySchedule(ByVal a As weeklyScheduler)
        myWeeklySchedule = a
    End Sub
    Private Sub Me_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint

        Dim myGraphics As Graphics
        Dim myRectangle As Rectangle
        Dim myPen As New Pen(Color.DarkGray, 2)

        myGraphics = Graphics.FromHwnd(Me.Handle)
        myRectangle = New Rectangle(0, 0, 294, 130)
        myGraphics.DrawRectangle(myPen, myRectangle)

    End Sub
End Class
