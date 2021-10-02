using System;
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
    }

    #region IUserControl
    public bool FeatureEnabled => _ur.DataStreamingEnabled || _ur.SftpEnabled || _ur.XmlRpcServerEnabled || _ur.SshEnabled;

    public string Title => "Connexion";

    public void OnClose() { }

    public void OnOpen() { }

    public void PeriodicUpdate()
    {
        btnDisconnect.Enabled = FeatureEnabled;
        btnConnect.Text = btnDisconnect.Enabled ? "Reconnect" : "Connect";
    }
    #endregion

    private void btnConnect_Click(object sender, EventArgs e)
    {
        if (e is KeyEventArgs && ((KeyEventArgs)e).KeyCode != Keys.Enter) return;

        // Connect to the robot
        _ur.Connect(txtIP.Text
            , enableDataStreaming: chkDataStreaming.Checked
            , enableXmlRpcServer: chkXmlRpc.Checked
            , xmlRpcServerPort: (int)udXmlRpcPort.Value
            , enableSSH: chkSsh.Checked
            , enableSFTP: chkSftp.Checked
            , login: txtLogin.Text
            , password: txtPassword.Text
            );

        // Store information
        Config.Current.IP = txtIP.Text;
        Config.Current.EnableDataStreaming = chkDataStreaming.Checked;
        Config.Current.EnableXmlRpcServer = chkXmlRpc.Checked;
        Config.Current.XmlRpcServerPort = (int)udXmlRpcPort.Value;
        Config.Current.EnableSSH = chkSsh.Checked;
        Config.Current.EnableSFTP = chkSftp.Checked;
        Config.Current.Login = txtLogin.Text;
        Config.Current.Password = txtPassword.Text;
        Config.Save();
    }

    private void btnDisconnect_Click(object sender, EventArgs e)
    {
        // Disconnect all services
        _ur.Disconnect();
    }
}
