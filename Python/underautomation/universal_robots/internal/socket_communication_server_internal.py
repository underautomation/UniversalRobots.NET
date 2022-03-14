import typing
from underautomation.universal_robots.socket_communication.internal.socket_communication_server_base import SocketCommunicationServerBase
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Internal import SocketCommunicationServerInternal as socket_communication_server_internal

class SocketCommunicationServerInternal(SocketCommunicationServerBase):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = socket_communication_server_internal()
		else:
			self._instance = _internal
