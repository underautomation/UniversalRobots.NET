//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace InterpreterMode {
	/// <summary>
	/// Response to an Interpreter Mode command
	/// </summary>
	public class CommandResponse {

		/// <summary>
		/// Response type to check if command succeed
		/// </summary>
		public CommandResponseStatus Status { get; }

		/// <summary>
		/// Command unique identifier
		/// </summary>
		public int Id { get; }

		/// <summary>
		/// Answer from the interpreter mode
		/// </summary>
		public string Body { get; }

		/// <summary>
		/// Raw line sent from the controller
		/// </summary>
		public string RawAnswer { get; }

		/// <summary>
		/// Command sent to the interpreter mode
		/// </summary>
		public string Command { get; }


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
