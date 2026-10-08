//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.UniversalRobots.Ssh.Tools.Common {
	/// <summary>
	/// Describes object identifier for DER encoding
	/// </summary>
	public struct ObjectIdentifier {

		/// <summary>
		/// Initializes a new instance of the <see cref="UnderAutomation.UniversalRobots.Ssh.Tools.Common.ObjectIdentifier"/> class.
		/// </summary>
		/// <param name="identifiers">The identifiers.</param>
		public ObjectIdentifier(params ulong[] identifiers)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Gets the object identifier.
		/// </summary>
		public readonly ulong[] Identifiers { get; }
	}
}
