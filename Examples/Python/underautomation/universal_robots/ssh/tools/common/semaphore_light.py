import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Common import SemaphoreLight as semaphore_light

class SemaphoreLight:
	def __init__(self, initialCount: int, _internal = 0):
		if(_internal == 0):
			self._instance = semaphore_light(initialCount)
		else:
			self._instance = _internal
	def release(self) -> int:
		return self._instance.Release()
	def release(self, releaseCount: int) -> int:
		return self._instance.Release(releaseCount)
	def wait(self) -> None:
		self._instance.Wait()
	def wait(self, millisecondsTimeout: int) -> bool:
		return self._instance.Wait(millisecondsTimeout)
	def wait(self, timeout: typing.Any) -> bool:
		return self._instance.Wait(timeout)
	def dispose(self) -> None:
		self._instance.Dispose()
	@property
	def current_count(self) -> int:
		return self._instance.CurrentCount
	@property
	def available_wait_handle(self) -> typing.Any:
		return self._instance.AvailableWaitHandle
