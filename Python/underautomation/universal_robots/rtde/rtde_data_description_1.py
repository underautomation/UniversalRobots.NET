import typing
from underautomation.universal_robots.rtde.rtde_types import RtdeTypes
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Rtde import RtdeDataDescription as rtde_data_description_1

T = typing.TypeVar('T')
class RtdeDataDescription1(typing.Generic[T]):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = rtde_data_description_1()
		else:
			self._instance = _internal
	@property
	def data(self) -> T:
		return self._instance.Data
	@property
	def type(self) -> RtdeTypes:
		return RtdeTypes(self._instance.Type)
	@property
	def name(self) -> str:
		return self._instance.Name
	@property
	def description(self) -> str:
		return self._instance.Description
	@property
	def lower_index(self) -> int:
		return self._instance.LowerIndex
	@property
	def array_size(self) -> int:
		return self._instance.ArraySize
	@property
	def is_array(self) -> bool:
		return self._instance.IsArray
