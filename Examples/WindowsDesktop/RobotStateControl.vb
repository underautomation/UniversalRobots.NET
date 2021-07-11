Imports System.ComponentModel
Imports UnderAutomation.UniversalRobots

Public Class RobotStateControl

    Shared Sub New()
        ' make grid objects expandable
        TypeDescriptor.AddAttributes(GetType(JointData), New TypeConverterAttribute(GetType(ExpandableObjectConverter)))
        TypeDescriptor.AddAttributes(GetType(JointConfiguration), New TypeConverterAttribute(GetType(ExpandableObjectConverter)))
        TypeDescriptor.AddAttributes(GetType(JointKinematicsInfo), New TypeConverterAttribute(GetType(ExpandableObjectConverter)))
        TypeDescriptor.AddAttributes(GetType(MasterboardDigitalIO), New TypeConverterAttribute(GetType(ExpandableObjectConverter)))

        ' make grid readonly
        TypeDescriptor.AddAttributes(GetType(PackageEventArgs), New ReadOnlyAttribute(True))
    End Sub

    Private _vscroll As VScrollBar

    Public Sub New()
        InitializeComponent()

        ' get scroll bar
        _vscroll = grid.Controls.OfType(Of Control).FirstOrDefault(Function(ctl) ctl.AccessibilityObject.Role = AccessibleRole.Table)?.Controls?.OfType(Of VScrollBar)?.FirstOrDefault()
    End Sub

    Public Property LabelText As String
        Get
            Return lbl.Text
        End Get
        Set(value As String)
            lbl.Text = value
        End Set
    End Property

    Public Sub SetSelectedObject(value As Object)
        If InvokeRequired Then
            Me.Invoke(Sub() SetSelectedObject(value))
        Else
            Me.SuspendLayout()

            ' conserve scroll bar position after a refresh
            Dim vScrollValue = _vscroll?.Value

            grid.SelectedObject = value
            grid.ExpandAllGridItems()

            If _vscroll IsNot Nothing Then _vscroll.Value = If(vScrollValue.HasValue, vScrollValue.Value, 0)
            Me.ResumeLayout()
        End If
    End Sub


End Class
