//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Common {
	/// <summary>
	/// Denavit–Hartenberg (DH) parameters for Universal Robots with only the relevant parameters
	/// </summary>
	public interface IUrDhParameters {

		/// <summary>
		/// DH parameter a2 (Shoulder)
		/// </summary>
		double A2 { get; }

		/// <summary>
		/// DH parameter a3 (Elbow)
		/// </summary>
		double A3 { get; }

		/// <summary>
		/// DH parameter d1 (Base)
		/// </summary>
		double D1 { get; }

		/// <summary>
		/// DH parameter d4 (Wrist1)
		/// </summary>
		double D4 { get; }

		/// <summary>
		/// DH parameter d5 (Wrist2)
		/// </summary>
		double D5 { get; }

		/// <summary>
		/// DH parameter d6 (Wrist3/Tool)
		/// </summary>
		double D6 { get; }
	}
}
