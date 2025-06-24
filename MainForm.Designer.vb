<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.knapsackBtn = New System.Windows.Forms.Button()
        Me.decimationBtn = New System.Windows.Forms.Button()
        Me.caesarBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'knapsackBtn
        '
        Me.knapsackBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.knapsackBtn.Location = New System.Drawing.Point(530, 245)
        Me.knapsackBtn.Name = "knapsackBtn"
        Me.knapsackBtn.Size = New System.Drawing.Size(173, 64)
        Me.knapsackBtn.TabIndex = 3
        Me.knapsackBtn.Text = "Knapsack"
        Me.knapsackBtn.UseVisualStyleBackColor = True
        '
        'decimationBtn
        '
        Me.decimationBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decimationBtn.Location = New System.Drawing.Point(314, 245)
        Me.decimationBtn.Name = "decimationBtn"
        Me.decimationBtn.Size = New System.Drawing.Size(173, 64)
        Me.decimationBtn.TabIndex = 2
        Me.decimationBtn.Text = "Decimation Cipher"
        Me.decimationBtn.UseVisualStyleBackColor = True
        '
        'caesarBtn
        '
        Me.caesarBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.caesarBtn.Location = New System.Drawing.Point(97, 245)
        Me.caesarBtn.Name = "caesarBtn"
        Me.caesarBtn.Size = New System.Drawing.Size(173, 64)
        Me.caesarBtn.TabIndex = 1
        Me.caesarBtn.Text = "Caesar Cipher"
        Me.caesarBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(297, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(207, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Choose your cipher:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(176, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(449, 32)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "WELCOME TO HELLO CIPHER!"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 372)
        Me.Controls.Add(Me.knapsackBtn)
        Me.Controls.Add(Me.decimationBtn)
        Me.Controls.Add(Me.caesarBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents knapsackBtn As Button
    Friend WithEvents decimationBtn As Button
    Friend WithEvents caesarBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
