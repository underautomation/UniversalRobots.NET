
Partial Class LicenseControl
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
        txtLicenseInfo = New Windows.Forms.RichTextBox()
        gridLicense = New Windows.Forms.PropertyGrid()
        groupBox1 = New Windows.Forms.GroupBox()
        btnSetLicense = New Windows.Forms.Button()
        label2 = New Windows.Forms.Label()
        label1 = New Windows.Forms.Label()
        txtKey = New Windows.Forms.TextBox()
        txtLicensee = New Windows.Forms.TextBox()
        groupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtLicenseInfo
        ' 
        txtLicenseInfo.BackColor = Drawing.SystemColors.ControlLight
        txtLicenseInfo.Location = New Drawing.Point(36, 140)
        txtLicenseInfo.Name = "txtLicenseInfo"
        txtLicenseInfo.ReadOnly = True
        txtLicenseInfo.Size = New Drawing.Size(459, 109)
        txtLicenseInfo.TabIndex = 6
        txtLicenseInfo.Text = ""
        AddHandler txtLicenseInfo.LinkClicked, New Windows.Forms.LinkClickedEventHandler(AddressOf txtLicenseInfo_LinkClicked)
        ' 
        ' gridLicense
        ' 
        gridLicense.HelpVisible = False
        gridLicense.Location = New Drawing.Point(36, 255)
        gridLicense.Name = "gridLicense"
        gridLicense.Size = New Drawing.Size(459, 200)
        gridLicense.TabIndex = 7
        gridLicense.ToolbarVisible = False
        ' 
        ' groupBox1
        ' 
        groupBox1.Controls.Add(btnSetLicense)
        groupBox1.Controls.Add(label2)
        groupBox1.Controls.Add(label1)
        groupBox1.Controls.Add(txtKey)
        groupBox1.Controls.Add(txtLicensee)
        groupBox1.Location = New Drawing.Point(36, 3)
        groupBox1.Name = "groupBox1"
        groupBox1.Size = New Drawing.Size(459, 121)
        groupBox1.TabIndex = 8
        groupBox1.TabStop = False
        groupBox1.Text = "Add your license key"
        ' 
        ' btnSetLicense
        ' 
        btnSetLicense.Location = New Drawing.Point(73, 86)
        btnSetLicense.Name = "btnSetLicense"
        btnSetLicense.Size = New Drawing.Size(127, 24)
        btnSetLicense.TabIndex = 2
        btnSetLicense.Text = "Set License"
        btnSetLicense.UseVisualStyleBackColor = True
        AddHandler btnSetLicense.Click, New EventHandler(AddressOf btnSetLicense_Click)
        ' 
        ' label2
        ' 
        label2.Location = New Drawing.Point(3, 58)
        label2.Name = "label2"
        label2.Size = New Drawing.Size(64, 23)
        label2.TabIndex = 1
        label2.Text = "Key :"
        label2.TextAlign = Drawing.ContentAlignment.MiddleRight
        ' 
        ' label1
        ' 
        label1.Location = New Drawing.Point(3, 31)
        label1.Name = "label1"
        label1.Size = New Drawing.Size(64, 23)
        label1.TabIndex = 1
        label1.Text = "Licensee :"
        label1.TextAlign = Drawing.ContentAlignment.MiddleRight
        ' 
        ' txtKey
        ' 
        txtKey.Location = New Drawing.Point(73, 60)
        txtKey.Name = "txtKey"
        txtKey.Size = New Drawing.Size(380, 20)
        txtKey.TabIndex = 0
        txtKey.UseSystemPasswordChar = True
        ' 
        ' txtLicensee
        ' 
        txtLicensee.Location = New Drawing.Point(73, 33)
        txtLicensee.Name = "txtLicensee"
        txtLicensee.Size = New Drawing.Size(380, 20)
        txtLicensee.TabIndex = 0
        ' 
        ' LicenseControl
        ' 
        AutoScaleDimensions = New Drawing.SizeF(6F, 13F)
        AutoScaleMode = Windows.Forms.AutoScaleMode.Font
        Controls.Add(groupBox1)
        Controls.Add(gridLicense)
        Controls.Add(txtLicenseInfo)
        Name = "LicenseControl"
        Size = New Drawing.Size(820, 589)
        groupBox1.ResumeLayout(False)
        groupBox1.PerformLayout()
        ResumeLayout(False)

    End Sub

#End Region

    Friend txtLicenseInfo As Windows.Forms.RichTextBox
    Private gridLicense As Windows.Forms.PropertyGrid
    Private groupBox1 As Windows.Forms.GroupBox
    Private txtKey As Windows.Forms.TextBox
    Private txtLicensee As Windows.Forms.TextBox
    Private btnSetLicense As Windows.Forms.Button
    Private label2 As Windows.Forms.Label
    Private label1 As Windows.Forms.Label
End Class
