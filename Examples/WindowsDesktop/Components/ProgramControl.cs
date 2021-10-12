using System.Reflection;
using System.Windows.Forms;
using UnderAutomation.UniversalRobots;

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
    public void OnOpen() { }
    #endregion
}