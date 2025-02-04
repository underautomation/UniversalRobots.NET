//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.Xml.Linq;
using System.IO;

namespace Files {
	/// <summary>
	/// Functions to compile and decompile a *.urp program file
	/// </summary>
	public class URProgram : URArchive {


		public const string EXTENSION = ".urp";

		/// <summary>
		/// Create a URProgram from its XML definition
		/// </summary>
		public URProgram(XElement xml) : base(default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Load a program from stream
		/// </summary>
		public static URProgram Load(Stream urpStream)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Load a *.urp program from file path
		/// </summary>
		public static URProgram Load(string urpFile)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		protected override string NameAttribute => default;


		protected override string RootElement => default;


		protected override string Extension => default;
	}
}
