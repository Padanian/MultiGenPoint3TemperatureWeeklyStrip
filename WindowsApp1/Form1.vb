Imports System.IO
Imports MultiGenPoint3TemperatureWeeklyStrip.MultiGenPoint3TemperatureWeeklyStrip

Public Class Form1
    Dim MultiGen1 As New MultiGenPoint3TemperatureWeeklyStrip.MultiGenPoint3TemperatureWeeklyStrip

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click
        Dim bf As New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter
        Dim fStream1 As New FileStream("D:\Users\Alex\Downloads\activeCoolTemp.sav", FileMode.Create)
        bf.Serialize(fStream1, myWeeklySchedule.activeCoolTemp)
        fStream1.Close()

        Dim fStream2 As New FileStream("D:\Users\Alex\Downloads\activeHeatTemp.sav", FileMode.Create)
        bf.Serialize(fStream2, myWeeklySchedule.activeHeatTemp)

        fStream2.Close()


    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim bf As New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter
        Dim fStream1 As New FileStream("D:\Users\Alex\Downloads\activeCoolTemp.sav", FileMode.Open)
        myWeeklySchedule.activeCoolTemp = bf.Deserialize(fStream1) ' read from file
        fStream1.Close()

        Dim fStream2 As New FileStream("D:\Users\Alex\Downloads\activeHeatTemp.sav", FileMode.Open)
        myWeeklySchedule.activeHeatTemp = bf.Deserialize(fStream2) ' read from file

        fStream2.Close()

    End Sub
    Private Sub WriteStructToFile(Of T)(ByVal arr() As T, ByVal filePath As String)
        Using fs As New IO.FileStream(filePath, IO.FileMode.OpenOrCreate)
            Dim formatter As New Runtime.Serialization.Formatters.Binary.BinaryFormatter()
            formatter.Serialize(fs, arr)
        End Using
    End Sub

    Private Function ReadStructFromFile(Of T)(ByVal filePath As String) As T()
        Dim structArray() As T
        Using fs As New IO.FileStream(filePath, IO.FileMode.Open)
            Dim formatter As New Runtime.Serialization.Formatters.Binary.BinaryFormatter()
            structArray = CType(formatter.Deserialize(fs), T())
        End Using
        Return structArray
    End Function


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        With MultiGen1
            .Location = New Point(50, 50)
        End With

        Me.Controls.Add(MultiGen1)

    End Sub
End Class
