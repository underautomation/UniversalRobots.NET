
Partial Class MainForm
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

#Region "Code généré par le Concepteur Windows Form"

    ''' <summary>
    ''' Méthode requise pour la prise en charge du concepteur - ne modifiez pas
    ''' le contenu de cette méthode avec l'éditeur de code.
    ''' </summary>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(MainForm))
        horizontalSplitContainer = New Windows.Forms.SplitContainer()
        panel1 = New Windows.Forms.Panel()
        label1 = New Windows.Forms.Label()
        lblLink = New Windows.Forms.LinkLabel()
        lblTitle = New Windows.Forms.Label()
        titlePictureBox = New Windows.Forms.PictureBox()
        verticalSplitContainer = New Windows.Forms.SplitContainer()
        leftTreeView = New Windows.Forms.TreeView()
        imgLst = New Windows.Forms.ImageList(components)
        mainPanel = New Windows.Forms.Panel()
        panelTitle = New Windows.Forms.Label()
        tmrPeriodicUpdate = New Windows.Forms.Timer(components)
        statusStrip1 = New Windows.Forms.StatusStrip()
        lblStatus = New Windows.Forms.ToolStripStatusLabel()
        lblErrors = New Windows.Forms.ToolStripStatusLabel()
        tmrError = New Windows.Forms.Timer(components)
        horizontalSplitContainer.Panel1.SuspendLayout()
        horizontalSplitContainer.Panel2.SuspendLayout()
        horizontalSplitContainer.SuspendLayout()
        panel1.SuspendLayout()
        CType(titlePictureBox, ComponentModel.ISupportInitialize).BeginInit()
        verticalSplitContainer.Panel1.SuspendLayout()
        verticalSplitContainer.Panel2.SuspendLayout()
        verticalSplitContainer.SuspendLayout()
        statusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' horizontalSplitContainer
        ' 
        horizontalSplitContainer.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
        horizontalSplitContainer.Dock = Windows.Forms.DockStyle.Fill
        horizontalSplitContainer.FixedPanel = Windows.Forms.FixedPanel.Panel1
        horizontalSplitContainer.Location = New Drawing.Point(0, 0)
        horizontalSplitContainer.Name = "horizontalSplitContainer"
        horizontalSplitContainer.Orientation = Windows.Forms.Orientation.Horizontal
        ' 
        ' horizontalSplitContainer.Panel1
        ' 
        horizontalSplitContainer.Panel1.Controls.Add(panel1)
        horizontalSplitContainer.Panel1.Controls.Add(lblTitle)
        horizontalSplitContainer.Panel1.Controls.Add(titlePictureBox)
        ' 
        ' horizontalSplitContainer.Panel2
        ' 
        horizontalSplitContainer.Panel2.Controls.Add(verticalSplitContainer)
        horizontalSplitContainer.Size = New Drawing.Size(984, 779)
        horizontalSplitContainer.SplitterDistance = 79
        horizontalSplitContainer.TabIndex = 0
        ' 
        ' panel1
        ' 
        panel1.Controls.Add(label1)
        panel1.Controls.Add(lblLink)
        panel1.Dock = Windows.Forms.DockStyle.Right
        panel1.Location = New Drawing.Point(597, 0)
        panel1.Name = "panel1"
        panel1.Size = New Drawing.Size(385, 77)
        panel1.TabIndex = 3
        ' 
        ' label1
        ' 
        label1.Dock = Windows.Forms.DockStyle.Fill
        label1.Font = New Drawing.Font("Microsoft Sans Serif", 8.25F, Drawing.FontStyle.Italic, Drawing.GraphicsUnit.Point, 0)
        label1.Location = New Drawing.Point(0, 0)
        label1.Name = "label1"
        label1.Size = New Drawing.Size(385, 57)
        label1.TabIndex = 3
        label1.Text = "Universal Robots Communication SDK Library demo software"
        label1.TextAlign = Drawing.ContentAlignment.MiddleCenter
        ' 
        ' lblLink
        ' 
        lblLink.Dock = Windows.Forms.DockStyle.Bottom
        lblLink.Location = New Drawing.Point(0, 57)
        lblLink.Name = "lblLink"
        lblLink.Size = New Drawing.Size(385, 20)
        lblLink.TabIndex = 2
        lblLink.TabStop = True
        lblLink.Text = "https://underautomation.com/universal-robots/documentation"
        lblLink.TextAlign = Drawing.ContentAlignment.MiddleCenter
        AddHandler lblLink.LinkClicked, New Windows.Forms.LinkLabelLinkClickedEventHandler(AddressOf lblLink_LinkClicked)
        ' 
        ' lblTitle
        ' 
        lblTitle.Dock = Windows.Forms.DockStyle.Left
        lblTitle.Font = New Drawing.Font("Microsoft Sans Serif", 15.75F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
        lblTitle.Location = New Drawing.Point(113, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Drawing.Size(254, 77)
        lblTitle.TabIndex = 1
        lblTitle.Text = "UnderAutomation"
        lblTitle.TextAlign = Drawing.ContentAlignment.MiddleLeft
        ' 
        ' titlePictureBox
        ' 
        titlePictureBox.Dock = Windows.Forms.DockStyle.Left
        titlePictureBox.Image = My.Resources.UnderAutomation132
        titlePictureBox.Location = New Drawing.Point(0, 0)
        titlePictureBox.Name = "titlePictureBox"
        titlePictureBox.Size = New Drawing.Size(113, 77)
        titlePictureBox.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
        titlePictureBox.TabIndex = 0
        titlePictureBox.TabStop = False
        AddHandler titlePictureBox.MouseDoubleClick, New Windows.Forms.MouseEventHandler(AddressOf titlePictureBox_MouseDoubleClick)
        ' 
        ' verticalSplitContainer
        ' 
        verticalSplitContainer.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
        verticalSplitContainer.Dock = Windows.Forms.DockStyle.Fill
        verticalSplitContainer.FixedPanel = Windows.Forms.FixedPanel.Panel1
        verticalSplitContainer.Location = New Drawing.Point(0, 0)
        verticalSplitContainer.Name = "verticalSplitContainer"
        ' 
        ' verticalSplitContainer.Panel1
        ' 
        verticalSplitContainer.Panel1.Controls.Add(leftTreeView)
        ' 
        ' verticalSplitContainer.Panel2
        ' 
        verticalSplitContainer.Panel2.Controls.Add(mainPanel)
        verticalSplitContainer.Panel2.Controls.Add(panelTitle)
        verticalSplitContainer.Size = New Drawing.Size(984, 696)
        verticalSplitContainer.SplitterDistance = 281
        verticalSplitContainer.TabIndex = 0
        ' 
        ' leftTreeView
        ' 
        leftTreeView.Dock = Windows.Forms.DockStyle.Fill
        leftTreeView.HideSelection = False
        leftTreeView.ImageIndex = 0
        leftTreeView.ImageList = imgLst
        leftTreeView.Location = New Drawing.Point(0, 0)
        leftTreeView.Name = "leftTreeView"
        leftTreeView.SelectedImageIndex = 0
        leftTreeView.Size = New Drawing.Size(279, 694)
        leftTreeView.TabIndex = 0
        AddHandler leftTreeView.NodeMouseClick, New Windows.Forms.TreeNodeMouseClickEventHandler(AddressOf leftTreeView_NodeMouseClick)
        ' 
        ' imgLst
        ' 
        imgLst.ImageStream = CType(resources.GetObject("imgLst.ImageStream"), Windows.Forms.ImageListStreamer)
        imgLst.TransparentColor = Drawing.Color.Transparent
        imgLst.Images.SetKeyName(0, "OFF")
        imgLst.Images.SetKeyName(1, "ON")
        ' 
        ' mainPanel
        ' 
        mainPanel.Dock = Windows.Forms.DockStyle.Fill
        mainPanel.Location = New Drawing.Point(0, 31)
        mainPanel.Name = "mainPanel"
        mainPanel.Size = New Drawing.Size(697, 663)
        mainPanel.TabIndex = 1
        ' 
        ' panelTitle
        ' 
        panelTitle.Dock = Windows.Forms.DockStyle.Top
        panelTitle.Font = New Drawing.Font("Microsoft Sans Serif", 14.25F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
        panelTitle.Location = New Drawing.Point(0, 0)
        panelTitle.Name = "panelTitle"
        panelTitle.Size = New Drawing.Size(697, 31)
        panelTitle.TabIndex = 0
        panelTitle.TextAlign = Drawing.ContentAlignment.MiddleCenter
        ' 
        ' tmrPeriodicUpdate
        ' 
        tmrPeriodicUpdate.Enabled = True
        tmrPeriodicUpdate.Interval = 200
        AddHandler tmrPeriodicUpdate.Tick, New EventHandler(AddressOf tmrPeriodicUpdate_Tick)
        ' 
        ' statusStrip1
        ' 
        statusStrip1.Items.AddRange(New Windows.Forms.ToolStripItem() {lblStatus, lblErrors})
        statusStrip1.Location = New Drawing.Point(0, 779)
        statusStrip1.Name = "statusStrip1"
        statusStrip1.Size = New Drawing.Size(984, 22)
        statusStrip1.TabIndex = 0
        statusStrip1.Text = "statusStrip1"
        ' 
        ' lblStatus
        ' 
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Drawing.Size(79, 17)
        lblStatus.Text = "Disconnected"
        ' 
        ' lblErrors
        ' 
        lblErrors.ActiveLinkColor = Drawing.Color.DarkRed
        lblErrors.IsLink = True
        lblErrors.LinkColor = Drawing.Color.Red
        lblErrors.Name = "lblErrors"
        lblErrors.Size = New Drawing.Size(16, 17)
        lblErrors.Text = "..."
        lblErrors.Visible = False
        lblErrors.VisitedLinkColor = Drawing.Color.Red
        AddHandler lblErrors.Click, New EventHandler(AddressOf lblErrors_Click)
        ' 
        ' tmrError
        ' 
        tmrError.Interval = 10000
        AddHandler tmrError.Tick, New EventHandler(AddressOf tmrError_Tick)
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New Drawing.SizeF(6F, 13F)
        AutoScaleMode = Windows.Forms.AutoScaleMode.Font
        BackColor = Drawing.SystemColors.Window
        ClientSize = New Drawing.Size(984, 801)
        Controls.Add(horizontalSplitContainer)
        Controls.Add(statusStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Drawing.Icon)
        Name = "MainForm"
        Text = "UnderAutomation - Universal Robots communication SDK"
        horizontalSplitContainer.Panel1.ResumeLayout(False)
        horizontalSplitContainer.Panel2.ResumeLayout(False)
        horizontalSplitContainer.ResumeLayout(False)
        panel1.ResumeLayout(False)
        CType(titlePictureBox, ComponentModel.ISupportInitialize).EndInit()
        verticalSplitContainer.Panel1.ResumeLayout(False)
        verticalSplitContainer.Panel2.ResumeLayout(False)
        verticalSplitContainer.ResumeLayout(False)
        statusStrip1.ResumeLayout(False)
        statusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

#End Region

    Private horizontalSplitContainer As Windows.Forms.SplitContainer
    Private verticalSplitContainer As Windows.Forms.SplitContainer
    Private mainPanel As Windows.Forms.Panel
    Private panelTitle As Windows.Forms.Label
    Private tmrPeriodicUpdate As Windows.Forms.Timer
    Private imgLst As Windows.Forms.ImageList
    Private titlePictureBox As Windows.Forms.PictureBox
    Private lblTitle As Windows.Forms.Label
    Private panel1 As Windows.Forms.Panel
    Private lblLink As Windows.Forms.LinkLabel
    Private label1 As Windows.Forms.Label
    Friend leftTreeView As Windows.Forms.TreeView
    Private statusStrip1 As Windows.Forms.StatusStrip
    Private lblStatus As Windows.Forms.ToolStripStatusLabel
    Private lblErrors As Windows.Forms.ToolStripStatusLabel
    Private tmrError As Windows.Forms.Timer
End Class
