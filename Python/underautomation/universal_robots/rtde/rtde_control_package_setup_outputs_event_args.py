import typing
from underautomation.universal_robots.common.package_event_args import PackageEventArgs
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Rtde import RtdeControlPackageSetupOutputsEventArgs as rtde_control_package_setup_outputs_event_args

class RtdeControlPackageSetupOutputsEventArgs(PackageEventArgs):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = rtde_control_package_setup_outputs_event_args()
		else:
			self._instance = _internal
	@property
	def output_recipe_id(self) -> int:
		return self._instance.OutputRecipeId
	@output_recipe_id.setter
	def output_recipe_id(self, value: int):
		self._instance.OutputRecipeId = value
	@property
	def variable_types(self) -> typing.List[str]:
		return self._instance.VariableTypes
	@variable_types.setter
	def variable_types(self, value: typing.List[str]):
		self._instance.VariableTypes = value
