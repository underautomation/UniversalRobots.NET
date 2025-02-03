//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Internal;
using License;

namespace UnderAutomation.UniversalRobots {

	public class UR : URServiceBase {


		public UR()
		{
			// Source is hidden, a Source licence is needed to access internal code...
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
		/// Interact with robot via SFTP
		/// </summary>
		public InterpreterModeClientInternal InterpreterMode { get; }

		/// <summary>
		/// Robot IP address, null is robot is disconnected
		/// </summary>
		public string IP { get; }

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
		/// Indicates that at least one of the implemented services is enabled
		/// </summary>
		public bool Enabled { get; }

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
		/// Return information about your license
		/// </summary>
		public static LicenseInfo LicenseInfo { get; }
	}
}
