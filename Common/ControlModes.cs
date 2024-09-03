//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Common {
	/// <summary>
	/// Robot control modes
	/// </summary>
	public enum ControlModes {

		/// <summary>
		/// Robot is position controlled
		/// </summary>
		Position = 0,

		/// <summary>
		/// The robot is hand guided  by pushing teached button
		/// </summary>
		Teach = 1,

		/// <summary>
		/// Robot is force controlled. (For example : URScript force_mode() function is called)
		/// </summary>
		Force = 2,

		/// <summary>
		/// Robot is torque controlled
		/// </summary>
		Torque = 3,
	}
}
