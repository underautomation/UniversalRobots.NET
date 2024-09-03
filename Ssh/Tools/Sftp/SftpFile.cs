//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ssh.Tools.Sftp {
	/// <summary>
	/// Represents SFTP file information
	/// </summary>
	public class SftpFile {

		/// <summary>
		/// Gets the file attributes.
		/// </summary>
		public SftpFileAttributes Attributes { get; }

		/// <summary>
		/// Gets the full path of the directory or file.
		/// </summary>
		public string FullName { get; }

		/// <summary>
		/// For files, gets the name of the file. For directories, gets the name of the last directory in the hierarchy if a hierarchy exists. 
		/// Otherwise, the Name property gets the name of the directory.
		/// </summary>
		public string Name { get; }

		/// <summary>
		/// Gets or sets the time the current file or directory was last accessed.
		/// </summary>
		/// <returns>The time that the current file or directory was last accessed.</returns>
		public DateTime LastAccessTime { get; set; }

		/// <summary>
		/// Gets or sets the time when the current file or directory was last written to.
		/// </summary>
		/// <returns>The time the current file was last written.</returns>
		public DateTime LastWriteTime { get; set; }

		/// <summary>
		/// Gets or sets the time, in coordinated universal time (UTC), the current file or directory was last accessed.
		/// </summary>
		/// <returns>The time that the current file or directory was last accessed.</returns>
		public DateTime LastAccessTimeUtc { get; set; }

		/// <summary>
		/// Gets or sets the time, in coordinated universal time (UTC), when the current file or directory was last written to.
		/// </summary>
		/// <returns>The time the current file was last written.</returns>
		public DateTime LastWriteTimeUtc { get; set; }

		/// <summary>
		/// Gets or sets the size, in bytes, of the current file.
		/// </summary>
		/// <returns>The size of the current file in bytes.</returns>
		public long Length { get; }

		/// <summary>
		/// Gets or sets file user id.
		/// </summary>
		/// <returns>File user id.</returns>
		public int UserId { get; set; }

		/// <summary>
		/// Gets or sets file group id.
		/// </summary>
		/// <returns>File group id.</returns>
		public int GroupId { get; set; }

		/// <summary>
		/// Gets a value indicating whether file represents a socket.
		/// </summary>
		/// <returns><code>true</code> if file represents a socket; otherwise, <code>false</code>.</returns>
		public bool IsSocket { get; }

		/// <summary>
		/// Gets a value indicating whether file represents a symbolic link.
		/// </summary>
		/// <returns><code>true</code> if file represents a symbolic link; otherwise, <code>false</code>.</returns>
		public bool IsSymbolicLink { get; }

		/// <summary>
		/// Gets a value indicating whether file represents a regular file.
		/// </summary>
		/// <returns><code>true</code> if file represents a regular file; otherwise, <code>false</code>.</returns>
		public bool IsRegularFile { get; }

		/// <summary>
		/// Gets a value indicating whether file represents a block device.
		/// </summary>
		/// <returns><code>true</code> if file represents a block device; otherwise, <code>false</code>.</returns>
		public bool IsBlockDevice { get; }

		/// <summary>
		/// Gets a value indicating whether file represents a directory.
		/// </summary>
		/// <returns><code>true</code> if file represents a directory; otherwise, <code>false</code>.</returns>
		public bool IsDirectory { get; }

		/// <summary>
		/// Gets a value indicating whether file represents a character device.
		/// </summary>
		/// <returns><code>true</code> if file represents a character device; otherwise, <code>false</code>.</returns>
		public bool IsCharacterDevice { get; }

		/// <summary>
		/// Gets a value indicating whether file represents a named pipe.
		/// </summary>
		/// <returns><code>true</code> if file represents a named pipe; otherwise, <code>false</code>.</returns>
		public bool IsNamedPipe { get; }

		/// <summary>
		/// Gets or sets a value indicating whether the owner can read from this file.
		/// </summary>
		/// <returns><code>true</code> if owner can read from this file; otherwise, <code>false</code>.</returns>
		public bool OwnerCanRead { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the owner can write into this file.
		/// </summary>
		/// <returns><code>true</code> if owner can write into this file; otherwise, <code>false</code>.</returns>
		public bool OwnerCanWrite { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the owner can execute this file.
		/// </summary>
		/// <returns><code>true</code> if owner can execute this file; otherwise, <code>false</code>.</returns>
		public bool OwnerCanExecute { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the group members can read from this file.
		/// </summary>
		/// <returns><code>true</code> if group members can read from this file; otherwise, <code>false</code>.</returns>
		public bool GroupCanRead { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the group members can write into this file.
		/// </summary>
		/// <returns><code>true</code> if group members can write into this file; otherwise, <code>false</code>.</returns>
		public bool GroupCanWrite { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the group members can execute this file.
		/// </summary>
		/// <returns><code>true</code> if group members can execute this file; otherwise, <code>false</code>.</returns>
		public bool GroupCanExecute { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the others can read from this file.
		/// </summary>
		/// <returns><code>true</code> if others can read from this file; otherwise, <code>false</code>.</returns>
		public bool OthersCanRead { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the others can write into this file.
		/// </summary>
		/// <returns><code>true</code> if others can write into this file; otherwise, <code>false</code>.</returns>
		public bool OthersCanWrite { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the others can execute this file.
		/// </summary>
		/// <returns><code>true</code> if others can execute this file; otherwise, <code>false</code>.</returns>
		public bool OthersCanExecute { get; set; }

		/// <summary>
		/// Sets file  permissions.
		/// </summary>
		/// <param name="mode">The mode.</param>
		public void SetPermissions(short mode)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Permanently deletes a file on remote machine.
		/// </summary>
		public void Delete()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Moves a specified file to a new location on remote machine, providing the option to specify a new file name.
		/// </summary>
		/// <param name="destFileName">The path to move the file to, which can specify a different file name.</param>
		public void MoveTo(string destFileName)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Updates file status on the server.
		/// </summary>
		public void UpdateStatus()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns a <xref href="System.String" data-throw-if-not-resolved="false"></xref> that represents this instance.
		/// </summary>
		/// <returns>A <xref href="System.String" data-throw-if-not-resolved="false"></xref> that represents this instance.</returns>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
