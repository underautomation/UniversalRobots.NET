//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.Xml.Linq;
using System.IO;

namespace Files {
	/// <summary>
	/// Contains basic methods to encode and decode a UR archive
	/// </summary>
	public abstract class URArchive {

		/// <summary>
		/// Initializes a new instance of <xref href="UnderAutomation.UniversalRobots.Files.URArchive" data-throw-if-not-resolved="false"></xref> from the specified XML element.
		/// </summary>
		/// <param name="xml">The XML element representing the archive content.</param>
		protected URArchive(XElement xml)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Save encoded file to a stream
		/// </summary>
		public void Save(Stream stream)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Save encoded file to a directory, overwrite it if it exists
		/// </summary>
		/// <param name="directory">Directory to save the file</param>
		/// <returns>Full name of the saved file</returns>
		public string Save(string directory)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Load a UR archive from file path and decode it as XML
		/// </summary>
		public static XElement Load(string filePath)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Load a UR archive from stream and decode it as XML
		/// </summary>
		public static XElement Load(Stream fileStream)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// XML description of the object
		/// </summary>
		public XElement XML { get; }

		/// <summary>
		/// Gets the XML attribute name used to store the archive name.
		/// </summary>
		protected abstract string NameAttribute { get; }

		/// <summary>
		/// Gets the expected root XML element name for this archive type.
		/// </summary>
		protected abstract string RootElement { get; }

		/// <summary>
		/// Gets the file extension for this archive type (e.g., ".urp" or ".installation").
		/// </summary>
		protected abstract string Extension { get; }

		/// <summary>
		/// Gets or sets the name of this archive, stored as an XML attribute.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// File name that should be used on a UR robot
		/// </summary>
		public string FileName { get; }
	}
}
