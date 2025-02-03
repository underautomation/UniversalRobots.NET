//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Dashboard {
	/// <summary>
	/// Enumerates all robot operational modes
	/// </summary>
	public enum OperationalModes {

		/// <summary>
		/// Loading and editing programs is allowed
		/// </summary>
		Manual = 0,

		/// <summary>
		/// Loading and editing programs and installations is not allowed, only playing programs
		/// </summary>
		Automatic = 1,

		/// <summary>
		/// The password has not been set.
		/// </summary>
		None = 2,
	}
}
