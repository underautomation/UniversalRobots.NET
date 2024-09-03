//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ssh.Tools.Common {
	/// <summary>
	/// Provides data for Shell DataReceived event
	/// </summary>
	public class ShellDataEventArgs : EventArgs {

		/// <summary>
		/// Gets the data.
		/// </summary>
		public byte[] Data { get; }

		/// <summary>
		/// Gets the line data.
		/// </summary>
		public string Line { get; }

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.UniversalRobots.Ssh.Tools.Common.ShellDataEventArgs" data-throw-if-not-resolved="false"></xref> class.
		/// </summary>
		/// <param name="data">The data.</param>
		public ShellDataEventArgs(byte[] data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.UniversalRobots.Ssh.Tools.Common.ShellDataEventArgs" data-throw-if-not-resolved="false"></xref> class.
		/// </summary>
		/// <param name="line">The line.</param>
		public ShellDataEventArgs(string line)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
