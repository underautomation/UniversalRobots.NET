//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace SocketCommunication {
	/// <summary>
	/// Event args raised when a socket message is received
	/// </summary>
	public class SocketRequestEventArgs : EventArgs {

		/// <summary>
		/// Message content received from robot
		/// </summary>
		public readonly string Message;

		/// <summary>
		/// Robot IP information
		/// </summary>
		public readonly SocketClient Client;
	}
}
