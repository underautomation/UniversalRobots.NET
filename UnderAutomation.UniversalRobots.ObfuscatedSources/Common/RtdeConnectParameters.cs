//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Rtde.Internal;

namespace Common {
	/// <summary>
	/// Setup RTDE (Real-Time Data Exchange) client communication
	/// </summary>
	public class RtdeConnectParameters : RtdeParametersBase {

		/// <summary>
		/// Choose to enable RTDE (Real-Time Data Exchange) 
		/// Default value is false
		/// </summary>
		public bool Enable { get; set; }
	}
}
