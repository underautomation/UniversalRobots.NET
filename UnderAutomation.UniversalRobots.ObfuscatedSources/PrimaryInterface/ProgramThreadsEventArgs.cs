//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace PrimaryInterface {
	/// <summary>
	/// Program threads
	/// </summary>
	public class ProgramThreadsEventArgs : PackageEventArgs {


		public ProgramThreadsEventArgs()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public ProgramThread[] Threads { get; set; }
	}
}
