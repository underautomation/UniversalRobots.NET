import typing
from underautomation.universal_robots.rtde.rtde_value import RtdeValue
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Rtde import RtdeBaseValues as rtde_base_values

class RtdeBaseValues:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = rtde_base_values()
		else:
			self._instance = _internal
	@property
	def values(self) -> typing.List[RtdeValue]:
		return [RtdeValue(x) for x in self._instance.Values]
