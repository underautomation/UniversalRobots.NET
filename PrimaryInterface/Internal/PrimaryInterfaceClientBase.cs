//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Internal;
using System;
using PrimaryInterface;
using Common;
using System.Net;

namespace PrimaryInterface.Internal {

	public class PrimaryInterfaceClientBase : URServiceBase {

		/// <summary>
		/// Robot mode data (Raised every 100ms)
		/// </summary>
		public event EventHandler<RobotModeDataPackageEventArgs> RobotModeDataReceived;

		/// <summary>
		/// Joint data (Raised every 100ms)
		/// </summary>
		public event EventHandler<JointDataPackageEventArgs> JointDataReceived;

		/// <summary>
		/// Tool data (Raised every 100ms)
		/// </summary>
		public event EventHandler<ToolDataPackageEventArgs> ToolDataReceived;

		/// <summary>
		/// Masterboard data (Raised every 100ms)
		/// </summary>
		public event EventHandler<MasterboardDataPackageEventArgs> MasterboardDataReceived;

		/// <summary>
		/// Cartesian inforlation (Raised every 100ms)
		/// </summary>
		public event EventHandler<CartesianInfoPackageEventArgs> CartesianInfoReceived;

		/// <summary>
		/// Kinematics information data (Raised when connection opened)
		/// </summary>
		public event EventHandler<KinematicsInfoPackageEventArgs> KinematicsInfoReceived;

		/// <summary>
		/// Configuration data (Raised when connection opened)
		/// </summary>
		public event EventHandler<ConfigurationDataPackageEventArgs> ConfigurationDataReceived;

		/// <summary>
		/// Force mode data (Raised every 100ms)
		/// </summary>
		public event EventHandler<ForceModeDataPackageEventArgs> ForceModeDataReceived;

		/// <summary>
		/// Additional (Raised every 100ms)
		/// </summary>
		public event EventHandler<AdditionalInfoPackageEventArgs> AdditionalInfoReceived;

		/// <summary>
		/// Calibration data (Raised every 100ms)
		/// </summary>
		public event EventHandler<CalibrationDataPackageEventArgs> CalibrationDataReceived;

		/// <summary>
		/// Safety data (Raised every 100ms)
		/// </summary>
		public event EventHandler<SafetyDataPackageEventArgs> SafetyDataReceived;

		/// <summary>
		/// Tool communication information (Raised every 100ms)
		/// </summary>
		public event EventHandler<ToolCommunicationInfoPackageEventArgs> ToolCommunicationInfoReceived;

		/// <summary>
		/// Tool mode information (Raised every 100ms)
		/// </summary>
		public event EventHandler<ToolModeInfoPackageEventArgs> ToolModeInfoReceived;

		/// <summary>
		/// Singularity information (Raised every 100ms)
		/// </summary>
		public event EventHandler<SingularityInfoPackageEventArgs> SingularityInfoReceived;

		/// <summary>
		/// Generic event raised each time a package is received
		/// </summary>
		public event EventHandler<PackageEventArgs> PackageReceived;

		/// <summary>
		/// Program threads changed
		/// </summary>
		public event EventHandler<ProgramThreadsEventArgs> ProgramThreadsReceived;

		/// <summary>
		/// Robot information and FW version
		/// </summary>
		public event EventHandler<VersionEventArgs> VersionReceived;

		/// <summary>
		/// Internal robot events (such as starting or stopping a program)
		/// </summary>
		public event EventHandler<KeyMessageEventArgs> KeyMessageReceived;

		/// <summary>
		/// Popup message that appears with the Assignment instruction or the URScript popup() function
		/// </summary>
		public event EventHandler<PopupMessageEventArgs> PopupMessageReceived;

		/// <summary>
		/// Log message sent with URScript instruction textmsg()
		/// </summary>
		public event EventHandler<TextMessageEventArgs> TextMessageReceived;

		/// <summary>
		/// Reports an error in the execution of the program
		/// </summary>
		public event EventHandler<RuntimeExceptionMessageEventArgs> RuntimeExceptionMessageReceived;

