//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Common {
	/// <summary>
	/// Safety modes
	/// </summary>
	public enum SafetyStatus : byte {

		/// <summary>
		/// Safety is in normal operating conditions
		/// </summary>
		Normal = 1,

		/// <summary>
		/// Speed is reduced
		/// </summary>
		Reduced = 2,

		/// <summary>
		/// Protective safeguard Stop. This safety function is triggeredby an external protective device using safety inputs which will trigger a Cat 2 stop3per IEC 60204-1.
		/// </summary>
		ProtectiveStop = 3,

		/// <summary>
		/// When a safety limit is violated, the safety system must be restarted.
		/// </summary>
		Recovery = 4,

		/// <summary>
		/// (SI0 + SI1 + SBUS) Physical s-stop interface input
		/// </summary>
		SafeguardStop = 5,

		/// <summary>
		/// (EA + EB + SBUS-&gt;Euromap67) Physical e-stop interface input activated
		/// </summary>
		SystemEmergencyStop = 6,

		/// <summary>
		/// (EA + EB + SBUS-&gt;Screen) Physical e-stop interface input activated
		/// </summary>
		RobotEmergencyStop = 7,

		/// <summary>
		/// Safety is in violation mode (for example, violation of the allowed delay between redundant signals)
		/// </summary>
		Violation = 8,

		/// <summary>
		/// Safety is in fault mode
		/// </summary>
		Fault = 9,


		AutomaticModeSafeguardStop = 10,


		SystemThreePositionEnablingStop = 11,
	}
}
