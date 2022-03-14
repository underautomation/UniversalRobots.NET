import typing
from underautomation.universal_robots.common.package_event_args import PackageEventArgs
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.PrimaryInterface import SafetyDataPackageEventArgs as safety_data_package_event_args

class SafetyDataPackageEventArgs(PackageEventArgs):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = safety_data_package_event_args()
		else:
			self._instance = _internal
	@property
	def data(self) -> typing.List[int]:
		return self._instance.Data
	@data.setter
	def data(self, value: typing.List[int]):
		self._instance.Data = value
