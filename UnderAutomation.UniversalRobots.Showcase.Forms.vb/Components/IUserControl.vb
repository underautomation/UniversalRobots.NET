Imports System.Windows.Forms

Friend Interface IUserControl
    Inherits IContainerControl
    ' Title of the user control
    ReadOnly Property Title As String

    ' Indicates if the feature shown is enabled
    ReadOnly Property FeatureEnabled As Boolean

    ' Called periodically in GUI thread
    Sub PeriodicUpdate()

    ' Called when the control is displayed
    Sub OnOpen()

    ' Called when the control is replaced by another
    Sub OnClose()

End Interface
