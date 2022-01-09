using System.Windows.Forms;
using UnderAutomation.UniversalRobots;

public partial class ConnectRtdePopup : Form, IRTDEOutputsUseVisitor
{
    TreeNode _parentNode;

    public ConnectRtdePopup(RTDEOutputUse rtde)
    {
        InitializeComponent();

        _parentNode = tree.Nodes.Add("");

        rtde.AcceptVisitor(this);

        _parentNode.Expand();
    }

    #region IRTDEOutputsUseVisitor
    public void Visit(RtdeOutputUseArrayData data)
    {
        AddTreeNode(data, true);
    }

    public void Visit(RtdeOutputUseArrayElementData data)
    {
        AddTreeNode(data, false);
    }

    public void Visit(RtdeOutputUseSingleData data)
    {
        AddTreeNode(data, true);
    }
    #endregion

    TreeNode _lastTopLevelNode;
    private void AddTreeNode(IRtdeOutputUseData data, bool topLevel)
    {
        var nodes = topLevel ? _parentNode.Nodes : _lastTopLevelNode.Nodes;

        var node = nodes.Add($"{data.Name} ({data.Type})");
        node.Tag = data;
        node.ToolTipText = UR.RtdeOutputsDescription.Get(data.Data).Description;

        if (topLevel) _lastTopLevelNode = node;
    }

    private void tree_AfterCheck(object sender, TreeViewEventArgs e)
    {
        if (e.Node is null) return;
        var tag = e.Node.Tag;

        if (tag is RtdeOutputUseSingleData)
        {
            ((RtdeOutputUseSingleData)tag).Use = e.Node.Checked;
        }
        else
        {
            foreach (TreeNode node in e.Node.Nodes) node.Checked = e.Node.Checked;
        }

    }
}
