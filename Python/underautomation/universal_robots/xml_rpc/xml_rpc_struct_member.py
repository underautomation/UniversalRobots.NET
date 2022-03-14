import typing
from underautomation.universal_robots.xml_rpc.xml_rpc_value import XmlRpcValue
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.XmlRpc import XmlRpcStructMember as xml_rpc_struct_member

class XmlRpcStructMember:
	def __init__(self, name: str, value: XmlRpcValue, _internal = 0):
		if(_internal == 0):
			self._instance = xml_rpc_struct_member(name, value)
		else:
			self._instance = _internal
	def __repr__(self):
		return self._instance.ToString()
	@property
	def name(self) -> str:
		return self._instance.Name
	@name.setter
	def name(self, value: str):
		self._instance.Name = value
	@property
	def value(self) -> XmlRpcValue:
		return XmlRpcValue(self._instance.Value)
	@value.setter
	def value(self, value: XmlRpcValue):
		self._instance.Value = value
