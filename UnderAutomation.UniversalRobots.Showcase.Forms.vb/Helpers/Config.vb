Imports System.IO
Imports System.Xml.Serialization
Imports UnderAutomation.UniversalRobots

' Save user information in a file next to the main executable
Public Class Config

    Public Shared Property Current As Config = New Config()

    ' Serializer for configuration 
    Private Shared ReadOnly _serializer As XmlSerializer = New XmlSerializer(GetType(Config))

    ' Configuration file
    Private Shared ReadOnly Property Path As String
        Get
            Return $"{GetType(Config).Assembly.Location}.xml"
        End Get
    End Property

    ' Serialize configuration file
    Public Shared Sub Save()
        Try
            Using writer = New StreamWriter(Path)
                _serializer.Serialize(writer, Current)
            End Using

        Catch
        End Try
    End Sub

    ' Deserialize configuration file
    Public Shared Sub Load()
        Try
            If Not File.Exists(Path) Then Return

            Using writer = New StreamReader(Path)
                Current = CType(_serializer.Deserialize(writer), Config)
            End Using

        Catch
        End Try
    End Sub

    Public Property ConnectParameters As ConnectParameters = New ConnectParameters()

#Region "HMI Properties"
    Public Property Licensee As String
    Public Property Key As String
    Public Property LoadProgram As String
    Public Property ShowPopup As String
    Public Property AddToLog As String
    Public Property LoadInstallation As String
    Public Property SftpPath As String
    Public Property URScript As String
#End Region
End Class
