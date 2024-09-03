//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace InterpreterMode {
	/// <summary>
	/// Type of response of an Interpreter Mode command
	/// </summary>
	public enum CommandResponseStatus {

		/// <summary>
		/// Something went wrong when receiving response
		/// </summary>
		Error = -1,

		/// <summary>
		/// The command compilation succeed and Interpreter mode will execute the statement
		/// </summary>
		Ack = 0,

		/// <summary>
		/// Program is not running or the statement results in a compilation or linker error
		/// </summary>
		Discard = 1,

		/// <summary>
		/// Answer from a state command
		/// </summary>
		State = 2,
	}
}
