//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace PrimaryInterface.Internal {
	/// <summary>
	/// Event args for raw package received
	/// </summary>
	public class RawPackageReceivedEventArgs : PackageEventArgs {

		/// <summary>
		/// Initializes a new instance with the raw packet data, receive timestamp, and package type.
		/// </summary>
		/// <param name="data">Full raw packet bytes including header.</param>
		/// <param name="receiveDate">UTC timestamp when the packet was received.</param>
		/// <param name="type">Primary Interface package type identifier byte.</param>
		public RawPackageReceivedEventArgs(byte[] data, DateTime receiveDate, byte type)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Full raw packet data (including header)
		/// </summary>
		public byte[] Data { get; }

		/// <summary>
		/// Package Type
		/// </summary>
		public byte Type { get; }
	}
}
