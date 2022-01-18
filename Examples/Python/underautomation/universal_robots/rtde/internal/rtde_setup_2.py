import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Rtde.Internal import RtdeSetup as rtde_setup_2

class RtdeSetup2:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = rtde_setup_2()
		else:
			self._instance = _internal
	def add(self, data: typing.Any) -> typing.Any:
		return self._instance.Add(data)
	def add(self, data: typing.Any, index: int=0) -> typing.Any:
		return self._instance.Add(data, index)
	def contains(self, data: typing.Any, index: int=0) -> bool:
		return self._instance.Contains(data, index)
	def contains(self, data: typing.Any) -> bool:
		return self._instance.Contains(data)
	def to_distinct_list(self) -> typing.Any:
		return self._instance.ToDistinctList()
