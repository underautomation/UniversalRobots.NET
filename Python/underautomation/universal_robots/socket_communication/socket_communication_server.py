import typing
from underautomation.universal_robots.socket_communication.internal.socket_communication_server_base import SocketCommunicationServerBase
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.SocketCommunication import SocketCommunicationServer as socket_communication_server

class SocketCommunicationServer(SocketCommunicationServerBase):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = socket_communication_server()
		else:
			self._instance = _internal
