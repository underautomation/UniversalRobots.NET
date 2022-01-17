using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using UnderAutomation.UniversalRobots;
using UnderAutomation.UniversalRobots.Ssh.Tools;
using UnderAutomation.UniversalRobots.Ssh.Tools.Common;

public partial class SshControl : UserControl, IUserControl
{
    private UR _ur;

    public SshControl(UR ur)
    {
        _ur = ur;
        InitializeComponent();
    }

    #region IUserControl
    public string Title => "Linux commands (SSH)";

    public bool FeatureEnabled => _ur.Ssh.Connected;

    public void PeriodicUpdate()
    {
        txtShellCommand.Enabled = FeatureEnabled;
        btnSendShell.Enabled = FeatureEnabled;
        txtSSHCommand.Enabled = FeatureEnabled;
        btnSSHSend.Enabled = FeatureEnabled;
    }

    public void OnClose()
    {
        // Close shell when control is not displayed
        _shell?.Close();
        _shell = null;
    }

    public void OnOpen()
    {
        if (!_ur.Ssh.Connected) return;

        // Create shell when control is displayed
        _shell = _ur.Ssh.CreateShellStream("UnderAutomation", 40, 100, 40, 100, 1000);
    }
    #endregion

    // Send SSH command to the robot outside a shell context
    private void btnSSHSend_Click(object sender, EventArgs e)
    {
        if (e is KeyEventArgs && ((KeyEventArgs)e).KeyCode != Keys.Enter) return;
        if (string.IsNullOrEmpty(txtSSHCommand.Text)) return;
        if (!_ur.Ssh.Connected) return;

        var command = _ur.Ssh.CreateCommand(txtSSHCommand.Text);

        command.Execute();

        txtCommandResult.Text = $"> {command.CommandText} (Exit status : {command.ExitStatus})\r\n{command.Result}\r\n{command.Error}";
    }

    #region Shell
    private ShellStream __shell;

    private ShellStream _shell
    {
        get
        {
            return __shell;
        }
        set
        {
            // set new shell and handlers
            if (__shell is object)
            {
                __shell.DataReceived -= _shell_DataReceived;
                __shell.ErrorOccurred -= _shell_ErrorOccurred;
            }
            __shell = value;

            if (__shell is object)
            {
                __shell.DataReceived += _shell_DataReceived;
                __shell.ErrorOccurred += _shell_ErrorOccurred;
            }
        }
    }

    // Send new command to shell
    private void btnSendShell_Click(object sender, EventArgs e)
    {
        if (e is KeyEventArgs && ((KeyEventArgs)e).KeyCode != Keys.Enter) return;
        if (string.IsNullOrEmpty(txtShellCommand.Text)) return;

        _shell?.WriteLine(txtShellCommand.Text);

        txtShellCommand.Text = "";
    }

    // Display received data from shell
    private void _shell_DataReceived(object sender, ShellDataEventArgs e)
    {
        if (txtShellHistory.InvokeRequired)
            txtShellHistory.Invoke(new Action(() => shell_DataReceived(e)));
        else
            shell_DataReceived(e);
    }
    private void shell_DataReceived(ShellDataEventArgs e)
    {
        var rawData = Encoding.UTF8.GetString(e.Data);

        // remove ANSI data from answer (for example color infos)
        var data = Regex.Replace(rawData, @"(\x9B|\x1B\[)[0-?]*[ -\/]*[@-~]", "");

        txtShellHistory.AppendText(data);

        txtShellHistory.ScrollToCaret();
    }

    // Display SSH errors
    private void _shell_ErrorOccurred(object sender, ExceptionEventArgs e)
    {
        if (txtShellHistory.InvokeRequired)
            txtShellHistory.Invoke(new Action(() => shell_ErrorOccurred(e.Exception.Message)));
        else
            shell_ErrorOccurred(e.Exception.Message);
    }
    private void shell_ErrorOccurred(string message)
    {
        txtShellHistory.AppendText("\r\n\r\n --- ERROR ---\r\n" + message + "\r\n\r\n");
    }
    #endregion
}
