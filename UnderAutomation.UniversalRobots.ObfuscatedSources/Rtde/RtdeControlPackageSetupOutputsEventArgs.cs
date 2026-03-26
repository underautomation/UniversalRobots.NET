//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace Rtde {
	/// <summary>
	/// Event arguments raised when the robot acknowledges the RTDE output recipe setup.
	/// </summary>
	public class RtdeControlPackageSetupOutputsEventArgs : PackageEventArgs {


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public RtdeControlPackageSetupOutputsEventArgs()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Gets or sets the recipe identifier assigned by the robot for output data.
		/// </summary>
		public byte OutputRecipeId { get; set; }

		/// <summary>
		/// Gets or sets the status of each subscribed output variable. Each entry contains the RTDE type name, or "IN_USE" / "NOT_FOUND".
		/// </summary>
		public string[] VariableTypes { get; set; }
	}
}
