using System;
using System.Windows.Forms;
using UnderAutomation.UniversalRobots;

public partial class ToolsControl : UserControl, IUserControl
{
    public ToolsControl()
    {
        InitializeComponent();
    }

    #region IUserControl
    public string Title => "Convert position types";

    public bool FeatureEnabled => true;

    public void PeriodicUpdate() { }
    public void OnClose() { }
    public void OnOpen() { }
    #endregion

    private void ValueChanged(object sender, EventArgs e)
    {
        var inPose = new Pose(0, 0, 0, (double)udRx.Value, (double)udRy.Value, (double)udRz.Value);

        Pose outPose; ;

        if (radioRPYToRotationVector.Checked)
        {
            // Convert from RPY to Rotation vector
            outPose = inPose.FromRPYToRotationVector();

            txtIn.Text = "RPY";
            txtOut.Text = "Rotation Vector";
        }
        else
        {
            // Convert from Rotation vector to RPY
            outPose = inPose.FromRotationVectorToRPY();

            txtIn.Text = "Rotation Vector";
            txtOut.Text = "RPY";
        }

        txtRx.Text = $"{outPose.Rx} rad";
        txtRy.Text = $"{outPose.Ry} rad";
        txtRz.Text = $"{outPose.Rz} rad";
    }
}