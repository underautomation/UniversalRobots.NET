import typing
from underautomation.universal_robots.ssh.tools.common.async_result import AsyncResult
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Common import AsyncResult as async_result_1

class AsyncResult1(AsyncResult):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = async_result_1()
		else:
			self._instance = _internal
	def set_as_completed(self, result: typing.Any, completedSynchronously: bool) -> None:
		self._instance.SetAsCompleted(result, completedSynchronously)
	def end_invoke(self) -> typing.Any:
		return self._instance.EndInvoke()
