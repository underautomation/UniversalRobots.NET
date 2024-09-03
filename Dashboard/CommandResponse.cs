//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Dashboard {
	/// <summary>
	/// Generic answer returned by a command
	/// </summary>
	public class CommandResponse {

		/// <summary>
		/// The command as succeeded
		/// </summary>
		public bool Succeed;

		/// <summary>
		/// A message that described the error or the action done
		/// </summary>
		public string Message;

		/// <summary>
		/// A human readable answer
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
