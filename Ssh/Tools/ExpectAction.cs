//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.Text.RegularExpressions;
using System;

namespace Ssh.Tools {
	/// <summary>
	/// Specifies behavior for expected expression
	/// </summary>
	public class ExpectAction {

		/// <summary>
		/// Gets the expected regular expression.
		/// </summary>
		public Regex Expect { get; }

		/// <summary>
		/// Gets the action to perform when expected expression is found.
		/// </summary>
		public Action<string> Action { get; }

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.UniversalRobots.Ssh.Tools.ExpectAction" data-throw-if-not-resolved="false"></xref> class.
		/// </summary>
		/// <param name="expect">The expect regular expression.</param>
		/// <param name="action">The action to perform.</param>
		public ExpectAction(Regex expect, Action<string> action)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.UniversalRobots.Ssh.Tools.ExpectAction" data-throw-if-not-resolved="false"></xref> class.
		/// </summary>
		/// <param name="expect">The expect expression.</param>
		/// <param name="action">The action to perform.</param>
		public ExpectAction(string expect, Action<string> action)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
