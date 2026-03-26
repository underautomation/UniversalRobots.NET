//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;
using System;

namespace Internal {
	/// <summary>
	/// Base class of all UR services implemented in this SDK
	/// </summary>
	public abstract class URServiceBase {

		/// <summary>
		/// Raises the <xref href="UnderAutomation.UniversalRobots.Internal.URServiceBase.InternalErrorOccured" data-throw-if-not-resolved="false"></xref> event to notify subscribers of an internal error.
		/// Exceptions thrown by event handlers are silently caught to prevent cascading failures.
		/// </summary>
		/// <param name="message">A human-readable description of the error.</param>
		/// <param name="ex">The exception that caused the error, or <code>null</code>.</param>
		/// <param name="context">The status code indicating which service or operation encountered the error.</param>
		protected void RaiseInternalError(string message, Exception ex, StatusCode context)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		protected URServiceBase()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Event raised when an error occured
		/// </summary>
		public event EventHandler<InternalErrorEventArgs> InternalErrorOccured;
	}
}
