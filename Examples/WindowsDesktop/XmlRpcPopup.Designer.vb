<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XmlRpcPopup
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnInteger = New System.Windows.Forms.Button()
        Me.lstArgs = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtMethodName = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtArgument = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtIp = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnPose = New System.Windows.Forms.Button()
        Me.btnNothing = New System.Windows.Forms.Button()
        Me.btnArrayPoses = New System.Windows.Forms.Button()
        Me.BtnString = New System.Windows.Forms.Button()
        Me.btnArrayNumbers = New System.Windows.Forms.Button()
        Me.btnFalse = New System.Windows.Forms.Button()
        Me.btnTrue = New System.Windows.Forms.Button()
        Me.btnDouble = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnInteger
        '
        Me.btnInteger.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnInteger.Location = New System.Drawing.Point(15, 36)
        Me.btnInteger.Name = "btnInteger"
        Me.btnInteger.Size = New System.Drawing.Size(115, 23)
        Me.btnInteger.TabIndex = 0
        Me.btnInteger.Text = "Integer : -12"
        Me.btnInteger.UseVisualStyleBackColor = True
        '
        'lstArgs
        '
        Me.lstArgs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lstArgs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstArgs.HideSelection = False
        Me.lstArgs.Location = New System.Drawing.Point(0, 123)
        Me.lstArgs.Name = "lstArgs"
        Me.lstArgs.Size = New System.Drawing.Size(523, 158)
        Me.lstArgs.TabIndex = 1
        Me.lstArgs.UseCompatibleStateImageBehavior = False
        Me.lstArgs.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Type"
        Me.ColumnHeader1.Width = 96
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Value"
        Me.ColumnHeader2.Width = 382
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtMethodName)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtArgument)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtIp)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(523, 86)
        Me.Panel1.TabIndex = 2
        '
        'txtMethodName
        '
        Me.txtMethodName.AutoSize = True
        Me.txtMethodName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtMethodName.Location = New System.Drawing.Point(91, 10)
        Me.txtMethodName.Name = "txtMethodName"
        Me.txtMethodName.Size = New System.Drawing.Size(74, 17)
        Me.txtMethodName.TabIndex = 1
        Me.txtMethodName.Text = "METHOD"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Method called : "
        '
        'txtArgument
        '
        Me.txtArgument.AutoSize = True
        Me.txtArgument.Location = New System.Drawing.Point(12, 67)
        Me.txtArgument.Name = "txtArgument"
        Me.txtArgument.Size = New System.Drawing.Size(162, 13)
        Me.txtArgument.TabIndex = 3
        Me.txtArgument.Text = "The request has % argument(s) : "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 36)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "From robot : "
        '
        'txtIp
        '
        Me.txtIp.AutoSize = True
        Me.txtIp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtIp.Location = New System.Drawing.Point(75, 34)
        Me.txtIp.Name = "txtIp"
        Me.txtIp.Size = New System.Drawing.Size(22, 17)
        Me.txtIp.TabIndex = 5
        Me.txtIp.Text = "IP"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.btnPose)
        Me.Panel2.Controls.Add(Me.btnNothing)
        Me.Panel2.Controls.Add(Me.btnArrayPoses)
        Me.Panel2.Controls.Add(Me.BtnString)
        Me.Panel2.Controls.Add(Me.btnArrayNumbers)
        Me.Panel2.Controls.Add(Me.btnFalse)
        Me.Panel2.Controls.Add(Me.btnTrue)
        Me.Panel2.Controls.Add(Me.btnDouble)
        Me.Panel2.Controls.Add(Me.btnInteger)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 318)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(523, 155)
        Me.Panel2.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(275, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Choose the object you would like to answer to the robot :"
        '
        'btnPose
        '
        Me.btnPose.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnPose.Location = New System.Drawing.Point(15, 65)
        Me.btnPose.Name = "btnPose"
        Me.btnPose.Size = New System.Drawing.Size(235, 23)
        Me.btnPose.TabIndex = 0
        Me.btnPose.Text = "Pose : p[100,-100,120,0.2,0,-0.1]"
        Me.btnPose.UseVisualStyleBackColor = True
        '
        'btnNothing
        '
        Me.btnNothing.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnNothing.Location = New System.Drawing.Point(187, 123)
        Me.btnNothing.Name = "btnNothing"
        Me.btnNothing.Size = New System.Drawing.Size(128, 23)
        Me.btnNothing.TabIndex = 0
        Me.btnNothing.Text = "Nothing"
        Me.btnNothing.UseVisualStyleBackColor = True
        '
        'btnArrayPoses
        '
        Me.btnArrayPoses.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnArrayPoses.Location = New System.Drawing.Point(15, 94)
        Me.btnArrayPoses.Name = "btnArrayPoses"
        Me.btnArrayPoses.Size = New System.Drawing.Size(235, 23)
        Me.btnArrayPoses.TabIndex = 0
        Me.btnArrayPoses.Text = "Array of poses : [p[0,1,0,0,0,0], p[0,0,1,0,0,0]]"
        Me.btnArrayPoses.UseVisualStyleBackColor = True
        '
        'BtnString
        '
        Me.BtnString.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BtnString.Location = New System.Drawing.Point(256, 65)
        Me.BtnString.Name = "BtnString"
        Me.BtnString.Size = New System.Drawing.Size(235, 23)
        Me.BtnString.TabIndex = 0
        Me.BtnString.Text = "String : ""Hi Robot !"""
        Me.BtnString.UseVisualStyleBackColor = True
        '
        'btnArrayNumbers
        '
        Me.btnArrayNumbers.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnArrayNumbers.Location = New System.Drawing.Point(256, 94)
        Me.btnArrayNumbers.Name = "btnArrayNumbers"
        Me.btnArrayNumbers.Size = New System.Drawing.Size(235, 23)
        Me.btnArrayNumbers.TabIndex = 0
        Me.btnArrayNumbers.Text = "Array of numbers : [-4, 2.3, 100]"
        Me.btnArrayNumbers.UseVisualStyleBackColor = True
        '
        'btnFalse
        '
        Me.btnFalse.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnFalse.Location = New System.Drawing.Point(376, 36)
        Me.btnFalse.Name = "btnFalse"
        Me.btnFalse.Size = New System.Drawing.Size(115, 23)
        Me.btnFalse.TabIndex = 0
        Me.btnFalse.Text = "False"
        Me.btnFalse.UseVisualStyleBackColor = True
        '
        'btnTrue
        '
        Me.btnTrue.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnTrue.Location = New System.Drawing.Point(256, 36)
        Me.btnTrue.Name = "btnTrue"
        Me.btnTrue.Size = New System.Drawing.Size(115, 23)
        Me.btnTrue.TabIndex = 0
        Me.btnTrue.Text = "True"
        Me.btnTrue.UseVisualStyleBackColor = True
        '
        'btnDouble
        '
        Me.btnDouble.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnDouble.Location = New System.Drawing.Point(135, 36)
        Me.btnDouble.Name = "btnDouble"
        Me.btnDouble.Size = New System.Drawing.Size(115, 23)
        Me.btnDouble.TabIndex = 0
        Me.btnDouble.Text = "Double : 2.5"
        Me.btnDouble.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(0, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(523, 37)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Request :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(0, 281)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(523, 37)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Answer :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 277)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(523, 4)
        Me.Panel3.TabIndex = 5
        '
        'XmlRpcPopup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 473)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.lstArgs)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label10)
        Me.Name = "XmlRpcPopup"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "XML-RPC request"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnInteger As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Private WithEvents lstArgs As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents Label3 As Label
    Friend WithEvents btnPose As Button
    Friend WithEvents BtnString As Button
    Friend WithEvents btnArrayNumbers As Button
    Friend WithEvents btnFalse As Button
    Friend WithEvents btnTrue As Button
    Friend WithEvents btnDouble As Button
    Friend WithEvents btnArrayPoses As Button
    Friend WithEvents btnNothing As Button
    Friend WithEvents txtMethodName As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtArgument As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtIp As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
End Class
