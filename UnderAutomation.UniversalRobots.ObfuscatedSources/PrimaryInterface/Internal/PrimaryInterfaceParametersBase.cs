//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using PrimaryInterface;

namespace PrimaryInterface.Internal {
	/// <summary>
	/// Parameters to setup a Primary/secondary interface connection
	/// </summary>
	public abstract class PrimaryInterfaceParametersBase {

		/// <summary>
		/// Interface on which to connect
		/// </summary>
		public Interfaces Port { get; set; }
	}
}
