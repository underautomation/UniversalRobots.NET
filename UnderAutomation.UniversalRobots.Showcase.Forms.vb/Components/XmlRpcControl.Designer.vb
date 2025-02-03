
Partial Class XmlRpcControl
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
        linkXmlRpcSample = New Windows.Forms.LinkLabel()
        txtXmlRpcPort = New Windows.Forms.TextBox()
        txtLocalIP = New Windows.Forms.TextBox()
        Label12 = New Windows.Forms.Label()
        Label2 = New Windows.Forms.Label()
        Label10 = New Windows.Forms.Label()
        Label14 = New Windows.Forms.Label()
        Label13 = New Windows.Forms.Label()
        Label9 = New Windows.Forms.Label()
        PictureBox1 = New Windows.Forms.PictureBox()
        label1 = New Windows.Forms.Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' linkXmlRpcSample
        ' 
        linkXmlRpcSample.AutoSize = True
        linkXmlRpcSample.Location = New Drawing.Point(221, 16)
        linkXmlRpcSample.Name = "linkXmlRpcSample"
        linkXmlRpcSample.Size = New Drawing.Size(100, 13)
        linkXmlRpcSample.TabIndex = 25
        linkXmlRpcSample.TabStop = True
        linkXmlRpcSample.Text = "xml_rpc_sample.urp"
        AddHandler linkXmlRpcSample.LinkClicked, New Windows.Forms.LinkLabelLinkClickedEventHandler(AddressOf linkXmlRpcSample_LinkClicked)
        ' 
        ' txtXmlRpcPort
        ' 
        txtXmlRpcPort.Location = New Drawing.Point(153, 91)
        txtXmlRpcPort.Name = "txtXmlRpcPort"
        txtXmlRpcPort.ReadOnly = True
        txtXmlRpcPort.Size = New Drawing.Size(190, 20)
        txtXmlRpcPort.TabIndex = 10
        ' 
        ' txtLocalIP
        ' 
        txtLocalIP.Location = New Drawing.Point(153, 65)
        txtLocalIP.Name = "txtLocalIP"
        txtLocalIP.ReadOnly = True
        txtLocalIP.Size = New Drawing.Size(190, 20)
        txtLocalIP.TabIndex = 11
        ' 
        ' Label12
        ' 
        Label12.Location = New Drawing.Point(46, 91)
        Label12.Name = "Label12"
        Label12.Size = New Drawing.Size(107, 20)
        Label12.TabIndex = 15
        Label12.Text = "Your local port :"
        Label12.TextAlign = Drawing.ContentAlignment.MiddleRight
        ' 
        ' Label2
        ' 
        Label2.Location = New Drawing.Point(46, 65)
        Label2.Name = "Label2"
        Label2.Size = New Drawing.Size(107, 20)
        Label2.TabIndex = 16
        Label2.Text = "Your local PC IP :"
        Label2.TextAlign = Drawing.ContentAlignment.MiddleRight
        ' 
        ' Label10
        ' 
        Label10.Location = New Drawing.Point(13, 44)
        Label10.Name = "Label10"
        Label10.Size = New Drawing.Size(368, 20)
        Label10.TabIndex = 18
        Label10.Text = "2. Use your local machine information in function rpc_factory() :"
        Label10.TextAlign = Drawing.ContentAlignment.MiddleLeft
        ' 
        ' Label14
        ' 
        Label14.Location = New Drawing.Point(13, 423)
        Label14.Name = "Label14"
        Label14.Size = New Drawing.Size(368, 20)
        Label14.TabIndex = 19
        Label14.Text = "4. Wait here for a popup asking you what to answer the robot..."
        Label14.TextAlign = Drawing.ContentAlignment.MiddleLeft
        ' 
        ' Label13
        ' 
        Label13.Location = New Drawing.Point(13, 124)
        Label13.Name = "Label13"
        Label13.Size = New Drawing.Size(368, 20)
        Label13.TabIndex = 20
        Label13.Text = "3. Run the program on your robot"
        Label13.TextAlign = Drawing.ContentAlignment.MiddleLeft
        ' 
        ' Label9
        ' 
        Label9.Location = New Drawing.Point(13, 12)
        Label9.Name = "Label9"
        Label9.Size = New Drawing.Size(205, 20)
        Label9.TabIndex = 21
        Label9.Text = "1. Upload this program on your UR robot : "
        Label9.TextAlign = Drawing.ContentAlignment.MiddleLeft
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = Windows.Forms.BorderStyle.Fixed3D
        PictureBox1.Image = My.Resources.xml_rpc_sample
        PictureBox1.Location = New Drawing.Point(0, 147)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Drawing.Size(551, 254)
        PictureBox1.SizeMode = Windows.Forms.PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 24
        PictureBox1.TabStop = False
        ' 
        ' label1
        ' 
        label1.Font = New Drawing.Font("Microsoft Sans Serif", 8.25F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
        label1.Location = New Drawing.Point(342, 12)
        label1.Name = "label1"
        label1.Size = New Drawing.Size(209, 112)
        label1.TabIndex = 20
        label1.Text = "WARNING : If the robot fails to connect, check your local firewall and check the " & "robot's security settings in Polyscope: Settings / Security / General"
        label1.TextAlign = Drawing.ContentAlignment.MiddleCenter
        ' 
        ' XmlRpcControl
        ' 
        AutoScaleDimensions = New Drawing.SizeF(6F, 13F)
        AutoScaleMode = Windows.Forms.AutoScaleMode.Font
        Controls.Add(txtXmlRpcPort)
        Controls.Add(txtLocalIP)
        Controls.Add(label1)
        Controls.Add(linkXmlRpcSample)
        Controls.Add(Label12)
        Controls.Add(Label2)
        Controls.Add(Label10)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(Label9)
        Controls.Add(PictureBox1)
        Name = "XmlRpcControl"
        Size = New Drawing.Size(1086, 805)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

#End Region

    Friend linkXmlRpcSample As Windows.Forms.LinkLabel
    Friend txtXmlRpcPort As Windows.Forms.TextBox
    Friend txtLocalIP As Windows.Forms.TextBox
    Friend Label12 As Windows.Forms.Label
    Friend Label2 As Windows.Forms.Label
    Friend Label10 As Windows.Forms.Label
    Friend Label14 As Windows.Forms.Label
    Friend Label13 As Windows.Forms.Label
    Friend Label9 As Windows.Forms.Label
    Friend PictureBox1 As Windows.Forms.PictureBox
    Friend label1 As Windows.Forms.Label
End Class
