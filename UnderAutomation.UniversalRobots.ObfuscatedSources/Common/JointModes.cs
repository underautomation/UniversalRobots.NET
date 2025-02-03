//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Common {
	/// <summary>
	/// Joint modes
	/// </summary>
	public enum JointModes : byte {


		ShuttingDown = 236,


		PartDCalibration = 237,


		Backdrive = 238,


		PowerOff = 239,


		NotResponding = 245,


		MotorInitialisation = 246,


		Booting = 247,


		PartDCalibrationError = 248,


		Bootloder = 249,


		Calibration = 250,


		Fault = 252,


		Running = 253,


		Idle = 255,
	}
}
