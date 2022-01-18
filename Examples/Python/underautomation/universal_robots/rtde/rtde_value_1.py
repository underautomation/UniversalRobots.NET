import typing
from underautomation.universal_robots.rtde.rtde_value import RtdeValue
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Rtde import RtdeValue as rtde_value_1

class RtdeValue1(RtdeValue):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = rtde_value_1()
		else:
			self._instance = _internal
	def __repr__(self):
		return self._instance.ToString()
	@property
	def value(self) -> typing.Any:
		return self._instance.Value
