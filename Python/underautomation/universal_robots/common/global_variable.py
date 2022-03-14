import typing
from underautomation.universal_robots.common.global_variable_value import GlobalVariableValue
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Common import GlobalVariable as global_variable

class GlobalVariable(GlobalVariableValue):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = global_variable()
		else:
			self._instance = _internal
	@property
	def name(self) -> str:
		return self._instance.Name
	@property
	def time(self) -> typing.Any:
		return self._instance.Time
