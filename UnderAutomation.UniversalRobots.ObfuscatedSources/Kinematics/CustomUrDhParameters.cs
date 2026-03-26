//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace Kinematics {
	/// <summary>
	/// Mutable Denavit-Hartenberg parameters for a Universal Robots arm, allowing custom DH values.
	/// </summary>
	public class CustomUrDhParameters : IUrDhParameters {

		/// <summary>
		/// Creates a new instance with the specified DH parameters.
		/// </summary>
		/// <param name="a2">DH parameter a2 (shoulder link length) in meters.</param>
		/// <param name="a3">DH parameter a3 (elbow link length) in meters.</param>
		/// <param name="d1">DH parameter d1 (base height offset) in meters.</param>
		/// <param name="d4">DH parameter d4 (wrist 1 offset) in meters.</param>
		/// <param name="d5">DH parameter d5 (wrist 2 offset) in meters.</param>
		/// <param name="d6">DH parameter d6 (wrist 3 / tool offset) in meters.</param>
		public CustomUrDhParameters(double a2, double a3, double d1, double d4, double d5, double d6)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Creates a new instance by copying values from an existing <xref href="UnderAutomation.UniversalRobots.Common.IUrDhParameters" data-throw-if-not-resolved="false"></xref> instance.
		/// </summary>
		/// <param name="parameters">Source DH parameters to copy.</param>
		public CustomUrDhParameters(IUrDhParameters parameters)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override bool Equals(object obj)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override int GetHashCode()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// DH parameter a2 (shoulder link length) in meters.
		/// </summary>
		public double A2 { get; set; }

		/// <summary>
		/// DH parameter a3 (elbow link length) in meters.
		/// </summary>
		public double A3 { get; set; }

		/// <summary>
		/// DH parameter d1 (base height offset) in meters.
		/// </summary>
		public double D1 { get; set; }

		/// <summary>
		/// DH parameter d4 (wrist 1 offset) in meters.
		/// </summary>
		public double D4 { get; set; }

		/// <summary>
		/// DH parameter d5 (wrist 2 offset) in meters.
		/// </summary>
		public double D5 { get; set; }

		/// <summary>
		/// DH parameter d6 (wrist 3 / tool offset) in meters.
		/// </summary>
		public double D6 { get; set; }
	}
}
