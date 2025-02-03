
Partial Class ArchiveControl
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
        toolStrip1 = New Windows.Forms.ToolStrip()
        btnOpen = New Windows.Forms.ToolStripButton()
        browser = New Windows.Forms.WebBrowser()
        lblFile = New Windows.Forms.Label()
        dlgOpen = New Windows.Forms.OpenFileDialog()
        toolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' toolStrip1
        ' 
        toolStrip1.Items.AddRange(New Windows.Forms.ToolStripItem() {btnOpen})
        toolStrip1.Location = New Drawing.Point(0, 0)
        toolStrip1.Name = "toolStrip1"
        toolStrip1.Size = New Drawing.Size(660, 25)
        toolStrip1.TabIndex = 1
        toolStrip1.Text = "toolStrip1"
        ' 
        ' btnOpen
        ' 
        btnOpen.Image = My.Resources.folder_line
        btnOpen.ImageTransparentColor = Drawing.Color.Magenta
        btnOpen.Name = "btnOpen"
        btnOpen.Size = New Drawing.Size(56, 22)
        btnOpen.Text = "Open"
        AddHandler btnOpen.Click, New EventHandler(AddressOf btnOpen_Click)
        ' 
        ' browser
        ' 
        browser.AllowNavigation = False
        browser.Dock = Windows.Forms.DockStyle.Fill
        browser.IsWebBrowserContextMenuEnabled = False
        browser.Location = New Drawing.Point(0, 45)
        browser.MinimumSize = New Drawing.Size(20, 20)
        browser.Name = "browser"
        browser.ScriptErrorsSuppressed = True
        browser.Size = New Drawing.Size(660, 431)
        browser.TabIndex = 2
        ' 
        ' lblFile
        ' 
        lblFile.Dock = Windows.Forms.DockStyle.Top
        lblFile.Location = New Drawing.Point(0, 25)
        lblFile.Name = "lblFile"
        lblFile.Size = New Drawing.Size(660, 20)
        lblFile.TabIndex = 3
        lblFile.Text = "---"
        lblFile.TextAlign = Drawing.ContentAlignment.MiddleCenter
        ' 
        ' dlgOpen
        ' 
        dlgOpen.Filter = "Program or installation|*.urp;*.installation|All files|*.*"
        dlgOpen.RestoreDirectory = True
        ' 
        ' ArchiveControl
        ' 
        AutoScaleDimensions = New Drawing.SizeF(6F, 13F)
        AutoScaleMode = Windows.Forms.AutoScaleMode.Font
        Controls.Add(browser)
        Controls.Add(lblFile)
        Controls.Add(toolStrip1)
        Name = "ArchiveControl"
        Size = New Drawing.Size(660, 476)
        toolStrip1.ResumeLayout(False)
        toolStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

#End Region

    Private toolStrip1 As Windows.Forms.ToolStrip
    Private btnOpen As Windows.Forms.ToolStripButton
    Private browser As Windows.Forms.WebBrowser
    Private lblFile As Windows.Forms.Label
    Private dlgOpen As Windows.Forms.OpenFileDialog
End Class
