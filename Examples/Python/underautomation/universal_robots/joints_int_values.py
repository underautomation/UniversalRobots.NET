import typing
from underautomation.universal_robots.joints_values_1 import JointsValues1
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots import JointsIntValues as joints_int_values

class JointsIntValues(JointsValues1):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = joints_int_values()
		else:
			self._instance = _internal
