import typing
from underautomation.universal_robots.rtde.rtde_base_values import RtdeBaseValues
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Rtde import RtdeBaseValues as rtde_base_values_1

T = typing.TypeVar('T')
class RtdeBaseValues1(RtdeBaseValues, typing.Generic[T]):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = rtde_base_values_1()
		else:
			self._instance = _internal
	def get_value(self, data: T, index: int) -> typing.Any:
		return self._instance.GetValue(data, index)
