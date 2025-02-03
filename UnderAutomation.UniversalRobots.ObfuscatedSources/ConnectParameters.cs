//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace UnderAutomation.UniversalRobots {
	/// <summary>
	/// Contains parameters to connect to the robot
	/// </summary>
	public class ConnectParameters {


		public ConnectParameters()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public ConnectParameters(string ip)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public string IP { get; set; }


		public bool PingBeforeConnecting { get; set; }


		public PrimaryInterfaceConnectParameters PrimaryInterface { get; set; }


		public DashboardConnectParameters Dashboard { get; set; }


		public SocketCommunicationConnectParameters SocketCommunication { get; set; }


		public SshConnectParameters Ssh { get; set; }


		public RtdeConnectParameters Rtde { get; set; }


		public XmlRpcConnectParameters XmlRpc { get; set; }


		public InterpreterModeConnectParameters InterpreterMode { get; set; }
	}
}
