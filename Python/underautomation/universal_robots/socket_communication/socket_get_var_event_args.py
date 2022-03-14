import typing
from underautomation.universal_robots.socket_communication.socket_client import SocketClient
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.SocketCommunication import SocketGetVarEventArgs as socket_get_var_event_args

class SocketGetVarEventArgs:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = socket_get_var_event_args()
		else:
			self._instance = _internal
	@property
	def client(self) -> SocketClient:
		return SocketClient(self._instance.Client)
	@property
	def name(self) -> str:
		return self._instance.Name
	@property
	def value(self) -> typing.Any:
		return self._instance.Value
	@value.setter
	def value(self, value: typing.Any):
		self._instance.Value = value
