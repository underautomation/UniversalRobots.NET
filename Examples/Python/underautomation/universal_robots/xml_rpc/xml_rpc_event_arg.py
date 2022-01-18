import typing
from underautomation.universal_robots.xml_rpc.xml_rpc_value import XmlRpcValue
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.XmlRpc import XmlRpcEventArg as xml_rpc_event_arg

class XmlRpcEventArg:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = xml_rpc_event_arg()
		else:
			self._instance = _internal
