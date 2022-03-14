import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.SocketCommunication import SocketClient as socket_client

class SocketClient:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = socket_client()
		else:
			self._instance = _internal
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
	def disconnect(self) -> None:
		self._instance.Disconnect()
	def socket_write(self, message: str) -> None:
		self._instance.SocketWrite(message)
	@property
	def connected(self) -> bool:
		return self._instance.Connected
	@property
	def end_point(self) -> typing.Any:
		return self._instance.EndPoint
