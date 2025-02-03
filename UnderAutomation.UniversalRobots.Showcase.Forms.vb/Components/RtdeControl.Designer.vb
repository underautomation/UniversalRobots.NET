
Partial Class RtdeControl
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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(RtdeControl))
        gridOutputs = New Windows.Forms.PropertyGrid()
        gridInputs = New Windows.Forms.PropertyGrid()
        btnSendInputs = New Windows.Forms.Button()
        label1 = New Windows.Forms.Label()
        label2 = New Windows.Forms.Label()
        label3 = New Windows.Forms.Label()
        txtFrequency = New Windows.Forms.TextBox()
        barSpeed = New Windows.Forms.TrackBar()
        label4 = New Windows.Forms.Label()
        lblSpeedPercent = New Windows.Forms.Label()
        tmrStopWrite = New Windows.Forms.Timer(components)
        timer1 = New Windows.Forms.Timer(components)
        toolTip1 = New Windows.Forms.ToolTip(components)
        splitContainer1 = New Windows.Forms.SplitContainer()
        panel3 = New Windows.Forms.Panel()
        panel2 = New Windows.Forms.Panel()
        panel1 = New Windows.Forms.Panel()
        toolStrip1 = New Windows.Forms.ToolStrip()
        btnPause = New Windows.Forms.ToolStripButton()
        btnResume = New Windows.Forms.ToolStripButton()
        toolStripSeparator1 = New Windows.Forms.ToolStripSeparator()
        toolStripLabel1 = New Windows.Forms.ToolStripLabel()
        lblState = New Windows.Forms.ToolStripLabel()
        toolStripSeparator2 = New Windows.Forms.ToolStripSeparator()
        toolStripLabel2 = New Windows.Forms.ToolStripLabel()
        lblkVersion = New Windows.Forms.ToolStripLabel()
        CType(barSpeed, ComponentModel.ISupportInitialize).BeginInit()
        splitContainer1.Panel1.SuspendLayout()
        splitContainer1.Panel2.SuspendLayout()
        splitContainer1.SuspendLayout()
        panel3.SuspendLayout()
        panel2.SuspendLayout()
        panel1.SuspendLayout()
        toolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' gridOutputs
        ' 
        gridOutputs.CommandsVisibleIfAvailable = False
        gridOutputs.Dock = Windows.Forms.DockStyle.Fill
        gridOutputs.HelpVisible = False
        gridOutputs.Location = New Drawing.Point(0, 24)
        gridOutputs.Name = "gridOutputs"
        gridOutputs.PropertySort = Windows.Forms.PropertySort.NoSort
        gridOutputs.Size = New Drawing.Size(430, 403)
        gridOutputs.TabIndex = 0
        gridOutputs.TabStop = False
        gridOutputs.ToolbarVisible = False
        ' 
        ' gridInputs
        ' 
        gridInputs.CommandsVisibleIfAvailable = False
        gridInputs.Dock = Windows.Forms.DockStyle.Fill
        gridInputs.HelpVisible = False
        gridInputs.Location = New Drawing.Point(0, 24)
        gridInputs.Name = "gridInputs"
        gridInputs.PropertySort = Windows.Forms.PropertySort.NoSort
        gridInputs.Size = New Drawing.Size(407, 403)
        gridInputs.TabIndex = 0
        gridInputs.ToolbarVisible = False
        ' 
        ' btnSendInputs
        ' 
        btnSendInputs.Anchor = Windows.Forms.AnchorStyles.Top
        btnSendInputs.Location = New Drawing.Point(130, 6)
        btnSendInputs.Name = "btnSendInputs"
        btnSendInputs.Size = New Drawing.Size(157, 23)
        btnSendInputs.TabIndex = 1
        btnSendInputs.Text = "Send inputs to robot"
        btnSendInputs.UseVisualStyleBackColor = True
        AddHandler btnSendInputs.Click, New EventHandler(AddressOf btnSendInputs_Click)
        ' 
        ' label1
        ' 
        label1.Dock = Windows.Forms.DockStyle.Top
        label1.Location = New Drawing.Point(0, 0)
        label1.Name = "label1"
        label1.Size = New Drawing.Size(407, 24)
        label1.TabIndex = 2
        label1.Text = "Inputs"
        label1.TextAlign = Drawing.ContentAlignment.MiddleCenter
        ' 
        ' label2
        ' 
        label2.Dock = Windows.Forms.DockStyle.Top
        label2.Location = New Drawing.Point(0, 0)
        label2.Name = "label2"
        label2.Size = New Drawing.Size(430, 24)
        label2.TabIndex = 2
        label2.Text = "Outputs"
        label2.TextAlign = Drawing.ContentAlignment.MiddleCenter
        ' 
        ' label3
        ' 
        label3.Anchor = Windows.Forms.AnchorStyles.Top
        label3.AutoSize = True
        label3.Location = New Drawing.Point(135, 11)
        label3.Name = "label3"
        label3.Size = New Drawing.Size(63, 13)
        label3.TabIndex = 2
        label3.Text = "Frequency ;"
        ' 
        ' txtFrequency
        ' 
        txtFrequency.Anchor = Windows.Forms.AnchorStyles.Top
        txtFrequency.Cursor = Windows.Forms.Cursors.Help
        txtFrequency.Location = New Drawing.Point(202, 8)
        txtFrequency.Name = "txtFrequency"
        txtFrequency.ReadOnly = True
        txtFrequency.Size = New Drawing.Size(100, 20)
        txtFrequency.TabIndex = 3
        toolTip1.SetToolTip(txtFrequency, "Timestamp should be among output data to compute frequency")
        ' 
        ' barSpeed
        ' 
        barSpeed.Anchor = Windows.Forms.AnchorStyles.Bottom
        barSpeed.Cursor = Windows.Forms.Cursors.Help
        barSpeed.Location = New Drawing.Point(111, 39)
        barSpeed.Maximum = 120
        barSpeed.Name = "barSpeed"
        barSpeed.Size = New Drawing.Size(191, 45)
        barSpeed.TabIndex = 4
        barSpeed.TickFrequency = 10
        toolTip1.SetToolTip(barSpeed, "speed_slider_mask and speed_slider_fraction should be among input data to use thi" & "s slider")
        barSpeed.Value = 50
        AddHandler barSpeed.ValueChanged, New EventHandler(AddressOf barSpeed_ValueChanged)
        ' 
        ' label4
        ' 
        label4.Anchor = Windows.Forms.AnchorStyles.Bottom
        label4.AutoSize = True
        label4.Location = New Drawing.Point(75, 43)
        label4.Name = "label4"
        label4.Size = New Drawing.Size(38, 13)
        label4.TabIndex = 2
        label4.Text = "Speed"
        ' 
        ' lblSpeedPercent
        ' 
        lblSpeedPercent.Anchor = Windows.Forms.AnchorStyles.Bottom
        lblSpeedPercent.AutoSize = True
        lblSpeedPercent.Location = New Drawing.Point(296, 43)
        lblSpeedPercent.Name = "lblSpeedPercent"
        lblSpeedPercent.Size = New Drawing.Size(27, 13)
        lblSpeedPercent.TabIndex = 2
        lblSpeedPercent.Text = "50%"
        ' 
        ' tmrStopWrite
        ' 
        tmrStopWrite.Interval = 500
        AddHandler tmrStopWrite.Tick, New EventHandler(AddressOf tmrStopWrite_Tick)
        ' 
        ' splitContainer1
        ' 
        splitContainer1.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
        splitContainer1.Dock = Windows.Forms.DockStyle.Fill
        splitContainer1.Location = New Drawing.Point(0, 55)
        splitContainer1.Name = "splitContainer1"
        ' 
        ' splitContainer1.Panel1
        ' 
        splitContainer1.Panel1.Controls.Add(gridInputs)
        splitContainer1.Panel1.Controls.Add(panel3)
        splitContainer1.Panel1.Controls.Add(label1)
        ' 
        ' splitContainer1.Panel2
        ' 
        splitContainer1.Panel2.Controls.Add(gridOutputs)
        splitContainer1.Panel2.Controls.Add(panel2)
        splitContainer1.Panel2.Controls.Add(label2)
        splitContainer1.Size = New Drawing.Size(845, 507)
        splitContainer1.SplitterDistance = 409
        splitContainer1.TabIndex = 5
        ' 
        ' panel3
        ' 
        panel3.Controls.Add(btnSendInputs)
        panel3.Controls.Add(lblSpeedPercent)
        panel3.Controls.Add(barSpeed)
        panel3.Controls.Add(label4)
        panel3.Dock = Windows.Forms.DockStyle.Bottom
        panel3.Location = New Drawing.Point(0, 427)
        panel3.Name = "panel3"
        panel3.Size = New Drawing.Size(407, 78)
        panel3.TabIndex = 5
        ' 
        ' panel2
        ' 
        panel2.Controls.Add(label3)
        panel2.Controls.Add(txtFrequency)
        panel2.Dock = Windows.Forms.DockStyle.Bottom
        panel2.Location = New Drawing.Point(0, 427)
        panel2.Name = "panel2"
        panel2.Size = New Drawing.Size(430, 78)
        panel2.TabIndex = 4
        ' 
        ' panel1
        ' 
        panel1.Controls.Add(toolStrip1)
        panel1.Dock = Windows.Forms.DockStyle.Top
        panel1.Location = New Drawing.Point(0, 0)
        panel1.Name = "panel1"
        panel1.Size = New Drawing.Size(845, 55)
        panel1.TabIndex = 6
        ' 
        ' toolStrip1
        ' 
        toolStrip1.Items.AddRange(New Windows.Forms.ToolStripItem() {btnPause, btnResume, toolStripSeparator1, toolStripLabel1, lblState, toolStripSeparator2, toolStripLabel2, lblkVersion})
        toolStrip1.Location = New Drawing.Point(0, 0)
        toolStrip1.Name = "toolStrip1"
        toolStrip1.Size = New Drawing.Size(845, 25)
        toolStrip1.TabIndex = 0
        toolStrip1.Text = "toolStrip1"
        ' 
        ' btnPause
        ' 
        btnPause.Image = CType(resources.GetObject("btnPause.Image"), Drawing.Image)
        btnPause.ImageTransparentColor = Drawing.Color.Magenta
        btnPause.Name = "btnPause"
        btnPause.Size = New Drawing.Size(58, 22)
        btnPause.Text = "Pause"
        AddHandler btnPause.Click, New EventHandler(AddressOf btnPause_Click)
        ' 
        ' btnResume
        ' 
        btnResume.Image = CType(resources.GetObject("btnResume.Image"), Drawing.Image)
        btnResume.ImageTransparentColor = Drawing.Color.Magenta
        btnResume.Name = "btnResume"
        btnResume.Size = New Drawing.Size(69, 22)
        btnResume.Text = "Resume"
        AddHandler btnResume.Click, New EventHandler(AddressOf btnStart_Click)
        ' 
        ' toolStripSeparator1
        ' 
        toolStripSeparator1.Name = "toolStripSeparator1"
        toolStripSeparator1.Size = New Drawing.Size(6, 25)
        ' 
        ' toolStripLabel1
        ' 
        toolStripLabel1.Name = "toolStripLabel1"
        toolStripLabel1.Size = New Drawing.Size(39, 22)
        toolStripLabel1.Text = "State :"
        ' 
        ' lblState
        ' 
        lblState.Name = "lblState"
        lblState.Size = New Drawing.Size(16, 22)
        lblState.Text = "..."
        ' 
        ' toolStripSeparator2
        ' 
        toolStripSeparator2.Name = "toolStripSeparator2"
        toolStripSeparator2.Size = New Drawing.Size(6, 25)
        ' 
        ' toolStripLabel2
        ' 
        toolStripLabel2.Name = "toolStripLabel2"
        toolStripLabel2.Size = New Drawing.Size(51, 22)
        toolStripLabel2.Text = "Version :"
        ' 
        ' lblkVersion
        ' 
        lblkVersion.Name = "lblkVersion"
        lblkVersion.Size = New Drawing.Size(16, 22)
        lblkVersion.Text = "..."
        ' 
        ' RtdeControl
        ' 
        AutoScaleDimensions = New Drawing.SizeF(6F, 13F)
        AutoScaleMode = Windows.Forms.AutoScaleMode.Font
        Controls.Add(splitContainer1)
        Controls.Add(panel1)
        Name = "RtdeControl"
        Size = New Drawing.Size(845, 562)
        CType(barSpeed, ComponentModel.ISupportInitialize).EndInit()
        splitContainer1.Panel1.ResumeLayout(False)
        splitContainer1.Panel2.ResumeLayout(False)
        splitContainer1.ResumeLayout(False)
        panel3.ResumeLayout(False)
        panel3.PerformLayout()
        panel2.ResumeLayout(False)
        panel2.PerformLayout()
        panel1.ResumeLayout(False)
        panel1.PerformLayout()
        toolStrip1.ResumeLayout(False)
        toolStrip1.PerformLayout()
        ResumeLayout(False)

    End Sub

