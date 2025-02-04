//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace PrimaryInterface {
	/// <summary>
	/// Safety internal data
	/// </summary>
	public class SafetyDataPackageEventArgs : PackageEventArgs {


		public SafetyDataPackageEventArgs()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Irrelevent (Internal use only)
		/// </summary>
		public byte[] Data { get; set; }
	}
}
