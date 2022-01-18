import typing
from underautomation.universal_robots.rtde.rtde_data_description_1 import RtdeDataDescription1
from underautomation.universal_robots.rtde.rtde_types import RtdeTypes
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Rtde.Internal import RtdeSetupItem as rtde_setup_item_1

class RtdeSetupItem1:
	def __init__(self, data: typing.Any, index: int, _internal = 0):
		if(_internal == 0):
			self._instance = rtde_setup_item_1(data, index)
		else:
			self._instance = _internal
	def __repr__(self):
		return self._instance.ToString()
	@property
	def index(self) -> int:
		return self._instance.Index
	@index.setter
	def index(self, value: int):
		self._instance.Index = value
	@property
	def data(self) -> typing.Any:
		return self._instance.Data
	@data.setter
	def data(self, value: typing.Any):
		self._instance.Data = value
	@property
	def description(self) -> RtdeDataDescription1:
		return RtdeDataDescription1(self._instance.Description)
	@property
	def name(self) -> str:
		return self._instance.Name
	@property
	def type(self) -> RtdeTypes:
		return RtdeTypes(self._instance.Type)
	@property
	def protocol_type(self) -> str:
		return self._instance.ProtocolType
