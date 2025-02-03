//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.Net;
using SocketCommunication.Internal;

namespace SocketCommunication {
	/// <summary>
	/// Represent a UR robot connected with URScript function socket_open()
	/// </summary>
	public class SocketClient : ISocketHandler {

		/// <summary>
		/// IP address and remote port used by the robot for socket communication
		/// </summary>
		public readonly IPEndPoint EndPoint;

		/// <summary>
		/// Event raised when the robot calls socket_get_var()
		/// </summary>
		public event SocketCommunicationServerBase.SocketGetVarEventHandler SocketGetVar;

		/// <summary>
		/// Event raised when a message is received from robot
		/// </summary>
		public event SocketCommunicationServerBase.SocketRequestEventHandler SocketRequest;

		/// <summary>
		/// Event handler when the robot socket disconnects
		/// </summary>
		public event SocketCommunicationServerBase.SocketClientDisconnectionEventHandler SocketClientDisconnection;

		/// <summary>
		/// Indicates that robot socket is still active
		/// </summary>
		public bool Connected { get; }

		/// <summary>
		/// Closes socket communication to robot
		/// </summary>
		public void Disconnect()
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
