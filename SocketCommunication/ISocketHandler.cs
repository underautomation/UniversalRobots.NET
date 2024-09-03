//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using SocketCommunication.Internal;

namespace SocketCommunication {
	/// <summary>
	/// Interface for classes that support socket messages
	/// </summary>
	public interface ISocketHandler {

		/// <summary>
		/// Event raised when the robot calls socket_get_var()
		/// </summary>
		event SocketCommunicationServerBase.SocketGetVarEventHandler SocketGetVar;

		/// <summary>
		/// Event raised when a message is received from robot
		/// </summary>
		event SocketCommunicationServerBase.SocketRequestEventHandler SocketRequest;

		/// <summary>
		/// Event raised when the robot socket disconnects
		/// </summary>
		event SocketCommunicationServerBase.SocketClientDisconnectionEventHandler SocketClientDisconnection;

		/// <summary>
		/// Write a socket message to the robot. The robot should be connected with socket_open()
		/// </summary>
		/// <param name="message">Message to send to the robot</param>
		void SocketWrite(string message)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
