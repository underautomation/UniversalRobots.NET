//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace InterpreterMode.Internal {

	public abstract class InterpreterModeClientParametersBase {

		/// <summary>
		/// Default Interpreter Mode server TCP port
		/// </summary>
		public const int DEFAULT_PORT = 30020;

		/// <summary>
		/// Interpreter Mode client TCP port. Default : 30020
		/// </summary>
		public int Port { get; set; }
	}
}
