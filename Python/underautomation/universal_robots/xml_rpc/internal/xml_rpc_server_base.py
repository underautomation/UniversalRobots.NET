import typing
from underautomation.universal_robots.internal.ur_service_base import URServiceBase
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.XmlRpc.Internal import XmlRpcServerBase as xml_rpc_server_base

class XmlRpcServerBase(URServiceBase):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = xml_rpc_server_base()
		else:
			self._instance = _internal
	def xml_rpc_server_request(self, handler):
		class Wrapper :
			def __init__(self, _internal):
				self._instance = _internal
		self._instance.XmlRpcServerRequest+= lambda sender, request : handler(Wrapper(sender), Wrapper(request))
	def start(self, port: int) -> None:
		self._instance.Start(port)
	def stop(self) -> None:
		self._instance.Stop()
	@property
	def enabled(self) -> bool:
		return self._instance.Enabled
	@property
	def port(self) -> int:
		return self._instance.Port
