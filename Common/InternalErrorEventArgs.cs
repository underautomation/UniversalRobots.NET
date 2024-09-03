//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Common {
	/// <summary>
	/// Describes an internal error
	/// </summary>
	public class InternalErrorEventArgs : EventArgs {

		/// <summary>
		/// The exception thrown that causes an internal error
		/// </summary>
		public readonly Exception Exception;

		/// <summary>
		/// Explicit message that explains what happened
		/// </summary>
		public readonly string Message;

		/// <summary>
		/// Context status associated to this internal error
		/// </summary>
		public readonly StatusCode Status;

		/// <summary>
		/// Returns exception message
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
