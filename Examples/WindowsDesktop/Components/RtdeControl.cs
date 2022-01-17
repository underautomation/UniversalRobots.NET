using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using UnderAutomation.UniversalRobots;
using UnderAutomation.UniversalRobots.Internal;
using UnderAutomation.UniversalRobots.Rtde;



public partial class RtdeControl : UserControl, IUserControl
{
    private UR _ur;
    private VScrollBar _vscroll;

    static RtdeControl()
    {
        TypeDescriptor.AddAttributes(typeof(CartesianCoordinates), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
        TypeDescriptor.AddAttributes(typeof(IJointValues), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
        TypeDescriptor.AddAttributes(typeof(Vector3D), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));

        TypeDescriptor.AddAttributes(typeof(RtdeOutputValues), new ReadOnlyAttribute(true));

        TypeDescriptor.AddAttributes(typeof(RtdeIntRegistersValue), new TypeConverterAttribute(typeof(RtdeRegistersConverter)));
        TypeDescriptor.AddAttributes(typeof(RtdeBitRegistersValue), new TypeConverterAttribute(typeof(RtdeRegistersConverter)));
        TypeDescriptor.AddAttributes(typeof(RtdeDoubleRegistersValue), new TypeConverterAttribute(typeof(RtdeRegistersConverter)));
    }

    public RtdeControl(UR ur)
    {
        _ur = ur;

        InitializeComponent();


        _vscroll = gridOutputs.Controls.OfType<Control>().FirstOrDefault(ctl => ctl.AccessibilityObject.Role == AccessibleRole.Table)?.Controls?.OfType<VScrollBar>()?.FirstOrDefault();

        _ur.Rtde.OutputDataReceived += Rtde_RTDEDataReceived;
    }


    #region IUserControl
    public string Title => "Real-time Data Exchange (RTDE)";

    public bool FeatureEnabled => _ur.Rtde.Connected;

    public void PeriodicUpdate()
    {
        txtFrequency.Text = $"{_ur.Rtde.MeasuredFrequency.ToString("0.000")} Hz";

        gridOutputs.Refresh();

        btnSendInputs.Enabled = FeatureEnabled;

        btnPause.Enabled = _ur.Rtde.State == RTDEStates.Started;

        btnResume.Enabled = _ur.Rtde.State == RTDEStates.Paused;

        lblState.Text = _ur.Rtde.State.ToString();
        lblkVersion.Text = _ur.Rtde.Version.ToString();
    }

    public void SetSelectedObject(object value)
    {
        this.SuspendLayout();

        // conserve scroll bar position after a refresh
        var vScrollValue = _vscroll?.Value;


        gridOutputs.SelectedObject = value;
        gridOutputs.ExpandAllGridItems();

        if (_vscroll != null)
            _vscroll.Value = vScrollValue ?? 0;

        this.ResumeLayout();
    }

    public void OnClose() { }

    private readonly RtdeInputValues InputValues = new RtdeInputValues();

    public void OnOpen()
    {
        gridInputs.SelectedObject = new RtdeValueTypeDescriptor(InputValues, _ur.Rtde.InputSetup);

        gridOutputs.SelectedObject = new RtdeValueTypeDescriptor(_ur.Rtde.OutputDataValues, _ur.Rtde.OutputSetup);
    }


    #endregion

    /// <summary>
    /// Filter properties to only display those in setup
    /// </summary>
    public class RtdeValueTypeDescriptor : CustomTypeDescriptor
    {
        public object Values { get; private set; }

        public IEnumerable<RtdeInputSetupItem> InputSetup { get; private set; }

        public IEnumerable<RtdeOutputSetupItem> OutputSetup { get; private set; }

        public RtdeValueTypeDescriptor(RtdeInputValues values, IEnumerable<RtdeInputSetupItem> setup)
            : base(TypeDescriptor.GetProvider(values).GetTypeDescriptor(values))
        {
            Values = values;
            InputSetup = setup;
        }
        public RtdeValueTypeDescriptor(RtdeOutputValues values, IEnumerable<RtdeOutputSetupItem> setup)
            : base(TypeDescriptor.GetProvider(values).GetTypeDescriptor(values))
        {
            Values = values;
            OutputSetup = setup;
        }


        public override PropertyDescriptorCollection GetProperties()
        {
            return this.GetProperties(new Attribute[] { });
        }
        public override PropertyDescriptorCollection GetProperties(Attribute[] attributes)
        {
            PropertyDescriptor[] properties;
            if (OutputSetup is object)
            {
                // Display only properties in Setup
                properties = base.GetProperties(attributes).Cast<PropertyDescriptor>()
                    .Where(x => OutputSetup.Any(d => d.Data.ToString() == x.Name))
                                     .Select(p => TypeDescriptor.CreateProperty(
                                         Values.GetType(),
                                         p,
                                         p.Attributes.Cast<Attribute>().ToArray()))
                                     .ToArray();
            }
            else if (InputSetup is object)
            {
                // Display only properties in Setup
                properties = base.GetProperties(attributes).Cast<PropertyDescriptor>()
                    .Where(x => InputSetup.Any(d => d.Data.ToString() == x.Name))
                                     .Select(p => TypeDescriptor.CreateProperty(
                                         Values.GetType(),
                                         p,
                                         p.Attributes.Cast<Attribute>().ToArray()))
                                     .ToArray();
            }
            else return base.GetProperties(attributes);

            return new PropertyDescriptorCollection(properties);
        }

    }

    /// <summary>
    /// Expand array values and only display index in setup
    /// </summary>
    public class RtdeRegistersConverter : ExpandableObjectConverter
    {
        public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
        {
            var wrapper = context.Instance as RtdeValueTypeDescriptor;

            var props = base.GetProperties(context, value, attributes);

            if (wrapper is null || (wrapper.InputSetup is null && wrapper.OutputSetup is null)) return props;

            // Display only properies Xnn in setup
            string[] propNames;

            if (wrapper.InputSetup is null)
                propNames = wrapper.OutputSetup.Where(x => x.Data.ToString() == context.PropertyDescriptor.Name).Select(x => "X" + x.Index).ToArray();
            else
                propNames = wrapper.InputSetup.Where(x => x.Data.ToString() == context.PropertyDescriptor.Name).Select(x => "X" + x.Index).ToArray();

            return new PropertyDescriptorCollection(props.OfType<PropertyDescriptor>().Where(x => propNames.Contains(x.Name)).ToArray());
        }
    }

    private void btnSendInputs_Click(object sender, EventArgs e)
    {
        _ur.Rtde.WriteInputs(InputValues);
    }


    private void barSpeed_ValueChanged(object sender, EventArgs e)
    {
        InputValues.SpeedSliderMask = 1;
        InputValues.SpeedSliderFraction = (double)barSpeed.Value / 100.0;
        lblSpeedPercent.Text = $"{barSpeed.Value}%";
        gridInputs.Refresh();

        _sendData = true;
        tmrStopWrite.Enabled = true;

        // Write data directly if no Data event
        if (_ur.Rtde.OutputSetup is object && _ur.Rtde.OutputSetup.Count() == 0 && _ur.Rtde.Connected) _ur.Rtde.WriteInputs(InputValues);
    }

    private void Rtde_RTDEDataReceived(object sender, RtdeDataPackageEventArgs e)
    {
        if (!_sendData || !_ur.Rtde.Connected) return;

        // Write data at same frequency as received data when cursor is pushed
        _ur.Rtde.WriteInputs(InputValues);
    }

    private bool _sendData;

    private void tmrStopWrite_Tick(object sender, EventArgs e)
    {
        _sendData = false;
        tmrStopWrite.Enabled = false;
    }

    private void btnPause_Click(object sender, EventArgs e)
    {
        _ur.Rtde.Pause();
    }

    private void btnStart_Click(object sender, EventArgs e)
    {
        _ur.Rtde.Resume();
    }

}

