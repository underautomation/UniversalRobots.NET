
Partial Class SshControl
    ''' <summary> 
    ''' Variable nécessaire au concepteur.
    ''' </summary>
    Private components As ComponentModel.IContainer = Nothing

    ''' <summary> 
    ''' Nettoyage des ressources utilisées.
    ''' </summary>
    ''' <paramname="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Code généré par le Concepteur de composants"

    ''' <summary> 
    ''' Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
    ''' le contenu de cette méthode avec l'éditeur de code.
    ''' </summary>
    Private Sub InitializeComponent()
        Label15 = New Windows.Forms.Label()
        btnSendShell = New Windows.Forms.Button()
        txtSSHCommand = New Windows.Forms.TextBox()
        txtShellCommand = New Windows.Forms.TextBox()
        txtShellHistory = New Windows.Forms.RichTextBox()
        btnSSHSend = New Windows.Forms.Button()
        label1 = New Windows.Forms.Label()
        label2 = New Windows.Forms.Label()
        txtCommandResult = New Windows.Forms.TextBox()
        SuspendLayout()
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Drawing.Font("Microsoft Sans Serif", 13F)
        Label15.Location = New Drawing.Point(8, 19)
        Label15.Name = "Label15"
        Label15.Size = New Drawing.Size(21, 22)
        Label15.TabIndex = 9
        Label15.Text = ">"
        ' 
        ' btnSendShell
        ' 
        btnSendShell.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Right
        btnSendShell.Location = New Drawing.Point(613, 18)
        btnSendShell.Name = "btnSendShell"
        btnSendShell.Size = New Drawing.Size(110, 23)
        btnSendShell.TabIndex = 8
        btnSendShell.Text = "Send"
        btnSendShell.UseVisualStyleBackColor = True
        AddHandler btnSendShell.Click, New EventHandler(AddressOf btnSendShell_Click)
        ' 
        ' txtSSHCommand
        ' 
        txtSSHCommand.Anchor = Windows.Forms.AnchorStyles.Bottom Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right
        txtSSHCommand.Location = New Drawing.Point(7, 411)
        txtSSHCommand.Name = "txtSSHCommand"
        txtSSHCommand.Size = New Drawing.Size(600, 20)
        txtSSHCommand.TabIndex = 6
        txtSSHCommand.Text = "ping localhost -c 1"
        AddHandler txtSSHCommand.KeyDown, New Windows.Forms.KeyEventHandler(AddressOf btnSSHSend_Click)
        ' 
        ' txtShellCommand
        ' 
        txtShellCommand.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right
        txtShellCommand.Location = New Drawing.Point(34, 20)
        txtShellCommand.Name = "txtShellCommand"
        txtShellCommand.Size = New Drawing.Size(573, 20)
        txtShellCommand.TabIndex = 7
        txtShellCommand.Text = "DISPLAY=:0 nohup /home/ur/ursim-current/start-ursim.sh UR16 `# Remote start UR16 " & "emulator on virtual machine`"
        AddHandler txtShellCommand.KeyDown, New Windows.Forms.KeyEventHandler(AddressOf btnSendShell_Click)
        ' 
        ' txtShellHistory
        ' 
        txtShellHistory.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Bottom Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right

        txtShellHistory.BackColor = Drawing.Color.Black
        txtShellHistory.ForeColor = Drawing.Color.White
        txtShellHistory.Location = New Drawing.Point(7, 44)
        txtShellHistory.Name = "txtShellHistory"
        txtShellHistory.ReadOnly = True
        txtShellHistory.Size = New Drawing.Size(716, 327)
        txtShellHistory.TabIndex = 5
        txtShellHistory.Text = ""
        ' 
        ' btnSSHSend
        ' 
        btnSSHSend.Anchor = Windows.Forms.AnchorStyles.Bottom Or Windows.Forms.AnchorStyles.Right
        btnSSHSend.Location = New Drawing.Point(613, 409)
        btnSSHSend.Name = "btnSSHSend"
        btnSSHSend.Size = New Drawing.Size(110, 23)
        btnSSHSend.TabIndex = 11
        btnSSHSend.Text = "Send"
        btnSSHSend.UseVisualStyleBackColor = True
        AddHandler btnSSHSend.Click, New EventHandler(AddressOf btnSSHSend_Click)
        ' 
        ' label1
        ' 
        label1.Anchor = Windows.Forms.AnchorStyles.Bottom Or Windows.Forms.AnchorStyles.Left
        label1.AutoSize = True
        label1.Font = New Drawing.Font("Microsoft Sans Serif", 8.25F, Drawing.FontStyle.Italic, Drawing.GraphicsUnit.Point, 0)
        label1.Location = New Drawing.Point(4, 395)
        label1.Name = "label1"
        label1.Size = New Drawing.Size(169, 13)
        label1.TabIndex = 12
        label1.Text = "Send command outside of a shell :"
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Font = New Drawing.Font("Microsoft Sans Serif", 8.25F, Drawing.FontStyle.Italic, Drawing.GraphicsUnit.Point, 0)
        label2.Location = New Drawing.Point(9, 4)
        label2.Name = "label2"
        label2.Size = New Drawing.Size(263, 13)
        label2.TabIndex = 13
        label2.Text = "Send a Linux command in a shell, like in your terminal :"
        ' 
        ' txtCommandResult
        ' 
        txtCommandResult.Anchor = Windows.Forms.AnchorStyles.Bottom Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right
        txtCommandResult.Location = New Drawing.Point(7, 438)
        txtCommandResult.Multiline = True
        txtCommandResult.Name = "txtCommandResult"
        txtCommandResult.ReadOnly = True
        txtCommandResult.Size = New Drawing.Size(716, 137)
        txtCommandResult.TabIndex = 14
        txtCommandResult.Text = ">"
        ' 
        ' SshControl
        ' 
        AutoScaleDimensions = New Drawing.SizeF(6F, 13F)
        AutoScaleMode = Windows.Forms.AutoScaleMode.Font
        AutoScroll = True
        Controls.Add(txtCommandResult)
        Controls.Add(label2)
        Controls.Add(label1)
        Controls.Add(btnSSHSend)
        Controls.Add(Label15)
        Controls.Add(btnSendShell)
        Controls.Add(txtSSHCommand)
        Controls.Add(txtShellCommand)
        Controls.Add(txtShellHistory)
        Name = "SshControl"
        Size = New Drawing.Size(730, 589)
        ResumeLayout(False)
        PerformLayout()

    End Sub

#End Region
    Friend Label15 As Windows.Forms.Label
    Friend btnSendShell As Windows.Forms.Button
    Friend txtSSHCommand As Windows.Forms.TextBox
    Friend txtShellCommand As Windows.Forms.TextBox
    Friend txtShellHistory As Windows.Forms.RichTextBox
    Friend btnSSHSend As Windows.Forms.Button
    Private label1 As Windows.Forms.Label
    Private label2 As Windows.Forms.Label
    Private txtCommandResult As Windows.Forms.TextBox
End Class
