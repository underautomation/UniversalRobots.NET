import typing
from underautomation.universal_robots.xml_rpc.xml_rpc_type import XmlRpcType
from underautomation.universal_robots.xml_rpc.xml_rpc_value import XmlRpcValue
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.XmlRpc import XmlRpcUnknownValue as xml_rpc_unknown_value

class XmlRpcUnknownValue(XmlRpcValue):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = xml_rpc_unknown_value()
		else:
			self._instance = _internal
	@property
	def type(self) -> XmlRpcType:
		return XmlRpcType(self._instance.Type)
	@property
	def additional_information(self) -> str:
		return self._instance.AdditionalInformation
