using System;
using System.Drawing;
using System.Windows.Forms;
using UnderAutomation.UniversalRobots;

public partial class ConnectControl : UserControl, IUserControl
{
    UR _ur;

    public ConnectControl(UR ur)
    {
        _ur = ur;
        InitializeComponent();

        // Use stored information or set to default
        txtIP.Text = Config.Current.IP ?? "192.168.0.1";
        chkDataStreaming.Checked = Config.Current.EnableDataStreaming ?? true;
        chkXmlRpc.Checked = Config.Current.EnableXmlRpcServer ?? true;
        udXmlRpcPort.Value = Config.Current.XmlRpcServerPort ?? UR.DEFAULT_XML_RPC_SERVER_PORT;
        chkSsh.Checked = Config.Current.EnableSSH ?? true;
        chkSftp.Checked = Config.Current.EnableSFTP ?? true;
        txtLogin.Text = Config.Current.Login ?? UR.DEFAULT_USERNAME;
        txtPassword.Text = Config.Current.Password ?? UR.DEFAULT_PASSWORD;
        chkSocket.Checked = Config.Current.EnableSocketServer ?? false;
        udSocketPort.Value = Config.Current.SocketServerPort ?? UR.DEFAULT_SOCKET_PORT;
    }

    #region IUserControl
    public bool FeatureEnabled => _ur.DataStreamingEnabled || _ur.SftpEnabled || _ur.XmlRpcServerEnabled || _ur.SshEnabled;

    public string Title => "Connection";

    public void OnClose() { }

    public void OnOpen() { }

    public void PeriodicUpdate()
    {
        var connected = FeatureEnabled;
        btnDisconnect.Enabled = connected;
        btnConnect.Text = connected ? "Reconnect" : "Connect";
        lblConnected.Text = connected ? "Connected" : "Disconnected";
        lblConnected.ForeColor = connected ? Color.Green : Color.Red;
    }
    #endregion

    private void btnConnect_Click(object sender, EventArgs e)
    {
        if (e is KeyEventArgs && ((KeyEventArgs)e).KeyCode != Keys.Enter) return;

        var parameters = new ConnectParameters();
        parameters.EnableDataStreaming = chkDataStreaming.Checked;
        parameters.EnableXmlRpcServer = chkXmlRpc.Checked;
        parameters.XmlRpcServerPort = (int)udXmlRpcPort.Value;
        parameters.EnableSSH = chkSsh.Checked;
        parameters.EnableSFTP = chkSftp.Checked;
        parameters.Login = txtLogin.Text;
        parameters.Password = txtPassword.Text;
        parameters.EnableSocket = chkSocket.Checked;
        parameters.SocketPort = (int)udSocketPort.Value;

        // Connect to the robot
        _ur.Connect(txtIP.Text, parameters);

        // Store information
        Config.Current.IP = txtIP.Text;
        Config.Current.EnableDataStreaming = chkDataStreaming.Checked;
        Config.Current.EnableXmlRpcServer = chkXmlRpc.Checked;
        Config.Current.XmlRpcServerPort = (int)udXmlRpcPort.Value;
        Config.Current.EnableSSH = chkSsh.Checked;
        Config.Current.EnableSFTP = chkSftp.Checked;
        Config.Current.Login = txtLogin.Text;
        Config.Current.Password = txtPassword.Text;
        Config.Current.EnableSocketServer = chkSocket.Checked;
        Config.Current.SocketServerPort = (int)udSocketPort.Value;
        Config.Save();
    }

    private void btnDisconnect_Click(object sender, EventArgs e)
    {
        // Disconnect all services
        _ur.Disconnect();
    }
}
