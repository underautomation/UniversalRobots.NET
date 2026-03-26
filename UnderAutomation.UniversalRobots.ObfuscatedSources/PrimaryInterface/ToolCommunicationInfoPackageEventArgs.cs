//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace PrimaryInterface {
	/// <summary>
	/// Tool communication info
	/// </summary>
	public class ToolCommunicationInfoPackageEventArgs : PackageEventArgs {

		/// <summary>
		/// Returns a string representation of the tool communication info.
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public ToolCommunicationInfoPackageEventArgs()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Is the tool communication interface enabled
		/// </summary>
		[PackageDescription("Is the tool communication interface enabled")]
public bool ToolCommunicationIsEnabled { get; set; }

		/// <summary>
		/// Baud rate for tool serial communication
		/// </summary>
		[PackageDescription("Baud rate")]
public int BaudRate { get; set; }

		/// <summary>
		/// Parity
		/// </summary>
		[PackageDescription("Parity")]
public int Parity { get; set; }

		/// <summary>
		/// Stop bits
		/// </summary>
		[PackageDescription("Stop bits")]
public int StopBits { get; set; }

		/// <summary>
		/// RX Idle Chars
		/// </summary>
		[PackageDescription("RX Idle Chars")]
public float RxIdleChars { get; set; }

		/// <summary>
		/// TX Idle Chars
		/// </summary>
		[PackageDescription("TX Idle Chars")]
public float TxIdleChars { get; set; }
	}
}
