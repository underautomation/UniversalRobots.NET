import typing
from underautomation.universal_robots.primary_interface.package_unit import PackageUnit
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.PrimaryInterface import PackageDescriptionAttribute as package_description_attribute

class PackageDescriptionAttribute:
	def __init__(self, description: str, unit: PackageUnit, _internal = 0):
		if(_internal == 0):
			self._instance = package_description_attribute(description, unit)
		else:
			self._instance = _internal
	@property
	def unit(self) -> PackageUnit:
		return PackageUnit(self._instance.Unit)
