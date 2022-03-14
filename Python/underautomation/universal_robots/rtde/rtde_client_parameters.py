import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Rtde import RtdeClientParameters as rtde_client_parameters

class RtdeClientParameters:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = rtde_client_parameters()
		else:
			self._instance = _internal
