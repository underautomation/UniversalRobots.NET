import typing
from underautomation.universal_robots.primary_interface.global_variables_firmware_version import GlobalVariablesFirmwareVersion
from underautomation.universal_robots.common.global_variable import GlobalVariable
from underautomation.universal_robots.primary_interface.global_variables_event_args import GlobalVariablesEventArgs
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.PrimaryInterface import GlobalVariables as global_variables

class GlobalVariables:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = global_variables()
		else:
			self._instance = _internal
	def values_updated(self, handler):
		class Wrapper :
			def __init__(self, _internal):
				self._instance = _internal
		self._instance.ValuesUpdated+= lambda sender, e : handler(Wrapper(sender), Wrapper(e))
	def list_updated(self, handler):
		class Wrapper :
			def __init__(self, _internal):
				self._instance = _internal
		self._instance.ListUpdated+= lambda sender, e : handler(Wrapper(sender), Wrapper(e))
	def get_all(self) -> typing.List[GlobalVariable]:
		return [GlobalVariable(x) for x in self._instance.GetAll()]
	def get_by_name(self, name: str) -> GlobalVariable:
		return GlobalVariable(self._instance.GetByName(name))
	def __repr__(self):
		return self._instance.ToString()
	@property
	def firmware_version(self) -> GlobalVariablesFirmwareVersion:
		return GlobalVariablesFirmwareVersion(self._instance.FirmwareVersion)
