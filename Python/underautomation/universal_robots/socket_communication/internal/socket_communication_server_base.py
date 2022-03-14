import typing
from underautomation.universal_robots.socket_communication.socket_client import SocketClient
from underautomation.universal_robots.internal.ur_service_base import URServiceBase
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.SocketCommunication.Internal import SocketCommunicationServerBase as socket_communication_server_base

class SocketCommunicationServerBase(URServiceBase):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = socket_communication_server_base()
		else:
			self._instance = _internal
	def socket_client_connection(self, handler):
		class Wrapper :
			def __init__(self, _internal):
				self._instance = _internal
		self._instance.SocketClientConnection+= lambda sender, request : handler(Wrapper(sender), Wrapper(request))
	def socket_get_var(self, handler):
		class Wrapper :
			def __init__(self, _internal):
				self._instance = _internal
		self._instance.SocketGetVar+= lambda sender, request : handler(Wrapper(sender), Wrapper(request))
	def socket_request(self, handler):
		class Wrapper :
			def __init__(self, _internal):
				self._instance = _internal
		self._instance.SocketRequest+= lambda sender, request : handler(Wrapper(sender), Wrapper(request))
	def socket_client_disconnection(self, handler):
		class Wrapper :
			def __init__(self, _internal):
				self._instance = _internal
		self._instance.SocketClientDisconnection+= lambda sender, request : handler(Wrapper(sender), Wrapper(request))
	def start(self, port: int) -> None:
		self._instance.Start(port)
	def stop(self) -> None:
		self._instance.Stop()
	def socket_write(self, message: str) -> None:
		self._instance.SocketWrite(message)
	@property
	def connected_clients(self) -> typing.List[SocketClient]:
		return [SocketClient(x) for x in self._instance.ConnectedClients]
	@property
	def enabled(self) -> bool:
		return self._instance.Enabled
	@property
	def port(self) -> int:
		return self._instance.Port
