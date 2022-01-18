import typing
from underautomation.universal_robots.ssh.tools.common.async_result_1 import AsyncResult1
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools import ExpectAsyncResult as expect_async_result

class ExpectAsyncResult(AsyncResult1):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = expect_async_result()
		else:
			self._instance = _internal
