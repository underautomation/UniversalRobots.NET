Partial Class XmlRpcPopup
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
        Panel3 = New Windows.Forms.Panel()
        btnDouble = New Windows.Forms.Button()
        lstArgs = New Windows.Forms.ListView()
        ColumnHeader1 = CType((New Windows.Forms.ColumnHeader()), Windows.Forms.ColumnHeader)
        ColumnHeader2 = CType((New Windows.Forms.ColumnHeader()), Windows.Forms.ColumnHeader)
        Label3 = New Windows.Forms.Label()
        btnPose = New Windows.Forms.Button()
        btnNothing = New Windows.Forms.Button()
        btnArrayPoses = New Windows.Forms.Button()
        BtnString = New Windows.Forms.Button()
        btnArrayNumbers = New Windows.Forms.Button()
        btnFalse = New Windows.Forms.Button()
        btnTrue = New Windows.Forms.Button()
        Label2 = New Windows.Forms.Label()
        txtMethodName = New Windows.Forms.Label()
        Label9 = New Windows.Forms.Label()
        txtArgument = New Windows.Forms.Label()
        Label11 = New Windows.Forms.Label()
        txtIp = New Windows.Forms.Label()
        Panel1 = New Windows.Forms.Panel()
        btnInteger = New Windows.Forms.Button()
        Panel2 = New Windows.Forms.Panel()
        Label10 = New Windows.Forms.Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Drawing.Color.Black
        Panel3.Dock = Windows.Forms.DockStyle.Bottom
        Panel3.Location = New Drawing.Point(0, 265)
        Panel3.Margin = New Windows.Forms.Padding(0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Drawing.Size(516, 4)
        Panel3.TabIndex = 11
        ' 
        ' btnDouble
        ' 
        btnDouble.DialogResult = Windows.Forms.DialogResult.OK
        btnDouble.Location = New Drawing.Point(135, 36)
        btnDouble.Name = "btnDouble"
        btnDouble.Size = New Drawing.Size(115, 23)
        btnDouble.TabIndex = 0
        btnDouble.Text = "Double : 2.5"
        btnDouble.UseVisualStyleBackColor = True
        AddHandler btnDouble.Click, New EventHandler(AddressOf btnDouble_Click)
        ' 
        ' lstArgs
        ' 
        lstArgs.Columns.AddRange(New Windows.Forms.ColumnHeader() {ColumnHeader1, ColumnHeader2})
        lstArgs.Dock = Windows.Forms.DockStyle.Fill
        lstArgs.HideSelection = False
        lstArgs.Location = New Drawing.Point(0, 123)
        lstArgs.Name = "lstArgs"
        lstArgs.Size = New Drawing.Size(516, 146)
        lstArgs.TabIndex = 6
        lstArgs.UseCompatibleStateImageBehavior = False
        lstArgs.View = Windows.Forms.View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Type"
        ColumnHeader1.Width = 96
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Value"
        ColumnHeader2.Width = 382
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Drawing.Point(12, 10)
        Label3.Name = "Label3"
        Label3.Size = New Drawing.Size(275, 13)
        Label3.TabIndex = 0
        Label3.Text = "Choose the object you would like to answer to the robot :"
        ' 
        ' btnPose
        ' 
        btnPose.DialogResult = Windows.Forms.DialogResult.OK
        btnPose.Location = New Drawing.Point(15, 65)
        btnPose.Name = "btnPose"
        btnPose.Size = New Drawing.Size(235, 23)
        btnPose.TabIndex = 0
        btnPose.Text = "Pose : p[100,-100,120,0.2,0,-0.1]"
        btnPose.UseVisualStyleBackColor = True
        AddHandler btnPose.Click, New EventHandler(AddressOf btnPose_Click)
        ' 
        ' btnNothing
        ' 
        btnNothing.DialogResult = Windows.Forms.DialogResult.OK
        btnNothing.Location = New Drawing.Point(187, 123)
        btnNothing.Name = "btnNothing"
        btnNothing.Size = New Drawing.Size(128, 23)
        btnNothing.TabIndex = 0
        btnNothing.Text = "null"
        btnNothing.UseVisualStyleBackColor = True
        AddHandler btnNothing.Click, New EventHandler(AddressOf btnNothing_Click)
        ' 
        ' btnArrayPoses
        ' 
        btnArrayPoses.DialogResult = Windows.Forms.DialogResult.OK
        btnArrayPoses.Location = New Drawing.Point(15, 94)
        btnArrayPoses.Name = "btnArrayPoses"
        btnArrayPoses.Size = New Drawing.Size(235, 23)
        btnArrayPoses.TabIndex = 0
        btnArrayPoses.Text = "Array of poses : [p[0,1,0,0,0,0], p[0,0,1,0,0,0]]"
        btnArrayPoses.UseVisualStyleBackColor = True
        AddHandler btnArrayPoses.Click, New EventHandler(AddressOf btnArrayPoses_Click)
        ' 
        ' BtnString
        ' 
        BtnString.DialogResult = Windows.Forms.DialogResult.OK
        BtnString.Location = New Drawing.Point(256, 65)
        BtnString.Name = "BtnString"
        BtnString.Size = New Drawing.Size(235, 23)
        BtnString.TabIndex = 0
        BtnString.Text = "String : ""Hi Robot !"""
        BtnString.UseVisualStyleBackColor = True
        AddHandler BtnString.Click, New EventHandler(AddressOf BtnString_Click)
        ' 
        ' btnArrayNumbers
        ' 
        btnArrayNumbers.DialogResult = Windows.Forms.DialogResult.OK
        btnArrayNumbers.Location = New Drawing.Point(256, 94)
        btnArrayNumbers.Name = "btnArrayNumbers"
        btnArrayNumbers.Size = New Drawing.Size(235, 23)
        btnArrayNumbers.TabIndex = 0
        btnArrayNumbers.Text = "Array of numbers : [-4, 2.3, 100]"
        btnArrayNumbers.UseVisualStyleBackColor = True
        AddHandler btnArrayNumbers.Click, New EventHandler(AddressOf btnArrayNumbers_Click)
        ' 
        ' btnFalse
        ' 
        btnFalse.DialogResult = Windows.Forms.DialogResult.OK
        btnFalse.Location = New Drawing.Point(376, 36)
        btnFalse.Name = "btnFalse"
        btnFalse.Size = New Drawing.Size(115, 23)
        btnFalse.TabIndex = 0
        btnFalse.Text = "False"
        btnFalse.UseVisualStyleBackColor = True
        AddHandler btnFalse.Click, New EventHandler(AddressOf btnFalse_Click)
        ' 
        ' btnTrue
        ' 
        btnTrue.DialogResult = Windows.Forms.DialogResult.OK
        btnTrue.Location = New Drawing.Point(256, 36)
        btnTrue.Name = "btnTrue"
        btnTrue.Size = New Drawing.Size(115, 23)
        btnTrue.TabIndex = 0
        btnTrue.Text = "True"
        btnTrue.UseVisualStyleBackColor = True
        AddHandler btnTrue.Click, New EventHandler(AddressOf btnTrue_Click)
        ' 
        ' Label2
        ' 
        Label2.Dock = Windows.Forms.DockStyle.Bottom
        Label2.Font = New Drawing.Font("Microsoft Sans Serif", 14F, Drawing.FontStyle.Bold)
        Label2.Location = New Drawing.Point(0, 269)
        Label2.Name = "Label2"
        Label2.Size = New Drawing.Size(516, 37)
        Label2.TabIndex = 10
        Label2.Text = "Answer :"
        Label2.TextAlign = Drawing.ContentAlignment.MiddleCenter
        ' 
        ' txtMethodName
        ' 
        txtMethodName.AutoSize = True
        txtMethodName.Font = New Drawing.Font("Microsoft Sans Serif", 10F, Drawing.FontStyle.Bold)
        txtMethodName.Location = New Drawing.Point(91, 10)
        txtMethodName.Name = "txtMethodName"
        txtMethodName.Size = New Drawing.Size(74, 17)
        txtMethodName.TabIndex = 1
        txtMethodName.Text = "METHOD"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Drawing.Point(12, 12)
        Label9.Name = "Label9"
        Label9.Size = New Drawing.Size(83, 13)
        Label9.TabIndex = 2
        Label9.Text = "Method called : "
        ' 
        ' txtArgument
        ' 
        txtArgument.AutoSize = True
        txtArgument.Location = New Drawing.Point(12, 67)
        txtArgument.Name = "txtArgument"
        txtArgument.Size = New Drawing.Size(162, 13)
        txtArgument.TabIndex = 3
        txtArgument.Text = "The request has % argument(s) : "
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Drawing.Point(12, 36)
        Label11.Name = "Label11"
        Label11.Size = New Drawing.Size(66, 13)
        Label11.TabIndex = 4
        Label11.Text = "From robot : "
        ' 
        ' txtIp
        ' 
        txtIp.AutoSize = True
        txtIp.Font = New Drawing.Font("Microsoft Sans Serif", 10F, Drawing.FontStyle.Bold)
        txtIp.Location = New Drawing.Point(75, 34)
        txtIp.Name = "txtIp"
        txtIp.Size = New Drawing.Size(22, 17)
        txtIp.TabIndex = 5
        txtIp.Text = "IP"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(txtMethodName)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(txtArgument)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(txtIp)
        Panel1.Dock = Windows.Forms.DockStyle.Top
        Panel1.Location = New Drawing.Point(0, 37)
        Panel1.Name = "Panel1"
        Panel1.Size = New Drawing.Size(516, 86)
        Panel1.TabIndex = 7
        ' 
        ' btnInteger
        ' 
        btnInteger.DialogResult = Windows.Forms.DialogResult.OK
        btnInteger.Location = New Drawing.Point(15, 36)
        btnInteger.Name = "btnInteger"
        btnInteger.Size = New Drawing.Size(115, 23)
        btnInteger.TabIndex = 0
        btnInteger.Text = "Integer : -12"
        btnInteger.UseVisualStyleBackColor = True
        AddHandler btnInteger.Click, New EventHandler(AddressOf btnInteger_Click)
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(btnPose)
        Panel2.Controls.Add(btnNothing)
        Panel2.Controls.Add(btnArrayPoses)
        Panel2.Controls.Add(BtnString)
        Panel2.Controls.Add(btnArrayNumbers)
        Panel2.Controls.Add(btnFalse)
        Panel2.Controls.Add(btnTrue)
        Panel2.Controls.Add(btnDouble)
        Panel2.Controls.Add(btnInteger)
        Panel2.Dock = Windows.Forms.DockStyle.Bottom
        Panel2.Location = New Drawing.Point(0, 306)
        Panel2.Name = "Panel2"
        Panel2.Size = New Drawing.Size(516, 155)
        Panel2.TabIndex = 8
        ' 
        ' Label10
        ' 
        Label10.Dock = Windows.Forms.DockStyle.Top
        Label10.Font = New Drawing.Font("Microsoft Sans Serif", 14F, Drawing.FontStyle.Bold)
        Label10.Location = New Drawing.Point(0, 0)
        Label10.Name = "Label10"
        Label10.Size = New Drawing.Size(516, 37)
        Label10.TabIndex = 9
        Label10.Text = "Request :"
        Label10.TextAlign = Drawing.ContentAlignment.MiddleCenter
        ' 
        ' XmlRpcPopup
        ' 
        AutoScaleDimensions = New Drawing.SizeF(6F, 13F)
        AutoScaleMode = Windows.Forms.AutoScaleMode.Font
        ClientSize = New Drawing.Size(516, 461)
        Controls.Add(Panel3)
        Controls.Add(lstArgs)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Controls.Add(Label10)
        Name = "XmlRpcPopup"
        ShowIcon = False
        StartPosition = Windows.Forms.FormStartPosition.CenterParent
        Text = "XML-RPC request"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)

    End Sub

