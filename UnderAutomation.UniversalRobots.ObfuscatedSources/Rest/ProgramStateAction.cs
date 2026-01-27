//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Rest {
	/// <summary>
	/// Actions available for changing the program state via REST API
	/// </summary>
	public enum ProgramStateAction {

		/// <summary>
		/// Start or resume playing the program
		/// </summary>
		play = 0,

		/// <summary>
		/// Pause the running program
		/// </summary>
		pause = 1,

		/// <summary>
		/// Stop the running program
		/// </summary>
		stop = 2,

		/// <summary>
		/// Resume a paused program
		/// </summary>
		resume = 3,
	}
}
