//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.IO;
using System;
using Ssh.Tools.Common;
using System.Text.RegularExpressions;

namespace Ssh.Tools {
	/// <summary>
	/// Contains operation for working with SSH Shell.
	/// </summary>
	public class ShellStream : Stream, IDisposable {

		/// <summary>
		/// Occurs when data was received.
		/// </summary>
		public event EventHandler<ShellDataEventArgs> DataReceived;

		/// <summary>
		/// Occurs when an error occurred.
		/// </summary>
		public event EventHandler<ExceptionEventArgs> ErrorOccurred;

		/// <summary>
		/// Gets a value that indicates whether data is available on the <xref href="UnderAutomation.UniversalRobots.Ssh.Tools.ShellStream" data-throw-if-not-resolved="false"></xref> to be read.
		/// </summary>
		/// <returns><code>true</code> if data is available to be read; otherwise, <code>false</code>.</returns>
		public bool DataAvailable { get; }

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
		/// Clears all buffers for this stream and causes any buffered data to be written to the underlying device.
		/// </summary>
		public override void Flush()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

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
		/// Reads a sequence of bytes from the current stream and advances the position within the stream by the number of bytes read.
		/// </summary>
		/// <param name="buffer">An array of bytes. When this method returns, the buffer contains the specified byte array with the values between <code class="paramref">offset</code> and (<code class="paramref">offset</code> + <code class="paramref">count</code> - 1) replaced by the bytes read from the current source.</param>
		/// <param name="offset">The zero-based byte offset in <code class="paramref">buffer</code> at which to begin storing the data read from the current stream.</param>
		/// <param name="count">The maximum number of bytes to be read from the current stream.</param>
		/// <returns>The total number of bytes read into the buffer. This can be less than the number of bytes requested if that many bytes are not currently available, or zero (0) if the end of the stream has been reached.</returns>
		public override int Read(byte[] buffer, int offset, int count)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// This method is not supported.
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
		/// This method is not supported.
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
		/// Expects the specified expression and performs action when one is found.
		/// </summary>
		/// <param name="expectActions">The expected expressions and actions to perform.</param>
		public void Expect(params ExpectAction[] expectActions)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Expects the specified expression and performs action when one is found.
		/// </summary>
		/// <param name="timeout">Time to wait for input.</param>
		/// <param name="expectActions">The expected expressions and actions to perform, if the specified time elapsed and expected condition have not met, that method will exit without executing any action.</param>
		public void Expect(TimeSpan timeout, params ExpectAction[] expectActions)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Begins the expect.
		/// </summary>
		/// <param name="expectActions">The expect actions.</param>
		/// <returns>An <xref href="System.IAsyncResult" data-throw-if-not-resolved="false"></xref> that references the asynchronous operation.</returns>
		public IAsyncResult BeginExpect(params ExpectAction[] expectActions)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Begins the expect.
		/// </summary>
		/// <param name="callback">The callback.</param>
		/// <param name="expectActions">The expect actions.</param>
		/// <returns>An <xref href="System.IAsyncResult" data-throw-if-not-resolved="false"></xref> that references the asynchronous operation.</returns>
		public IAsyncResult BeginExpect(AsyncCallback callback, params ExpectAction[] expectActions)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Begins the expect.
		/// </summary>
		/// <param name="callback">The callback.</param>
		/// <param name="state">The state.</param>
		/// <param name="expectActions">The expect actions.</param>
		/// <returns>An <xref href="System.IAsyncResult" data-throw-if-not-resolved="false"></xref> that references the asynchronous operation.</returns>
		public IAsyncResult BeginExpect(AsyncCallback callback, object state, params ExpectAction[] expectActions)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Begins the expect.
		/// </summary>
		/// <param name="timeout">The timeout.</param>
		/// <param name="callback">The callback.</param>
		/// <param name="state">The state.</param>
		/// <param name="expectActions">The expect actions.</param>
		/// <returns>An <xref href="System.IAsyncResult" data-throw-if-not-resolved="false"></xref> that references the asynchronous operation.</returns>
		public IAsyncResult BeginExpect(TimeSpan timeout, AsyncCallback callback, object state, params ExpectAction[] expectActions)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Ends the execute.
		/// </summary>
		/// <param name="asyncResult">The async result.</param>
		public string EndExpect(IAsyncResult asyncResult)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Expects the expression specified by text.
		/// </summary>
		/// <param name="text">The text to expect.</param>
		/// <returns>Text available in the shell that ends with expected text.</returns>
		public string Expect(string text)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Expects the expression specified by text.
		/// </summary>
		/// <param name="text">The text to expect.</param>
		/// <param name="timeout">Time to wait for input.</param>
		/// <returns>The text available in the shell that ends with expected text, or <code>null</code> if the specified time has elapsed.</returns>
		public string Expect(string text, TimeSpan timeout)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Expects the expression specified by regular expression.
		/// </summary>
		/// <param name="regex">The regular expression to expect.</param>
		/// <returns>The text available in the shell that contains all the text that ends with expected expression.</returns>
		public string Expect(Regex regex)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Expects the expression specified by regular expression.
		/// </summary>
		/// <param name="regex">The regular expression to expect.</param>
		/// <param name="timeout">Time to wait for input.</param>
		/// <returns>The text available in the shell that contains all the text that ends with expected expression,
		/// or <code>null</code> if the specified time has elapsed.</returns>
		public string Expect(Regex regex, TimeSpan timeout)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads the line from the shell. If line is not available it will block the execution and will wait for new line.
		/// </summary>
		/// <returns>The line read from the shell.</returns>
		public string ReadLine()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads a line from the shell. If line is not available it will block the execution and will wait for new line.
		/// </summary>
		/// <param name="timeout">Time to wait for input.</param>
		/// <returns>The line read from the shell, or <code>null</code> when no input is received for the specified timeout.</returns>
		public string ReadLine(TimeSpan timeout)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads text available in the shell.
		/// </summary>
		/// <returns>The text available in the shell.</returns>
		public string Read()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Writes the specified text to the shell.
		/// </summary>
		/// <param name="text">The text to be written to the shell.</param>
		public void Write(string text)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Writes the line to the shell.
		/// </summary>
		/// <param name="line">The line to be written to the shell.</param>
		public void WriteLine(string line)
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
