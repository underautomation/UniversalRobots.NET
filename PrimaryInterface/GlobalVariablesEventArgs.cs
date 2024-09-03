//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace PrimaryInterface {
	/// <summary>
	/// Event args of variable update events
	/// </summary>
	public class GlobalVariablesEventArgs : EventArgs {

		/// <summary>
		/// New list of all up to date variables
		/// </summary>
		public GlobalVariable[] Variables { get; }
	}
}
