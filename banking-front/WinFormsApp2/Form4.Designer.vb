<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.header = New System.Windows.Forms.Label()
        Me.getCash = New System.Windows.Forms.Button()
        Me.getShare = New System.Windows.Forms.Button()
        Me.depositMoney = New System.Windows.Forms.Button()
        Me.buyShare = New System.Windows.Forms.Button()
        Me.sellShare = New System.Windows.Forms.Button()
        Me.withdrawCash = New System.Windows.Forms.Button()
        Me.Amount = New System.Windows.Forms.TextBox()
        Me.balanceInfo = New System.Windows.Forms.Label()
        Me.apiMessage = New System.Windows.Forms.Label()
        Me.logout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'header
        '
        Me.header.AutoSize = True
        Me.header.Location = New System.Drawing.Point(402, 62)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(120, 32)
        Me.header.TabIndex = 0
        Me.header.Text = "Welcome "
        '
        'getCash
        '
        Me.getCash.Location = New System.Drawing.Point(61, 295)
        Me.getCash.Name = "getCash"
        Me.getCash.Size = New System.Drawing.Size(281, 46)
        Me.getCash.TabIndex = 1
        Me.getCash.Text = "Cash Balance"
        Me.getCash.UseVisualStyleBackColor = True
        '
        'getShare
        '
        Me.getShare.Location = New System.Drawing.Point(764, 295)
        Me.getShare.Name = "getShare"
        Me.getShare.Size = New System.Drawing.Size(281, 46)
        Me.getShare.TabIndex = 1
        Me.getShare.Text = "Share Balance"
        Me.getShare.UseVisualStyleBackColor = True
        '
        'depositMoney
        '
        Me.depositMoney.Location = New System.Drawing.Point(61, 433)
        Me.depositMoney.Name = "depositMoney"
        Me.depositMoney.Size = New System.Drawing.Size(281, 46)
        Me.depositMoney.TabIndex = 1
        Me.depositMoney.Text = "Deposit Money"
        Me.depositMoney.UseVisualStyleBackColor = True
        '
        'buyShare
        '
        Me.buyShare.Location = New System.Drawing.Point(764, 433)
        Me.buyShare.Name = "buyShare"
        Me.buyShare.Size = New System.Drawing.Size(281, 46)
        Me.buyShare.TabIndex = 1
        Me.buyShare.Text = "Buy Share"
        Me.buyShare.UseVisualStyleBackColor = True
        '
        'sellShare
        '
        Me.sellShare.Location = New System.Drawing.Point(764, 524)
        Me.sellShare.Name = "sellShare"
        Me.sellShare.Size = New System.Drawing.Size(281, 46)
        Me.sellShare.TabIndex = 1
        Me.sellShare.Text = "Sell Share"
        Me.sellShare.UseVisualStyleBackColor = True
        '
        'withdrawCash
        '
        Me.withdrawCash.Location = New System.Drawing.Point(61, 531)
        Me.withdrawCash.Name = "withdrawCash"
        Me.withdrawCash.Size = New System.Drawing.Size(281, 46)
        Me.withdrawCash.TabIndex = 1
        Me.withdrawCash.Text = "Cash Withdrawal"
        Me.withdrawCash.UseVisualStyleBackColor = True
        '
        'Amount
        '
        Me.Amount.Location = New System.Drawing.Point(416, 373)
        Me.Amount.Name = "Amount"
        Me.Amount.PlaceholderText = "Enter Amount"
        Me.Amount.Size = New System.Drawing.Size(251, 39)
        Me.Amount.TabIndex = 2
        '
        'balanceInfo
        '
        Me.balanceInfo.AutoSize = True
        Me.balanceInfo.Location = New System.Drawing.Point(369, 175)
        Me.balanceInfo.Name = "balanceInfo"
        Me.balanceInfo.Size = New System.Drawing.Size(0, 32)
        Me.balanceInfo.TabIndex = 3
        '
        'apiMessage
        '
        Me.apiMessage.AutoSize = True
        Me.apiMessage.Location = New System.Drawing.Point(490, 621)
        Me.apiMessage.Name = "apiMessage"
        Me.apiMessage.Size = New System.Drawing.Size(0, 32)
        Me.apiMessage.TabIndex = 4
        '
        'logout
        '
        Me.logout.Location = New System.Drawing.Point(469, 621)
        Me.logout.Name = "logout"
        Me.logout.Size = New System.Drawing.Size(150, 46)
        Me.logout.TabIndex = 5
        Me.logout.Text = "Logout"
        Me.logout.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1147, 700)
        Me.Controls.Add(Me.logout)
        Me.Controls.Add(Me.apiMessage)
        Me.Controls.Add(Me.balanceInfo)
        Me.Controls.Add(Me.Amount)
        Me.Controls.Add(Me.withdrawCash)
        Me.Controls.Add(Me.sellShare)
        Me.Controls.Add(Me.buyShare)
        Me.Controls.Add(Me.depositMoney)
        Me.Controls.Add(Me.getShare)
        Me.Controls.Add(Me.getCash)
        Me.Controls.Add(Me.header)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents header As Label
    Friend WithEvents getCash As Button
    Friend WithEvents getShare As Button
    Friend WithEvents depositMoney As Button
    Friend WithEvents buyShare As Button
    Friend WithEvents sellShare As Button
    Friend WithEvents withdrawCash As Button
    Friend WithEvents Amount As TextBox
    Friend WithEvents balanceInfo As Label
    Friend WithEvents apiMessage As Label
    Friend WithEvents logout As Button
End Class