		/// <summary>
		/// Last Robot mode data received
		/// </summary>
		public RobotModeDataPackageEventArgs RobotModeData { get; }

		/// <summary>
		/// Last joint data received
		/// </summary>
		public JointDataPackageEventArgs JointData { get; }

		/// <summary>
		/// Last tool data received
		/// </summary>
		public ToolDataPackageEventArgs ToolData { get; }

		/// <summary>
		/// Last masterboard data received
		/// </summary>
		public MasterboardDataPackageEventArgs MasterboardData { get; }

		/// <summary>
		/// Last cartesian information received
		/// </summary>
		public CartesianInfoPackageEventArgs CartesianInfo { get; }

		/// <summary>
		/// Last kinematics information received
		/// </summary>
		public KinematicsInfoPackageEventArgs KinematicsInfo { get; }

		/// <summary>
		/// Last configuration data received
		/// </summary>
		public ConfigurationDataPackageEventArgs ConfigurationData { get; }

		/// <summary>
		/// Last force mode data received
		/// </summary>
		public ForceModeDataPackageEventArgs ForceModeData { get; }

		/// <summary>
		/// Last additional information received
		/// </summary>
		public AdditionalInfoPackageEventArgs AdditionalInfo { get; }

		/// <summary>
		/// Last calibration data received
		/// </summary>
		public CalibrationDataPackageEventArgs CalibrationData { get; }

		/// <summary>
		/// Last safety data received
		/// </summary>
		public SafetyDataPackageEventArgs SafetyData { get; }

		/// <summary>
		/// Last tool communication information received
		/// </summary>
		public ToolCommunicationInfoPackageEventArgs ToolCommunicationInfo { get; }

		/// <summary>
		/// Last tool mode information received
		/// </summary>
		public ToolModeInfoPackageEventArgs ToolModeInfo { get; }

		/// <summary>
		/// Last singularity information information received
		/// </summary>
		public SingularityInfoPackageEventArgs SingularityInfo { get; }

		/// <summary>
		/// Last program thread information received
		/// </summary>
		public ProgramThreadsEventArgs ProgramThreads { get; }

		/// <summary>
		/// Version of the robot and FW
		/// </summary>
		public VersionEventArgs Version { get; }

		/// <summary>
		/// Internal robot events (such as starting or stopping a program)
		/// </summary>
		public KeyMessageEventArgs KeyMessage { get; }

		/// <summary>
		/// Popup message that appears with the Assignment instruction or the URScript popup() function
		/// </summary>
		public PopupMessageEventArgs PopupMessage { get; }

		/// <summary>
		/// Log message sent with URScript instruction textmsg()
		/// </summary>
		public TextMessageEventArgs TextMessage { get; }

		/// <summary>
		/// Reports an error in the execution of the program
		/// </summary>
		public RuntimeExceptionMessageEventArgs RuntimeExceptionMessage { get; }

		/// <summary>
		/// List of all variables in current robot program
		/// </summary>
		public GlobalVariables GlobalVariables { get; }

		/// <summary>
		/// Contains methods to send custom URScript to the robot
		/// </summary>
		public PrimaryInterfaceScript Script { get; }

		/// <summary>
		/// Contains methods to send commands to the robot
		/// </summary>
		public PrimaryInterfaceCommands Commands { get; }

		/// <summary>
		/// IP address of the connected robot
		/// </summary>
		public string IP { get; }

		/// <summary>
		/// Interface used for the connected robot
		/// </summary>
		public Interfaces Port { get; }


		protected void InternalConnect(string ip, Interfaces port)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Stops data streaming and the possibility to send scripts to the robot.
		/// </summary>
		public void Disconnect()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Return True if the connection to the robot is active
		/// </summary>
		public bool Connected { get; }

		/// <summary>
		/// Indicates the current local endpoint (i.e. IP Address) used to communicate with the robot. You can use this IP in your UR script in the function rpc_factory()
		/// </summary>
		public IPEndPoint LocalEndPoint { get; }
	}
}
