Imports System
Imports System.ComponentModel
Imports System.Globalization
Imports System.Linq
Imports System.Windows.Forms
Imports UnderAutomation.UniversalRobots.Common
Imports UnderAutomation.UniversalRobots.PrimaryInterface

' Advanced Property Grid thats displays a Primary Interface Package
Public Partial Class PrimaryInterfacePackageControl
    Inherits UserControl
    Private _vscroll As VScrollBar

    Shared Sub New()
        ' make grid objects expandable
        Call TypeDescriptor.AddAttributes(GetType(JointData), New TypeConverterAttribute(GetType(CustomExpandableObjectConverter)))
        Call TypeDescriptor.AddAttributes(GetType(JointConfiguration), New TypeConverterAttribute(GetType(CustomExpandableObjectConverter)))
        Call TypeDescriptor.AddAttributes(GetType(JointKinematicsInfo), New TypeConverterAttribute(GetType(CustomExpandableObjectConverter)))
        Call TypeDescriptor.AddAttributes(GetType(MasterboardDigitalIO), New TypeConverterAttribute(GetType(CustomExpandableObjectConverter)))

        ' make grid readonly
        Call TypeDescriptor.AddAttributes(GetType(PackageEventArgs), New ReadOnlyAttribute(True))
    End Sub

    Public Sub New()
        InitializeComponent()
        _vscroll = grid.Controls.OfType(Of Control)().FirstOrDefault(Function(ctl) ctl.AccessibilityObject.Role = AccessibleRole.Table)?.Controls?.OfType(Of VScrollBar)()?.FirstOrDefault()
    End Sub


    Public Property LabelText As String
        Get
            Return lbl.Text
        End Get
        Set(value As String)
            lbl.Text = value
        End Set
    End Property

    Public Sub SetSelectedObject(Of T As PackageEventArgs)(value As T)
        SuspendLayout()

        ' conserve scroll bar position after a refresh
        Dim vScrollValue = _vscroll?.Value

        If value Is Nothing Then
            If grid.SelectedObject Is Nothing Then grid.SelectedObject = Activator.CreateInstance(Of T)()
        Else
            grid.SelectedObject = value
            grid.ExpandAllGridItems()

            If _vscroll IsNot Nothing Then _vscroll.Value = If(vScrollValue, 0)
        End If
        ResumeLayout()
    End Sub

    Public Class CustomExpandableObjectConverter
        Inherits ExpandableObjectConverter
        Public Overrides Function ConvertTo(context As ITypeDescriptorContext, culture As CultureInfo, value As Object, destinationType As Type) As Object
            ' Return empty string and not class name in data grid view for expandable objects
            Return If(destinationType Is GetType(String), "", MyBase.ConvertTo(context, culture, value, destinationType))
        End Function
    End Class
End Class
