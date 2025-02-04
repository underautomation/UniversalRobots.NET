//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Common {
	/// <summary>
	/// Describes a global variable
	/// </summary>
	public class GlobalVariable : GlobalVariableValue {


		public GlobalVariable()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Variable name
		/// </summary>
		public string Name { get; }

		/// <summary>
		/// Last time the variable was sampled
		/// </summary>
		public TimeSpan Time { get; }
	}
}
