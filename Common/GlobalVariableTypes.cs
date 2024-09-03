//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Common {
	/// <summary>
	/// Possible types of a variable
	/// </summary>
	public enum GlobalVariableTypes {

		/// <summary>
		/// Variable value is null, the value has not been assigned yet
		/// </summary>
		None = 0,

		/// <summary>
		/// Variable value is a System.String
		/// </summary>
		String = 1,

		/// <summary>
		/// Variable value is an array : GlobalVariableValue[]
		/// </summary>
		List = 2,

		/// <summary>
		/// Variable value is a UnderAutomation.UniversalRobots.Pose
		/// </summary>
		Pose = 3,

		/// <summary>
		/// Variable value is bool
		/// </summary>
		Bool = 4,

		/// <summary>
		/// Variable value is int
		/// </summary>
		Int = 5,

		/// <summary>
		/// Variable value is float
		/// </summary>
		Float = 6,

		/// <summary>
		/// Variable value is a matrix
		/// </summary>
		Matrix = 7,
	}
}
