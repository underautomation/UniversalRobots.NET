//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.Collections.Generic;
using System;

namespace Ssh.Tools.Sftp {
	/// <summary>
	/// Contains SFTP file attributes.
	/// </summary>
	public class SftpFileAttributes {

		/// <summary>
		/// Gets or sets the local time the current file or directory was last accessed.
		/// </summary>
		/// <returns>The local time that the current file or directory was last accessed.</returns>
		public DateTime LastAccessTime { get; set; }

		/// <summary>
		/// Gets or sets the local time when the current file or directory was last written to.
		/// </summary>
		/// <returns>The local time the current file was last written.</returns>
		public DateTime LastWriteTime { get; set; }

		/// <summary>
		/// Gets or sets the UTC time the current file or directory was last accessed.
		/// </summary>
		/// <returns>The UTC time that the current file or directory was last accessed.</returns>
		public DateTime LastAccessTimeUtc { get; set; }

		/// <summary>
		/// Gets or sets the UTC time when the current file or directory was last written to.
		/// </summary>
		/// <returns>The UTC time the current file was last written.</returns>
		public DateTime LastWriteTimeUtc { get; set; }

		/// <summary>
		/// Gets or sets the size, in bytes, of the current file.
		/// </summary>
		/// <returns>The size of the current file in bytes.</returns>
		public long Size { get; set; }

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
		/// Gets a value indicating whether the owner can read from this file.
		/// </summary>
		/// <returns><code>true</code> if owner can read from this file; otherwise, <code>false</code>.</returns>
		public bool OwnerCanRead { get; set; }

		/// <summary>
		/// Gets a value indicating whether the owner can write into this file.
		/// </summary>
		/// <returns><code>true</code> if owner can write into this file; otherwise, <code>false</code>.</returns>
		public bool OwnerCanWrite { get; set; }

		/// <summary>
		/// Gets a value indicating whether the owner can execute this file.
		/// </summary>
		/// <returns><code>true</code> if owner can execute this file; otherwise, <code>false</code>.</returns>
		public bool OwnerCanExecute { get; set; }

		/// <summary>
		/// Gets a value indicating whether the group members can read from this file.
		/// </summary>
		/// <returns><code>true</code> if group members can read from this file; otherwise, <code>false</code>.</returns>
		public bool GroupCanRead { get; set; }

		/// <summary>
		/// Gets a value indicating whether the group members can write into this file.
		/// </summary>
		/// <returns><code>true</code> if group members can write into this file; otherwise, <code>false</code>.</returns>
		public bool GroupCanWrite { get; set; }

		/// <summary>
		/// Gets a value indicating whether the group members can execute this file.
		/// </summary>
		/// <returns><code>true</code> if group members can execute this file; otherwise, <code>false</code>.</returns>
		public bool GroupCanExecute { get; set; }

		/// <summary>
		/// Gets a value indicating whether the others can read from this file.
		/// </summary>
		/// <returns><code>true</code> if others can read from this file; otherwise, <code>false</code>.</returns>
		public bool OthersCanRead { get; set; }

		/// <summary>
		/// Gets a value indicating whether the others can write into this file.
		/// </summary>
		/// <returns><code>true</code> if others can write into this file; otherwise, <code>false</code>.</returns>
		public bool OthersCanWrite { get; set; }

		/// <summary>
		/// Gets a value indicating whether the others can execute this file.
		/// </summary>
		/// <returns><code>true</code> if others can execute this file; otherwise, <code>false</code>.</returns>
		public bool OthersCanExecute { get; set; }

		/// <summary>
		/// Gets or sets the extensions.
		/// </summary>
		/// <returns>The extensions.</returns>
		public IDictionary<string, string> Extensions { get; }

		/// <summary>
		/// Sets the permissions.
		/// </summary>
		/// <param name="mode">The mode.</param>
		public void SetPermissions(short mode)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns a byte array representing the current <xref href="UnderAutomation.UniversalRobots.Ssh.Tools.Sftp.SftpFileAttributes" data-throw-if-not-resolved="false"></xref>.
		/// </summary>
		/// <returns>A byte array representing the current <xref href="UnderAutomation.UniversalRobots.Ssh.Tools.Sftp.SftpFileAttributes" data-throw-if-not-resolved="false"></xref>.</returns>
		public byte[] GetBytes()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
