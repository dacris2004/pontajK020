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
        Me.lblUser1 = New System.Windows.Forms.Label()
        Me.lblUser2 = New System.Windows.Forms.Label()
        Me.lblUser3 = New System.Windows.Forms.Label()
        Me.btnUser1 = New System.Windows.Forms.Button()
        Me.btnUser2 = New System.Windows.Forms.Button()
        Me.btnUser3 = New System.Windows.Forms.Button()
        Me.listInfoPontaj = New System.Windows.Forms.ListBox()
        Me.btnPonteaza = New System.Windows.Forms.Button()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblUser1
        '
        Me.lblUser1.AutoSize = True
        Me.lblUser1.Location = New System.Drawing.Point(31, 37)
        Me.lblUser1.Name = "lblUser1"
        Me.lblUser1.Size = New System.Drawing.Size(91, 20)
        Me.lblUser1.TabIndex = 0
        Me.lblUser1.Text = "user1Name"
        '
        'lblUser2
        '
        Me.lblUser2.AutoSize = True
        Me.lblUser2.Location = New System.Drawing.Point(31, 97)
        Me.lblUser2.Name = "lblUser2"
        Me.lblUser2.Size = New System.Drawing.Size(91, 20)
        Me.lblUser2.TabIndex = 1
        Me.lblUser2.Text = "user2Name"
        '
        'lblUser3
        '
        Me.lblUser3.AutoSize = True
        Me.lblUser3.Location = New System.Drawing.Point(31, 157)
        Me.lblUser3.Name = "lblUser3"
        Me.lblUser3.Size = New System.Drawing.Size(91, 20)
        Me.lblUser3.TabIndex = 2
        Me.lblUser3.Text = "user3Name"
        '
        'btnUser1
        '
        Me.btnUser1.Location = New System.Drawing.Point(162, 33)
        Me.btnUser1.Name = "btnUser1"
        Me.btnUser1.Size = New System.Drawing.Size(87, 31)
        Me.btnUser1.TabIndex = 3
        Me.btnUser1.Text = "status"
        Me.btnUser1.UseVisualStyleBackColor = True
        '
        'btnUser2
        '
        Me.btnUser2.Location = New System.Drawing.Point(162, 93)
        Me.btnUser2.Name = "btnUser2"
        Me.btnUser2.Size = New System.Drawing.Size(87, 31)
        Me.btnUser2.TabIndex = 4
        Me.btnUser2.Text = "status"
        Me.btnUser2.UseVisualStyleBackColor = True
        '
        'btnUser3
        '
        Me.btnUser3.Location = New System.Drawing.Point(162, 153)
        Me.btnUser3.Name = "btnUser3"
        Me.btnUser3.Size = New System.Drawing.Size(87, 31)
        Me.btnUser3.TabIndex = 5
        Me.btnUser3.Text = "status"
        Me.btnUser3.UseVisualStyleBackColor = True
        '
        'listInfoPontaj
        '
        Me.listInfoPontaj.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listInfoPontaj.ForeColor = System.Drawing.Color.White
        Me.listInfoPontaj.FormattingEnabled = True
        Me.listInfoPontaj.ItemHeight = 22
        Me.listInfoPontaj.Location = New System.Drawing.Point(275, 33)
        Me.listInfoPontaj.Name = "listInfoPontaj"
        Me.listInfoPontaj.Size = New System.Drawing.Size(272, 70)
        Me.listInfoPontaj.TabIndex = 6
        '
        'btnPonteaza
        '
        Me.btnPonteaza.Location = New System.Drawing.Point(446, 153)
        Me.btnPonteaza.Name = "btnPonteaza"
        Me.btnPonteaza.Size = New System.Drawing.Size(101, 31)
        Me.btnPonteaza.TabIndex = 7
        Me.btnPonteaza.Text = "Ponteaza"
        Me.btnPonteaza.UseVisualStyleBackColor = True
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(490, 204)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(0, 20)
        Me.lblInfo.TabIndex = 8
        '
        'frmMain
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 249)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.btnPonteaza)
        Me.Controls.Add(Me.listInfoPontaj)
        Me.Controls.Add(Me.btnUser3)
        Me.Controls.Add(Me.btnUser2)
        Me.Controls.Add(Me.btnUser1)
        Me.Controls.Add(Me.lblUser3)
        Me.Controls.Add(Me.lblUser2)
        Me.Controls.Add(Me.lblUser1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pontaj K020 Targoviste"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUser1 As Label
    Friend WithEvents lblUser2 As Label
    Friend WithEvents lblUser3 As Label
    Friend WithEvents btnUser1 As Button
    Friend WithEvents btnUser2 As Button
    Friend WithEvents btnUser3 As Button
    Friend WithEvents listInfoPontaj As ListBox
    Friend WithEvents btnPonteaza As Button
    Friend WithEvents lblInfo As Label
End Class
