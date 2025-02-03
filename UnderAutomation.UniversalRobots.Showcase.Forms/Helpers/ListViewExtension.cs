using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public static class ListViewExtension
{

    /// <summary>
    /// Update list view
    /// </summary>
    /// <param name="list">ListView to update</param>
    /// <param name="values">Items to add to the list</param>
    /// <param name="decoders">Lambda that transforms item to column string value</param>
    public static void UpdateList<T>(this ListView list, IEnumerable<T> values, params Func<T, object>[] decoders)
    {
        try
        {
            list.BeginUpdate();

            if (values is null || values.Count() == 0) list.Items.Clear();
            else
            {

                for (int i = 0; i < values.Count(); i++)
                {
                    var variable = values.ElementAt(i);

                    if (i < list.Items.Count)
                    {
                        // Replace item
                        for (int c = 0; c < decoders.Length; c++) list.Items[i].SubItems[c].Text = decoders[c](variable)?.ToString();
                    }
                    else
                    {
                        // add new items
                        list.Items.Add(new ListViewItem(decoders.Select(decoder => decoder(variable)?.ToString()).ToArray()));
                    }
                }

                var itemCount = list.Items.Count;
                for (int i = values.Count(); i < itemCount; i++)
                {
                    // remove last items
                    list.Items.RemoveAt(list.Items.Count - 1);
                }
            }
        }
        finally
        {
            list.EndUpdate();
        }
    }


    [DllImport("user32.dll")]
    static extern int SendMessage
    (IntPtr window, int message, int wParam, IntPtr lParam);

    public static void SetGroupCollapse(this ListViewGroup group, GroupState state)
    {
        var i = group.ListView.Groups.IndexOf(group);

        LVGROUP lvgroup = new LVGROUP();
        lvgroup.cbSize = Marshal.SizeOf(lvgroup);
        lvgroup.state = (int)state; // LVGS_COLLAPSIBLE 
        lvgroup.mask = 4; // LVGF_STATE 
        lvgroup.iGroupId = i;
        IntPtr ip = IntPtr.Zero;
        try
        {
            ip = Marshal.AllocHGlobal(lvgroup.cbSize);
            Marshal.StructureToPtr(lvgroup, ip, true);
            SendMessage(group.ListView.Handle, 0x1000 + 147, i, ip); // #define  LVM_SETGROUPINFO(LVM_FIRST + 147)
        }
        catch (Exception ex)
        {
        }
        finally
        {
            if (null != ip) Marshal.FreeHGlobal(ip);
        }
    }
}

[StructLayout(LayoutKind.Sequential)]
public struct LVGROUP
{
    public int cbSize;
    public int mask;
    public IntPtr pszHeader;
    public int cchHeader;
    public IntPtr pszFooter;
    public int cchFooter;
    public int iGroupId;
    public int stateMask;
    public int state;
    public int uAlign;
}
public enum GroupState
{
    COLLAPSIBLE = 8,
    COLLAPSED = 1,
    EXPANDED = 0
}