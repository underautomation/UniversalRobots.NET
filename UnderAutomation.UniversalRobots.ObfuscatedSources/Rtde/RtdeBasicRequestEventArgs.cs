//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace Rtde {
	/// <summary>
	/// Event arguments for a basic RTDE request/response exchange indicating whether the request was accepted by the robot controller.
	/// </summary>
	public class RtdeBasicRequestEventArgs : PackageEventArgs {


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public RtdeBasicRequestEventArgs()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Gets or sets a value indicating whether the request was accepted by the robot.
		/// </summary>
		public bool Accepted { get; set; }
	}
}
