//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Internal;
using SocketCommunication;

namespace SocketCommunication.Internal {
	/// <summary>
	/// Base for Socket communication server
	/// </summary>
	public class SocketCommunicationServerBase : URServiceBase, ISocketHandler {

		/// <summary>
		/// Event handler of a robot that connects with socket_open()
		/// </summary>
		public delegate void SocketClientConnectionEventHandler(object sender, SocketClientConnectionEventArgs request);

		/// <summary>
		/// Event handler when the robot socket disconnects
		/// </summary>
		public delegate void SocketClientDisconnectionEventHandler(object sender, SocketClientDisconnectionEventArgs request);

		/// <summary>
		/// Event handler of a socket message sent with socket_get_var()
		/// </summary>
		public delegate void SocketGetVarEventHandler(object sender, SocketGetVarEventArgs request);

		/// <summary>
		/// Event handler of a socket message received from robot
		/// </summary>
		public delegate void SocketRequestEventHandler(object sender, SocketRequestEventArgs request);

		/// <summary>
		/// List of all connected clients. One robot can open multiple sockets.
		/// </summary>
		public SocketClient[] ConnectedClients { get; }

		/// <summary>
		/// Starts socket server. Robot can connect with URScript function socket_open()
		/// </summary>
		/// <param name="port">Socket server port</param>
		public void Start(int port)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Is the socket server enabled
		/// </summary>
		public bool Enabled { get; }

		/// <summary>
		/// Socket server local port
		/// </summary>
		public int Port { get; }

		/// <summary>
		/// Event raised when a robot connects with URScript function socket_open()
		/// </summary>
		public event SocketCommunicationServerBase.SocketClientConnectionEventHandler SocketClientConnection;

		/// <summary>
		/// Event raised when the robot calls socket_get_var()
		/// </summary>
		public event SocketCommunicationServerBase.SocketGetVarEventHandler SocketGetVar;

		/// <summary>
		/// Event raised when a message is received from robot
		/// </summary>
		public event SocketCommunicationServerBase.SocketRequestEventHandler SocketRequest;

		/// <summary>
		/// Event raised when the robot socket disconnects
		/// </summary>
		public event SocketCommunicationServerBase.SocketClientDisconnectionEventHandler SocketClientDisconnection;

		/// <summary>
		/// Disable local socket server and disconnect all connected clients
		/// </summary>
		public void Stop()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Write a socket message to the robot. The robot should be connected with socket_open()
		/// </summary>
		/// <param name="message">Message to send to the robot</param>
		public void SocketWrite(string message)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
