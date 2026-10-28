//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.UniversalRobots.Common {
	/// <summary>
	/// Safety modes of a UR robot.
	/// </summary>
	public enum SafetyModes {

		/// <summary>
		/// The safety mode is not known. Returned for a value this SDK does not recognize.
		/// </summary>
		Unknown = -128,

		/// <summary>
		/// Normal operation.
		/// </summary>
		Normal = 1,

		/// <summary>
		/// Reduced mode: speed and force limits are lower.
		/// </summary>
		Reduced = 2,

		/// <summary>
		/// Protective stop.
		/// </summary>
		ProtectiveStop = 3,

		/// <summary>
		/// Recovery mode after a safety limit violation.
		/// </summary>
		Recovery = 4,

		/// <summary>
		/// Safeguard stop.
		/// </summary>
		SafeguardStop = 5,

		/// <summary>
		/// System emergency stop.
		/// </summary>
		SystemEmergencyStop = 6,

		/// <summary>
		/// Robot emergency stop.
		/// </summary>
		RobotEmergencyStop = 7,

		/// <summary>
		/// Safety violation.
		/// </summary>
		Violation = 8,

		/// <summary>
		/// Safety fault.
		/// </summary>
		Fault = 9,

		/// <summary>
		/// The safety system validates the joint identification.
		/// </summary>
		ValidateJointId = 10,

		/// <summary>
		/// Undefined safety mode.
		/// </summary>
		UndefinedSafetyMode = 11,

		/// <summary>
		/// Safeguard stop in automatic mode.
		/// </summary>
		AutomaticModeSafeguardStop = 12,

		/// <summary>
		/// System three-position enabling device stop.
		/// </summary>
		SystemThreePositionEnablingStop = 13,

		/// <summary>
		/// Teach pendant three-position enabling device stop.
		/// </summary>
		TpThreePositionEnablingStop = 14,

		/// <summary>
		/// Emergency stop from the IMMI interface.
		/// </summary>
		ImmiEmergencyStop = 15,

		/// <summary>
		/// Safeguard stop from the IMMI interface.
		/// </summary>
		ImmiSafeguardStop = 16,

		/// <summary>
		/// PROFIsafe is waiting for its parameters.
		/// </summary>
		ProfisafeWaitingForParameters = 17,

		/// <summary>
		/// PROFIsafe safeguard stop in automatic mode.
		/// </summary>
		ProfisafeAutomaticModeSafeguardStop = 18,

		/// <summary>
		/// PROFIsafe safeguard stop.
		/// </summary>
		ProfisafeSafeguardStop = 19,

		/// <summary>
		/// PROFIsafe emergency stop.
		/// </summary>
		ProfisafeEmergencyStop = 20,

		/// <summary>
		/// Safeguard stop requested through the safety API.
		/// </summary>
		SafetyApiSafeguardStop = 22,
	}
}
