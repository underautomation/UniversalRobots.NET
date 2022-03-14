import typing
from underautomation.universal_robots.rtde.rtde_data_description_1 import RtdeDataDescription1
from underautomation.universal_robots.rtde.rtde_input_data import RtdeInputData
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Rtde import RtdeInputDataDescription as rtde_input_data_description

class RtdeInputDataDescription(RtdeDataDescription1[RtdeInputData]):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = rtde_input_data_description()
		else:
			self._instance = _internal
