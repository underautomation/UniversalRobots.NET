import typing
from underautomation.universal_robots.xml_rpc.xml_rpc_event_arg import XmlRpcEventArg
from underautomation.universal_robots.internal.urservice_base import URServiceBase
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.XmlRpc.Internal import XmlRpcServerBase as xml_rpc_server_base

class XmlRpcServerBase(URServiceBase):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = xml_rpc_server_base()
		else:
			self._instance = _internal
	def xml_rpc_server_request(self, handler):
		self._instance.XmlRpcServerRequest+= lambda sender, request : handler(sender, XmlRpcEventArg(request))
	def start(self, port: int) -> None:
		self._instance.Start(port)
	def stop(self) -> None:
		self._instance.Stop()
	def add__xml_rpc_server_request(self, value: typing.Any) -> None:
		self._instance.add_XmlRpcServerRequest(value)
	def remove__xml_rpc_server_request(self, value: typing.Any) -> None:
		self._instance.remove_XmlRpcServerRequest(value)
	@property
	def enabled(self) -> bool:
		return self._instance.Enabled
	@property
	def port(self) -> int:
		return self._instance.Port
