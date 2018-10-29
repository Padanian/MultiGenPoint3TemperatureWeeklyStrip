<Serializable()>
Public Class weeklyScheduler
    Public Property setpointHeatT1 As Double
    Public Property setpointHeatT2 As Double
    Public Property setpointHeatT3 As Double
    Public Property setpointCoolT1 As Double
    Public Property setpointCoolT2 As Double
    Public Property setpointCoolT3 As Double

    Public Property heatPB As Double
    Public Property coolPB As Double
    Public Property freezeProtSetpoint As Double
    Public Property ecoHeatReduction As Double
    Public Property ecoCoolIncrease As Double
    Public Property workingSetpoint As Double
    Public activeHeatTemp(,) As Integer
    Public activeCoolTemp(,) As Integer
    Public Sub New()
        ReDim activeHeatTemp(6, 47)
        ReDim activeCoolTemp(6, 47)
        For i = 0 To 6
            For j = 0 To 47
                activeHeatTemp(i, j) = 0
                activeCoolTemp(i, j) = 0
            Next
        Next

        setpointHeatT1 = 21.0
        setpointHeatT2 = 19.0
        setpointHeatT3 = 15.0
        setpointCoolT1 = 24.0
        setpointCoolT2 = 26.0
        setpointCoolT3 = 30.0

        heatPB = 2.0
        coolPB = 2.0
        freezeProtSetpoint = 6.0
        ecoHeatReduction = -4.0
        ecoCoolIncrease = 4.0
        workingSetpoint = 0.0


    End Sub



End Class
