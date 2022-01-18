import typing
from underautomation.universal_robots.xml_rpc.xml_rpc_type import XmlRpcType
from underautomation.universal_robots.pose import Pose
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.XmlRpc import XmlRpcValue as xml_rpc_value

class XmlRpcValue:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = xml_rpc_value()
		else:
			self._instance = _internal
	@staticmethod
	def op__implicit(value: float) -> 'XmlRpcValue':
		return xml_rpc_value.op_Implicit(value)
	@staticmethod
	def op__implicit(value: bool) -> 'XmlRpcValue':
		return xml_rpc_value.op_Implicit(value)
	@staticmethod
	def op__implicit(value: int) -> 'XmlRpcValue':
		return xml_rpc_value.op_Implicit(value)
	@staticmethod
	def op__implicit(value: str) -> 'XmlRpcValue':
		return xml_rpc_value.op_Implicit(value)
	@staticmethod
	def op__implicit(value: Pose) -> 'XmlRpcValue':
		return xml_rpc_value.op_Implicit(value._instance)
	@staticmethod
	def op__implicit(value: 'XmlRpcValue') -> 'XmlRpcValue':
		return xml_rpc_value.op_Implicit(value._instance)
	@staticmethod
	def op__implicit(value: float) -> 'XmlRpcValue':
		return xml_rpc_value.op_Implicit(value)
	@staticmethod
	def op__implicit(value: int) -> 'XmlRpcValue':
		return xml_rpc_value.op_Implicit(value)
	@staticmethod
	def op__implicit(value: str) -> 'XmlRpcValue':
		return xml_rpc_value.op_Implicit(value)
	@staticmethod
	def op__implicit(value: Pose) -> 'XmlRpcValue':
		return xml_rpc_value.op_Implicit(value._instance)
	@staticmethod
	def op__implicit(value: bool) -> 'XmlRpcValue':
		return xml_rpc_value.op_Implicit(value)
	@staticmethod
	def op__implicit(value: 'XmlRpcValue') -> float:
		return xml_rpc_value.op_Implicit(value._instance)
	@staticmethod
	def op__implicit(value: 'XmlRpcValue') -> bool:
		return xml_rpc_value.op_Implicit(value._instance)
	@staticmethod
	def op__implicit(value: 'XmlRpcValue') -> int:
		return xml_rpc_value.op_Implicit(value._instance)
	@staticmethod
	def op__implicit(value: 'XmlRpcValue') -> str:
		return xml_rpc_value.op_Implicit(value._instance)
	@staticmethod
	def op__implicit(value: 'XmlRpcValue') -> Pose:
		return xml_rpc_value.op_Implicit(value._instance)
	@staticmethod
	def op__implicit(value: 'XmlRpcValue') -> int:
		return xml_rpc_value.op_Implicit(value._instance)
	@staticmethod
	def op__implicit(value: 'XmlRpcValue') -> float:
		return xml_rpc_value.op_Implicit(value._instance)
	@staticmethod
	def op__implicit(value: 'XmlRpcValue') -> Pose:
		return xml_rpc_value.op_Implicit(value._instance)
	@staticmethod
	def op__implicit(value: 'XmlRpcValue') -> str:
		return xml_rpc_value.op_Implicit(value._instance)
	@staticmethod
	def op__implicit(value: 'XmlRpcValue') -> bool:
		return xml_rpc_value.op_Implicit(value._instance)
	def __repr__(self):
		return self._instance.ToString()
	@property
	def type(self) -> XmlRpcType:
		return XmlRpcType(self._instance.Type)
	@property
	def xml(self) -> typing.Any:
		return self._instance.Xml
