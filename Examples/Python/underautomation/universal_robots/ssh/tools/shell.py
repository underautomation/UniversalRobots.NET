import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools import Shell as shell

class Shell:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = shell()
		else:
			self._instance = _internal
	def add__starting(self, value: typing.Any) -> None:
		self._instance.add_Starting(value)
	def remove__starting(self, value: typing.Any) -> None:
		self._instance.remove_Starting(value)
	def add__started(self, value: typing.Any) -> None:
		self._instance.add_Started(value)
	def remove__started(self, value: typing.Any) -> None:
		self._instance.remove_Started(value)
	def add__stopping(self, value: typing.Any) -> None:
		self._instance.add_Stopping(value)
	def remove__stopping(self, value: typing.Any) -> None:
		self._instance.remove_Stopping(value)
	def add__stopped(self, value: typing.Any) -> None:
		self._instance.add_Stopped(value)
	def remove__stopped(self, value: typing.Any) -> None:
		self._instance.remove_Stopped(value)
	def add__error_occurred(self, value: typing.Any) -> None:
		self._instance.add_ErrorOccurred(value)
	def remove__error_occurred(self, value: typing.Any) -> None:
		self._instance.remove_ErrorOccurred(value)
	def start(self) -> None:
		self._instance.Start()
	def stop(self) -> None:
		self._instance.Stop()
	def dispose(self) -> None:
		self._instance.Dispose()
	@property
	def is_started(self) -> bool:
		return self._instance.IsStarted
