Imports System.Windows.Forms

Public Partial Class LogControl
    Inherits UserControl
    Implements IUserControl
    Public Sub New()
        InitializeComponent()
    End Sub

#Region "IUserControl"
    Public ReadOnly Property Title As String Implements IUserControl.Title
        Get
            Return "Logs"
        End Get
    End Property

    Public ReadOnly Property FeatureEnabled As Boolean Implements IUserControl.FeatureEnabled
        Get
            Return True
        End Get
    End Property

    Public Sub PeriodicUpdate() Implements IUserControl.PeriodicUpdate
    End Sub

    Public Sub OnClose() Implements IUserControl.OnClose
    End Sub
    Public Sub OnOpen() Implements IUserControl.OnOpen
        txtLog.Text = String.Join(Microsoft.VisualBasic.Constants.vbCrLf & Microsoft.VisualBasic.Constants.vbCrLf, MainForm.Instance.Errors.ToArray())
    End Sub
#End Region


End Class
