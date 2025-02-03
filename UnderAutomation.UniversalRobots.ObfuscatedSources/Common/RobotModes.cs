//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Common {
	/// <summary>
	/// Robot running modes
	/// </summary>
	public enum RobotModes {

		/// <summary>
		/// Robot is in an obsolete CB2 mode
		/// </summary>
		Other = -1,

		/// <summary>
		/// Robot is not connected to its controller
		/// </summary>
		Disconnected = 0,

		/// <summary>
		/// Robot has stopped due to a Safety Stop
		/// </summary>
		ConfirmSafety = 1,

		/// <summary>
		/// The robot controller is booting
		/// </summary>
		Booting = 2,

		/// <summary>
		/// The robot is powered off
		/// </summary>
		PowerOff = 3,

		/// <summary>
		/// The robot is powered on
		/// </summary>
		PowerOn = 4,

		/// <summary>
		/// Power is on but breaks are not released
		/// </summary>
		Idle = 5,

		/// <summary>
		/// The robot is hand guided  by pushing teached button
		/// </summary>
		BackDrive = 6,

		/// <summary>
		/// Robot is in normal mode
		/// </summary>
		Running = 7,

		/// <summary>
		/// Firmware is upgrading
		/// </summary>
		UpdatingFirmware = 8,
	}
}
