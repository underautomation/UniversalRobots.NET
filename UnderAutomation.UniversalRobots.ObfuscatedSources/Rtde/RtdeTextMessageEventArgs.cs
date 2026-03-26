//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace Rtde {
	/// <summary>
	/// Event arguments for a text message received from the robot via the RTDE interface.
	/// </summary>
	public class RtdeTextMessageEventArgs : PackageEventArgs {


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public RtdeTextMessageEventArgs()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Gets or sets the text content of the message.
		/// </summary>
		public string Message { get; set; }

		/// <summary>
		/// Gets or sets the source module that generated the message on the robot.
		/// </summary>
		public string Source { get; set; }

		/// <summary>
		/// Gets or sets the warning level of the message (0 = exception/error, 1 = warning, 2 = info).
		/// </summary>
		public byte WarningLevel { get; set; }
	}
}
