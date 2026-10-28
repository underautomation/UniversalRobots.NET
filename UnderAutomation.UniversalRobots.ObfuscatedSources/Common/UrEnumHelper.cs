//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.UniversalRobots.Common {
	/// <summary>
	/// Conversions from the raw numbers sent by a robot to the enums of the SDK.
	/// An unknown number never throws: the result is the Unknown value of the enum.
	/// </summary>
	public static class UrEnumHelper {

		/// <summary>
		/// Converts a raw robot model number to <see cref="UnderAutomation.UniversalRobots.Common.RobotModels"/>.
		/// </summary>
		/// <param name="value">Raw robot model number.</param>
		/// <returns>The model, or <see cref="UnderAutomation.UniversalRobots.Common.RobotModels.Unknown"/> if the number is not known.</returns>
		public static RobotModels RobotModelFromValue(int value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Converts a raw robot mode number to <see cref="UnderAutomation.UniversalRobots.Common.RobotModes"/>.
		/// </summary>
		/// <param name="value">Raw robot mode number.</param>
		/// <returns>The mode, or <see cref="UnderAutomation.UniversalRobots.Common.RobotModes.Unknown"/> if the number is not known.</returns>
		public static RobotModes RobotModeFromValue(int value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Converts a raw safety mode number to <see cref="UnderAutomation.UniversalRobots.Common.SafetyModes"/>.
		/// </summary>
		/// <param name="value">Raw safety mode number.</param>
		/// <returns>The safety mode, or <see cref="UnderAutomation.UniversalRobots.Common.SafetyModes.Unknown"/> if the number is not known.</returns>
		public static SafetyModes SafetyModeFromValue(int value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Converts a raw robot series number to <see cref="UnderAutomation.UniversalRobots.Common.RobotSeries"/>.
		/// </summary>
		/// <param name="value">Raw series number: 1 for CB3, 2 for e-Series, 3 for UR Series, 4 for G Series.</param>
		/// <returns>The series, or <see cref="UnderAutomation.UniversalRobots.Common.RobotSeries.Unknown"/> if the number is not known.</returns>
		public static RobotSeries RobotSeriesFromValue(int value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Finds the series of a robot from its model and its software version.
		/// </summary>
		/// <param name="model">Robot model.</param>
		/// <param name="softwareMajor">Major version of the software (3 or 5 for PolyScope, 10 for PolyScope X).</param>
		/// <param name="softwareMinor">Minor version of the software.</param>
		/// <returns>The series, or <see cref="UnderAutomation.UniversalRobots.Common.RobotSeries.Unknown"/> if the model and the version do not match a series.</returns>
		public static RobotSeries RobotSeriesFromModel(RobotModels model, int softwareMajor, int softwareMinor)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Converts a raw control box number to <see cref="UnderAutomation.UniversalRobots.Common.ControlBoxType"/>.
		/// Both numberings sent by the robots are accepted: 1 and 5 mean CB5, 2 and 7 mean CB7.
		/// </summary>
		/// <param name="value">Raw control box number.</param>
		/// <returns>The control box type, or <see cref="UnderAutomation.UniversalRobots.Common.ControlBoxType.Unknown"/> if the number is not known.</returns>
		public static ControlBoxType ControlBoxTypeFromValue(int value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Converts a raw tool flange number to <see cref="UnderAutomation.UniversalRobots.Common.ToolFlangeType"/>.
		/// </summary>
		/// <param name="value">Raw tool flange number: 1 for V1, 2 for V2.</param>
		/// <returns>The tool flange type, or <see cref="UnderAutomation.UniversalRobots.Common.ToolFlangeType.Unknown"/> if the number is not known.</returns>
		public static ToolFlangeType ToolFlangeTypeFromValue(int value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Tells if the safety mode is a protective, safeguard or enabling device stop.
		/// Emergency stops, faults and violations are not included.
		/// </summary>
		/// <param name="mode">Safety mode.</param>
		/// <returns>True if the robot is stopped by a protective, safeguard or enabling device stop.</returns>
		public static bool IsProtectiveStopped(SafetyModes mode)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Tells if the safety mode lets the robot move and run a program: Normal or Reduced.
		/// </summary>
		/// <param name="mode">Safety mode.</param>
		/// <returns>True for <see cref="UnderAutomation.UniversalRobots.Common.SafetyModes.Normal"/> and <see cref="UnderAutomation.UniversalRobots.Common.SafetyModes.Reduced"/>.</returns>
		public static bool SafetyModeAllowsExecution(SafetyModes mode)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
