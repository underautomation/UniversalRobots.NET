
Partial Class ToolsControl
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
        GroupBox7 = New Windows.Forms.GroupBox()
        RadioButton2 = New Windows.Forms.RadioButton()
        radioRPYToRotationVector = New Windows.Forms.RadioButton()
        txtRz = New Windows.Forms.TextBox()
        txtRy = New Windows.Forms.TextBox()
        txtRx = New Windows.Forms.TextBox()
        udRz = New Windows.Forms.NumericUpDown()
        udRy = New Windows.Forms.NumericUpDown()
        udRx = New Windows.Forms.NumericUpDown()
        Label6 = New Windows.Forms.Label()
        Label7 = New Windows.Forms.Label()
        Label5 = New Windows.Forms.Label()
        Label4 = New Windows.Forms.Label()
        txtOut = New Windows.Forms.Label()
        txtIn = New Windows.Forms.Label()
        GroupBox7.SuspendLayout()
        CType(udRz, ComponentModel.ISupportInitialize).BeginInit()
        CType(udRy, ComponentModel.ISupportInitialize).BeginInit()
        CType(udRx, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox7
        ' 
        GroupBox7.Controls.Add(RadioButton2)
        GroupBox7.Controls.Add(radioRPYToRotationVector)
        GroupBox7.Controls.Add(txtRz)
        GroupBox7.Controls.Add(txtRy)
        GroupBox7.Controls.Add(txtRx)
        GroupBox7.Controls.Add(udRz)
        GroupBox7.Controls.Add(udRy)
        GroupBox7.Controls.Add(udRx)
        GroupBox7.Controls.Add(Label6)
        GroupBox7.Controls.Add(Label7)
        GroupBox7.Controls.Add(Label5)
        GroupBox7.Controls.Add(Label4)
        GroupBox7.Controls.Add(txtOut)
        GroupBox7.Controls.Add(txtIn)
        GroupBox7.Location = New Drawing.Point(21, 21)
        GroupBox7.Name = "GroupBox7"
        GroupBox7.Size = New Drawing.Size(439, 191)
        GroupBox7.TabIndex = 5
        GroupBox7.TabStop = False
        GroupBox7.Text = "Convert angles"
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Drawing.Point(260, 25)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Drawing.Size(162, 17)
        RadioButton2.TabIndex = 7
        RadioButton2.Text = "From Rotation Vector to RPY"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' radioRPYToRotationVector
        ' 
        radioRPYToRotationVector.AutoSize = True
        radioRPYToRotationVector.Checked = True
        radioRPYToRotationVector.Location = New Drawing.Point(72, 25)
        radioRPYToRotationVector.Name = "radioRPYToRotationVector"
        radioRPYToRotationVector.Size = New Drawing.Size(161, 17)
        radioRPYToRotationVector.TabIndex = 6
        radioRPYToRotationVector.TabStop = True
        radioRPYToRotationVector.Text = "From RPY to Rotation vector"
        radioRPYToRotationVector.UseVisualStyleBackColor = True
        AddHandler radioRPYToRotationVector.CheckedChanged, New EventHandler(AddressOf ValueChanged)
        ' 
        ' txtRz
        ' 
        txtRz.Location = New Drawing.Point(243, 145)
        txtRz.Name = "txtRz"
        txtRz.ReadOnly = True
        txtRz.Size = New Drawing.Size(100, 20)
        txtRz.TabIndex = 5
        ' 
        ' txtRy
        ' 
        txtRy.Location = New Drawing.Point(243, 119)
        txtRy.Name = "txtRy"
        txtRy.ReadOnly = True
        txtRy.Size = New Drawing.Size(100, 20)
        txtRy.TabIndex = 4
        ' 
        ' txtRx
        ' 
        txtRx.Location = New Drawing.Point(243, 93)
        txtRx.Name = "txtRx"
        txtRx.ReadOnly = True
        txtRx.Size = New Drawing.Size(100, 20)
        txtRx.TabIndex = 3
        ' 
        ' udRz
        ' 
        udRz.DecimalPlaces = 3
        udRz.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        udRz.Location = New Drawing.Point(72, 145)
        udRz.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        udRz.Minimum = New Decimal(New Integer() {9999, 0, 0, -2147483648})
        udRz.Name = "udRz"
        udRz.Size = New Drawing.Size(120, 20)
        udRz.TabIndex = 2
        AddHandler udRz.ValueChanged, New EventHandler(AddressOf ValueChanged)
        ' 
        ' udRy
        ' 
        udRy.DecimalPlaces = 3
        udRy.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        udRy.Location = New Drawing.Point(72, 119)
        udRy.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        udRy.Minimum = New Decimal(New Integer() {9999, 0, 0, -2147483648})
        udRy.Name = "udRy"
        udRy.Size = New Drawing.Size(120, 20)
        udRy.TabIndex = 1
        AddHandler udRy.ValueChanged, New EventHandler(AddressOf ValueChanged)
        ' 
        ' udRx
        ' 
        udRx.DecimalPlaces = 3
        udRx.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        udRx.Location = New Drawing.Point(72, 93)
        udRx.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        udRx.Minimum = New Decimal(New Integer() {9999, 0, 0, -2147483648})
        udRx.Name = "udRx"
        udRx.Size = New Drawing.Size(120, 20)
        udRx.TabIndex = 0
        AddHandler udRx.ValueChanged, New EventHandler(AddressOf ValueChanged)
        ' 
        ' Label6
        ' 
        Label6.Location = New Drawing.Point(11, 147)
        Label6.Name = "Label6"
        Label6.Size = New Drawing.Size(55, 13)
        Label6.TabIndex = 1
        Label6.Text = "RZ (rad) :"
        Label6.TextAlign = Drawing.ContentAlignment.MiddleRight
        ' 
        ' Label7
        ' 
        Label7.Font = New Drawing.Font("Microsoft Sans Serif", 14.25F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
        Label7.Location = New Drawing.Point(198, 93)
        Label7.Name = "Label7"
        Label7.Size = New Drawing.Size(39, 72)
        Label7.TabIndex = 1
        Label7.Text = "="
        Label7.TextAlign = Drawing.ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.Location = New Drawing.Point(11, 121)
        Label5.Name = "Label5"
        Label5.Size = New Drawing.Size(55, 13)
        Label5.TabIndex = 1
        Label5.Text = "RY (rad) :"
        Label5.TextAlign = Drawing.ContentAlignment.MiddleRight
        ' 
        ' Label4
        ' 
        Label4.Location = New Drawing.Point(11, 95)
        Label4.Name = "Label4"
        Label4.Size = New Drawing.Size(55, 13)
        Label4.TabIndex = 1
        Label4.Text = "RX (rad) :"
        Label4.TextAlign = Drawing.ContentAlignment.MiddleRight
        ' 
        ' txtOut
        ' 
        txtOut.Font = New Drawing.Font("Microsoft Sans Serif", 14.25F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
        txtOut.Location = New Drawing.Point(224, 52)
        txtOut.Name = "txtOut"
        txtOut.Size = New Drawing.Size(142, 38)
        txtOut.TabIndex = 1
        txtOut.Text = "Rotation Vector"
        txtOut.TextAlign = Drawing.ContentAlignment.MiddleCenter
        ' 
        ' txtIn
        ' 
        txtIn.Font = New Drawing.Font("Microsoft Sans Serif", 14.25F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
        txtIn.Location = New Drawing.Point(56, 52)
        txtIn.Name = "txtIn"
        txtIn.Size = New Drawing.Size(147, 38)
        txtIn.TabIndex = 1
        txtIn.Text = "RPY"
        txtIn.TextAlign = Drawing.ContentAlignment.MiddleCenter
        ' 
        ' ToolsControl
        ' 
        AutoScaleDimensions = New Drawing.SizeF(6F, 13F)
        AutoScaleMode = Windows.Forms.AutoScaleMode.Font
        Controls.Add(GroupBox7)
        Name = "ToolsControl"
        Size = New Drawing.Size(741, 580)
        GroupBox7.ResumeLayout(False)
        GroupBox7.PerformLayout()
        CType(udRz, ComponentModel.ISupportInitialize).EndInit()
        CType(udRy, ComponentModel.ISupportInitialize).EndInit()
        CType(udRx, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

#End Region

    Friend GroupBox7 As Windows.Forms.GroupBox
    Friend RadioButton2 As Windows.Forms.RadioButton
    Friend radioRPYToRotationVector As Windows.Forms.RadioButton
    Friend txtRz As Windows.Forms.TextBox
    Friend txtRy As Windows.Forms.TextBox
    Friend txtRx As Windows.Forms.TextBox
    Friend udRz As Windows.Forms.NumericUpDown
    Friend udRy As Windows.Forms.NumericUpDown
    Friend udRx As Windows.Forms.NumericUpDown
    Friend Label6 As Windows.Forms.Label
    Friend Label7 As Windows.Forms.Label
    Friend Label5 As Windows.Forms.Label
    Friend Label4 As Windows.Forms.Label
    Friend txtOut As Windows.Forms.Label
    Friend txtIn As Windows.Forms.Label
End Class
