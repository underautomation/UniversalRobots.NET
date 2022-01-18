import typing
from underautomation.universal_robots.rtde.rtde_value_1 import RtdeValue1
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Rtde import RtdeRegistersValue as rtde_registers_value_1

class RtdeRegistersValue1(RtdeValue1):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = rtde_registers_value_1()
		else:
			self._instance = _internal
	def set_value(self, index: int, value: typing.Any) -> None:
		self._instance.SetValue(index, value)
	def get_value(self, index: int) -> typing.Any:
		return self._instance.GetValue(index)
	@property
	def lower_range_index(self) -> int:
		return self._instance.LowerRangeIndex
