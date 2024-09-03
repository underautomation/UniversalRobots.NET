//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using PrimaryInterface.Internal;

namespace Common {
	/// <summary>
	/// Setup Primary Interface Client communication
	/// </summary>
	public class PrimaryInterfaceConnectParameters : PrimaryInterfaceParametersBase {

		/// <summary>
		/// Choose to enable primary interface
		/// Default value is true
		/// </summary>
		public bool Enable { get; set; }
	}
}
