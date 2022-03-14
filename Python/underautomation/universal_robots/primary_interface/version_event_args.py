import typing
from underautomation.universal_robots.common.package_event_args import PackageEventArgs
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.PrimaryInterface import VersionEventArgs as version_event_args

class VersionEventArgs(PackageEventArgs):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = version_event_args()
		else:
			self._instance = _internal
	@property
	def project_name(self) -> str:
		return self._instance.ProjectName
	@project_name.setter
	def project_name(self, value: str):
		self._instance.ProjectName = value
	@property
	def major_version(self) -> int:
		return self._instance.MajorVersion
	@major_version.setter
	def major_version(self, value: int):
		self._instance.MajorVersion = value
	@property
	def minor_version(self) -> int:
		return self._instance.MinorVersion
	@minor_version.setter
	def minor_version(self, value: int):
		self._instance.MinorVersion = value
	@property
	def bugfix_version(self) -> int:
		return self._instance.BugfixVersion
	@bugfix_version.setter
	def bugfix_version(self, value: int):
		self._instance.BugfixVersion = value
	@property
	def build_number(self) -> int:
		return self._instance.BuildNumber
	@build_number.setter
	def build_number(self, value: int):
		self._instance.BuildNumber = value
	@property
	def build_date(self) -> str:
		return self._instance.BuildDate
	@build_date.setter
	def build_date(self, value: str):
		self._instance.BuildDate = value
	@property
	def version(self) -> typing.Any:
		return self._instance.Version
