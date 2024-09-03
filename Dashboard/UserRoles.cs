//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Dashboard {
	/// <summary>
	/// Enumerates all user roles
	/// </summary>
	public enum UserRoles {

		/// <summary>
		/// In Setup Robot, buttons "Update", "Set Password", "Network", "Time" and "URCaps" are disabled, "Expert Mode" is available (if correct password is supplied)
		/// </summary>
		Programmer = 0,

		/// <summary>
		/// Only "RUN Program" And "SHUTDOWN Robot" buttons are enabled, "Expert Mode" cannot be activated
		/// </summary>
		Operator = 1,

		/// <summary>
		/// All buttons enabled, "Expert Mode" is available (if correct password is supplied)
		/// </summary>
		None = 2,

		/// <summary>
		/// All buttons disabled and "Expert Mode" cannot be activated
		/// </summary>
		Locked = 3,

		/// <summary>
		/// Works like "operator" but does not give access to the move tab. (From FW 3.1.17136)
		/// </summary>
		restricted = 4,
	}
}
