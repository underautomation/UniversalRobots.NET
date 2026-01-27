//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Rest {
	/// <summary>
	/// Program state values returned by the REST API
	/// </summary>
	public enum RestProgramState {

		/// <summary>
		/// Unknown state
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// Program is stopped
		/// </summary>
		Stopped = 1,

		/// <summary>
		/// Program is playing
		/// </summary>
		Playing = 2,

		/// <summary>
		/// Program is paused
		/// </summary>
		Paused = 3,
	}
}
