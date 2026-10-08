//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.UniversalRobots.Ssh.Tools {
	/// <summary>
	/// Supports port forwarding functionality.
	/// </summary>
	public interface IForwardedPort {

		/// <summary>
		/// The <see cref="UnderAutomation.UniversalRobots.Ssh.Tools.IForwardedPort.Closing"/> event occurs as the forwarded port is being stopped.
		/// </summary>
		event EventHandler Closing;
	}
}
