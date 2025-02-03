//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Internal;
using System;
using Ssh.Tools.Sftp;
using System.IO;
using System.Text;

namespace Ssh.Internal {
	/// <summary>
	/// Implementation of the SSH File Transfer Protocol (SFTP) over SSH for transfering files to the robot controller
	/// </summary>
	public abstract class SftpClientBase : URServiceBase {

		/// <summary>
		/// Gets a value indicating if this client is connected to the robot
		/// </summary>
		public bool Connected { get; }


		protected void ConnectInternal(string ip, int port, string username, string password)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public void Disconnect()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Gets or sets the operation timeout.
		/// </summary>
		/// <returns>The timeout to wait until an operation completes. The default value is negative
		/// one (-1) milliseconds, which indicates an infinite timeout period.</returns>
		public TimeSpan OperationTimeout { get; set; }

		/// <summary>
		/// Gets or sets the maximum size of the buffer in bytes.
		/// </summary>
		/// <returns>The size of the buffer. The default buffer size is 32768 bytes (32 KB).</returns>
		public uint BufferSize { get; set; }

		/// <summary>
		/// Gets remote working directory.
		/// </summary>
		public string WorkingDirectory { get; }

		/// <summary>
		/// Gets sftp protocol version.
		/// </summary>
		public int ProtocolVersion { get; }

