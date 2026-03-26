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

		/// <summary>
		/// File extension for UR installation files.
		/// </summary>
		public const string EXTENSION = ".installation";

		/// <summary>
		/// Creates a URInstallation from its XML definition.
		/// </summary>
		/// <param name="xml">The XML element representing the installation content.</param>
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

		/// <summary>
		/// Returns the file name of this installation.
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Determines whether the specified object is equal to this installation.
		/// </summary>
		public override bool Equals(object obj)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Returns a hash code for this installation.
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
