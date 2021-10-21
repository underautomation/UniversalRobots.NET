using System.Windows.Forms;
using UnderAutomation.UniversalRobots;

public partial class PrimaryInterfaceControl : UserControl, IUserControl
{
    private UR _ur;

    public PrimaryInterfaceControl(UR ur)
    {
        _ur = ur;
        InitializeComponent();

        txtScript.Text = Config.Current.URScript ?? "movej([-1.5,-1.5,-2,-0.5,1.8,0],a=1.4, v=1.05, t=0, r=0)";
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
        gridVersion.SetSelectedObject(_ur.Version);
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
        _ur.Send(txtScript.Text);

        Config.Current.URScript = txtScript.Text;
        Config.Save();
    }
}
