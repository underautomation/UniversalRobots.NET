//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.Collections;

namespace PrimaryInterface {
	/// <summary>
	/// Represents the state of digital I/O pins on the UR controller masterboard,
	/// including standard digital, configurable, and tool digital pins.
	/// </summary>
	public class MasterboardDigitalIO {


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
		/// Register value
		/// </summary>
		[PackageDescription("Register value")]
public int Value { get; }

		/// <summary>
		/// Register value seen as a bool array
		/// </summary>
		[PackageDescription("Register value seen as a bool array")]
public BitArray BitArray { get; }

		/// <summary>
		/// State of standard digital I/O pin 0.
		/// </summary>
		public bool Digital0 { get; }

		/// <summary>
		/// State of standard digital I/O pin 1.
		/// </summary>
		public bool Digital1 { get; }

		/// <summary>
		/// State of standard digital I/O pin 2.
		/// </summary>
		public bool Digital2 { get; }

		/// <summary>
		/// State of standard digital I/O pin 3.
		/// </summary>
		public bool Digital3 { get; }

		/// <summary>
		/// State of standard digital I/O pin 4.
		/// </summary>
		public bool Digital4 { get; }

		/// <summary>
		/// State of standard digital I/O pin 5.
		/// </summary>
		public bool Digital5 { get; }

		/// <summary>
		/// State of standard digital I/O pin 6.
		/// </summary>
		public bool Digital6 { get; }

		/// <summary>
		/// State of standard digital I/O pin 7.
		/// </summary>
		public bool Digital7 { get; }

		/// <summary>
		/// State of configurable digital I/O pin 0.
		/// </summary>
		public bool Configurable0 { get; }

		/// <summary>
		/// State of configurable digital I/O pin 1.
		/// </summary>
		public bool Configurable1 { get; }

		/// <summary>
		/// State of configurable digital I/O pin 2.
		/// </summary>
		public bool Configurable2 { get; }

		/// <summary>
		/// State of configurable digital I/O pin 3.
		/// </summary>
		public bool Configurable3 { get; }

		/// <summary>
		/// State of configurable digital I/O pin 4.
		/// </summary>
		public bool Configurable4 { get; }

		/// <summary>
		/// State of configurable digital I/O pin 5.
		/// </summary>
		public bool Configurable5 { get; }

		/// <summary>
		/// State of configurable digital I/O pin 6.
		/// </summary>
		public bool Configurable6 { get; }

		/// <summary>
		/// State of configurable digital I/O pin 7.
		/// </summary>
		public bool Configurable7 { get; }

		/// <summary>
		/// State of tool digital I/O pin 0.
		/// </summary>
		public bool ToolDigital0 { get; }

		/// <summary>
		/// State of tool digital I/O pin 1.
		/// </summary>
		public bool ToolDigital1 { get; }
	}
}
