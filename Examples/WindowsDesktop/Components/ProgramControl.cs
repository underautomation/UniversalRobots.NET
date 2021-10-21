using System.Reflection;
using System.Windows.Forms;
using UnderAutomation.UniversalRobots;
using System.Linq;
using System;
using System.Collections.Generic;

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
        method.Invoke(lstThreads, new object[] { ControlStyles.OptimizedDoubleBuffer, true });
    }

    #region IUserControl
    public string Title => "Running program and variables";

    public bool FeatureEnabled => _ur.DataStreamingEnabled;

    public void PeriodicUpdate()
    {
        var variables = _ur.GlobalVariables.GetAll();

        UpdateList(lstVariables, variables, v => v.Name, v => v.Type.ToString(), v => v.ToString());

        var threads = _ur.ProgramThreads?.Threads;

        if(threads is object)
            UpdateList(lstThreads, threads, t => t.LineNumber.ToString(), t => t.LineName);
    }

    /// <summary>
    /// Update list view
    /// </summary>
    /// <param name="list">ListView to update</param>
    /// <param name="values">Items to add to the list</param>
    /// <param name="decoders">Lambda that transforms item to column string value</param>
    private void UpdateList<T>(ListView list, IEnumerable<T> values, params Func<T, string>[] decoders)
    {
        try
        {
            list.BeginUpdate();

            for (int i = 0; i < values.Count(); i++)
            {
                var variable = values.ElementAt(i);

                if (i < list.Items.Count)
                {
                    // Replace item
                    for (int c = 0; c < decoders.Length; c++) list.Items[i].SubItems[c].Text = decoders[c](variable);
                }
                else
                {
                    // add new items
                    list.Items.Add(new ListViewItem(decoders.Select(decoder => decoder(variable)).ToArray()));
                }
            }

            var itemCount = list.Items.Count;
            for (int i = values.Count(); i < itemCount; i++)
            {
                // remove last items
                list.Items.RemoveAt(list.Items.Count - 1);
            }
        }
        finally
        {
            list.EndUpdate();
        }
    }

    public void OnClose() { }
    public void OnOpen()
    {
        cbPrograms.Items.Clear();
        lblPathToPrograms.Text = "";

        if (!_ur.SftpEnabled || string.IsNullOrEmpty(_ur.IP)) return;

        var loadedPrograms = _ur.GetLoadedProgram();
        var splitedPath = loadedPrograms.Value?.Split(new string[] { "programs/" }, System.StringSplitOptions.RemoveEmptyEntries);
        var pathToPrograms = splitedPath is null ? loadedPrograms.Message : $"{splitedPath[0]}programs";

        lblPathToPrograms.Text = pathToPrograms;

        if (splitedPath is object)
        {
            try
            {
                var items = _ur.SFTP.ListDirectory(pathToPrograms);

                var programs = items.Where(x => x.Name.EndsWith(".urp", StringComparison.InvariantCultureIgnoreCase)).Select(x => x.Name).ToArray();

                cbPrograms.Items.AddRange(programs);
                if (splitedPath.Length > 0) cbPrograms.Text = splitedPath[1];
            }
            catch(Exception e)
            {
                lblPathToPrograms.Text = $"{lblPathToPrograms.Text} ({e.Message})";
            }
        }
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