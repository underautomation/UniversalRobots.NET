import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Common import AsyncResult as async_result

class AsyncResult:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = async_result()
		else:
			self._instance = _internal
	def set_as_completed(self, exception: typing.Any, completedSynchronously: bool) -> None:
		self._instance.SetAsCompleted(exception, completedSynchronously)
	@property
	def end_invoke_called(self) -> bool:
		return self._instance.EndInvokeCalled
	@property
	def async_state(self) -> typing.Any:
		return self._instance.AsyncState
	@property
	def completed_synchronously(self) -> bool:
		return self._instance.CompletedSynchronously
	@property
	def async_wait_handle(self) -> typing.Any:
		return self._instance.AsyncWaitHandle
	@property
	def is_completed(self) -> bool:
		return self._instance.IsCompleted
