import typing
from underautomation.universal_robots.common.global_variable_types import GlobalVariableTypes
from underautomation.universal_robots.common.pose import Pose
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Common import GlobalVariableValue as global_variable_value

class GlobalVariableValue:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = global_variable_value()
		else:
			self._instance = _internal
	def __repr__(self):
		return self._instance.ToString()
	def to_list(self) -> typing.List['GlobalVariableValue']:
		return [GlobalVariableValue(x) for x in self._instance.ToList()]
	def to_pose(self) -> Pose:
		return Pose(None, None, None, None, None, None, self._instance.ToPose())
	def to_bool(self) -> bool:
		return self._instance.ToBool()
	def to_int(self) -> int:
		return self._instance.ToInt()
	def to_float(self) -> float:
		return self._instance.ToFloat()
	def to_matrix(self) -> typing.Any:
		return self._instance.ToMatrix()
	@staticmethod
	def parse(message: str) -> 'GlobalVariableValue':
		return GlobalVariableValue(global_variable_value.Parse(message))
	@property
	def type(self) -> GlobalVariableTypes:
		return GlobalVariableTypes(self._instance.Type)
	@property
	def value(self) -> typing.Any:
		return self._instance.Value
