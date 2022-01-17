using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using UnderAutomation.UniversalRobots;
using UnderAutomation.UniversalRobots.XmlRpc;

public partial class XmlRpcControl : UserControl, IUserControl
{
    private UR _ur;

    public XmlRpcControl(UR ur)
    {
        _ur = ur;
        InitializeComponent();

        _ur.XmlRpc.XmlRpcServerRequest += _ur_OnXmlRpcServerRequest;
    }

    // Handle a new XML-RPC request
    private void _ur_OnXmlRpcServerRequest(object sender, XmlRpcEventArg request)
    {
        var waitHandle = new AutoResetEvent(false);

        // Open dialog in main thread
        MainForm.InvokeOnMainForm(new Action(() =>
        {
            var dlg = new XmlRpcPopup(request, waitHandle);

            dlg.ShowDialog(MainForm.Instance);
        }));

        // Wait dialog to close
        waitHandle.WaitOne();
    }

    #region IUserControl
    public string Title => "Remote procedure call (XML-RPC)";

    public bool FeatureEnabled => _ur.XmlRpc.Enabled;

    public void PeriodicUpdate()
    {
        txtLocalIP.Text = _ur.PrimaryInterface.LocalEndPoint?.Address?.ToString() ?? "Enable primary interface to display IP";
        txtXmlRpcPort.Text = _ur.XmlRpc.Port.ToString();
    }
    public void OnClose() { }
    public void OnOpen() { }
    #endregion

    // Open sample in explorer
    private void linkXmlRpcSample_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        var samplePath = Path.Combine(Path.Combine(Path.GetDirectoryName(typeof(MainForm).Assembly.Location), "Samples"), "xml_rpc_sample.urp");
       Explorer.RevealFile(samplePath);
    }
}