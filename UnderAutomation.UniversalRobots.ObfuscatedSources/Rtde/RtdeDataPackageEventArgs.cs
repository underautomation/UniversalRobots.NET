//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace Rtde {
	/// <summary>
	/// Event arguments for an RTDE output data package received from the robot at the subscribed frequency.
	/// </summary>
	public class RtdeDataPackageEventArgs : PackageEventArgs {


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public RtdeDataPackageEventArgs()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Gets or sets the recipe identifier for the received output data (RTDE v2 only; 0 for v1).
		/// </summary>
		public byte OutputRecipeId { get; set; }

		/// <summary>
		/// Gets or sets the decoded output values contained in this data package.
		/// </summary>
		public RtdeOutputValues OutputDataValues { get; set; }

		/// <summary>
		/// Gets or sets the measured frequency in Hz, computed from successive <xref href="UnderAutomation.UniversalRobots.Rtde.RtdeOutputData.Timestamp" data-throw-if-not-resolved="false"></xref> values.
		/// </summary>
		public double MeasuredFrequency { get; set; }
	}
}
