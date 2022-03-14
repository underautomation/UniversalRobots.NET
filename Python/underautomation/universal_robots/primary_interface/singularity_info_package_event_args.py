import typing
from underautomation.universal_robots.common.package_event_args import PackageEventArgs
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.PrimaryInterface import SingularityInfoPackageEventArgs as singularity_info_package_event_args

class SingularityInfoPackageEventArgs(PackageEventArgs):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = singularity_info_package_event_args()
		else:
			self._instance = _internal
	@property
	def singularity_severity(self) -> int:
		return self._instance.SingularitySeverity
	@singularity_severity.setter
	def singularity_severity(self, value: int):
		self._instance.SingularitySeverity = value
	@property
	def singularity_type(self) -> int:
		return self._instance.SingularityType
	@singularity_type.setter
	def singularity_type(self, value: int):
		self._instance.SingularityType = value
