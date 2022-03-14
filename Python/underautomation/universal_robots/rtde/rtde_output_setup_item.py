import typing
from underautomation.universal_robots.rtde.rtde_output_data import RtdeOutputData
from underautomation.universal_robots.rtde.rtde_data_description_1 import RtdeDataDescription1
from underautomation.universal_robots.rtde.internal.rtde_setup_item_1 import RtdeSetupItem1
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Rtde import RtdeOutputSetupItem as rtde_output_setup_item

class RtdeOutputSetupItem(RtdeSetupItem1[RtdeOutputData]):
	def __init__(self, data: RtdeOutputData, index: int, _internal = 0):
		if(_internal == 0):
			self._instance = rtde_output_setup_item(data, index)
		else:
			self._instance = _internal
	@property
	def description(self) -> RtdeDataDescription1[RtdeOutputData]:
		return RtdeDataDescription1[RtdeOutputData](self._instance.Description)
