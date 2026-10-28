//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.UniversalRobots.Common {
	/// <summary>
	/// Series of a UR robot.
	/// </summary>
	public enum RobotSeries {

		/// <summary>
		/// The series is not known. Returned for a value this SDK does not recognize.
		/// </summary>
		Unknown = -128,

		/// <summary>
		/// CB3 series (UR3, UR5, UR10).
		/// </summary>
		CB3 = 1,

		/// <summary>
		/// e-Series (UR3e, UR5e, UR10e, UR16e...).
		/// </summary>
		ESeries = 2,

		/// <summary>
		/// UR Series (UR15, UR18, UR20, UR30, UR8 Long).
		/// </summary>
		URSeries = 3,

		/// <summary>
		/// G Series (UR10 G 1750, UR17 G 1300, UR18 G 950).
		/// </summary>
		GSeries = 4,
	}
}
