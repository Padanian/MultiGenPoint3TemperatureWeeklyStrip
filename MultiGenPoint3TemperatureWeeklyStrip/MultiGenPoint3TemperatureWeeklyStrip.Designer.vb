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
        Me.lblClock = New System.Windows.Forms.Label()
        Me.lblTemperature = New System.Windows.Forms.Label()
        Me.lblDay1 = New System.Windows.Forms.Label()
        Me.lblDay2 = New System.Windows.Forms.Label()
        Me.lblDay3 = New System.Windows.Forms.Label()
        Me.lblDay4 = New System.Windows.Forms.Label()
        Me.lblDay5 = New System.Windows.Forms.Label()
        Me.lblDay6 = New System.Windows.Forms.Label()
        Me.lblDay7 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.pbCool = New System.Windows.Forms.PictureBox()
        Me.pbManual = New System.Windows.Forms.PictureBox()
        Me.pbHeat = New System.Windows.Forms.PictureBox()
        CType(Me.pbCool, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbManual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbHeat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblClock
        '
        Me.lblClock.AutoSize = True
        Me.lblClock.Font = New System.Drawing.Font("Digital-7", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClock.Location = New System.Drawing.Point(123, 23)
        Me.lblClock.Name = "lblClock"
        Me.lblClock.Size = New System.Drawing.Size(142, 64)
        Me.lblClock.TabIndex = 0
        Me.lblClock.Text = "12:34"
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
        'lblDay1
        '
        Me.lblDay1.AutoSize = True
        Me.lblDay1.Location = New System.Drawing.Point(3, 6)
        Me.lblDay1.Name = "lblDay1"
        Me.lblDay1.Size = New System.Drawing.Size(13, 13)
        Me.lblDay1.TabIndex = 2
        Me.lblDay1.Text = "1"
        '
        'lblDay2
        '
        Me.lblDay2.AutoSize = True
        Me.lblDay2.Location = New System.Drawing.Point(13, 6)
        Me.lblDay2.Name = "lblDay2"
        Me.lblDay2.Size = New System.Drawing.Size(13, 13)
        Me.lblDay2.TabIndex = 2
        Me.lblDay2.Text = "2"
        '
        'lblDay3
        '
        Me.lblDay3.AutoSize = True
        Me.lblDay3.Location = New System.Drawing.Point(23, 6)
        Me.lblDay3.Name = "lblDay3"
        Me.lblDay3.Size = New System.Drawing.Size(13, 13)
        Me.lblDay3.TabIndex = 2
        Me.lblDay3.Text = "3"
        '
        'lblDay4
        '
        Me.lblDay4.AutoSize = True
        Me.lblDay4.Location = New System.Drawing.Point(33, 6)
        Me.lblDay4.Name = "lblDay4"
        Me.lblDay4.Size = New System.Drawing.Size(13, 13)
        Me.lblDay4.TabIndex = 2
        Me.lblDay4.Text = "4"
        '
        'lblDay5
        '
        Me.lblDay5.AutoSize = True
        Me.lblDay5.Location = New System.Drawing.Point(43, 6)
        Me.lblDay5.Name = "lblDay5"
        Me.lblDay5.Size = New System.Drawing.Size(13, 13)
        Me.lblDay5.TabIndex = 2
        Me.lblDay5.Text = "5"
        '
        'lblDay6
        '
        Me.lblDay6.AutoSize = True
        Me.lblDay6.Location = New System.Drawing.Point(53, 6)
        Me.lblDay6.Name = "lblDay6"
        Me.lblDay6.Size = New System.Drawing.Size(13, 13)
        Me.lblDay6.TabIndex = 2
        Me.lblDay6.Text = "6"
        '
        'lblDay7
        '
        Me.lblDay7.AutoSize = True
        Me.lblDay7.Location = New System.Drawing.Point(63, 6)
        Me.lblDay7.Name = "lblDay7"
        Me.lblDay7.Size = New System.Drawing.Size(13, 13)
        Me.lblDay7.TabIndex = 2
        Me.lblDay7.Text = "7"
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
        'MultiGenPoint3TemperatureWeeklyStrip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblDay7)
        Me.Controls.Add(Me.lblDay6)
        Me.Controls.Add(Me.lblDay5)
        Me.Controls.Add(Me.lblDay4)
        Me.Controls.Add(Me.lblDay3)
        Me.Controls.Add(Me.lblDay2)
        Me.Controls.Add(Me.lblDay1)
        Me.Controls.Add(Me.pbCool)
        Me.Controls.Add(Me.pbManual)
        Me.Controls.Add(Me.pbHeat)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblTemperature)
        Me.Controls.Add(Me.lblClock)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Name = "MultiGenPoint3TemperatureWeeklyStrip"
        Me.Size = New System.Drawing.Size(294, 130)
        CType(Me.pbCool, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbManual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbHeat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblClock As Label
    Friend WithEvents lblTemperature As Label
    Friend WithEvents pbHeat As PictureBox
    Friend WithEvents pbCool As PictureBox
    Friend WithEvents lblDay1 As Label
    Friend WithEvents lblDay2 As Label
    Friend WithEvents lblDay3 As Label
    Friend WithEvents lblDay4 As Label
    Friend WithEvents lblDay5 As Label
    Friend WithEvents lblDay6 As Label
    Friend WithEvents lblDay7 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents pbManual As PictureBox
End Class