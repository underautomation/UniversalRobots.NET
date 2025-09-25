//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace Kinematics {

	public class Ur5DhParameters : IUrDhParameters {


		public Ur5DhParameters()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// DH parameter a2 (Shoulder)
		/// </summary>
		public double A2 { get; }

		/// <summary>
		/// DH parameter a3 (Elbow)
		/// </summary>
		public double A3 { get; }

		/// <summary>
		/// DH parameter d1 (Base)
		/// </summary>
		public double D1 { get; }

		/// <summary>
		/// DH parameter d4 (Wrist1)
		/// </summary>
		public double D4 { get; }

		/// <summary>
		/// DH parameter d5 (Wrist2)
		/// </summary>
		public double D5 { get; }

		/// <summary>
		/// DH parameter d6 (Wrist3/Tool)
		/// </summary>
		public double D6 { get; }
	}
}
