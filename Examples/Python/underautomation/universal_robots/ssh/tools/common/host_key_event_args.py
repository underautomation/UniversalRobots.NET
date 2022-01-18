import typing
from underautomation.universal_robots.ssh.tools.security.key_host_algorithm import KeyHostAlgorithm
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Common import HostKeyEventArgs as host_key_event_args

class HostKeyEventArgs:
	def __init__(self, host: KeyHostAlgorithm, _internal = 0):
		if(_internal == 0):
			self._instance = host_key_event_args(host)
		else:
			self._instance = _internal
	@property
	def can_trust(self) -> bool:
		return self._instance.CanTrust
	@can_trust.setter
	def can_trust(self, value: bool):
		self._instance.CanTrust = value
	@property
	def host_key(self) -> int:
		return self._instance.HostKey
	@property
	def host_key_name(self) -> str:
		return self._instance.HostKeyName
	@property
	def finger_print(self) -> int:
		return self._instance.FingerPrint
	@property
	def key_length(self) -> int:
		return self._instance.KeyLength
