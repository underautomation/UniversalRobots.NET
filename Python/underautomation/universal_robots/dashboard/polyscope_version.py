import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Dashboard import PolyscopeVersion as polyscope_version

class PolyscopeVersion:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = polyscope_version()
		else:
			self._instance = _internal
	def __repr__(self):
		return self._instance.ToString()
	@property
	def date(self) -> str:
		return self._instance.Date
	@date.setter
	def date(self, value: str):
		self._instance.Date = value
	@property
	def version(self) -> typing.Any:
		return self._instance.Version
	@version.setter
	def version(self, value: typing.Any):
		self._instance.Version = value
	@property
	def description(self) -> str:
		return self._instance.Description
	@description.setter
	def description(self, value: str):
		self._instance.Description = value
