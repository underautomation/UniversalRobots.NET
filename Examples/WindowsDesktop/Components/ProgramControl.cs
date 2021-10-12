using System.Reflection;
using System.Windows.Forms;
using UnderAutomation.UniversalRobots;
using System.Linq;
using System;

public partial class ProgramControl : UserControl, IUserControl
{
    private UR _ur;

    public ProgramControl(UR ur)
    {
        _ur = ur;

        InitializeComponent();

        // prevent list view from flickering
        var method = typeof(Control).GetMethod("SetStyle", BindingFlags.Instance | BindingFlags.NonPublic);
        method.Invoke(lstVariables, new object[] { ControlStyles.OptimizedDoubleBuffer, true });
    }

    #region IUserControl
    public string Title => "Running program and variables";

    public bool FeatureEnabled => _ur.DataStreamingEnabled;

    public void PeriodicUpdate()
    {
        var variables = _ur.GlobalVariables.GetAll();

        try
        {
            lstVariables.BeginUpdate();

            for (int i = 0; i < variables.Length; i++)
            {
                var variable = variables[i];

                if (i < lstVariables.Items.Count)
                {
                    // Replace item
                    lstVariables.Items[i].SubItems[0].Text = variable.Name;
                    lstVariables.Items[i].SubItems[1].Text = variable.Type.ToString();
                    lstVariables.Items[i].SubItems[2].Text = variable.ToString();
                }
                else
                {
                    // add new items
                    lstVariables.Items.Add(new ListViewItem(new[] { variable.Name, variable.Type.ToString(), variable.ToString() }));
                }
            }

            var itemCount = lstVariables.Items.Count;
            for (int i= variables.Length;i< itemCount; i++)
            {
                // remove last items
                lstVariables.Items.RemoveAt(lstVariables.Items.Count - 1);
            }
        }
        finally
        {
            lstVariables.EndUpdate();
        }
    }

    public void OnClose() { }
    public void OnOpen()
    {
        cbPrograms.Items.Clear();

        if (!_ur.SftpEnabled || string.IsNullOrEmpty(_ur.IP)) return;

        var loadedPrograms = _ur.GetLoadedProgram();
        var splitedPath = loadedPrograms.Value.Split(new string[] { "programs/" }, System.StringSplitOptions.RemoveEmptyEntries);
        var pathToPrograms = $"{splitedPath[0]}programs";

        var items = _ur.SFTP.ListDirectory(pathToPrograms);

        var programs = items.Where(x => x.Name.EndsWith(".urp", StringComparison.InvariantCultureIgnoreCase)).Select(x => x.Name).ToArray();

        cbPrograms.Items.AddRange(programs);
        if (splitedPath.Length > 0) cbPrograms.Text = splitedPath[1];
    }
    #endregion

    private void btnRun_Click(object sender, System.EventArgs e)
    {
        var result = _ur.LoadProgram(cbPrograms.Text);

        if (!result.Succeed) throw new Exception(result.Message);

        result = _ur.Play();

        if (!result.Succeed) throw new Exception(result.Message);
    }

    private void btnPause_Click(object sender, EventArgs e)
    {
        _ur.Pause();
    }

    private void btnStop_Click(object sender, EventArgs e)
    {
        _ur.Stop();
    }
}