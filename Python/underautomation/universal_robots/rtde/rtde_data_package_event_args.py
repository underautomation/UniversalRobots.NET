import typing
from underautomation.universal_robots.rtde.rtde_output_values import RtdeOutputValues
from underautomation.universal_robots.common.package_event_args import PackageEventArgs
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Rtde import RtdeDataPackageEventArgs as rtde_data_package_event_args

class RtdeDataPackageEventArgs(PackageEventArgs):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = rtde_data_package_event_args()
		else:
			self._instance = _internal
	@property
	def output_recipe_id(self) -> int:
		return self._instance.OutputRecipeId
	@output_recipe_id.setter
	def output_recipe_id(self, value: int):
		self._instance.OutputRecipeId = value
	@property
	def output_data_values(self) -> RtdeOutputValues:
		return RtdeOutputValues(self._instance.OutputDataValues)
	@output_data_values.setter
	def output_data_values(self, value: RtdeOutputValues):
		self._instance.OutputDataValues = value
	@property
	def measured_frequency(self) -> float:
		return self._instance.MeasuredFrequency
	@measured_frequency.setter
	def measured_frequency(self, value: float):
		self._instance.MeasuredFrequency = value
