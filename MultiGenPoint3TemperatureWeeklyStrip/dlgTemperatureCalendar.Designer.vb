<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgTemperatureCalendar
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbDays = New System.Windows.Forms.GroupBox()
        Me.chkDayAll = New System.Windows.Forms.CheckBox()
        Me.rbFestivo = New System.Windows.Forms.RadioButton()
        Me.rbFeriale = New System.Windows.Forms.RadioButton()
        Me.rbDay0 = New System.Windows.Forms.RadioButton()
        Me.rbDay6 = New System.Windows.Forms.RadioButton()
        Me.rbDay5 = New System.Windows.Forms.RadioButton()
        Me.rbDay4 = New System.Windows.Forms.RadioButton()
        Me.rbDay3 = New System.Windows.Forms.RadioButton()
        Me.rbDay2 = New System.Windows.Forms.RadioButton()
        Me.rbDay1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.nupHeatT1 = New System.Windows.Forms.NumericUpDown()
        Me.nupHeatT2 = New System.Windows.Forms.NumericUpDown()
        Me.nupHeatT3 = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.nupCoolT3 = New System.Windows.Forms.NumericUpDown()
        Me.nupCoolT2 = New System.Windows.Forms.NumericUpDown()
        Me.nupCoolT1 = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.nupHeatBP = New System.Windows.Forms.NumericUpDown()
        Me.nupCoolBP = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.nupFrostProt = New System.Windows.Forms.NumericUpDown()
        Me.nupHeatEco = New System.Windows.Forms.NumericUpDown()
        Me.nupCoolEco = New System.Windows.Forms.NumericUpDown()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCopyBack = New System.Windows.Forms.Button()
        Me.btnCopyForth = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbManual = New System.Windows.Forms.ComboBox()
        Me.btnLoadWeekly = New System.Windows.Forms.Button()
        Me.btnSaveWeekly = New System.Windows.Forms.Button()
        Me.btnEmptyWeek = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.gbDays.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.nupHeatT1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupHeatT2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupHeatT3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.nupCoolT3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupCoolT2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupCoolT1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.nupHeatBP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupCoolBP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.nupFrostProt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupHeatEco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupCoolEco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(626, 320)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Annulla"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "T3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "T2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "T1"
        '
        'gbDays
        '
        Me.gbDays.Controls.Add(Me.chkDayAll)
        Me.gbDays.Controls.Add(Me.rbFestivo)
        Me.gbDays.Controls.Add(Me.rbFeriale)
        Me.gbDays.Controls.Add(Me.rbDay0)
        Me.gbDays.Controls.Add(Me.rbDay6)
        Me.gbDays.Controls.Add(Me.rbDay5)
        Me.gbDays.Controls.Add(Me.rbDay4)
        Me.gbDays.Controls.Add(Me.rbDay3)
        Me.gbDays.Controls.Add(Me.rbDay2)
        Me.gbDays.Controls.Add(Me.rbDay1)
        Me.gbDays.Location = New System.Drawing.Point(34, 122)
        Me.gbDays.Name = "gbDays"
        Me.gbDays.Size = New System.Drawing.Size(717, 37)
        Me.gbDays.TabIndex = 3
        Me.gbDays.TabStop = False
        '
        'chkDayAll
        '
        Me.chkDayAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkDayAll.AutoSize = True
        Me.chkDayAll.Location = New System.Drawing.Point(511, 15)
        Me.chkDayAll.Name = "chkDayAll"
        Me.chkDayAll.Size = New System.Drawing.Size(79, 17)
        Me.chkDayAll.TabIndex = 1
        Me.chkDayAll.Text = "Tutti i giorni"
        Me.chkDayAll.UseVisualStyleBackColor = True
        '
        'rbFestivo
        '
        Me.rbFestivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbFestivo.AutoSize = True
        Me.rbFestivo.Location = New System.Drawing.Point(653, 14)
        Me.rbFestivo.Name = "rbFestivo"
        Me.rbFestivo.Size = New System.Drawing.Size(52, 17)
        Me.rbFestivo.TabIndex = 0
        Me.rbFestivo.TabStop = True
        Me.rbFestivo.Text = "Festivi"
        Me.rbFestivo.UseVisualStyleBackColor = True
        '
        'rbFeriale
        '
        Me.rbFeriale.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbFeriale.AutoSize = True
        Me.rbFeriale.Location = New System.Drawing.Point(596, 14)
        Me.rbFeriale.Name = "rbFeriale"
        Me.rbFeriale.Size = New System.Drawing.Size(52, 17)
        Me.rbFeriale.TabIndex = 0
        Me.rbFeriale.TabStop = True
        Me.rbFeriale.Text = "Feriali"
        Me.rbFeriale.UseVisualStyleBackColor = True
        '
        'rbDay0
        '
        Me.rbDay0.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbDay0.AutoSize = True
        Me.rbDay0.Location = New System.Drawing.Point(405, 14)
        Me.rbDay0.Name = "rbDay0"
        Me.rbDay0.Size = New System.Drawing.Size(73, 17)
        Me.rbDay0.TabIndex = 0
        Me.rbDay0.TabStop = True
        Me.rbDay0.Text = "Domenica"
        Me.rbDay0.UseVisualStyleBackColor = True
        '
        'rbDay6
        '
        Me.rbDay6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbDay6.AutoSize = True
        Me.rbDay6.Location = New System.Drawing.Point(342, 14)
        Me.rbDay6.Name = "rbDay6"
        Me.rbDay6.Size = New System.Drawing.Size(58, 17)
        Me.rbDay6.TabIndex = 0
        Me.rbDay6.TabStop = True
        Me.rbDay6.Text = "Sabato"
        Me.rbDay6.UseVisualStyleBackColor = True
        '
        'rbDay5
        '
        Me.rbDay5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbDay5.AutoSize = True
        Me.rbDay5.Location = New System.Drawing.Point(275, 14)
        Me.rbDay5.Name = "rbDay5"
        Me.rbDay5.Size = New System.Drawing.Size(61, 17)
        Me.rbDay5.TabIndex = 0
        Me.rbDay5.TabStop = True
        Me.rbDay5.Text = "Venerdì"
        Me.rbDay5.UseVisualStyleBackColor = True
        '
        'rbDay4
        '
        Me.rbDay4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbDay4.AutoSize = True
        Me.rbDay4.Location = New System.Drawing.Point(210, 14)
        Me.rbDay4.Name = "rbDay4"
        Me.rbDay4.Size = New System.Drawing.Size(59, 17)
        Me.rbDay4.TabIndex = 0
        Me.rbDay4.TabStop = True
        Me.rbDay4.Text = "Giovedì"
        Me.rbDay4.UseVisualStyleBackColor = True
        '
        'rbDay3
        '
        Me.rbDay3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbDay3.AutoSize = True
        Me.rbDay3.Location = New System.Drawing.Point(136, 14)
        Me.rbDay3.Name = "rbDay3"
        Me.rbDay3.Size = New System.Drawing.Size(72, 17)
        Me.rbDay3.TabIndex = 0
        Me.rbDay3.TabStop = True
        Me.rbDay3.Text = "Mercoledì"
        Me.rbDay3.UseVisualStyleBackColor = True
        '
        'rbDay2
        '
        Me.rbDay2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbDay2.AutoSize = True
        Me.rbDay2.Location = New System.Drawing.Point(68, 14)
        Me.rbDay2.Name = "rbDay2"
        Me.rbDay2.Size = New System.Drawing.Size(62, 17)
        Me.rbDay2.TabIndex = 0
        Me.rbDay2.TabStop = True
        Me.rbDay2.Text = "Martedì"
        Me.rbDay2.UseVisualStyleBackColor = True
        '
        'rbDay1
        '
        Me.rbDay1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbDay1.AutoSize = True
        Me.rbDay1.Location = New System.Drawing.Point(6, 14)
        Me.rbDay1.Name = "rbDay1"
        Me.rbDay1.Size = New System.Drawing.Size(56, 17)
        Me.rbDay1.TabIndex = 0
        Me.rbDay1.TabStop = True
        Me.rbDay1.Text = "Lunedì"
        Me.rbDay1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.nupHeatT1)
        Me.GroupBox2.Controls.Add(Me.nupHeatT2)
        Me.GroupBox2.Controls.Add(Me.nupHeatT3)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(34, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(130, 104)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Setpoint riscaldamento"
        '
        'nupHeatT1
        '
        Me.nupHeatT1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nupHeatT1.DecimalPlaces = 1
        Me.nupHeatT1.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nupHeatT1.Location = New System.Drawing.Point(55, 18)
        Me.nupHeatT1.Maximum = New Decimal(New Integer() {999, 0, 0, 65536})
        Me.nupHeatT1.Name = "nupHeatT1"
        Me.nupHeatT1.Size = New System.Drawing.Size(47, 22)
        Me.nupHeatT1.TabIndex = 1
        Me.nupHeatT1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nupHeatT1.Value = New Decimal(New Integer() {999, 0, 0, 65536})
        '
        'nupHeatT2
        '
        Me.nupHeatT2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nupHeatT2.DecimalPlaces = 1
        Me.nupHeatT2.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nupHeatT2.Location = New System.Drawing.Point(55, 46)
        Me.nupHeatT2.Maximum = New Decimal(New Integer() {999, 0, 0, 65536})
        Me.nupHeatT2.Name = "nupHeatT2"
        Me.nupHeatT2.Size = New System.Drawing.Size(47, 22)
        Me.nupHeatT2.TabIndex = 1
        Me.nupHeatT2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nupHeatT2.Value = New Decimal(New Integer() {999, 0, 0, 65536})
        '
        'nupHeatT3
        '
        Me.nupHeatT3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nupHeatT3.DecimalPlaces = 1
        Me.nupHeatT3.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nupHeatT3.Location = New System.Drawing.Point(55, 74)
        Me.nupHeatT3.Maximum = New Decimal(New Integer() {999, 0, 0, 65536})
        Me.nupHeatT3.Name = "nupHeatT3"
        Me.nupHeatT3.Size = New System.Drawing.Size(47, 22)
        Me.nupHeatT3.TabIndex = 1
        Me.nupHeatT3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nupHeatT3.Value = New Decimal(New Integer() {999, 0, 0, 65536})
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "T3"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "T2"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "T1"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.nupCoolT3)
        Me.GroupBox3.Controls.Add(Me.nupCoolT2)
        Me.GroupBox3.Controls.Add(Me.nupCoolT1)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Location = New System.Drawing.Point(170, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(133, 104)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Setpoint raffrescamento"
        '
        'nupCoolT3
        '
        Me.nupCoolT3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nupCoolT3.DecimalPlaces = 1
        Me.nupCoolT3.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nupCoolT3.Location = New System.Drawing.Point(58, 18)
        Me.nupCoolT3.Maximum = New Decimal(New Integer() {999, 0, 0, 65536})
        Me.nupCoolT3.Name = "nupCoolT3"
        Me.nupCoolT3.Size = New System.Drawing.Size(47, 22)
        Me.nupCoolT3.TabIndex = 1
        Me.nupCoolT3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nupCoolT3.Value = New Decimal(New Integer() {999, 0, 0, 65536})
        '
        'nupCoolT2
        '
        Me.nupCoolT2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nupCoolT2.DecimalPlaces = 1
        Me.nupCoolT2.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nupCoolT2.Location = New System.Drawing.Point(58, 46)
        Me.nupCoolT2.Maximum = New Decimal(New Integer() {999, 0, 0, 65536})
        Me.nupCoolT2.Name = "nupCoolT2"
        Me.nupCoolT2.Size = New System.Drawing.Size(47, 22)
        Me.nupCoolT2.TabIndex = 1
        Me.nupCoolT2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nupCoolT2.Value = New Decimal(New Integer() {999, 0, 0, 65536})
        '
        'nupCoolT1
        '
        Me.nupCoolT1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nupCoolT1.DecimalPlaces = 1
        Me.nupCoolT1.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nupCoolT1.Location = New System.Drawing.Point(58, 74)
        Me.nupCoolT1.Maximum = New Decimal(New Integer() {999, 0, 0, 65536})
        Me.nupCoolT1.Name = "nupCoolT1"
        Me.nupCoolT1.Size = New System.Drawing.Size(47, 22)
        Me.nupCoolT1.TabIndex = 1
        Me.nupCoolT1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nupCoolT1.Value = New Decimal(New Integer() {999, 0, 0, 65536})
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(34, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(19, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "T3"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(34, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "T2"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(36, 76)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(17, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "T1"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.nupHeatBP)
        Me.GroupBox4.Controls.Add(Me.nupCoolBP)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Location = New System.Drawing.Point(309, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(165, 104)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Bande proporzionali"
        '
        'nupHeatBP
        '
        Me.nupHeatBP.DecimalPlaces = 1
        Me.nupHeatBP.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nupHeatBP.Location = New System.Drawing.Point(107, 18)
        Me.nupHeatBP.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nupHeatBP.Name = "nupHeatBP"
        Me.nupHeatBP.Size = New System.Drawing.Size(47, 22)
        Me.nupHeatBP.TabIndex = 1
        Me.nupHeatBP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nupHeatBP.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'nupCoolBP
        '
        Me.nupCoolBP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.nupCoolBP.DecimalPlaces = 1
        Me.nupCoolBP.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nupCoolBP.Location = New System.Drawing.Point(107, 74)
        Me.nupCoolBP.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nupCoolBP.Name = "nupCoolBP"
        Me.nupCoolBP.Size = New System.Drawing.Size(47, 22)
        Me.nupCoolBP.TabIndex = 1
        Me.nupCoolBP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nupCoolBP.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Bp riscaldamento"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 76)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Bp raffrescamento"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.nupFrostProt)
        Me.GroupBox5.Controls.Add(Me.nupHeatEco)
        Me.GroupBox5.Controls.Add(Me.nupCoolEco)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Location = New System.Drawing.Point(579, 12)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(172, 104)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Altri setpoint"
        '
        'nupFrostProt
        '
        Me.nupFrostProt.DecimalPlaces = 1
        Me.nupFrostProt.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nupFrostProt.Location = New System.Drawing.Point(115, 18)
        Me.nupFrostProt.Maximum = New Decimal(New Integer() {120, 0, 0, 65536})
        Me.nupFrostProt.Name = "nupFrostProt"
        Me.nupFrostProt.Size = New System.Drawing.Size(47, 22)
        Me.nupFrostProt.TabIndex = 1
        Me.nupFrostProt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nupFrostProt.Value = New Decimal(New Integer() {120, 0, 0, 65536})
        '
        'nupHeatEco
        '
        Me.nupHeatEco.DecimalPlaces = 1
        Me.nupHeatEco.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nupHeatEco.Location = New System.Drawing.Point(115, 46)
        Me.nupHeatEco.Maximum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.nupHeatEco.Minimum = New Decimal(New Integer() {10, 0, 0, -2147483648})
        Me.nupHeatEco.Name = "nupHeatEco"
        Me.nupHeatEco.Size = New System.Drawing.Size(47, 22)
        Me.nupHeatEco.TabIndex = 1
        Me.nupHeatEco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nupCoolEco
        '
        Me.nupCoolEco.DecimalPlaces = 1
        Me.nupCoolEco.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nupCoolEco.Location = New System.Drawing.Point(115, 74)
        Me.nupCoolEco.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nupCoolEco.Name = "nupCoolEco"
        Me.nupCoolEco.Size = New System.Drawing.Size(47, 22)
        Me.nupCoolEco.TabIndex = 1
        Me.nupCoolEco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nupCoolEco.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(10, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Antigelo"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(10, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(92, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Eco riscaldamento"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(10, 76)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(98, 13)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Eco raffrescamento"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(12, 248)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(19, 13)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "T3"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(12, 263)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(19, 13)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "T2"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(13, 279)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(17, 13)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "T1"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(2, 149)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(26, 13)
        Me.Label18.TabIndex = 5
        Me.Label18.Text = "Risc."
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(2, 232)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(26, 13)
        Me.Label19.TabIndex = 5
        Me.Label19.Text = "Raff."
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Location = New System.Drawing.Point(34, 236)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(722, 1)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'btnCopyBack
        '
        Me.btnCopyBack.Location = New System.Drawing.Point(34, 314)
        Me.btnCopyBack.Name = "btnCopyBack"
        Me.btnCopyBack.Size = New System.Drawing.Size(90, 35)
        Me.btnCopyBack.TabIndex = 7
        Me.btnCopyBack.Text = "Copia su giorno precedente"
        Me.btnCopyBack.UseVisualStyleBackColor = True
        '
        'btnCopyForth
        '
        Me.btnCopyForth.Location = New System.Drawing.Point(130, 314)
        Me.btnCopyForth.Name = "btnCopyForth"
        Me.btnCopyForth.Size = New System.Drawing.Size(90, 35)
        Me.btnCopyForth.TabIndex = 7
        Me.btnCopyForth.Text = "Copia su giorno successivo"
        Me.btnCopyForth.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbManual)
        Me.GroupBox1.Location = New System.Drawing.Point(480, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(93, 104)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Manuale"
        '
        'cbManual
        '
        Me.cbManual.FormattingEnabled = True
        Me.cbManual.Items.AddRange(New Object() {"T3", "T2", "T1", "Antigelo"})
        Me.cbManual.Location = New System.Drawing.Point(6, 40)
        Me.cbManual.Name = "cbManual"
        Me.cbManual.Size = New System.Drawing.Size(81, 21)
        Me.cbManual.TabIndex = 0
        '
        'btnLoadWeekly
        '
        Me.btnLoadWeekly.Location = New System.Drawing.Point(226, 314)
        Me.btnLoadWeekly.Name = "btnLoadWeekly"
        Me.btnLoadWeekly.Size = New System.Drawing.Size(90, 35)
        Me.btnLoadWeekly.TabIndex = 7
        Me.btnLoadWeekly.Text = "Carica settimanale"
        Me.btnLoadWeekly.UseVisualStyleBackColor = True
        '
        'btnSaveWeekly
        '
        Me.btnSaveWeekly.Location = New System.Drawing.Point(322, 314)
        Me.btnSaveWeekly.Name = "btnSaveWeekly"
        Me.btnSaveWeekly.Size = New System.Drawing.Size(90, 35)
        Me.btnSaveWeekly.TabIndex = 7
        Me.btnSaveWeekly.Text = "Salva settimanale"
        Me.btnSaveWeekly.UseVisualStyleBackColor = True
        '
        'btnEmptyWeek
        '
        Me.btnEmptyWeek.Location = New System.Drawing.Point(439, 314)
        Me.btnEmptyWeek.Name = "btnEmptyWeek"
        Me.btnEmptyWeek.Size = New System.Drawing.Size(99, 35)
        Me.btnEmptyWeek.TabIndex = 7
        Me.btnEmptyWeek.Text = "Crea settimanale vuoto"
        Me.btnEmptyWeek.UseVisualStyleBackColor = True
        '
        'dlgTemperatureCalendar
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(784, 361)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnEmptyWeek)
        Me.Controls.Add(Me.btnSaveWeekly)
        Me.Controls.Add(Me.btnLoadWeekly)
        Me.Controls.Add(Me.btnCopyForth)
        Me.Controls.Add(Me.btnCopyBack)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbDays)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgTemperatureCalendar"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Calendario"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.gbDays.ResumeLayout(False)
        Me.gbDays.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.nupHeatT1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupHeatT2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupHeatT3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.nupCoolT3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupCoolT2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupCoolT1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.nupHeatBP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupCoolBP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.nupFrostProt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupHeatEco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupCoolEco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents gbDays As GroupBox
    Friend WithEvents rbFestivo As RadioButton
    Friend WithEvents rbFeriale As RadioButton
    Friend WithEvents rbDay0 As RadioButton
    Friend WithEvents rbDay6 As RadioButton
    Friend WithEvents rbDay5 As RadioButton
    Friend WithEvents rbDay4 As RadioButton
    Friend WithEvents rbDay3 As RadioButton
    Friend WithEvents rbDay2 As RadioButton
    Friend WithEvents rbDay1 As RadioButton
    Friend WithEvents chkDayAll As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents nupHeatT1 As NumericUpDown
    Friend WithEvents nupHeatT2 As NumericUpDown
    Friend WithEvents nupHeatT3 As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents nupCoolT3 As NumericUpDown
    Friend WithEvents nupCoolT2 As NumericUpDown
    Friend WithEvents nupCoolT1 As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents nupHeatBP As NumericUpDown
    Friend WithEvents nupCoolBP As NumericUpDown
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents nupFrostProt As NumericUpDown
    Friend WithEvents nupHeatEco As NumericUpDown
    Friend WithEvents nupCoolEco As NumericUpDown
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnCopyBack As Button
    Friend WithEvents btnCopyForth As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbManual As ComboBox
    Friend WithEvents btnLoadWeekly As Button
    Friend WithEvents btnSaveWeekly As Button
    Friend WithEvents btnEmptyWeek As Button
End Class
