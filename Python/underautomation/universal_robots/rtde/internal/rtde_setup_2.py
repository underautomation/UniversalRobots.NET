import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Rtde.Internal import RtdeSetup as rtde_setup_2

T = typing.TypeVar('T')
U = typing.TypeVar('U')
class RtdeSetup2(typing.Generic[T, U]):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = rtde_setup_2()
		else:
			self._instance = _internal
	def add(self, data: U, index: int=0) -> T:
		return self._instance.Add(data, index)
	def remove(self, data: U, index: int=-1) -> int:
		return self._instance.Remove(data, index)
	def contains(self, data: U, index: int=0) -> bool:
		return self._instance.Contains(data, index)
	def to_distinct_list(self) -> typing.Any:
		return self._instance.ToDistinctList()
