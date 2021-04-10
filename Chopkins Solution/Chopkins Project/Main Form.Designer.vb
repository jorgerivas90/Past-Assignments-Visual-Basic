<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.lbl12Pack = New System.Windows.Forms.Label()
        Me.lbl5Pack = New System.Windows.Forms.Label()
        Me.lbl2Pack = New System.Windows.Forms.Label()
        Me.lblTotals = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txt12Pack = New System.Windows.Forms.TextBox()
        Me.txt5Pack = New System.Windows.Forms.TextBox()
        Me.txt2Pack = New System.Windows.Forms.TextBox()
        Me.lblTotalOrdered = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl12Pack
        '
        Me.lbl12Pack.AutoSize = True
        Me.lbl12Pack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl12Pack.Location = New System.Drawing.Point(116, 57)
        Me.lbl12Pack.Name = "lbl12Pack"
        Me.lbl12Pack.Size = New System.Drawing.Size(70, 20)
        Me.lbl12Pack.TabIndex = 0
        Me.lbl12Pack.Text = "12 Pack:"
        '
        'lbl5Pack
        '
        Me.lbl5Pack.AutoSize = True
        Me.lbl5Pack.Location = New System.Drawing.Point(116, 94)
        Me.lbl5Pack.Name = "lbl5Pack"
        Me.lbl5Pack.Size = New System.Drawing.Size(61, 20)
        Me.lbl5Pack.TabIndex = 2
        Me.lbl5Pack.Text = "5 Pack:"
        '
        'lbl2Pack
        '
        Me.lbl2Pack.AutoSize = True
        Me.lbl2Pack.Location = New System.Drawing.Point(116, 129)
        Me.lbl2Pack.Name = "lbl2Pack"
        Me.lbl2Pack.Size = New System.Drawing.Size(61, 20)
        Me.lbl2Pack.TabIndex = 4
        Me.lbl2Pack.Text = "2 Pack:"
        '
        'lblTotals
        '
        Me.lblTotals.AutoSize = True
        Me.lblTotals.Location = New System.Drawing.Point(116, 167)
        Me.lblTotals.Name = "lblTotals"
        Me.lblTotals.Size = New System.Drawing.Size(56, 20)
        Me.lblTotals.TabIndex = 6
        Me.lblTotals.Text = "Totals:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(133, 223)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(105, 46)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(290, 223)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(110, 46)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txt12Pack
        '
        Me.txt12Pack.Location = New System.Drawing.Point(188, 57)
        Me.txt12Pack.Name = "txt12Pack"
        Me.txt12Pack.Size = New System.Drawing.Size(70, 26)
        Me.txt12Pack.TabIndex = 9
        '
        'txt5Pack
        '
        Me.txt5Pack.Location = New System.Drawing.Point(188, 89)
        Me.txt5Pack.Name = "txt5Pack"
        Me.txt5Pack.Size = New System.Drawing.Size(70, 26)
        Me.txt5Pack.TabIndex = 11
        '
        'txt2Pack
        '
        Me.txt2Pack.Location = New System.Drawing.Point(188, 123)
        Me.txt2Pack.Name = "txt2Pack"
        Me.txt2Pack.Size = New System.Drawing.Size(70, 26)
        Me.txt2Pack.TabIndex = 13
        '
        'lblTotalOrdered
        '
        Me.lblTotalOrdered.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalOrdered.Location = New System.Drawing.Point(188, 166)
        Me.lblTotalOrdered.Name = "lblTotalOrdered"
        Me.lblTotalOrdered.Size = New System.Drawing.Size(70, 32)
        Me.lblTotalOrdered.TabIndex = 14
        '
        'lblCost
        '
        Me.lblCost.BackColor = System.Drawing.Color.Gold
        Me.lblCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCost.Location = New System.Drawing.Point(290, 167)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(110, 31)
        Me.lblCost.TabIndex = 15
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblTotalOrdered)
        Me.Controls.Add(Me.txt2Pack)
        Me.Controls.Add(Me.txt5Pack)
        Me.Controls.Add(Me.txt12Pack)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblTotals)
        Me.Controls.Add(Me.lbl2Pack)
        Me.Controls.Add(Me.lbl5Pack)
        Me.Controls.Add(Me.lbl12Pack)
        Me.Name = "frmMain"
        Me.Text = "Chopkins Toys"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl12Pack As Label
    Friend WithEvents lbl5Pack As Label
    Friend WithEvents lbl2Pack As Label
    Friend WithEvents lblTotals As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button



    Friend WithEvents txt12Pack As TextBox
    Friend WithEvents txt5Pack As TextBox
    Friend WithEvents txt2Pack As TextBox
    Friend WithEvents lblTotalOrdered As Label
    Friend WithEvents lblCost As Label
End Class
