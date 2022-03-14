import typing
from underautomation.universal_robots.rtde.internal.rtde_setup_2 import RtdeSetup2
from underautomation.universal_robots.rtde.rtde_output_setup_item import RtdeOutputSetupItem
from underautomation.universal_robots.rtde.rtde_output_data import RtdeOutputData
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Rtde import RtdeOutputSetup as rtde_output_setup

class RtdeOutputSetup(RtdeSetup2[RtdeOutputSetupItem, RtdeOutputData]):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = rtde_output_setup()
		else:
			self._instance = _internal