#End Region
    Private gridInputs As Windows.Forms.PropertyGrid
    Private gridOutputs As Windows.Forms.PropertyGrid
    Private btnSendInputs As Windows.Forms.Button
    Private label1 As Windows.Forms.Label
    Private label2 As Windows.Forms.Label
    Private label3 As Windows.Forms.Label
    Private txtFrequency As Windows.Forms.TextBox
    Private barSpeed As Windows.Forms.TrackBar
    Private label4 As Windows.Forms.Label
    Private lblSpeedPercent As Windows.Forms.Label
    Private tmrStopWrite As Windows.Forms.Timer
    Private timer1 As Windows.Forms.Timer
    Private toolTip1 As Windows.Forms.ToolTip
    Private splitContainer1 As Windows.Forms.SplitContainer
    Private panel3 As Windows.Forms.Panel
    Private panel2 As Windows.Forms.Panel
    Private panel1 As Windows.Forms.Panel
    Private toolStrip1 As Windows.Forms.ToolStrip
    Private btnResume As Windows.Forms.ToolStripButton
    Private btnPause As Windows.Forms.ToolStripButton
    Private toolStripSeparator1 As Windows.Forms.ToolStripSeparator
    Private toolStripLabel1 As Windows.Forms.ToolStripLabel
    Private lblState As Windows.Forms.ToolStripLabel
    Private toolStripSeparator2 As Windows.Forms.ToolStripSeparator
    Private toolStripLabel2 As Windows.Forms.ToolStripLabel
    Private lblkVersion As Windows.Forms.ToolStripLabel
End Class
