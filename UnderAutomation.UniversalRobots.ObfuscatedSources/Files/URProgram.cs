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

		/// <summary>
		/// File extension for UR program files.
		/// </summary>
		public const string EXTENSION = ".urp";

		/// <summary>
		/// Creates a URProgram from its XML definition.
		/// </summary>
		/// <param name="xml">The XML element representing the program content.</param>
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

		/// <summary>
		/// Returns the file name of this program.
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Determines whether the specified object is equal to this program.
		/// </summary>
		public override bool Equals(object obj)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Returns a hash code for this program.
		/// </summary>
		public override int GetHashCode()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets the XML attribute name used to store the archive name.
		/// </summary>
		protected override string NameAttribute => default;

		/// <summary>
		/// Gets the expected root XML element name for this archive type.
		/// </summary>
		protected override string RootElement => default;

		/// <summary>
		/// Gets the file extension for this archive type (e.g., ".urp" or ".installation").
		/// </summary>
		protected override string Extension => default;
	}
}
