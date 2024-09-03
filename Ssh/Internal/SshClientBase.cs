//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Internal;
using Ssh.Tools;
using System.Text;
using System.IO;
using System.Collections.Generic;
using Ssh.Tools.Common;
using System;

namespace Ssh.Internal {
	/// <summary>
	/// Provides a client connection to SSH server
	/// </summary>
	public abstract class SshClientBase : URServiceBase {

		/// <summary>
		/// Gets a value indicating if this client is connected to the robot
		/// </summary>
		public bool Connected { get; }


		protected void ConnectInternal(string ip, int port, string username, string password)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Disconnects this client from the SSH server
		/// </summary>
		public void Disconnect()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Creates the command to be executed.
		/// </summary>
		/// <param name="commandText">The command text.</param>
		/// <returns><xref href="UnderAutomation.UniversalRobots.Ssh.Tools.SshCommand" data-throw-if-not-resolved="false"></xref> object.</returns>
		public SshCommand CreateCommand(string commandText)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Creates the command to be executed with specified encoding.
		/// </summary>
		/// <param name="commandText">The command text.</param>
		/// <param name="encoding">The encoding to use for results.</param>
		/// <returns><xref href="UnderAutomation.UniversalRobots.Ssh.Tools.SshCommand" data-throw-if-not-resolved="false"></xref> object which uses specified encoding.</returns>
		public SshCommand CreateCommand(string commandText, Encoding encoding)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Creates and executes the command.
		/// </summary>
		/// <param name="commandText">The command text.</param>
		/// <returns>Returns an instance of <xref href="UnderAutomation.UniversalRobots.Ssh.Tools.SshCommand" data-throw-if-not-resolved="false"></xref> with execution results.</returns>
		public SshCommand RunCommand(string commandText)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Creates the shell.
		/// </summary>
		/// <param name="input">The input.</param>
		/// <param name="output">The output.</param>
		/// <param name="extendedOutput">The extended output.</param>
		/// <param name="terminalName">Name of the terminal.</param>
		/// <param name="columns">The columns.</param>
		/// <param name="rows">The rows.</param>
		/// <param name="width">The width.</param>
		/// <param name="height">The height.</param>
		/// <param name="terminalModes">The terminal mode.</param>
		/// <param name="bufferSize">Size of the internal read buffer.</param>
		/// <returns>Returns a representation of a <xref href="UnderAutomation.UniversalRobots.Ssh.Tools.Shell" data-throw-if-not-resolved="false"></xref> object.</returns>
		public Shell CreateShell(Stream input, Stream output, Stream extendedOutput, string terminalName, uint columns, uint rows, uint width, uint height, IDictionary<TerminalModes, uint> terminalModes, int bufferSize)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Creates the shell.
		/// </summary>
		/// <param name="input">The input.</param>
		/// <param name="output">The output.</param>
		/// <param name="extendedOutput">The extended output.</param>
		/// <param name="terminalName">Name of the terminal.</param>
		/// <param name="columns">The columns.</param>
		/// <param name="rows">The rows.</param>
		/// <param name="width">The width.</param>
		/// <param name="height">The height.</param>
		/// <param name="terminalModes">The terminal mode.</param>
		/// <returns>Returns a representation of a <xref href="UnderAutomation.UniversalRobots.Ssh.Tools.Shell" data-throw-if-not-resolved="false"></xref> object.</returns>
		public Shell CreateShell(Stream input, Stream output, Stream extendedOutput, string terminalName, uint columns, uint rows, uint width, uint height, IDictionary<TerminalModes, uint> terminalModes)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Creates the shell.
		/// </summary>
		/// <param name="input">The input.</param>
		/// <param name="output">The output.</param>
		/// <param name="extendedOutput">The extended output.</param>
		/// <returns>Returns a representation of a <xref href="UnderAutomation.UniversalRobots.Ssh.Tools.Shell" data-throw-if-not-resolved="false"></xref> object.</returns>
		public Shell CreateShell(Stream input, Stream output, Stream extendedOutput)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Creates the shell.
		/// </summary>
		/// <param name="encoding">The encoding to use to send the input.</param>
		/// <param name="input">The input.</param>
		/// <param name="output">The output.</param>
		/// <param name="extendedOutput">The extended output.</param>
		/// <param name="terminalName">Name of the terminal.</param>
		/// <param name="columns">The columns.</param>
		/// <param name="rows">The rows.</param>
		/// <param name="width">The width.</param>
		/// <param name="height">The height.</param>
		/// <param name="terminalModes">The terminal mode.</param>
		/// <param name="bufferSize">Size of the internal read buffer.</param>
		/// <returns>Returns a representation of a <xref href="UnderAutomation.UniversalRobots.Ssh.Tools.Shell" data-throw-if-not-resolved="false"></xref> object.</returns>
		public Shell CreateShell(Encoding encoding, string input, Stream output, Stream extendedOutput, string terminalName, uint columns, uint rows, uint width, uint height, IDictionary<TerminalModes, uint> terminalModes, int bufferSize)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Creates the shell.
		/// </summary>
		/// <param name="encoding">The encoding.</param>
		/// <param name="input">The input.</param>
		/// <param name="output">The output.</param>
		/// <param name="extendedOutput">The extended output.</param>
		/// <param name="terminalName">Name of the terminal.</param>
		/// <param name="columns">The columns.</param>
		/// <param name="rows">The rows.</param>
		/// <param name="width">The width.</param>
		/// <param name="height">The height.</param>
		/// <param name="terminalModes">The terminal modes.</param>
		/// <returns>Returns a representation of a <xref href="UnderAutomation.UniversalRobots.Ssh.Tools.Shell" data-throw-if-not-resolved="false"></xref> object.</returns>
		public Shell CreateShell(Encoding encoding, string input, Stream output, Stream extendedOutput, string terminalName, uint columns, uint rows, uint width, uint height, IDictionary<TerminalModes, uint> terminalModes)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Creates the shell.
		/// </summary>
		/// <param name="encoding">The encoding.</param>
		/// <param name="input">The input.</param>
		/// <param name="output">The output.</param>
		/// <param name="extendedOutput">The extended output.</param>
		/// <returns>Returns a representation of a <xref href="UnderAutomation.UniversalRobots.Ssh.Tools.Shell" data-throw-if-not-resolved="false"></xref> object.</returns>
		public Shell CreateShell(Encoding encoding, string input, Stream output, Stream extendedOutput)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Creates the shell stream.
		/// </summary>
		/// <param name="terminalName">The <code>TERM</code> environment variable.</param>
		/// <param name="columns">The terminal width in columns.</param>
		/// <param name="rows">The terminal width in rows.</param>
		/// <param name="width">The terminal height in pixels.</param>
		/// <param name="height">The terminal height in pixels.</param>
		/// <param name="bufferSize">The size of the buffer.</param>
		/// <returns>The created <xref href="UnderAutomation.UniversalRobots.Ssh.Tools.ShellStream" data-throw-if-not-resolved="false"></xref> instance.</returns>
		public ShellStream CreateShellStream(string terminalName, uint columns, uint rows, uint width, uint height, int bufferSize)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Creates the shell stream.
		/// </summary>
		/// <param name="terminalName">The <code>TERM</code> environment variable.</param>
		/// <param name="columns">The terminal width in columns.</param>
		/// <param name="rows">The terminal width in rows.</param>
		/// <param name="width">The terminal height in pixels.</param>
		/// <param name="height">The terminal height in pixels.</param>
		/// <param name="bufferSize">The size of the buffer.</param>
		/// <param name="terminalModeValues">The terminal mode values.</param>
		/// <returns>The created <xref href="UnderAutomation.UniversalRobots.Ssh.Tools.ShellStream" data-throw-if-not-resolved="false"></xref> instance.</returns>
		public ShellStream CreateShellStream(string terminalName, uint columns, uint rows, uint width, uint height, int bufferSize, IDictionary<TerminalModes, uint> terminalModeValues)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
