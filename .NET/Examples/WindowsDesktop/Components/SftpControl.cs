using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using UnderAutomation.UniversalRobots;
using UnderAutomation.UniversalRobots.Ssh.Tools.Common;
using UnderAutomation.UniversalRobots.Ssh.Tools.Sftp;
using UnderAutomation.UniversalRobots.Files;

public partial class SftpControl : UserControl, IUserControl
{
    private UR _ur;

    public SftpControl(UR ur)
    {
        _ur = ur;
        InitializeComponent();
    }

    #region IUserControl
    public string Title => "File handling (SFTP)";

    public bool FeatureEnabled => _ur.Sftp.Connected;

    public void PeriodicUpdate()
    {
        this.Enabled = FeatureEnabled;
    }


    public void OnClose()
    {
        Config.Current.SftpPath = txtPath.Text;
        Config.Save();

        lstFolder.Items.Clear();
        gridFile.SelectedObject = null;
    }

    public void OnOpen()
    {
        try
        {
            InitializeFtp();
        }
        catch(SftpPathNotFoundException)
        {
            Config.Current.SftpPath = "/";
            InitializeFtp();
        }
    }
    #endregion

    public void InitializeFtp()
    {
        FillList(Config.Current.SftpPath ?? "/");
    }

    // Display directory content in the list view
    private void FillList(string path)
    {
        gridFile.SelectedObject = null;
        lstFolder.Items.Clear();

        if (!_ur.Sftp.Connected) return;

        path = path.Replace(@"\", "/");
        if (!path.EndsWith("/"))
            path = path + "/";

        txtPath.Text = path;

        var files = _ur.Sftp.ListDirectory(path);

        foreach (var file in files)
        {
            // do not display special folders
            if (file.Name == "." || file.Name == "..") continue;

            var itm = lstFolder.Items.Add(file.Name);

            itm.Tag = file;

            if (file.IsDirectory)
                itm.ImageKey = "folder";
            else if (file.IsSymbolicLink)
                itm.ImageKey = "symbolicLink";
            else
                itm.ImageKey = "file";
        }
    }

    // Open directory after double click
    private void lstFolder_ItemActivate(object sender, EventArgs e)
    {
        var file = lstFolder.SelectedItems?.OfType<ListViewItem>()?.FirstOrDefault()?.Tag as UnderAutomation.UniversalRobots.Ssh.Tools.Sftp.SftpFile;

        if (file == null || (!file.IsDirectory && !file.IsSymbolicLink)) return;

        if (file.IsSymbolicLink && file.IsRegularFile)
        {
            try
            {
                var value = _ur.Sftp.ReadAllText(file.FullName);

                MessageBox.Show(value, file.FullName);
            }
            catch
            {
                FillList(file.FullName);
            }
        }
        else
        {
            FillList(file.FullName);
        }
    }

    // Show select item data inside right grid
    private void lstFolder_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
    {
        gridFile.SelectedObject = e.Item?.Tag;
    }
    private void lstFolder_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lstFolder.SelectedItems.Count == 0) gridFile.SelectedObject = null;
    }

    // Navigate to parent directory
    private void btnPrevious_Click(object sender, EventArgs e)
    {
        var p = GetPath().TrimEnd('/');
        if (p == "") return;
        FillList(Path.GetDirectoryName(p));
    }

    // Refresh current directory
    private void btnOpenPath_Click(object sender, EventArgs e)
    {
        if (e is KeyEventArgs && ((KeyEventArgs)e).KeyCode != Keys.Enter) return;
        ReloadList();
    }
    private void ReloadList()
    {
        FillList(GetPath());
        gridFile.SelectedObject = null;
    }

    // Delete an element
    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Do you really want to delete selected item ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

        if (!_ur.Sftp.Connected) return;

        foreach (var itm in lstFolder.SelectedItems.OfType<ListViewItem>())
        {
            var file = itm.Tag as SftpFile;

            if (file == null) return;

            _ur.Sftp.Delete(file.FullName);
            Thread.Sleep(500);
            ReloadList();
        }
    }

    // Edit item to rename element
    private void btnRename_Click(object sender, EventArgs e)
    {
        lstFolder.SelectedItems?.OfType<ListViewItem>()?.FirstOrDefault()?.BeginEdit();
    }

    // Send file to the robot and refresh list
    private void btnUpload_Click(object sender, EventArgs e)
    {
        if (!_ur.Sftp.Connected) return;

        if (dlgOpen.ShowDialog() != DialogResult.OK) return;

        using (var selectedFile = File.OpenRead(dlgOpen.FileName))
        {
            _ur.Sftp.UploadFile(selectedFile, GetPath() + Path.GetFileName(dlgOpen.FileName).Replace(@"\", "/"));
        }

        Thread.Sleep(500);
        ReloadList();
        SelectFile(Path.GetFileName(dlgOpen.FileName));
    }

    // Get current directory path
    private string GetPath()
    {
        if (!txtPath.Text.EndsWith("/")) return txtPath.Text + "/";
        return txtPath.Text;
    }

    // Select a file in list view by its name
    private void SelectFile(string name)
    {
        var itm = lstFolder.Items.OfType<ListViewItem>().FirstOrDefault(x => string.Equals(x.Text, name, StringComparison.InvariantCultureIgnoreCase));
        if (itm != null) itm.Selected = true;
    }

    // Save remote file to local computer
    private void btnDownload_Click(object sender, EventArgs e)
    {
        if (!_ur.Sftp.Connected) return;

        var file = lstFolder.SelectedItems.OfType<ListViewItem>()?.FirstOrDefault()?.Tag as UnderAutomation.UniversalRobots.Ssh.Tools.Sftp.SftpFile;

        if (file == null) return;

        dlgSave.FileName = Path.GetFileName(file.FullName).Replace(@"\", "/");

        if (dlgSave.ShowDialog() != DialogResult.OK) return;

        using (var selectedFile = File.Open(dlgSave.FileName, FileMode.OpenOrCreate))
        {
            _ur.Sftp.DownloadFile(file.FullName, selectedFile);
        }

        Explorer.RevealFile(dlgSave.FileName);
    }

    // Perform renaming or directory creation
    private void lstFolder_AfterLabelEdit(object sender, LabelEditEventArgs e)
    {
        if (!_ur.Sftp.Connected) return;

        try
        {
            if (lstFolder.Items[e.Item].Tag is null)
            {
                // if it is a directory creation
                _ur.Sftp.CreateDirectory(txtPath.Text + e.Label);
            }
            else
            {
                var file = lstFolder.Items[e.Item].Tag as UnderAutomation.UniversalRobots.Ssh.Tools.Sftp.SftpFile;

                if ((e.Label == null) || (file == null) || (file.Name == e.Label)) return;

                _ur.Sftp.RenameFile(file.FullName, Path.GetDirectoryName(file.FullName).Replace(@"\", "/") + "/" + e.Label);
            }

        }
        finally
        {
            e.CancelEdit = true;
            Thread.Sleep(500);
            ReloadList();
            SelectFile(e.Label);
        }
    }


    private void btnNewFolder_Click(object sender, EventArgs e)
    {
        if (!_ur.Sftp.Connected) return;
        lstFolder.Items.Add("new directory", "folder").BeginEdit();
    }

    private void btnDecompile_Click(object sender, EventArgs e)
    {
        var file = lstFolder.SelectedItems?.OfType<ListViewItem>()?.FirstOrDefault()?.Tag as SftpFile;

        if (file is null) return;

        MainForm.Decompile(file.FullName);
    }

    private void gridFile_SelectedObjectsChanged(object sender, EventArgs e)
    {
        var selected = gridFile.SelectedObject as SftpFile;

        btnDownload.Enabled = selected is object && selected.IsRegularFile;
        btnRename.Enabled = selected is object;
        btnDelete.Enabled = selected is object;
        btnDecompile.Enabled = selected is object && selected.IsRegularFile && (selected.Name.EndsWith(URProgram.EXTENSION, StringComparison.InvariantCultureIgnoreCase) || selected.Name.EndsWith(URInstallation.EXTENSION, StringComparison.InvariantCultureIgnoreCase));
    }

}
