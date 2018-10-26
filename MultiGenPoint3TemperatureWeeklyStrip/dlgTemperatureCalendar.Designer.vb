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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkDayAll = New System.Windows.Forms.CheckBox()
        Me.rbDay6_7 = New System.Windows.Forms.RadioButton()
        Me.rbDay1_5 = New System.Windows.Forms.RadioButton()
        Me.rbDay7 = New System.Windows.Forms.RadioButton()
        Me.rbDay6 = New System.Windows.Forms.RadioButton()
        Me.rbDay5 = New System.Windows.Forms.RadioButton()
        Me.rbDay4 = New System.Windows.Forms.RadioButton()
        Me.rbDay3 = New System.Windows.Forms.RadioButton()
        Me.rbDay2 = New System.Windows.Forms.RadioButton()
        Me.rbDay1 = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanel1.SuspendLayout()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(626, 305)
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
        Me.Label1.Location = New System.Drawing.Point(26, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "T3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "T2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "T1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkDayAll)
        Me.GroupBox1.Controls.Add(Me.rbDay6_7)
        Me.GroupBox1.Controls.Add(Me.rbDay1_5)
        Me.GroupBox1.Controls.Add(Me.rbDay7)
        Me.GroupBox1.Controls.Add(Me.rbDay6)
        Me.GroupBox1.Controls.Add(Me.rbDay5)
        Me.GroupBox1.Controls.Add(Me.rbDay4)
        Me.GroupBox1.Controls.Add(Me.rbDay3)
        Me.GroupBox1.Controls.Add(Me.rbDay2)
        Me.GroupBox1.Controls.Add(Me.rbDay1)
        Me.GroupBox1.Location = New System.Drawing.Point(52, 122)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(717, 37)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
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
        'rbDay6_7
        '
        Me.rbDay6_7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbDay6_7.AutoSize = True
        Me.rbDay6_7.Location = New System.Drawing.Point(653, 14)
        Me.rbDay6_7.Name = "rbDay6_7"
        Me.rbDay6_7.Size = New System.Drawing.Size(52, 17)
        Me.rbDay6_7.TabIndex = 0
        Me.rbDay6_7.TabStop = True
        Me.rbDay6_7.Text = "Festivi"
        Me.rbDay6_7.UseVisualStyleBackColor = True
        '
        'rbDay1_5
        '
        Me.rbDay1_5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbDay1_5.AutoSize = True
        Me.rbDay1_5.Location = New System.Drawing.Point(596, 14)
        Me.rbDay1_5.Name = "rbDay1_5"
        Me.rbDay1_5.Size = New System.Drawing.Size(52, 17)
        Me.rbDay1_5.TabIndex = 0
        Me.rbDay1_5.TabStop = True
        Me.rbDay1_5.Text = "Feriali"
        Me.rbDay1_5.UseVisualStyleBackColor = True
        '
        'rbDay7
        '
        Me.rbDay7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbDay7.AutoSize = True
        Me.rbDay7.Location = New System.Drawing.Point(405, 14)
        Me.rbDay7.Name = "rbDay7"
        Me.rbDay7.Size = New System.Drawing.Size(73, 17)
        Me.rbDay7.TabIndex = 0
        Me.rbDay7.TabStop = True
        Me.rbDay7.Text = "Domenica"
        Me.rbDay7.UseVisualStyleBackColor = True
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
        'dlgTemperatureCalendar
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(784, 346)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
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
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbDay6_7 As RadioButton
    Friend WithEvents rbDay1_5 As RadioButton
    Friend WithEvents rbDay7 As RadioButton
    Friend WithEvents rbDay6 As RadioButton
    Friend WithEvents rbDay5 As RadioButton
    Friend WithEvents rbDay4 As RadioButton
    Friend WithEvents rbDay3 As RadioButton
    Friend WithEvents rbDay2 As RadioButton
    Friend WithEvents rbDay1 As RadioButton
    Friend WithEvents chkDayAll As CheckBox
End Class
