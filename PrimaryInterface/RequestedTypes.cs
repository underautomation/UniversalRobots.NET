//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace PrimaryInterface {
	/// <summary>
	/// Types for popup assignment
	/// </summary>
	public enum RequestedTypes {

		/// <summary>
		/// Popup for boolean value assignment
		/// </summary>
		Boolean = 0,

		/// <summary>
		/// Popup for integer number value assignment
		/// </summary>
		Integer = 1,

		/// <summary>
		/// Popup for float number value assignment
		/// </summary>
		Float = 2,

		/// <summary>
		/// Popup for string value assignment
		/// </summary>
		String = 3,

		/// <summary>
		/// Popup for pose value assignment
		/// </summary>
		Pose = 4,

		/// <summary>
		/// Popup for joint vector value assignment
		/// </summary>
		JointVector = 5,

		/// <summary>
		/// Unused
		/// </summary>
		Waypoint = 6,

		/// <summary>
		/// Unused
		/// </summary>
		Expression = 7,

		/// <summary>
		/// It's a simple popup message
		/// </summary>
		None = 8,
	}
}