#End Region

    Friend Panel3 As Windows.Forms.Panel
    Friend btnDouble As Windows.Forms.Button
    Private lstArgs As Windows.Forms.ListView
    Friend ColumnHeader1 As Windows.Forms.ColumnHeader
    Friend ColumnHeader2 As Windows.Forms.ColumnHeader
    Friend Label3 As Windows.Forms.Label
    Friend btnPose As Windows.Forms.Button
    Friend btnNothing As Windows.Forms.Button
    Friend btnArrayPoses As Windows.Forms.Button
    Friend BtnString As Windows.Forms.Button
    Friend btnArrayNumbers As Windows.Forms.Button
    Friend btnFalse As Windows.Forms.Button
    Friend btnTrue As Windows.Forms.Button
    Friend Label2 As Windows.Forms.Label
    Friend txtMethodName As Windows.Forms.Label
    Friend Label9 As Windows.Forms.Label
    Friend txtArgument As Windows.Forms.Label
    Friend Label11 As Windows.Forms.Label
    Friend txtIp As Windows.Forms.Label
    Friend Panel1 As Windows.Forms.Panel
    Friend btnInteger As Windows.Forms.Button
    Friend Panel2 As Windows.Forms.Panel
    Friend Label10 As Windows.Forms.Label
End Class
