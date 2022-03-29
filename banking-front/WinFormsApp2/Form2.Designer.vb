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
        Me.SuspendLayout()
        '
        'phoneNumber
        '
        Me.phoneNumber.Location = New System.Drawing.Point(373, 269)
        Me.phoneNumber.Name = "phoneNumber"
        Me.phoneNumber.PlaceholderText = "Enter Phone Number"
        Me.phoneNumber.Size = New System.Drawing.Size(299, 39)
        Me.phoneNumber.TabIndex = 0
        '
        'pin
        '
        Me.pin.Location = New System.Drawing.Point(373, 371)
        Me.pin.Name = "pin"
        Me.pin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pin.PlaceholderText = "Enter Pin"
        Me.pin.Size = New System.Drawing.Size(299, 39)
        Me.pin.TabIndex = 1
        '
        'submit_button
        '
        Me.submit_button.Location = New System.Drawing.Point(440, 459)
        Me.submit_button.Name = "submit_button"
        Me.submit_button.Size = New System.Drawing.Size(150, 46)
        Me.submit_button.TabIndex = 2
        Me.submit_button.Text = "Submit"
        Me.submit_button.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(475, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 32)
        Me.Label1.TabIndex = 3
        '
        'apiMessage
        '
        Me.apiMessage.AutoSize = True
        Me.apiMessage.Location = New System.Drawing.Point(402, 549)
        Me.apiMessage.Name = "apiMessage"
        Me.apiMessage.Size = New System.Drawing.Size(0, 32)
        Me.apiMessage.TabIndex = 4
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1071, 658)
        Me.Controls.Add(Me.apiMessage)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.submit_button)
        Me.Controls.Add(Me.pin)
        Me.Controls.Add(Me.phoneNumber)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents phoneNumber As TextBox
    Friend WithEvents pin As TextBox
    Friend WithEvents submit_button As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents apiMessage As Label
End Class
