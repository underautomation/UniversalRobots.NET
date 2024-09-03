//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ssh.Tools.Sftp {
	/// <summary>
	/// Contains File system information exposed by statvfs@openssh.com request.
	/// </summary>
	public class SftpFileSytemInformation {

		/// <summary>
		/// Gets the file system block size.
		/// </summary>
		/// <returns>The file system block size.</returns>
		public ulong FileSystemBlockSize { get; }

		/// <summary>
		/// Gets the fundamental file system size of the block.
		/// </summary>
		/// <returns>The fundamental file system block size.</returns>
		public ulong BlockSize { get; }

		/// <summary>
		/// Gets the total blocks.
		/// </summary>
		/// <returns>The total blocks.</returns>
		public ulong TotalBlocks { get; }

		/// <summary>
		/// Gets the free blocks.
		/// </summary>
		/// <returns>The free blocks.</returns>
		public ulong FreeBlocks { get; }

		/// <summary>
		/// Gets the available blocks.
		/// </summary>
		/// <returns>The available blocks.</returns>
		public ulong AvailableBlocks { get; }

		/// <summary>
		/// Gets the total nodes.
		/// </summary>
		/// <returns>The total nodes.</returns>
		public ulong TotalNodes { get; }

		/// <summary>
		/// Gets the free nodes.
		/// </summary>
		/// <returns>The free nodes.</returns>
		public ulong FreeNodes { get; }

		/// <summary>
		/// Gets the available nodes.
		/// </summary>
		/// <returns>The available nodes.</returns>
		public ulong AvailableNodes { get; }

		/// <summary>
		/// Gets the sid.
		/// </summary>
		/// <returns>The sid.</returns>
		public ulong Sid { get; }

		/// <summary>
		/// Gets a value indicating whether this instance is read only.
		/// </summary>
		/// <returns><code>true</code> if this instance is read only; otherwise, <code>false</code>.</returns>
		public bool IsReadOnly { get; }

		/// <summary>
		/// Gets a value indicating whether [supports set uid].
		/// </summary>
		/// <returns><code>true</code> if [supports set uid]; otherwise, <code>false</code>.</returns>
		public bool SupportsSetUid { get; }

		/// <summary>
		/// Gets the max name lenght.
		/// </summary>
		/// <returns>The max name lenght.</returns>
		public ulong MaxNameLenght { get; }
	}
}
