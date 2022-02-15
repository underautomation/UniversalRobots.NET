using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using UnderAutomation.UniversalRobots;
using UnderAutomation.UniversalRobots.SocketCommunication;

public partial class SocketControl : UserControl, IUserControl
{
    private UR _ur;

    public SocketControl(UR ur)
    {
        _ur = ur;
        InitializeComponent();

        _ur.SocketCommunication.SocketRequest += _ur_SocketRequest;
        _ur.SocketCommunication.SocketGetVar += _ur_SocketGetVar;
        _ur.SocketCommunication.SocketClientConnection += _ur_SocketClientConnection;
        _ur.SocketCommunication.SocketClientDisconnection += _ur_SocketClientDisconnection;
    }

    private void _ur_SocketClientDisconnection(object sender, SocketClientDisconnectionEventArgs request)
    {
        Log($"Robot disconnection : {request.Client?.EndPoint}");
        UpdateList();
    }

    private void _ur_SocketClientConnection(object sender, SocketClientConnectionEventArgs request)
    {
        Log($"Robot connection : {request.Client?.EndPoint}");
        UpdateList();
    }

    private void _ur_SocketGetVar(object sender, SocketGetVarEventArgs request)
    {
        if (request.Name == "var_a")
        {
            request.Value = -10;
        }
        else
        {
            request.Value = 12;
        }
        Log($"Robot {request.Client.EndPoint} calls socket_get_var() : {request.Name}. Answer : {request.Value}");
    }

    private void _ur_SocketRequest(object sender, SocketRequestEventArgs request)
    {
        Log($"Robot {request.Client.EndPoint} socket message : {request.Message}");
    }

    private List<String> LogBuffer = new List<string>();
    private readonly object _lck = new object();
    private void Log(string message)
    {
        if (LogBuffer is null)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => Log(message)));
            }
            else
            {
                AppendText(message);
            }
        }
        else
        {
            lock (_lck)
            {
                LogBuffer.Add(message);
            }
        }
    }

    private void AppendText(string message)
    {
        lock (_lck)
        {
            txtLog.AppendText(message);
            txtLog.AppendText("\r\n\r\n");
            txtLog.ScrollToCaret();
        }
    }

    #region IUserControl
    public string Title => "Socket communication";

    public bool FeatureEnabled => _ur.SocketCommunication.Enabled;

    public void PeriodicUpdate()
    {
        txtLocalIP.Text = _ur.PrimaryInterface.LocalEndPoint?.Address?.ToString() ?? "Enable primary interface to display IP";
        txtPort.Text = _ur.SocketCommunication.Port.ToString();
    }

    public void OnClose()
    {
        lock (_lck)
        {
            LogBuffer = new List<string>();
        }
    }

    public void OnOpen()
    {
        lock (_lck)
        {
            if (LogBuffer is object)
            {
                foreach (var message in LogBuffer)
                {
                    AppendText(message);
                }
            }
            LogBuffer = null;
        }

        btnSend.Enabled = _ur.SocketCommunication.Enabled;

        UpdateList();
    }
    #endregion

    private SocketClient GetSelectedClient()
    {
        return lstClients.SelectedItems?.OfType<ListViewItem>()?.FirstOrDefault()?.Tag as SocketClient;
    }

    private void UpdateList()
    {
        if (this.InvokeRequired)
        {
            this.Invoke(new Action(UpdateList));
            return;
        }

        var selected = GetSelectedClient();

        lstClients.Items.Clear();
        foreach (var client in _ur.SocketCommunication.ConnectedClients)
        {
            var itm = lstClients.Items.Add(new ListViewItem(new[] {
                _ur.SocketCommunication.Port.ToString(),
                client.EndPoint?.Address?.ToString() ?? "",
                client.EndPoint?.Port.ToString() ?? "",
            }));
            itm.Tag = client;

            itm.Selected = selected == client;
        }

        AfterSelection();
    }

    private void linkSample_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        var samplePath = Path.Combine(Path.Combine(Path.GetDirectoryName(typeof(MainForm).Assembly.Location), "Samples"), "socket_sample.urp");
        Explorer.RevealFile(samplePath);
    }

    private void lstClients_SelectedIndexChanged(object sender, EventArgs e)
    {
        AfterSelection();
    }

    private void AfterSelection()
    {
        var selected = GetSelectedClient();

        if(selected is null)
        {
            btnSend.Text = "Send to all clients";
        }
        else
        {
            btnSend.Text = $"Send to {selected.EndPoint}";
        }
    }

    private void btnSend_Click(object sender, EventArgs e)
    {
        if (e is KeyEventArgs && ((KeyEventArgs)e).KeyCode != Keys.Enter) return;
        if (!FeatureEnabled) return;

        var selected = GetSelectedClient();

        if (selected is null)
        {
            _ur.SocketCommunication.SocketWrite(txtMessage.Text);
        }
        else
        {
            selected.SocketWrite(txtMessage.Text);
        }

        Log($"{btnSend.Text} : {txtMessage.Text}");
    }

}
