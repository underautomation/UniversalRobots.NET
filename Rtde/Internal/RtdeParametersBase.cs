//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Rtde;

namespace Rtde.Internal {
	/// <summary>
	/// Base parameters to set up RTDE
	/// </summary>
	public abstract class RtdeParametersBase {

		/// <summary>
		/// For RTDE version 2, you can specify a frequency for output received data. Maximum frequency depends on your robot version.
		/// If you set frequency to 0, maximum frequency will be choosen
		/// Default value is 10Hz
		/// </summary>
		public double Frequency { get; set; }

		/// <summary>
		/// RTDE version. If set to Auto, the most recent version will be choosen according to your robot version
		/// Default value is V2
		/// </summary>
		public RtdeVersions Version { get; set; }

		/// <summary>
		/// List of all output data the robot will send to your application
		/// </summary>
		public RtdeOutputSetup OutputSetup { get; set; }

		/// <summary>
		/// List of all input data you can send to the robot
		/// </summary>
		public RtdeInputSetup InputSetup { get; set; }

		/// <summary>
		/// Default RTDE TCP port used (30004)
		/// </summary>
		public const int DEFAULT_PORT = 30004;

		/// <summary>
		/// TCP port used for RTDE connection. Default : 30004
		/// </summary>
		public int Port { get; set; }
	}
}
