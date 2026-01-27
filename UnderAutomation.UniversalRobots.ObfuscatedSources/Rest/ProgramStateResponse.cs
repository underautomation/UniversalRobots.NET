//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Rest {
	/// <summary>
	/// Response from GET /program/v1/state endpoint
	/// </summary>
	public class ProgramStateResponse {


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public ProgramStateResponse()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Current state of the program
		/// </summary>
		public RestProgramState State { get; set; }
	}
}
