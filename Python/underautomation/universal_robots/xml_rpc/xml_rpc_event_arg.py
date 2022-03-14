import typing
from underautomation.universal_robots.xml_rpc.xml_rpc_value import XmlRpcValue
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.XmlRpc import XmlRpcEventArg as xml_rpc_event_arg

class XmlRpcEventArg:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = xml_rpc_event_arg()
		else:
			self._instance = _internal
	@property
	def xml_request(self) -> typing.Any:
		return self._instance.XmlRequest
	@property
	def method_name(self) -> str:
		return self._instance.MethodName
	@property
	def arguments(self) -> typing.List[XmlRpcValue]:
		return [XmlRpcValue(x) for x in self._instance.Arguments]
	@property
	def end_point(self) -> typing.Any:
		return self._instance.EndPoint
	@property
	def answer(self) -> XmlRpcValue:
		return XmlRpcValue(self._instance.Answer)
	@answer.setter
	def answer(self, value: XmlRpcValue):
		self._instance.Answer = value
