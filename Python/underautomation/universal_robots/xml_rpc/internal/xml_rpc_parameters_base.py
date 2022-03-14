import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.XmlRpc.Internal import XmlRpcParametersBase as xml_rpc_parameters_base

class XmlRpcParametersBase:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = xml_rpc_parameters_base()
		else:
			self._instance = _internal
	@property
	def port(self) -> int:
		return self._instance.Port
	@port.setter
	def port(self, value: int):
		self._instance.Port = value
