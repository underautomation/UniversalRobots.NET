Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports System.Windows.Forms
Imports UnderAutomation.UniversalRobots
Imports UnderAutomation.UniversalRobots.Common
Imports UnderAutomation.UniversalRobots.Rtde



Public Partial Class RtdeControl
    Inherits UserControl
    Implements IUserControl
    Private _ur As UR
    Private _vscroll As VScrollBar

    Shared Sub New()
        Call TypeDescriptor.AddAttributes(GetType(CartesianCoordinates), New TypeConverterAttribute(GetType(ExpandableObjectConverter)))
        Call TypeDescriptor.AddAttributes(GetType(JointsValues(Of)), New TypeConverterAttribute(GetType(ExpandableObjectConverter)))
        Call TypeDescriptor.AddAttributes(GetType(Vector3D), New TypeConverterAttribute(GetType(ExpandableObjectConverter)))

        Call TypeDescriptor.AddAttributes(GetType(RtdeOutputValues), New ReadOnlyAttribute(True))

        Call TypeDescriptor.AddAttributes(GetType(RtdeIntRegistersValue), New TypeConverterAttribute(GetType(RtdeRegistersConverter)))
        Call TypeDescriptor.AddAttributes(GetType(RtdeBitRegistersValue), New TypeConverterAttribute(GetType(RtdeRegistersConverter)))
        Call TypeDescriptor.AddAttributes(GetType(RtdeDoubleRegistersValue), New TypeConverterAttribute(GetType(RtdeRegistersConverter)))
    End Sub

    Public Sub New(ur As UR)
        _ur = ur

        InitializeComponent()


        _vscroll = gridOutputs.Controls.OfType(Of Control)().FirstOrDefault(Function(ctl) ctl.AccessibilityObject.Role = AccessibleRole.Table)?.Controls?.OfType(Of VScrollBar)()?.FirstOrDefault()

        AddHandler _ur.Rtde.OutputDataReceived, AddressOf Rtde_RTDEDataReceived
    End Sub


#Region "IUserControl"
    Public ReadOnly Property Title As String Implements IUserControl.Title
        Get
            Return "Real-time Data Exchange (RTDE)"
        End Get
    End Property

    Public ReadOnly Property FeatureEnabled As Boolean Implements IUserControl.FeatureEnabled
        Get
            Return _ur.Rtde.Connected
        End Get
    End Property

    Public Sub PeriodicUpdate() Implements IUserControl.PeriodicUpdate
        txtFrequency.Text = $"{_ur.Rtde.MeasuredFrequency.ToString("0.000")} Hz"

        gridOutputs.Refresh()

        btnSendInputs.Enabled = FeatureEnabled

        btnPause.Enabled = _ur.Rtde.State = RTDEStates.Started

        btnResume.Enabled = _ur.Rtde.State = RTDEStates.Paused

        lblState.Text = _ur.Rtde.State.ToString()
        lblkVersion.Text = _ur.Rtde.Version.ToString()
    End Sub

    Public Sub SetSelectedObject(value As Object)
        SuspendLayout()

        ' conserve scroll bar position after a refresh
        Dim vScrollValue = _vscroll?.Value


        gridOutputs.SelectedObject = value
        gridOutputs.ExpandAllGridItems()

        If _vscroll IsNot Nothing Then _vscroll.Value = If(vScrollValue, 0)

        ResumeLayout()
    End Sub

    Public Sub OnClose() Implements IUserControl.OnClose
    End Sub

    Private ReadOnly InputValues As RtdeInputValues = New RtdeInputValues()

    Public Sub OnOpen() Implements IUserControl.OnOpen
        gridInputs.SelectedObject = New RtdeValueTypeDescriptor(InputValues, _ur.Rtde.InputSetup)

        gridOutputs.SelectedObject = New RtdeValueTypeDescriptor(_ur.Rtde.OutputDataValues, _ur.Rtde.OutputSetup)
    End Sub


