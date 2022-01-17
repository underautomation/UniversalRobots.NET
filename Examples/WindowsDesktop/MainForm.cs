using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using UnderAutomation.UniversalRobots;

public partial class MainForm : Form
{
    // UR instance that handles connection to the robot
    private readonly UR _ur = new UR();

    public static MainForm Instance { get; private set; }

    #region Initialisation
    public MainForm()
    {
        Instance = this;

        // Catch all unhandled exceptions
        AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
        Application.ThreadException += Application_ThreadException;

        // Load configuration file
        Config.Load();

        InitializeComponent();

        // Add nodes in left menu and instanciate associated control 
        AddNode(new ConnectControl(_ur));
        AddNode(new PrimaryInterfaceControl(_ur));
        AddNode(new ProgramControl(_ur));
        AddNode(new RtdeControl(_ur));
        AddNode(new DashboardControl(_ur));
        AddNode(new XmlRpcControl(_ur));
        AddNode(new SocketControl(_ur));
        AddNode(new SftpControl(_ur));
        AddNode(new SshControl(_ur));
        AddNode(new ToolsControl());
        AddNode(new ArchiveControl(_ur));
        AddNode(new LicenseControl());
        AddNode(new LogControl());

        _ur.InternalErrorOccured += _ur_InternalErrorOccured;

        // Select first node at startup
        SelectNode(leftTreeView.Nodes[0]);

    }


    private void AddNode(IUserControl control)
    {
        var node = leftTreeView.Nodes.Add(control.Title);
        node.Tag = control;
    }
    #endregion

    #region Unhandled exception
    private void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
    {
        CatchApplicationException(e.Exception);
    }

    private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
    {
        CatchApplicationException(e.ExceptionObject as Exception);
    }

    private void CatchApplicationException(Exception e)
    {
        if (this.InvokeRequired)
        {
            this.Invoke(new Action(() => CatchApplicationException(e)));
            return;
        }

        MessageBox.Show(e?.Message, "An error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    #endregion

    #region User interaction
    private void leftTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
    {
        SelectNode(e.Node);
    }

    internal T SelectNode<T>() where T : class, IUserControl
    {
        var node = Instance.leftTreeView.Nodes.OfType<TreeNode>().FirstOrDefault(n => n.Tag is T);
        var control = node.Tag as T;
        SelectNode(node);
        return control;
    }

    // Open right control associated to a node
    internal void SelectNode(TreeNode node)
    {
        if (leftTreeView.SelectedNode != node) leftTreeView.SelectedNode = node;

        if (node is null) return;

        mainPanel.SuspendLayout();

        mainPanel.Controls.OfType<IUserControl>().FirstOrDefault()?.OnClose();

        mainPanel.Controls.Clear();

        var control = node.Tag as Control;

        if (control == null)
        {
            panelTitle.Text = "";
            return;
        }

        panelTitle.Text = (node.Tag as IUserControl)?.Title;

        mainPanel.Controls.Add(control);

        control.Dock = DockStyle.Fill;

        mainPanel.ResumeLayout();

        mainPanel.Controls.OfType<IUserControl>().FirstOrDefault()?.OnOpen();
        mainPanel.Controls.OfType<IUserControl>().FirstOrDefault()?.PeriodicUpdate();
    }

    // Open browser to documentation page
    private void lblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        System.Diagnostics.Process.Start("https://underautomation.com/universal-robots/documentation?f");
    }
    #endregion

    // Timer callback to refresh the control on the right and the left menu
    private void tmrPeriodicUpdate_Tick(object sender, EventArgs e)
    {
        try
        {
            // refresh control on the right
            mainPanel.Controls.OfType<IUserControl>().FirstOrDefault()?.PeriodicUpdate();
        }
        catch { }

        lblStatus.Text = _ur.Enabled ? $"Connected to {_ur.IP}" : "Disconnected";

        try
        {
            // Refresh left menu icons and colors
            foreach (TreeNode node in leftTreeView.Nodes)
            {
                try
                {
                    var ctrl = node?.Tag as IUserControl;
                    if (ctrl == null) continue;

                    var enabled = ctrl.FeatureEnabled;

                    var key = enabled ? "ON" : "OFF";

                    if (key != node.ImageKey)
                    {
                        node.ImageKey = key;
                        node.SelectedImageKey = key;
                        node.ForeColor = enabled ? Color.Green : Color.DarkGray;
                    }
                }
                catch { }
            }
        }
        catch { }
    }

    private void titlePictureBox_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        ScreenshotsGenerator.Generate(this);
    }

    public static void Decompile(string fullName)
    {
        var control = Instance.SelectNode<ArchiveControl>();
        control?.Decompile(fullName);
    }

    public static void InvokeOnMainForm(Delegate action)
    {
        if (Instance.InvokeRequired)
        {
            Instance.Invoke(action);
            return;
        }
        action?.DynamicInvoke();
    }

    #region Show errors
    public readonly List<string> Errors = new List<string>();

    private void lblErrors_Click(object sender, EventArgs e)
    {
        SelectNode<LogControl>();
    }

    // Hide red label after some times
    private void tmrError_Tick(object sender, EventArgs e)
    {
        tmrError.Enabled = false;
        lblErrors.Text = "";
        lblErrors.Visible = false;
    }

    // Callback when an error occured in SDK
    private void _ur_InternalErrorOccured(object sender, InternalErrorEventArgs e)
    {
        var error = e.ToString();
        Errors.Add(error);
        ShowError(error);
    }

    // Display error
    private void ShowError(string error)
    {
        if (InvokeRequired)
        {
            Invoke(new Action(() => ShowError(error)));
            return;
        }

        if (string.IsNullOrEmpty(error)) return;

        if (error.Length > 100) error = error.Substring(0, 100) + " ...";

        lblErrors.Text = error;
        lblErrors.Visible = true;

        // Show label some times
        tmrError.Enabled = true;
    }
    #endregion
}