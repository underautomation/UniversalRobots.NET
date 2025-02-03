//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace SocketCommunication {
	/// <summary>
	/// Event args raised when a socket message sent with socket_get_var() is received
	/// </summary>
	public class SocketGetVarEventArgs : EventArgs {

		/// <summary>
		/// Robot remote endpoint
		/// </summary>
		public readonly SocketClient Client;

		/// <summary>
		/// Name of requested variable
		/// </summary>
		public readonly string Name;

		/// <summary>
		/// Variable value to send to the robot. If value is null, no messsage is replied to the robot
		/// </summary>
		public int? Value;
	}
}
