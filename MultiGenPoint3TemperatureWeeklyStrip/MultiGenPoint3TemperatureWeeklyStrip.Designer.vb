<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MultiGenPoint3TemperatureWeeklyStrip
    Inherits System.Windows.Forms.UserControl

    'UserControl1 esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblClockHH = New System.Windows.Forms.Label()
        Me.lblTemperature = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.pbCool = New System.Windows.Forms.PictureBox()
        Me.pbEco = New System.Windows.Forms.PictureBox()
        Me.pbManual = New System.Windows.Forms.PictureBox()
        Me.pbHeat = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblClockMM = New System.Windows.Forms.Label()
        Me.lblClockDP = New System.Windows.Forms.Label()
        CType(Me.pbCool, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbEco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbManual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbHeat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblClockHH
        '
        Me.lblClockHH.Font = New System.Drawing.Font("Digital-7 Mono", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClockHH.Location = New System.Drawing.Point(137, 35)
        Me.lblClockHH.Name = "lblClockHH"
        Me.lblClockHH.Size = New System.Drawing.Size(66, 47)
        Me.lblClockHH.TabIndex = 0
        Me.lblClockHH.Text = "88"
        Me.lblClockHH.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTemperature
        '
        Me.lblTemperature.Font = New System.Drawing.Font("Digital-7", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTemperature.Location = New System.Drawing.Point(35, 23)
        Me.lblTemperature.Name = "lblTemperature"
        Me.lblTemperature.Size = New System.Drawing.Size(81, 34)
        Me.lblTemperature.TabIndex = 0
        Me.lblTemperature.Text = "12.3°c"
        Me.lblTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Location = New System.Drawing.Point(29, 6)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(13, 13)
        Me.lblDay.TabIndex = 2
        Me.lblDay.Text = "1"
        '
        'lblDate
        '
        Me.lblDate.Font = New System.Drawing.Font("Digital-7", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(31, 54)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(81, 30)
        Me.lblDate.TabIndex = 0
        Me.lblDate.Text = "88/88/88"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pbCool
        '
        Me.pbCool.Image = Global.MultiGenPoint3TemperatureWeeklyStrip.My.Resources.Resources.if_snowflake_alt2_372618
        Me.pbCool.Location = New System.Drawing.Point(234, 3)
        Me.pbCool.Name = "pbCool"
        Me.pbCool.Size = New System.Drawing.Size(16, 16)
        Me.pbCool.TabIndex = 1
        Me.pbCool.TabStop = False
        '
        'pbEco
        '
        Me.pbEco.Image = Global.MultiGenPoint3TemperatureWeeklyStrip.My.Resources.Resources.if_coda_eco_ecology_environment_flower_green_leaf_nature_paper_plant_392515_1_
        Me.pbEco.Location = New System.Drawing.Point(163, 3)
        Me.pbEco.Name = "pbEco"
        Me.pbEco.Size = New System.Drawing.Size(16, 16)
        Me.pbEco.TabIndex = 1
        Me.pbEco.TabStop = False
        '
        'pbManual
        '
        Me.pbManual.Image = Global.MultiGenPoint3TemperatureWeeklyStrip.My.Resources.Resources.if_icon_3_high_five_329409
        Me.pbManual.Location = New System.Drawing.Point(180, 3)
        Me.pbManual.Name = "pbManual"
        Me.pbManual.Size = New System.Drawing.Size(16, 16)
        Me.pbManual.TabIndex = 1
        Me.pbManual.TabStop = False
        '
        'pbHeat
        '
        Me.pbHeat.Image = Global.MultiGenPoint3TemperatureWeeklyStrip.My.Resources.Resources.if_sun_226556
        Me.pbHeat.Location = New System.Drawing.Point(216, 3)
        Me.pbHeat.Name = "pbHeat"
        Me.pbHeat.Size = New System.Drawing.Size(16, 16)
        Me.pbHeat.TabIndex = 1
        Me.pbHeat.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Day"
        '
        'lblClockMM
        '
        Me.lblClockMM.Font = New System.Drawing.Font("Digital-7 Mono", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClockMM.Location = New System.Drawing.Point(204, 32)
        Me.lblClockMM.Margin = New System.Windows.Forms.Padding(0)
        Me.lblClockMM.Name = "lblClockMM"
        Me.lblClockMM.Size = New System.Drawing.Size(66, 52)
        Me.lblClockMM.TabIndex = 0
        Me.lblClockMM.Text = "88"
        Me.lblClockMM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblClockDP
        '
        Me.lblClockDP.BackColor = System.Drawing.Color.Transparent
        Me.lblClockDP.Font = New System.Drawing.Font("Digital-7", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClockDP.Location = New System.Drawing.Point(194, 38)
        Me.lblClockDP.Margin = New System.Windows.Forms.Padding(0)
        Me.lblClockDP.Name = "lblClockDP"
        Me.lblClockDP.Size = New System.Drawing.Size(18, 42)
        Me.lblClockDP.TabIndex = 0
        Me.lblClockDP.Text = ":"
        Me.lblClockDP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MultiGenPoint3TemperatureWeeklyStrip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.pbCool)
        Me.Controls.Add(Me.pbEco)
        Me.Controls.Add(Me.pbManual)
        Me.Controls.Add(Me.pbHeat)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblTemperature)
        Me.Controls.Add(Me.lblClockDP)
        Me.Controls.Add(Me.lblClockMM)
        Me.Controls.Add(Me.lblClockHH)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Name = "MultiGenPoint3TemperatureWeeklyStrip"
        Me.Size = New System.Drawing.Size(294, 130)
        CType(Me.pbCool, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbEco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbManual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbHeat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblClockHH As Label
    Friend WithEvents lblTemperature As Label
    Friend WithEvents pbHeat As PictureBox
    Friend WithEvents pbCool As PictureBox
    Friend WithEvents lblDay As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents pbManual As PictureBox
    Friend WithEvents pbEco As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblClockMM As Label
    Friend WithEvents lblClockDP As Label
End Class