import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools import CommandAsyncResult as command_async_result

class CommandAsyncResult:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = command_async_result()
		else:
			self._instance = _internal
	@property
	def bytes_received(self) -> int:
		return self._instance.BytesReceived
	@bytes_received.setter
	def bytes_received(self, value: int):
		self._instance.BytesReceived = value
	@property
	def bytes_sent(self) -> int:
		return self._instance.BytesSent
	@bytes_sent.setter
	def bytes_sent(self, value: int):
		self._instance.BytesSent = value
	@property
	def async_state(self) -> typing.Any:
		return self._instance.AsyncState
	@property
	def async_wait_handle(self) -> typing.Any:
		return self._instance.AsyncWaitHandle
	@property
	def completed_synchronously(self) -> bool:
		return self._instance.CompletedSynchronously
	@property
	def is_completed(self) -> bool:
		return self._instance.IsCompleted
