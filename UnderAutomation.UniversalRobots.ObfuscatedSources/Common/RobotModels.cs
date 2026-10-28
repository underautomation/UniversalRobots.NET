//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.UniversalRobots.Common {
	/// <summary>
	/// Model of a UR robot
	/// </summary>
	public enum RobotModels {

		/// <summary>
		/// UR5 robot model.
		/// </summary>
		UR5 = 1,

		/// <summary>
		/// UR10 robot model.
		/// </summary>
		UR10 = 2,

		/// <summary>
		/// UR3 robot model.
		/// </summary>
		UR3 = 3,

		/// <summary>
		/// UR16 robot model.
		/// </summary>
		UR16 = 4,

		/// <summary>
		/// UR20 robot model.
		/// </summary>
		UR20 = 7,

		/// <summary>
		/// UR30 robot model.
		/// </summary>
		UR30 = 8,

		/// <summary>
		/// UR8 Long robot model.
		/// </summary>
		UR8L = 6,

		/// <summary>
		/// UR18 robot model.
		/// </summary>
		UR18 = 5,

		/// <summary>
		/// UR15 robot model.
		/// </summary>
		UR15 = 9,

		/// <summary>
		/// UR10 G 1750 robot model (G Series).
		/// </summary>
		UR10G1750 = 12,

		/// <summary>
		/// UR17 G 1300 robot model (G Series).
		/// </summary>
		UR17G1300 = 13,

		/// <summary>
		/// UR18 G 950 robot model (G Series).
		/// </summary>
		UR18G950 = 14,

		/// <summary>
		/// The model is not known. Returned by <see cref="UnderAutomation.UniversalRobots.Common.UrEnumHelper.RobotModelFromValue(System.Int32)"/> for a value this SDK does not recognize.
		/// </summary>
		Unknown = -128,
	}
}
