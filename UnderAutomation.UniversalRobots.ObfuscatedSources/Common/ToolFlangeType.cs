//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.UniversalRobots.Common {
	/// <summary>
	/// Version of the tool flange of a UR robot.
	/// </summary>
	public enum ToolFlangeType {

		/// <summary>
		/// The tool flange version is not known.
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// Tool flange version 1.
		/// </summary>
		V1 = 1,

		/// <summary>
		/// Tool flange version 2 (tool voltage on connector T2, PolyScope X 10.15 and later).
		/// </summary>
		V2 = 2,
	}
}
