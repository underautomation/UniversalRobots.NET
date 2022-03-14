import typing
from underautomation.universal_robots.rtde.rtde_versions import RtdeVersions
from underautomation.universal_robots.rtde.rtde_basic_request_event_args import RtdeBasicRequestEventArgs
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Rtde import RtdeProtocolVersionEventArgs as rtde_protocol_version_event_args

class RtdeProtocolVersionEventArgs(RtdeBasicRequestEventArgs):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = rtde_protocol_version_event_args()
		else:
			self._instance = _internal
	@property
	def version(self) -> RtdeVersions:
		return RtdeVersions(self._instance.Version)
	@version.setter
	def version(self, value: RtdeVersions):
		self._instance.Version = value
