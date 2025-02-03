//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Internal;
using XmlRpc;

namespace XmlRpc.Internal {

	public abstract class XmlRpcServerBase : URServiceBase {

		/// <summary>
		/// Event raised when a XML-RPC request is sent by the robot and received.
		/// </summary>
		/// <param name="sender">The UR instance that raised this event</param>
		/// <param name="request">Content of the request</param>
		public delegate void XmlRpcServerRequestEventHandler(object sender, XmlRpcEventArg request);

		/// <summary>
		/// Enable the local XML-RPC server to receive commands from the robot
		/// </summary>
		/// <param name="port">Port number on which the server should start</param>
		public void Start(int port)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Disable and close the socket used for the XML-RPC server
		/// </summary>
		public void Stop()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Is the XML-RPC server enabled
		/// </summary>
		public bool Enabled { get; }

		/// <summary>
		/// Local port on which the XML-RPC server is running. 0 if server is disabled
		/// </summary>
		public int Port { get; }

		/// <summary>
		/// Event raised when a XML-RPC request has been sent from the robot to this machine. You should answer to the robot in this event via the property request.Answer
		/// </summary>
		public event XmlRpcServerBase.XmlRpcServerRequestEventHandler XmlRpcServerRequest;
	}
}
