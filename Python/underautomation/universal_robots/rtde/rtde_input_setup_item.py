import typing
from underautomation.universal_robots.rtde.rtde_input_data import RtdeInputData
from underautomation.universal_robots.rtde.rtde_data_description_1 import RtdeDataDescription1
from underautomation.universal_robots.rtde.internal.rtde_setup_item_1 import RtdeSetupItem1
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Rtde import RtdeInputSetupItem as rtde_input_setup_item

class RtdeInputSetupItem(RtdeSetupItem1[RtdeInputData]):
	def __init__(self, data: RtdeInputData, index: int, _internal = 0):
		if(_internal == 0):
			self._instance = rtde_input_setup_item(data, index)
		else:
			self._instance = _internal
	@property
	def description(self) -> RtdeDataDescription1[RtdeInputData]:
		return RtdeDataDescription1[RtdeInputData](self._instance.Description)
