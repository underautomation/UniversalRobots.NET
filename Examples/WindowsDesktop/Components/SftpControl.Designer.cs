
    partial class SftpControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SftpControl));
            this.SplitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lstFolder = new System.Windows.Forms.ListView();
            this.lstFolderImageList = new System.Windows.Forms.ImageList(this.components);
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.txtPath = new System.Windows.Forms.ToolStripTextBox();
            this.tsFolder = new System.Windows.Forms.ToolStrip();
            this.gridFile = new System.Windows.Forms.PropertyGrid();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.btnPrevious = new System.Windows.Forms.ToolStripButton();
            this.btnOpenPath = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnDownload = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnRename = new System.Windows.Forms.ToolStripButton();
            this.btnUpload = new System.Windows.Forms.ToolStripButton();
            this.btnNewFolder = new System.Windows.Forms.ToolStripButton();
            this.SplitContainer2.Panel1.SuspendLayout();
            this.SplitContainer2.Panel2.SuspendLayout();
            this.SplitContainer2.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            this.tsFolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplitContainer2
            // 
            this.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer2.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer2.Name = "SplitContainer2";
            // 
            // SplitContainer2.Panel1
            // 
            this.SplitContainer2.Panel1.Controls.Add(this.lstFolder);
            this.SplitContainer2.Panel1.Controls.Add(this.ToolStrip1);
            this.SplitContainer2.Panel1.Controls.Add(this.tsFolder);
            // 
            // SplitContainer2.Panel2
            // 
            this.SplitContainer2.Panel2.Controls.Add(this.gridFile);
            this.SplitContainer2.Size = new System.Drawing.Size(701, 662);
            this.SplitContainer2.SplitterDistance = 486;
            this.SplitContainer2.TabIndex = 2;
            // 
            // lstFolder
            // 
            this.lstFolder.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.lstFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstFolder.HideSelection = false;
            this.lstFolder.LabelEdit = true;
            this.lstFolder.LargeImageList = this.lstFolderImageList;
            this.lstFolder.Location = new System.Drawing.Point(0, 50);
            this.lstFolder.Name = "lstFolder";
            this.lstFolder.Size = new System.Drawing.Size(482, 608);
            this.lstFolder.TabIndex = 1;
            this.lstFolder.UseCompatibleStateImageBehavior = false;
            this.lstFolder.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.lstFolder_AfterLabelEdit);
            this.lstFolder.ItemActivate += new System.EventHandler(this.lstFolder_ItemActivate);
            this.lstFolder.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstFolder_ItemSelectionChanged);
            this.lstFolder.SelectedIndexChanged += new System.EventHandler(this.lstFolder_SelectedIndexChanged);
            // 
            // lstFolderImageList
            // 
            this.lstFolderImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lstFolderImageList.ImageStream")));
            this.lstFolderImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.lstFolderImageList.Images.SetKeyName(0, "folder");
            this.lstFolderImageList.Images.SetKeyName(1, "file");
            this.lstFolderImageList.Images.SetKeyName(2, "symbolicLink");
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPrevious,
            this.txtPath,
            this.btnOpenPath});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 25);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(482, 25);
            this.ToolStrip1.TabIndex = 2;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(400, 25);
            this.txtPath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnOpenPath_Click);
            // 
            // tsFolder
            // 
            this.tsFolder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRefresh,
            this.btnDownload,
            this.btnDelete,
            this.btnRename,
            this.btnUpload,
            this.btnNewFolder});
            this.tsFolder.Location = new System.Drawing.Point(0, 0);
            this.tsFolder.Name = "tsFolder";
            this.tsFolder.Size = new System.Drawing.Size(482, 25);
            this.tsFolder.TabIndex = 0;
            this.tsFolder.Text = "ToolStrip1";
            // 
            // gridFile
            // 
            this.gridFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridFile.HelpVisible = false;
            this.gridFile.Location = new System.Drawing.Point(0, 0);
            this.gridFile.Name = "gridFile";
            this.gridFile.Size = new System.Drawing.Size(207, 658);
            this.gridFile.TabIndex = 0;
            this.gridFile.ToolbarVisible = false;
            // 
            // dlgOpen
            // 
            this.dlgOpen.Filter = "All files|*.*";
            this.dlgOpen.Title = "Select file to upload";
            // 
            // dlgSave
            // 
            this.dlgSave.Filter = "All files|*.*";
            this.dlgSave.Title = "Download file";
            // 
            // btnPrevious
            // 
            this.btnPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrevious.Image = global::UnderAutomation.UniversalRobots.Sample.WindowsDesktop.Properties.Resources.arrow_up_line;
            this.btnPrevious.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(23, 22);
            this.btnPrevious.Text = "Parent folder";
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnOpenPath
            // 
            this.btnOpenPath.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpenPath.Image = global::UnderAutomation.UniversalRobots.Sample.WindowsDesktop.Properties.Resources.arrow_right_line;
            this.btnOpenPath.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenPath.Name = "btnOpenPath";
            this.btnOpenPath.Size = new System.Drawing.Size(23, 22);
            this.btnOpenPath.Text = "Open";
            this.btnOpenPath.Click += new System.EventHandler(this.btnOpenPath_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefresh.Image = global::UnderAutomation.UniversalRobots.Sample.WindowsDesktop.Properties.Resources.refresh_line;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(23, 22);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnOpenPath_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDownload.Image = global::UnderAutomation.UniversalRobots.Sample.WindowsDesktop.Properties.Resources.save_3_fill;
            this.btnDownload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(23, 22);
            this.btnDownload.Text = "Download File";
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelete.Image = global::UnderAutomation.UniversalRobots.Sample.WindowsDesktop.Properties.Resources.delete_bin_5_line;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(23, 22);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRename
            // 
            this.btnRename.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRename.Image = global::UnderAutomation.UniversalRobots.Sample.WindowsDesktop.Properties.Resources.file_edit_line;
            this.btnRename.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(23, 22);
            this.btnRename.Text = "Rename";
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUpload.Image = global::UnderAutomation.UniversalRobots.Sample.WindowsDesktop.Properties.Resources.upload_2_line;
            this.btnUpload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(23, 22);
            this.btnUpload.Text = "Upload file";
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnNewFolder
            // 
            this.btnNewFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNewFolder.Image = global::UnderAutomation.UniversalRobots.Sample.WindowsDesktop.Properties.Resources.folder_add_line;
            this.btnNewFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewFolder.Name = "btnNewFolder";
            this.btnNewFolder.Size = new System.Drawing.Size(23, 22);
            this.btnNewFolder.Text = "New folder";
            this.btnNewFolder.Click += new System.EventHandler(this.btnNewFolder_Click);
            // 
            // SftpControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SplitContainer2);
            this.Name = "SftpControl";
            this.Size = new System.Drawing.Size(701, 662);
            this.SplitContainer2.Panel1.ResumeLayout(false);
            this.SplitContainer2.Panel1.PerformLayout();
            this.SplitContainer2.Panel2.ResumeLayout(false);
            this.SplitContainer2.ResumeLayout(false);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.tsFolder.ResumeLayout(false);
            this.tsFolder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.SplitContainer SplitContainer2;
        internal System.Windows.Forms.ListView lstFolder;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton btnPrevious;
        internal System.Windows.Forms.ToolStripTextBox txtPath;
        internal System.Windows.Forms.ToolStripButton btnOpenPath;
        internal System.Windows.Forms.ToolStrip tsFolder;
        internal System.Windows.Forms.ToolStripButton btnRefresh;
        internal System.Windows.Forms.ToolStripButton btnDelete;
        internal System.Windows.Forms.ToolStripButton btnRename;
        internal System.Windows.Forms.ToolStripButton btnUpload;
        internal System.Windows.Forms.ToolStripButton btnDownload;
        internal System.Windows.Forms.PropertyGrid gridFile;
    internal System.Windows.Forms.OpenFileDialog dlgOpen;
    internal System.Windows.Forms.SaveFileDialog dlgSave;
    internal System.Windows.Forms.ImageList lstFolderImageList;
    internal System.Windows.Forms.ToolStripButton btnNewFolder;
}
