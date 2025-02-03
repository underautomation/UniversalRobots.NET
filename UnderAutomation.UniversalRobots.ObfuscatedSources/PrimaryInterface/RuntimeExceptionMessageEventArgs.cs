//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace PrimaryInterface {
	/// <summary>
	/// Reports an error in the execution of the program
	/// </summary>
	public class RuntimeExceptionMessageEventArgs : PackageEventArgs {

		/// <summary>
		/// Execution error line number
		/// </summary>
		public int ScriptLineNumber { get; set; }

		/// <summary>
		/// Execution error column number
		/// </summary>
		public int ScriptColumnNumber { get; set; }

		/// <summary>
		/// Information about exception
		/// </summary>
		public string RuntimeExceptionTextMessage { get; set; }
	}
}
