//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using InterpreterMode.Internal;

namespace Common {
	/// <summary>
	/// Setup Interpreter Mode Client
	/// </summary>
	public class InterpreterModeConnectParameters : InterpreterModeClientParametersBase {

		/// <summary>
		/// Enable Interpreter Mode client communication
		/// Default value is false
		/// </summary>
		public bool Enable { get; set; }
	}
}
