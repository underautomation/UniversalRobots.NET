
Partial Class PrimaryInterfacePopup
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        btnClose = New Windows.Forms.Button()
        panel1 = New Windows.Forms.Panel()
        lblMessage = New Windows.Forms.Label()
        img = New Windows.Forms.PictureBox()
        txtAnswer = New Windows.Forms.TextBox()
        panel1.SuspendLayout()
        CType(img, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = Windows.Forms.AnchorStyles.None
        btnClose.Location = New Drawing.Point(86, 10)
        btnClose.Name = "btnClose"
        btnClose.Size = New Drawing.Size(310, 34)
        btnClose.TabIndex = 0
        btnClose.Text = "Close popup on robot"
        btnClose.UseVisualStyleBackColor = True
        AddHandler btnClose.Click, New EventHandler(AddressOf btnClose_Click)
        ' 
        ' panel1
        ' 
        panel1.Controls.Add(btnClose)
        panel1.Dock = Windows.Forms.DockStyle.Bottom
        panel1.Location = New Drawing.Point(0, 125)
        panel1.Name = "panel1"
        panel1.Size = New Drawing.Size(475, 53)
        panel1.TabIndex = 2
        ' 
        ' lblMessage
        ' 
        lblMessage.Dock = Windows.Forms.DockStyle.Fill
        lblMessage.Font = New Drawing.Font("Microsoft Sans Serif", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
        lblMessage.Location = New Drawing.Point(100, 0)
        lblMessage.Name = "lblMessage"
        lblMessage.Size = New Drawing.Size(375, 105)
        lblMessage.TabIndex = 3
        lblMessage.Text = "................"
        lblMessage.TextAlign = Drawing.ContentAlignment.MiddleLeft
        ' 
        ' img
        ' 
        img.BackgroundImage = My.Resources.info
        img.BackgroundImageLayout = Windows.Forms.ImageLayout.Center
        img.Dock = Windows.Forms.DockStyle.Left
        img.Location = New Drawing.Point(0, 0)
        img.Name = "img"
        img.Size = New Drawing.Size(100, 125)
        img.TabIndex = 4
        img.TabStop = False
        ' 
        ' txtAnswer
        ' 
        txtAnswer.Dock = Windows.Forms.DockStyle.Bottom
        txtAnswer.Location = New Drawing.Point(100, 105)
        txtAnswer.Name = "txtAnswer"
        txtAnswer.Size = New Drawing.Size(375, 20)
        txtAnswer.TabIndex = 5
        ' 
        ' PrimaryInterfacePopup
        ' 
        AutoScaleMode = Windows.Forms.AutoScaleMode.None
        AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        ClientSize = New Drawing.Size(475, 178)
        Controls.Add(lblMessage)
        Controls.Add(txtAnswer)
        Controls.Add(img)
        Controls.Add(panel1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "PrimaryInterfacePopup"
        ShowIcon = False
        ShowInTaskbar = False
        StartPosition = Windows.Forms.FormStartPosition.WindowsDefaultBounds
        TopMost = True
        AddHandler Shown, New EventHandler(AddressOf PrimaryInterfacePopup_Shown)
        panel1.ResumeLayout(False)
        CType(img, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

#End Region

    Private btnClose As Windows.Forms.Button
    Private panel1 As Windows.Forms.Panel
    Private lblMessage As Windows.Forms.Label
    Private img As Windows.Forms.PictureBox
    Private txtAnswer As Windows.Forms.TextBox
End Class
