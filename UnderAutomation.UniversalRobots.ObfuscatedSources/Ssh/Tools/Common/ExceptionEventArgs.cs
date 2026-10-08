//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.UniversalRobots.Ssh.Tools.Common {
	/// <summary>
	/// Provides data for the ErrorOccured events.
	/// </summary>
	public class ExceptionEventArgs : EventArgs {

		/// <summary>
		/// Initializes a new instance of the <see cref="UnderAutomation.UniversalRobots.Ssh.Tools.Common.ExceptionEventArgs"/> class.
		/// </summary>
		/// <param name="exception">An System.Exception that represents the error that occurred.</param>
		public ExceptionEventArgs(Exception exception)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Gets the System.Exception that represents the error that occurred.
		/// </summary>
		public Exception Exception { get; }
	}
}
