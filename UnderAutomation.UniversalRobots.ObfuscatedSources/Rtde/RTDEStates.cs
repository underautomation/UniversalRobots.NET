//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Rtde {
	/// <summary>
	/// Represents the current state of the RTDE connection lifecycle.
	/// </summary>
	public enum RTDEStates {

		/// <summary>
		/// RTDE is not connected.
		/// </summary>
		Disabled = 0,

		/// <summary>
		/// RTDE connection and recipe setup are in progress.
		/// </summary>
		Connecting = 1,

		/// <summary>
		/// RTDE is actively streaming data.
		/// </summary>
		Started = 2,

		/// <summary>
		/// RTDE streaming is paused but the connection remains open.
		/// </summary>
		Paused = 3,
	}
}
