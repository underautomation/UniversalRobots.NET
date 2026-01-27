//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Rest {
	/// <summary>
	/// Actions available for changing the robot's operational state via REST API
	/// </summary>
	public enum RobotStateAction {

		/// <summary>
		/// Unlocks the robot from a protective stop state
		/// </summary>
		UNLOCK_PROTECTIVE_STOP = 0,

		/// <summary>
		/// Restarts the safety system
		/// </summary>
		RESTART_SAFETY = 1,

		/// <summary>
		/// Powers off the robot
		/// </summary>
		POWER_OFF = 2,

		/// <summary>
		/// Powers on the robot
		/// </summary>
		POWER_ON = 3,

		/// <summary>
		/// Releases the robot brakes
		/// </summary>
		BRAKE_RELEASE = 4,
	}
}