		/// <summary>
		/// Changes remote directory to path.
		/// </summary>
		/// <param name="path">New directory path.</param>
		public void ChangeDirectory(string path)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Changes permissions of file(s) to specified mode.
		/// </summary>
		/// <param name="path">File(s) path, may match multiple files.</param>
		/// <param name="mode">The mode.</param>
		public void ChangePermissions(string path, short mode)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Creates remote directory specified by path.
		/// </summary>
		/// <param name="path">Directory path to create.</param>
		public void CreateDirectory(string path)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Deletes remote directory specified by path.
		/// </summary>
		/// <param name="path">Directory to be deleted path.</param>
		public void DeleteDirectory(string path)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Deletes remote file specified by path.
		/// </summary>
		/// <param name="path">File to be deleted path.</param>
		public void DeleteFile(string path)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Renames remote file from old path to new path.
		/// </summary>
		/// <param name="oldPath">Path to the old file location.</param>
		/// <param name="newPath">Path to the new file location.</param>
		public void RenameFile(string oldPath, string newPath)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Renames remote file from old path to new path.
		/// </summary>
		/// <param name="oldPath">Path to the old file location.</param>
		/// <param name="newPath">Path to the new file location.</param>
		/// <param name="isPosix">if set to <code>true</code> then perform a posix rename.</param>
		public void RenameFile(string oldPath, string newPath, bool isPosix)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Creates a symbolic link from old path to new path.
		/// </summary>
		/// <param name="path">The old path.</param>
		/// <param name="linkPath">The new path.</param>
		public void SymbolicLink(string path, string linkPath)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Retrieves list of files in remote directory.
		/// </summary>
		/// <param name="path">The path.</param>
		/// <param name="listCallback">The list callback.</param>
		/// <returns>A list of files.</returns>
		public SftpFile[] ListDirectory(string path, Action<int> listCallback = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Enumerates programs with .urp extension. It searches recursively programs in "/programs" if it exists, or "/home/ur/ursim-current/programs" for simulator
		/// </summary>
		/// <returns>Array of program relative path</returns>
		public string[] EnumeratePrograms()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Enumerates installations with .installation extension. It searches recursively installations in "/programs" if it exists, or "/home/ur/ursim-current/programs" for simulator
		/// </summary>
		/// <returns>Array of installations relative path</returns>
		public string[] EnumerateInstallations()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Begins an asynchronous operation of retrieving list of files in remote directory.
		/// </summary>
		/// <param name="path">The path.</param>
		/// <param name="asyncCallback">The method to be called when the asynchronous write operation is completed.</param>
		/// <param name="state">A user-provided object that distinguishes this particular asynchronous write request from other requests.</param>
		/// <param name="listCallback">The list callback.</param>
		/// <returns>An <xref href="System.IAsyncResult" data-throw-if-not-resolved="false"></xref> that references the asynchronous operation.</returns>
		public IAsyncResult BeginListDirectory(string path, AsyncCallback asyncCallback, object state, Action<int> listCallback = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Ends an asynchronous operation of retrieving list of files in remote directory.
		/// </summary>
		/// <param name="asyncResult">The pending asynchronous SFTP request.</param>
		/// <returns>A list of files.</returns>
		public SftpFile[] EndListDirectory(IAsyncResult asyncResult)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets reference to remote file or directory.
		/// </summary>
		/// <param name="path">The path.</param>
		/// <returns>A reference to <xref href="UnderAutomation.UniversalRobots.Ssh.Tools.Sftp.SftpFile" data-throw-if-not-resolved="false"></xref> file object.</returns>
		public SftpFile Get(string path)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Checks whether file or directory exists;
		/// </summary>
		/// <param name="path">The path.</param>
		/// <returns><code>true</code> if directory or file exists; otherwise <code>false</code>.</returns>
		public bool Exists(string path)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Downloads remote file specified by the path into the stream.
		/// </summary>
		/// <param name="path">File to download.</param>
		/// <param name="localPath">Local file to download</param>
		/// <param name="downloadCallback">The download callback.</param>
		public void DownloadFile(string path, string localPath, Action<ulong> downloadCallback = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Downloads remote file specified by the path into the stream.
		/// </summary>
		/// <param name="path">File to download.</param>
		/// <param name="output">Stream to write the file into.</param>
		/// <param name="downloadCallback">The download callback.</param>
		public void DownloadFile(string path, Stream output, Action<ulong> downloadCallback = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Begins an asynchronous file downloading into the stream.
		/// </summary>
		/// <param name="path">The path.</param>
		/// <param name="output">The output.</param>
		/// <returns>An <xref href="System.IAsyncResult" data-throw-if-not-resolved="false"></xref> that references the asynchronous operation.</returns>
		public IAsyncResult BeginDownloadFile(string path, Stream output)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Begins an asynchronous file downloading into the stream.
		/// </summary>
		/// <param name="path">The path.</param>
		/// <param name="output">The output.</param>
		/// <param name="asyncCallback">The method to be called when the asynchronous write operation is completed.</param>
		/// <returns>An <xref href="System.IAsyncResult" data-throw-if-not-resolved="false"></xref> that references the asynchronous operation.</returns>
		public IAsyncResult BeginDownloadFile(string path, Stream output, AsyncCallback asyncCallback)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Begins an asynchronous file downloading into the stream.
		/// </summary>
		/// <param name="path">The path.</param>
		/// <param name="output">The output.</param>
		/// <param name="asyncCallback">The method to be called when the asynchronous write operation is completed.</param>
		/// <param name="state">A user-provided object that distinguishes this particular asynchronous write request from other requests.</param>
		/// <param name="downloadCallback">The download callback.</param>
		/// <returns>An <xref href="System.IAsyncResult" data-throw-if-not-resolved="false"></xref> that references the asynchronous operation.</returns>
		public IAsyncResult BeginDownloadFile(string path, Stream output, AsyncCallback asyncCallback, object state, Action<ulong> downloadCallback = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Ends an asynchronous file downloading into the stream.
		/// </summary>
		/// <param name="asyncResult">The pending asynchronous SFTP request.</param>
		public void EndDownloadFile(IAsyncResult asyncResult)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Uploads file into remote file.
		/// </summary>
		/// <param name="localPath">Local file to read and transfer.</param>
		/// <param name="path">Remote file path.</param>
		/// <param name="uploadCallback">The upload callback.</param>
		public void UploadFile(string localPath, string path, Action<ulong> uploadCallback = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Uploads stream into remote file.
		/// </summary>
		/// <param name="input">Data input stream.</param>
		/// <param name="path">Remote file path.</param>
		/// <param name="uploadCallback">The upload callback.</param>
		public void UploadFile(Stream input, string path, Action<ulong> uploadCallback = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Uploads stream into remote file.
		/// </summary>
		/// <param name="input">Data input stream.</param>
		/// <param name="path">Remote file path.</param>
		/// <param name="canOverride">if set to <code>true</code> then existing file will be overwritten.</param>
		/// <param name="uploadCallback">The upload callback.</param>
		public void UploadFile(Stream input, string path, bool canOverride, Action<ulong> uploadCallback = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Begins an asynchronous uploading the stream into remote file.
		/// </summary>
		/// <param name="input">Data input stream.</param>
		/// <param name="path">Remote file path.</param>
		/// <returns>An <xref href="System.IAsyncResult" data-throw-if-not-resolved="false"></xref> that references the asynchronous operation.</returns>
		public IAsyncResult BeginUploadFile(Stream input, string path)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Begins an asynchronous uploading the stream into remote file.
		/// </summary>
		/// <param name="input">Data input stream.</param>
		/// <param name="path">Remote file path.</param>
		/// <param name="asyncCallback">The method to be called when the asynchronous write operation is completed.</param>
		/// <returns>An <xref href="System.IAsyncResult" data-throw-if-not-resolved="false"></xref> that references the asynchronous operation.</returns>
		public IAsyncResult BeginUploadFile(Stream input, string path, AsyncCallback asyncCallback)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Begins an asynchronous uploading the stream into remote file.
		/// </summary>
		/// <param name="input">Data input stream.</param>
		/// <param name="path">Remote file path.</param>
		/// <param name="asyncCallback">The method to be called when the asynchronous write operation is completed.</param>
		/// <param name="state">A user-provided object that distinguishes this particular asynchronous write request from other requests.</param>
		/// <param name="uploadCallback">The upload callback.</param>
		/// <returns>An <xref href="System.IAsyncResult" data-throw-if-not-resolved="false"></xref> that references the asynchronous operation.</returns>
		public IAsyncResult BeginUploadFile(Stream input, string path, AsyncCallback asyncCallback, object state, Action<ulong> uploadCallback = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Begins an asynchronous uploading the stream into remote file.
		/// </summary>
		/// <param name="input">Data input stream.</param>
		/// <param name="path">Remote file path.</param>
		/// <param name="canOverride">Specified whether an existing file can be overwritten.</param>
		/// <param name="asyncCallback">The method to be called when the asynchronous write operation is completed.</param>
		/// <param name="state">A user-provided object that distinguishes this particular asynchronous write request from other requests.</param>
		/// <param name="uploadCallback">The upload callback.</param>
		/// <returns>An <xref href="System.IAsyncResult" data-throw-if-not-resolved="false"></xref> that references the asynchronous operation.</returns>
		public IAsyncResult BeginUploadFile(Stream input, string path, bool canOverride, AsyncCallback asyncCallback, object state, Action<ulong> uploadCallback = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Ends an asynchronous uploading the stream into remote file.
		/// </summary>
		/// <param name="asyncResult">The pending asynchronous SFTP request.</param>
		public void EndUploadFile(IAsyncResult asyncResult)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Gets status using statvfs@openssh.com request.
		/// </summary>
		/// <param name="path">The path.</param>
		/// <returns>A <xref href="UnderAutomation.UniversalRobots.Ssh.Tools.Sftp.SftpFileSytemInformation" data-throw-if-not-resolved="false"></xref> instance that contains file status information.</returns>
		public SftpFileSytemInformation GetStatus(string path)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Appends lines to a file, creating the file if it does not already exist.
		/// </summary>
		/// <param name="path">The file to append the lines to. The file is created if it does not already exist.</param>
		/// <param name="contents">The lines to append to the file.</param>
		public void AppendAllLines(string path, string[] contents)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Appends lines to a file by using a specified encoding, creating the file if it does not already exist.
		/// </summary>
		/// <param name="path">The file to append the lines to. The file is created if it does not already exist.</param>
		/// <param name="contents">The lines to append to the file.</param>
		/// <param name="encoding">The character encoding to use.</param>
		public void AppendAllLines(string path, string[] contents, Encoding encoding)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Appends the specified string to the file, creating the file if it does not already exist.
		/// </summary>
		/// <param name="path">The file to append the specified string to.</param>
		/// <param name="contents">The string to append to the file.</param>
		public void AppendAllText(string path, string contents)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Appends the specified string to the file, creating the file if it does not already exist.
		/// </summary>
		/// <param name="path">The file to append the specified string to.</param>
		/// <param name="contents">The string to append to the file.</param>
		/// <param name="encoding">The character encoding to use.</param>
		public void AppendAllText(string path, string contents, Encoding encoding)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Creates a <xref href="System.IO.StreamWriter" data-throw-if-not-resolved="false"></xref> that appends UTF-8 encoded text to the specified file,
		/// creating the file if it does not already exist.
		/// </summary>
		/// <param name="path">The path to the file to append to.</param>
		/// <returns>A <xref href="System.IO.StreamWriter" data-throw-if-not-resolved="false"></xref> that appends text to a file using UTF-8 encoding without a
		/// Byte-Order Mark (BOM).</returns>
		public StreamWriter AppendText(string path)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Creates a <xref href="System.IO.StreamWriter" data-throw-if-not-resolved="false"></xref> that appends text to a file using the specified
		/// encoding, creating the file if it does not already exist.
		/// </summary>
		/// <param name="path">The path to the file to append to.</param>
		/// <param name="encoding">The character encoding to use.</param>
		/// <returns>A <xref href="System.IO.StreamWriter" data-throw-if-not-resolved="false"></xref> that appends text to a file using the specified encoding.</returns>
		public StreamWriter AppendText(string path, Encoding encoding)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Creates or overwrites a file in the specified path.
		/// </summary>
		/// <param name="path">The path and name of the file to create.</param>
		/// <returns>A <xref href="UnderAutomation.UniversalRobots.Ssh.Tools.Sftp.SftpFileStream" data-throw-if-not-resolved="false"></xref> that provides read/write access to the file specified in path.</returns>
		public SftpFileStream Create(string path)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Creates or overwrites the specified file.
		/// </summary>
		/// <param name="path">The path and name of the file to create.</param>
		/// <param name="bufferSize">The maximum number of bytes buffered for reads and writes to the file.</param>
		/// <returns>A <xref href="UnderAutomation.UniversalRobots.Ssh.Tools.Sftp.SftpFileStream" data-throw-if-not-resolved="false"></xref> that provides read/write access to the file specified in path.</returns>
		public SftpFileStream Create(string path, int bufferSize)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Creates or opens a file for writing UTF-8 encoded text.
		/// </summary>
		/// <param name="path">The file to be opened for writing.</param>
		/// <returns>A <xref href="System.IO.StreamWriter" data-throw-if-not-resolved="false"></xref> that writes text to a file using UTF-8 encoding without
		/// a Byte-Order Mark (BOM).</returns>
		public StreamWriter CreateText(string path)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Creates or opens a file for writing text using the specified encoding.
		/// </summary>
		/// <param name="path">The file to be opened for writing.</param>
		/// <param name="encoding">The character encoding to use.</param>
		/// <returns>A <xref href="System.IO.StreamWriter" data-throw-if-not-resolved="false"></xref> that writes to a file using the specified encoding.</returns>
		public StreamWriter CreateText(string path, Encoding encoding)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Deletes the specified file or directory.
		/// </summary>
		/// <param name="path">The name of the file or directory to be deleted. Wildcard characters are not supported.</param>
		public void Delete(string path)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns the date and time the specified file or directory was last accessed.
		/// </summary>
		/// <param name="path">The file or directory for which to obtain access date and time information.</param>
		/// <returns>A <xref href="System.DateTime" data-throw-if-not-resolved="false"></xref> structure set to the date and time that the specified file or directory was last accessed.
		/// This value is expressed in local time.</returns>
		public DateTime GetLastAccessTime(string path)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Returns the date and time, in coordinated universal time (UTC), that the specified file or directory was last accessed.
		/// </summary>
		/// <param name="path">The file or directory for which to obtain access date and time information.</param>
		/// <returns>A <xref href="System.DateTime" data-throw-if-not-resolved="false"></xref> structure set to the date and time that the specified file or directory was last accessed.
		/// This value is expressed in UTC time.</returns>
		public DateTime GetLastAccessTimeUtc(string path)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Returns the date and time the specified file or directory was last written to.
		/// </summary>
		/// <param name="path">The file or directory for which to obtain write date and time information.</param>
		/// <returns>A <xref href="System.DateTime" data-throw-if-not-resolved="false"></xref> structure set to the date and time that the specified file or directory was last written to.
		/// This value is expressed in local time.</returns>
		public DateTime GetLastWriteTime(string path)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Returns the date and time, in coordinated universal time (UTC), that the specified file or directory was last written to.
		/// </summary>
		/// <param name="path">The file or directory for which to obtain write date and time information.</param>
		/// <returns>A <xref href="System.DateTime" data-throw-if-not-resolved="false"></xref> structure set to the date and time that the specified file or directory was last written to.
		/// This value is expressed in UTC time.</returns>
		public DateTime GetLastWriteTimeUtc(string path)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Opens a <xref href="UnderAutomation.UniversalRobots.Ssh.Tools.Sftp.SftpFileStream" data-throw-if-not-resolved="false"></xref> on the specified path with read/write access.
		/// </summary>
		/// <param name="path">The file to open.</param>
		/// <param name="mode">A <xref href="System.IO.FileMode" data-throw-if-not-resolved="false"></xref> value that specifies whether a file is created if one does not exist, and determines whether the contents of existing files are retained or overwritten.</param>
		/// <returns>An unshared <xref href="UnderAutomation.UniversalRobots.Ssh.Tools.Sftp.SftpFileStream" data-throw-if-not-resolved="false"></xref> that provides access to the specified file, with the specified mode and read/write access.</returns>
		public SftpFileStream Open(string path, FileMode mode)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Opens a <xref href="UnderAutomation.UniversalRobots.Ssh.Tools.Sftp.SftpFileStream" data-throw-if-not-resolved="false"></xref> on the specified path, with the specified mode and access.
		/// </summary>
		/// <param name="path">The file to open.</param>
		/// <param name="mode">A <xref href="System.IO.FileMode" data-throw-if-not-resolved="false"></xref> value that specifies whether a file is created if one does not exist, and determines whether the contents of existing files are retained or overwritten.</param>
		/// <param name="access">A <xref href="System.IO.FileAccess" data-throw-if-not-resolved="false"></xref> value that specifies the operations that can be performed on the file.</param>
		/// <returns>An unshared <xref href="UnderAutomation.UniversalRobots.Ssh.Tools.Sftp.SftpFileStream" data-throw-if-not-resolved="false"></xref> that provides access to the specified file, with the specified mode and access.</returns>
		public SftpFileStream Open(string path, FileMode mode, FileAccess access)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Opens an existing file for reading.
		/// </summary>
		/// <param name="path">The file to be opened for reading.</param>
		/// <returns>A read-only <xref href="UnderAutomation.UniversalRobots.Ssh.Tools.Sftp.SftpFileStream" data-throw-if-not-resolved="false"></xref> on the specified path.</returns>
		public SftpFileStream OpenRead(string path)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Opens an existing UTF-8 encoded text file for reading.
		/// </summary>
		/// <param name="path">The file to be opened for reading.</param>
		/// <returns>A <xref href="System.IO.StreamReader" data-throw-if-not-resolved="false"></xref> on the specified path.</returns>
		public StreamReader OpenText(string path)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Opens a file for writing.
		/// </summary>
		/// <param name="path">The file to be opened for writing.</param>
		/// <returns>An unshared <xref href="UnderAutomation.UniversalRobots.Ssh.Tools.Sftp.SftpFileStream" data-throw-if-not-resolved="false"></xref> object on the specified path with <xref href="System.IO.FileAccess.Write" data-throw-if-not-resolved="false"></xref> access.</returns>
		public SftpFileStream OpenWrite(string path)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Opens a binary file, reads the contents of the file into a byte array, and closes the file.
		/// </summary>
		/// <param name="path">The file to open for reading.</param>
		/// <returns>A byte array containing the contents of the file.</returns>
		public byte[] ReadAllBytes(string path)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Opens a text file, reads all lines of the file using UTF-8 encoding, and closes the file.
		/// </summary>
		/// <param name="path">The file to open for reading.</param>
		/// <returns>A string array containing all lines of the file.</returns>
		public string[] ReadAllLines(string path)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Opens a file, reads all lines of the file with the specified encoding, and closes the file.
		/// </summary>
		/// <param name="path">The file to open for reading.</param>
		/// <param name="encoding">The encoding applied to the contents of the file.</param>
		/// <returns>A string array containing all lines of the file.</returns>
		public string[] ReadAllLines(string path, Encoding encoding)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Opens a text file, reads all lines of the file with the UTF-8 encoding, and closes the file.
		/// </summary>
		/// <param name="path">The file to open for reading.</param>
		/// <returns>A string containing all lines of the file.</returns>
		public string ReadAllText(string path)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Opens a file, reads all lines of the file with the specified encoding, and closes the file.
		/// </summary>
		/// <param name="path">The file to open for reading.</param>
		/// <param name="encoding">The encoding applied to the contents of the file.</param>
		/// <returns>A string containing all lines of the file.</returns>
		public string ReadAllText(string path, Encoding encoding)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads the lines of a file with the UTF-8 encoding.
		/// </summary>
		/// <param name="path">The file to read.</param>
		/// <returns>The lines of the file.</returns>
		public string[] ReadLines(string path)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Read the lines of a file that has a specified encoding.
		/// </summary>
		/// <param name="path">The file to read.</param>
		/// <param name="encoding">The encoding that is applied to the contents of the file.</param>
		/// <returns>The lines of the file.</returns>
		public string[] ReadLines(string path, Encoding encoding)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Writes the specified byte array to the specified file, and closes the file.
		/// </summary>
		/// <param name="path">The file to write to.</param>
		/// <param name="bytes">The bytes to write to the file.</param>
		public void WriteAllBytes(string path, byte[] bytes)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Writes a collection of strings to the file using the UTF-8 encoding, and closes the file.
		/// </summary>
		/// <param name="path">The file to write to.</param>
		/// <param name="contents">The lines to write to the file.</param>
		public void WriteAllLines(string path, string[] contents)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Writes the specified string to the file using the UTF-8 encoding, and closes the file.
		/// </summary>
		/// <param name="path">The file to write to.</param>
		/// <param name="contents">The string to write to the file.</param>
		public void WriteAllText(string path, string contents)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Writes the specified string to the file using the specified encoding, and closes the file.
		/// </summary>
		/// <param name="path">The file to write to.</param>
		/// <param name="contents">The string to write to the file.</param>
		/// <param name="encoding">The encoding to apply to the string.</param>
		public void WriteAllText(string path, string contents, Encoding encoding)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Gets the <xref href="UnderAutomation.UniversalRobots.Ssh.Tools.Sftp.SftpFileAttributes" data-throw-if-not-resolved="false"></xref> of the file on the path.
		/// </summary>
		/// <param name="path">The path to the file.</param>
		/// <returns>The <xref href="UnderAutomation.UniversalRobots.Ssh.Tools.Sftp.SftpFileAttributes" data-throw-if-not-resolved="false"></xref> of the file on the path.</returns>
		public SftpFileAttributes GetAttributes(string path)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Sets the specified <xref href="UnderAutomation.UniversalRobots.Ssh.Tools.Sftp.SftpFileAttributes" data-throw-if-not-resolved="false"></xref> of the file on the specified path.
		/// </summary>
		/// <param name="path">The path to the file.</param>
		/// <param name="fileAttributes">The desired <xref href="UnderAutomation.UniversalRobots.Ssh.Tools.Sftp.SftpFileAttributes" data-throw-if-not-resolved="false"></xref>.</param>
		public void SetAttributes(string path, SftpFileAttributes fileAttributes)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Synchronizes the directories.
		/// </summary>
		/// <param name="sourcePath">The source path.</param>
		/// <param name="destinationPath">The destination path.</param>
		/// <param name="searchPattern">The search pattern.</param>
		/// <returns>A list of uploaded files.</returns>
		public FileInfo[] SynchronizeDirectories(string sourcePath, string destinationPath, string searchPattern)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Begins the synchronize directories.
		/// </summary>
		/// <param name="sourcePath">The source path.</param>
		/// <param name="destinationPath">The destination path.</param>
		/// <param name="searchPattern">The search pattern.</param>
		/// <param name="asyncCallback">The async callback.</param>
		/// <param name="state">The state.</param>
		/// <returns>An <xref href="System.IAsyncResult" data-throw-if-not-resolved="false"></xref> that represents the asynchronous directory synchronization.</returns>
		public IAsyncResult BeginSynchronizeDirectories(string sourcePath, string destinationPath, string searchPattern, AsyncCallback asyncCallback, object state)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Ends the synchronize directories.
		/// </summary>
		/// <param name="asyncResult">The async result.</param>
		/// <returns>A list of uploaded files.</returns>
		public FileInfo[] EndSynchronizeDirectories(IAsyncResult asyncResult)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
