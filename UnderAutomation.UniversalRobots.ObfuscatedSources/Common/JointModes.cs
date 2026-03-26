//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Common {
	/// <summary>
	/// Joint modes
	/// </summary>
	public enum JointModes : byte {

		/// <summary>
		/// Joint is shutting down.
		/// </summary>
		ShuttingDown = 236,

		/// <summary>
		/// Joint is in part D calibration mode.
		/// </summary>
		PartDCalibration = 237,

		/// <summary>
		/// Joint is in backdrive mode.
		/// </summary>
		Backdrive = 238,

		/// <summary>
		/// Joint is powered off.
		/// </summary>
		PowerOff = 239,

		/// <summary>
		/// Joint is not responding.
		/// </summary>
		NotResponding = 245,

		/// <summary>
		/// Joint motor is initializing.
		/// </summary>
		MotorInitialisation = 246,

		/// <summary>
		/// Joint is booting.
		/// </summary>
		Booting = 247,

		/// <summary>
		/// Joint part D calibration encountered an error.
		/// </summary>
		PartDCalibrationError = 248,

		/// <summary>
		/// Joint is in bootloader mode.
		/// </summary>
		Bootloader = 249,

		/// <summary>
		/// Joint is calibrating.
		/// </summary>
		Calibration = 250,

		/// <summary>
		/// Joint is in a fault state.
		/// </summary>
		Fault = 252,

		/// <summary>
		/// Joint is running normally.
		/// </summary>
		Running = 253,

		/// <summary>
		/// Joint is idle.
		/// </summary>
		Idle = 255,
	}
}
