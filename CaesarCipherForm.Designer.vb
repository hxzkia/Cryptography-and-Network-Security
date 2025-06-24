<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CaesarCipherForm
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
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.backBtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.shiftBox = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.transformTB = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.encryptBtn = New System.Windows.Forms.RadioButton()
        Me.decryptBtn = New System.Windows.Forms.RadioButton()
        Me.resultTB = New System.Windows.Forms.TextBox()
        CType(Me.shiftBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'closeBtn
        '
        Me.closeBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeBtn.Location = New System.Drawing.Point(428, 325)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(89, 43)
        Me.closeBtn.TabIndex = 7
        Me.closeBtn.Text = "Close"
        Me.closeBtn.UseVisualStyleBackColor = True
        '
        'backBtn
        '
        Me.backBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backBtn.Location = New System.Drawing.Point(329, 325)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(89, 43)
        Me.backBtn.TabIndex = 6
        Me.backBtn.Text = "Back"
        Me.backBtn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 25)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Shift:"
        '
        'shiftBox
        '
        Me.shiftBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shiftBox.Location = New System.Drawing.Point(76, 181)
        Me.shiftBox.Maximum = New Decimal(New Integer() {25, 0, 0, 0})
        Me.shiftBox.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.shiftBox.Name = "shiftBox"
        Me.shiftBox.ReadOnly = True
        Me.shiftBox.Size = New System.Drawing.Size(71, 27)
        Me.shiftBox.TabIndex = 2
        Me.shiftBox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 248)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 25)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Result"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 25)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Text to transform"
        '
        'transformTB
        '
        Me.transformTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transformTB.Location = New System.Drawing.Point(12, 48)
        Me.transformTB.Multiline = True
        Me.transformTB.Name = "transformTB"
        Me.transformTB.Size = New System.Drawing.Size(298, 89)
        Me.transformTB.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.encryptBtn)
        Me.GroupBox1.Controls.Add(Me.decryptBtn)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(340, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(177, 90)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Process"
        '
        'encryptBtn
        '
        Me.encryptBtn.AutoSize = True
        Me.encryptBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.encryptBtn.Location = New System.Drawing.Point(6, 29)
        Me.encryptBtn.Name = "encryptBtn"
        Me.encryptBtn.Size = New System.Drawing.Size(87, 24)
        Me.encryptBtn.TabIndex = 4
        Me.encryptBtn.Text = "Encrypt"
        Me.encryptBtn.UseVisualStyleBackColor = True
        '
        'decryptBtn
        '
        Me.decryptBtn.AutoSize = True
        Me.decryptBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decryptBtn.Location = New System.Drawing.Point(6, 59)
        Me.decryptBtn.Name = "decryptBtn"
        Me.decryptBtn.Size = New System.Drawing.Size(89, 24)
        Me.decryptBtn.TabIndex = 5
        Me.decryptBtn.Text = "Decrypt"
        Me.decryptBtn.UseVisualStyleBackColor = True
        '
        'resultTB
        '
        Me.resultTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultTB.Location = New System.Drawing.Point(12, 276)
        Me.resultTB.Multiline = True
        Me.resultTB.Name = "resultTB"
        Me.resultTB.ReadOnly = True
        Me.resultTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.resultTB.Size = New System.Drawing.Size(298, 92)
        Me.resultTB.TabIndex = 19
        '
        'CaesarCipherForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 384)
        Me.Controls.Add(Me.resultTB)
        Me.Controls.Add(Me.closeBtn)
        Me.Controls.Add(Me.backBtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.shiftBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.transformTB)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CaesarCipherForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Caesar Cipher"
        CType(Me.shiftBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents closeBtn As Button
    Friend WithEvents backBtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents shiftBox As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents transformTB As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents encryptBtn As RadioButton
    Friend WithEvents decryptBtn As RadioButton
    Friend WithEvents resultTB As TextBox
End Class
