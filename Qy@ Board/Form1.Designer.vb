<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PortDataListBox = New System.Windows.Forms.ListBox()
        Me.PortOpenButton = New System.Windows.Forms.Button()
        Me.ComPortListBox = New System.Windows.Forms.ListBox()
        Me.BaudRateListBox = New System.Windows.Forms.ListBox()
        Me.ComPortButton = New System.Windows.Forms.Button()
        Me.BaudRateButton = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Clear5Button = New System.Windows.Forms.Button()
        Me.Clear4Button = New System.Windows.Forms.Button()
        Me.RXLabel = New System.Windows.Forms.Label()
        Me.TXLabel = New System.Windows.Forms.Label()
        Me.Clear3Button = New System.Windows.Forms.Button()
        Me.Clear1Button = New System.Windows.Forms.Button()
        Me.RXDecListBox = New System.Windows.Forms.ListBox()
        Me.TXDataListBox = New System.Windows.Forms.ListBox()
        Me.RXAscListBox = New System.Windows.Forms.ListBox()
        Me.Clear2Button = New System.Windows.Forms.Button()
        Me.RXAscLabel = New System.Windows.Forms.Label()
        Me.RXDecLabel = New System.Windows.Forms.Label()
        Me.DOut8Button = New System.Windows.Forms.Button()
        Me.DOut7Button = New System.Windows.Forms.Button()
        Me.DOut6Button = New System.Windows.Forms.Button()
        Me.DOut5Button = New System.Windows.Forms.Button()
        Me.DOut4Button = New System.Windows.Forms.Button()
        Me.DOut3Button = New System.Windows.Forms.Button()
        Me.DOut2Button = New System.Windows.Forms.Button()
        Me.DIn1Label = New System.Windows.Forms.Label()
        Me.AnOut2Button = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DOut1Button = New System.Windows.Forms.Button()
        Me.DIn1Button = New System.Windows.Forms.Button()
        Me.AnOut1Button = New System.Windows.Forms.Button()
        Me.Analog4Button = New System.Windows.Forms.Button()
        Me.Analog3Button = New System.Windows.Forms.Button()
        Me.Analog2Button = New System.Windows.Forms.Button()
        Me.Analog1Button = New System.Windows.Forms.Button()
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(876, 539)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PortDataListBox)
        Me.TabPage1.Controls.Add(Me.PortOpenButton)
        Me.TabPage1.Controls.Add(Me.ComPortListBox)
        Me.TabPage1.Controls.Add(Me.BaudRateListBox)
        Me.TabPage1.Controls.Add(Me.ComPortButton)
        Me.TabPage1.Controls.Add(Me.BaudRateButton)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(868, 506)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Connect to Serial Port"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'PortDataListBox
        '
        Me.PortDataListBox.FormattingEnabled = True
        Me.PortDataListBox.ItemHeight = 20
        Me.PortDataListBox.Location = New System.Drawing.Point(344, 12)
        Me.PortDataListBox.Name = "PortDataListBox"
        Me.PortDataListBox.Size = New System.Drawing.Size(173, 204)
        Me.PortDataListBox.TabIndex = 105
        '
        'PortOpenButton
        '
        Me.PortOpenButton.Location = New System.Drawing.Point(363, 227)
        Me.PortOpenButton.Name = "PortOpenButton"
        Me.PortOpenButton.Size = New System.Drawing.Size(154, 104)
        Me.PortOpenButton.TabIndex = 104
        Me.PortOpenButton.Text = "Connect"
        Me.PortOpenButton.UseVisualStyleBackColor = True
        '
        'ComPortListBox
        '
        Me.ComPortListBox.FormattingEnabled = True
        Me.ComPortListBox.ItemHeight = 20
        Me.ComPortListBox.Location = New System.Drawing.Point(207, 17)
        Me.ComPortListBox.Name = "ComPortListBox"
        Me.ComPortListBox.Size = New System.Drawing.Size(110, 184)
        Me.ComPortListBox.TabIndex = 103
        '
        'BaudRateListBox
        '
        Me.BaudRateListBox.FormattingEnabled = True
        Me.BaudRateListBox.ItemHeight = 20
        Me.BaudRateListBox.Location = New System.Drawing.Point(22, 17)
        Me.BaudRateListBox.Name = "BaudRateListBox"
        Me.BaudRateListBox.Size = New System.Drawing.Size(165, 204)
        Me.BaudRateListBox.TabIndex = 102
        '
        'ComPortButton
        '
        Me.ComPortButton.Location = New System.Drawing.Point(184, 222)
        Me.ComPortButton.Name = "ComPortButton"
        Me.ComPortButton.Size = New System.Drawing.Size(154, 104)
        Me.ComPortButton.TabIndex = 101
        Me.ComPortButton.Text = "Com Port"
        Me.ComPortButton.UseVisualStyleBackColor = True
        '
        'BaudRateButton
        '
        Me.BaudRateButton.Location = New System.Drawing.Point(22, 227)
        Me.BaudRateButton.Name = "BaudRateButton"
        Me.BaudRateButton.Size = New System.Drawing.Size(127, 95)
        Me.BaudRateButton.TabIndex = 100
        Me.BaudRateButton.Text = "Baud Rate"
        Me.BaudRateButton.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(868, 506)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Qy@ Board"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Clear5Button)
        Me.TabPage3.Controls.Add(Me.Clear4Button)
        Me.TabPage3.Controls.Add(Me.RXLabel)
        Me.TabPage3.Controls.Add(Me.TXLabel)
        Me.TabPage3.Controls.Add(Me.Clear3Button)
        Me.TabPage3.Controls.Add(Me.Clear1Button)
        Me.TabPage3.Controls.Add(Me.RXDecListBox)
        Me.TabPage3.Controls.Add(Me.TXDataListBox)
        Me.TabPage3.Controls.Add(Me.RXAscListBox)
        Me.TabPage3.Controls.Add(Me.Clear2Button)
        Me.TabPage3.Controls.Add(Me.RXAscLabel)
        Me.TabPage3.Controls.Add(Me.RXDecLabel)
        Me.TabPage3.Controls.Add(Me.DOut8Button)
        Me.TabPage3.Controls.Add(Me.DOut7Button)
        Me.TabPage3.Controls.Add(Me.DOut6Button)
        Me.TabPage3.Controls.Add(Me.DOut5Button)
        Me.TabPage3.Controls.Add(Me.DOut4Button)
        Me.TabPage3.Controls.Add(Me.DOut3Button)
        Me.TabPage3.Controls.Add(Me.DOut2Button)
        Me.TabPage3.Controls.Add(Me.DIn1Label)
        Me.TabPage3.Controls.Add(Me.AnOut2Button)
        Me.TabPage3.Controls.Add(Me.PictureBox1)
        Me.TabPage3.Controls.Add(Me.DOut1Button)
        Me.TabPage3.Controls.Add(Me.DIn1Button)
        Me.TabPage3.Controls.Add(Me.AnOut1Button)
        Me.TabPage3.Controls.Add(Me.Analog4Button)
        Me.TabPage3.Controls.Add(Me.Analog3Button)
        Me.TabPage3.Controls.Add(Me.Analog2Button)
        Me.TabPage3.Controls.Add(Me.Analog1Button)
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(868, 506)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Testing"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Clear5Button
        '
        Me.Clear5Button.Location = New System.Drawing.Point(733, 186)
        Me.Clear5Button.Name = "Clear5Button"
        Me.Clear5Button.Size = New System.Drawing.Size(116, 62)
        Me.Clear5Button.TabIndex = 177
        Me.Clear5Button.Text = "Clear All "
        Me.Clear5Button.UseVisualStyleBackColor = True
        '
        'Clear4Button
        '
        Me.Clear4Button.Location = New System.Drawing.Point(198, 186)
        Me.Clear4Button.Name = "Clear4Button"
        Me.Clear4Button.Size = New System.Drawing.Size(116, 62)
        Me.Clear4Button.TabIndex = 176
        Me.Clear4Button.Text = "Clear RX "
        Me.Clear4Button.UseVisualStyleBackColor = True
        '
        'RXLabel
        '
        Me.RXLabel.AutoSize = True
        Me.RXLabel.Location = New System.Drawing.Point(194, 139)
        Me.RXLabel.Name = "RXLabel"
        Me.RXLabel.Size = New System.Drawing.Size(18, 20)
        Me.RXLabel.TabIndex = 175
        Me.RXLabel.Text = "0"
        '
        'TXLabel
        '
        Me.TXLabel.AutoSize = True
        Me.TXLabel.Location = New System.Drawing.Point(366, 163)
        Me.TXLabel.Name = "TXLabel"
        Me.TXLabel.Size = New System.Drawing.Size(18, 20)
        Me.TXLabel.TabIndex = 174
        Me.TXLabel.Text = "0"
        '
        'Clear3Button
        '
        Me.Clear3Button.Location = New System.Drawing.Point(597, 186)
        Me.Clear3Button.Name = "Clear3Button"
        Me.Clear3Button.Size = New System.Drawing.Size(116, 62)
        Me.Clear3Button.TabIndex = 173
        Me.Clear3Button.Text = "Clear RX Decimal"
        Me.Clear3Button.UseVisualStyleBackColor = True
        '
        'Clear1Button
        '
        Me.Clear1Button.Location = New System.Drawing.Point(331, 186)
        Me.Clear1Button.Name = "Clear1Button"
        Me.Clear1Button.Size = New System.Drawing.Size(119, 62)
        Me.Clear1Button.TabIndex = 171
        Me.Clear1Button.Text = "Clear TX"
        Me.Clear1Button.UseVisualStyleBackColor = True
        '
        'RXDecListBox
        '
        Me.RXDecListBox.FormattingEnabled = True
        Me.RXDecListBox.ItemHeight = 20
        Me.RXDecListBox.Location = New System.Drawing.Point(597, 16)
        Me.RXDecListBox.Name = "RXDecListBox"
        Me.RXDecListBox.Size = New System.Drawing.Size(128, 144)
        Me.RXDecListBox.TabIndex = 170
        '
        'TXDataListBox
        '
        Me.TXDataListBox.FormattingEnabled = True
        Me.TXDataListBox.ItemHeight = 20
        Me.TXDataListBox.Location = New System.Drawing.Point(347, 15)
        Me.TXDataListBox.Name = "TXDataListBox"
        Me.TXDataListBox.Size = New System.Drawing.Size(101, 144)
        Me.TXDataListBox.TabIndex = 169
        '
        'RXAscListBox
        '
        Me.RXAscListBox.FormattingEnabled = True
        Me.RXAscListBox.ItemHeight = 20
        Me.RXAscListBox.Location = New System.Drawing.Point(466, 16)
        Me.RXAscListBox.Name = "RXAscListBox"
        Me.RXAscListBox.Size = New System.Drawing.Size(116, 144)
        Me.RXAscListBox.TabIndex = 168
        '
        'Clear2Button
        '
        Me.Clear2Button.Location = New System.Drawing.Point(466, 186)
        Me.Clear2Button.Name = "Clear2Button"
        Me.Clear2Button.Size = New System.Drawing.Size(116, 62)
        Me.Clear2Button.TabIndex = 172
        Me.Clear2Button.Text = "Clear RX Character"
        Me.Clear2Button.UseVisualStyleBackColor = True
        '
        'RXAscLabel
        '
        Me.RXAscLabel.AutoSize = True
        Me.RXAscLabel.Location = New System.Drawing.Point(483, 163)
        Me.RXAscLabel.Name = "RXAscLabel"
        Me.RXAscLabel.Size = New System.Drawing.Size(18, 20)
        Me.RXAscLabel.TabIndex = 167
        Me.RXAscLabel.Text = "0"
        '
        'RXDecLabel
        '
        Me.RXDecLabel.AutoSize = True
        Me.RXDecLabel.Location = New System.Drawing.Point(608, 163)
        Me.RXDecLabel.Name = "RXDecLabel"
        Me.RXDecLabel.Size = New System.Drawing.Size(18, 20)
        Me.RXDecLabel.TabIndex = 166
        Me.RXDecLabel.Text = "0"
        '
        'DOut8Button
        '
        Me.DOut8Button.Location = New System.Drawing.Point(642, 437)
        Me.DOut8Button.Name = "DOut8Button"
        Me.DOut8Button.Size = New System.Drawing.Size(139, 49)
        Me.DOut8Button.TabIndex = 165
        Me.DOut8Button.Text = "Digital Output 8"
        Me.DOut8Button.UseVisualStyleBackColor = True
        '
        'DOut7Button
        '
        Me.DOut7Button.Location = New System.Drawing.Point(642, 382)
        Me.DOut7Button.Name = "DOut7Button"
        Me.DOut7Button.Size = New System.Drawing.Size(139, 49)
        Me.DOut7Button.TabIndex = 164
        Me.DOut7Button.Text = "Digital Output 7"
        Me.DOut7Button.UseVisualStyleBackColor = True
        '
        'DOut6Button
        '
        Me.DOut6Button.Location = New System.Drawing.Point(642, 325)
        Me.DOut6Button.Name = "DOut6Button"
        Me.DOut6Button.Size = New System.Drawing.Size(139, 49)
        Me.DOut6Button.TabIndex = 163
        Me.DOut6Button.Text = "Digital Output 6"
        Me.DOut6Button.UseVisualStyleBackColor = True
        '
        'DOut5Button
        '
        Me.DOut5Button.Location = New System.Drawing.Point(642, 266)
        Me.DOut5Button.Name = "DOut5Button"
        Me.DOut5Button.Size = New System.Drawing.Size(139, 49)
        Me.DOut5Button.TabIndex = 162
        Me.DOut5Button.Text = "Digital Output 5"
        Me.DOut5Button.UseVisualStyleBackColor = True
        '
        'DOut4Button
        '
        Me.DOut4Button.Location = New System.Drawing.Point(487, 437)
        Me.DOut4Button.Name = "DOut4Button"
        Me.DOut4Button.Size = New System.Drawing.Size(139, 49)
        Me.DOut4Button.TabIndex = 161
        Me.DOut4Button.Text = "Digital Output 4"
        Me.DOut4Button.UseVisualStyleBackColor = True
        '
        'DOut3Button
        '
        Me.DOut3Button.Location = New System.Drawing.Point(487, 382)
        Me.DOut3Button.Name = "DOut3Button"
        Me.DOut3Button.Size = New System.Drawing.Size(139, 49)
        Me.DOut3Button.TabIndex = 160
        Me.DOut3Button.Text = "Digital Output 3"
        Me.DOut3Button.UseVisualStyleBackColor = True
        '
        'DOut2Button
        '
        Me.DOut2Button.Location = New System.Drawing.Point(487, 325)
        Me.DOut2Button.Name = "DOut2Button"
        Me.DOut2Button.Size = New System.Drawing.Size(139, 49)
        Me.DOut2Button.TabIndex = 159
        Me.DOut2Button.Text = "Digital Output 2"
        Me.DOut2Button.UseVisualStyleBackColor = True
        '
        'DIn1Label
        '
        Me.DIn1Label.AutoSize = True
        Me.DIn1Label.Location = New System.Drawing.Point(343, 391)
        Me.DIn1Label.Name = "DIn1Label"
        Me.DIn1Label.Size = New System.Drawing.Size(105, 20)
        Me.DIn1Label.TabIndex = 158
        Me.DIn1Label.Text = "Digital input 1"
        '
        'AnOut2Button
        '
        Me.AnOut2Button.Location = New System.Drawing.Point(175, 327)
        Me.AnOut2Button.Name = "AnOut2Button"
        Me.AnOut2Button.Size = New System.Drawing.Size(139, 49)
        Me.AnOut2Button.TabIndex = 155
        Me.AnOut2Button.Text = "Analog Output 2"
        Me.AnOut2Button.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Location = New System.Drawing.Point(347, 327)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 154
        Me.PictureBox1.TabStop = False
        '
        'DOut1Button
        '
        Me.DOut1Button.Location = New System.Drawing.Point(487, 266)
        Me.DOut1Button.Name = "DOut1Button"
        Me.DOut1Button.Size = New System.Drawing.Size(139, 49)
        Me.DOut1Button.TabIndex = 153
        Me.DOut1Button.Text = "Digital Output 1"
        Me.DOut1Button.UseVisualStyleBackColor = True
        '
        'DIn1Button
        '
        Me.DIn1Button.Location = New System.Drawing.Point(331, 266)
        Me.DIn1Button.Name = "DIn1Button"
        Me.DIn1Button.Size = New System.Drawing.Size(139, 49)
        Me.DIn1Button.TabIndex = 152
        Me.DIn1Button.Text = "Digital Inputs"
        Me.DIn1Button.UseVisualStyleBackColor = True
        '
        'AnOut1Button
        '
        Me.AnOut1Button.Location = New System.Drawing.Point(175, 266)
        Me.AnOut1Button.Name = "AnOut1Button"
        Me.AnOut1Button.Size = New System.Drawing.Size(139, 49)
        Me.AnOut1Button.TabIndex = 151
        Me.AnOut1Button.Text = "Analog Output 1"
        Me.AnOut1Button.UseVisualStyleBackColor = True
        '
        'Analog4Button
        '
        Me.Analog4Button.Location = New System.Drawing.Point(16, 445)
        Me.Analog4Button.Name = "Analog4Button"
        Me.Analog4Button.Size = New System.Drawing.Size(139, 47)
        Me.Analog4Button.TabIndex = 150
        Me.Analog4Button.Text = "Analog Input 4"
        Me.Analog4Button.UseVisualStyleBackColor = True
        '
        'Analog3Button
        '
        Me.Analog3Button.Location = New System.Drawing.Point(16, 382)
        Me.Analog3Button.Name = "Analog3Button"
        Me.Analog3Button.Size = New System.Drawing.Size(139, 49)
        Me.Analog3Button.TabIndex = 149
        Me.Analog3Button.Text = "Analog Input 3"
        Me.Analog3Button.UseVisualStyleBackColor = True
        '
        'Analog2Button
        '
        Me.Analog2Button.Location = New System.Drawing.Point(16, 327)
        Me.Analog2Button.Name = "Analog2Button"
        Me.Analog2Button.Size = New System.Drawing.Size(139, 47)
        Me.Analog2Button.TabIndex = 148
        Me.Analog2Button.Text = "Analog Input 2"
        Me.Analog2Button.UseVisualStyleBackColor = True
        '
        'Analog1Button
        '
        Me.Analog1Button.Location = New System.Drawing.Point(16, 266)
        Me.Analog1Button.Name = "Analog1Button"
        Me.Analog1Button.Size = New System.Drawing.Size(139, 49)
        Me.Analog1Button.TabIndex = 147
        Me.Analog1Button.Text = "Analog Input 1"
        Me.Analog1Button.UseVisualStyleBackColor = True
        '
        'QuitButton
        '
        Me.QuitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.QuitButton.Location = New System.Drawing.Point(918, 559)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(82, 76)
        Me.QuitButton.TabIndex = 53
        Me.QuitButton.Text = "Quit"
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'SerialPort1
        '
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 666)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents QuitButton As Button
    Friend WithEvents PortDataListBox As ListBox
    Friend WithEvents PortOpenButton As Button
    Friend WithEvents ComPortListBox As ListBox
    Friend WithEvents BaudRateListBox As ListBox
    Friend WithEvents ComPortButton As Button
    Friend WithEvents BaudRateButton As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DOut8Button As Button
    Friend WithEvents DOut7Button As Button
    Friend WithEvents DOut6Button As Button
    Friend WithEvents DOut5Button As Button
    Friend WithEvents DOut4Button As Button
    Friend WithEvents DOut3Button As Button
    Friend WithEvents DOut2Button As Button
    Friend WithEvents DIn1Label As Label
    Friend WithEvents AnOut2Button As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DOut1Button As Button
    Friend WithEvents DIn1Button As Button
    Friend WithEvents AnOut1Button As Button
    Friend WithEvents Analog4Button As Button
    Friend WithEvents Analog3Button As Button
    Friend WithEvents Analog2Button As Button
    Friend WithEvents Analog1Button As Button
    Friend WithEvents Clear5Button As Button
    Friend WithEvents Clear4Button As Button
    Friend WithEvents RXLabel As Label
    Friend WithEvents TXLabel As Label
    Friend WithEvents Clear3Button As Button
    Friend WithEvents Clear1Button As Button
    Friend WithEvents RXDecListBox As ListBox
    Friend WithEvents TXDataListBox As ListBox
    Friend WithEvents RXAscListBox As ListBox
    Friend WithEvents Clear2Button As Button
    Friend WithEvents RXAscLabel As Label
    Friend WithEvents RXDecLabel As Label
End Class
