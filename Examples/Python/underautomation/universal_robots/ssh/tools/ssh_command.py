import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools import SshCommand as ssh_command

class SshCommand:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = ssh_command()
		else:
			self._instance = _internal
	def begin_execute(self) -> typing.Any:
		return self._instance.BeginExecute()
	def begin_execute(self, callback: typing.Any) -> typing.Any:
		return self._instance.BeginExecute(callback)
	def begin_execute(self, callback: typing.Any, state: typing.Any) -> typing.Any:
		return self._instance.BeginExecute(callback, state)
	def begin_execute(self, commandText: str, callback: typing.Any, state: typing.Any) -> typing.Any:
		return self._instance.BeginExecute(commandText, callback, state)
	def end_execute(self, asyncResult: typing.Any) -> str:
		return self._instance.EndExecute(asyncResult)
	def execute(self) -> str:
		return self._instance.Execute()
	def cancel_async(self) -> None:
		self._instance.CancelAsync()
	def execute(self, commandText: str) -> str:
		return self._instance.Execute(commandText)
	def dispose(self) -> None:
		self._instance.Dispose()
	@property
	def command_text(self) -> str:
		return self._instance.CommandText
	@property
	def command_timeout(self) -> typing.Any:
		return self._instance.CommandTimeout
	@command_timeout.setter
	def command_timeout(self, value: typing.Any):
		self._instance.CommandTimeout = value
	@property
	def exit_status(self) -> int:
		return self._instance.ExitStatus
	@property
	def output_stream(self) -> typing.Any:
		return self._instance.OutputStream
	@property
	def extended_output_stream(self) -> typing.Any:
		return self._instance.ExtendedOutputStream
	@property
	def result(self) -> str:
		return self._instance.Result
	@property
	def error(self) -> str:
		return self._instance.Error
