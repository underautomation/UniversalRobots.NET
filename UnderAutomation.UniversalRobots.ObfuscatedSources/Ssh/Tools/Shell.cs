//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;
using Ssh.Tools.Common;

namespace Ssh.Tools {
	/// <summary>
	/// Represents instance of the SSH shell object
	/// </summary>
	public class Shell : IDisposable {

		/// <summary>
		/// Gets a value indicating whether this shell is started.
		/// </summary>
		/// <returns><code>true</code> if started is started; otherwise, <code>false</code>.</returns>
		public bool IsStarted { get; }

		/// <summary>
		/// Occurs when shell is starting.
		/// </summary>
		public event EventHandler<EventArgs> Starting;

		/// <summary>
		/// Occurs when shell is started.
		/// </summary>
		public event EventHandler<EventArgs> Started;

		/// <summary>
		/// Occurs when shell is stopping.
		/// </summary>
		public event EventHandler<EventArgs> Stopping;

		/// <summary>
		/// Occurs when shell is stopped.
		/// </summary>
		public event EventHandler<EventArgs> Stopped;

		/// <summary>
		/// Occurs when an error occurred.
		/// </summary>
		public event EventHandler<ExceptionEventArgs> ErrorOccurred;

		/// <summary>
		/// Starts this shell.
		/// </summary>
		public void Start()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Stops this shell.
		/// </summary>
		public void Stop()
		{
			// Source is hidden, a Source licence is needed to access internal code...
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
