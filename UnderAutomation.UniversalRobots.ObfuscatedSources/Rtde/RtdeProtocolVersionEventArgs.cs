//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Rtde {
	/// <summary>
	/// Event arguments indicating which RTDE protocol version was negotiated with the robot.
	/// </summary>
	public class RtdeProtocolVersionEventArgs : RtdeBasicRequestEventArgs {


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public RtdeProtocolVersionEventArgs()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Gets or sets the negotiated RTDE protocol version.
		/// </summary>
		public RtdeVersions Version { get; set; }
	}
}
