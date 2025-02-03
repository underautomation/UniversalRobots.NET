using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using UnderAutomation.UniversalRobots;
using UnderAutomation.UniversalRobots.Common;
using UnderAutomation.UniversalRobots.PrimaryInterface;

// Advanced Property Grid thats displays a Primary Interface Package
public partial class PrimaryInterfacePackageControl : UserControl
{
    private VScrollBar _vscroll;

    static PrimaryInterfacePackageControl()
    {
        // make grid objects expandable
        TypeDescriptor.AddAttributes(typeof(JointData), new TypeConverterAttribute(typeof(CustomExpandableObjectConverter)));
        TypeDescriptor.AddAttributes(typeof(JointConfiguration), new TypeConverterAttribute(typeof(CustomExpandableObjectConverter)));
        TypeDescriptor.AddAttributes(typeof(JointKinematicsInfo), new TypeConverterAttribute(typeof(CustomExpandableObjectConverter)));
        TypeDescriptor.AddAttributes(typeof(MasterboardDigitalIO), new TypeConverterAttribute(typeof(CustomExpandableObjectConverter)));

        // make grid readonly
        TypeDescriptor.AddAttributes(typeof(PackageEventArgs), new ReadOnlyAttribute(true));
    }

    public PrimaryInterfacePackageControl()
    {
        InitializeComponent();
        _vscroll = grid.Controls.OfType<Control>().FirstOrDefault(ctl => ctl.AccessibilityObject.Role == AccessibleRole.Table)?.Controls?.OfType<VScrollBar>()?.FirstOrDefault();
    }


    public string LabelText
    {
        get
        {
            return lbl.Text;
        }
        set
        {
            lbl.Text = value;
        }
    }

    public void SetSelectedObject<T>(T value) where T: PackageEventArgs
    {
        this.SuspendLayout();

        // conserve scroll bar position after a refresh
        var vScrollValue = _vscroll?.Value;

        if (value is null)
        {
            if (grid.SelectedObject is null) grid.SelectedObject = Activator.CreateInstance<T>();
        }
        else
        {
            grid.SelectedObject = value;
            grid.ExpandAllGridItems();

            if (_vscroll != null)
                _vscroll.Value = vScrollValue ?? 0;
        }
        this.ResumeLayout();
    }

    public class CustomExpandableObjectConverter : ExpandableObjectConverter
    {
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            // Return empty string and not class name in data grid view for expandable objects
            return destinationType == typeof(string) ? "" : base.ConvertTo(context, culture, value, destinationType);
        }
    }
}

