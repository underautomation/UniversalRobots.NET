//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Rtde.Internal;
using Rtde;

namespace Internal {
	/// <summary>
	/// Internal implementation of the Real-Time Data Exchange (RTDE) client that delegates connection to the parent <xref href="UnderAutomation.UniversalRobots.UR" data-throw-if-not-resolved="false"></xref> instance.
	/// </summary>
	public class RtdeClientInternal : RtdeClientBase {

		/// <summary>
		/// Connects to the RTDE interface on the robot controller.
		/// </summary>
		/// <param name="outputSetup">Configuration for RTDE output subscriptions.</param>
		/// <param name="inputSetup">Configuration for RTDE input registers.</param>
		/// <param name="version">RTDE protocol version to negotiate.</param>
		/// <param name="frequency">Output data frequency in Hz.</param>
		/// <param name="port">TCP port of the RTDE server.</param>
		public void Connect(RtdeOutputSetup outputSetup, RtdeInputSetup inputSetup, RtdeVersions version, double frequency, int port)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
