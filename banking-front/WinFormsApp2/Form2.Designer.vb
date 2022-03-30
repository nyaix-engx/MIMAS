<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.phoneNumber = New System.Windows.Forms.TextBox()
        Me.pin = New System.Windows.Forms.TextBox()
        Me.submit_button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.apiMessage = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'phoneNumber
        '
        Me.phoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.phoneNumber.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.phoneNumber.Location = New System.Drawing.Point(22, 27)
        Me.phoneNumber.Name = "phoneNumber"
        Me.phoneNumber.PlaceholderText = "Enter Phone Number"
        Me.phoneNumber.Size = New System.Drawing.Size(264, 32)
        Me.phoneNumber.TabIndex = 0
        '
        'pin
        '
        Me.pin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.pin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.pin.Location = New System.Drawing.Point(22, 18)
        Me.pin.Name = "pin"
        Me.pin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pin.PlaceholderText = "Enter Pin"
        Me.pin.Size = New System.Drawing.Size(251, 32)
        Me.pin.TabIndex = 1
        '
        'submit_button
        '
        Me.submit_button.BackColor = System.Drawing.Color.Gold
        Me.submit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.submit_button.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.submit_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.submit_button.Location = New System.Drawing.Point(449, 507)
        Me.submit_button.Name = "submit_button"
        Me.submit_button.Size = New System.Drawing.Size(150, 62)
        Me.submit_button.TabIndex = 2
        Me.submit_button.Text = "Submit"
        Me.submit_button.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(407, 250)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 32)
        Me.Label1.TabIndex = 3
        '
        'apiMessage
        '
        Me.apiMessage.AutoSize = True
        Me.apiMessage.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.apiMessage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.apiMessage.Location = New System.Drawing.Point(449, 595)
        Me.apiMessage.Name = "apiMessage"
        Me.apiMessage.Size = New System.Drawing.Size(0, 32)
        Me.apiMessage.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.phoneNumber)
        Me.Panel1.Location = New System.Drawing.Point(375, 272)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(296, 80)
        Me.Panel1.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel2.Controls.Add(Me.pin)
        Me.Panel2.Location = New System.Drawing.Point(375, 382)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(296, 74)
        Me.Panel2.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label2.Location = New System.Drawing.Point(449, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 45)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "MIMAS"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1071, 658)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.apiMessage)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.submit_button)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents phoneNumber As TextBox
    Friend WithEvents pin As TextBox
    Friend WithEvents submit_button As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents apiMessage As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
End Class
