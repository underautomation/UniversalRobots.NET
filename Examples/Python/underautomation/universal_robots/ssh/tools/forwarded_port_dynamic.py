import typing
from underautomation.universal_robots.ssh.tools.forwarded_port import ForwardedPort
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools import ForwardedPortDynamic as forwarded_port_dynamic

class ForwardedPortDynamic(ForwardedPort):
	def __init__(self, host: str, port: int, _internal = 0):
		if(_internal == 0):
			self._instance = forwarded_port_dynamic(host, port)
		else:
			self._instance = _internal
	def dispose(self) -> None:
		self._instance.Dispose()
	@property
	def bound_host(self) -> str:
		return self._instance.BoundHost
	@property
	def bound_port(self) -> int:
		return self._instance.BoundPort
	@property
	def is_started(self) -> bool:
		return self._instance.IsStarted
