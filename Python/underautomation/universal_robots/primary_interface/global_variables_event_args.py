import typing
from underautomation.universal_robots.common.global_variable import GlobalVariable
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.PrimaryInterface import GlobalVariablesEventArgs as global_variables_event_args

class GlobalVariablesEventArgs:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = global_variables_event_args()
		else:
			self._instance = _internal
	@property
	def variables(self) -> typing.List[GlobalVariable]:
		return [GlobalVariable(x) for x in self._instance.Variables]
