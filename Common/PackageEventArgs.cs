//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Common {
	/// <summary>
	/// Base class of all received data packages
	/// </summary>
	public abstract class PackageEventArgs : EventArgs {

		/// <summary>
		/// The date the data has been received
		/// </summary>
		public DateTime ReceiveDate;
	}
}
