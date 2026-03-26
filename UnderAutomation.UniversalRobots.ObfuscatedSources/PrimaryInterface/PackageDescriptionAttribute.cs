//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.ComponentModel;

namespace PrimaryInterface {
	/// <summary>
	/// Describes a field of a received package
	/// </summary>
	public class PackageDescriptionAttribute : DescriptionAttribute {

		/// <summary>
		/// Initializes a new instance with no physical unit.
		/// </summary>
		/// <param name="description">Human-readable description of the field.</param>
		public PackageDescriptionAttribute(string description)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Initializes a new instance with a specified physical unit.
		/// </summary>
		/// <param name="description">Human-readable description of the field.</param>
		/// <param name="unit">Physical unit of the measured value.</param>
		public PackageDescriptionAttribute(string description, PackageUnit unit)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Physical unit of the field
		/// </summary>
		public PackageUnit Unit { get; }
	}
}
