using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using UnderAutomation.UniversalRobots;

public partial class XmlRpcControl : UserControl, IUserControl
{
    private UR _ur;

    public XmlRpcControl(UR ur)
    {
        _ur = ur;
        InitializeComponent();

        _ur.XmlRpcServerRequest += _ur_OnXmlRpcServerRequest;
    }

    // Handle a new XML-RPC request
    private void _ur_OnXmlRpcServerRequest(object sender, XmlRpcEventArg request)
    {
        var waitHandle = new AutoResetEvent(false);

        // Open dialog in main thread
        this.Invoke(new Action(() =>
        {
            var dlg = new XmlRpcPopup(request, waitHandle);

            dlg.ShowDialog();
        }));

        // Wait dialog to close
        waitHandle.WaitOne();
    }

    #region IUserControl
    public string Title => "Remote procedure call (XML-RPC)";

    public bool FeatureEnabled => _ur.XmlRpcServerEnabled;

    public void PeriodicUpdate()
    {
        txtLocalIP.Text = _ur.DataStreamingLocalEndPoint?.Address?.ToString();
        txtXmlRpcPort.Text = _ur.XmlRpcServerPort.ToString();
    }
    public void OnClose() { }
    public void OnOpen() { }
    #endregion

    // Open sample in explorer
    private void linkXmlRpcSample_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        var samplePath = Path.Combine(Path.Combine(Path.GetDirectoryName(typeof(MainForm).Assembly.Location), "Samples"), "xml_rpc_sample.urp");
        Process.Start("explorer.exe", $"/select,\"{samplePath}\"");
    }
}