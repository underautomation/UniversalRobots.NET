//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.ComponentModel;
using System.Runtime.InteropServices;

namespace PrimaryInterface {
	/// <summary>
	/// Describes a field of a received package
	/// </summary>
	public class PackageDescriptionAttribute : DescriptionAttribute {

		/// <summary>
		/// Physical unit of the field
		/// </summary>
		public PackageUnit Unit { get; }


		public PackageDescriptionAttribute(string description)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public PackageDescriptionAttribute(string description, PackageUnit unit)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
