
Partial Class SocketControl
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
        btnSend = New Windows.Forms.Button()
        txtMessage = New Windows.Forms.TextBox()
        txtLog = New Windows.Forms.RichTextBox()
        lstClients = New Windows.Forms.ListView()
        columnHeader2 = CType((New Windows.Forms.ColumnHeader()), Windows.Forms.ColumnHeader)
        columnHeader3 = CType((New Windows.Forms.ColumnHeader()), Windows.Forms.ColumnHeader)
        columnHeader4 = CType((New Windows.Forms.ColumnHeader()), Windows.Forms.ColumnHeader)
        label1 = New Windows.Forms.Label()
        linkSample = New Windows.Forms.LinkLabel()
        txtPort = New Windows.Forms.TextBox()
        txtLocalIP = New Windows.Forms.TextBox()
        Label12 = New Windows.Forms.Label()
        Label2 = New Windows.Forms.Label()
        Label10 = New Windows.Forms.Label()
        Label13 = New Windows.Forms.Label()
        Label9 = New Windows.Forms.Label()
        label3 = New Windows.Forms.Label()
        pictureBox2 = New Windows.Forms.PictureBox()
        CType(pictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Drawing.Font("Microsoft Sans Serif", 13F)
        Label15.Location = New Drawing.Point(1, 382)
        Label15.Name = "Label15"
        Label15.Size = New Drawing.Size(21, 22)
        Label15.TabIndex = 9
        Label15.Text = ">"
        ' 
        ' btnSend
        ' 
        btnSend.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Right
        btnSend.Location = New Drawing.Point(512, 381)
        btnSend.Name = "btnSend"
        btnSend.Size = New Drawing.Size(209, 23)
        btnSend.TabIndex = 8
        btnSend.Text = "Send"
        btnSend.UseVisualStyleBackColor = True
        AddHandler btnSend.Click, New EventHandler(AddressOf btnSend_Click)
        ' 
        ' txtMessage
        ' 
        txtMessage.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right
        txtMessage.Location = New Drawing.Point(27, 383)
        txtMessage.Name = "txtMessage"
        txtMessage.Size = New Drawing.Size(479, 20)
        txtMessage.TabIndex = 7
        AddHandler txtMessage.KeyDown, New Windows.Forms.KeyEventHandler(AddressOf btnSend_Click)
        ' 
        ' txtLog
        ' 
        txtLog.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Bottom Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right

        txtLog.BackColor = Drawing.Color.Black
        txtLog.ForeColor = Drawing.Color.White
        txtLog.Location = New Drawing.Point(5, 410)
        txtLog.Name = "txtLog"
        txtLog.ReadOnly = True
        txtLog.Size = New Drawing.Size(716, 176)
        txtLog.TabIndex = 5
        txtLog.Text = ""
        ' 
        ' lstClients
        ' 
        lstClients.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right
        lstClients.Columns.AddRange(New Windows.Forms.ColumnHeader() {columnHeader2, columnHeader3, columnHeader4})
        lstClients.FullRowSelect = True
        lstClients.HideSelection = False
        lstClients.Location = New Drawing.Point(27, 292)
        lstClients.MultiSelect = False
        lstClients.Name = "lstClients"
        lstClients.Size = New Drawing.Size(479, 85)
        lstClients.TabIndex = 10
        lstClients.UseCompatibleStateImageBehavior = False
        lstClients.View = Windows.Forms.View.Details
        AddHandler lstClients.SelectedIndexChanged, New EventHandler(AddressOf lstClients_SelectedIndexChanged)
        ' 
        ' columnHeader2
        ' 
        columnHeader2.Text = "Local port"
        columnHeader2.Width = 80
        ' 
        ' columnHeader3
        ' 
        columnHeader3.Text = "Remote IP"
        columnHeader3.Width = 120
        ' 
        ' columnHeader4
        ' 
        columnHeader4.Text = "Remote port"
        columnHeader4.Width = 80
        ' 
        ' label1
        ' 
        label1.Font = New Drawing.Font("Microsoft Sans Serif", 8.25F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
        label1.Location = New Drawing.Point(373, 8)
        label1.Name = "label1"
        label1.Size = New Drawing.Size(209, 97)
        label1.TabIndex = 32
        label1.Text = "WARNING : If the robot fails to connect, check your local firewall and check the " & "robot's security settings in Polyscope: Settings / Security / General"
        label1.TextAlign = Drawing.ContentAlignment.MiddleCenter
        ' 
        ' linkSample
        ' 
        linkSample.AutoSize = True
        linkSample.Location = New Drawing.Point(232, 8)
        linkSample.Name = "linkSample"
        linkSample.Size = New Drawing.Size(96, 13)
        linkSample.TabIndex = 36
        linkSample.TabStop = True
        linkSample.Text = "socket_sample.urp"
        AddHandler linkSample.LinkClicked, New Windows.Forms.LinkLabelLinkClickedEventHandler(AddressOf linkSample_LinkClicked)
        ' 
        ' txtPort
        ' 
        txtPort.Location = New Drawing.Point(164, 72)
        txtPort.Name = "txtPort"
        txtPort.ReadOnly = True
        txtPort.Size = New Drawing.Size(203, 20)
        txtPort.TabIndex = 26
        ' 
        ' txtLocalIP
        ' 
        txtLocalIP.Location = New Drawing.Point(164, 46)
        txtLocalIP.Name = "txtLocalIP"
        txtLocalIP.ReadOnly = True
        txtLocalIP.Size = New Drawing.Size(203, 20)
        txtLocalIP.TabIndex = 27
        ' 
        ' Label12
        ' 
        Label12.Location = New Drawing.Point(57, 72)
        Label12.Name = "Label12"
        Label12.Size = New Drawing.Size(107, 20)
        Label12.TabIndex = 28
        Label12.Text = "Your local port :"
        Label12.TextAlign = Drawing.ContentAlignment.MiddleRight
        ' 
        ' Label2
        ' 
        Label2.Location = New Drawing.Point(57, 46)
        Label2.Name = "Label2"
        Label2.Size = New Drawing.Size(107, 20)
        Label2.TabIndex = 29
        Label2.Text = "Your local PC IP :"
        Label2.TextAlign = Drawing.ContentAlignment.MiddleRight
        ' 
        ' Label10
        ' 
        Label10.Location = New Drawing.Point(24, 25)
        Label10.Name = "Label10"
        Label10.Size = New Drawing.Size(368, 20)
        Label10.TabIndex = 30
        Label10.Text = "2. Use your local machine information in function socket_open() :"
        Label10.TextAlign = Drawing.ContentAlignment.MiddleLeft
        ' 
        ' Label13
        ' 
        Label13.Location = New Drawing.Point(24, 95)
        Label13.Name = "Label13"
        Label13.Size = New Drawing.Size(368, 20)
        Label13.TabIndex = 33
        Label13.Text = "3. Run the program on your robot"
        Label13.TextAlign = Drawing.ContentAlignment.MiddleLeft
        ' 
        ' Label9
        ' 
        Label9.Location = New Drawing.Point(24, 4)
        Label9.Name = "Label9"
        Label9.Size = New Drawing.Size(205, 20)
        Label9.TabIndex = 34
        Label9.Text = "1. Upload this program on your UR robot : "
        Label9.TextAlign = Drawing.ContentAlignment.MiddleLeft
        ' 
        ' label3
        ' 
        label3.Location = New Drawing.Point(24, 269)
        label3.Name = "label3"
        label3.Size = New Drawing.Size(368, 20)
        label3.TabIndex = 33
        label3.Text = "4. Select a socket and exchange messages"
        label3.TextAlign = Drawing.ContentAlignment.MiddleLeft
        ' 
        ' pictureBox2
        ' 
        pictureBox2.Image = My.Resources.socket_sample
        pictureBox2.Location = New Drawing.Point(84, 118)
        pictureBox2.Name = "pictureBox2"
        pictureBox2.Size = New Drawing.Size(293, 148)
        pictureBox2.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
        pictureBox2.TabIndex = 38
        pictureBox2.TabStop = False
        ' 
        ' SocketControl
        ' 
        AutoScaleDimensions = New Drawing.SizeF(6F, 13F)
        AutoScaleMode = Windows.Forms.AutoScaleMode.Font
        AutoScroll = True
        Controls.Add(pictureBox2)
        Controls.Add(label1)
        Controls.Add(linkSample)
        Controls.Add(txtPort)
        Controls.Add(txtLocalIP)
        Controls.Add(Label12)
        Controls.Add(Label2)
        Controls.Add(Label10)
        Controls.Add(label3)
        Controls.Add(Label13)
        Controls.Add(Label9)
        Controls.Add(lstClients)
        Controls.Add(Label15)
        Controls.Add(btnSend)
        Controls.Add(txtMessage)
        Controls.Add(txtLog)
        Name = "SocketControl"
        Size = New Drawing.Size(735, 589)
        CType(pictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

#End Region
    Friend Label15 As Windows.Forms.Label
    Friend btnSend As Windows.Forms.Button
    Friend txtMessage As Windows.Forms.TextBox
    Friend txtLog As Windows.Forms.RichTextBox
    Private lstClients As Windows.Forms.ListView
    Private columnHeader2 As Windows.Forms.ColumnHeader
    Private columnHeader3 As Windows.Forms.ColumnHeader
    Private columnHeader4 As Windows.Forms.ColumnHeader
    Friend label1 As Windows.Forms.Label
    Friend linkSample As Windows.Forms.LinkLabel
    Friend txtPort As Windows.Forms.TextBox
    Friend txtLocalIP As Windows.Forms.TextBox
    Friend Label12 As Windows.Forms.Label
    Friend Label2 As Windows.Forms.Label
    Friend Label10 As Windows.Forms.Label
    Friend Label13 As Windows.Forms.Label
    Friend Label9 As Windows.Forms.Label
    Friend label3 As Windows.Forms.Label
    Private pictureBox2 As Windows.Forms.PictureBox
End Class
