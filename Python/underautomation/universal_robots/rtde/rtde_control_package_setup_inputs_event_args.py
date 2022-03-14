import typing
from underautomation.universal_robots.common.package_event_args import PackageEventArgs
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Rtde import RtdeControlPackageSetupInputsEventArgs as rtde_control_package_setup_inputs_event_args

class RtdeControlPackageSetupInputsEventArgs(PackageEventArgs):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = rtde_control_package_setup_inputs_event_args()
		else:
			self._instance = _internal
	@property
	def input_recipe_id(self) -> int:
		return self._instance.InputRecipeId
	@input_recipe_id.setter
	def input_recipe_id(self, value: int):
		self._instance.InputRecipeId = value
	@property
	def variable_types(self) -> typing.List[str]:
		return self._instance.VariableTypes
	@variable_types.setter
	def variable_types(self, value: typing.List[str]):
		self._instance.VariableTypes = value
