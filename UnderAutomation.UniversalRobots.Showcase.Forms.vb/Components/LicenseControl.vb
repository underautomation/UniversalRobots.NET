Imports System.Diagnostics
Imports System.Windows.Forms
Imports UnderAutomation.UniversalRobots
Imports UnderAutomation.UniversalRobots.License

Public Partial Class LicenseControl
    Inherits UserControl
    Implements IUserControl
    ' Cache valid license info
    Private _licenseValid As Boolean

    Public Sub New()
        InitializeComponent()

        ' Set stored license information
        txtLicensee.Text = Config.Current.Licensee
        txtKey.Text = Config.Current.Key

        ' Register license at startup
        UR.RegisterLicense(Config.Current.Licensee, Config.Current.Key)

        UpdateLicenseControls()
    End Sub

#Region "IUserControl"
    Public ReadOnly Property Title As String Implements IUserControl.Title
        Get
            Return "License"
        End Get
    End Property

    Public ReadOnly Property FeatureEnabled As Boolean Implements IUserControl.FeatureEnabled
        Get
            Return _licenseValid
        End Get
    End Property

    Public Sub PeriodicUpdate() Implements IUserControl.PeriodicUpdate
    End Sub

    Public Sub OnClose() Implements IUserControl.OnClose
    End Sub

    Public Sub OnOpen() Implements IUserControl.OnOpen
    End Sub
#End Region

    Private Sub UpdateLicenseControls()
        ' Display license data
        Dim info = UR.LicenseInfo
        txtLicenseInfo.Text = info.ToString()
        gridLicense.SelectedObject = info
        _licenseValid = info.State <> LicenseState.Invalid AndAlso info.State <> LicenseState.Expired
    End Sub

    Private Sub btnSetLicense_Click(sender As Object, e As EventArgs)
        ' Register license with provided information
        UR.RegisterLicense(txtLicensee.Text, txtKey.Text)

        UpdateLicenseControls()

        ' Store license information
        Config.Current.Licensee = txtLicensee.Text
        Config.Current.Key = txtKey.Text
        Config.Save()
    End Sub

    Private Sub txtLicenseInfo_LinkClicked(sender As Object, e As LinkClickedEventArgs)
        Process.Start(e.LinkText)
    End Sub
End Class
