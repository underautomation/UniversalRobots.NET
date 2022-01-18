import typing
from underautomation.universal_robots.ssh.tools.forwarded_port import ForwardedPort
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools import ForwardedPortRemote as forwarded_port_remote

class ForwardedPortRemote(ForwardedPort):
	def __init__(self, boundHostAddress: typing.Any, boundPort: int, hostAddress: typing.Any, port: int, _internal = 0):
		if(_internal == 0):
			self._instance = forwarded_port_remote(boundHostAddress, boundPort, hostAddress, port)
		else:
			self._instance = _internal
	def dispose(self) -> None:
		self._instance.Dispose()
	@property
	def is_started(self) -> bool:
		return self._instance.IsStarted
	@property
	def bound_host_address(self) -> typing.Any:
		return self._instance.BoundHostAddress
	@property
	def bound_host(self) -> str:
		return self._instance.BoundHost
	@property
	def bound_port(self) -> int:
		return self._instance.BoundPort
	@property
	def host_address(self) -> typing.Any:
		return self._instance.HostAddress
	@property
	def host(self) -> str:
		return self._instance.Host
	@property
	def port(self) -> int:
		return self._instance.Port
