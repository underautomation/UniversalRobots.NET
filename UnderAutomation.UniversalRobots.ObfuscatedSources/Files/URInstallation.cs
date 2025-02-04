//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.Xml.Linq;
using System.IO;

namespace Files {
	/// <summary>
	/// Functions to encode and decode a *.installation file
	/// </summary>
	public class URInstallation : URArchive {


		public const string EXTENSION = ".installation";

		/// <summary>
		/// Create a URProgram from its XML definition
		/// </summary>
		public URInstallation(XElement xml) : base(default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Load an installation file from stream
		/// </summary>
		public static URInstallation Load(Stream urpStream)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Load a *.installation file from path
		/// </summary>
		public static URInstallation Load(string urpFile)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		protected override string NameAttribute => default;


		protected override string RootElement => default;


		protected override string Extension => default;
	}
}
