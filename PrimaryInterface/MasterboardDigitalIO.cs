//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.Collections;

namespace PrimaryInterface {

	public class MasterboardDigitalIO {

		/// <summary>
		/// Register value
		/// </summary>
		[PackageDescription("Register value")]
public int Value { get; }

		/// <summary>
		/// Register value seen as a bool array
		/// </summary>
		[PackageDescription("Register value seen as a bool array")]
public BitArray BitArray { get; }


		public bool Digital0 { get; }


		public bool Digital1 { get; }


		public bool Digital2 { get; }


		public bool Digital3 { get; }


		public bool Digital4 { get; }


		public bool Digital5 { get; }


		public bool Digital6 { get; }


		public bool Digital7 { get; }


		public bool Configurable0 { get; }


		public bool Configurable1 { get; }


		public bool Configurable2 { get; }


		public bool Configurable3 { get; }


		public bool Configurable4 { get; }


		public bool Configurable5 { get; }


		public bool Configurable6 { get; }


		public bool Configurable7 { get; }


		public bool ToolDigital0 { get; }


		public bool ToolDigital1 { get; }
	}
}
