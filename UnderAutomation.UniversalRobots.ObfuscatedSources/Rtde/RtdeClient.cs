//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Rtde.Internal;

namespace Rtde {
	/// <summary>
	/// Standalone RTDE client for exchanging real-time data with a Universal Robots controller on TCP port 30004.
	/// </summary>
	public class RtdeClient : RtdeClientBase {

		/// <summary>
		/// Static description of all available RTDE output variables.
		/// </summary>
		public static readonly RtdeOutputsDescription AllOutputsDescription;

		/// <summary>
		/// Static description of all available RTDE input variables.
		/// </summary>
		public static readonly RtdeInputsDescription AllInputsDescription;

		/// <summary>
		/// Connects to the robot's RTDE interface, sets up the specified input/output recipes, and starts data streaming.
		/// </summary>
		/// <param name="ip">IP address of the robot.</param>
		/// <param name="outputSetup">Output variables to subscribe to (robot-to-client).</param>
		/// <param name="inputSetup">Input variables to write (client-to-robot).</param>
		/// <param name="version">Preferred RTDE protocol version.</param>
		/// <param name="frequency">Desired output data frequency in Hz (RTDE v2 only).</param>
		/// <param name="port">TCP port. Default is 30004.</param>
		public void Connect(string ip, RtdeOutputSetup outputSetup, RtdeInputSetup inputSetup, RtdeVersions version, double frequency, int port = 30004)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public RtdeClient()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
