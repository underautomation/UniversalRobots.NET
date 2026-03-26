//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Dashboard {
	/// <summary>
	/// Answer returned by a command which contains a typed value.
	/// </summary>
	public class CommandResponse<T> : CommandResponse {

		/// <summary>
		/// Value return by the command
		/// </summary>
		public T Value;

		/// <summary>
		/// Initializes a new instance of <xref href="UnderAutomation.UniversalRobots.Dashboard.CommandResponse%601" data-throw-if-not-resolved="false"></xref> by copying the base response data.
		/// </summary>
		/// <param name="command">The base command response to copy from.</param>
		public CommandResponse(CommandResponse command)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// A human readable answer
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Determines whether the specified object is equal to this response.
		/// </summary>
		public override bool Equals(object obj)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Returns a hash code for this response.
		/// </summary>
		public override int GetHashCode()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
