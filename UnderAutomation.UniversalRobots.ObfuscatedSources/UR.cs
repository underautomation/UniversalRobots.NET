//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Internal;
using License;

namespace UnderAutomation.UniversalRobots {
	/// <summary>
	/// Main entry point for connecting to and interacting with a Universal Robots controller.
	/// Provides access to all communication interfaces: Primary Interface, Dashboard, RTDE, SSH, SFTP, XML-RPC, Socket Communication, Interpreter Mode, and REST API.
	/// </summary>
	public class UR : URServiceBase {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.UniversalRobots.UR" data-throw-if-not-resolved="false"></xref> class and creates all communication clients.
		/// </summary>
		public UR()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Connects to a robot with default parameters
		/// </summary>
		/// <param name="ip">Robot IP address</param>
		public void Connect(string ip)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Connects to a robot with specific parameters
		/// </summary>
		/// <param name="parameters">Connection parameters</param>
		public void Connect(ConnectParameters parameters)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Disconnects all clients and disable all services
		/// </summary>
		public void Disconnect()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// If you have a license and a key, please call this static method to register the product and exit the trial period
		/// You can register a product even if the trial period has ended
		/// </summary>
		/// <param name="licensee">Your organization name</param>
		/// <param name="key">The associated key supplied by UnderAutomation</param>
		/// <returns>Information about the supplied license</returns>
		public static LicenseInfo RegisterLicense(string licensee, string key)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Interact with robot via Primary Interface
		/// </summary>
		public PrimaryInterfaceClientInternal PrimaryInterface { get; }

		/// <summary>
		/// Interact with robot via XML-RPC
		/// </summary>
		public XmlRpcServerInternal XmlRpc { get; }

		/// <summary>
		/// Interact with robot via Dashboard
		/// </summary>
		public DashboardClientInternal Dashboard { get; }

		/// <summary>
		/// Interact with robot via Socket communication
		/// </summary>
		public SocketCommunicationServerInternal SocketCommunication { get; }

		/// <summary>
		/// Interact with robot via RTDE
		/// </summary>
		public RtdeClientInternal Rtde { get; }

		/// <summary>
		/// Interact with robot via SSH
		/// </summary>
		public SshClientInternal Ssh { get; }

		/// <summary>
		/// Interact with robot via SFTP
		/// </summary>
		public SftpClientInternal Sftp { get; }

		/// <summary>
		/// Interact with robot via Interpreter Mode
		/// </summary>
		public InterpreterModeClientInternal InterpreterMode { get; }

		/// <summary>
		/// Interact with robot via REST API (PolyscopeX only)
		/// </summary>
		public RestClientInternal Rest { get; }

		/// <summary>
		/// Robot IP address, null is robot is disconnected
		/// </summary>
		public string IP { get; }

		/// <summary>
		/// Indicates that at least one of the implemented services is enabled
		/// </summary>
		public bool Enabled { get; }

		/// <summary>
		/// Return information about your license
		/// </summary>
		public static LicenseInfo LicenseInfo { get; }
	}
}
