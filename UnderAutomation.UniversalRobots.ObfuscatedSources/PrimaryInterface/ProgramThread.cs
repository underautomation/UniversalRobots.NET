//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace PrimaryInterface {
	/// <summary>
	/// Represents a single running thread in a UR program.
	/// </summary>
	public class ProgramThread {


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public ProgramThread()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Current line number being executed in the program.
		/// </summary>
		public int LineNumber { get; set; }

		/// <summary>
		/// Name of the program line being executed.
		/// </summary>
		public string LineName { get; set; }

		/// <summary>
		/// Name of the thread.
		/// </summary>
		public string ThreadName { get; set; }
	}
}
