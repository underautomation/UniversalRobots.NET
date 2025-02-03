//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.Runtime.Serialization;
using System.Runtime.InteropServices;

namespace Ssh.Tools.Common {
	/// <summary>
	/// The exception that is thrown when pass phrase for key file is empty or null
	/// </summary>
	[Serializable]
public class SshPassPhraseNullOrEmptyException : SshException, ISerializable {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.UniversalRobots.Ssh.Tools.Common.SshPassPhraseNullOrEmptyException" data-throw-if-not-resolved="false"></xref> class.
		/// </summary>
		public SshPassPhraseNullOrEmptyException()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.UniversalRobots.Ssh.Tools.Common.SshPassPhraseNullOrEmptyException" data-throw-if-not-resolved="false"></xref> class.
		/// </summary>
		/// <param name="message">The message.</param>
		public SshPassPhraseNullOrEmptyException(string message)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.UniversalRobots.Ssh.Tools.Common.SshPassPhraseNullOrEmptyException" data-throw-if-not-resolved="false"></xref> class.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="innerException">The inner exception.</param>
		public SshPassPhraseNullOrEmptyException(string message, Exception innerException)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.UniversalRobots.Ssh.Tools.Common.SshPassPhraseNullOrEmptyException" data-throw-if-not-resolved="false"></xref> class.
		/// </summary>
		/// <param name="info">The <xref href="System.Runtime.Serialization.SerializationInfo" data-throw-if-not-resolved="false"></xref> that holds the serialized object data about the exception being thrown.</param>
		/// <param name="context">The <xref href="System.Runtime.Serialization.StreamingContext" data-throw-if-not-resolved="false"></xref> that contains contextual information about the source or destination.</param>
		protected SshPassPhraseNullOrEmptyException(SerializationInfo info, StreamingContext context)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