#End Region

    ''' <summary>
    ''' Filter properties to only display those in setup
    ''' </summary>
    Public Class RtdeValueTypeDescriptor
        Inherits CustomTypeDescriptor


        Private _Values As Object, _InputSetup As System.Collections.Generic.IEnumerable(Of RtdeInputSetupItem), _OutputSetup As System.Collections.Generic.IEnumerable(Of RtdeOutputSetupItem)

        Public Property Values As Object
            Get
                Return _Values
            End Get
            Private Set(value As Object)
                _Values = value
            End Set
        End Property

        Public Property InputSetup As IEnumerable(Of RtdeInputSetupItem)
            Get
                Return _InputSetup
            End Get
            Private Set(value As IEnumerable(Of RtdeInputSetupItem))
                _InputSetup = value
            End Set
        End Property

        Public Property OutputSetup As IEnumerable(Of RtdeOutputSetupItem)
            Get
                Return _OutputSetup
            End Get
            Private Set(value As IEnumerable(Of RtdeOutputSetupItem))
                _OutputSetup = value
            End Set
        End Property

        Public Sub New(values As RtdeInputValues, setup As IEnumerable(Of RtdeInputSetupItem))
            MyBase.New(TypeDescriptor.GetProvider(values).GetTypeDescriptor(values))
            Me.Values = values
            InputSetup = setup
        End Sub
        Public Sub New(values As RtdeOutputValues, setup As IEnumerable(Of RtdeOutputSetupItem))
            MyBase.New(TypeDescriptor.GetProvider(values).GetTypeDescriptor(values))
            Me.Values = values
            OutputSetup = setup
        End Sub


        Public Overrides Overloads Function GetProperties() As PropertyDescriptorCollection
            Return GetProperties(New Attribute() {})
        End Function
        Public Overrides Overloads Function GetProperties(attributes As Attribute()) As PropertyDescriptorCollection
            Dim properties As PropertyDescriptor()
            If TypeOf OutputSetup Is Object Then
                ' Display only properties in Setup
                properties = MyBase.GetProperties(attributes).Cast(Of PropertyDescriptor)().Where(Function(x) OutputSetup.Any(Function(d) Equals(d.Data.ToString(), x.Name))).[Select](Function(p) TypeDescriptor.CreateProperty(Values.GetType(), p, p.Attributes.Cast(Of Attribute)().ToArray())).ToArray()
            ElseIf TypeOf InputSetup Is Object Then
                ' Display only properties in Setup
                properties = MyBase.GetProperties(attributes).Cast(Of PropertyDescriptor)().Where(Function(x) InputSetup.Any(Function(d) Equals(d.Data.ToString(), x.Name))).[Select](Function(p) TypeDescriptor.CreateProperty(Values.GetType(), p, p.Attributes.Cast(Of Attribute)().ToArray())).ToArray()
            Else
                Return MyBase.GetProperties(attributes)
            End If

            Return New PropertyDescriptorCollection(properties)
        End Function

    End Class

    ''' <summary>
    ''' Expand array values and only display index in setup
    ''' </summary>
    Public Class RtdeRegistersConverter
        Inherits ExpandableObjectConverter
        Public Overrides Function GetProperties(context As ITypeDescriptorContext, value As Object, attributes As Attribute()) As PropertyDescriptorCollection
            Dim wrapper = TryCast(context.Instance, RtdeValueTypeDescriptor)

            Dim props = MyBase.GetProperties(context, value, attributes)

            If wrapper Is Nothing OrElse wrapper.InputSetup Is Nothing AndAlso wrapper.OutputSetup Is Nothing Then Return props

            ' Display only properies Xnn in setup
            Dim propNames As String()

            If wrapper.InputSetup Is Nothing Then
                propNames = wrapper.OutputSetup.Where(Function(x) Equals(x.Data.ToString(), context.PropertyDescriptor.Name)).[Select](Function(x) "X" & x.Index.ToString()).ToArray()
            Else
                propNames = wrapper.InputSetup.Where(Function(x) Equals(x.Data.ToString(), context.PropertyDescriptor.Name)).[Select](Function(x) "X" & x.Index.ToString()).ToArray()
            End If

            Return New PropertyDescriptorCollection(props.OfType(Of PropertyDescriptor)().Where(Function(x) propNames.Contains(x.Name)).ToArray())
        End Function
    End Class

    Private Sub btnSendInputs_Click(sender As Object, e As EventArgs)
        _ur.Rtde.WriteInputs(InputValues)
    End Sub


    Private Sub barSpeed_ValueChanged(sender As Object, e As EventArgs)
        InputValues.SpeedSliderMask = 1
        InputValues.SpeedSliderFraction = barSpeed.Value / 100.0
        lblSpeedPercent.Text = $"{barSpeed.Value}%"
        gridInputs.Refresh()

        _sendData = True
        tmrStopWrite.Enabled = True

        ' Write data directly if no Data event
        If TypeOf _ur.Rtde.OutputSetup Is Object AndAlso _ur.Rtde.OutputSetup.Count() = 0 AndAlso _ur.Rtde.Connected Then _ur.Rtde.WriteInputs(InputValues)
    End Sub

    Private Sub Rtde_RTDEDataReceived(sender As Object, e As RtdeDataPackageEventArgs)
        If Not _sendData OrElse Not _ur.Rtde.Connected Then Return

        ' Write data at same frequency as received data when cursor is pushed
        _ur.Rtde.WriteInputs(InputValues)
    End Sub

    Private _sendData As Boolean

    Private Sub tmrStopWrite_Tick(sender As Object, e As EventArgs)
        _sendData = False
        tmrStopWrite.Enabled = False
    End Sub

    Private Sub btnPause_Click(sender As Object, e As EventArgs)
        _ur.Rtde.Pause()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs)
        _ur.Rtde.Resume()
    End Sub

End Class
