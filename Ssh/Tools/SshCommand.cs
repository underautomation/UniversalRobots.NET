//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.IO;

namespace Ssh.Tools {
	/// <summary>
	/// Represents SSH command that can be executed.
	/// </summary>
	public class SshCommand : IDisposable {

		/// <summary>
		/// Gets the command text.
		/// </summary>
		public string CommandText { get; }

		/// <summary>
		/// Gets or sets the command timeout.
		/// </summary>
		/// <returns>The command timeout.</returns>
		public TimeSpan CommandTimeout { get; set; }

		/// <summary>
		/// Gets the command exit status.
		/// </summary>
		public int ExitStatus { get; }

		/// <summary>
		/// Gets the output stream.
		/// </summary>
		public Stream OutputStream { get; }

		/// <summary>
		/// Gets the extended output stream.
		/// </summary>
		public Stream ExtendedOutputStream { get; }

		/// <summary>
		/// Gets the command execution result.
		/// </summary>
		public string Result { get; }

		/// <summary>
		/// Gets the command execution error.
		/// </summary>
		public string Error { get; }

		/// <summary>
		/// Begins an asynchronous command execution.
		/// </summary>
		/// <returns>An <xref href="System.IAsyncResult" data-throw-if-not-resolved="false"></xref> that represents the asynchronous command execution, which could still be pending.</returns>
		public IAsyncResult BeginExecute()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Begins an asynchronous command execution.
		/// </summary>
		/// <param name="callback">An optional asynchronous callback, to be called when the command execution is complete.</param>
		/// <returns>An <xref href="System.IAsyncResult" data-throw-if-not-resolved="false"></xref> that represents the asynchronous command execution, which could still be pending.</returns>
		public IAsyncResult BeginExecute(AsyncCallback callback)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Begins an asynchronous command execution.
		/// </summary>
		/// <param name="callback">An optional asynchronous callback, to be called when the command execution is complete.</param>
		/// <param name="state">A user-provided object that distinguishes this particular asynchronous read request from other requests.</param>
		/// <returns>An <xref href="System.IAsyncResult" data-throw-if-not-resolved="false"></xref> that represents the asynchronous command execution, which could still be pending.</returns>
		public IAsyncResult BeginExecute(AsyncCallback callback, object state)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Begins an asynchronous command execution.
		/// </summary>
		/// <param name="commandText">The command text.</param>
		/// <param name="callback">An optional asynchronous callback, to be called when the command execution is complete.</param>
		/// <param name="state">A user-provided object that distinguishes this particular asynchronous read request from other requests.</param>
		/// <returns>An <xref href="System.IAsyncResult" data-throw-if-not-resolved="false"></xref> that represents the asynchronous command execution, which could still be pending.</returns>
		public IAsyncResult BeginExecute(string commandText, AsyncCallback callback, object state)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Waits for the pending asynchronous command execution to complete.
		/// </summary>
		/// <param name="asyncResult">The reference to the pending asynchronous request to finish.</param>
		/// <returns>Command execution result.</returns>
		public string EndExecute(IAsyncResult asyncResult)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Executes command specified by <xref href="UnderAutomation.UniversalRobots.Ssh.Tools.SshCommand.CommandText" data-throw-if-not-resolved="false"></xref> property.
		/// </summary>
		/// <returns>Command execution result</returns>
		public string Execute()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Cancels command execution in asynchronous scenarios.
		/// </summary>
		public void CancelAsync()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Executes the specified command text.
		/// </summary>
		/// <param name="commandText">The command text.</param>
		/// <returns>Command execution result</returns>
		public string Execute(string commandText)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		public void Dispose()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Releases unmanaged and - optionally - managed resources
		/// </summary>
		/// <param name="disposing"><code>true</code> to release both managed and unmanaged resources; <code>false</code> to release only unmanaged resources.</param>
		protected virtual void Dispose(bool disposing)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
