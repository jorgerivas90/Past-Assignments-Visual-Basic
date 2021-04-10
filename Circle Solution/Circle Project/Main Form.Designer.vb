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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRadius = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Radius:"
        '
        'txtRadius
        '
        Me.txtRadius.Location = New System.Drawing.Point(47, 38)
        Me.txtRadius.Name = "txtRadius"
        Me.txtRadius.Size = New System.Drawing.Size(59, 33)
        Me.txtRadius.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(149, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 28)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Area:"
        '
        'lblArea
        '
        Me.lblArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblArea.Location = New System.Drawing.Point(154, 38)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(63, 33)
        Me.lblArea.TabIndex = 5
        Me.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(12, 96)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(104, 41)
        Me.btnCalc.TabIndex = 2
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(146, 96)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(106, 41)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 179)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtRadius)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Circle Area"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtRadius As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblArea As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
End Class
