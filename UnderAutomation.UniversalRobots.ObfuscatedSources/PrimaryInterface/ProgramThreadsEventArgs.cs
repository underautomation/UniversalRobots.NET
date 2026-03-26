//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace PrimaryInterface {
	/// <summary>
	/// Event data containing information about currently running program threads.
	/// </summary>
	public class ProgramThreadsEventArgs : PackageEventArgs {


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public ProgramThreadsEventArgs()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Array of currently running program threads.
		/// </summary>
		public ProgramThread[] Threads { get; set; }
	}
}
