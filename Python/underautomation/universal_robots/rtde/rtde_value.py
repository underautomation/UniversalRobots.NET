import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Rtde import RtdeValue as rtde_value

class RtdeValue:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = rtde_value()
		else:
			self._instance = _internal
	@property
	def value(self) -> typing.Any:
		return self._instance.Value
