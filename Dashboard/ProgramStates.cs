//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Dashboard {
	/// <summary>
	/// Enumerate possible states of a program.
	/// </summary>
	public enum ProgramStates {

		/// <summary>
		/// No program is running.
		/// </summary>
		Stopped = 0,

		/// <summary>
		/// Program is running.
		/// </summary>
		Playing = 1,

		/// <summary>
		/// Program is paused.
		/// </summary>
		Paused = 2,
	}
}
