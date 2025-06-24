<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KnapsackForm
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
        Me.resultTB = New System.Windows.Forms.TextBox()
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.backBtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.transformTB = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.encryptBtn = New System.Windows.Forms.RadioButton()
        Me.decryptBtn = New System.Windows.Forms.RadioButton()
        Me.privateKeyTB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mTB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nTB = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'resultTB
        '
        Me.resultTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultTB.Location = New System.Drawing.Point(12, 346)
        Me.resultTB.Multiline = True
        Me.resultTB.Name = "resultTB"
        Me.resultTB.ReadOnly = True
        Me.resultTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.resultTB.Size = New System.Drawing.Size(450, 129)
        Me.resultTB.TabIndex = 28
        '
        'closeBtn
        '
        Me.closeBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeBtn.Location = New System.Drawing.Point(567, 432)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(89, 43)
        Me.closeBtn.TabIndex = 8
        Me.closeBtn.Text = "Close"
        Me.closeBtn.UseVisualStyleBackColor = True
        '
        'backBtn
        '
        Me.backBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backBtn.Location = New System.Drawing.Point(468, 432)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(89, 43)
        Me.backBtn.TabIndex = 7
        Me.backBtn.Text = "Back"
        Me.backBtn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 25)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Private Key:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 318)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 25)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Result"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 25)
        Me.Label1.TabIndex = 25
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
        Me.GroupBox1.TabIndex = 24
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
        Me.encryptBtn.TabIndex = 5
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
        Me.decryptBtn.TabIndex = 6
        Me.decryptBtn.Text = "Decrypt"
        Me.decryptBtn.UseVisualStyleBackColor = True
        '
        'privateKeyTB
        '
        Me.privateKeyTB.Location = New System.Drawing.Point(143, 159)
        Me.privateKeyTB.Name = "privateKeyTB"
        Me.privateKeyTB.Size = New System.Drawing.Size(250, 22)
        Me.privateKeyTB.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 25)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "n:"
        '
        'mTB
        '
        Me.mTB.Location = New System.Drawing.Point(44, 266)
        Me.mTB.Name = "mTB"
        Me.mTB.Size = New System.Drawing.Size(93, 22)
        Me.mTB.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 263)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 25)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "m:"
        '
        'nTB
        '
        Me.nTB.Location = New System.Drawing.Point(44, 210)
        Me.nTB.Name = "nTB"
        Me.nTB.Size = New System.Drawing.Size(93, 22)
        Me.nTB.TabIndex = 3
        '
        'KnapsackForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 487)
        Me.Controls.Add(Me.nTB)
        Me.Controls.Add(Me.mTB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.privateKeyTB)
        Me.Controls.Add(Me.resultTB)
        Me.Controls.Add(Me.closeBtn)
        Me.Controls.Add(Me.backBtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.transformTB)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "KnapsackForm"
        Me.Text = "KnapsackForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents resultTB As TextBox
    Friend WithEvents closeBtn As Button
    Friend WithEvents backBtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents transformTB As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents encryptBtn As RadioButton
    Friend WithEvents decryptBtn As RadioButton
    Friend WithEvents privateKeyTB As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents mTB As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents nTB As TextBox
End Class
