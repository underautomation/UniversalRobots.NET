using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using UnderAutomation.UniversalRobots.Rtde;
using UnderAutomation.UniversalRobots.Rtde.Internal;

public class ConnectRtdePopup<T, U, V> : ConnectRtdePopupBase
    where V : RtdeSetup<T, U>, new()
    where T: RtdeSetupItem<U>, new()
    where U: Enum
{
    public ConnectRtdePopup(string text, V rtde, IEnumerable< RtdeDataDescription<U>> allData) : base(text)
    {
        var parentNode = tree.Nodes.Add("All data");

        foreach (var data in allData)
        {
            if (data.IsArray)
            {
                var node = parentNode.Nodes.Add(data.Name);
                for (int i = data.LowerIndex; i < data.LowerIndex + data.ArraySize; i++)
                {
                    AddTreeNode(node, new T() { Data = data.Data, Index = i }, rtde);
                }
            }
            else
            {
                AddTreeNode(parentNode, new T() {Data = data.Data }, rtde);
            }
        }

        // Expand parent node
        parentNode.Expand();


        foreach (TreeNode node in parentNode.Nodes)
        {
            if (node.Nodes.OfType<TreeNode>().Any(n => n.Checked)) node.Expand();// Expand only nodes that have checked children
            if (node.Nodes.Count > 0 && node.Nodes.OfType<TreeNode>().All(n => n.Checked)) node.Checked = true;// check node if all its sub node are checked
        }
        if (parentNode.Nodes.OfType<TreeNode>().All(n => n.Checked)) parentNode.Checked = true;
    }


    public V Setup { get; } = new V();

    private void AddTreeNode(TreeNode parent, T tag, V originalConfiguration)
    {
        var node = parent.Nodes.Add($"{tag.Name} ({tag.Type})");
        node.Tag = tag;
        node.ToolTipText = tag.Description.Description;
        node.Checked = originalConfiguration.Contains(tag.Data, tag.Index);
    }

    protected override void tree_AfterCheck(object sender, TreeViewEventArgs e)
    {
        if (e.Node is null) return;

        var tag = e.Node.Tag as T;

        if (tag is null)
        {
            foreach (TreeNode node in e.Node.Nodes) if (node.Checked != e.Node.Checked) node.Checked = e.Node.Checked;
        }
        else
        {
            if (e.Node.Checked) Setup.Add(tag);
            else Setup.Remove(tag);
        }
    }

}