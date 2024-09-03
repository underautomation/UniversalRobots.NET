//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace SocketCommunication {
	/// <summary>
	/// Event args raised when a socket client is connected with socket_open()
	/// </summary>
	public class SocketClientConnectionEventArgs : EventArgs {

		/// <summary>
		/// Robot remote endpoint
		/// </summary>
		public readonly SocketClient Client;
	}
}
