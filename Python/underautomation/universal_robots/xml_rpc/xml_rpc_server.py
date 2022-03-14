import typing
from underautomation.universal_robots.xml_rpc.internal.xml_rpc_server_base import XmlRpcServerBase
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.XmlRpc import XmlRpcServer as xml_rpc_server

class XmlRpcServer(XmlRpcServerBase):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = xml_rpc_server()
		else:
			self._instance = _internal
