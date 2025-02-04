//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Ssh.Tools.Messages.Transport;
using System.Runtime.Serialization;

namespace Ssh.Tools.Common {
	/// <summary>
	/// The exception that is thrown when connection was terminated.
	/// </summary>
	public class SshConnectionException : SshException, ISerializable {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.UniversalRobots.Ssh.Tools.Common.SshConnectionException" data-throw-if-not-resolved="false"></xref> class.
		/// </summary>
		public SshConnectionException()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.UniversalRobots.Ssh.Tools.Common.SshConnectionException" data-throw-if-not-resolved="false"></xref> class.
		/// </summary>
		/// <param name="message">The message.</param>
		public SshConnectionException(string message)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.UniversalRobots.Ssh.Tools.Common.SshConnectionException" data-throw-if-not-resolved="false"></xref> class.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="disconnectReasonCode">The disconnect reason code.</param>
		public SshConnectionException(string message, DisconnectReason disconnectReasonCode)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.UniversalRobots.Ssh.Tools.Common.SshConnectionException" data-throw-if-not-resolved="false"></xref> class.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="disconnectReasonCode">The disconnect reason code.</param>
		/// <param name="inner">The inner.</param>
		public SshConnectionException(string message, DisconnectReason disconnectReasonCode, Exception inner)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Gets the disconnect reason if provided by the server or client. Otherwise None.
		/// </summary>
		public DisconnectReason DisconnectReason { get; }
	}
}
