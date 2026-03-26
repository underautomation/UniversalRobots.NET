//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Common {
	/// <summary>
	/// Describes a global variable
	/// </summary>
	public class GlobalVariable : GlobalVariableValue {

		/// <summary>
		/// Returns the variable name followed by its string representation.
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Determines whether the specified object is a <xref href="UnderAutomation.UniversalRobots.Common.GlobalVariable" data-throw-if-not-resolved="false"></xref> with the same name, type, and value.
		/// </summary>
		public override bool Equals(object obj)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Returns a hash code based on the variable name, type, and value.
		/// </summary>
		public override int GetHashCode()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


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
