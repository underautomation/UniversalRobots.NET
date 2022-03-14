import typing
from underautomation.universal_robots.ssh.tools.ssh_command import SshCommand
from underautomation.universal_robots.ssh.tools.shell import Shell
from underautomation.universal_robots.ssh.tools.shell_stream import ShellStream
from underautomation.universal_robots.internal.ur_service_base import URServiceBase
from underautomation.universal_robots.ssh.tools.common.terminal_modes import TerminalModes
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Internal import SshClientBase as ssh_client_base

class SshClientBase(URServiceBase):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = ssh_client_base()
		else:
			self._instance = _internal
	def disconnect(self) -> None:
		self._instance.Disconnect()
	def create_command(self, commandText: str, encoding: typing.Any) -> SshCommand:
		return SshCommand(self._instance.CreateCommand(commandText, encoding))
	def run_command(self, commandText: str) -> SshCommand:
		return SshCommand(self._instance.RunCommand(commandText))
	def create_shell(self, encoding: typing.Any, input: str, output: typing.Any, extendedOutput: typing.Any, terminalName: str, columns: int, rows: int, width: int, height: int, terminalModes: typing.Any, bufferSize: int) -> Shell:
		return Shell(self._instance.CreateShell(encoding, input, output, extendedOutput, terminalName, columns, rows, width, height, terminalModes, bufferSize))
	def create_shell_stream(self, terminalName: str, columns: int, rows: int, width: int, height: int, bufferSize: int, terminalModeValues: typing.Any) -> ShellStream:
		return ShellStream(self._instance.CreateShellStream(terminalName, columns, rows, width, height, bufferSize, terminalModeValues))
	@property
	def connected(self) -> bool:
		return self._instance.Connected
