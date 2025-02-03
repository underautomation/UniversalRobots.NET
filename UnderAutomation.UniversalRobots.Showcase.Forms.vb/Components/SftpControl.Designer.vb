
Partial Class SftpControl
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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(SftpControl))
        SplitContainer2 = New Windows.Forms.SplitContainer()
        lstFolder = New Windows.Forms.ListView()
        lstFolderImageList = New Windows.Forms.ImageList(components)
        ToolStrip1 = New Windows.Forms.ToolStrip()
        btnPrevious = New Windows.Forms.ToolStripButton()
        txtPath = New Windows.Forms.ToolStripTextBox()
        btnOpenPath = New Windows.Forms.ToolStripButton()
        tsFolder = New Windows.Forms.ToolStrip()
        btnRefresh = New Windows.Forms.ToolStripButton()
        btnDownload = New Windows.Forms.ToolStripButton()
        btnDelete = New Windows.Forms.ToolStripButton()
        btnRename = New Windows.Forms.ToolStripButton()
        btnUpload = New Windows.Forms.ToolStripButton()
        btnNewFolder = New Windows.Forms.ToolStripButton()
        btnDecompile = New Windows.Forms.ToolStripButton()
        gridFile = New Windows.Forms.PropertyGrid()
        dlgOpen = New Windows.Forms.OpenFileDialog()
        dlgSave = New Windows.Forms.SaveFileDialog()
        SplitContainer2.Panel1.SuspendLayout()
        SplitContainer2.Panel2.SuspendLayout()
        SplitContainer2.SuspendLayout()
        ToolStrip1.SuspendLayout()
        tsFolder.SuspendLayout()
        SuspendLayout()
        ' 
        ' SplitContainer2
        ' 
        SplitContainer2.BorderStyle = Windows.Forms.BorderStyle.Fixed3D
        SplitContainer2.Dock = Windows.Forms.DockStyle.Fill
        SplitContainer2.Location = New Drawing.Point(0, 0)
        SplitContainer2.Name = "SplitContainer2"
        ' 
        ' SplitContainer2.Panel1
        ' 
        SplitContainer2.Panel1.Controls.Add(lstFolder)
        SplitContainer2.Panel1.Controls.Add(ToolStrip1)
        SplitContainer2.Panel1.Controls.Add(tsFolder)
        ' 
        ' SplitContainer2.Panel2
        ' 
        SplitContainer2.Panel2.Controls.Add(gridFile)
        SplitContainer2.Size = New Drawing.Size(701, 662)
        SplitContainer2.SplitterDistance = 620
        SplitContainer2.TabIndex = 2
        ' 
        ' lstFolder
        ' 
        lstFolder.Activation = Windows.Forms.ItemActivation.TwoClick
        lstFolder.Dock = Windows.Forms.DockStyle.Fill
        lstFolder.HideSelection = False
        lstFolder.LabelEdit = True
        lstFolder.LargeImageList = lstFolderImageList
        lstFolder.Location = New Drawing.Point(0, 50)
        lstFolder.Name = "lstFolder"
        lstFolder.Size = New Drawing.Size(616, 608)
        lstFolder.TabIndex = 1
        lstFolder.UseCompatibleStateImageBehavior = False
        AddHandler lstFolder.AfterLabelEdit, New Windows.Forms.LabelEditEventHandler(AddressOf lstFolder_AfterLabelEdit)
        AddHandler lstFolder.ItemActivate, New EventHandler(AddressOf lstFolder_ItemActivate)
        AddHandler lstFolder.ItemSelectionChanged, New Windows.Forms.ListViewItemSelectionChangedEventHandler(AddressOf lstFolder_ItemSelectionChanged)
        AddHandler lstFolder.SelectedIndexChanged, New EventHandler(AddressOf lstFolder_SelectedIndexChanged)
        ' 
        ' lstFolderImageList
        ' 
        lstFolderImageList.ImageStream = CType(resources.GetObject("lstFolderImageList.ImageStream"), Windows.Forms.ImageListStreamer)
        lstFolderImageList.TransparentColor = Drawing.Color.Transparent
        lstFolderImageList.Images.SetKeyName(0, "folder")
        lstFolderImageList.Images.SetKeyName(1, "file")
        lstFolderImageList.Images.SetKeyName(2, "symbolicLink")
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.Items.AddRange(New Windows.Forms.ToolStripItem() {btnPrevious, txtPath, btnOpenPath})
        ToolStrip1.Location = New Drawing.Point(0, 25)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Drawing.Size(616, 25)
        ToolStrip1.TabIndex = 2
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' btnPrevious
        ' 
        btnPrevious.DisplayStyle = Windows.Forms.ToolStripItemDisplayStyle.Image
        btnPrevious.Image = My.Resources.arrow_up_line
        btnPrevious.ImageTransparentColor = Drawing.Color.Magenta
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Drawing.Size(23, 22)
        btnPrevious.Text = "Parent folder"
        AddHandler btnPrevious.Click, New EventHandler(AddressOf btnPrevious_Click)
        ' 
        ' txtPath
        ' 
        txtPath.Name = "txtPath"
        txtPath.Size = New Drawing.Size(400, 25)
        AddHandler txtPath.KeyDown, New Windows.Forms.KeyEventHandler(AddressOf btnOpenPath_Click)
        ' 
        ' btnOpenPath
        ' 
        btnOpenPath.DisplayStyle = Windows.Forms.ToolStripItemDisplayStyle.Image
        btnOpenPath.Image = My.Resources.arrow_right_line
        btnOpenPath.ImageTransparentColor = Drawing.Color.Magenta
        btnOpenPath.Name = "btnOpenPath"
        btnOpenPath.Size = New Drawing.Size(23, 22)
        btnOpenPath.Text = "Open"
        AddHandler btnOpenPath.Click, New EventHandler(AddressOf btnOpenPath_Click)
        ' 
        ' tsFolder
        ' 
        tsFolder.Items.AddRange(New Windows.Forms.ToolStripItem() {btnRefresh, btnDownload, btnDelete, btnRename, btnUpload, btnNewFolder, btnDecompile})
        tsFolder.Location = New Drawing.Point(0, 0)
        tsFolder.Name = "tsFolder"
        tsFolder.Size = New Drawing.Size(616, 25)
        tsFolder.TabIndex = 0
        tsFolder.Text = "ToolStrip1"
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Image = My.Resources.refresh_line
        btnRefresh.ImageTransparentColor = Drawing.Color.Magenta
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Drawing.Size(66, 22)
        btnRefresh.Text = "Refresh"
        AddHandler btnRefresh.Click, New EventHandler(AddressOf btnOpenPath_Click)
        ' 
        ' btnDownload
        ' 
        btnDownload.Image = My.Resources.save_3_fill
        btnDownload.ImageTransparentColor = Drawing.Color.Magenta
        btnDownload.Name = "btnDownload"
        btnDownload.Size = New Drawing.Size(102, 22)
        btnDownload.Text = "Download File"
        AddHandler btnDownload.Click, New EventHandler(AddressOf btnDownload_Click)
        ' 
        ' btnDelete
        ' 
        btnDelete.Image = My.Resources.delete_bin_5_line
        btnDelete.ImageTransparentColor = Drawing.Color.Magenta
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Drawing.Size(60, 22)
        btnDelete.Text = "Delete"
        AddHandler btnDelete.Click, New EventHandler(AddressOf btnDelete_Click)
        ' 
        ' btnRename
        ' 
        btnRename.Image = My.Resources.file_edit_line
        btnRename.ImageTransparentColor = Drawing.Color.Magenta
        btnRename.Name = "btnRename"
        btnRename.Size = New Drawing.Size(70, 22)
        btnRename.Text = "Rename"
        AddHandler btnRename.Click, New EventHandler(AddressOf btnRename_Click)
        ' 
        ' btnUpload
        ' 
        btnUpload.Image = My.Resources.upload_2_line
        btnUpload.ImageTransparentColor = Drawing.Color.Magenta
        btnUpload.Name = "btnUpload"
        btnUpload.Size = New Drawing.Size(84, 22)
        btnUpload.Text = "Upload file"
        AddHandler btnUpload.Click, New EventHandler(AddressOf btnUpload_Click)
        ' 
        ' btnNewFolder
        ' 
        btnNewFolder.Image = My.Resources.folder_add_line
        btnNewFolder.ImageTransparentColor = Drawing.Color.Magenta
        btnNewFolder.Name = "btnNewFolder"
        btnNewFolder.Size = New Drawing.Size(85, 22)
        btnNewFolder.Text = "New folder"
        AddHandler btnNewFolder.Click, New EventHandler(AddressOf btnNewFolder_Click)
        ' 
        ' btnDecompile
        ' 
        btnDecompile.Image = My.Resources.tools_line
        btnDecompile.ImageTransparentColor = Drawing.Color.Magenta
        btnDecompile.Name = "btnDecompile"
        btnDecompile.Size = New Drawing.Size(84, 22)
        btnDecompile.Text = "Decompile"
        btnDecompile.ToolTipText = "Decompile program (*.urp) or installation (*.installation)"
        AddHandler btnDecompile.Click, New EventHandler(AddressOf btnDecompile_Click)
        ' 
        ' gridFile
        ' 
        gridFile.Dock = Windows.Forms.DockStyle.Fill
        gridFile.HelpVisible = False
        gridFile.Location = New Drawing.Point(0, 0)
        gridFile.Name = "gridFile"
        gridFile.Size = New Drawing.Size(73, 658)
        gridFile.TabIndex = 0
        gridFile.ToolbarVisible = False
        AddHandler gridFile.SelectedObjectsChanged, New EventHandler(AddressOf gridFile_SelectedObjectsChanged)
        ' 
        ' dlgOpen
        ' 
        dlgOpen.Filter = "All files|*.*"
        dlgOpen.Title = "Select file to upload"
        ' 
        ' dlgSave
        ' 
        dlgSave.Filter = "All files|*.*"
        dlgSave.RestoreDirectory = True
        dlgSave.Title = "Download file"
        ' 
        ' SftpControl
        ' 
        AutoScaleDimensions = New Drawing.SizeF(6F, 13F)
        AutoScaleMode = Windows.Forms.AutoScaleMode.Font
        Controls.Add(SplitContainer2)
        Name = "SftpControl"
        Size = New Drawing.Size(701, 662)
        SplitContainer2.Panel1.ResumeLayout(False)
        SplitContainer2.Panel1.PerformLayout()
        SplitContainer2.Panel2.ResumeLayout(False)
        SplitContainer2.ResumeLayout(False)
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        tsFolder.ResumeLayout(False)
        tsFolder.PerformLayout()
        ResumeLayout(False)

    End Sub

#End Region

    Friend SplitContainer2 As Windows.Forms.SplitContainer
    Friend lstFolder As Windows.Forms.ListView
    Friend ToolStrip1 As Windows.Forms.ToolStrip
    Friend btnPrevious As Windows.Forms.ToolStripButton
    Friend txtPath As Windows.Forms.ToolStripTextBox
    Friend btnOpenPath As Windows.Forms.ToolStripButton
    Friend tsFolder As Windows.Forms.ToolStrip
    Friend btnRefresh As Windows.Forms.ToolStripButton
    Friend btnDelete As Windows.Forms.ToolStripButton
    Friend btnRename As Windows.Forms.ToolStripButton
    Friend btnUpload As Windows.Forms.ToolStripButton
    Friend btnDownload As Windows.Forms.ToolStripButton
    Friend gridFile As Windows.Forms.PropertyGrid
    Friend dlgOpen As Windows.Forms.OpenFileDialog
    Friend dlgSave As Windows.Forms.SaveFileDialog
    Friend lstFolderImageList As Windows.Forms.ImageList
    Friend btnDecompile As Windows.Forms.ToolStripButton
    Friend btnNewFolder As Windows.Forms.ToolStripButton
End Class
