Partial Class InterpreterModeControl
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
        splitMain = New Windows.Forms.SplitContainer()
        txtConsole = New Windows.Forms.RichTextBox()
        pnlMain = New Windows.Forms.Panel()
        txtCommand = New Windows.Forms.TextBox()
        btnSendCommand = New Windows.Forms.Button()
        btnEndInterpreter = New Windows.Forms.Button()
        btnClearInterpreter = New Windows.Forms.Button()
        btnAbort = New Windows.Forms.Button()
        btnSkipBuffer = New Windows.Forms.Button()
        btnLastExecuted = New Windows.Forms.Button()
        btnLastInterpreted = New Windows.Forms.Button()
        btnLastCleared = New Windows.Forms.Button()
        btnLastUnexecuted = New Windows.Forms.Button()
        splitMain.Panel1.SuspendLayout()
        splitMain.Panel2.SuspendLayout()
        splitMain.SuspendLayout()
        pnlMain.SuspendLayout()
        SuspendLayout()
        ' 
        ' splitMain
        ' 
        splitMain.BorderStyle = Windows.Forms.BorderStyle.Fixed3D
        splitMain.Dock = Windows.Forms.DockStyle.Fill
        splitMain.Location = New Drawing.Point(0, 0)
        splitMain.Name = "splitMain"
        ' 
        ' splitMain.Panel1
        ' 
        splitMain.Panel1.Controls.Add(txtConsole)
        ' 
        ' splitMain.Panel2
        ' 
        splitMain.Panel2.AutoScroll = True
        splitMain.Panel2.Controls.Add(txtCommand)
        splitMain.Panel2.Controls.Add(pnlMain)
        splitMain.Size = New Drawing.Size(1240, 710)
        splitMain.SplitterDistance = 413
        splitMain.TabIndex = 1
        ' 
        ' txtConsole
        ' 
        txtConsole.BackColor = Drawing.Color.Black
        txtConsole.BorderStyle = Windows.Forms.BorderStyle.None
        txtConsole.Dock = Windows.Forms.DockStyle.Fill
        txtConsole.ForeColor = Drawing.Color.White
        txtConsole.Location = New Drawing.Point(0, 0)
        txtConsole.Name = "txtConsole"
        txtConsole.ReadOnly = True
        txtConsole.Size = New Drawing.Size(409, 706)
        txtConsole.TabIndex = 0
        txtConsole.Text = "Please use commands on the right panel." & Microsoft.VisualBasic.Constants.vbLf & Microsoft.VisualBasic.Constants.vbLf & "> "
        ' 
        ' pnlMain
        ' 
        pnlMain.Controls.Add(btnLastUnexecuted)
        pnlMain.Controls.Add(btnLastCleared)
        pnlMain.Controls.Add(btnLastInterpreted)
        pnlMain.Controls.Add(btnLastExecuted)
        pnlMain.Controls.Add(btnSkipBuffer)
        pnlMain.Controls.Add(btnAbort)
        pnlMain.Controls.Add(btnClearInterpreter)
        pnlMain.Controls.Add(btnEndInterpreter)
        pnlMain.Controls.Add(btnSendCommand)
        pnlMain.Location = New Drawing.Point(4, 29)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Drawing.Size(436, 448)
        pnlMain.TabIndex = 9
        ' 
        ' txtCommand
        ' 
        txtCommand.Location = New Drawing.Point(4, 3)
        txtCommand.Name = "txtCommand"
        txtCommand.Size = New Drawing.Size(435, 20)
        txtCommand.TabIndex = 10
        txtCommand.Text = "movej([-1.5,-1.5,-2,-0.5,1.8,0],a=1.4, v=1.05, t=0, r=0)"
        ' 
        ' btnSendCommand
        ' 
        btnSendCommand.Location = New Drawing.Point(131, 3)
        btnSendCommand.Name = "btnSendCommand"
        btnSendCommand.Size = New Drawing.Size(152, 23)
        btnSendCommand.TabIndex = 1
        btnSendCommand.Text = "Send command"
        btnSendCommand.UseVisualStyleBackColor = True
        AddHandler btnSendCommand.Click, New EventHandler(AddressOf btnSendCommand_Click)
        ' 
        ' btnEndInterpreter
        ' 
        btnEndInterpreter.Location = New Drawing.Point(3, 74)
        btnEndInterpreter.Name = "btnEndInterpreter"
        btnEndInterpreter.Size = New Drawing.Size(152, 23)
        btnEndInterpreter.TabIndex = 1
        btnEndInterpreter.Text = "End interpreter"
        btnEndInterpreter.UseVisualStyleBackColor = True
        AddHandler btnEndInterpreter.Click, New EventHandler(AddressOf btnEndInterpreter_Click)
        ' 
        ' btnClearInterpreter
        ' 
        btnClearInterpreter.Location = New Drawing.Point(3, 103)
        btnClearInterpreter.Name = "btnClearInterpreter"
        btnClearInterpreter.Size = New Drawing.Size(152, 23)
        btnClearInterpreter.TabIndex = 1
        btnClearInterpreter.Text = "Clear interpreter"
        btnClearInterpreter.UseVisualStyleBackColor = True
        AddHandler btnClearInterpreter.Click, New EventHandler(AddressOf btnClearInterpreter_Click)
        ' 
        ' btnAbort
        ' 
        btnAbort.Location = New Drawing.Point(3, 132)
        btnAbort.Name = "btnAbort"
        btnAbort.Size = New Drawing.Size(152, 23)
        btnAbort.TabIndex = 1
        btnAbort.Text = "Abort"
        btnAbort.UseVisualStyleBackColor = True
        AddHandler btnAbort.Click, New EventHandler(AddressOf btnAbort_Click)
        ' 
        ' btnSkipBuffer
        ' 
        btnSkipBuffer.Location = New Drawing.Point(3, 161)
        btnSkipBuffer.Name = "btnSkipBuffer"
        btnSkipBuffer.Size = New Drawing.Size(152, 23)
        btnSkipBuffer.TabIndex = 1
        btnSkipBuffer.Text = "Skip buffer"
        btnSkipBuffer.UseVisualStyleBackColor = True
        AddHandler btnSkipBuffer.Click, New EventHandler(AddressOf btnSkipBuffer_Click)
        ' 
        ' btnLastExecuted
        ' 
        btnLastExecuted.Location = New Drawing.Point(3, 209)
        btnLastExecuted.Name = "btnLastExecuted"
        btnLastExecuted.Size = New Drawing.Size(152, 23)
        btnLastExecuted.TabIndex = 1
        btnLastExecuted.Text = "Get last executed"
        btnLastExecuted.UseVisualStyleBackColor = True
        AddHandler btnLastExecuted.Click, New EventHandler(AddressOf btnLastExecuted_Click)
        ' 
        ' btnLastInterpreted
        ' 
        btnLastInterpreted.Location = New Drawing.Point(3, 238)
        btnLastInterpreted.Name = "btnLastInterpreted"
        btnLastInterpreted.Size = New Drawing.Size(152, 23)
        btnLastInterpreted.TabIndex = 1
        btnLastInterpreted.Text = "Get last interpreted"
        btnLastInterpreted.UseVisualStyleBackColor = True
        AddHandler btnLastInterpreted.Click, New EventHandler(AddressOf btnLastInterpreted_Click)
        ' 
        ' btnLastCleared
        ' 
        btnLastCleared.Location = New Drawing.Point(3, 267)
        btnLastCleared.Name = "btnLastCleared"
        btnLastCleared.Size = New Drawing.Size(152, 23)
        btnLastCleared.TabIndex = 1
        btnLastCleared.Text = "Get last cleared"
        btnLastCleared.UseVisualStyleBackColor = True
        AddHandler btnLastCleared.Click, New EventHandler(AddressOf btnLastCleared_Click)
        ' 
        ' btnLastUnexecuted
        ' 
        btnLastUnexecuted.Location = New Drawing.Point(3, 296)
        btnLastUnexecuted.Name = "btnLastUnexecuted"
        btnLastUnexecuted.Size = New Drawing.Size(152, 23)
        btnLastUnexecuted.TabIndex = 1
        btnLastUnexecuted.Text = "Get last unexecuted"
        btnLastUnexecuted.UseVisualStyleBackColor = True
        AddHandler btnLastUnexecuted.Click, New EventHandler(AddressOf btnLastUnexecuted_Click)
        ' 
        ' InterpreterModeControl
        ' 
        AutoScaleDimensions = New Drawing.SizeF(6F, 13F)
        AutoScaleMode = Windows.Forms.AutoScaleMode.Font
        Controls.Add(splitMain)
        Name = "InterpreterModeControl"
        Size = New Drawing.Size(1240, 710)
        splitMain.Panel1.ResumeLayout(False)
        splitMain.Panel2.ResumeLayout(False)
        splitMain.Panel2.PerformLayout()
        splitMain.ResumeLayout(False)
        pnlMain.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

#End Region

    Friend splitMain As Windows.Forms.SplitContainer
    Friend txtConsole As Windows.Forms.RichTextBox
    Private pnlMain As Windows.Forms.Panel
    Friend txtCommand As Windows.Forms.TextBox
    Friend btnEndInterpreter As Windows.Forms.Button
    Friend btnSendCommand As Windows.Forms.Button
    Friend btnClearInterpreter As Windows.Forms.Button
    Friend btnAbort As Windows.Forms.Button
    Friend btnSkipBuffer As Windows.Forms.Button
    Friend btnLastExecuted As Windows.Forms.Button
    Friend btnLastInterpreted As Windows.Forms.Button
    Friend btnLastCleared As Windows.Forms.Button
    Friend btnLastUnexecuted As Windows.Forms.Button
End Class
