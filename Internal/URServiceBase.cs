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


		protected void RaiseInternalError(string message, Exception ex, StatusCode context)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Event raised when an error occured
		/// </summary>
		public event EventHandler<InternalErrorEventArgs> InternalErrorOccured;
	}
}
