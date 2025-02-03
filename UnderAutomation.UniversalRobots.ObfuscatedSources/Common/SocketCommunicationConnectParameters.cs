//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using SocketCommunication.Internal;

namespace Common {
	/// <summary>
	/// Setup socket communication server
	/// </summary>
	public class SocketCommunicationConnectParameters : SocketCommunicationParametersBase {

		/// <summary>
		/// Choose to enable socket communication server
		/// Default value is false
		/// </summary>
		public bool Enable { get; set; }
	}
}
