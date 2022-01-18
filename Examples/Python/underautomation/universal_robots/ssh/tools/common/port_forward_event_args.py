import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Common import PortForwardEventArgs as port_forward_event_args

class PortForwardEventArgs:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = port_forward_event_args()
		else:
			self._instance = _internal
	@property
	def originator_host(self) -> str:
		return self._instance.OriginatorHost
	@property
	def originator_port(self) -> int:
		return self._instance.OriginatorPort
