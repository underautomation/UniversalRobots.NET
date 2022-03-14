import typing
from underautomation.universal_robots.common.package_event_args import PackageEventArgs
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Rtde import RtdeBasicRequestEventArgs as rtde_basic_request_event_args

class RtdeBasicRequestEventArgs(PackageEventArgs):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = rtde_basic_request_event_args()
		else:
			self._instance = _internal
	@property
	def accepted(self) -> bool:
		return self._instance.Accepted
	@accepted.setter
	def accepted(self, value: bool):
		self._instance.Accepted = value
