import typing
from underautomation.universal_robots.primary_interface.global_variables_firmware_version import GlobalVariablesFirmwareVersion
from underautomation.universal_robots.common.global_variable import GlobalVariable
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.PrimaryInterface import GlobalVariables as global_variables

class GlobalVariables:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = global_variables()
		else:
			self._instance = _internal
	def get_all(self) -> GlobalVariable:
		return GlobalVariable(self._instance.GetAll())
	def get_by_name(self, name: str) -> GlobalVariable:
		return GlobalVariable(self._instance.GetByName(name))
	def add__values_updated(self, value: typing.Any) -> None:
		self._instance.add_ValuesUpdated(value)
	def remove__values_updated(self, value: typing.Any) -> None:
		self._instance.remove_ValuesUpdated(value)
	def add__list_updated(self, value: typing.Any) -> None:
		self._instance.add_ListUpdated(value)
	def remove__list_updated(self, value: typing.Any) -> None:
		self._instance.remove_ListUpdated(value)
	def __repr__(self):
		return self._instance.ToString()
	@property
	def firmware_version(self) -> GlobalVariablesFirmwareVersion:
		return GlobalVariablesFirmwareVersion(self._instance.FirmwareVersion)
