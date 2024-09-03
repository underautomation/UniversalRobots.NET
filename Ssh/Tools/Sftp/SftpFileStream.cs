//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.IO;

namespace Ssh.Tools.Sftp {
	/// <summary>
	/// Exposes a <xref href="System.IO.Stream" data-throw-if-not-resolved="false"></xref> around a remote SFTP file, supporting both synchronous and asynchronous read and write operations.
	/// </summary>
	public class SftpFileStream : Stream, IDisposable {

		/// <summary>
		/// Gets a value indicating whether the current stream supports reading.
		/// </summary>
		/// <returns><code>true</code> if the stream supports reading; otherwise, <code>false</code>.</returns>
		public override bool CanRead { get; }

		/// <summary>
		/// Gets a value indicating whether the current stream supports seeking.
		/// </summary>
		/// <returns><code>true</code> if the stream supports seeking; otherwise, <code>false</code>.</returns>
		public override bool CanSeek { get; }

		/// <summary>
		/// Gets a value indicating whether the current stream supports writing.
		/// </summary>
		/// <returns><code>true</code> if the stream supports writing; otherwise, <code>false</code>.</returns>
		public override bool CanWrite { get; }

		/// <summary>
		/// Indicates whether timeout properties are usable for <xref href="UnderAutomation.UniversalRobots.Ssh.Tools.Sftp.SftpFileStream" data-throw-if-not-resolved="false"></xref>.
		/// </summary>
		/// <returns><code>true</code> in all cases.</returns>
		public override bool CanTimeout { get; }

		/// <summary>
		/// Gets the length in bytes of the stream.
		/// </summary>
		/// <returns>A long value representing the length of the stream in bytes.</returns>
		public override long Length { get; }

		/// <summary>
		/// Gets or sets the position within the current stream.
		/// </summary>
		/// <returns>The current position within the stream.</returns>
		public override long Position { get; set; }

		/// <summary>
		/// Gets the name of the path that was used to construct the current <xref href="UnderAutomation.UniversalRobots.Ssh.Tools.Sftp.SftpFileStream" data-throw-if-not-resolved="false"></xref>.
		/// </summary>
		/// <returns>The name of the path that was used to construct the current <xref href="UnderAutomation.UniversalRobots.Ssh.Tools.Sftp.SftpFileStream" data-throw-if-not-resolved="false"></xref>.</returns>
		public string Name { get; }

		/// <summary>
		/// Gets the operating system file handle for the file that the current <xref href="UnderAutomation.UniversalRobots.Ssh.Tools.Sftp.SftpFileStream" data-throw-if-not-resolved="false"></xref> encapsulates.
		/// </summary>
		/// <returns>The operating system file handle for the file that the current <xref href="UnderAutomation.UniversalRobots.Ssh.Tools.Sftp.SftpFileStream" data-throw-if-not-resolved="false"></xref> encapsulates.</returns>
		public virtual byte[] Handle { get; }

		/// <summary>
		/// Gets or sets the operation timeout.
		/// </summary>
		/// <returns>The timeout.</returns>
		public TimeSpan Timeout { get; set; }

		/// <summary>
		/// Clears all buffers for this stream and causes any buffered data to be written to the file.
		/// </summary>
		public override void Flush()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Reads a sequence of bytes from the current stream and advances the position within the stream by the
		/// number of bytes read.
		/// </summary>
		/// <param name="buffer">An array of bytes. When this method returns, the buffer contains the specified byte array with the values between <code class="paramref">offset</code> and (<code class="paramref">offset</code> + <code class="paramref">count</code> - 1) replaced by the bytes read from the current source.</param>
		/// <param name="offset">The zero-based byte offset in <code class="paramref">buffer</code> at which to begin storing the data read from the current stream.</param>
		/// <param name="count">The maximum number of bytes to be read from the current stream.</param>
		/// <returns>The total number of bytes read into the buffer. This can be less than the number of bytes requested
		/// if that many bytes are not currently available, or zero (0) if the end of the stream has been reached.</returns>
		public override int Read(byte[] buffer, int offset, int count)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads a byte from the stream and advances the position within the stream by one byte, or returns -1 if at the end of the stream.
		/// </summary>
		/// <returns>The unsigned byte cast to an <xref href="System.Int32" data-throw-if-not-resolved="false"></xref>, or -1 if at the end of the stream.</returns>
		public override int ReadByte()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Sets the position within the current stream.
		/// </summary>
		/// <param name="offset">A byte offset relative to the <code class="paramref">origin</code> parameter.</param>
		/// <param name="origin">A value of type <xref href="System.IO.SeekOrigin" data-throw-if-not-resolved="false"></xref> indicating the reference point used to obtain the new position.</param>
		/// <returns>The new position within the current stream.</returns>
		public override long Seek(long offset, SeekOrigin origin)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Sets the length of the current stream.
		/// </summary>
		/// <param name="value">The desired length of the current stream in bytes.</param>
		public override void SetLength(long value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Writes a sequence of bytes to the current stream and advances the current position within this stream by the number of bytes written.
		/// </summary>
		/// <param name="buffer">An array of bytes. This method copies <code class="paramref">count</code> bytes from <code class="paramref">buffer</code> to the current stream.</param>
		/// <param name="offset">The zero-based byte offset in <code class="paramref">buffer</code> at which to begin copying bytes to the current stream.</param>
		/// <param name="count">The number of bytes to be written to the current stream.</param>
		public override void Write(byte[] buffer, int offset, int count)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Writes a byte to the current position in the stream and advances the position within the stream by one byte.
		/// </summary>
		/// <param name="value">The byte to write to the stream.</param>
		public override void WriteByte(byte value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Releases the unmanaged resources used by the <xref href="System.IO.Stream" data-throw-if-not-resolved="false"></xref> and optionally releases the managed resources.
		/// </summary>
		/// <param name="disposing"><code>true</code> to release both managed and unmanaged resources; <code>false</code> to release only unmanaged resources.</param>
		protected override void Dispose(bool disposing)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
