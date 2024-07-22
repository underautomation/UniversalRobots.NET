using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using UnderAutomation.UniversalRobots;
using UnderAutomation.UniversalRobots.Rtde;

public partial class ConnectControl : UserControl, IUserControl
{
    UR _ur;

    private RtdeOutputSetup _rtdeOutputSetup;
    private RtdeInputSetup _rtdeInputSetup;


    public ConnectControl(UR ur)
    {
        _ur = ur;
        InitializeComponent();

        var parameters = Config.Current.ConnectParameters ?? new ConnectParameters();

        // Use stored information or set to default
        txtIP.Text = parameters.IP ?? "192.168.0.1";
        chkPrimaryInterface.Checked = parameters.PrimaryInterface.Enable;
        chkDashboard.Checked = parameters.Dashboard.Enable;
        chkInterpreterMode.Checked = parameters.InterpreterMode.Enable;
        chkXmlRpc.Checked = parameters.XmlRpc.Enable;
        udXmlRpcPort.Value = parameters.XmlRpc.Port;
        chkSsh.Checked = parameters.Ssh.EnableSsh;
        chkSftp.Checked = parameters.Ssh.EnableSftp;
        txtUsername.Text = parameters.Ssh.Username;
        txtPassword.Text = parameters.Ssh.Password;
        chkSocket.Checked = parameters.SocketCommunication.Enable;
        udSocketPort.Value = parameters.SocketCommunication.Port;
        chkRTDE.Checked = parameters.Rtde.Enable;
        udFrequency.Value = (decimal)parameters.Rtde.Frequency;
        radioV1.Checked = parameters.Rtde.Version == RtdeVersions.V1;
        radioV2.Checked = parameters.Rtde.Version == RtdeVersions.V2;

        _rtdeOutputSetup = parameters.Rtde.OutputSetup;
        _rtdeInputSetup = parameters.Rtde.InputSetup;

        UpdateRtdeIndicators();

        txtLicensee.Text = Config.Current.Licensee;
        txtKey.Text = Config.Current.Key;
    }

    #region IUserControl
    public bool FeatureEnabled => _ur.Enabled;

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
        parameters.IP = txtIP.Text;
        parameters.PrimaryInterface.Enable = chkPrimaryInterface.Checked;
        parameters.Dashboard.Enable = chkDashboard.Checked;
        parameters.InterpreterMode.Enable = chkInterpreterMode.Checked;
        parameters.XmlRpc.Enable = chkXmlRpc.Checked;
        parameters.XmlRpc.Port = (int)udXmlRpcPort.Value;
        parameters.Ssh.EnableSsh = chkSsh.Checked;
        parameters.Ssh.EnableSftp = chkSftp.Checked;
        parameters.Ssh.Username = txtUsername.Text;
        parameters.Ssh.Password = txtPassword.Text;
        parameters.SocketCommunication.Enable = chkSocket.Checked;
        parameters.SocketCommunication.Port = (int)udSocketPort.Value;
        parameters.Rtde.Enable = chkRTDE.Checked;
        parameters.Rtde.OutputSetup = _rtdeOutputSetup;
        parameters.Rtde.Frequency = (double)udFrequency.Value;
        parameters.Rtde.InputSetup = _rtdeInputSetup;
        parameters.Rtde.Version = radioV1.Checked ? RtdeVersions.V1 : RtdeVersions.V2;

        // Store information
        Config.Current.ConnectParameters = parameters;
        Config.Current.Licensee = txtLicensee.Text;
        Config.Current.Key = txtKey.Text;
        Config.Save();

        UR.RegisterLicense(txtLicensee.Text, txtKey.Text);

        // Connect to the robot
        _ur.Connect(parameters);

    }

    private void btnDisconnect_Click(object sender, EventArgs e)
    {
        // Disconnect all services
        _ur.Disconnect();
    }

    #region RTDE
    private void btnRtdeOutputs_Click(object sender, EventArgs e)
    {
        var popup = new ConnectRtdePopup< RtdeOutputSetupItem, RtdeOutputData, RtdeOutputSetup>(
            "Select output RTDE data to read",
            _rtdeOutputSetup,
            RtdeClient.AllOutputsDescription.Items.OfType<RtdeDataDescription<RtdeOutputData>>()
        );
        if (popup.ShowDialog() == DialogResult.OK)
        {
            _rtdeOutputSetup = popup.Setup;
            UpdateRtdeIndicators();
        }
    }

    private void btnRtdeInputs_Click(object sender, EventArgs e)
    {
        var popup = new ConnectRtdePopup<RtdeInputSetupItem, RtdeInputData, RtdeInputSetup>(
            "Select input RTDE data to write",
            _rtdeInputSetup, 
            RtdeClient.AllInputsDescription.Items.OfType<RtdeDataDescription<RtdeInputData>>()
        );
        if (popup.ShowDialog() == DialogResult.OK)
        {
            _rtdeInputSetup = popup.Setup;
            UpdateRtdeIndicators();
        }
    }


    private void lnkMaxFrequency_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        udFrequency.Value = 0;
    }


    private void UpdateRtdeIndicators()
    {
        lblRtdeOutputs.Text = $"{(_rtdeOutputSetup is null ? 0 : _rtdeOutputSetup.Count)} data selected";
        lblRtdeInputs.Text = $"{(_rtdeOutputSetup is null ? 0 : _rtdeInputSetup.Count)} data selected";
    }
    #endregion

    private void radioV1_CheckedChanged(object sender, EventArgs e)
    {
        var enabled = !radioV1.Checked;
        udFrequency.Enabled = enabled;
        lnkMaxFrequency.Enabled = enabled;
        lblHz.Enabled = enabled;
        lblFrequency.Enabled = enabled;
    }

    private void btnConnect_Click(object sender, KeyEventArgs e)
    {

    }

    private void linkLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        Process.Start("https://underautomation.com/license");
    }
}
