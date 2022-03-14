import typing
from underautomation.universal_robots.xml_rpc.internal.xml_rpc_parameters_base import XmlRpcParametersBase
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Common import XmlRpcConnectParameters as xml_rpc_connect_parameters

class XmlRpcConnectParameters(XmlRpcParametersBase):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = xml_rpc_connect_parameters()
		else:
			self._instance = _internal
	@property
	def enable(self) -> bool:
		return self._instance.Enable
	@enable.setter
	def enable(self, value: bool):
		self._instance.Enable = value
