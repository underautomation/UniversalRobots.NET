using UnderAutomation.UniversalRobots;
using UnderAutomation.UniversalRobots.Common;
using UnderAutomation.UniversalRobots.Kinematics;

public partial class KinematicsControl : UserControl, IUserControl
{
    UR _ur;
    public KinematicsControl(UR ur)
    {
        _ur = ur;

        InitializeComponent();

        cbModele.Items.Clear();
        cbModele.Items.Add("");
        foreach (var model in Enum.GetNames<RobotModelsExtended>())
        {
            cbModele.Items.Add(model.ToString());
        }
        cbModele.SelectedIndex = 0;

        gridJointsFK.SelectedObject = new double[] { 0, 0, 0, 0, 0, 0 };
        gridDH.SelectedObject = new CustomUrDhParameters(0, 0, 0, 0, 0, 0);
        gridCartesianIK.SelectedObject = new Pose(0, 0, 0, 0, 0, 0);

        lstIKResults.Items.Clear();
    }

    #region IUserControl
    public string Title => "Forward & Invert Kinematics";

    public bool FeatureEnabled => true;

    public void PeriodicUpdate()
    {
        btnImportDH.Enabled = cbModele.SelectedIndex > 0;
        BtnCopyIKSelectedResult.Enabled = lstIKResults.SelectedItems.Count > 0;

        var jointData = _ur.PrimaryInterface.JointData;
        if (jointData is null) return;

        gridCurrentJoints.SelectedObject = new double[] {
            jointData.Base.Position,
            jointData.Shoulder.Position,
            jointData.Elbow.Position,
            jointData.Wrist1.Position,
            _ur.PrimaryInterface.JointData.Wrist2.Position,
            jointData.Wrist3.Position,
        };

        var configurationData = _ur.PrimaryInterface.ConfigurationData;
        if (configurationData is null) return;

        gridCurrentDh.SelectedObject = new CustomUrDhParameters(configurationData);

        var cartesianInfo = _ur.PrimaryInterface.CartesianInfo;
        if (cartesianInfo is null) return;

        gridCurrentCartesian.SelectedObject = cartesianInfo.AsPose();
    }

    public void OnClose() { }

    public void OnOpen() { }
    #endregion


    private void btnCopyCurrentJoints_Click(object sender, EventArgs e)
    {
        var joints = gridCurrentJoints.SelectedObject as double[];
        var currentDh = gridCurrentDh.SelectedObject as IUrDhParameters;
        if (joints is null || currentDh is null) return;

        gridJointsFK.SelectedObject = joints.ToArray();
        gridDH.SelectedObject = new CustomUrDhParameters(currentDh);
    }

    private void btnCopyCurrentCartesian_Click(object sender, EventArgs e)
    {
        var pose = gridCurrentCartesian.SelectedObject as Pose;
        var currentDh = gridCurrentDh.SelectedObject as IUrDhParameters;
        if (pose is null || currentDh is null) return;
        gridCartesianIK.SelectedObject = new Pose(pose);
        gridDH.SelectedObject = new CustomUrDhParameters(currentDh);
    }

    private void btnImportDH_Click(object sender, EventArgs e)
    {
        gridDH.SelectedObject = new CustomUrDhParameters(KinematicsUtils.GetDhParametersFromModel(Enum.Parse<RobotModelsExtended>(cbModele.SelectedItem.ToString())));
    }

    private void btnCopyFKResult_Click(object sender, EventArgs e)
    {
        var result = gridFKResult.SelectedObject as Pose;
        if (result is null) return;
        gridCartesianIK.SelectedObject = new Pose(result);
    }

    private void BtnCopyIKSelectedResult_Click(object sender, EventArgs e)
    {
        if (lstIKResults.SelectedItems.Count == 0) return;

        var joints = lstIKResults.SelectedItems[0].Tag as double[];

        if (joints is null) return;

        gridJointsFK.SelectedObject = joints.ToArray();
    }

    private void btnForwardKinematics_Click(object sender, EventArgs e)
    {
        var joints = gridJointsFK.SelectedObject as double[];
        var dh = gridDH.SelectedObject as IUrDhParameters;

        if (joints is null || dh is null) return;

        var fkResult = KinematicsUtils.ForwardKinematics(joints, dh);

        gridFKResult.SelectedObject = Pose.From4x4MatrixToRotationVector(fkResult.ToolTransform);
    }

    private void btnInvertKinematics_Click(object sender, EventArgs e)
    {
        var pose = gridCartesianIK.SelectedObject as Pose;
        var dh = gridDH.SelectedObject as IUrDhParameters;

        if (pose is null || dh is null) return;

        var matrix = pose.FromRotationVectorTo4x4Matrix();

        var results = KinematicsUtils.InverseKinematics(matrix, dh);

        lstIKResults.Items.Clear();
        for (int i = 0; i < results.Length; i++)
        {
            var result = results[i];
            var item = new ListViewItem();
            item.Text = (i + 1).ToString();
            foreach (var value in result) item.SubItems.Add(value.ToString("F4"));
            item.Tag = result;

            lstIKResults.Items.Add(item);
        }
    }
}
