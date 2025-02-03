
Partial Class ProgramControl
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
        lstVariables = New Windows.Forms.ListView()
        columnHeaderName = CType((New Windows.Forms.ColumnHeader()), Windows.Forms.ColumnHeader)
        columnHeaderType = CType((New Windows.Forms.ColumnHeader()), Windows.Forms.ColumnHeader)
        columnHeaderValue = CType((New Windows.Forms.ColumnHeader()), Windows.Forms.ColumnHeader)
        panel1 = New Windows.Forms.Panel()
        btnStop = New Windows.Forms.Button()
        btnPause = New Windows.Forms.Button()
        btnRun = New Windows.Forms.Button()
        cbPrograms = New Windows.Forms.ComboBox()
        lblPathToPrograms = New Windows.Forms.Label()
        label2 = New Windows.Forms.Label()
        lstThreads = New Windows.Forms.ListView()
        columnHeader2 = CType((New Windows.Forms.ColumnHeader()), Windows.Forms.ColumnHeader)
        columnHeader3 = CType((New Windows.Forms.ColumnHeader()), Windows.Forms.ColumnHeader)
        label3 = New Windows.Forms.Label()
        label1 = New Windows.Forms.Label()
        lblWarningVariables = New Windows.Forms.Label()
        panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lstVariables
        ' 
        lstVariables.Columns.AddRange(New Windows.Forms.ColumnHeader() {columnHeaderName, columnHeaderType, columnHeaderValue})
        lstVariables.Dock = Windows.Forms.DockStyle.Fill
        lstVariables.HideSelection = False
        lstVariables.Location = New Drawing.Point(0, 206)
        lstVariables.Name = "lstVariables"
        lstVariables.Size = New Drawing.Size(845, 270)
        lstVariables.TabIndex = 0
        lstVariables.UseCompatibleStateImageBehavior = False
        lstVariables.View = Windows.Forms.View.Details
        ' 
        ' columnHeaderName
        ' 
        columnHeaderName.Text = "Name"
        columnHeaderName.Width = 112
        ' 
        ' columnHeaderType
        ' 
        columnHeaderType.Text = "Type"
        columnHeaderType.Width = 121
        ' 
        ' columnHeaderValue
        ' 
        columnHeaderValue.Text = "Value"
        columnHeaderValue.Width = 2000
        ' 
        ' panel1
        ' 
        panel1.Controls.Add(btnStop)
        panel1.Controls.Add(btnPause)
        panel1.Controls.Add(btnRun)
        panel1.Controls.Add(cbPrograms)
        panel1.Controls.Add(lblPathToPrograms)
        panel1.Controls.Add(label2)
        panel1.Dock = Windows.Forms.DockStyle.Top
        panel1.Location = New Drawing.Point(0, 0)
        panel1.Name = "panel1"
        panel1.Size = New Drawing.Size(845, 54)
        panel1.TabIndex = 1
        ' 
        ' btnStop
        ' 
        btnStop.Location = New Drawing.Point(533, 8)
        btnStop.Name = "btnStop"
        btnStop.Size = New Drawing.Size(52, 21)
        btnStop.TabIndex = 2
        btnStop.Text = "Stop"
        btnStop.UseVisualStyleBackColor = True
        AddHandler btnStop.Click, New EventHandler(AddressOf btnStop_Click)
        ' 
        ' btnPause
        ' 
        btnPause.Location = New Drawing.Point(475, 8)
        btnPause.Name = "btnPause"
        btnPause.Size = New Drawing.Size(52, 21)
        btnPause.TabIndex = 2
        btnPause.Text = "Pause"
        btnPause.UseVisualStyleBackColor = True
        AddHandler btnPause.Click, New EventHandler(AddressOf btnPause_Click)
        ' 
        ' btnRun
        ' 
        btnRun.Location = New Drawing.Point(417, 8)
        btnRun.Name = "btnRun"
        btnRun.Size = New Drawing.Size(52, 21)
        btnRun.TabIndex = 2
        btnRun.Text = "Run"
        btnRun.UseVisualStyleBackColor = True
        AddHandler btnRun.Click, New EventHandler(AddressOf btnRun_Click)
        ' 
        ' cbPrograms
        ' 
        cbPrograms.FormattingEnabled = True
        cbPrograms.Location = New Drawing.Point(154, 8)
        cbPrograms.Name = "cbPrograms"
        cbPrograms.Size = New Drawing.Size(257, 21)
        cbPrograms.TabIndex = 1
        ' 
        ' lblPathToPrograms
        ' 
        lblPathToPrograms.AutoSize = True
        lblPathToPrograms.Font = New Drawing.Font("Microsoft Sans Serif", 8.25F, Drawing.FontStyle.Italic, Drawing.GraphicsUnit.Point, 0)
        lblPathToPrograms.Location = New Drawing.Point(151, 32)
        lblPathToPrograms.Name = "lblPathToPrograms"
        lblPathToPrograms.Size = New Drawing.Size(16, 13)
        lblPathToPrograms.TabIndex = 0
        lblPathToPrograms.Text = "---"
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Font = New Drawing.Font("Microsoft Sans Serif", 8.25F, Drawing.FontStyle.Italic, Drawing.GraphicsUnit.Point, 0)
        label2.Location = New Drawing.Point(3, 11)
        label2.Name = "label2"
        label2.Size = New Drawing.Size(145, 13)
        label2.TabIndex = 0
        label2.Text = "Programs saved in the robot :"
        ' 
        ' lstThreads
        ' 
        lstThreads.Columns.AddRange(New Windows.Forms.ColumnHeader() {columnHeader2, columnHeader3})
        lstThreads.Dock = Windows.Forms.DockStyle.Top
        lstThreads.HideSelection = False
        lstThreads.Location = New Drawing.Point(0, 84)
        lstThreads.Name = "lstThreads"
        lstThreads.Size = New Drawing.Size(845, 92)
        lstThreads.TabIndex = 3
        lstThreads.UseCompatibleStateImageBehavior = False
        lstThreads.View = Windows.Forms.View.Details
        ' 
        ' columnHeader2
        ' 
        columnHeader2.Text = "Line number"
        columnHeader2.Width = 80
        ' 
        ' columnHeader3
        ' 
        columnHeader3.Text = "Line script"
        columnHeader3.Width = 2000
        ' 
        ' label3
        ' 
        label3.Dock = Windows.Forms.DockStyle.Top
        label3.Font = New Drawing.Font("Microsoft Sans Serif", 8.25F, Drawing.FontStyle.Italic, Drawing.GraphicsUnit.Point, 0)
        label3.Location = New Drawing.Point(0, 176)
        label3.Name = "label3"
        label3.Size = New Drawing.Size(845, 30)
        label3.TabIndex = 4
        label3.Text = "List of all variables :"
        label3.TextAlign = Drawing.ContentAlignment.BottomLeft
        ' 
        ' label1
        ' 
        label1.Dock = Windows.Forms.DockStyle.Top
        label1.Font = New Drawing.Font("Microsoft Sans Serif", 8.25F, Drawing.FontStyle.Italic, Drawing.GraphicsUnit.Point, 0)
        label1.Location = New Drawing.Point(0, 54)
        label1.Name = "label1"
        label1.Size = New Drawing.Size(845, 30)
        label1.TabIndex = 5
        label1.Text = "List of all program threads :"
        label1.TextAlign = Drawing.ContentAlignment.BottomLeft
        ' 
        ' lblWarningVariables
        ' 
        lblWarningVariables.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right
        lblWarningVariables.AutoSize = True
        lblWarningVariables.Location = New Drawing.Point(151, 257)
        lblWarningVariables.Name = "lblWarningVariables"
        lblWarningVariables.Size = New Drawing.Size(339, 13)
        lblWarningVariables.TabIndex = 6
        lblWarningVariables.Text = "Primary interface should be connected to display threads and variables"
        ' 
        ' ProgramControl
        ' 
        AutoScaleDimensions = New Drawing.SizeF(6F, 13F)
        AutoScaleMode = Windows.Forms.AutoScaleMode.Font
        Controls.Add(lblWarningVariables)
        Controls.Add(lstVariables)
        Controls.Add(label3)
        Controls.Add(lstThreads)
        Controls.Add(label1)
        Controls.Add(panel1)
        Name = "ProgramControl"
        Size = New Drawing.Size(845, 476)
        panel1.ResumeLayout(False)
        panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

#End Region

    Private lstVariables As Windows.Forms.ListView
    Private columnHeaderName As Windows.Forms.ColumnHeader
    Private columnHeaderType As Windows.Forms.ColumnHeader
    Private columnHeaderValue As Windows.Forms.ColumnHeader
    Private panel1 As Windows.Forms.Panel
    Private cbPrograms As Windows.Forms.ComboBox
    Private label2 As Windows.Forms.Label
    Private btnRun As Windows.Forms.Button
    Private btnStop As Windows.Forms.Button
    Private btnPause As Windows.Forms.Button
    Private lblPathToPrograms As Windows.Forms.Label
    Private lstThreads As Windows.Forms.ListView
    Private columnHeader2 As Windows.Forms.ColumnHeader
    Private columnHeader3 As Windows.Forms.ColumnHeader
    Private label3 As Windows.Forms.Label
    Private label1 As Windows.Forms.Label
    Private lblWarningVariables As Windows.Forms.Label
End Class
