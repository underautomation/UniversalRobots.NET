//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace UnderAutomation.UniversalRobots {
	/// <summary>
	/// Contains parameters to connect to the robot
	/// </summary>
	public class ConnectParameters {

		/// <summary>
		/// Initializes a new instance of <xref href="UnderAutomation.UniversalRobots.ConnectParameters" data-throw-if-not-resolved="false"></xref> with default values.
		/// </summary>
		public ConnectParameters()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Initializes a new instance of <xref href="UnderAutomation.UniversalRobots.ConnectParameters" data-throw-if-not-resolved="false"></xref> with the specified robot IP address.
		/// </summary>
		/// <param name="ip">The IP address of the Universal Robots controller.</param>
		public ConnectParameters(string ip)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns a string representation containing the robot IP address.
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// IP address of the Universal Robots controller.
		/// </summary>
		public string IP { get; set; }

		/// <summary>
		/// If <code>true</code>, a ping is sent to the robot before attempting connection. Default is <code>true</code>.
		/// </summary>
		public bool PingBeforeConnecting { get; set; }

		/// <summary>
		/// Primary Interface connection parameters (port 30001/30002).
		/// </summary>
		public PrimaryInterfaceConnectParameters PrimaryInterface { get; set; }

		/// <summary>
		/// Dashboard Server connection parameters (port 29999).
		/// </summary>
		public DashboardConnectParameters Dashboard { get; set; }

		/// <summary>
		/// Socket communication connection parameters for exchanging data with URScript programs.
		/// </summary>
		public SocketCommunicationConnectParameters SocketCommunication { get; set; }

		/// <summary>
		/// SSH and SFTP connection parameters for file transfer and remote shell access.
		/// </summary>
		public SshConnectParameters Ssh { get; set; }

		/// <summary>
		/// Real-Time Data Exchange (RTDE) connection parameters (port 30004).
		/// </summary>
		public RtdeConnectParameters Rtde { get; set; }

		/// <summary>
		/// XML-RPC connection parameters for remote procedure calls.
		/// </summary>
		public XmlRpcConnectParameters XmlRpc { get; set; }

		/// <summary>
		/// Interpreter Mode connection parameters for sending URScript lines interactively.
		/// </summary>
		public InterpreterModeConnectParameters InterpreterMode { get; set; }

		/// <summary>
		/// REST API connection parameters (PolyscopeX only)
		/// </summary>
		public RestConnectParameters Rest { get; set; }
	}
}
