
Partial Class ConnectRtdePopupBase
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
        tree = New Windows.Forms.TreeView()
        panel1 = New Windows.Forms.Panel()
        button1 = New Windows.Forms.Button()
        panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' tree
        ' 
        tree.CheckBoxes = True
        tree.Dock = Windows.Forms.DockStyle.Fill
        tree.Location = New Drawing.Point(0, 0)
        tree.Name = "tree"
        tree.ShowNodeToolTips = True
        tree.Size = New Drawing.Size(304, 477)
        tree.TabIndex = 0
        AddHandler tree.AfterCheck, New Windows.Forms.TreeViewEventHandler(AddressOf tree_AfterCheck)
        ' 
        ' panel1
        ' 
        panel1.Controls.Add(button1)
        panel1.Dock = Windows.Forms.DockStyle.Bottom
        panel1.Location = New Drawing.Point(0, 477)
        panel1.Name = "panel1"
        panel1.Size = New Drawing.Size(304, 51)
        panel1.TabIndex = 1
        ' 
        ' button1
        ' 
        button1.Anchor = Windows.Forms.AnchorStyles.None
        button1.DialogResult = Windows.Forms.DialogResult.OK
        button1.Location = New Drawing.Point(89, 6)
        button1.Name = "button1"
        button1.Size = New Drawing.Size(126, 38)
        button1.TabIndex = 2
        button1.Text = "OK"
        button1.UseVisualStyleBackColor = True
        ' 
        ' ConnectRtdePopupBase
        ' 
        AutoScaleDimensions = New Drawing.SizeF(6F, 13F)
        AutoScaleMode = Windows.Forms.AutoScaleMode.Font
        ClientSize = New Drawing.Size(304, 528)
        Controls.Add(tree)
        Controls.Add(panel1)
        Name = "ConnectRtdePopupBase"
        ShowIcon = False
        StartPosition = Windows.Forms.FormStartPosition.CenterParent
        TopMost = True
        panel1.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

#End Region
    Private panel1 As Windows.Forms.Panel
    Private button1 As Windows.Forms.Button
    Protected tree As Windows.Forms.TreeView
End Class
