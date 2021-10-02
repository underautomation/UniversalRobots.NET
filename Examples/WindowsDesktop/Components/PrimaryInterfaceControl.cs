using System.Windows.Forms;
using UnderAutomation.UniversalRobots;

public partial class PrimaryInterfaceControl : UserControl, IUserControl
{
    private UR _ur;

    public PrimaryInterfaceControl(UR ur)
    {
        _ur = ur;
        InitializeComponent();
    }

    #region IUserControl
    public string Title => "Data streaming and script (Primary Interface)";

    public bool FeatureEnabled => _ur.DataStreamingEnabled;

    public void PeriodicUpdate()
    {
        btnSendScript.Enabled = FeatureEnabled;
        txtScript.Enabled = FeatureEnabled;

        // Update grid with last received values
        gridAdditionnalInfo.SetSelectedObject(_ur.AdditionalInfo);
        gridCartesian.SetSelectedObject(_ur.CartesianInfo);
        gridConfiguration.SetSelectedObject(_ur.ConfigurationData);
        gridForce.SetSelectedObject(_ur.ForceModeData);
        gridJointData.SetSelectedObject(_ur.JointData);
        gridMasterboard.SetSelectedObject(_ur.MasterboardData);
        gridRobotMode.SetSelectedObject(_ur.RobotModeData);
        GridToolCommunication.SetSelectedObject(_ur.ToolCommunicationInfo);
        gridTool.SetSelectedObject(_ur.ToolData);
        gridToolModeInfo.SetSelectedObject(_ur.ToolModeInfo);
        gridKinematicsData.SetSelectedObject(_ur.KinematicsInfo);
    }

    public void OnOpen()
    {
        this.VerticalScroll.Value = 0;
        this.HorizontalScroll.Value = 0;
    }

    public void OnClose() { }
    #endregion


    private void btnSendScript_Click(object sender, System.EventArgs e)
    {
        if (e is KeyEventArgs && ((KeyEventArgs)e).KeyCode != Keys.Enter) return;

        _ur.Send(txtScript.Text);
    }
}
