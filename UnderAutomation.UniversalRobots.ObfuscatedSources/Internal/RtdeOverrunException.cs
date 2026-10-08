//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.Runtime.Serialization;

namespace UnderAutomation.UniversalRobots.Internal {
	/// <summary>
	/// Exception thrown when RTDE data cannot be consumed fast enough, causing the input buffer to fill up.
	/// This typically occurs when the <code>OutputDataReceived</code> event handler takes longer to execute than the interval between RTDE messages.
	/// </summary>
	public class RtdeOverrunException : Exception, ISerializable {

		/// <summary>
		/// Initializes a new instance of the <see cref="UnderAutomation.UniversalRobots.Internal.RtdeOverrunException"/> class with a default diagnostic message.
		/// </summary>
		public RtdeOverrunException()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
