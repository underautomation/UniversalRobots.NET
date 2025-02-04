//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace Rtde {

	public class RtdeDataPackageEventArgs : PackageEventArgs {


		public RtdeDataPackageEventArgs()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public byte OutputRecipeId { get; set; }


		public RtdeOutputValues OutputDataValues { get; set; }


		public double MeasuredFrequency { get; set; }
	}
}
