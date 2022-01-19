import typing
from underautomation.universal_robots.ssh.tools.common.exception_event_args import ExceptionEventArgs
from underautomation.universal_robots.ssh.tools.common.port_forward_event_args import PortForwardEventArgs
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools import ForwardedPort as forwarded_port

class ForwardedPort:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = forwarded_port()
		else:
			self._instance = _internal
	def exception(self, handler):
		self._instance.Exception+= lambda sender, e : handler(sender, ExceptionEventArgs(None, e))
	def request_received(self, handler):
		self._instance.RequestReceived+= lambda sender, e : handler(sender, PortForwardEventArgs(e))
	def add__exception(self, value: typing.Any) -> None:
		self._instance.add_Exception(value)
	def remove__exception(self, value: typing.Any) -> None:
		self._instance.remove_Exception(value)
	def add__request_received(self, value: typing.Any) -> None:
		self._instance.add_RequestReceived(value)
	def remove__request_received(self, value: typing.Any) -> None:
		self._instance.remove_RequestReceived(value)
	def start(self) -> None:
		self._instance.Start()
	def stop(self) -> None:
		self._instance.Stop()
	@property
	def is_started(self) -> bool:
		return self._instance.IsStarted
