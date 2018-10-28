Imports System.Globalization
Public Class MultiGenPoint3TemperatureWeeklyStrip
    Dim WithEvents clock As New Timers.Timer
    Private m_temperature As Double
    Private m_isHeating As Boolean
    Private m_isCooling As Boolean
    Private m_isManual As Boolean
    Private m_isOff As Boolean
    Private m_isEco As Boolean
    Public Shared myWeeklySchedule As New weeklyScheduler
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

        For i = 3 To 288 Step 6
            Dim pbTickT1 As PictureBox = New PictureBox
            Dim pbTickT2 As PictureBox = New PictureBox
            Dim pbTickT3 As PictureBox = New PictureBox
            With pbTickT1
                .Width = 5
                .Height = 5
                .Location = New Point(Me.Location.X + i, Me.Location.Y + 110)
                .BackColor = Color.Black
                .Visible = True
            End With
            Me.Controls.Add(pbTickT1)
            AddHandler pbTickT1.Click, AddressOf pbSquares_Click
            With pbTickT2
                .Width = 5
                .Height = 5
                .Location = New Point(Me.Location.X + i, Me.Location.Y + 116)
                .BackColor = Color.Black
                .Visible = True
            End With
            Me.Controls.Add(pbTickT2)
            AddHandler pbTickT2.Click, AddressOf pbSquares_Click
            With pbTickT3
                .Width = 5
                .Height = 5
                .Location = New Point(Me.Location.X + i, Me.Location.Y + 122)
                .BackColor = Color.Black
                .Visible = True
            End With
            Me.Controls.Add(pbTickT3)
            AddHandler pbTickT3.Click, AddressOf pbSquares_Click
        Next
        AddHandler Me.Click, AddressOf pbSquares_Click

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

        With clock
            .Interval = 1000
            .Enabled = True
            .AutoReset = True
            .Start()
        End With
#End Region
        Me.temperature = 88.8
        Me.isHeating = False
        Me.isCooling = False
        Me.isManual = False
        Me.isEco = False

        If DateTime.Now.DayOfWeek <> 0 Then
            lblDay.Text = DateTime.Now.DayOfWeek
        Else
            lblDay.Text = "7"
        End If



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
    Public Sub pbSquares_Click()
        dlgTemperatureCalendar.ShowDialog()
    End Sub


End Class
