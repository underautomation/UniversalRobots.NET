using System;
using System.Threading;
using System.Windows.Forms;
using UnderAutomation.UniversalRobots.Common;
using UnderAutomation.UniversalRobots.XmlRpc;

// Popup opened when a XML-RPC request is received from the robot
public partial class XmlRpcPopup : Form
{
    private XmlRpcEventArg _request;
    private AutoResetEvent _waitHandle;

    public XmlRpcPopup(XmlRpcEventArg request, AutoResetEvent waitHandle)
    {
        _request = request;
        _waitHandle = waitHandle;

        InitializeComponent();

        txtMethodName.Text = request.MethodName;

        txtIp.Text = request.EndPoint?.Address?.ToString();

        // specify the number of argument
        txtArgument.Text = txtArgument.Text.Replace("%", request.Arguments.Length.ToString());

        // fill the argument list
        foreach (var arg in request.Arguments)
            lstArgs.Items.Add(new ListViewItem(new[] { arg.Type.ToString(), arg.ToString() }));
    }

    #region Buttons click
    private void btnInteger_Click(object sender, EventArgs e)
    {
        _request.Answer = -12;
    }

    private void btnDouble_Click(object sender, EventArgs e)
    {
        _request.Answer = 2.5;
    }

    private void btnTrue_Click(object sender, EventArgs e)
    {
        _request.Answer = true;
    }

    private void btnFalse_Click(object sender, EventArgs e)
    {
        _request.Answer = false;
    }

    private void btnPose_Click(object sender, EventArgs e)
    {
        _request.Answer = new Pose(100, -100, 120, 0.2, 0, -0.1);
    }

    private void BtnString_Click(object sender, EventArgs e)
    {
        _request.Answer = "Hi Robot !";
    }

    private void btnArrayPoses_Click(object sender, EventArgs e)
    {
        _request.Answer = new[]
        {
            new Pose(0, 1, 0, 0, 0, 0),
            new Pose(0, 0, 1, 0, 0, 0)
        };
    }

    private void btnArrayNumbers_Click(object sender, EventArgs e)
    {
        _request.Answer = new double[] { -4, 2.3, 100 };
    }

    private void btnNothing_Click(object sender, EventArgs e)
    {
        _request.Answer = null;
    }
    #endregion

    // all buttons have ActionResult to OK which closes the form.
    // Set _waitHandle for the XML-RPC thread to continue
    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        base.OnFormClosing(e);

        _waitHandle.Set();
    }
}
